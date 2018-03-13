using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class CDL : IDisposable
 {
  private string _strCDLCode;
  private DateTime _dteDateApplied;
  private string _strReason;
  private string _strCreatedBy;
  private DateTime _dteCreatedOn;
  private string _strModifiedBy;
  private DateTime _dteModifiedOn;

  public string CDLCode { get { return _strCDLCode; } set { _strCDLCode = value; } }
  public DateTime DateApplied { get { return _dteDateApplied; } set { _dteDateApplied = value; } }
  public string Reason { get { return _strReason; } set { _strReason = value; } }
  public string CreatedBy { get { return _strCreatedBy; } }
  public DateTime CreatedOn { get { return _dteCreatedOn; } }
  public string ModifiedBy { get { return _strModifiedBy; } }
  public DateTime ModifiedOn { get { return _dteModifiedOn; } }

  public int Delete()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "DELETE FROM HR.CDL WHERE cdlcode=@cdlcode";
    cmd.Parameters.Add(new SqlParameter("@cdlcode", _strCDLCode));
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
    cmd.CommandText = "SELECT * FROM HR.CDL WHERE cdlcode=@cdlcode";
    cmd.Parameters.Add(new SqlParameter("@cdlcode", _strCDLCode));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strCDLCode = dr["cdlcode"].ToString();
     _dteDateApplied = clsValidator.CheckDate(dr["dateapp"].ToString());
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
   SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString);
   cn.Open();
   SqlTransaction tran = cn.BeginTransaction();
   SqlCommand cmd = cn.CreateCommand();
   cmd.Transaction = tran;
   try
   {   
    cmd.CommandText = "SELECT RIGHT('000000000' + CAST(pvalue AS VARCHAR(9)),9) FROM Speedo.Keys WHERE pkey='cdlcode'";
    _strCDLCode = cmd.ExecuteScalar().ToString();

    cmd.CommandText = "INSERT INTO HR.CDL VALUES(@cdlcode,@dateapp,@preason,@createby,@createon,@modifyby,@modifyon)";
    cmd.Parameters.Add(new SqlParameter("@cdlcode", _strCDLCode));
    cmd.Parameters.Add(new SqlParameter("@dateapp", _dteDateApplied));
    cmd.Parameters.Add(new SqlParameter("@preason", _strReason));
    cmd.Parameters.Add(new SqlParameter("@createby", HRMSCore.Username));
    cmd.Parameters.Add(new SqlParameter("@createon", DateTime.Now));
    cmd.Parameters.Add(new SqlParameter("@modifyby", HRMSCore.Username));
    cmd.Parameters.Add(new SqlParameter("@modifyon", DateTime.Now));
    intReturn = cmd.ExecuteNonQuery();

    if (intReturn > 0)
    {
     cmd.CommandText = "UPDATE Speedo.Keys SET pvalue=pvalue+1 WHERE pkey='cdlcode'";
     cmd.ExecuteNonQuery();
    }
    tran.Commit();
   }
   catch 
   { 
    tran.Rollback(); 
   }
   finally 
   { 
    cn.Close(); 
   }
   return intReturn;
  }

  public int Update()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.CDL SET preason=@preason, modifyby=@modifyby, modifyon=@modifyon WHERE cdlcode=@cdlcode";
    cmd.Parameters.Add(new SqlParameter("@cdlcode", _strCDLCode));
    cmd.Parameters.Add(new SqlParameter("@preason", _strReason));
    cmd.Parameters.Add(new SqlParameter("@modifyby", HRMSCore.Username));
    cmd.Parameters.Add(new SqlParameter("@modifyon", DateTime.Now));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable GetDSGMainForm()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.CDL ORDER BY cdlcode";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDSExcludedEmployee(string pCDLCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username,lastname,firname FROM HR.Employees WHERE username NOT IN (SELECT username FROM HR.CDLEmployee WHERE cdlcode=@cdlcode) ORDER BY lastname";
    cmd.Parameters.Add(new SqlParameter("@cdlcode", pCDLCode));
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDSIncludedEmployee(string pCDLCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username,lastname,firname FROM HR.Employees WHERE username IN (SELECT username FROM HR.CDLEmployee WHERE cdlcode=@cdlcode) ORDER BY lastname";
    cmd.Parameters.Add(new SqlParameter("@cdlcode", pCDLCode));
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static string GetLeaveCode(string pUsername, string pCDLCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT leavcode FROM HR.CDLEmployee WHERE cdlcode=@cdlcode AND username=@username";
    cmd.Parameters.Add(new SqlParameter("@cdlcode", pCDLCode));
    cmd.Parameters.Add(new SqlParameter("@username", pUsername));
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static int InsertMember(string pCDLCode, string pUsername, string pLeaveCode)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "INSERT INTO HR.CDLEmployee VALUES(@cdlcode,@username,@leavcode)";
    cmd.Parameters.Add(new SqlParameter("@cdlcode", pCDLCode));
    cmd.Parameters.Add(new SqlParameter("@username", pUsername));
    cmd.Parameters.Add(new SqlParameter("@leavcode", pLeaveCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public static int RemoveMember(string pCDLCode, string pUsername)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "DELETE FROM HR.CDLEmployee WHERE cdlcode=@cdlcode AND username=@username";
    cmd.Parameters.Add(new SqlParameter("@cdlcode", pCDLCode));
    cmd.Parameters.Add(new SqlParameter("@username", pUsername));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

 }
}