using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class MigrationACM : IDisposable
 {
  private int _intControllerId;
  private int _intDoorId;
  private string _strDoor;
  private string _strCardId;
  private int _intPersonalId;
  private DateTime _dteTDate;
  private DateTime _dteTTime;
  private int _intEventId;
  private string _strStaffId;
  private DateTime _dteDT;
  private string _strJobCode;
  private int _intjobInOut;
  private string _strTSurname;
  private string _strTName;
  private string _strpviewed;
  private string _strAcmuser;
  private string _strAcmevent;
  private int _intTransID;

  public int ControllerID { get { return _intControllerId; } set { _intControllerId = value; } }
  public int DoorID { get { return _intDoorId; } set { _intDoorId = value; } }
  public string Door { get { return _strDoor; } set { _strDoor = value; } }
  public string CardID { get { return _strCardId; } set { _strCardId = value; } }
  public int PersonalID { get { return _intPersonalId; } set { _intPersonalId = value; } }
  public DateTime TDate { get { return _dteTDate; } set { _dteTDate = value; } }
  public DateTime TTime { get { return _dteTTime; } set { _dteTTime = value; } }
  public int EventId { get { return _intEventId; } set { _intEventId = value; } }
  public string StaffID { get { return _strStaffId; } set { _strStaffId = value; } }
  public DateTime DT { get { return _dteDT; } set { _dteDT = value; } }
  public string JobCode { get { return _strJobCode; } set { _strJobCode = value; } }
  public int JobInOut { get { return _intjobInOut; } set { _intjobInOut = value; } }
  public string TSurName { get { return _strTSurname; } set { _strTSurname = value; } }
  public string TName { get { return _strTName; } set { _strTName = value; } }
  public string pviewed { get { return _strpviewed; } set { _strpviewed = value; } }
  public string ACMuser { get { return _strAcmuser; } set { _strAcmuser = value; } }
  public string ACMevent { get { return _strAcmevent; } set { _strAcmevent = value; } }
  public int TransID { get { return _intTransID; } set { _intTransID = value; } }


  public int InsertTransact()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.ACMConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cn.Open();
    cmd.CommandText = "INSERT INTO Transact (ControllerID, DoorID, Door, CardID, PersonalID, TDate, TTime, EventID, StaffID, DT, JobCode, JobInOut, TSurName, TName) VALUES (@controllerid, @doorid, @door, @cardid, @personalid, @tdate, @ttime, @eventid, @staffid, @dt, @jobcode, @jobinout, @tsurname, @tname)";
    cmd.Parameters.Add(new SqlParameter("@controllerid", _intControllerId));
    cmd.Parameters.Add(new SqlParameter("@doorid", _intDoorId));
    cmd.Parameters.Add(new SqlParameter("@door", _strDoor));
    cmd.Parameters.Add(new SqlParameter("@cardid", _strCardId));
    cmd.Parameters.Add(new SqlParameter("@personalid", _intPersonalId));
    cmd.Parameters.Add(new SqlParameter("@tdate", _dteTDate));
    cmd.Parameters.Add(new SqlParameter("@ttime", _dteTTime));
    cmd.Parameters.Add(new SqlParameter("@eventid", _intEventId));
    cmd.Parameters.Add(new SqlParameter("@staffid", _strStaffId));
    cmd.Parameters.Add(new SqlParameter("@dt", _dteDT));
    cmd.Parameters.Add(new SqlParameter("@jobcode", _strJobCode));
    cmd.Parameters.Add(new SqlParameter("@jobinout", _intjobInOut));
    cmd.Parameters.Add(new SqlParameter("@tsurname", _strTSurname));
    cmd.Parameters.Add(new SqlParameter("@tname", _strTName));
    intReturn = cmd.ExecuteNonQuery();
    cn.Close();
   }
   return intReturn;
  }

  public int InsertTransactLogs()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.ACMConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cn.Open();
    cmd.CommandText = "INSERT INTO TransactInsertLogs (StaffID, DoorID, EventID, TDate, TTime, pviewed) VALUES (@staffid, @doorid, @eventid, @tdate, @ttime, @pviewed)";
    cmd.Parameters.Add(new SqlParameter("@staffid", _strStaffId));
    cmd.Parameters.Add(new SqlParameter("@doorid", _intDoorId));
    cmd.Parameters.Add(new SqlParameter("@eventid", _intEventId));
    cmd.Parameters.Add(new SqlParameter("@tdate", _dteTDate));
    cmd.Parameters.Add(new SqlParameter("@ttime", _dteTTime));
    cmd.Parameters.Add(new SqlParameter("@pviewed", _strpviewed));

    intReturn = cmd.ExecuteNonQuery();
    cn.Close();
   }
   return intReturn;
  }

  public int InsertACMLogs()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.ACMConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cn.Open();
    cmd.CommandText = "INSERT INTO ACMlog (logdate, logtime, ACMuser, ACMevent, TransID) VALUES (@logdate, @logtime, @acmuser, @acmevent, @transid)";
    cmd.Parameters.Add(new SqlParameter("@logdate", _dteTDate));
    cmd.Parameters.Add(new SqlParameter("@logtime", _dteTTime));
    cmd.Parameters.Add(new SqlParameter("@acmuser", _strAcmuser));
    cmd.Parameters.Add(new SqlParameter("@acmevent", _strAcmevent));
    cmd.Parameters.Add(new SqlParameter("@transid", _intTransID));
    intReturn = cmd.ExecuteNonQuery();
    cn.Close();
   }
   return intReturn;
  }

  public int DeleteTransact(DateTime pStart, DateTime pEnd)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.ACMConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cn.Open();
    cmd.CommandText = "DELETE FROM Transact WHERE TDAte BETWEEN @datestart AND @dateend";
    cmd.Parameters.Add(new SqlParameter("@datestart", pStart));
    cmd.Parameters.Add(new SqlParameter("@dateend", pEnd));
    intReturn = cmd.ExecuteNonQuery();
    cn.Close();
   }
   return intReturn;
  }

  public int DeleteTransactLogs(DateTime pStart, DateTime pEnd)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.ACMConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cn.Open();
    cmd.CommandText = "DELETE FROM TransactInsertLogs WHERE TDAte BETWEEN @datestart AND @dateend";
    cmd.Parameters.Add(new SqlParameter("@datestart", pStart));
    cmd.Parameters.Add(new SqlParameter("@dateend", pEnd));
    intReturn = cmd.ExecuteNonQuery();
    cn.Close();
   }
   return intReturn;
  }

  public int DeleteACMLogs(DateTime pStart, DateTime pEnd)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.ACMConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cn.Open();
    cmd.CommandText = "DELETE FROM ACMlog WHERE logdate BETWEEN @datestart AND @dateend";
    cmd.Parameters.Add(new SqlParameter("@datestart", pStart));
    cmd.Parameters.Add(new SqlParameter("@dateend", pEnd));
    intReturn = cmd.ExecuteNonQuery();
    cn.Close();
   }
   return intReturn;
  }


  public void Dispose() { GC.SuppressFinalize(this); }

  ///////////////////
  ///static member///
  ///////////////////

  public static int GetCountTransact(DateTime pStart, DateTime pEnd)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.ACMMigrationConnectionString))
   {
    using (SqlCommand cmd = cn.CreateCommand())
    {
     cmd.CommandText = "SELECT COUNT(*) AS CountTransact FROM Transact WHERE TDAte BETWEEN @datestart AND @dateend";
     cmd.Parameters.Add(new SqlParameter("@datestart", pStart));
     cmd.Parameters.Add(new SqlParameter("@dateend", pEnd));
     cn.Open();
     intReturn = clsValidator.CheckInteger(cmd.ExecuteScalar().ToString());
     cn.Close();
    }
   }
   return intReturn;
  }

  public static int GetCountTransactLogs(DateTime pStart, DateTime pEnd)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.ACMMigrationConnectionString))
   {
    using (SqlCommand cmd = cn.CreateCommand())
    {
     cmd.CommandText = "SELECT COUNT(*) AS CountTransact FROM TransactInsertLogs WHERE TDAte BETWEEN @datestart AND @dateend";
     cmd.Parameters.Add(new SqlParameter("@datestart", pStart));
     cmd.Parameters.Add(new SqlParameter("@dateend", pEnd));
     cn.Open();
     intReturn = clsValidator.CheckInteger(cmd.ExecuteScalar().ToString());
     cn.Close();
    }
   }
   return intReturn;
  }

  public static int GetCountACMlog(DateTime pStart, DateTime pEnd)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.ACMMigrationConnectionString))
   {
    using (SqlCommand cmd = cn.CreateCommand())
    {
     cmd.CommandText = "SELECT COUNT(*) AS CountTransact FROM ACMlog WHERE logdate BETWEEN @datestart AND @dateend";
     cmd.Parameters.Add(new SqlParameter("@datestart", pStart));
     cmd.Parameters.Add(new SqlParameter("@dateend", pEnd));
     cn.Open();
     intReturn = clsValidator.CheckInteger(cmd.ExecuteScalar().ToString());
     cn.Close();
    }
   }
   return intReturn;
  }

  public static DataTable GetDSGTransact(DateTime pStart, DateTime pEnd)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.ACMMigrationConnectionString))
   {
    using (SqlCommand cmd = cn.CreateCommand())
    {
     cmd.CommandText = "SELECT TransID, ControllerID, DoorID, Door, CardID, PersonalID, TDate, TTime, EventID, StaffID, DT, JobCode, JobInOut, TSurName, TName FROM Transact WHERE TDAte BETWEEN @datestart AND @dateend";
     cmd.Parameters.Add(new SqlParameter("@datestart", pStart));
     cmd.Parameters.Add(new SqlParameter("@dateend", pEnd));
     SqlDataAdapter da = new SqlDataAdapter(cmd);
     da.Fill(tblReturn);
    }
   }
   return tblReturn;
  }

  public static DataTable GetDSGTransactLogs(DateTime pStart, DateTime pEnd)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.ACMMigrationConnectionString))
   {
    using (SqlCommand cmd = cn.CreateCommand())
    {
     cmd.CommandText = "SELECT StaffID, DoorID, EventID, TDate, TTime, pviewed FROM TransactInsertLogs WHERE TDAte BETWEEN @datestart AND @dateend";
     cmd.Parameters.Add(new SqlParameter("@datestart", pStart));
     cmd.Parameters.Add(new SqlParameter("@dateend", pEnd));
     SqlDataAdapter da = new SqlDataAdapter(cmd);
     da.Fill(tblReturn);
    }
   }
   return tblReturn;
  }

  public static DataTable GetDSGACMLogs(DateTime pStart, DateTime pEnd)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.ACMMigrationConnectionString))
   {
    using (SqlCommand cmd = cn.CreateCommand())
    {
     cmd.CommandText = "SELECT logdate, logtime, acmuser, acmevent, transid FROM ACMlog WHERE logdate BETWEEN @datestart AND @dateend";
     cmd.Parameters.Add(new SqlParameter("@datestart", pStart));
     cmd.Parameters.Add(new SqlParameter("@dateend", pEnd));
     SqlDataAdapter da = new SqlDataAdapter(cmd);
     da.Fill(tblReturn);
    }
   }
   return tblReturn;
  }

  public static string GetPersonalID(string pStaffId)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.ACMConnectionString))
   {
    using (SqlCommand cmd = cn.CreateCommand())
    {
     cmd.CommandText = "SELECT PersonalID FROM personal WHERE StaffID=@staffid";
     cmd.Parameters.Add(new SqlParameter("@staffid", pStaffId));
     cn.Open();
     try { strReturn = cmd.ExecuteScalar().ToString(); }
     catch { }
     finally { cn.Close(); }
    }
   }
    return strReturn;
  }

 }
}
