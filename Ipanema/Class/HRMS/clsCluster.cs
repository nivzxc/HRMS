using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class clsCluster : IDisposable
 {
  public clsCluster() { }

  private string _strClusterCode;
  private string _strClusterName;
  private string _strDescription;
  private string _strEnabled;
  private string _strCreateBy;
  private DateTime _dteCreateOn;
  private string _strUpdateBy;
  private DateTime _dteUpdateOn;

  public string ClusterCode { get { return _strClusterCode; } set { _strClusterCode = value; } }
  public string ClusterName { get { return _strClusterName; } set { _strClusterName = value; } }
  public string Description { get { return _strDescription; } set { _strDescription = value; } }
  public string Enabled { get { return _strEnabled; } set { _strEnabled = value; } }
  public string CreateBy { get { return _strCreateBy; } }
  public DateTime CreateOn { get { return _dteCreateOn; } }
  public string UpdateBy { get { return _strUpdateBy; } }
  public DateTime UpdateOn { get { return _dteUpdateOn; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Cluster WHERE cluscode='" + _strClusterCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strClusterCode = dr["cluscode"].ToString();
     _strClusterName = dr["clusname"].ToString();
     _strDescription = dr["clusdesc"].ToString();
     _strEnabled = dr["penabled"].ToString();
     _strCreateBy = dr["createby"].ToString();
     _dteCreateOn = clsValidator.CheckDate(dr["createon"].ToString());
     _strUpdateBy = dr["updateby"].ToString();
     _dteUpdateOn = clsValidator.CheckDate(dr["updateon"].ToString());
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
    cmd.CommandText = "INSERT INTO HR.Cluster VALUES(@cluscode,@clusname,@clusdesc,@penabled,@createby,@createon,@updateby,@updateon)";
    cmd.Parameters.Add("@cluscode", SqlDbType.Char, 3);
    cmd.Parameters.Add("@clusname", SqlDbType.VarChar, 50);
    cmd.Parameters.Add("@clusdesc", SqlDbType.Text);
    cmd.Parameters.Add("@penabled", SqlDbType.Char, 1);
    cmd.Parameters.Add("@createby", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@createon", SqlDbType.DateTime);
    cmd.Parameters.Add("@updateby", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@updateon", SqlDbType.DateTime);

    cmd.Parameters["@cluscode"].Value = GenerateCode();
    cmd.Parameters["@clusname"].Value = _strClusterName;
    cmd.Parameters["@clusdesc"].Value = _strDescription;
    cmd.Parameters["@penabled"].Value = _strEnabled;
    cmd.Parameters["@createby"].Value = HRMSCore.Username;
    cmd.Parameters["@createon"].Value = DateTime.Now;
    cmd.Parameters["@updateby"].Value = HRMSCore.Username;
    cmd.Parameters["@updateon"].Value = DateTime.Now;
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
    cmd.CommandText = "UPDATE HR.Cluster SET clusname=@clusname, clusdesc=@clusdesc, penabled=@penabled, updateby=@updateby, updateon=@updateon WHERE cluscode=@cluscode";
    cmd.Parameters.Add("@cluscode", SqlDbType.Char, 3);
    cmd.Parameters.Add("@clusname", SqlDbType.VarChar, 50);
    cmd.Parameters.Add("@clusdesc", SqlDbType.Text);
    cmd.Parameters.Add("@penabled", SqlDbType.Char, 1);
    cmd.Parameters.Add("@updateby", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@updateon", SqlDbType.DateTime);

    cmd.Parameters["@cluscode"].Value = _strClusterCode;
    cmd.Parameters["@clusname"].Value = _strClusterName;
    cmd.Parameters["@clusdesc"].Value = _strDescription;
    cmd.Parameters["@penabled"].Value = _strEnabled;
    cmd.Parameters["@updateby"].Value = HRMSCore.Username;
    cmd.Parameters["@updateon"].Value = DateTime.Now;
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
    cmd.CommandText = "DELETE FROM HR.Cluster WHERE cluscode=@cluscode";
    cmd.Parameters.Add(new SqlParameter("@cluscode", _strClusterCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static string GenerateCode()
  {
   string strReturn = "";
   int intSeed = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 cluscode FROM HR.Cluster ORDER BY cluscode DESC";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
     strReturn = dr["cluscode"].ToString();
    dr.Close();
   }
   intSeed = clsValidator.CheckInteger(strReturn) + 1;
   strReturn = ("00" + intSeed.ToString()).Substring(intSeed.ToString().Length - 1);
   return strReturn;
  }

  public static DataTable GetDataTable()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Cluster ORDER BY cluscode";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static int Enable(string pClusterCode)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Cluster SET penabled='1' WHERE cluscode=@cluscode";
    cmd.Parameters.Add(new SqlParameter("@cluscode", pClusterCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public static int Disable(string pClusterCode)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Cluster SET penabled='0' WHERE cluscode='" + pClusterCode + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public static DataTable GetDdlDs()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT cluscode AS pvalue, clusname AS ptext FROM HR.Cluster WHERE penabled='1' ORDER BY clusname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }
  
        //ADDED BY CALVIN CAVITE DATE: 4/10/2018
  public static string getClusterName(string clustname) 
  {
            string clustName = "";
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString)) {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT clusname FROM HR.Cluster WHERE clusname='" + clustname + "'";
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();                
                if (dr.Read())
                {
                    clustName = dr["clusname"].ToString();
                }
                dr.Close();
                cn.Close();
            }
            return clustName;
  }

 }
}