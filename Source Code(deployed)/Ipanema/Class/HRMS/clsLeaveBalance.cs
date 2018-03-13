using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{

 class LeaveApplicationBalance : IDisposable
 {

  public LeaveApplicationBalance() { }

  private string _strUsername;
  private string _strLeaveTypeCode;
  private float _fltBalance;
  private float _fltEntitlement;
  private string _strStatus;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public string LeaveTypeCode { set { _strLeaveTypeCode = value; } get { return _strLeaveTypeCode; } }
  public float Balance { set { _fltBalance = value; } get { return _fltBalance; } }
  public float Entitlement { set { _fltEntitlement = value; } get { return _fltEntitlement; } }
  public string Status { set { _strStatus = value; } get { return _strStatus; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.LeaveBalance WHERE username='" + _strUsername + "' AND leavtype='" + _strLeaveTypeCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strUsername = dr["username"].ToString();
     _strLeaveTypeCode = dr["leavtype"].ToString();
     _fltBalance = clsValidator.CheckFloat(dr["pbalance"].ToString());
     _fltEntitlement = clsValidator.CheckFloat(dr["entitle"].ToString());
     _strStatus = dr["pstatus"].ToString();
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
    cmd.CommandText = "INSERT INTO HR.LeaveBalance VALUES(@username,@leavtype,@pbalance,@entitle,@pstatus)";
    cmd.Parameters.AddWithValue("@username", _strUsername);
    cmd.Parameters.AddWithValue("@leavtype", _strLeaveTypeCode);
    cmd.Parameters.AddWithValue("@pbalance", _fltBalance);
    cmd.Parameters.AddWithValue("@entitle", _fltEntitlement);
    cmd.Parameters.AddWithValue("@pstatus", _strStatus);
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
    cmd.CommandText = "UPDATE HR.LeaveBalance SET pbalance=@pbalance, entitle=@entitle, pstatus=@pstatus WHERE username=@username AND leavtype=@leavtype";
    cmd.Parameters.AddWithValue("@username", _strUsername);
    cmd.Parameters.AddWithValue("@leavtype", _strLeaveTypeCode);
    cmd.Parameters.AddWithValue("@pbalance", _fltBalance);
    cmd.Parameters.AddWithValue("@entitle", _fltEntitlement);
    cmd.Parameters.AddWithValue("@pstatus", _strStatus);
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
    cmd.CommandText = "DELETE FROM HR.LeaveBalance WHERE username=@username AND leavtype=@leavtype";
    cmd.Parameters.AddWithValue("@username", _strUsername);
    cmd.Parameters.AddWithValue("@leavtype", _strLeaveTypeCode);
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Methods /////////
  //////////////////////////////////
     //gerard static method
  public static DataTable DSGZeroEL(string pEL)
  {
      DataTable tblReturn = new DataTable();
      using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
      {
          SqlCommand cmd = cn.CreateCommand();
          cmd.CommandText = "SELECT HR.Employees.lastname, HR.employees.firname FROM HR.LeaveBalance, HR.Employees WHERE HR.LeaveBalance.pbalance = '0' AND HR.LeaveBalance.pstatus = '1' AND HR.LeaveBalance.leavtype = (SELECT HR.LeaveSetting.leavtype FROM HR.LeaveSetting WHERE HR.LeaveSetting.leavname LIKE 'Emergency Leave') AND HR.LeaveBalance.username = HR.Employees.username ORDER BY lastname";
          //cmd.Parameters.Add(new SqlParameter("@pel", "%emergency%"));
          SqlDataAdapter da = new SqlDataAdapter(cmd);
          da.Fill(tblReturn);
          // (SELECT withpay FROM HR.LeaveTypes WHERE leavtype=HR.LeaveBalance.leavtype)='1'
      }
      return tblReturn;
  }

  public static DataTable DSGZeroVL(string pVL)
  {
      DataTable tblReturn = new DataTable();
      using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
      {
          SqlCommand cmd = cn.CreateCommand();
          cmd.CommandText = "SELECT HR.Employees.lastname, HR.employees.firname FROM HR.LeaveBalance, HR.Employees WHERE HR.LeaveBalance.pbalance = '0' AND HR.LeaveBalance.pstatus = '1' AND HR.LeaveBalance.leavtype = (SELECT HR.LeaveSetting.leavtype FROM HR.LeaveSetting WHERE HR.LeaveSetting.leavname LIKE 'Vacation Leave') AND HR.LeaveBalance.username = HR.Employees.username ORDER BY lastname";
          //cmd.Parameters.Add(new SqlParameter("@pvl", "%vacation%"));
          SqlDataAdapter da = new SqlDataAdapter(cmd);
          da.Fill(tblReturn);
          // (SELECT withpay FROM HR.LeaveTypes WHERE leavtype=HR.LeaveBalance.leavtype)='1'
      }
      return tblReturn;
  }

  public static DataTable DSGZeroSL(string pSL)
  {
      DataTable tblReturn = new DataTable();
      using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
      {
          SqlCommand cmd = cn.CreateCommand();
          cmd.CommandText = "SELECT HR.Employees.lastname, HR.employees.firname FROM HR.LeaveBalance, HR.Employees WHERE HR.LeaveBalance.pbalance = '0' AND HR.LeaveBalance.pstatus = '1' AND HR.LeaveBalance.leavtype = (SELECT HR.LeaveSetting.leavtype FROM HR.LeaveSetting WHERE HR.LeaveSetting.leavname LIKE 'Sick Leave') AND HR.LeaveBalance.username = HR.Employees.username ORDER BY lastname";
          //cmd.Parameters.Add(new SqlParameter("@psl", "%sick%"));
          SqlDataAdapter da = new SqlDataAdapter(cmd);
          da.Fill(tblReturn);
          // (SELECT withpay FROM HR.LeaveTypes WHERE leavtype=HR.LeaveBalance.leavtype)='1'
      }
      return tblReturn;
  }
     //
  public static DataTable DSGFormLeaveEntitlementList(string pWhere)
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("Username");
   tblReturn.Columns.Add("LeaveTypeCode");
   tblReturn.Columns.Add("EmployeeName");
   tblReturn.Columns.Add("LeaveType");
   tblReturn.Columns.Add("Entitled", System.Type.GetType("System.Double"));
   tblReturn.Columns.Add("Used", System.Type.GetType("System.Double"));
   tblReturn.Columns.Add("Balance", System.Type.GetType("System.Double"));
   tblReturn.Columns.Add("Status");

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.LeaveBalance " + pWhere + "ORDER BY username,leavtype";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     DataRow drwN = tblReturn.NewRow();
     drwN["Username"] = dr["username"].ToString();
     drwN["LeaveTypeCode"] = dr["leavtype"].ToString();
     drwN["EmployeeName"] = Employee.GetName(dr["username"].ToString(), EmployeeNameFormat.LastFirst);
     drwN["LeaveType"] = LeaveApplicationTypes.GetDescription(dr["leavtype"].ToString());
     drwN["Entitled"] = clsValidator.CheckFloat(dr["entitle"].ToString());
     drwN["Used"] = clsValidator.CheckFloat(dr["entitle"].ToString()) - clsValidator.CheckFloat(dr["pbalance"].ToString());
     drwN["Balance"] = clsValidator.CheckFloat(dr["pbalance"].ToString());
     drwN["Status"] = dr["pstatus"].ToString();
     tblReturn.Rows.Add(drwN);
    }
    dr.Close();
   }
   return tblReturn;
  }

  public static DataTable NoBalanceFormListDataSource(string pLeaveType)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT lastname,firname,username FROM HR.Employees WHERE pstatus='1' AND username NOT IN (SELECT username FROM HR.LeaveBalance WHERE leavtype='" + pLeaveType + "') ORDER BY lastname,firname"; 
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDataTableEntitlementHasBalance(string pUsername)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.LeaveBalance WHERE username='" + pUsername + "' AND pstatus='1' AND leavtype IN (SELECT leavtype FROM HR.LeaveTypes WHERE hasbal='1' AND pstatus='1') ORDER BY leavtype";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDataTableEntitlement(string pUsername)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.LeaveBalance WHERE username='" + pUsername + "' AND pstatus='1' ORDER BY leavtype";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDataTableEntitlement(string pUsername, string pStatus)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.LeaveBalance WHERE username='" + pUsername + "' AND pstatus='" + pStatus + "' ORDER BY leavtype";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static void DisableRecords(string pLeaveTypeCode)
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.LeaveBalance SET pstatus='0' WHERE leavtype='" + pLeaveTypeCode + "'";
    cn.Open();
    cmd.ExecuteNonQuery();
   }
  }

  public static float GetRemainingBalance(string pUsername, string pLeaveTypeCode)
  {
   float fltReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT pbalance FROM HR.LeaveBalance WHERE username='" + pUsername + "' AND leavtype='" + pLeaveTypeCode + "'";
    cn.Open();
    try { fltReturn = clsValidator.CheckFloat(cmd.ExecuteScalar().ToString()); }
    catch { }
   }
   return fltReturn;
  }

  public static int DeductLeaveBalance(float pDeductUnit, string pUserName, string pLeaveType)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.LeaveBalance SET pbalance=pbalance-" + pDeductUnit + " WHERE username='" + pUserName + "' AND leavtype='" + pLeaveType + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public static int AddLeaveBalance(float pAddUnit, string pUserName, string pLeaveType)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.LeaveBalance SET pbalance=pbalance+" + pAddUnit + " WHERE username='" + pUserName + "' AND leavtype='" + pLeaveType + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public static DataTable DdlDsStatusAll()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "1";
   drw["ptext"] = "Active";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "0";
   drw["ptext"] = "Inactive";
   tblReturn.Rows.Add(drw);

   return tblReturn;
  }

  public static string ToLeaveBalanceStatusDesc(string pLeaveStatus)
  {
   if (pLeaveStatus == "1")
    return "Active";
   else
    return "Inactive";
  }

  public static void SetActive(string pUsername, string pLeaveType)
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.LeaveBalance SET pstatus='1' WHERE username='" + pUsername + "' AND leavtype='" + pLeaveType + "'";
    cn.Open();
    cmd.ExecuteNonQuery();
   }
  }

  public static void SetInActive(string pUsername, string pLeaveType)
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.LeaveBalance SET pstatus='0' WHERE username='" + pUsername + "' AND leavtype='" + pLeaveType + "'";
    cn.Open();
    cmd.ExecuteNonQuery();
   }
  }
 }

}