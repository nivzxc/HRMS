using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{

 public class clsUsers : IDisposable
 {
  private string _strUsername;
  private string _strPassword;
  private string _strLastName;
  private string _strFirstName;
  private string _strMiddleName;
  private string _strNickName;
  private string _strEmail;
  private DateTime _dteBirthDate;
  private string _strTitle;
  private string _strGender;
  private string _strOnline;
  private DateTime _dteLastLog;
  private string _strUserClass;
  private string _strStatus;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public string Password { set { _strPassword = value; } get { return _strPassword; } }
  public string LastName { set { _strLastName = value; } get { return _strLastName; } }
  public string FirstName { set { _strFirstName = value; } get { return _strFirstName; } }
  public string MiddleName { set { _strMiddleName = value; } get { return _strMiddleName; } }
  public string NickName { set { _strNickName = value; } get { return _strNickName; } }
  public string Email { set { _strEmail = value; } get { return _strEmail; } }
  public DateTime BirthDate { set { _dteBirthDate = value; } get { return _dteBirthDate; } }
  public string Title { set { _strTitle = value; } get { return _strTitle; } }
  public string Gender { set { _strGender = value; } get { return _strGender; } }
  public string Online { set { _strOnline = value; } get { return _strOnline; } }
  public DateTime LastLog { set { _dteLastLog = value; } get { return _dteLastLog; } }
  public string UserClass { set { _strUserClass = value; } get { return _strUserClass; } }
  public string Status { set { _strStatus = value; } get { return _strStatus; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM Users.Users WHERE username='" + _strUsername + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strUsername = dr["username"].ToString();
     _strPassword = dr["pword"].ToString();
     _strLastName = dr["lastname"].ToString();
     _strFirstName = dr["firname"].ToString();
     _strMiddleName = dr["midname"].ToString();
     _strNickName = dr["nickname"].ToString();
     _strEmail = dr["email"].ToString();
     _dteBirthDate = clsValidator.CheckDate(dr["brthdate"].ToString());
     _strTitle = dr["emptitle"].ToString();
     _strGender = dr["gender"].ToString();
     _strOnline = dr["online"].ToString();
     _dteLastLog = clsValidator.CheckDate(dr["lastlog"].ToString());
     _strUserClass = dr["userclss"].ToString();
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
    cmd.CommandText = "INSERT INTO Users.Users VALUES(@username,@pword,@lastname,@firname,@midname,@nickname,@email,@brthdate,@emptitle,@gender,@online,@lastlog,@userclss,@pstatus)";
    cmd.Parameters.Add(new SqlParameter("@username", _strUsername));
    cmd.Parameters.Add(new SqlParameter("@pword", _strPassword));
    cmd.Parameters.Add(new SqlParameter("@lastname", _strLastName));
    cmd.Parameters.Add(new SqlParameter("@firname", _strFirstName));
    cmd.Parameters.Add(new SqlParameter("@midname", _strMiddleName));
    cmd.Parameters.Add(new SqlParameter("@nickname", _strNickName));
    cmd.Parameters.Add(new SqlParameter("@email", _strEmail));
    cmd.Parameters.Add(new SqlParameter("@brthdate", _dteBirthDate));
    cmd.Parameters.Add(new SqlParameter("@emptitle", _strTitle));
    cmd.Parameters.Add(new SqlParameter("@gender", _strGender));
    cmd.Parameters.Add(new SqlParameter("@online", _strOnline));
    cmd.Parameters.Add(new SqlParameter("@lastlog", _dteLastLog));
    cmd.Parameters.Add(new SqlParameter("@userclss", _strUserClass));
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
    cmd.CommandText = "UPDATE Users.Users SET pword=@pword, lastname=@lastname, firname=@firname, midname=@midname, nickname=@nickname, email=@email, brthdate=@brthdate, emptitle=@emptitle, gender=@gender, online=@online, lastlog=@lastlog, userclss=@userclss, pstatus=@pstatus WHERE username=@username";
    cmd.Parameters.Add(new SqlParameter("@username", _strUsername));
    cmd.Parameters.Add(new SqlParameter("@pword", _strPassword));
    cmd.Parameters.Add(new SqlParameter("@lastname", _strLastName));
    cmd.Parameters.Add(new SqlParameter("@firname", _strFirstName));
    cmd.Parameters.Add(new SqlParameter("@midname", _strMiddleName));
    cmd.Parameters.Add(new SqlParameter("@nickname", _strNickName));
    cmd.Parameters.Add(new SqlParameter("@email", _strEmail));
    cmd.Parameters.Add(new SqlParameter("@brthdate", _dteBirthDate));
    cmd.Parameters.Add(new SqlParameter("@emptitle", _strTitle));
    cmd.Parameters.Add(new SqlParameter("@gender", _strGender));
    cmd.Parameters.Add(new SqlParameter("@online", _strOnline));
    cmd.Parameters.Add(new SqlParameter("@lastlog", _dteLastLog));
    cmd.Parameters.Add(new SqlParameter("@userclss", _strUserClass));
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
    cmd.CommandText = "DELETE FROM Users.Users WHERE username=@username";
    cmd.Parameters.Add(new SqlParameter("@username", _strUsername));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable GetDSG(string pWhere)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username,lastname + ', ' + firname AS pname,emptitle,pstatus FROM Users.Users " + pWhere;
    cn.Open();
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDSLStatusAll()
  {
   DataTable tblReturn = new DataTable();

   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "0";
   drw["ptext"] = "Disabled";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "1";
   drw["ptext"] = "Active";
   tblReturn.Rows.Add(drw);
   return tblReturn;
  }

  public static DataTable GetDSLStatus()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "0";
   drw["ptext"] = "Disabled";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "1";
   drw["ptext"] = "Active";
   tblReturn.Rows.Add(drw);
   return tblReturn;
  }

  public static DataTable GetDSLUserName()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username AS pvalue, username AS ptext FROM HR.Employees WHERE username NOT IN (SELECT username FROM Users.Users) AND pstatus='1' ORDER BY username";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static void SetActive(string pUsername)
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE Users.Users SET pstatus='1' WHERE username='" + pUsername + "'";
    cn.Open();
    cmd.ExecuteNonQuery();
   }
  }

  public static void SetInActive(string pUsername)
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE Users.Users SET pstatus='0' WHERE username='" + pUsername + "'";
    cn.Open();
    cmd.ExecuteNonQuery();
   }
  }

 }

}