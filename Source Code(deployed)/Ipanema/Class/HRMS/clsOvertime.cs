using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace HRMS
{

 public class clsOvertime : IDisposable
 {
  private string _strOvertimeCode;
  private string _strUsername;
  private DateTime _dteDateFile;
  private DateTime _dteDateStart;
  private DateTime _dteDateEnd;
  private float _fltUnits;
  private string _strReason;
  private string _strChargeType;
  private string _strDepartmentCode;
  private string _strRequestorApproverName;
  private DateTime _dteRequestorApproverDate;
  private string _strRequestorApproverRemarks;
  private string _strRequestorApproverStatus;
  private string _strHeadApproverName;
  private DateTime _dteHeadApproverDate;
  private string _strHeadApproverRemarks;
  private string _strHeadApproverStatus;
  private string _strStatus;

  public clsOvertime() { }
  public clsOvertime(string pOvertimeCode) { _strOvertimeCode = pOvertimeCode; }

  public string OvertimeCode { get { return _strOvertimeCode; } set { _strOvertimeCode = value; } }
  public string Username { get { return _strUsername; } set { _strUsername = value; } }
  public DateTime DateFile { get { return _dteDateFile; } set { _dteDateFile = value; } }
  public DateTime DateStart { get { return _dteDateStart; } set { _dteDateStart = value; } }
  public DateTime DateEnd { get { return _dteDateEnd; } set { _dteDateEnd = value; } }
  public float Units { get { return _fltUnits; } set { _fltUnits = value; } }
  public string ChargeType { get { return _strChargeType; } set { _strChargeType = value; } }
  public string DepartmentCode { get { return _strDepartmentCode; } set { _strDepartmentCode = value; } }
  public string Reason { get { return _strReason; } set { _strReason = value; } }
  public string RequestorApproverName { get { return _strRequestorApproverName; } set { _strRequestorApproverName = value; } }
  public DateTime RequestorApproverDate { get { return _dteRequestorApproverDate; } set { _dteRequestorApproverDate = value; } }
  public string RequestorApproverRemarks { get { return _strRequestorApproverRemarks; } set { _strRequestorApproverRemarks = value; } }
  public string RequestorApproverStatus { get { return _strRequestorApproverStatus; } set { _strRequestorApproverStatus = value; } }
  public string HeadApproverName { get { return _strHeadApproverName; } set { _strHeadApproverName = value; } }
  public DateTime HeadApproverDate { get { return _dteHeadApproverDate; } set { _dteHeadApproverDate = value; } }
  public string HeadApproverRemarks { get { return _strHeadApproverRemarks; } set { _strHeadApproverRemarks = value; } }
  public string HeadApproverStatus { get { return _strHeadApproverStatus; } set { _strHeadApproverStatus = value; } }
  public string Status { get { return _strStatus; } set { _strStatus = value; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Overtime WHERE otcode='" + _strOvertimeCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strUsername = dr["username"].ToString();
     _dteDateFile = clsValidator.CheckDate(dr["datefile"].ToString());
     _dteDateStart = clsValidator.CheckDate(dr["datestrt"].ToString());
     _dteDateEnd = clsValidator.CheckDate(dr["dateend"].ToString());
     _fltUnits = clsValidator.CheckFloat(dr["units"].ToString());
     _strReason = dr["reason"].ToString();
     _strChargeType = dr["chartype"].ToString();
     _strDepartmentCode = dr["deptcode"].ToString();
     _strRequestorApproverName = dr["apprname"].ToString();
     _dteRequestorApproverDate = clsValidator.CheckDate(dr["apprdate"].ToString());
     _strRequestorApproverRemarks = dr["apprrem"].ToString();
     _strRequestorApproverStatus = dr["apprstat"].ToString();
     _strHeadApproverName = dr["apphname"].ToString();
     _dteHeadApproverDate = clsValidator.CheckDate(dr["apphdate"].ToString());
     _strHeadApproverRemarks = dr["apphrem"].ToString();
     _strHeadApproverStatus = dr["apphstat"].ToString();
     _strStatus = dr["otstat"].ToString();
    }
    dr.Close();
   }
  }

  public int InsertAdmin()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "spOTInsertAdmin";
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@datefile", SqlDbType.DateTime);
    cmd.Parameters.Add("@datestrt", SqlDbType.DateTime);
    cmd.Parameters.Add("@dateend", SqlDbType.DateTime);
    cmd.Parameters.Add("@units", SqlDbType.Float);
    cmd.Parameters.Add("@reason", SqlDbType.VarChar);
    cmd.Parameters.Add("@chartype", SqlDbType.Char, 1);
    cmd.Parameters.Add("@deptcode", SqlDbType.Char, 3);
    cmd.Parameters.Add("@apprname", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@apprdate", SqlDbType.DateTime);
    cmd.Parameters.Add("@apprrem", SqlDbType.VarChar, 100);
    cmd.Parameters.Add("@apprstat", SqlDbType.Char, 1);
    cmd.Parameters.Add("@apphname", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@apphdate", SqlDbType.DateTime);
    cmd.Parameters.Add("@apphrem", SqlDbType.VarChar, 255);
    cmd.Parameters.Add("@apphstat", SqlDbType.Char, 1);
    cmd.Parameters.Add("@otstat", SqlDbType.Char, 1);
    cmd.Parameters.Add("@otcode", SqlDbType.Char, 9);

    cmd.Parameters["@username"].Value = _strUsername;
    cmd.Parameters["@datefile"].Value = _dteDateFile;
    cmd.Parameters["@datestrt"].Value = _dteDateStart;
    cmd.Parameters["@dateend"].Value = _dteDateEnd;
    cmd.Parameters["@units"].Value = _fltUnits;
    cmd.Parameters["@reason"].Value = _strReason;
    cmd.Parameters["@chartype"].Value = _strChargeType;
    cmd.Parameters["@deptcode"].Value = _strDepartmentCode;
    if (_strChargeType == "0")
    {
     cmd.Parameters["@apprname"].Value = DBNull.Value;
     cmd.Parameters["@apprdate"].Value = DBNull.Value;
     cmd.Parameters["@apprrem"].Value = DBNull.Value;
     cmd.Parameters["@apprstat"].Value = DBNull.Value;
    }
    else
    {
     cmd.Parameters["@apprname"].Value = _strRequestorApproverName;
     cmd.Parameters["@apprdate"].Value = _dteRequestorApproverDate;
     cmd.Parameters["@apprrem"].Value = _strRequestorApproverRemarks;
     cmd.Parameters["@apprstat"].Value = _strRequestorApproverStatus;
    }
    cmd.Parameters["@apphname"].Value = _strHeadApproverName;
    cmd.Parameters["@apphdate"].Value = _dteHeadApproverDate;
    cmd.Parameters["@apphrem"].Value = _strHeadApproverRemarks;
    cmd.Parameters["@apphstat"].Value = _strHeadApproverStatus;
    cmd.Parameters["@otstat"].Value = _strStatus;
    cmd.Parameters["@otcode"].Direction = ParameterDirection.Output;
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
    _strOvertimeCode = cmd.Parameters["@otcode"].Value.ToString();
   }
   return intReturn;
  }

  public int UpdateAdmin()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Overtime SET datefile=@datefile, datestrt=@datestrt, dateend=@dateend, reason=@reason, apprdate=@apprdate, apprrem=@apprrem, apprstat=@apprstat, apphdate=@apphdate, apphrem=@apphrem, apphstat=@apphstat, otstat=@otstat WHERE otcode=@otcode";
    cmd.Parameters.Add("@datefile", SqlDbType.DateTime);
    cmd.Parameters.Add("@datestrt", SqlDbType.DateTime);
    cmd.Parameters.Add("@dateend", SqlDbType.DateTime);
    cmd.Parameters.Add("@reason", SqlDbType.VarChar);
    cmd.Parameters.Add("@apprdate", SqlDbType.DateTime);
    cmd.Parameters.Add("@apprrem", SqlDbType.VarChar, 100);
    cmd.Parameters.Add("@apprstat", SqlDbType.Char, 1);
    cmd.Parameters.Add("@apphdate", SqlDbType.DateTime);
    cmd.Parameters.Add("@apphrem", SqlDbType.VarChar, 255);
    cmd.Parameters.Add("@apphstat", SqlDbType.Char, 1);
    cmd.Parameters.Add("@otstat", SqlDbType.Char, 1);
    cmd.Parameters.Add("@otcode", SqlDbType.Char, 9);

    cmd.Parameters["@datefile"].Value = _dteDateFile;
    cmd.Parameters["@datestrt"].Value = _dteDateStart;
    cmd.Parameters["@dateend"].Value = _dteDateEnd;
    cmd.Parameters["@reason"].Value = _strReason;
    if (_strChargeType == "0")
    {
     cmd.Parameters["@apprdate"].Value = DBNull.Value;
     cmd.Parameters["@apprrem"].Value = DBNull.Value;
     cmd.Parameters["@apprstat"].Value = DBNull.Value;
    }
    else
    {
     if (_dteRequestorApproverDate == clsDateTime.SystemMinDate)
      cmd.Parameters["@apprdate"].Value = DBNull.Value;
     else
      cmd.Parameters["@apprdate"].Value = _dteRequestorApproverDate;
     cmd.Parameters["@apprrem"].Value = _strRequestorApproverRemarks;
     cmd.Parameters["@apprstat"].Value = _strRequestorApproverStatus;
    }
    if (_dteHeadApproverDate == clsDateTime.SystemMinDate)
     cmd.Parameters["@apphdate"].Value = DBNull.Value;
    else
     cmd.Parameters["@apphdate"].Value = _dteHeadApproverDate;
    cmd.Parameters["@apphrem"].Value = _strHeadApproverRemarks;
    cmd.Parameters["@apphstat"].Value = _strHeadApproverStatus;
    cmd.Parameters["@otstat"].Value = _strStatus;
    cmd.Parameters["@otcode"].Value = _strOvertimeCode;
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
    cmd.CommandText = "DELETE FROM HR.Overtime WHERE otcode='" + _strOvertimeCode + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable FormListDataSource(string pWhere, string pOrderBy)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    if(pOrderBy == "lastname")
     cmd.CommandText = "SELECT HR.Overtime.* FROM HR.Overtime INNER JOIN HR.Employees ON HR.Overtime.username = HR.Employees.username " + pWhere + "ORDER BY " + pOrderBy;
    else if (pOrderBy == "deptname")
     cmd.CommandText = "SELECT HR.Overtime.* FROM HR.Overtime INNER JOIN HR.Department ON HR.Overtime.deptcode = HR.Department.deptcode " + pWhere + "ORDER BY " + pOrderBy;
    else
     cmd.CommandText = "SELECT * FROM HR.Overtime " + pWhere + "ORDER BY " + pOrderBy;
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DataTable()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Overtime ORDER BY otcode";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DataTable(string pUsername)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Overtime WHERE username='" + pUsername + "' ORDER BY datefile";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DataTable(string pWhere, string pOrderBy)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Overtime " + pWhere + "ORDER BY " + pOrderBy;
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable Applications(DateTime pFocusDate, string pUsername, string pFilter)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    if (pFilter == "ALL")
     cmd.CommandText = "SELECT otcode FROM HR.Overtime WHERE username='" + pUsername + "' AND '" + pFocusDate + "' BETWEEN CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,datestrt))) AND CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,dateend)))";
    else
     cmd.CommandText = "SELECT otcode FROM HR.Overtime WHERE username='" + pUsername + "' AND '" + pFocusDate + "' BETWEEN CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,datestrt))) AND CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,dateend))) AND otstat='A'";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetApprovedOvertime(DateTime pFocusDate, string pUsername)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Overtime WHERE username='" + pUsername + "' AND otstat='A' AND '" + pFocusDate + "' BETWEEN CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,datestrt))) AND CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,dateend))) ORDER BY otcode";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
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

  public static string GetChargeTypeDesc(string pChargeType)
  {
   return (pChargeType == "0" ? "Charge within the department" : "Charge to other department");
  }

  public static string ToStatusDesc(string pStatusCode)
  {
   switch (pStatusCode)
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

  public static DataTable DdlDsApproveFilter()
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

  public static DataTable DdlDsChargeTypeAll()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");

   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "0";
   drw["ptext"] = "Charge within the department";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "1";
   drw["ptext"] = "Charge to the other department";
   tblReturn.Rows.Add(drw);

   return tblReturn;
  }

  public static DataTable DdlDsChargeType()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");

   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "0";
   drw["ptext"] = "Charge within the department";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "1";
   drw["ptext"] = "Charge to the other department";
   tblReturn.Rows.Add(drw);

   return tblReturn;
  }

 }
}