using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 class TimeSheetAccess
 {
  public DataTable DSLActive(string strCategory, string strCriteria)
  {
   string strSQL = "";
   switch (strCategory)
   {
    case "username":
     strSQL = "SELECT username AS pvalue, lastname + ', ' + firname AS ptext FROM HR.Employees WHERE username LIKE @values AND pstatus='1' ORDER BY lastname";
     break;
    case "firstname":
     strSQL = "SELECT username AS pvalue, lastname + ', ' + firname AS ptext FROM HR.Employees WHERE firname LIKE @values AND pstatus='1' ORDER BY lastname";
     break;
    case "lastname":
     strSQL = "SELECT username AS pvalue, lastname + ', ' + firname AS ptext FROM HR.Employees WHERE lastname LIKE @values AND pstatus='1' ORDER BY lastname";
     break;
   }
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();

    cmd.CommandText = strSQL;
    cmd.Parameters.Add(new SqlParameter("@values", "%" + strCriteria + "%"));
    cn.Open();

    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }


  public DataTable DSLUsernameAccess(string _strUsername)
  {
   DataTable tblReturn = new DataTable();
   
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT lastname + ', ' + firname AS ptext, username AS pvalue FROM HR.Employees WHERE username IN (SELECT username FROM HR.TimesheetAccess WHERE approver=@username)";
    cmd.Parameters.Add(new SqlParameter("@username", _strUsername));
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }

   return tblReturn;
  }

  public DataTable DSLDepartmentEmployees(string strDepartmentCode, string strApprover)
  {
   DataTable tblReturn = new DataTable();
   using(SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString)){
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT HR.Employees.lastname + ', ' + HR.Employees.firname AS ptext, HR.Employees.username AS pvalue FROM HR.Employees WHERE HR.Employees.deptcode = @deptcode AND username NOT IN (SELECT HR.TimesheetAccess.username FROM HR.TimesheetAccess WHERE HR.TimesheetAccess.approver=@approver)";
    cmd.Parameters.Add(new SqlParameter("@deptcode", strDepartmentCode));
    cmd.Parameters.Add(new SqlParameter("@approver", strApprover));
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public void TimesheetGrantAccess(DataTable tblSource)
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString)) 
   {
    cn.Open();
    SqlBulkCopy sbc = new SqlBulkCopy(cn);
    sbc.DestinationTableName = "HR.TimesheetAccess";
    sbc.ColumnMappings.Add("username", "username");
    sbc.ColumnMappings.Add("approver", "approver");
    sbc.WriteToServer(tblSource);
    sbc.Close();
    cn.Close();
   }
   
  }

  public void TimesheetRemoveAccess(DataTable tblSource)
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cn.Open();

    foreach (DataRow drw in tblSource.Rows)
    {
     cmd.CommandText = "DELETE FROM  HR.TimesheetAccess WHERE username=@username AND  approver=@approver";
     cmd.Parameters.Add(new SqlParameter("@username", drw["username"].ToString()));
     cmd.Parameters.Add(new SqlParameter("@approver", drw["approver"].ToString()));
     cmd.ExecuteNonQuery();
     cmd.Parameters.Clear();
    }
   }
  }

 }
}
