using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 class clsTimeCardACM : IDisposable
 {
  public clsTimeCardACM() { }

  private string _strTransID;
  private DateTime _dteTDate;
  private DateTime _dteTTime;
  private string _strEventID;
  private string _strStaffID;
  private string _strDoor;

  public string TransID { get { return _strTransID; } set { _strTransID = value; } }
  public DateTime TDate { get { return _dteTDate; } set { _dteTDate = value; } }
  public DateTime TTime { get { return _dteTTime; } set { _dteTTime = value; } }
  public string EventID { get { return _strEventID; } set { _strEventID = value; } }
  public string StaffID { get { return _strStaffID; } set { _strStaffID = value; } }
  public string Door { get { return _strDoor; } set { _strDoor = value; } }

  public void Dispose() { GC.SuppressFinalize(this); }

  public void Fill()
  {
       using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
       {
        SqlCommand cmd = cn.CreateCommand();
        cmd.CommandText = "SELECT * FROM ACM.TimeCard WHERE transid='" + _strTransID + "'";
        cn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
         _dteTDate = clsValidator.CheckDate(dr["TDate"].ToString());
         _dteTTime = clsValidator.CheckDate(dr["TTime"].ToString());
         _strEventID = dr["EventID"].ToString();
         _strStaffID = dr["StaffID"].ToString();
         _strDoor = dr["Door"].ToString();
        }
        dr.Close();
   }
  }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable DSGTimeCardList(DateTime pFrom, DateTime pTo, string pUsername)
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("username");
   tblReturn.Columns.Add("empnum");
   tblReturn.Columns.Add("pname");
   tblReturn.Columns.Add("tdate", System.Type.GetType("System.DateTime"));
   tblReturn.Columns.Add("ttime", System.Type.GetType("System.DateTime"));
   tblReturn.Columns.Add("action");
   tblReturn.Columns.Add("door");

   string strEmployeeNumber = (pUsername == "ALL" ? "" : Employee.GetEmployeeNumber(pUsername));
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT StaffID,TDate,TTime,EventID,Door FROM ACM.TimeCard WHERE (TDate BETWEEN '" + pFrom + "' AND '" + pTo + "')" + (pUsername == "ALL" ? "" : " AND StaffID='" + strEmployeeNumber + "' ORDER BY TDATE");
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    int intCounter = 1;
    string strDate,strPreviousDate;
    strDate = "";
    strPreviousDate = "";
    while (dr.Read())
    {
     DataRow drw = tblReturn.NewRow();
     drw["username"] = pUsername;
     //drw["pname"] = Employee.GetName(pUsername, EmployeeNameFormat.LastFirst);
     drw["empnum"] = dr["StaffID"].ToString();
     drw["pname"] = Employee.GetName(dr["StaffID"].ToString(), EmployeeWhereParameter.EmployeeNumber);
     drw["tdate"] = clsValidator.CheckDate(dr["TDate"].ToString()).ToString("MMM dd, yyyy");
     drw["ttime"] = clsValidator.CheckDate(dr["TTime"].ToString());

     strPreviousDate = strDate;
     strDate = drw["tdate"].ToString();

     switch (dr["EventID"].ToString())
     {
         case "1":
             drw["action"] = "In";
             break;
         case "5":
             drw["action"] = "Out";
             break;
         case "":
             drw["action"] = "Out";
             break;
         default:
             drw["action"] = dr["EventID"].ToString();
             break;
     }

     drw["door"] = dr["Door"].ToString();
     tblReturn.Rows.Add(drw);
     intCounter++;
    }
    cn.Close();
    dr.Close();
   }
   return tblReturn;
  }        

  public static DataTable DSGTimeCardListFILO(DateTime pDateStart, DateTime pDateEnd, string pUsername)
  {
       DataTable tblReturn = new DataTable();
       tblReturn.Columns.Add("username");
       tblReturn.Columns.Add("empnum");
       tblReturn.Columns.Add("pname");
       tblReturn.Columns.Add("tdate", System.Type.GetType("System.DateTime"));
       tblReturn.Columns.Add("ttime", System.Type.GetType("System.DateTime"));
       tblReturn.Columns.Add("action");
       tblReturn.Columns.Add("door");

       string strEmployeeName = Employee.GetName(pUsername, EmployeeNameFormat.LastFirst);
            string strEmployeeNumber = Employee.GetEmployeeNumber(pUsername);
            string strTransIDTemp = "";
       DateTime dteTemp;
       //DateTime dteTempIn;
       //DateTime dteTempOut;
       using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
       {    
            for (dteTemp = clsDateTime.GetDateOnly(pDateStart); dteTemp <= pDateEnd; dteTemp = dteTemp.AddDays(1))
            {                 
                 strTransIDTemp = clsTimeCardACM.GetInTransactionID(pUsername, dteTemp);
                 if (strTransIDTemp != "")
                 {
                        using (clsTimeCardACM tacm = new clsTimeCardACM())
                        {
                            DataRow drwIn = tblReturn.NewRow();
                            drwIn["username"] = pUsername;
                            drwIn["empnum"] = strEmployeeNumber;
                            drwIn["pname"] = Employee.GetName(pUsername);
                            tacm.TransID = strTransIDTemp;
                            tacm.Fill();
                            drwIn["tdate"] = tacm.TDate;
                            drwIn["ttime"] = tacm.TTime;
                            switch (tacm.EventID)
                            {
                                case "1":
                                    drwIn["action"] = "In";
                                    break;
                                case "5":
                                    drwIn["action"] = "Out";
                                    break;
                                default:
                                    drwIn["action"] = tacm.EventID;
                                    break;
                            }
                            drwIn["door"] = tacm.Door;
                            tblReturn.Rows.Add(drwIn);
                        }                                               
                 }
                 strTransIDTemp = clsTimeCardACM.GetOutTransactionID(pUsername, dteTemp);
                 if (strTransIDTemp != "")
                 {
                        using (clsTimeCardACM tacm = new clsTimeCardACM())
                        {
                            DataRow drwIn = tblReturn.NewRow();
                            drwIn["username"] = pUsername;
                            drwIn["empnum"] = strEmployeeNumber;
                            drwIn["pname"] = Employee.GetName(pUsername);
                            tacm.TransID = strTransIDTemp;
                            tacm.Fill();
                            drwIn["tdate"] = tacm.TDate;
                            drwIn["ttime"] = tacm.TTime;
                            switch (tacm.EventID)
                            {
                                case "1":
                                    drwIn["action"] = "In";
                                    break;
                                case "5":
                                    drwIn["action"] = "Out";
                                    break;
                                default:
                                    drwIn["action"] = tacm.EventID;
                                    break;
                            }
                            drwIn["door"] = tacm.Door;
                            tblReturn.Rows.Add(drwIn);
                        }
                    }

            }
       }
       return tblReturn;
  }

  public static string GetAfterEventType(string pUsername, DateTime pFocusDate)
  {
   string strReturn = "";
   string strEmployeeNumber = Employee.GetEmployeeNumber(pUsername);
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 EventID FROM ACM.TimeCard WHERE StaffID='" + strEmployeeNumber + "' AND TDate > '" + pFocusDate + "' ORDER BY TDate,TTime DESC";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static DateTime GetFirstOut(string pUsername, DateTime pFocusDate)
  {
   DateTime dteReturn = clsDateTime.SystemMinDate;
   string strEmployeeNumber = Employee.GetEmployeeNumber(pUsername);
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 TTime FROM ACM.TimeCard WHERE StaffID='" + strEmployeeNumber + "' AND TDate > '" + pFocusDate + "' AND EventID='5' ORDER BY TDate,TTime";
    cn.Open();
    try { dteReturn = clsDateTime.CombineDateTime(pFocusDate, clsValidator.CheckDate(cmd.ExecuteScalar().ToString())); }
    catch { }
   }
   return dteReturn;
  }

  public static string GetAfterOutTransactionID(string pUsername, DateTime pFocusDate)
  {
   string strReturn = "";
   string strEmployeeNumber = Employee.GetEmployeeNumber(pUsername);
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 TransID FROM ACM.TimeCard WHERE StaffID='" + strEmployeeNumber + "' AND TDate > '" + pFocusDate + "' AND EventID='5' ORDER BY TDate,TTime DESC";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static DateTime GetIn(string pUsername, DateTime pFocusDate)
  {
   DateTime dteReturn = clsDateTime.SystemMinDate;
   string strEmployeeNumber = Employee.GetEmployeeNumber(pUsername);
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 TDate,TTime FROM ACM.TimeCard  WHERE StaffID='" + strEmployeeNumber + "' AND TDate='" + pFocusDate + "'  ORDER BY TTime";
    //cmd.CommandText = " SELECT TOP 1 focsdate AS TDate,keyin AS TTime FROM ACM.TimeCard WHERE focsdate='" + pFocusDate + "' AND username='" + pUsername + "' ORDER BY keyin ";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
     dteReturn = clsDateTime.CombineDateTime(clsValidator.CheckDate(dr["TDate"].ToString()), clsValidator.CheckDate(dr["TTime"].ToString()));
    dr.Close();
   }
   return dteReturn;
  }

  public static DateTime GetOut(string pUsername, DateTime pFocusDate)
  {
   DateTime dteReturn = clsDateTime.SystemMinDate;
   string strEmployeeNumber = Employee.GetEmployeeNumber(pUsername);
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 TDate,TTime FROM ACM.TimeCard WHERE StaffID='" + strEmployeeNumber + "' AND TDate='" + pFocusDate + "' ORDER BY TTime DESC";
    //cmd.CommandText = " SELECT TOP 1 focsdate AS TDate,keyout AS TTime FROM ACM.TimeCard WHERE focsdate='" + pFocusDate + "' AND username='" + pUsername + "' ORDER BY keyout DESC ";
       cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
     dteReturn = clsDateTime.CombineDateTime(clsValidator.CheckDate(dr["TDate"].ToString()), clsValidator.CheckDate(dr["TTime"].ToString()));
    dr.Close();

    if (dteReturn == clsDateTime.SystemMinDate && clsTimeCardACM.HasIn(pUsername, pFocusDate))
     dteReturn = clsTimeCardACM.GetFirstOut(pUsername, pFocusDate.AddDays(1));
   }
   return dteReturn;
  }

  public static string GetInTransactionID(string pUsername, DateTime pFocusDate)
  {
   string strReturn = "";
   string strEmployeeNumber = Employee.GetEmployeeNumber(pUsername);
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 TransID FROM ACM.TimeCard WHERE StaffID='" + strEmployeeNumber + "' AND TDate='" + pFocusDate + "' AND EventID='1' ORDER BY TTime";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
     strReturn = dr["TransID"].ToString();
    dr.Close();
   }
   return strReturn;
  }

  public static string GetOutTransactionID(string pUsername, DateTime pFocusDate)
  {
   string strReturn = "";
   string strEmployeeNumber = Employee.GetEmployeeNumber(pUsername);
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 TransID FROM ACM.TimeCard WHERE StaffID='" + strEmployeeNumber + "' AND TDate='" + pFocusDate + "' AND EventID='5' ORDER BY TTime DESC";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
     strReturn = dr["TransID"].ToString();
    dr.Close();

    if (strReturn == "" && clsTimeCardACM.HasIn(pUsername, pFocusDate))
    {
     if (clsTimeCardACM.GetAfterEventType(pUsername, pFocusDate) == "5")
      strReturn = clsTimeCardACM.GetAfterOutTransactionID(pUsername, pFocusDate);
    }
   }
   return strReturn;
  }

  //public static DataTable GetTimeCards(string pUsername, DateTime pFocusDate)
  //{
  // DataTable tblReturn = new DataTable();
  // tblReturn.Columns.Add("focsdate");
  // tblReturn.Columns.Add("keyin");
  // tblReturn.Columns.Add("keyout");
  // DataTable tblRawTimeCards = new DataTable();
  // string strEmployeeNumber = clsEmployee.GetEmployeeNumber(pUsername);
  // DateTime dteTempIn = clsDateTime.SystemMinDate;

  // using (SqlConnection cn = new SqlConnection(HRMSCore.ACMConnectionString))
  // {
  //  SqlCommand cmd = cn.CreateCommand();
  //  cmd.CommandText = "SELECT TDate,TTime,EventID FROM Transact WHERE StaffID='" + strEmployeeNumber + "' AND TDate='" + pFocusDate + "' ORDER BY TTime";
  //  SqlDataAdapter da = new SqlDataAdapter(cmd);
  //  da.Fill(tblRawTimeCards);
  // }

  // foreach (DataRow drw in tblRawTimeCards.Rows)
  // {

  // }

  // return tblReturn;
  //}

  public static bool HasIn(string pUsername, DateTime pFocusDate)
  {
   bool blnReturn = false;
   string strEmployeeNumber = Employee.GetEmployeeNumber(pUsername);
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
   // cmd.CommandText = " SELECT TTime FROM ACM.TimeCard WHERE focsdate='" + pFocusDate + "' AND username='" + pUsername + "'";
    cmd.CommandText = "SELECT TTime FROM ACM.TimeCard WHERE StaffID='" + strEmployeeNumber + "' AND TDate='" + pFocusDate + "' AND EventID='1'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
   return blnReturn;
  }

  public static bool HasOut(string pUsername, DateTime pFocusDate)
  {
   bool blnReturn = false;
   string strEmployeeNumber = Employee.GetEmployeeNumber(pUsername);
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    //cmd.CommandText = " SELECT  keyout FROM ACM.TimeCard WHERE focsdate='" + pFocusDate + "' AND username='" + pUsername + "'";
    cmd.CommandText = "SELECT TTime FROM ACM.TimeCard  WHERE StaffID='" + strEmployeeNumber + "' AND TDate='" + pFocusDate + "' AND EventID='5'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
   return blnReturn;
  }
 }
}
