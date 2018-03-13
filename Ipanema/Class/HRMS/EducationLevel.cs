using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public static class EducationLevel
 {

  public static DataTable GetDSL()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT educlvl AS pvalue, details AS ptext FROM HR.EducationLevel ORDER BY educordr";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static string GetDetails(string pEducationLevelCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT details FROM HR.EducationLevel WHERE educlvl=@educlvl";
    cmd.Parameters.Add(new SqlParameter("@educlvl", pEducationLevelCode));
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

 }
}
