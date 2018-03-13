using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class clsRC:IDisposable
 {
  public clsRC()
  {
   _strRcCode = "";
   _strRcName = "";
   _strDivisionCode = "";
   _strGPCode = "";
   _strCompanyCode = "";
   _strStatus = "";
  }

  private string _strRcCode;
  private string _strRcName;
  private string _strDivisionCode;
  private string _strGPCode;
  private string _strCompanyCode;
  private string _strStatus;
  private string _strCreateBy;
  private DateTime _dteCreateOn;
  private string _strModifyBy;
  private DateTime _dteModifyOn;

  public string RcCode { get { return _strRcCode; } set { _strRcCode = value; } }
  public string RcName { get { return _strRcName; } set { _strRcName = value; } }
  public string DivisionCode { get { return _strDivisionCode; } set { _strDivisionCode = value; } }
  public string GPCode { get { return _strGPCode; } set { _strGPCode = value; } }
  public string CompanyCode { get { return _strCompanyCode; } set { _strCompanyCode = value; } }
  public string Status { get { return _strStatus; } set { _strStatus = value; } }
  public string CreateBy { get { return _strCreateBy; } set { _strCreateBy = value; } }
  public DateTime CreateOn { get { return _dteCreateOn; } set { _dteCreateOn = value; } }
  public string ModifyBy { get { return _strModifyBy; } set { _strModifyBy = value; } }
  public DateTime ModifyOn { get { return _dteModifyOn; } set { _dteModifyOn = value; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Rc WHERE rccode='" + _strRcCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strRcName = dr["rcname"].ToString();
     _strDivisionCode = dr["divicode"].ToString();
     _strGPCode = dr["gpcode"].ToString();
     _strCompanyCode = dr["comcode"].ToString();
     _strStatus = dr["status"].ToString();
     _strCreateBy = dr["createby"].ToString();
     _dteCreateOn = clsValidator.CheckDate(dr["createon"].ToString());
     _strModifyBy = dr["modifyby"].ToString();
     _dteModifyOn = clsValidator.CheckDate(dr["modifyon"].ToString());
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
    cmd.CommandText = "INSERT INTO HR.RC VALUES(@rccode,@rcname,@divicode,@gpcode,@comcode,@pstatus,@createby,@createon,@modifyby,@modifyon)";
    cmd.Parameters.Add(new SqlParameter("@rccode", _strRcCode));
    cmd.Parameters.Add(new SqlParameter("@rcname", _strRcName));
    cmd.Parameters.Add(new SqlParameter("@divicode", _strDivisionCode));
    cmd.Parameters.Add(new SqlParameter("@gpcode", _strGPCode));
    cmd.Parameters.Add(new SqlParameter("@comcode", _strCompanyCode));    
    cmd.Parameters.Add(new SqlParameter("@pstatus", _strStatus));
    cmd.Parameters.Add(new SqlParameter("@createby", ""));
    cmd.Parameters.Add(new SqlParameter("@createon", DateTime.Now));
    cmd.Parameters.Add(new SqlParameter("@modifyby", ""));
    cmd.Parameters.Add(new SqlParameter("@modifyon", DateTime.Now));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();

    cmd.CommandText = "UPDATE Speedo.Keys SET pvalue=pvalue+1 WHERE pkey='deptcode'";
    cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int Update()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.RC SET rcname=@rcname, divicode=@divicode, gpcode=@gpcode, comcode=@comcode, status=@pstatus, modifyby=@modifyby, modifyon=@modifyon WHERE rccode=@rccode";
    cmd.Parameters.Add(new SqlParameter("@rccode", _strRcCode));
    cmd.Parameters.Add(new SqlParameter("@rcname", _strRcName));
    cmd.Parameters.Add(new SqlParameter("@divicode", _strDivisionCode));
    cmd.Parameters.Add(new SqlParameter("@gpcode", _strGPCode));
    cmd.Parameters.Add(new SqlParameter("@comcode", _strCompanyCode));
    cmd.Parameters.Add(new SqlParameter("@pstatus", _strStatus));
    cmd.Parameters.Add(new SqlParameter("@modifyby", ""));
    cmd.Parameters.Add(new SqlParameter("@modifyon", DateTime.Now));
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
    cmd.CommandText = "DELETE FROM HR.RC WHERE rccode='" + _strRcCode + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable DSGMainForm()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("RCCode");
   tblReturn.Columns.Add("RCName");
   tblReturn.Columns.Add("Division");
   tblReturn.Columns.Add("GPCode");
   tblReturn.Columns.Add("Company");
   tblReturn.Columns.Add("Status");

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.RC ORDER BY rcname";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     DataRow drw = tblReturn.NewRow();
     drw["RCCode"] = dr["rccode"].ToString();
     drw["RCName"] = dr["rcname"].ToString();
     drw["Division"] = Division.GetDivisionName(dr["divicode"].ToString());
     drw["GPCode"] = dr["gpcode"].ToString();
     drw["Company"] = clsCompany.GetName(dr["comcode"].ToString());
     drw["Status"] = (dr["status"].ToString() == "1" ? "Enabled" : "Disabled");
     tblReturn.Rows.Add(drw);
    }
    dr.Close();
   }
   return tblReturn;
  }

  public static string GetRCName(string pRcCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT rcname FROM HR.Rc WHERE rccode='" + pRcCode + "'";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { strReturn = ""; }
   }
   return strReturn;
  }

  public static DataTable GetDdlDs()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT rccode AS pValue,rcname AS pText FROM HR.Rc ORDER BY rcname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    cn.Open();
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDdlDsByDivisionCode(string pDivicode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT rccode AS pValue,rcname AS pText FROM HR.Rc WHERE divicode='" + pDivicode + "' ORDER BY rcname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    cn.Open();
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDataTable(string pDivicode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT rccode,rcname FROM HR.Rc WHERE divicode='" + pDivicode + "' ORDER BY rcname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    cn.Open();
    da.Fill(tblReturn);
    cn.Close();
   }
   return tblReturn;
  }

  public static string GetSQLInClauseGP(string pDivision)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT gpcode FROM HR.Rc WHERE divicode='" + pDivision + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     if (strReturn == "")
      strReturn = dr["gpcode"].ToString();
     else
      strReturn = strReturn + "','" + dr["gpcode"].ToString();
    }
    dr.Close();
   }
   return strReturn;
  }

  public static bool IsRcCodeExist(string pRcCode)
  {
      bool blnReturn = false;
      using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
      {
          SqlCommand cmd = cn.CreateCommand();
          cmd.CommandText = "SELECT * FROM HR.Rc WHERE rccode=@rccode";
          cmd.Parameters.Add(new SqlParameter("@rccode", pRcCode));
          cn.Open();
          SqlDataReader dr = cmd.ExecuteReader();
          blnReturn = dr.Read();
          dr.Close();
      }
      return blnReturn;
  }

 }
}