using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class clsUndertime : IDisposable
 {
  public enum UTUsers { Employee = 0, Approver = 1, HrAdmin = 2 }
  public enum UTStatus { Cancelled = 0, ForApproval = 1, Approved = 2, Disapproved = 3 }

  private string _strUndertimeCode;
  private string _strUsername;
  private DateTime _dteDateFiled;
  private DateTime _dteDateApplied;
  private string _strReason;
  private string _strApproverUsername;
  private DateTime _dteApproverDate;
  private string _strApproverRemarks;
  private string _strUTStatus;

  public clsUndertime() { }
  public clsUndertime(string pUTCode) { _strUndertimeCode = pUTCode; }

  public string UndertimeCode { get { return _strUndertimeCode; } set { _strUndertimeCode = value; } }
  public string Username { get { return _strUsername; } set { _strUsername = value; } }
  public DateTime DateFiled { get { return _dteDateFiled; } set { _dteDateFiled = value; } }
  public DateTime DateApplied { get { return _dteDateApplied; } set { _dteDateApplied = value; } }
  public string Reason { get { return _strReason; } set { _strReason = value; } }
  public string ApproverUsername { get { return _strApproverUsername; } set { _strApproverUsername = value; } }
  public DateTime ApproverDate { get { return _dteApproverDate; } set { _dteApproverDate = value; } }
  public string ApproverRemarks { get { return _strApproverRemarks; } set { _strApproverRemarks = value; } }
  public string Status { set { _strUTStatus = value; } get { return _strUTStatus; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.UnderTime WHERE utcode='" + _strUndertimeCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strUsername = dr["username"].ToString();
     _dteDateFiled = Convert.ToDateTime(dr["datefile"].ToString());
     _dteDateApplied = Convert.ToDateTime(dr["dateapp"].ToString());
     _strReason = dr["reason"].ToString();
     _strApproverUsername = dr["apphname"].ToString();
     _dteApproverDate = clsValidator.CheckDate(dr["apphdate"].ToString());
     _strApproverRemarks = dr["apphrem"].ToString();
     _strUTStatus = dr["utstat"].ToString();
    }
    dr.Close();
   }
  }

  public int InsertAdmin()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = new SqlCommand("spUndertimeInsertAdmin", cn);
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@datefile", SqlDbType.DateTime);
    cmd.Parameters.Add("@dateapp", SqlDbType.DateTime);
    cmd.Parameters.Add("@reason", SqlDbType.VarChar, 255);
    cmd.Parameters.Add("@apphname", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@apphdate", SqlDbType.DateTime);
    cmd.Parameters.Add("@apphrem", SqlDbType.VarChar, 255);
    cmd.Parameters.Add("@utstat", SqlDbType.Char, 1);
    cmd.Parameters.Add("@utcode", SqlDbType.Char, 9);
    cmd.Parameters["@username"].Value = _strUsername;
    cmd.Parameters["@datefile"].Value = _dteDateFiled;
    cmd.Parameters["@dateapp"].Value = _dteDateApplied;
    cmd.Parameters["@reason"].Value = _strReason;
    cmd.Parameters["@apphname"].Value = _strApproverUsername;
    cmd.Parameters["@apphdate"].Value = _dteApproverDate;
    cmd.Parameters["@apphrem"].Value = _strApproverRemarks;
    cmd.Parameters["@utstat"].Value = _strUTStatus;
    cmd.Parameters["@utcode"].Direction = ParameterDirection.Output;
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int UpdateAdmin()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Undertime SET datefile=@datefile, dateapp=@dateapp, reason=@reason,apphname=@apphname, apphdate=@apphdate, apphrem=@apphrem, utstat=@utstat WHERE utcode='" + _strUndertimeCode + "'";
    cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@datefile", SqlDbType.DateTime);
    cmd.Parameters.Add("@dateapp", SqlDbType.DateTime);
    cmd.Parameters.Add("@reason", SqlDbType.VarChar, 255);
    cmd.Parameters.Add("@apphname", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@apphdate", SqlDbType.DateTime);
    cmd.Parameters.Add("@apphrem", SqlDbType.VarChar, 255);
    cmd.Parameters.Add("@utstat", SqlDbType.Char, 1);
    cmd.Parameters.Add("@utcode", SqlDbType.Char, 9);
    cmd.Parameters["@username"].Value = _strUsername;
    cmd.Parameters["@datefile"].Value = _dteDateFiled;
    cmd.Parameters["@dateapp"].Value = _dteDateApplied;
    cmd.Parameters["@reason"].Value = _strReason;
    cmd.Parameters["@apphname"].Value = _strApproverUsername;
    cmd.Parameters["@apphdate"].Value = _dteApproverDate;
    cmd.Parameters["@apphrem"].Value = _strApproverRemarks;
    cmd.Parameters["@utstat"].Value = _strUTStatus;
    cmd.Parameters["@utcode"].Value = _strUndertimeCode;
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
    cmd.CommandText = "DELETE FROM HR.UnderTime WHERE utcode='" + _strUndertimeCode + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int Approve(string pApproverRemarks, DateTime pApproverDate)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.UnderTime SET apphrem=@apphrem,apphdate='" + pApproverDate + "',utstat='A' WHERE utcode='" + _strUndertimeCode + "'";
    cmd.Parameters.Add("@apphrem", SqlDbType.VarChar, 255);
    cmd.Parameters["@apphrem"].Value = pApproverRemarks;
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int Disapprove(string pApproverRemarks, DateTime pApproverDate)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.UnderTime SET apphrem=@apphrem,apphdate='" + pApproverDate + "',utstat='D' WHERE utcode='" + _strUndertimeCode + "'";
    cmd.Parameters.Add("@apphrem", SqlDbType.VarChar, 255);
    cmd.Parameters["@apphrem"].Value = pApproverRemarks;
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int Cancel()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.UnderTime SET utstat='C' WHERE utcode='" + _strUndertimeCode + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable Applications(DateTime pFocusDate, string pUsername, string pFilter)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    if (pFilter == "ALL")
     cmd.CommandText = "SELECT utcode FROM HR.UnderTime WHERE username='" + pUsername + "' AND CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,dateapp))) = '" + pFocusDate + "'";
    else
     cmd.CommandText = "SELECT utcode FROM HR.UnderTime WHERE username='" + pUsername + "' AND utstat='A' AND CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,dateapp))) = '" + pFocusDate + "'";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSGFormUndertimeList(string pWhere)
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("utcode");
   tblReturn.Columns.Add("requestor");
   tblReturn.Columns.Add("datefile", System.Type.GetType("System.DateTime"));
   tblReturn.Columns.Add("dateapp", System.Type.GetType("System.DateTime"));
   tblReturn.Columns.Add("reason");
   tblReturn.Columns.Add("approver");
   tblReturn.Columns.Add("status");   
   tblReturn.Columns.Add("statuscode");

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Undertime " + pWhere + "ORDER BY datefile DESC";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     DataRow drwN = tblReturn.NewRow();
     drwN["utcode"] = dr["utcode"].ToString();
     drwN["requestor"] = Employee.GetName(dr["username"].ToString(), EmployeeNameFormat.LastFirst);
     drwN["datefile"] = clsValidator.CheckDate(dr["datefile"].ToString()).ToString("yyyy/MM/dd hh:mm tt");
     drwN["dateapp"] = clsValidator.CheckDate(dr["dateapp"].ToString()).ToString("yyyy/MM/dd hh:mm tt");
     drwN["approver"] = Employee.GetName(dr["apphname"].ToString(), EmployeeNameFormat.LastFirst);
     drwN["status"] = clsUndertime.ToUndertimeStatusText(dr["utstat"].ToString());
     drwN["reason"] = dr["reason"].ToString().Replace("\n", "  ");
     drwN["statuscode"] = dr["utstat"].ToString();
     tblReturn.Rows.Add(drwN);
    }
    dr.Close();
   }
   return tblReturn;
  }

  public static bool HasExistingApplication(string pUsername, DateTime pApplicationDate)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT utcode FROM HR.Undertime WHERE username='" + pUsername + "' AND utstat IN ('F','A') AND DATEPART(mm,dateapp)='" + pApplicationDate.Month + "' AND DATEPART(dd,dateapp)='" + pApplicationDate.Day + "' AND DATEPART(yy,dateapp)='" + pApplicationDate.Year + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
   return blnReturn;
  }

  public static bool AuthenticateAccess(string pUsername, string pUndertimeCode)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username FROM HR.Undertime WHERE utcode='" + pUndertimeCode + "' AND (username='" + pUsername + "' OR apphname='" + pUsername + "')";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
   return blnReturn;
  }

  public static int GetTotalForApproval(string pApproverName)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT COUNT(utcode) FROM HR.Undertime WHERE apphname='" + pApproverName + "' AND utstat='F'";
    cn.Open();
    try { intReturn = int.Parse(cmd.ExecuteScalar().ToString()); }
    catch { intReturn = 0; }
   }
   return intReturn;
  }

  public static DataTable GetTopRecords(UTUsers pUTUsers, int pTop, string pUserName)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    switch (pUTUsers)
    {
     case UTUsers.Employee:
      cmd.CommandText = "SELECT TOP " + pTop + " utcode,datefile,dateapp,apphname,utstat,username FROM HR.Undertime WHERE username='" + pUserName + "' ORDER BY datefile DESC";
      break;
     case UTUsers.Approver:
      cmd.CommandText = "SELECT TOP " + pTop + " utcode,datefile,dateapp,apphname,utstat,username FROM HR.Undertime WHERE apphname='" + pUserName + "' AND utstat='F' ORDER BY datefile DESC";
      break;
    }
    cn.Open();
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static string GetRequestStatusIcon(string pUTStatus)
  {
   string strReturn = "";
   if (pUTStatus == "D")
    strReturn = "Disapproved.png";
   else if (pUTStatus == "F")
    strReturn = "Approval.png";
   else if (pUTStatus == "A")
    strReturn = "Approved.png";
   else if (pUTStatus == "C")
    strReturn = "Disapproved.png";
   return strReturn;
  }

  public static string ToUndertimeStatusText(string pUTStatus)
  {
   string strReturn = "";
   if (pUTStatus == "D")
    strReturn = "Disapproved";
   else if (pUTStatus == "F")
    strReturn = "For Approval";
   else if (pUTStatus == "A")
    strReturn = "Approved";
   else if (pUTStatus == "C")
    strReturn = "Cancelled";
   return strReturn;
  }

  public static UTStatus ToUndertimeStatus(string pUTStatusCode)
  {
   switch (pUTStatusCode)
   {
    case "X":
     return UTStatus.Cancelled;
    case "F":
     return UTStatus.ForApproval;
    case "A":
     return UTStatus.Approved;
    case "D":
     return UTStatus.Disapproved;
    default:
     return UTStatus.Cancelled;
   }
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

 }
}