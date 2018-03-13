using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class Division : IDisposable
 {
  private string _strDivisionCode;
  private string _strDivisionName;
  private string _strDescription;
  private string _strDivisionHead;
  private string _strDivisionShortName;

  public Division() { }
  public Division(string pDivisionCode) { _strDivisionCode = pDivisionCode; }

  public string Code { get { return _strDivisionCode; } set { _strDivisionCode = value; } }
  public string Name { get { return _strDivisionName; } set { _strDivisionName = value; } }
  public string Description { get { return _strDescription; } set { _strDescription = value; } }
  public string Head { get { return _strDivisionHead; } set { _strDivisionHead = value; } }
  public string ShortName { get { return _strDivisionShortName; } set { _strDivisionShortName = value; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Division WHERE divicode=@divicode";
    cmd.Parameters.Add(new SqlParameter("@divicode", _strDivisionCode));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strDivisionName = dr["division"].ToString();
     _strDescription = dr["pdesc"].ToString();
     _strDivisionHead = dr["divihead"].ToString();
     _strDivisionShortName = dr["divisnam"].ToString();
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
    cmd.CommandText = "INSERT INTO HR.Division VALUES(@divicode,@division,@divisnam,@pdesc,@divihead)";
    cmd.Parameters.Add(new SqlParameter("@divicode", _strDivisionCode));
    cmd.Parameters.Add(new SqlParameter("@division", _strDivisionName));
       cmd.Parameters.Add(new SqlParameter("@divisnam", _strDivisionShortName));
    cmd.Parameters.Add(new SqlParameter("@pdesc", _strDescription));
    cmd.Parameters.Add(new SqlParameter("@divihead", _strDivisionHead));
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
    cmd.CommandText = "UPDATE HR.Division SET division=@division,divisnam=@divisnam, pdesc=@pdesc, divihead=@divihead WHERE divicode=@divicode";
    cmd.Parameters.Add(new SqlParameter("@divicode", _strDivisionCode));
    cmd.Parameters.Add(new SqlParameter("@division", _strDivisionName));
       cmd.Parameters.Add(new SqlParameter("@divisnam", _strDivisionShortName));
    cmd.Parameters.Add(new SqlParameter("@pdesc", _strDescription));
    cmd.Parameters.Add(new SqlParameter("@divihead", _strDivisionHead));
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
    cmd.CommandText = "DELETE FROM HR.Division WHERE divicode=@divicode";
    cmd.Parameters.Add(new SqlParameter("@divicode", _strDivisionCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Methods /////////
  //////////////////////////////////

  public static DataTable GetDSGFormDivisionList()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Division ORDER BY division";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDSL()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT divicode AS pvalue, division AS ptext FROM HR.Division ORDER BY division";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSLDivisionAll()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT divicode, division FROM HR.Division ORDER BY division";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     drw = tblReturn.NewRow();
     drw["pvalue"] = dr["divicode"].ToString();
     drw["ptext"] = dr["division"].ToString();
     tblReturn.Rows.Add(drw);
    }
    dr.Close();
   }
   return tblReturn;
  }

  public static string GetDivisionName(string pDivisionCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT division FROM HR.Division WHERE divicode=@divicode";
    cmd.Parameters.Add(new SqlParameter("@divicode", pDivisionCode));
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

 }
}