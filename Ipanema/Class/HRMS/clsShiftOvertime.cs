using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{

 class clsShiftOvertime
 {

  ///////// Static Members /////////

  public DataTable GetDataTable(string pShiftCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.ShiftOvertime ORDER BY overfrom";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

 }

}
