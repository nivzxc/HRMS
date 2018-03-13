using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class clsChangeShiftBatch : IDisposable
 {
  public clsChangeShiftBatch() { }

  private string _strChangeScheduleBatchCode;
  private string _strShiftCode;
  private DateTime _dteApplicationDate;
  private string _strReason;
  private string _strCreatedBy;
  private DateTime _dteCreatedOn;
  private string _strModifiedBy;
  private DateTime _dteModifiedOn;

  public string ChangeScheduleBatchCode { get { return _strChangeScheduleBatchCode; } set { _strChangeScheduleBatchCode = value; } }
  public string ShiftCode { get { return _strShiftCode; } set { _strShiftCode = value; } }
  public DateTime ApplicationDate { get { return _dteApplicationDate; } set { _dteApplicationDate = value; } }
  public string Reason { get { return _strReason; } set { _strReason = value; } }
  public string CreatedBy { get { return _strCreatedBy; } }
  public DateTime CreatedOn { get { return _dteCreatedOn; } }
  public string ModifiedBy { get { return _strModifiedBy; } }
  public DateTime ModifiedOn { get { return _dteModifiedOn; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.ChangeShiftBatch WHERE csbcode=@csbcode";
    cmd.Parameters.Add(new SqlParameter("@csbcode", _strChangeScheduleBatchCode));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strShiftCode = dr["shftcode"].ToString();
     _dteApplicationDate = clsValidator.CheckDate(dr["appdate"].ToString());
     _strReason = dr["preason"].ToString();
     _strCreatedBy = dr["createby"].ToString();
     _dteCreatedOn = clsValidator.CheckDate(dr["createon"].ToString());
     _strModifiedBy = dr["modifyby"].ToString();
     _dteModifiedOn = clsValidator.CheckDate(dr["modifyon"].ToString());
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
    cmd.CommandText = "INSERT INTO HR.ChangeShiftBatch VALUES(@csbcode,@shftcode,@appdate,@preason,@createby,@createon,@modifyby,@modifyon)";
    cmd.Parameters.Add(new SqlParameter("@csbcode", _strChangeScheduleBatchCode));
    cmd.Parameters.Add(new SqlParameter("@shftcode", _strShiftCode));
    cmd.Parameters.Add(new SqlParameter("@appdate", clsDateTime.GetDateOnly(_dteApplicationDate)));
    cmd.Parameters.Add(new SqlParameter("@preason", _strReason));
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
    cmd.CommandText = "UPDATE HR.ChangeShiftBatch SET shftcode=@shftcode, appdate=@appdate, preason=@preason, modifyby=@modifyby, modifyon=@modifyon WHERE csbcode=@csbcode";
    cmd.Parameters.Add(new SqlParameter("@csbcode", _strChangeScheduleBatchCode));
    cmd.Parameters.Add(new SqlParameter("@shftcode", _strShiftCode));
    cmd.Parameters.Add(new SqlParameter("@appdate", _dteApplicationDate));
    cmd.Parameters.Add(new SqlParameter("@preason", _strReason));
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
    cmd.CommandText = "DELETE FROM HR.ChangeShiftBatch WHERE csbcode=@csbcode";
    cmd.Parameters.Add(new SqlParameter("@csbcode", _strChangeScheduleBatchCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable GetDSChangeShift(string pUsername, DateTime pFocusDate)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.ChangeShiftBatch WHERE appdate=@appdate AND csbcode IN (SELECT csbcode FROM HR.ChangeShiftBatchEmployee WHERE username=@username)";
    cmd.Parameters.Add(new SqlParameter("@appdate", pFocusDate));
    cmd.Parameters.Add(new SqlParameter("@username", pUsername));
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSChangeShift(string pUsername, DateTime pDateFrom, DateTime pDateTo)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.ChangeShiftBatch WHERE (appdate BETWEEN '" + pDateFrom + "' AND '" + pDateTo + "') AND (csbcode IN (SELECT csbcode FROM HR.ChangeShiftBatchEmployee WHERE username='" + pUsername + "'))";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetIncludedEmployee(string pChangeShiftBatchCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username,lastname,firname FROM HR.Employees WHERE username IN (SELECT username FROM HR.ChangeShiftBatchEmployee WHERE csbcode='" + pChangeShiftBatchCode + "') ORDER BY lastname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetExcludedEmployee(string pChangeShiftBatchCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username,lastname,firname FROM HR.Employees WHERE username NOT IN (SELECT username FROM HR.ChangeShiftBatchEmployee WHERE csbcode='" + pChangeShiftBatchCode + "') ORDER BY lastname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static bool CodeExist(string pChangeShiftBatchCode)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.ChangeShiftBatch WHERE csbcode='" + pChangeShiftBatchCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
   }
   return blnReturn;
  }

  public static DataTable GetDataTable()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.ChangeShiftBatch ORDER BY appdate";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static int InsertMember(string pChangeShiftBatchCode, string pUsername)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "INSERT INTO HR.ChangeShiftBatchEmployee VALUES('" + pChangeShiftBatchCode + "','" + pUsername + "')";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public static int RemoveMember(string pChangeShiftBatchCode, string pUsername)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "DELETE FROM HR.ChangeShiftBatchEmployee WHERE csbcode='" + pChangeShiftBatchCode + "' AND username='" + pUsername + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

 }
}
