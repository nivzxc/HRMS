using System;
using System.Data;
using System.Data.SqlClient;
using HRMS;

namespace HRMS
{
 public class clsEmployeeType : IDisposable
 {
  private string _strEmployeeTypeCode;
  private string _strName;
  private string _strDescription;
  private string _strEnabled;
  private string _strCreateBy;
  private DateTime _dteCreateOn;
  private string _strModifyBy;
  private DateTime _dteModifyOn;

  public clsEmployeeType() { }

  public string EmployeeTypeCode { get { return _strEmployeeTypeCode; } set { _strEmployeeTypeCode = value; } }
  public string Name { get { return _strName; } set { _strName = value; } }
  public string Description { get { return _strDescription; } set { _strDescription = value; } }
  public string Enabled { get { return _strEnabled; } set { _strEnabled = value; } }
  public string CreateBy { get { return _strCreateBy; } set { _strCreateBy = value; } }
  public DateTime CreateOn { get { return _dteCreateOn; } set { _dteCreateOn = value; } }
  public string ModifyBy { get { return _strModifyBy; } set { _strModifyBy = value; } }
  public DateTime ModifyOn { get { return _dteModifyOn; } set { _dteModifyOn = value; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.EmployeeType WHERE etypcode='" + _strEmployeeTypeCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strEmployeeTypeCode = dr["etypcode"].ToString();
     _strName = dr["etypname"].ToString();
     _strDescription = dr["etypdesc"].ToString();
     _strEnabled = dr["penabled"].ToString();
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
    cmd.CommandText = "INSERT INTO HR.EmployeeType VALUES('" + GenerateCode() + "',@etypname,@etypdesc,@penabled,@createby,@createon,@modifyby,@modifyon)";
    cmd.Parameters.Add(new SqlParameter("@etypname", _strName));
    cmd.Parameters.Add(new SqlParameter("@etypdesc", _strDescription));
    cmd.Parameters.Add(new SqlParameter("@penabled", _strEnabled));
    cmd.Parameters.Add(new SqlParameter("@createby", _strCreateBy));
    cmd.Parameters.Add(new SqlParameter("@createon", _dteCreateOn));
    cmd.Parameters.Add(new SqlParameter("@modifyby", _strModifyBy));
    cmd.Parameters.Add(new SqlParameter("@modifyon", _dteModifyOn));
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
    cmd.CommandText = "UPDATE HR.EmployeeType SET etypname=@etypname, etypdesc=@etypdesc, modifyby=@modifyby, modifyon=@modifyon WHERE etypcode=@etypcode";
    cmd.Parameters.Add(new SqlParameter("@etypcode", _strEmployeeTypeCode));
    cmd.Parameters.Add(new SqlParameter("@etypname", _strName));
    cmd.Parameters.Add(new SqlParameter("@etypdesc", _strDescription));
    cmd.Parameters.Add(new SqlParameter("@modifyby", _strModifyBy));
    cmd.Parameters.Add(new SqlParameter("@modifyon", _dteModifyOn));
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
    cmd.CommandText = "DELETE FROM HR.EmployeeType WHERE etypcode='" + _strEmployeeTypeCode + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable DSGEmployeeTypeList()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.EmployeeType ORDER BY etypname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static string GetEmployeeTypeName(string pEmployeeTypeCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT etypname FROM HR.EmployeeType WHERE etypcode='" + pEmployeeTypeCode + "'";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static DataTable DSLEmployeeType()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT etypcode AS pvalue, etypname AS ptext FROM HR.EmployeeType ORDER BY etypname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSLEmployeeTypeAll()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT etypcode, etypname FROM HR.EmployeeType ORDER BY etypname";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     drw = tblReturn.NewRow();
     drw["pvalue"] = dr["etypcode"].ToString();
     drw["ptext"] = dr["etypname"].ToString();
     tblReturn.Rows.Add(drw);
    }
    dr.Close();
   }
   return tblReturn;
  }

  public static int UpdateEnabledStatus(string pEmployeeTypeCode, string pStatus, string pUsername)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.EmployeeType SET penabled='" + pStatus + "', modifyby='" + pUsername + "', modifyon='" + DateTime.Now + "' WHERE etypcode='" + pEmployeeTypeCode + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }


  //////////////////////////////////
  ///////// Helper Methods /////////
  //////////////////////////////////

  private static string GenerateCode()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 CAST(etypcode AS INT) FROM HR.EmployeeType ORDER BY CAST(etypcode AS INT) DESC";
    cn.Open();
    try { intReturn = int.Parse(cmd.ExecuteScalar().ToString()); }
    catch { }
   }
   intReturn += 1;
   return (intReturn++).ToString("00");
  }

 }
}
