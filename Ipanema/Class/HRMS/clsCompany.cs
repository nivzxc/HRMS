using System;
using System.Data;
using System.Data.SqlClient;
using HRMS;

namespace HRMS
{
 class clsCompany
 {
  private string _strCompanyCode;
  private string _strName;
  private string _strRemarks;

  public clsCompany() { }

  public clsCompany(string pCompanyCode) { _strCompanyCode = pCompanyCode; }
  public string CompanyCode { set { _strCompanyCode = value; } get { return _strCompanyCode; } }
  public string Name { set { _strName = value; } get { return _strName; } }
  public string Remarks { set { _strRemarks = value; } get { return _strRemarks; } }

  public int Insert()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "INSERT INTO Speedo.Company VALUES(@comcode,@comname,@comrem)";
    cmd.Parameters.Add("@comcode", SqlDbType.Char, 5);
    cmd.Parameters.Add("@comname", SqlDbType.VarChar, 50);
    cmd.Parameters.Add("@comrem", SqlDbType.VarChar, 255);
    cmd.Parameters["@comcode"].Value = _strCompanyCode;
    cmd.Parameters["@comname"].Value = _strName;
    cmd.Parameters["@comrem"].Value = _strRemarks;
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
    cmd.CommandText = "UPDATE Speedo.Company SET comname=@comname, comrem=@comrem WHERE comcode=@comcode";
    cmd.Parameters.Add("@comcode", SqlDbType.Char, 5);
    cmd.Parameters.Add("@comname", SqlDbType.VarChar, 50);
    cmd.Parameters.Add("@comrem", SqlDbType.VarChar, 255);
    cmd.Parameters["@comcode"].Value = _strCompanyCode;
    cmd.Parameters["@comname"].Value = _strName;
    cmd.Parameters["@comrem"].Value = _strRemarks;
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
    cmd.CommandText = "DELETE FROM Speedo.Company WHERE comcode='" + _strCompanyCode + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  ////////// Static Members //////////

  public static string GetName(string pCompanyCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT comname FROM Speedo.Company WHERE comcode='" + pCompanyCode + "'";
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
    cmd.CommandText = "SELECT comcode AS pvalue, comname AS ptext FROM Speedo.Company ORDER BY comname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

 }

}
