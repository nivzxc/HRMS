using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 class clsEmployeeMovement : IDisposable
 {
  public clsEmployeeMovement() { }

  private string _strMovementCode;
  private string _strUsername;
  private DateTime _dteEffectivityFrom;
  private DateTime _dteEffectivityTo;
  private string _strDivisionCode;
  private string _strGroupCode;
  private string _strDepartmentCode;
  private string _strJGCode;
  private string _strPosition;
  private string _strRemarks;
  private string _strCreateBy;
  private DateTime _dteCreateOn;
  private string _strModifyBy;
  private DateTime _dteModifyOn;  

  public string MovementCode { get { return _strMovementCode; } set { _strMovementCode = value; } }
  public string Username { get { return _strUsername; } set { _strUsername = value; } }
  public DateTime EffectivityFrom { get { return _dteEffectivityFrom; } set { _dteEffectivityFrom = value; } }
  public DateTime EffectivityTo { get { return _dteEffectivityTo; } set { _dteEffectivityTo = value; } }
  public string DivisionCode { get { return _strDivisionCode; } set { _strDivisionCode = value; } }
  public string GroupCode { get { return _strGroupCode; } set { _strGroupCode = value; } }
  public string DepartmentCode { get { return _strDepartmentCode; } set { _strDepartmentCode = value; } }
  public string JGCode { get { return _strJGCode; } set { _strJGCode = value; } }
  public string Position { get { return _strPosition; } set { _strPosition = value; } }
  public string Remarks { get { return _strRemarks; } set { _strRemarks = value; } }
  public string CreateBy { get { return _strCreateBy; } set { _strCreateBy = value; } }
  public DateTime CreateOn { get { return _dteCreateOn; } set { _dteCreateOn = value; } }
  public string ModifyBy { get { return _strModifyBy; } set { _strModifyBy = value; } }
  public DateTime ModifyOn { get { return _dteModifyOn; } set { _dteModifyOn = value; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.EmployeeMovement WHERE movecode='" + _strMovementCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strUsername = dr["username"].ToString();
     _dteEffectivityFrom = clsValidator.CheckDate(dr["effcfrom"].ToString());
     _dteEffectivityTo = clsValidator.CheckDate(dr["effcto"].ToString());
     _strDivisionCode = dr["divicode"].ToString();
     _strGroupCode = dr["grpcode"].ToString();
     _strDepartmentCode = dr["deptcode"].ToString();
     _strJGCode = dr["jgcode"].ToString();
     _strPosition = dr["position"].ToString();
     _strRemarks = dr["remarks"].ToString();
     _strCreateBy = dr["createby"].ToString();
     _dteCreateOn = clsValidator.CheckDate(dr["createon"].ToString());
     _strModifyBy = dr["modifyby"].ToString();
     _dteModifyOn = clsValidator.CheckDate(dr["modifyon"].ToString());
    }
    dr.Close();
   }
  }

  public int Add()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    _strMovementCode = clsEmployeeMovement.GenerateCode(_strUsername);
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "INSERT INTO HR.EmployeeMovement VALUES(@movecode,@username,@effcfrom,@effcto,@divicode,@grpcode,@deptcode,@jgcode,@position,@remarks,@createby,@createon,@modifyby,@modifyon)";
    cmd.Parameters.Add(new SqlParameter("@movecode", _strMovementCode));
    cmd.Parameters.Add(new SqlParameter("@username", _strUsername));
    cmd.Parameters.Add(new SqlParameter("@effcfrom", _dteEffectivityFrom));
    cmd.Parameters.Add(new SqlParameter("@effcto", _dteEffectivityTo));
    cmd.Parameters.Add(new SqlParameter("@divicode", _strDivisionCode));
    cmd.Parameters.Add(new SqlParameter("@grpcode", _strGroupCode));
    cmd.Parameters.Add(new SqlParameter("@deptcode", _strDepartmentCode));
    cmd.Parameters.Add(new SqlParameter("@jgcode", _strJGCode));
    cmd.Parameters.Add(new SqlParameter("@position", _strPosition));
    cmd.Parameters.Add(new SqlParameter("@remarks", _strRemarks));
    cmd.Parameters.Add(new SqlParameter("@createby", _strCreateBy));
    cmd.Parameters.Add(new SqlParameter("@createon", _dteCreateOn));
    cmd.Parameters.Add(new SqlParameter("@modifyby", _strModifyBy));
    cmd.Parameters.Add(new SqlParameter("@modifyon", _dteModifyOn));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int Edit()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.EmployeeMovement SET effcfrom=@effcfrom, effcto=@effcto, divicode=@divicode, grpcode=@grpcode, deptcode=@deptcode, jgcode=@jgcode, position=@position, remarks=@remarks, modifyby=@modifyby, modifyon=@modifyon WHERE movecode=@movecode";
    cmd.Parameters.Add(new SqlParameter("@movecode", _strMovementCode));
    cmd.Parameters.Add(new SqlParameter("@effcfrom", _dteEffectivityFrom));
    cmd.Parameters.Add(new SqlParameter("@effcto", _dteEffectivityTo));
    cmd.Parameters.Add(new SqlParameter("@divicode", _strDivisionCode));
    cmd.Parameters.Add(new SqlParameter("@grpcode", _strGroupCode));
    cmd.Parameters.Add(new SqlParameter("@deptcode", _strDepartmentCode));
    cmd.Parameters.Add(new SqlParameter("@jgcode", _strJGCode));
    cmd.Parameters.Add(new SqlParameter("@position", _strPosition));
    cmd.Parameters.Add(new SqlParameter("@remarks", _strRemarks));
    cmd.Parameters.Add(new SqlParameter("@modifyby", _strModifyBy));
    cmd.Parameters.Add(new SqlParameter("@modifyon", _dteModifyOn));
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
    cmd.CommandText = "DELETE FROM HR.EmployeeMovement WHERE movecode='" + _strMovementCode + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable DSGFormEmployeeDetails(string pUsername)
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("MovementCode");
   tblReturn.Columns.Add("DateFrom", System.Type.GetType("System.DateTime"));
   tblReturn.Columns.Add("DateTo", System.Type.GetType("System.DateTime"));
   tblReturn.Columns.Add("Department");
   tblReturn.Columns.Add("JGCode");
   tblReturn.Columns.Add("Position");
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.EmployeeMovement WHERE username='" + pUsername + "' ORDER BY movecode";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     DataRow drwN = tblReturn.NewRow();
     drwN["MovementCode"] = dr["movecode"].ToString();
     drwN["DateFrom"] = clsValidator.CheckDate(dr["effcfrom"].ToString());
     drwN["DateTo"] = clsValidator.CheckDate(dr["effcto"].ToString());
     drwN["Department"] = Department.GetName(dr["deptcode"].ToString());
     drwN["JGCode"] = dr["jgcode"].ToString();
     drwN["Position"] = dr["position"].ToString();
     tblReturn.Rows.Add(drwN);
    }
    dr.Close();
   }
   return tblReturn;
  }

  /////////////////////////////////
  ///////// Helper Class //////////
  /////////////////////////////////

  private static string GenerateCode(string pUsername)
  {
   string strReturn = "";
   string strEmployeeCode = Employee.GetEmployeeNumber(pUsername);
   string strLastCode = "";
   int intSeed = 0;

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 movecode FROM HR.EmployeeMovement WHERE username='" + pUsername + "' ORDER BY movecode DESC";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
     strLastCode = dr["movecode"].ToString();
    dr.Close();
   }

   if (strLastCode == "")
    strReturn = "MV" + strEmployeeCode + "-01";
   else
   {
    intSeed = int.Parse(strLastCode.Substring(strLastCode.Length - 2)) + 1;
    strReturn = "MV" + strEmployeeCode + "-" + ("00" + intSeed.ToString()).Substring(intSeed.ToString().Length);
   }

   return strReturn;
  }

 }
}