using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{

 public class OfficialBusinessDetails : IDisposable
 {
  private string _strOBCode;
  private DateTime _dteFocusDate;
  private DateTime _dteKeyIn;
  private DateTime _dteKeyOut;
  private string _strUpdateBy;
  private DateTime _dteUpdateOn;

  public OfficialBusinessDetails() { }

  public string OBCode { get { return _strOBCode; } set { _strOBCode = value; } }
  public DateTime FocusDate { get { return _dteFocusDate; } set { _dteFocusDate = value; } }
  public DateTime KeyIn { get { return _dteKeyIn; } set { _dteKeyIn = value; } }
  public DateTime KeyOut { get { return _dteKeyOut; } set { _dteKeyOut = value; } }
  public string UpdateBy { get { return _strUpdateBy; } set { _strUpdateBy = value; } }
  public DateTime UpdateOn { get { return _dteUpdateOn; } set { _dteUpdateOn = value; } }

  public int Insert()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "INSERT INTO HR.OBDetails VALUES(@obcode,@focsdate,@keyin,@keyout,'1',@updateby,@updateon)";
    cmd.Parameters.Add("@obcode", SqlDbType.Char, 9);
    cmd.Parameters.Add("@focsdate", SqlDbType.DateTime);
    cmd.Parameters.Add("@keyin", SqlDbType.DateTime);
    cmd.Parameters.Add("@keyout", SqlDbType.DateTime);
    cmd.Parameters.Add("@updateby", SqlDbType.VarChar,30);
    cmd.Parameters.Add("@updateon", SqlDbType.DateTime);
    cmd.Parameters["@obcode"].Value = _strOBCode;
    cmd.Parameters["@focsdate"].Value = clsDateTime.GetDateOnly(_dteFocusDate);
    cmd.Parameters["@keyin"].Value = _dteKeyIn;
    cmd.Parameters["@keyout"].Value = _dteKeyOut;
    cmd.Parameters["@updateby"].Value = _strUpdateBy;
    cmd.Parameters["@updateon"].Value = _dteUpdateOn;
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
    cmd.CommandText = "UPDATE HR.OBDetails SET keyin=@keyin, keyout=@keyout, updateby=@updateby, updateon=@updateon WHERE obcode=@obcode AND focsdate=@focsdate";
    cmd.Parameters.Add("@obcode", SqlDbType.Char, 9);
    cmd.Parameters.Add("@focsdate", SqlDbType.DateTime);
    cmd.Parameters.Add("@keyin", SqlDbType.DateTime);
    cmd.Parameters.Add("@keyout", SqlDbType.DateTime);
    cmd.Parameters.Add("@updateby", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@updateon", SqlDbType.DateTime);
    cmd.Parameters["@obcode"].Value = _strOBCode;
    cmd.Parameters["@focsdate"].Value = _dteFocusDate;
    cmd.Parameters["@keyin"].Value = _dteKeyIn;
    cmd.Parameters["@keyout"].Value = _dteKeyOut;
    cmd.Parameters["@updateby"].Value = _strUpdateBy;
    cmd.Parameters["@updateon"].Value = _dteUpdateOn;
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.OBDetails WHERE obcode='" + _strOBCode + "' AND focsdate='" + _dteFocusDate + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _dteKeyIn = clsValidator.CheckDate(dr["keyin"].ToString());
     _dteKeyOut = clsValidator.CheckDate(dr["keyout"].ToString());
     _strUpdateBy = dr["updateby"].ToString();
     _dteUpdateOn = clsValidator.CheckDate(dr["updateon"].ToString());
    }
    dr.Close();
   }
  }

  public int Delete()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "DELETE FROM HR.OBDetails WHERE obcode='" + _strOBCode + "' AND focsdate='" + _dteFocusDate + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DateTime GetTimeIn(string pUsername, DateTime pFocusDate)
  {
   DateTime dteReturn = clsDateTime.SystemMinDate;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 keyin FROM HR.OBDetails WHERE focsdate='" + pFocusDate + "' AND pstatus='1' AND obcode IN (SELECT obcode FROM HR.OB WHERE username='" + pUsername + "' AND obstat='A') ORDER BY keyin";
    cn.Open();
    try { dteReturn = clsValidator.CheckDate(cmd.ExecuteScalar().ToString()); }
    catch { }
   }
   return dteReturn;
  }

  public static DateTime GetTimeOut(string pUsername, DateTime pFocusDate)
  {
   DateTime dteReturn = clsDateTime.SystemMinDate;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 keyout FROM HR.OBDetails WHERE focsdate='" + pFocusDate + "' AND pstatus='1' AND obcode IN (SELECT obcode FROM HR.OB WHERE username='" + pUsername + "' AND obstat='A') ORDER BY keyout DESC";
    cn.Open();
    try { dteReturn = clsValidator.CheckDate(cmd.ExecuteScalar().ToString()); }
    catch { }
   }
   return dteReturn;
  }

  /// <summary>
  /// Get the approved OB details of a specified focus date and employee username
  /// </summary>
  /// <param name="pFocusDate">Focus date to query</param>
  /// <param name="pUsername">Employee username</param>
  /// <returns></returns>
  public static DataTable ApprovedOBDetails(DateTime pFocusDate, string pUsername)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.OBDetails WHERE focsdate='" + pFocusDate + "' AND pstatus='1' AND obcode IN (SELECT obcode FROM HR.OB WHERE username='" + pUsername + "' AND obstat='A')";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DataTableByOBCode(string pOBCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.OBDetails WHERE obcode ='" + pOBCode + "'";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSGEmployeeOBDetails(string username, DateTime pStart, DateTime pEnd)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT obcode AS obcode,CONVERT(varchar(11),CAST(focsdate as varchar),1) AS focsdate,(SELECT username FROM HR.OB WHERE HR.OB.obcode = HR.OBDetails.obcode) AS username,(SELECT lastname + ', ' + firname + ' ' + midname FROM HR.Employees WHERE HR.Employees.username = (SELECT username FROM HR.OB WHERE HR.OB.obcode = HR.OBDetails.obcode)) AS employeename,(SELECT reason FROM HR.OB WHERE HR.OB.obcode = HR.OBDetails.obcode) AS reason FROM HR.OBDetails WHERE pstatus = '1' AND (SELECT username FROM HR.OB WHERE HR.OB.obcode = HR.OBDetails.obcode) = @username AND (focsdate BETWEEN @pstart AND @pend) AND (SELECT obstat FROM HR.OB WHERE HR.OB.obcode = HR.OBDetails.obcode) = 'A' AND (SELECT apphstat FROM HR.OB WHERE HR.OB.obcode = HR.OBDetails.obcode) = 'A'ORDER BY username";
    cmd.Parameters.Add(new SqlParameter("@username", username));
    cmd.Parameters.Add(new SqlParameter("@pstart", pStart));
    cmd.Parameters.Add(new SqlParameter("@pend", pEnd));
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

     

  public static bool HasExistingApplication(string pOBCode, DateTime pDateFrom, DateTime pDateTo)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT obcode FROM HR.OBDetails WHERE obcode='" + pOBCode + "' AND pstatus='1' AND (('" + pDateFrom + "' >=  keyin AND '" + pDateFrom + "' < keyout) OR ('" + pDateFrom + "' < keyin AND '" + pDateTo + "' >= keyout) OR ('" + pDateTo + "' >  keyin AND '" + pDateTo + "' <= keyout))";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
   return blnReturn;
  }

  public static int CountSchedule(string pOBCode)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT COUNT(obcode) FROM HR.OBDetails WHERE obcode='" + pOBCode + "'";
    cn.Open();
    try { intReturn = clsValidator.CheckInteger(cmd.ExecuteScalar().ToString()); }
    catch { }
   }
   return intReturn;
  }

 } 

}