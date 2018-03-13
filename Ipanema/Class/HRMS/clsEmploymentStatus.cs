using System;
using System.Data;
using System.Data.SqlClient;
using HRMS;

namespace HRMS
{
 public class clsEmploymentStatus : IDisposable
 {
  private string _strEmploymentStatusCode;
  private string _strName;

  public clsEmploymentStatus() { }
  public clsEmploymentStatus(string pEmploymentStatusCode) { _strEmploymentStatusCode = pEmploymentStatusCode; }

  public string EmploymentStatusCode { get { return _strEmploymentStatusCode; } set { _strEmploymentStatusCode = value; } }
  public string Name { get { return _strName; } set { _strName = value; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.EmploymentStatus WHERE esttcode='" + _strEmploymentStatusCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strEmploymentStatusCode = dr["esttcode"].ToString();
     _strName = dr["empstat"].ToString();
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
    cmd.CommandText = "INSERT INTO HR.EmploymentStatus VALUES(@esttcode,@empstat)";
    cmd.Parameters.Add(new SqlParameter("@esttcode", _strEmploymentStatusCode));
    cmd.Parameters.Add(new SqlParameter("@empstat", _strName));
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
    cmd.CommandText = "UPDATE HR.EmploymentStatus SET empstat=@empstat WHERE esttcode=@esttcode";
    cmd.Parameters.Add(new SqlParameter("@esttcode", _strEmploymentStatusCode));
    cmd.Parameters.Add(new SqlParameter("@empstat", _strName));
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
    cmd.CommandText = "DELETE FROM HR.EmploymentStatus WHERE esttcode=@esttcode";
    cmd.Parameters.Add(new SqlParameter("@esttcode", _strEmploymentStatusCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static string GetEmploymentStatusName(string pEmploymentStatusCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT empstat FROM HR.EmploymentStatus WHERE esttcode=@esttcode";
    cmd.Parameters.Add(new SqlParameter("@esttcode", pEmploymentStatusCode));
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static DataTable DSLEmploymentStatus()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT esttcode AS pvalue, empstat AS ptext FROM HR.EmploymentStatus ORDER BY empstat";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSLEmploymentStatusAll()
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
    cmd.CommandText = "SELECT esttcode, empstat FROM HR.EmploymentStatus ORDER BY empstat";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     drw = tblReturn.NewRow();
     drw["pvalue"] = dr["esttcode"].ToString();
     drw["ptext"] = dr["empstat"].ToString();
     tblReturn.Rows.Add(drw);
    }
    dr.Close();
   }
   return tblReturn;
  }
  
 }
}
