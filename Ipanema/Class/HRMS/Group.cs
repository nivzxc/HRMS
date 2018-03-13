using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class Group : IDisposable
 {
  private string _strGroupCode;
  private string _strGroupName;
  private string _strDivisionCode;

  public Group() { }
  public Group(string pGroupCode) { _strGroupCode = pGroupCode; }

  public string GroupCode { get { return _strGroupCode; } set { _strGroupCode = value; } }
  public string GroupName { get { return _strGroupName; } set { _strGroupName = value; } }
  public string DivisionCode { get { return _strDivisionCode; } set { _strDivisionCode = value; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Groups WHERE grpcode=@grpcode";
    cmd.Parameters.Add(new SqlParameter("@grpcode", _strGroupCode));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strGroupName = dr["grpname"].ToString();
     _strDivisionCode = dr["divicode"].ToString();
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
    cmd.CommandText = "INSERT INTO HR.Groups VALUES(@grpcode,@grpname,@divicode)";
    cmd.Parameters.Add("@grpcode", SqlDbType.Char, 2);
    cmd.Parameters.Add("@grpname", SqlDbType.VarChar, 50);
    cmd.Parameters.Add("@divicode", SqlDbType.VarChar, 6);
    cmd.Parameters["@grpcode"].Value = _strGroupCode;
    cmd.Parameters["@grpname"].Value = _strGroupName;
    cmd.Parameters["@divicode"].Value = _strDivisionCode;
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
    cmd.CommandText = "UPDATE HR.Groups SET grpname=@grpname, divicode=@divicode WHERE grpcode=@grpcode";
    cmd.Parameters.Add("@grpcode", SqlDbType.Char, 2);
    cmd.Parameters.Add("@grpname", SqlDbType.VarChar, 50);
    cmd.Parameters.Add("@divicode", SqlDbType.VarChar, 6);
    cmd.Parameters["@grpcode"].Value = _strGroupCode;
    cmd.Parameters["@grpname"].Value = _strGroupName;
    cmd.Parameters["@divicode"].Value = _strDivisionCode;
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
    cmd.CommandText = "DELETE FROM HR.Groups WHERE grpcode=@grpcode";
    cmd.Parameters.Add(new SqlParameter("@grpcode", _strGroupCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable DSGFormGroupList()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("GroupCode");
   tblReturn.Columns.Add("GroupName");
   tblReturn.Columns.Add("Division");

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Groups ORDER BY grpname";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     DataRow drwN = tblReturn.NewRow();
     drwN["GroupCode"] = dr["grpcode"].ToString();
     drwN["GroupName"] = dr["grpname"].ToString();
     drwN["Division"] = Division.GetDivisionName(dr["divicode"].ToString());
     tblReturn.Rows.Add(drwN);
    }
    dr.Close();
   }
   return tblReturn;
  }

  public static DataTable GetDSL()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT grpcode AS pvalue, grpname AS ptext FROM HR.Groups ORDER BY grpname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDSL(string pDivisionCode)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT grpcode AS pvalue, grpname AS ptext FROM HR.Groups WHERE divicode=@divicode ORDER BY grpname";
    cmd.Parameters.Add(new SqlParameter("@divicode", pDivisionCode));
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

   DataTable tblGroup = Group.GetDSL();
   foreach (DataRow drw in tblGroup.Rows)
   {
    drwNew = tblReturn.NewRow();
    drwNew["pvalue"] = drw["pvalue"].ToString();
    drwNew["ptext"] = drw["ptext"].ToString();
    tblReturn.Rows.Add(drwNew);
   }

   return tblReturn;
  }

  public static DataTable GetDSLAll(string pDivisionCode)
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");
   DataRow drwNew = tblReturn.NewRow();
   drwNew["pvalue"] = "ALL";
   drwNew["ptext"] = "All";
   tblReturn.Rows.Add(drwNew);

   DataTable tblGroup = Group.GetDSL(pDivisionCode);
   foreach (DataRow drw in tblGroup.Rows)
   {
    drwNew = tblReturn.NewRow();
    drwNew["pvalue"] = drw["pvalue"].ToString();
    drwNew["ptext"] = drw["ptext"].ToString();
    tblReturn.Rows.Add(drwNew);
   }

   return tblReturn;
  }

  public static string GetGroupName(string pGroupCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT grpname FROM HR.Groups WHERE grpcode=@grpcode";
    cmd.Parameters.Add(new SqlParameter("@grpcode", pGroupCode));
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static string GenerateCode()
  {
       string strReturn = "";
       using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
       {
        SqlCommand cmd = cn.CreateCommand();
        cmd.CommandText = "SELECT TOP 1 grpcode FROM HR.Groups ORDER BY grpcode DESC";
        cn.Open();
        try { strReturn = cmd.ExecuteScalar().ToString(); }
        catch { }
       }
            if (strReturn != "")
            {
                strReturn = (clsValidator.CheckInteger(strReturn) + 1).ToString();
                strReturn = ("00" + strReturn).Substring(strReturn.Length);
            }
            else {
                strReturn = "01";
            }
       return strReturn;
  }

 }
}
