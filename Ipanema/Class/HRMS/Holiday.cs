using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class Holiday : IDisposable
 {
  private string _strHolidayCode;
  private DateTime _dteDateApplied;
  private string _strShiftCode;
  private string _strDescription;
  private string _strCreateBy;
  private DateTime _dteCreateOn;
  private string _strModifyBy;
  private DateTime _dteModifyOn;

  public Holiday() { }

  public string HolidayCode { get { return _strHolidayCode; } set { _strHolidayCode = value; } }
  public DateTime DateApplied { get { return _dteDateApplied; } set { _dteDateApplied = value; } }
  public string ShiftCode { get { return _strShiftCode; } set { _strShiftCode = value; } }
  public string Description { get { return _strDescription; } set { _strDescription = value; } }
  public string CreateBy { get { return _strCreateBy; } }
  public DateTime CreateOn { get { return _dteCreateOn; } }
  public string ModifyBy { get { return _strModifyBy; } }
  public DateTime ModifyOn { get { return _dteModifyOn; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Holidays WHERE holicode=@holicode";
    cmd.Parameters.Add(new SqlParameter("@holicode", _strHolidayCode));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strHolidayCode = dr["holicode"].ToString();
     _dteDateApplied = clsValidator.CheckDate(dr["dateapp"].ToString());
     _strShiftCode = dr["shftcode"].ToString();
     _strDescription = dr["holidesc"].ToString();
     _strCreateBy = dr["createby"].ToString();
     _dteCreateOn = clsValidator.CheckDate(dr["createon"].ToString());
     _strModifyBy = dr["modifyby"].ToString();
     _dteModifyOn = clsValidator.CheckDate(dr["modifyon"].ToString());
    }
    dr.Close();
   }
  }

  public int Insert()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "INSERT INTO HR.Holidays VALUES(@holicode,@dateapp,@shftcode,@holidesc,@createby,@createon,@modifyby,@modifyon)";
    cmd.Parameters.Add(new SqlParameter("@holicode", _strHolidayCode));
    cmd.Parameters.Add(new SqlParameter("@dateapp", _dteDateApplied));
    cmd.Parameters.Add(new SqlParameter("@shftcode", _strShiftCode));
    cmd.Parameters.Add(new SqlParameter("@holidesc", _strDescription));
    cmd.Parameters.Add(new SqlParameter("@createby", HRMSCore.Username));
    cmd.Parameters.Add(new SqlParameter("@createon", DateTime.Now));
    cmd.Parameters.Add(new SqlParameter("@modifyby", HRMSCore.Username));
    cmd.Parameters.Add(new SqlParameter("@modifyon", DateTime.Now));
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
    cmd.CommandText = "UPDATE HR.Holidays SET dateapp=@dateapp, shftcode=@shftcode, holidesc=@holidesc, modifyby=@modifyby, modifyon=@modifyon WHERE holicode=@holicode";
    cmd.Parameters.Add(new SqlParameter("@holicode", _strHolidayCode));
    cmd.Parameters.Add(new SqlParameter("@dateapp", _dteDateApplied));
    cmd.Parameters.Add(new SqlParameter("@shftcode", _strShiftCode));
    cmd.Parameters.Add(new SqlParameter("@holidesc", _strDescription));
    cmd.Parameters.Add(new SqlParameter("@createby", _strCreateBy));
    cmd.Parameters.Add(new SqlParameter("@createon", _dteCreateOn));
    cmd.Parameters.Add(new SqlParameter("@modifyby", HRMSCore.Username));
    cmd.Parameters.Add(new SqlParameter("@modifyon", DateTime.Now));
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
    cmd.CommandText = "DELETE FROM HR.Holidays WHERE holicode=@holicode";
    cmd.Parameters.Add(new SqlParameter("@holicode", _strHolidayCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable DSGFormHolidayList()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Holidays ORDER BY holicode";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetHoliday(string pOrderBy)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Holidays ORDER BY " + pOrderBy;
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetHoliday(DateTime pDateFrom, DateTime pDateTo)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Holidays WHERE dateapp BETWEEN '" + pDateFrom + "' AND '" + pDateTo + "'";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetHoliday(DateTime pFocusDate)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Holidays WHERE dateapp ='" + pFocusDate + "'";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetMonthHoliday(int pYear, int pMonth)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Holidays WHERE DATEPART(mm,dateapp)='" + pMonth + "' AND  DATEPART(yy,dateapp)='" + pYear + "'";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static bool IsHoliday(DateTime pDateTime)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT holicode FROM HR.Holidays WHERE dateapp='" + pDateTime + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
   return blnReturn;
  }

  public static bool IsHoliday(DateTime pDateFrom, DateTime pDateTo)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT holicode FROM HR.Holidays WHERE dateapp BETWEEN '" + pDateFrom + "' AND '" + pDateTo + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
   return blnReturn;
  }

 }

}