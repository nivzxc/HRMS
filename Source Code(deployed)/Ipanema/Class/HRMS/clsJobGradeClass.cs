using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class clsJobGradeClass
 {
  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable DSLJGClass()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT jgccode AS pvalue, jgcname AS ptext FROM HR.JobGradeClass ORDER BY jgorder";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static string GetJGClassName()
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
   }
   return strReturn;
  }

 }
}