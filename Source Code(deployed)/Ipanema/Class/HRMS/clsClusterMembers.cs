using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS 
{

 public class clsClusterMembers : IDisposable
 {
  public clsClusterMembers() { }

  private string _strUsername;
  private string _strClusterCode;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public string ClusterCode { set { _strClusterCode = value; } get { return _strClusterCode; } }

  public int Insert()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "INSERT INTO HR.EmployeeCluster VALUES(@username,@cluscode)";
    cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);    
    cmd.Parameters.Add("@cluscode", SqlDbType.Char, 3);
    cmd.Parameters["@username"].Value = _strUsername;
    cmd.Parameters["@cluscode"].Value = _strClusterCode;    
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
    cmd.CommandText = "DELETE FROM HR.EmployeeCluster WHERE cluscode='" + _strClusterCode + "' AND username='" + _strUsername + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable DSGIncluded(string pClusterCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT lastname + ', ' + firname + ' ' + midintl + '.' AS pname,jgcode,etypname,username FROM HR.Employees INNER JOIN HR.EmployeeType ON HR.Employees.etypcode = HR.EmployeeType.etypcode WHERE username IN (SELECT username FROM HR.EmployeeCluster WHERE cluscode='" + pClusterCode + "') ORDER BY lastname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSGExcluded(string pClusterCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT lastname + ', ' + firname + ' ' + midintl + '.' AS pname,jgcode,etypname,username FROM HR.Employees INNER JOIN HR.EmployeeType ON HR.Employees.etypcode = HR.EmployeeType.etypcode WHERE pstatus='1' AND username NOT IN (SELECT username FROM HR.EmployeeCluster WHERE cluscode='" + pClusterCode + "') ORDER BY lastname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }
 }

}