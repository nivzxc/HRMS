using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 class LeaveApplicationTypes : IDisposable
 {
  private string _strLeaveTypeCode;
  private string _strLeaveType;
  private string _strWithPay;
  private float _fltMaximumBalance;
  private string _strHasBalance;
  private string _strStatus;

  public LeaveApplicationTypes() { }

  public string LeaveTypeCode { get { return _strLeaveTypeCode; } set { _strLeaveTypeCode = value; } }
  public string LeaveType { get { return _strLeaveType; } set { _strLeaveType = value; } }
  public string WithPay { get { return _strWithPay; } set { _strWithPay = value; } }
  public float MaximumBalance { get { return _fltMaximumBalance; } set { _fltMaximumBalance = value; } }
  public string HasBalance { get { return _strHasBalance; } set { _strHasBalance = value; } }
  public string Status { get { return _strStatus; } set { _strStatus = value; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.LeaveTypes WHERE leavtype='" + _strLeaveTypeCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strLeaveTypeCode = dr["leavtype"].ToString();
     _strLeaveType = dr["ltdesc"].ToString();
     _strWithPay = dr["withpay"].ToString();
     _fltMaximumBalance = clsValidator.CheckFloat((dr["maxbal"].ToString()));
     _strHasBalance = dr["hasbal"].ToString();
     _strStatus = dr["pstatus"].ToString();
    }
    dr.Close();
   }
  }

  public int Insert()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    _strLeaveTypeCode = GenerateCode();
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "INSERT INTO HR.LeaveTypes VALUES(@leavtype,@ltdesc,@withpay,@maxbal,@hasbal,'1')";
    cmd.Parameters.Add(new SqlParameter("@leavtype", _strLeaveTypeCode));
    cmd.Parameters.Add(new SqlParameter("@ltdesc", _strLeaveType));
    cmd.Parameters.Add(new SqlParameter("@withpay", _strWithPay));
    cmd.Parameters.Add(new SqlParameter("@maxbal", _fltMaximumBalance));
    cmd.Parameters.Add(new SqlParameter("@hasbal", _strHasBalance));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int Update()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.LeaveTypes SET ltdesc=@ltdesc, withpay=@withpay, maxbal=@maxbal, hasbal=@hasbal, pstatus=@pstatus WHERE leavtype=@leavtype";
    cmd.Parameters.Add(new SqlParameter("@leavtype", _strLeaveTypeCode));
    cmd.Parameters.Add(new SqlParameter("@ltdesc", _strLeaveType));
    cmd.Parameters.Add(new SqlParameter("@withpay", _strWithPay));
    cmd.Parameters.Add(new SqlParameter("@maxbal", _fltMaximumBalance));
    cmd.Parameters.Add(new SqlParameter("@hasbal", _strHasBalance));
    cmd.Parameters.Add(new SqlParameter("@pstatus", _strStatus));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int Delete()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "DELETE FROM HR.LeaveTypes WHERE leavtype='" + _strLeaveTypeCode + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////  
  //////////////////////////////////

  public static string GetDescription(string pLeaveTypeCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT ltdesc FROM HR.LeaveTypes WHERE leavtype=@leavtype";
    cmd.Parameters.Add(new SqlParameter("@leavtype", pLeaveTypeCode));
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static string GetMaxBalance(string pLeaveTypeCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT maxbal FROM HR.LeaveTypes WHERE leavtype='" + pLeaveTypeCode + "'";
    cn.Open();
    try
    { strReturn = cmd.ExecuteScalar().ToString(); }
    catch
    { }
   }
   return strReturn;
  }

  public static string GetWithPay(string pLeaveTypeCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT withpay FROM HR.LeaveTypes WHERE leavtype='" + pLeaveTypeCode + "'";
    cn.Open();
    try
    { strReturn = cmd.ExecuteScalar().ToString(); }
    catch
    { }
   }
   return strReturn;
  }

  public static string GetHasBalance(string pLeaveTypeCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT hasbal FROM HR.LeaveTypes WHERE leavtype='" + pLeaveTypeCode + "'";
    cn.Open();
    try
    { strReturn = cmd.ExecuteScalar().ToString(); }
    catch
    { }
   }
   return strReturn;
  }

  public static bool IsHasBalance(string pLeaveTypeCode)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT hasbal FROM HR.LeaveTypes WHERE leavtype='" + pLeaveTypeCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
     blnReturn = dr["hasbal"].ToString() == "1";
    dr.Close();
   }
   return blnReturn;
  }

  public static bool IsWithPay(string pLeaveType)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT withpay FROM HR.LeaveTypes WHERE leavtype='" + pLeaveType + "'";
    cn.Open();
    try
    { blnReturn = (cmd.ExecuteScalar().ToString() == "1"); }
    catch
    { blnReturn = false; }
   }
   return blnReturn;
  }

  public static DataTable DSGLeaveTypeList()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("leavtype");
   tblReturn.Columns.Add("ltdesc");
   tblReturn.Columns.Add("withpay");
   tblReturn.Columns.Add("maxbal");
   tblReturn.Columns.Add("hasbal");
   tblReturn.Columns.Add("pstatus");

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.LeaveTypes ORDER BY leavtype";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     DataRow drwN = tblReturn.NewRow();
     drwN["leavtype"] = dr["leavtype"].ToString();
     drwN["ltdesc"] = dr["ltdesc"].ToString();
     drwN["withpay"] = (dr["withpay"].ToString() == "1" ? "Yes" : "No");
     drwN["maxbal"] = dr["maxbal"].ToString();
     drwN["hasbal"] = (dr["hasbal"].ToString() == "1" ? "Yes" : "No");
     drwN["pstatus"] = (dr["pstatus"].ToString() == "1" ? "Yes" : "No");
     tblReturn.Rows.Add(drwN);
    }
    dr.Close();
   }
   return tblReturn;
  }

  public static DataTable GetActiveLeaveTypes()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.LeaveTypes ORDER BY leavtype";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetActiveLeaveTypes(string pUsername)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.LeaveTypes WHERE leavtype NOT IN (SELECT leavtype FROM HR.LeaveBalance WHERE username='" + pUsername + "') ORDER BY leavtype";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSLLeaveType()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    //cmd.CommandText = "SELECT leavtype AS pvalue, ltdesc AS ptext FROM HR.LeaveTypes WHERE pstatus='1' ORDER BY ltdesc";
    cmd.CommandText = "SELECT leavtype AS pvalue, ltdesc AS ptext FROM HR.LeaveTypes ORDER BY ltdesc"; //added 1/15/2018 by calvin
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSLLeaveTypeWithPay()
  {
      DataTable tblReturn = new DataTable();
      using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
      {
          SqlCommand cmd = cn.CreateCommand();
          cmd.CommandText = "SELECT leavtype AS pvalue, ltdesc AS ptext FROM HR.LeaveTypes WHERE pstatus='1' And withpay ='1' ORDER BY ltdesc";
          SqlDataAdapter da = new SqlDataAdapter(cmd);
          da.Fill(tblReturn);
      }
      return tblReturn;
  }

  public static DataTable GetDSLActive(string pUsername)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT leavtype AS pvalue, ltdesc AS ptext FROM HR.LeaveTypes WHERE pstatus='1' AND leavtype NOT IN (SELECT leavtype FROM HR.LeaveBalance WHERE username='" + pUsername + "') ORDER BY ltdesc";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDSLActiveAll()
  {
   DataTable tblReturn = new DataTable();

   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT leavtype, ltdesc FROM HR.LeaveTypes WHERE pstatus='1' ORDER BY ltdesc";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     drw = tblReturn.NewRow();
     drw["pvalue"] = dr["leavtype"].ToString();
     drw["ptext"] = dr["ltdesc"].ToString();
     tblReturn.Rows.Add(drw);
    }
    dr.Close();
   }

   return tblReturn;
  }

  public static DataTable GetDSLAll()
  {
   DataTable tblReturn = new DataTable();

   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT leavtype, ltdesc FROM HR.LeaveTypes ORDER BY ltdesc";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     drw = tblReturn.NewRow();
     drw["pvalue"] = dr["leavtype"].ToString();
     drw["ptext"] = dr["ltdesc"].ToString();
     tblReturn.Rows.Add(drw);
    }
    dr.Close();
   }

   return tblReturn;
  }

  ///////////////////////////////////
  ///////// Helper Methods //////////
  ///////////////////////////////////

  public static string GenerateCode()
  {
   string strReturn = "";
   int intSeed = 0;
   
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 leavtype FROM HR.LeaveTypes ORDER BY leavtype DESC";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
     intSeed = clsValidator.CheckInteger(dr["leavtype"].ToString());
    dr.Close();
   }

   intSeed += 1;
   strReturn = ("000" + intSeed.ToString()).Substring(intSeed.ToString().Length);

   return strReturn;
  }

 }

}