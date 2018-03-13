using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class clsOffense : IDisposable
 {
  private string _strOffenseCode;
  private string _strUsername;
  private string _strDetails;
  private string _strClassCode;
  private DateTime _dteDateStart;
  private DateTime _dteDateEnd;
  private string _strEnabled;
  private string _strCreateBy;
  private DateTime _dteCreateOn;
  private string _strModifyBy;
  private DateTime _dteModifyOn;

  public clsOffense()
  {
   _strOffenseCode = "";
   _strUsername = "";
   _strDetails = "";
   _strClassCode = "";
   _dteDateStart = clsDateTime.SystemMinDate;
   _dteDateEnd = clsDateTime.SystemMinDate;
   _strEnabled = "";
   _strCreateBy = "";
   _dteCreateOn = clsDateTime.SystemMinDate;
   _strModifyBy = "";
   _dteModifyOn = clsDateTime.SystemMinDate;
  }

  public string OffenseCode { set { _strOffenseCode = value; } get { return _strOffenseCode; } }
  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public string Details { set { _strDetails = value; } get { return _strDetails; } }
  public string ClassCode { set { _strClassCode = value; } get { return _strClassCode; } }
  public DateTime DateStart { get { return _dteDateStart; } set { _dteDateStart = value; } }
  public DateTime DateEnd { get { return _dteDateEnd; } set { _dteDateEnd = value; } }
  public string Enabled { set { _strEnabled = value; } get { return _strEnabled; } }
  public string CreateBy { set { _strCreateBy = value; } get { return _strCreateBy; } }
  public DateTime CreateOn { get { return _dteCreateOn; } }
  public string ModifyBy { set { _strModifyBy = value; } get { return _strModifyBy; } }
  public DateTime ModifyOn { get { return _dteModifyOn; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Offense WHERE offncode=@offncode";
    cmd.Parameters.Add(new SqlParameter("@offncode", _strOffenseCode));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strOffenseCode = dr["offncode"].ToString();
     _strUsername = dr["username"].ToString();
     _strDetails = dr["xdetails"].ToString();
     _strClassCode = dr["oclscode"].ToString();
     _dteDateStart = clsValidator.CheckDate(dr["datestrt"].ToString());
     _dteDateEnd = clsValidator.CheckDate(dr["dateend"].ToString());
     _strEnabled = dr["enabled"].ToString();
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
   int intSeed = 0;

   SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString);
   cn.Open();
   SqlTransaction tran = cn.BeginTransaction();
   SqlCommand cmd = cn.CreateCommand();
   cmd.Transaction = tran;
   try
   {
    cmd.CommandText = "SELECT pvalue FROM Speedo.Keys WHERE pkey='offncode'";
    intSeed = clsValidator.CheckInteger(cmd.ExecuteScalar().ToString());
    _strOffenseCode = ("000000000" + intSeed.ToString()).Substring(intSeed.ToString().Length);

    cmd.CommandText = "INSERT INTO HR.Offense VALUES(@offncode,@username,@xdetails,@oclscode,@datestrt,@dateend,@enabled,@createby,@createon,@modifyby,@modifyon)";
    cmd.Parameters.Add(new SqlParameter("@offncode", _strOffenseCode));
    cmd.Parameters.Add(new SqlParameter("@username", _strUsername));
    cmd.Parameters.Add(new SqlParameter("@xdetails", _strDetails));
    cmd.Parameters.Add(new SqlParameter("@oclscode", _strClassCode));
    cmd.Parameters.Add(new SqlParameter("@datestrt", _dteDateStart));
    cmd.Parameters.Add(new SqlParameter("@dateend", _dteDateEnd));
    cmd.Parameters.Add(new SqlParameter("@enabled", _strEnabled));
    cmd.Parameters.Add(new SqlParameter("@createby", _strCreateBy));
    cmd.Parameters.Add(new SqlParameter("@createon", DateTime.Now));
    cmd.Parameters.Add(new SqlParameter("@modifyby", _strModifyBy));
    cmd.Parameters.Add(new SqlParameter("@modifyon", DateTime.Now));
    intReturn = cmd.ExecuteNonQuery();

    if (intReturn > 0)
    {
     cmd.CommandText = "UPDATE Speedo.Keys SET pvalue=pvalue+1 WHERE pkey='offncode'";
     cmd.ExecuteNonQuery();
    }

    tran.Commit();
   }
   catch
   {
    tran.Rollback();
   }
   finally
   {
    cn.Close();
   }
   return intReturn;
  }

  public int Update()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Offense SET xdetails=@xdetails, oclscode=@oclscode, datestrt=@datestrt, dateend=@dateend, enabled=@enabled, modifyby=@modifyby, modifyon=@modifyon WHERE offncode=@offncode";
    cmd.Parameters.Add(new SqlParameter("@offncode", _strOffenseCode));
    cmd.Parameters.Add(new SqlParameter("@xdetails", _strDetails));
    cmd.Parameters.Add(new SqlParameter("@oclscode", _strClassCode));
    cmd.Parameters.Add(new SqlParameter("@datestrt", _dteDateStart));
    cmd.Parameters.Add(new SqlParameter("@dateend", _dteDateEnd));
    cmd.Parameters.Add(new SqlParameter("@enabled", _strEnabled));
    cmd.Parameters.Add(new SqlParameter("@modifyby", _strModifyBy));
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
    cmd.CommandText = "DELETE FROM HR.Offense WHERE offncode=@offncode";
    cmd.Parameters.Add(new SqlParameter("@offncode", _strOffenseCode));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable GetDSGMainForm()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("OffenseCode");
   tblReturn.Columns.Add("Name");
   tblReturn.Columns.Add("Details");
   tblReturn.Columns.Add("Class");
   tblReturn.Columns.Add("DateStart");
   tblReturn.Columns.Add("DateEnd");
   tblReturn.Columns.Add("Enabled");

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Offense ORDER BY xdetails";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     DataRow drwN = tblReturn.NewRow();
     drwN["OffenseCode"] = dr["offncode"].ToString();
     drwN["Name"] = Employee.GetName(dr["username"].ToString());
     drwN["Details"] = dr["xdetails"].ToString();
     drwN["Class"] = dr["oclscode"].ToString();
     drwN["DateStart"] = clsValidator.CheckDate(dr["datestrt"].ToString()).ToString("MM/dd/yyyy");
     drwN["DateEnd"] = clsValidator.CheckDate(dr["dateend"].ToString()).ToString("MM/dd/yyyy");
     drwN["Enabled"] = (dr["enabled"].ToString() == "1" ? "Yes" : "No");
     tblReturn.Rows.Add(drwN);
    }
    dr.Close();
   }
   return tblReturn;
  }

  public static DataTable GetDSLClass()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");
   for (int i = 1; i <= 5; i++)
   {
    DataRow drwN = tblReturn.NewRow();
    drwN["pvalue"] = i.ToString();
    drwN["ptext"] = i.ToString();
    tblReturn.Rows.Add(drwN);
   }
   return tblReturn;
  }

  public static DataTable GetDSGMainFormNotification()
  {
      DataTable tblReturn = new DataTable();
      using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
      {
          SqlCommand cmd = cn.CreateCommand();
          cmd.CommandText = "SELECT offncode AS offensecode, username AS usernameviolation, (SELECT lastname FROM HR.Employees WHERE HR.Employees.username = HR.Offense.username) AS lastnameviolation, (SELECT firname FROM HR.Employees WHERE HR.Employees.username = HR.Offense.username) AS firstnameviolation FROM HR.Offense WHERE CONVERT(varchar(11),HR.Offense.dateend,1)  <= @dateend AND enabled = '1'";
          cmd.Parameters.Add(new SqlParameter("@dateend", DateTime.Now));
          SqlDataAdapter da = new SqlDataAdapter(cmd);
          da.Fill(tblReturn);
      }
      return tblReturn;
  }

 }
}