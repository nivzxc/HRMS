using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Ipanema.Forms;
using System.Drawing;
using System.IO;
using System.Data.OleDb;

namespace HRMS
{
 public enum FormCallers
 {
  None,
  MdiIpanema,
  DepartmentApproverAdd,
  DivisionList,
  EmployeeDetails,
  EmployeeList,
  EmployeeNew,
  EmployeeScheduleInsert,
  EmployeeScheduleList,
  EmployeeScheduleUpdate,
  EmployeeTypeList,
  JobGradeList,
  HolidayEdit,
  HolidayNew,
  LeaveEntitlementList,
  LeaveList,
  OBNew,
  OBList,
  RecruitmentSourceList,
  ResignationReasonList,
  ScheduleList,
  ShiftList,
  TimeCardList,
  Timesheet,
  TimesheetPeriodList,
  TimesheetProcess,
  UndertimeList
 }

 public enum EFormType
 {
  Leave,
  Undertime,
  Overtime,
  OfficialBussiness
 }

 public static class HRMSCore
 {
  private static string _strUsername;
  private static string _strPassword;
  private static DateTime _dteLoginDate;
  private static string _strAccessLevel;
  private static mdiIpanema _mdiIpanema;
 
  [STAThread]
  static void Main()
  {
   Application.EnableVisualStyles();
   Application.SetCompatibleTextRenderingDefault(false);
   Application.Run(new frmLogin());
  }

  public static mdiIpanema MDIParentIpanema { set { _mdiIpanema = value; } get { return _mdiIpanema; } }
        //public static string HrmsConnectionString { get { return "data source=carlos; initial catalog=MySTIHQ; user id=mystihq; password=sp33do"; } }
        //public static string HrmsConnectionString { get { return "data source=hades; initial catalog=mystihq; user id=usermystihq; password=F0r3v3rho"; } }
        //public static string HrmsConnectionString { get { return "data source=hatshepsut.cnwsjht2ssio.ap-southeast-1.rds.amazonaws.com,1433; initial catalog=db_myphilfirst; user id=mvergara; password=1Mast3rk3y"; } } 

        //////////PFIC DATABASE Connection string////////////////////
        public static string HrmsConnectionString { get { return @"data source=W2K12R2-MIS; initial catalog=HR_TEST_DB; user id=sa; password=H1!dm2017"; } }
        //public static string HrmsConnectionString { get { return @"data source=W2K12R2-MIS; initial catalog=MySTIHQ; user id=sa; password=H1!dm2017"; } }

        //////////BIOMETRIC ACCESS DB Connection string////////////////////
        ///////////////////// ADDED BY CALVIN /////////////////////////////
        //public static string BiometricConnectionString { get { return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Jovelle-pc\eds ars\data.mdb; Password=6eds97"; } }
        
        //////////// HQ BIOMETRIC ACCESS DATABASE CONNECTION //////////////
        public static string BiometricConnectionString { get { return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\JOVELLE-PC\eds ars\data.mdb;Jet OLEDB:Database Password=6eds97"; } }
       
        //////////// CEBU & MANILA BRANCH BIOMETRIC ACCESS DATABASE CONNECTION //////////////
        public static string BranchBiometricConnectionString { get { return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\JOVELLE-PC\TIME MASTER Timekeeping System (X639 - PRO)\TIMEMASTER.MDB;Jet OLEDB:Database Password="; } }
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////


        //public static string HrmsConnectionString { get { return "data source=thebar; initial catalog=MySTIHQ2; user id=sa; password=thebar"; } }
        //public static string HrmsConnectionString { get { return "Data Source=203.176.117.204,1433;Network Library=dbmssocn;Initial Catalog=MySTIHQ;User ID=mystihq;Password=sp33do;"; } }
        //public static string HrmsConnectionString { get { return "data source=thebar; initial catalog=MySTIHQ2; user id=sa; password=thebar"; } }
        //public static string ACMConnectionString  { get { return @"data source=TIMEKEEPING\SQLEXPRESS; initial catalog=ACM; user id=sa; password=t1m3"; } }
        // public static string ACMConnectionString { get { return @"data source=ALFONSO\SQLEXPRESS; initial catalog=ACM; user id=sa; password=t1m3"; } }
        public static string ACMConnectionString { get { return @"data source=thebar; initial catalog=ACM2; user id=sa; password=thebar"; } }
  //public static string ACMConnectionString { get { return @"data source=thebar; initial catalog=ACM; user id=sa; password=thebar"; } }
  public static string ACMMigrationConnectionString { get { return @"data source=thebar; initial catalog=ACM; user id=sa; password=thebar"; } }

  public static string RequiredTotalWorkHoursKey   { get { return "000000001"; } }

  public static string Username { get { return _strUsername; } set { _strUsername = value; } }
  public static string Password { get { return _strPassword; } set { _strPassword = value; } }
  public static DateTime LoginDate { get { return _dteLoginDate; } set { _dteLoginDate = value; } }
  public static string AccessLevel { get { return _strAccessLevel; } set { _strAccessLevel = value; } }
  public static int WorkHoursPerDay { get { return 8; } }

  public static int ExecuteSQL(string pCommandText)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = pCommandText;
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public static bool Login(string pUsername, string pPassword)
  {
   bool blnReturn = false;
   bool blnCorrectAccount = false;

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM Users.Users WHERE username=@username AND pword=@pword";
    cmd.Parameters.Add(new SqlParameter("@username", pUsername));
    cmd.Parameters.Add(new SqlParameter("@pword", pPassword));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnCorrectAccount = dr.Read();
    dr.Close();
    cmd.Parameters.Clear();
    
    if (blnCorrectAccount)
    {
     cmd.CommandText = "SELECT * FROM Users.UsersModules WHERE username=@username AND modlcode='012' AND pstatus='1'"; 
     cmd.Parameters.Add(new SqlParameter("@username", pUsername));
     dr = cmd.ExecuteReader();
     blnReturn = dr.Read();
     dr.Close();
    }
    
   }

   if (blnReturn)
   {
    _strUsername = pUsername;
    _strPassword = pPassword;
    _dteLoginDate = DateTime.Now;
   }
   return blnReturn;
  }

  public static void UpdateStatusBarFormInfo(string pText)
  {
   _mdiIpanema.FormControlFormInfo.Text = pText;
  }
 }
}