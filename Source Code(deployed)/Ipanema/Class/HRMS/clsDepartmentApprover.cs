using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class clsDepartmentApprover : IDisposable
 {
  public clsDepartmentApprover() { }

  private string _strDepartmentCode;
  private string _strUsername;
  private string _strLeave;
  private string _strUT;
  private string _strOB;
  private string _strOT;

  public string DepartmentCode { set { _strDepartmentCode = value; } get { return _strDepartmentCode; } }
  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public string CanApproveLeave { set { _strLeave = value; } get { return _strLeave; } }
  public string CanApproveUT { set { _strUT = value; } get { return _strUT; } }
  public string CanApproveOB { set { _strOB = value; } get { return _strOB; } }
  public string CanApproveOT { set { _strOT = value; } get { return _strOT; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.DepartmentApprove WHERE deptcode='" + _strDepartmentCode + "' AND username='" + _strUsername + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strLeave = dr["leave"].ToString();
     _strUT = dr["ut"].ToString();
     _strOB = dr["ob"].ToString();
     _strOT = dr["ot"].ToString();
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
    cmd.CommandText = "INSERT INTO HR.DepartmentApprover VALUES(@deptcode,@username,@leave,@ut,@ob,@ot,@rfiflag)";
    cmd.Parameters.Add(new SqlParameter("@deptcode", _strDepartmentCode));
    cmd.Parameters.Add(new SqlParameter("@username", _strUsername));
    cmd.Parameters.Add(new SqlParameter("@leave", _strLeave));
    cmd.Parameters.Add(new SqlParameter("@ut", _strUT));
    cmd.Parameters.Add(new SqlParameter("@ob", _strOB));
    cmd.Parameters.Add(new SqlParameter("@ot", _strOT));
    cmd.Parameters.Add(new SqlParameter("@rfiflag","1"));
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
    cmd.CommandText = "UPDATE SET HR.DepartmentApprover SET leave=@leave, ut=@ut, ob=@ob, ot=@ot WHERE deptcode=@deptcode AND username=@username";
    cmd.Parameters.Add(new SqlParameter("@deptcode", _strDepartmentCode));
    cmd.Parameters.Add(new SqlParameter("@username", _strUsername));
    cmd.Parameters.Add(new SqlParameter("@leave", _strLeave));
    cmd.Parameters.Add(new SqlParameter("@ut", _strUT));
    cmd.Parameters.Add(new SqlParameter("@ob", _strOB));
    cmd.Parameters.Add(new SqlParameter("@ot", _strOT));
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
    cmd.CommandText = "DELETE FROM HR.DepartmentApprover WHERE deptcode='" + _strDepartmentCode + "' AND username='" + _strUsername + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static bool IsApprover(string pUsername, string pDepartmentCode)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {

   }
   return blnReturn;
  }

  public static DataTable GetDataTable()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.DepartmentApprover ORDER BY deptcode,username";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDataTable(string pDepartmentCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.DepartmentApprover WHERE deptcode='" + pDepartmentCode + "' ORDER BY deptcode,username";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static bool IsApprover(string pUsername, EFormType pEFormType)
  {
   bool blnReturn = false;
   string strCommandText = "";
   switch (pEFormType)
   {
    case EFormType.Leave:
     strCommandText = "SELECT username FROM HR.DepartmentApprover WHERE username='" + pUsername + "' AND leave='1'";
     break;
    case EFormType.Overtime:
     strCommandText = "SELECT username FROM HR.DepartmentApprover WHERE username='" + pUsername + "' AND ot='1'";
     break;
    case EFormType.OfficialBussiness:
     strCommandText = "SELECT username FROM HR.DepartmentApprover WHERE username='" + pUsername + "' AND ob='1'";
     break;
    case EFormType.Undertime:
     strCommandText = "SELECT username FROM HR.DepartmentApprover WHERE username='" + pUsername + "' AND ut='1'";
     break;
   }

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = strCommandText;
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
   return blnReturn;
  }

  public static DataTable DdlDsByDepartment(string pDepartmentCode, EFormType pEFormType)
  {
   DataTable tblReturn = new DataTable();
   string strCommandText = "";
   switch (pEFormType)
   {
    case EFormType.Leave:
     strCommandText = "SELECT username AS pvalue,firname + ' ' + lastname AS ptext FROM Users.Users WHERE username IN (SELECT username FROM HR.DepartmentApprover WHERE deptcode='" + pDepartmentCode + "' AND leave='1') ORDER BY firname";
     break;
    case EFormType.OfficialBussiness:
     strCommandText = "SELECT username AS pvalue,firname + ' ' + lastname AS ptext FROM Users.Users WHERE username IN (SELECT username FROM HR.DepartmentApprover WHERE deptcode='" + pDepartmentCode + "' AND ob='1') ORDER BY firname";
     break;
    case EFormType.Overtime:
     strCommandText = "SELECT username AS pvalue,firname + ' ' + lastname AS ptext FROM Users.Users WHERE username IN (SELECT username FROM HR.DepartmentApprover WHERE deptcode='" + pDepartmentCode + "' AND ot='1') ORDER BY firname";
     break;
    case EFormType.Undertime:
     strCommandText = "SELECT username AS pvalue,firname + ' ' + lastname AS ptext FROM Users.Users WHERE username IN (SELECT username FROM HR.DepartmentApprover WHERE deptcode='" + pDepartmentCode + "' AND ut='1') ORDER BY firname";
     break;
   }

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = strCommandText;
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    cn.Open();
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DdlDsByEmployee(string pUsername, EFormType pEFormType)
  {
   DataTable tblReturn = new DataTable();
   string strCommandText = "";
   switch (pEFormType)
   {
    case EFormType.Leave:
     strCommandText = "SELECT username AS pvalue,firname + ' ' + lastname AS ptext FROM Users.Users WHERE username IN (SELECT username FROM HR.DepartmentApprover WHERE deptcode=(SELECT TOP 1 deptcode FROM HR.Employees WHERE username='" + pUsername + "') AND leave='1') ORDER BY firname";
     break;
    case EFormType.OfficialBussiness:
     strCommandText = "SELECT username AS pvalue,firname + ' ' + lastname AS ptext FROM Users.Users WHERE username IN (SELECT username FROM HR.DepartmentApprover WHERE deptcode=(SELECT TOP 1 deptcode FROM HR.Employees WHERE username='" + pUsername + "') AND ob='1') ORDER BY firname";
     break;
    case EFormType.Overtime:
     strCommandText = "SELECT username AS pvalue,firname + ' ' + lastname AS ptext FROM Users.Users WHERE username IN (SELECT username FROM HR.DepartmentApprover WHERE deptcode=(SELECT TOP 1 deptcode FROM HR.Employees WHERE username='" + pUsername + "') AND ot='1') ORDER BY firname";
     break;
    case EFormType.Undertime:
     strCommandText = "SELECT username AS pvalue,firname + ' ' + lastname AS ptext FROM Users.Users WHERE username IN (SELECT username FROM HR.DepartmentApprover WHERE deptcode=(SELECT TOP 1 deptcode FROM HR.Employees WHERE username='" + pUsername + "') AND ut='1') ORDER BY firname";
     break;
   }

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = strCommandText;
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    cn.Open();
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static string GetApprovers(string pDepartmentCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT lastname, firname FROM HR.Employees WHERE username IN (SELECT username FROM HR.DepartmentApprover WHERE deptcode='" + pDepartmentCode + "')";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     if (strReturn == "")
      strReturn = dr["firname"].ToString() + " " + dr["lastname"].ToString();
     else
      strReturn = strReturn + ", " + dr["firname"].ToString() + " " + dr["lastname"].ToString();
    }
    dr.Close();
   }
   return (strReturn == "" ? "None" : strReturn);
  }

 }
}