using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 class clsShiftMode
 {

  public static DataTable GetDdlDs()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT shmdcode AS pvalue, shmdname AS ptext FROM HR.ShiftMode ORDER BY shmdname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static string GetShiftModeName(string pShiftModeCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT shmdname FROM HR.ShiftMode WHERE shmdcode='" + pShiftModeCode + "'";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

 }
}