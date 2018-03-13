using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace HRMS
{
 public class LeaveApplication : IDisposable
 {
  private string _strLeaveCode;
  private string _strLeaveType;
  private string _strRequestor;
  private DateTime _dteDateFile;
  private DateTime _dteDateStart;
  private DateTime _dteDateEnd;
  private float _fltUnits;
  private string _strReason;
  private string _strApprover;
  private DateTime _dteApproverDate;
  private string _strApproverRemarks;
  private string _strStatus;

  public LeaveApplication() 
  { 
  }

  public LeaveApplication(string pLeaveCode) 
  { 
   _strLeaveCode = pLeaveCode; 
  }

  public string LeaveCode { set { _strLeaveCode = value; } get { return _strLeaveCode; } }
  public string LeaveType { set { _strLeaveType = value; } get { return _strLeaveType; } }
  public string Requestor { set { _strRequestor = value; } get { return _strRequestor; } }
  public DateTime DateFile { set { _dteDateFile = value; } get { return _dteDateFile; } }
  public DateTime DateStart { set { _dteDateStart = value; } get { return _dteDateStart; } }
  public DateTime DateEnd { set { _dteDateEnd = value; } get { return _dteDateEnd; } }
  public float Units { set { _fltUnits = value; } get { return _fltUnits; } }
  public string Reason { set { _strReason = value; } get { return _strReason; } }
  public string Approver { set { _strApprover = value; } get { return _strApprover; } }
  public DateTime ApproverDate { set { _dteApproverDate = value; } get { return _dteApproverDate; } }
  public string ApproverRemarks { set { _strApproverRemarks = value; } get { return _strApproverRemarks; } }
  public string Status { set { _strStatus = value; } get { return _strStatus; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Leave WHERE leavcode=@leavcode";
    cmd.Parameters.Add(new SqlParameter("@leavcode", _strLeaveCode));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strLeaveCode = dr["leavcode"].ToString();
     _strLeaveType = dr["leavtype"].ToString();
     _strRequestor = dr["username"].ToString();
     _dteDateFile = clsValidator.CheckDate(dr["datefile"].ToString());
     _dteDateStart = clsValidator.CheckDate(dr["datestrt"].ToString());
     _dteDateEnd = clsValidator.CheckDate(dr["dateend"].ToString());
     _fltUnits = float.Parse(dr["units"].ToString());
     _strReason = dr["reason"].ToString();
     _strApprover = dr["apphname"].ToString();
     _dteApproverDate = clsValidator.CheckDate(dr["apphdate"].ToString());
     _strApproverRemarks = dr["apphrem"].ToString();
     _strStatus = dr["leavstat"].ToString();
    }
    dr.Close();
   }
  }

  public bool InsertAdmin()
  {
   bool blnReturn = false;
   int intSeed = 0;
   SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString);
   cn.Open();
   SqlTransaction tran = cn.BeginTransaction();
   SqlCommand cmd = new SqlCommand("spLeaveInsertAdmin", cn);
   cmd.Transaction = tran;
   try
   {
    cmd.CommandText = "INSERT INTO HR.Leave VALUES(@leavcode,@leavtype,@username,@datefile,@datestrt,@dateend,@units,@reason,@apphname,@apphdate,@apphrem,@leavstat)";
    cmd.Parameters.Add(new SqlParameter("@leavcode", _strLeaveCode));
    cmd.Parameters.Add(new SqlParameter("@leavtype", _strLeaveType));
    cmd.Parameters.Add(new SqlParameter("@username", _strRequestor));
    cmd.Parameters.Add(new SqlParameter("@datefile", _dteDateFile));
    cmd.Parameters.Add(new SqlParameter("@datestrt", _dteDateStart));
    cmd.Parameters.Add(new SqlParameter("@dateend", _dteDateEnd));
    cmd.Parameters.Add(new SqlParameter("@units", _fltUnits));
    cmd.Parameters.Add(new SqlParameter("@reason", _strReason));
    cmd.Parameters.Add(new SqlParameter("@apphname", _strApprover));
    cmd.Parameters.Add(new SqlParameter("@apphdate", _dteApproverDate));
    cmd.Parameters.Add(new SqlParameter("@apphrem", _strApproverRemarks));
    cmd.Parameters.Add(new SqlParameter("@leavstat", _strStatus));  
    cmd.ExecuteNonQuery();

    cmd.CommandText = "UPDATE Speedo.Keys SET pvalue=pvalue + 1 WHERE pkey='leavcode'";
    cmd.ExecuteNonQuery();

    tran.Commit();
    blnReturn = true;
   }
   catch { tran.Rollback(); blnReturn = false; }
   finally { cn.Close(); }
   return blnReturn;
  }

  public int UpdateAdmin()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Leave SET leavtype=@leavtype, reason=@reason, apphdate=@apphdate, leavstat=@leavstat WHERE leavcode=@leavcode";
    cmd.Parameters.Add(new SqlParameter("@leavtype", _strLeaveType));
    cmd.Parameters.Add(new SqlParameter("@reason", _strReason));
    cmd.Parameters.Add(new SqlParameter("@apphdate", _dteApproverDate));
    cmd.Parameters.Add(new SqlParameter("@leavstat", _strStatus));
    cmd.Parameters.Add(new SqlParameter("@leavcode", _strLeaveCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int DeleteAdmin()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "DELETE FROM HR.Leave WHERE leavcode=@leavcode";
    cmd.Parameters.Add(new SqlParameter("@leavcode", _strLeaveCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static float GetLeaveUnits(DateTime pDateFrom, DateTime pDateTo, float pTimeFrom, float pTimeTo, string pUsername)
  {
   float fltReturn = 0;
   float fltTimeFrom = pTimeFrom;
   float fltTimeTo = pTimeTo;
   DateTime dteDateFrom = clsDateTime.GetDateOnly(pDateFrom);
   DateTime dteDateTo = clsDateTime.GetDateOnly(pDateTo);
   DateTime dteTemp = pDateFrom;
   while (dteTemp < dteDateTo)
   {
    if (clsShift.IsWorkingShift(clsShift.GetDayShiftCode(pUsername, dteTemp)))
     fltReturn++;
    dteTemp = dteTemp.AddDays(1);
   }
   if (!clsShift.IsWorkingShift(clsShift.GetDayShiftCode(pUsername, dteDateFrom)))
    fltTimeFrom = 0;

   if (!clsShift.IsWorkingShift(clsShift.GetDayShiftCode(pUsername, dteDateTo)))
    fltTimeTo = 0;

   fltReturn = fltReturn + (fltTimeTo - fltTimeFrom);
   return fltReturn;
  }

  public static bool HasExistingApplication(string pUsername, DateTime pDateFrom, DateTime pDateTo)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT leavcode FROM HR.Leave WHERE username=@username AND leavstat IN ('F','A') AND (('" + pDateFrom + "' >= datestrt AND '" + pDateFrom + "' < dateend) OR ('" + pDateFrom + "' < datestrt AND '" + pDateTo + "' >= dateend) OR ('" + pDateTo + "' >  datestrt AND '" + pDateTo + "' <= dateend))";
    cmd.Parameters.Add(new SqlParameter("@username", pUsername));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
   return blnReturn;
  }

  public static DataTable GetApprovedLeave(DateTime pFocusDate, string pUsername)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Leave WHERE username='" + pUsername + "' AND leavstat='A' AND '" + pFocusDate + "' BETWEEN CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,datestrt))) AND CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,dateend)))";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GETDSGLeaveOffense(DateTime pStart, DateTime pEnd)
  {
      DataTable tblReturn = new DataTable();
      using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
      {
          SqlCommand cmd = cn.CreateCommand();
          cmd.CommandText = "SELECT username AS username, (SELECT lastname + ', ' + firname + ' ' + midname FROM HR.Employees WHERE HR.Employees.username = HR.Leave.username) AS employeename, SUM(units) AS units FROM HR.Leave WHERE leavstat = 'A' AND (datestrt BETWEEN @pStart AND @pEnd) AND  CONVERT(varchar(11),datestrt,1) NOT IN (SELECT  CONVERT(varchar(11),dateapp,1) FROM HR.CDL) GROUP BY username";
          cmd.Parameters.Add(new SqlParameter("@pStart", pStart));
          cmd.Parameters.Add(new SqlParameter("@pEnd", pEnd));
          SqlDataAdapter da = new SqlDataAdapter(cmd);
          da.Fill(tblReturn);
      }
      return tblReturn;
  }

  public static DataTable GetDSApplications(DateTime pFocusDate, string pUsername, string pFilter)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    if (pFilter == "ALL")
     cmd.CommandText = "SELECT leavcode FROM HR.Leave WHERE username='" + pUsername + "' AND '" + pFocusDate + "' BETWEEN CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,datestrt))) AND CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,dateend)))";
    else
     cmd.CommandText = "SELECT leavcode FROM HR.Leave WHERE username='" + pUsername + "' AND leavstat='A' AND '" + pFocusDate + "' BETWEEN CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,datestrt))) AND CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,dateend)))";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDSGFormLeaveList(string pLastName, string pReason,string pLeaveStatus, string pLeaveType, DateTime pDateStart, DateTime pDateEnd)
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("leavcode");
   tblReturn.Columns.Add("leavtype");
   tblReturn.Columns.Add("requestor");
   tblReturn.Columns.Add("datefile", System.Type.GetType("System.DateTime"));
   tblReturn.Columns.Add("datestart", System.Type.GetType("System.DateTime"));
   tblReturn.Columns.Add("dateend", System.Type.GetType("System.DateTime"));
   tblReturn.Columns.Add("unit");
   tblReturn.Columns.Add("approver");
   tblReturn.Columns.Add("status");
   tblReturn.Columns.Add("reason");
   tblReturn.Columns.Add("statuscode");
   string strConditions = " ";

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    if (pLeaveStatus != "ALL")
    {
     strConditions = strConditions + " AND leavstat=@leavstat";
     cmd.Parameters.Add(new SqlParameter("@leavstat", pLeaveStatus));
    }

    if (pLeaveType != "ALL")
    {
     strConditions = strConditions + " AND leavtype=@leavtype";
     cmd.Parameters.Add(new SqlParameter("@leavtype", pLeaveType));
    }

    cmd.CommandText = "SELECT leavcode, (SELECT ltdesc FROM HR.LeaveTypes WHERE leavtype=HR.Leave.leavtype) AS pLeaveType, (SELECT lastname + ', ' + firname FROM HR.Employees WHERE username=HR.Leave.username) AS pName, datefile, datestrt, dateend, units, (SELECT lastname + ', ' + firname FROM HR.Employees WHERE username=HR.Leave.apphname) AS pApproverName, leavstat, reason FROM HR.Leave WHERE username IN (SELECT username FROM HR.Employees WHERE lastname LIKE @lastname + '%') AND reason LIKE '%' + @reason + '%' AND ((datestrt BETWEEN @FilterDateStart AND @FilterDateEnd) OR (dateend BETWEEN @FilterDateStart AND @FilterDateEnd))" + strConditions + " ORDER BY datefile DESC";
    cmd.Parameters.Add(new SqlParameter("@lastname", pLastName));
    cmd.Parameters.Add(new SqlParameter("@reason", pReason));
    cmd.Parameters.Add(new SqlParameter("@FilterDateStart", pDateStart));
    cmd.Parameters.Add(new SqlParameter("@FilterDateEnd", pDateEnd));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     DataRow drwN = tblReturn.NewRow();
     drwN["leavcode"] = dr["leavcode"].ToString();
     drwN["leavtype"] = dr["pLeaveType"].ToString();
     drwN["requestor"] = dr["pName"].ToString();
     drwN["datefile"] = clsValidator.CheckDate(dr["datefile"].ToString()).ToString("yyyy/MM/dd hh:mm tt");
     drwN["datestart"] = clsValidator.CheckDate(dr["datestrt"].ToString()).ToString("yyyy/MM/dd hh:mm tt");
     drwN["dateend"] = clsValidator.CheckDate(dr["dateend"].ToString()).ToString("yyyy/MM/dd hh:mm tt");
     drwN["unit"] = dr["units"].ToString();
     drwN["approver"] = dr["pApproverName"].ToString();
     drwN["status"] = LeaveApplication.ToLeaveStatusDesc(dr["leavstat"].ToString());
     drwN["reason"] = dr["reason"].ToString().Replace("\n","  ");
     drwN["statuscode"] = dr["leavstat"].ToString();
     tblReturn.Rows.Add(drwN);
    }
    dr.Close();
   }
   return tblReturn;
  }

  //public static DataTable GetDataTable()
  //{
  // DataTable tblReturn = new DataTable();
  // using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
  // {
  //  SqlCommand cmd = cn.CreateCommand();
  //  cmd.CommandText = "SELECT * FROM HR.Leave ORDER BY username,datestrt";
  //  SqlDataAdapter da = new SqlDataAdapter(cmd);
  //  da.Fill(tblReturn);
  // }
  // return tblReturn;
  //}

  //public static DataTable GetDataTable(string pOrderBy)
  //{
  // DataTable tblReturn = new DataTable();
  // using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
  // {
  //  SqlCommand cmd = cn.CreateCommand();
  //  cmd.CommandText = "SELECT * FROM HR.Leave ORDER BY " + pOrderBy;
  //  SqlDataAdapter da = new SqlDataAdapter(cmd);
  //  da.Fill(tblReturn);
  // }
  // return tblReturn;
  //}

  //public static DataTable GetDataTable(string pWhere, string pOrderBy)
  //{
  // DataTable tblReturn = new DataTable();
  // using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
  // {
  //  SqlCommand cmd = cn.CreateCommand();
  //  cmd.CommandText = "SELECT * FROM HR.Leave " + pWhere + "ORDER BY " + pOrderBy;
  //  SqlDataAdapter da = new SqlDataAdapter(cmd);
  //  da.Fill(tblReturn);
  // }
  // return tblReturn;
  //}

  //public static DataTable GetDataTable(DateTime pFocusDate, string pUsername)
  //{
  // DataTable tblReturn = new DataTable();
  // using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
  // {
  //  SqlCommand cmd = cn.CreateCommand();
  //  cmd.CommandText = "SELECT * FROM HR.Leave WHERE '" + pFocusDate + "' BETWEEN CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,datestrt))) AND CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,dateend))) AND leavstat='A'";
  //  SqlDataAdapter da = new SqlDataAdapter(cmd);
  //  da.Fill(tblReturn);
  // }
  // return tblReturn;
  //}

  public static string ToLeaveStatusDesc(string pLeaveStatusCode)
  {
   switch (pLeaveStatusCode)
   {
    case "C":
     return "Cancelled";
    case "F":
     return "For Approval";
    case "A":
     return "Approved";
    case "D":
     return "Disapproved";
    default:
     return "Cancelled";
   }
  }

  public static Color GetLVBGColor(string pStatus)
  {
   Color clrReturn = Color.White;

   switch (pStatus)
   {
    case "F":
     clrReturn = Color.AliceBlue;
     break;
    case "D":
     clrReturn = Color.MistyRose;
     break;
    case "A":
     clrReturn = Color.Honeydew;
     break;
    case "C":
     clrReturn = Color.PeachPuff;
     break;
   }

   return clrReturn;
  }

  public static DataTable DdlDsStatusAll()
  {
   DataTable tblReturn = new DataTable();

   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drwS = tblReturn.NewRow();
   drwS["pvalue"] = "ALL";
   drwS["ptext"] = "All";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "A";
   drwS["ptext"] = "Approved";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "C";
   drwS["ptext"] = "Cancelled";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "D";
   drwS["ptext"] = "Disapproved";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "F";
   drwS["ptext"] = "For Approval";
   tblReturn.Rows.Add(drwS);

   return tblReturn;
  }

  public static DataTable DdlDsStatus()
  {
   DataTable tblReturn = new DataTable();

   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drwS = tblReturn.NewRow();
   drwS["pvalue"] = "A";
   drwS["ptext"] = "Approved";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "C";
   drwS["ptext"] = "Cancelled";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "D";
   drwS["ptext"] = "Disapproved";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "F";
   drwS["ptext"] = "For Approval";
   tblReturn.Rows.Add(drwS);

   return tblReturn;
  }

  public static DataTable GetDSLApproveFilter()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");

   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "A";
   drw["ptext"] = "Approved";
   tblReturn.Rows.Add(drw);

   return tblReturn;
  }

 }

}