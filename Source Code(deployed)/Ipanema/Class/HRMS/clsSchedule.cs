using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class clsSchedule: IDisposable
 {
  private string _strSchedCode;
  private string _strSundayShift;
  private string _strMondayShift;
  private string _strTuesdayShift;
  private string _strWednesdayShift;
  private string _strThursdayShift;
  private string _strFridayShift;
  private string _strSaturdayShift;
  private string _strRemarks;
  private string _strLastUpdateBy;
  private DateTime _dteLastUpdateDate;

  public clsSchedule() { }
  public clsSchedule(string pSchedCode) { _strSchedCode = pSchedCode; }

  public string ScheduleCode { get { return _strSchedCode; } set { _strSchedCode = value; } }
  public string SundayShift { get { return _strSundayShift; } set { _strSundayShift = value; } }
  public string MondayShift { get { return _strMondayShift; } set { _strMondayShift = value; } }
  public string TuesdayShift { get { return _strTuesdayShift; } set { _strTuesdayShift = value; } }
  public string WednesdayShift { get { return _strWednesdayShift; } set { _strWednesdayShift = value; } }
  public string ThursdayShift { get { return _strThursdayShift; } set { _strThursdayShift = value; } }
  public string FridayShift { get { return _strFridayShift; } set { _strFridayShift = value; } }
  public string SaturdayShift { get { return _strSaturdayShift; } set { _strSaturdayShift = value; } }
  public string Remarks { get { return _strRemarks; } set { _strRemarks = value; } }
  public string LastUpdateBy { get { return _strLastUpdateBy; } set { _strLastUpdateBy = value; } }
  public DateTime LastUpdateDate { get { return _dteLastUpdateDate; } set { _dteLastUpdateDate = value; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Schedule WHERE schdcode='" + _strSchedCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strSchedCode = dr["schdcode"].ToString();
     _strSundayShift = dr["sunshift"].ToString();
     _strMondayShift = dr["monshift"].ToString();
     _strTuesdayShift = dr["tueshift"].ToString();
     _strWednesdayShift = dr["wedshift"].ToString();
     _strThursdayShift = dr["thushift"].ToString();
     _strFridayShift = dr["frishift"].ToString();
     _strSaturdayShift = dr["satshift"].ToString();
     _strRemarks = dr["premarks"].ToString();
     _dteLastUpdateDate = clsValidator.CheckDate(dr["lastdate"].ToString());
     _strLastUpdateBy = dr["lastby"].ToString();     
    }
    dr.Close();
   }
  }

  public int Add()
  {
   int intReturn = 0;
   string strNewScheduleCode = "";

   SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString);
   cn.Open();
   SqlTransaction tran = cn.BeginTransaction();
   SqlCommand cmd = cn.CreateCommand();
   cmd.Transaction = tran;
   cmd.CommandText = "SELECT pvalue FROM Speedo.Keys WHERE pkey='schdcode'";
   strNewScheduleCode = "000" + cmd.ExecuteScalar().ToString();
   strNewScheduleCode = strNewScheduleCode.Substring(strNewScheduleCode.Length - 3);

   cmd.CommandText = "UPDATE Speedo.Keys SET pvalue=pvalue+1 WHERE pkey='schdcode'";
   cmd.ExecuteNonQuery();

   cmd.CommandText = "INSERT INTO HR.Schedule VALUES('" + strNewScheduleCode + "','" + _strSundayShift + "','" + _strMondayShift + "','" + _strTuesdayShift + "','" + _strWednesdayShift + "','" + _strThursdayShift + "','" + _strFridayShift + "','" + _strSaturdayShift + "',@remarks,'" + _dteLastUpdateDate + "','" + _strLastUpdateBy + "')";
   cmd.Parameters.Add("@remarks", SqlDbType.VarChar, 255);
   cmd.Parameters["@remarks"].Value = _strRemarks;
   intReturn = cmd.ExecuteNonQuery();

   try
   { tran.Commit(); }
   catch
   { tran.Rollback(); intReturn = 0; }
   finally
   { cn.Close(); }

   return intReturn;
  }

  public int Edit()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Schedule SET sunshift='" + _strSundayShift + "', monshift='" + _strMondayShift + "', tueshift='" + _strTuesdayShift + "', wedshift='" + _strWednesdayShift + "', thushift='" + _strThursdayShift + "', frishift='" + _strFridayShift + "', satshift='" + _strSaturdayShift + "', premarks=@premarks, lastdate='" + _dteLastUpdateDate + "', lastby='" + _strLastUpdateBy + "' WHERE schdcode='" + _strSchedCode + "'";
    cmd.Parameters.Add("@premarks", SqlDbType.VarChar, 255);
    cmd.Parameters["@premarks"].Value = _strRemarks;
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
    cmd.CommandText = "DELETE FROM HR.Schedule WHERE schdcode='" + _strSchedCode + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public float GetTotalWorkingHours()
  {
   float fltReturn = 0;
   fltReturn += clsShift.GetTotalWorkingHours(_strMondayShift);
   fltReturn += clsShift.GetTotalWorkingHours(_strTuesdayShift);
   fltReturn += clsShift.GetTotalWorkingHours(_strWednesdayShift);
   fltReturn += clsShift.GetTotalWorkingHours(_strThursdayShift);
   fltReturn += clsShift.GetTotalWorkingHours(_strFridayShift);
   fltReturn += clsShift.GetTotalWorkingHours(_strSaturdayShift);
   fltReturn += clsShift.GetTotalWorkingHours(_strSundayShift);
   return fltReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Methods /////////
  //////////////////////////////////

  public static int CountUsingDefault(string pScheduleCode)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT COUNT(schdcode) FROM HR.Employees WHERE schdcode='" + pScheduleCode + "' AND pstatus='1'";
    cn.Open();
    try { intReturn = clsValidator.CheckInteger(cmd.ExecuteScalar().ToString()); }
    catch { }
   }
   return intReturn;
  }

  public static int CountUsingSpecial(string pScheduleCode)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT COUNT(DISTINCT schdcode) FROM HR.EmployeeSchedule WHERE schdcode='" + pScheduleCode + "' AND username IN (SELECT username FROM HR.Employees WHERE pstatus='1')";
    cn.Open();
    try { intReturn = clsValidator.CheckInteger(cmd.ExecuteScalar().ToString()); }
    catch { }
   }
   return intReturn;
  }

  public static DataTable DSGScheduleList()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Schedule ORDER BY schdcode";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSGEmployeeUsingDefault(string pScheduleCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT lastname + ', ' + firname AS pName, deptname FROM HR.Employees INNER JOIN HR.Department ON HR.Employees.deptcode = HR.Department.deptcode WHERE schdcode='" + pScheduleCode + "' AND HR.Employees.pstatus='1' ORDER BY deptname,lastname,firname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSGEmployeeUsingSpecial(string pScheduleCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT lastname + ', ' + firname AS pName, deptname FROM HR.Employees INNER JOIN HR.Department ON HR.Employees.deptcode = HR.Department.deptcode WHERE username IN (SELECT DISTINCT username FROM HR.EmployeeSchedule WHERE schdcode='" + pScheduleCode + "') AND HR.Employees.pstatus='1' ORDER BY deptname,lastname,firname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSLSchedule()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT schdcode AS pvalue, schdcode AS ptext FROM HR.Schedule ORDER BY schdcode";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSLSchedule(string pDefaultScheduleCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT schdcode AS pvalue, schdcode AS ptext FROM HR.Schedule WHERE schdcode <> '" + pDefaultScheduleCode + "' ORDER BY schdcode";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static string GetShiftCode(string pUsername, DateTime pDate)
  {
   string strReturn = "";
   string strScheduleCode = "";
   bool blnHasOtherSchedule = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT schdcode FROM HR.UsersSchedule WHERE username='" + pUsername + "' AND '" + pDate + "' BETWEEN effcfrom AND effcto";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     blnHasOtherSchedule = true;
     strScheduleCode = dr["schdcode"].ToString();
    }
    dr.Close();

    if (!blnHasOtherSchedule)
    {
     cmd.CommandText = "SELECT schdcode FROM HR.Employees WHERE username='" + pUsername + "'";
     try { strScheduleCode = cmd.ExecuteScalar().ToString(); }
     catch { }
    }

    switch (pDate.DayOfWeek)
    {
     case DayOfWeek.Sunday:
      cmd.CommandText = "SELECT sunshft FROM HR.Schedule WHERE schdcode='" + strScheduleCode + "'";
      break;
     case DayOfWeek.Monday:
      cmd.CommandText = "SELECT monshft FROM HR.Schedule WHERE schdcode='" + strScheduleCode + "'";
      break;
     case DayOfWeek.Tuesday:
      cmd.CommandText = "SELECT tueshft FROM HR.Schedule WHERE schdcode='" + strScheduleCode + "'";
      break;
     case DayOfWeek.Wednesday:
      cmd.CommandText = "SELECT wedshft FROM HR.Schedule WHERE schdcode='" + strScheduleCode + "'";
      break;
     case DayOfWeek.Thursday:
      cmd.CommandText = "SELECT thushft FROM HR.Schedule WHERE schdcode='" + strScheduleCode + "'";
      break;
     case DayOfWeek.Friday:
      cmd.CommandText = "SELECT frishft FROM HR.Schedule WHERE schdcode='" + strScheduleCode + "'";
      break;
     case DayOfWeek.Saturday:
      cmd.CommandText = "SELECT satshft FROM HR.Schedule WHERE schdcode='" + strScheduleCode + "'";
      break;
    }
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static string GetApplicableShiftCode(DateTime pDate, string pScheduleCode)
  {
   string strReturn = "";
   string strField = "";

   switch (pDate.DayOfWeek)
   {
    case DayOfWeek.Sunday:
     strField = "sunshift";
     break;
    case DayOfWeek.Monday:
     strField = "monshift";
     break;
    case DayOfWeek.Tuesday:
     strField = "tueshift";
     break;
    case DayOfWeek.Wednesday:
     strField = "wedshift";
     break;
    case DayOfWeek.Thursday:
     strField = "thushift";
     break;
    case DayOfWeek.Friday:
     strField = "frishift";
     break;
    case DayOfWeek.Saturday:
     strField = "satshift";
     break;
   }

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT " + strField + " FROM HR.Schedule WHERE schdcode='" + pScheduleCode + "'";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { strReturn = ""; }
   }
   return strReturn;
  }



 }
}