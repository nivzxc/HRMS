using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class Department : IDisposable
 {
  public Department() { }

  private string _strDepartmentCode;
  private string _strDepartmentName;
  private string _strDivisionCode;
  private string _strGroupCode;
  private string _strStatus;  

  public string DepartmentCode { get { return _strDepartmentCode; } set { _strDepartmentCode = value; } }
  public string DepartmentName { get { return _strDepartmentName; } set { _strDepartmentName = value; } }
  public string DivisionCode { get { return _strDivisionCode; } set { _strDivisionCode = value; } }
  public string GroupCode { get { return _strGroupCode; } set { _strGroupCode = value; } }
  public string Status { get { return _strStatus; } set { _strStatus = value; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Department WHERE deptcode=@deptcode";
    cmd.Parameters.Add(new SqlParameter("@deptcode", _strDepartmentCode));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strDepartmentName = dr["deptname"].ToString();
     _strDivisionCode = dr["divicode"].ToString();
     _strGroupCode = dr["grpcode"].ToString();
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
    _strDepartmentCode = GenerateCode();
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "INSERT INTO HR.Department VALUES(@deptcode,@deptname,@divicode,@grpcode,@pstatus)";
    cmd.Parameters.Add(new SqlParameter("@deptcode", _strDepartmentCode));
    cmd.Parameters.Add(new SqlParameter("@deptname", _strDepartmentName));
    cmd.Parameters.Add(new SqlParameter("@divicode", _strDivisionCode));
    cmd.Parameters.Add(new SqlParameter("@grpcode", _strGroupCode));
    cmd.Parameters.Add(new SqlParameter("@pstatus", _strStatus));
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
    cmd.CommandText = "UPDATE HR.Department SET deptname=@deptname, divicode=@divicode, grpcode=@grpcode, pstatus=@pstatus WHERE deptcode=@deptcode";
    cmd.Parameters.Add(new SqlParameter("@deptcode", _strDepartmentCode));
    cmd.Parameters.Add(new SqlParameter("@deptname", _strDepartmentName));
    cmd.Parameters.Add(new SqlParameter("@divicode", _strDivisionCode));
    cmd.Parameters.Add(new SqlParameter("@grpcode", _strGroupCode));
    cmd.Parameters.Add(new SqlParameter("@pstatus", _strStatus));
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
    cmd.CommandText = "DELETE FROM HR.Department WHERE deptcode=@deptcode";
    cmd.Parameters.Add(new SqlParameter("@deptcode", _strDepartmentCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static string GetName(string pDepartmentCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT deptname FROM HR.Department WHERE deptcode=@deptcode";
    cmd.Parameters.Add(new SqlParameter("@deptcode", pDepartmentCode));
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static DataTable GetDSL()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT deptcode AS pvalue, deptname AS ptext FROM HR.Department ORDER BY deptname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

            //ADDED BY CALVIN April 13, 2018
  public static DataTable GetDepartment(string grpCode)
  {
            DataTable tblreturn = new DataTable();
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString)) {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT deptcode AS pvalue, deptname AS ptext FROM HR.Department WHERE grpcode='"+ grpCode+"' ORDER BY deptname";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tblreturn);
            }
            return tblreturn;
  }


  public static DataTable GetDSL(string pGroupCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT deptcode AS pvalue, deptname AS ptext FROM HR.Department WHERE grpcode=@grpcode ORDER BY deptname";
    cmd.Parameters.Add(new SqlParameter("@grpcode", pGroupCode));
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDSLByDivision(string pDivisionCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT deptcode AS pvalue, deptname AS ptext FROM HR.Department WHERE divicode=@divicode ORDER BY deptname";
    cmd.Parameters.Add(new SqlParameter("@divicode", pDivisionCode));
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDSLActive()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT deptcode AS pvalue, deptname AS ptext FROM HR.Department WHERE pstatus='1' ORDER BY deptname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDSLAll()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");

   DataRow drwNew = tblReturn.NewRow();
   drwNew["pvalue"] = "ALL";
   drwNew["ptext"] = "All";
   tblReturn.Rows.Add(drwNew);

   DataTable tblDepartment = Department.GetDSL();
   foreach (DataRow drw in tblDepartment.Rows)
   {
    drwNew = tblReturn.NewRow();
    drwNew["pvalue"] = drw["pvalue"].ToString();
    drwNew["ptext"] = drw["ptext"].ToString();
    tblReturn.Rows.Add(drwNew);
   }

   return tblReturn;
  }

  public static DataTable GetDSLAll(string pGroupCode)
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");

   DataRow drwNew = tblReturn.NewRow();
   drwNew["pvalue"] = "ALL";
   drwNew["ptext"] = "All";
   tblReturn.Rows.Add(drwNew);

   DataTable tblDepartment = Department.GetDSL(pGroupCode);
   foreach (DataRow drw in tblDepartment.Rows)
   {
    drwNew = tblReturn.NewRow();
    drwNew["pvalue"] = drw["pvalue"].ToString();
    drwNew["ptext"] = drw["ptext"].ToString();
    tblReturn.Rows.Add(drwNew);
   }

   return tblReturn;
  }

  public static DataTable GetDSLAllByDivision(string pDivisionCode)
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");

   DataRow drwNew = tblReturn.NewRow();
   drwNew["pvalue"] = "ALL";
   drwNew["ptext"] = "All";
   tblReturn.Rows.Add(drwNew);

   DataTable tblDepartment = Department.GetDSLByDivision(pDivisionCode);
   foreach (DataRow drw in tblDepartment.Rows)
   {
    drwNew = tblReturn.NewRow();
    drwNew["pvalue"] = drw["pvalue"].ToString();
    drwNew["ptext"] = drw["ptext"].ToString();
    tblReturn.Rows.Add(drwNew);
   }

   return tblReturn;
  }

  public static DataTable GetDSGFormDepartmentList()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("DepartmentCode");
   tblReturn.Columns.Add("DepartmentName");
   tblReturn.Columns.Add("Group");
   tblReturn.Columns.Add("Division");
   tblReturn.Columns.Add("Enabled");
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Department ORDER BY deptname";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     DataRow drwN = tblReturn.NewRow();
     drwN["DepartmentCode"] = dr["deptcode"].ToString();
     drwN["DepartmentName"] = dr["deptname"].ToString();
     drwN["Group"] = Group.GetGroupName(dr["grpcode"].ToString());
     drwN["Division"] = Division.GetDivisionName(dr["divicode"].ToString());
     drwN["Enabled"] = dr["pstatus"].ToString();
     tblReturn.Rows.Add(drwN);
    }
    dr.Close();
   }
   return tblReturn;
  }

  public static DataTable DataTable(string pOrderBy)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Department ORDER BY " + pOrderBy;
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static string GenerateCode()
  {
   string strReturn = "";
   int intSeed = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 deptcode FROM HR.Department ORDER BY deptcode DESC";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
     strReturn = dr["deptcode"].ToString();
    dr.Close();
   }
   intSeed = clsValidator.CheckInteger(strReturn) + 1;
   strReturn = ("00" + intSeed.ToString()).Substring(intSeed.ToString().Length - 1);
   return strReturn;
  }

  public static int SetActive(string pDepartmentCode)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Department SET pstatus='1' WHERE deptcode=@deptcode";
    cmd.Parameters.Add(new SqlParameter("@deptcode", pDepartmentCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public static int SetInactive(string pDepartmentCode)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Department SET pstatus='0' WHERE deptcode=@deptcode";
    cmd.Parameters.Add(new SqlParameter("@deptcode", pDepartmentCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

 }
}