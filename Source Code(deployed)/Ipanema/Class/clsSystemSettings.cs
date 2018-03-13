using System;
using System.Data;
using System.Data.SqlClient;
using HRMS;

class clsSystemSettings
{

 public static string GetValue(string pKey)
 {
  string strReturn = "";
  using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
  {
   SqlCommand cmd = cn.CreateCommand();
   cmd.CommandText = "SELECT pvalue FROM Speedo.SystemSettings WHERE pkey=@pkey";
   cmd.Parameters.Add("@pkey", SqlDbType.Char, 10);
   cmd.Parameters["@pkey"].Value = pKey;
   cn.Open();
   try { strReturn = cmd.ExecuteScalar().ToString(); }
   catch { }
  }
  return strReturn;
 }

}