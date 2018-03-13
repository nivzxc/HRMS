using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using Ipanema.Forms;

namespace HRMS
{

 public class clsTimesheet: IDisposable
 {
  public clsTimesheet() { }

  private const int RoundDecimal = 2;
  private static DateTime NightDifferentialStart1 = new DateTime(2006, 2, 9, 0, 00, 00);
  private static DateTime NightDifferentialEnd1 = new DateTime(2006, 2, 9, 6, 00, 00);
  private static DateTime NightDifferentialStart2 = new DateTime(2006, 2, 9, 22, 00, 00);
  private static DateTime NightDifferentialEnd2 = new DateTime(2006, 2, 9, 0, 00, 00);

  ///////////////////////////////////////////////
  ///////// Timesheet Processing Fields /////////
  ///////////////////////////////////////////////

  private string[] _strpEmployeeList;
  private DateTime _dtepDateStart;
  private DateTime _dtepDateEnd;
  private ProgressBar _prgpProgressBar;
  private Label _lblpLabelProcessEmployee;
  private Label _lblpLabelProcessRemarks;
  private frmTimesheetProcessDialog _frmpTimesheetProcessDialog;

  public string[] pEmployeeList { set { _strpEmployeeList = value; } get { return _strpEmployeeList; } }
  public DateTime pDateStart { set { _dtepDateStart = value; } get { return _dtepDateStart; } }
  public DateTime pDateEnd { set { _dtepDateEnd = value; } get { return _dtepDateEnd; } }
  public ProgressBar pProgressBar { set { _prgpProgressBar = value; } get { return _prgpProgressBar; } }
  public Label pLabelProcessEmployee { set { _lblpLabelProcessEmployee = value; } get { return _lblpLabelProcessEmployee; } }
  public Label pLabelProcessRemarks { set { _lblpLabelProcessRemarks = value; } get { return _lblpLabelProcessRemarks; } }
  public frmTimesheetProcessDialog pTimesheetProcessDialog { set { _frmpTimesheetProcessDialog = value; } get { return _frmpTimesheetProcessDialog; } }

  private string _strUsername;
  private DateTime _dteFocusDate;
  private DateTime _dteTimeIn;
  private DateTime _dteTimeOut;
  private string _strShiftCode;
  private DateTime _dteShiftIn;
  private DateTime _dteShiftOut;
  private float _fltTotalUnit;
  private float _fltWorkUnit;
  private float _fltAbsentUnit;
  private float _fltLeaveWithPay;
  private float _fltLeaveWithoutPay;
  private float _fltLateUnit;
  private float _fltUndertimeUnit;
  private float _fltTCUnit;
  private float _fltOBUnit;
  private float _fltExcessUnit;
  private float _fltRegularOT;
  private float _fltRegularND;
  private float _fltRestDayOT;
  private float _fltRestDayND;
  private float _fltRestDayEX;
  private float _fltSpecialHolidayOT;
  private float _fltSpecialHolidayND;
  private float _fltSpecialHolidayEX;
  private float _fltRegularHolidayOT;
  private float _fltRegularHolidayND;
  private float _fltRegularHolidayEX;
  private float _fltRestDaySpecialHolidayOT;
  private float _fltRestDaySpecialHolidayND;
  private float _fltRestDaySpecialHolidayEX;
  private float _fltRestDayRegularHolidayOT;
  private float _fltRestDayRegularHolidayND;
  private float _fltRestDayRegularHolidayEX;
  private DateTime _dteLastUpdateDate;
  private string _strLastUpdateBy;
  private string _strStatus;  

  public string Username { get { return _strUsername; } set { _strUsername = value; } }
  public DateTime FocusDate { get { return _dteFocusDate; } set { _dteFocusDate = value; } }
  public DateTime TimeIn { get { return _dteTimeIn; } set { _dteTimeIn = value; } }
  public DateTime TimeOut { get { return _dteTimeOut; } set { _dteTimeOut = value; } }
  public string ShiftCode { get { return _strShiftCode; } set { _strShiftCode = value; } }
  public DateTime ShiftIn { get { return _dteShiftIn; } set { _dteShiftIn = value; } }
  public DateTime ShiftOut { get { return _dteShiftOut; } set { _dteShiftOut = value; } }
  public float TotalUnit { get { return _fltTotalUnit; } set { _fltTotalUnit = value; } }
  public float WorkUnit { get { return _fltWorkUnit; } set { _fltWorkUnit = value; } }
  public float AbsentUnit { get { return _fltAbsentUnit; } set { _fltAbsentUnit = value; } }
  public float LeaveWithPay { get { return _fltLeaveWithPay; } set { _fltLeaveWithPay = value; } }
  public float LeaveWithoutPay { get { return _fltLeaveWithoutPay; } set { _fltLeaveWithoutPay = value; } }
  public float LateUnit { get { return _fltLateUnit; } set { _fltLateUnit = value; } }
  public float UndertimeUnit { get { return _fltUndertimeUnit; } set { _fltUndertimeUnit = value; } }
  public float TCUnit { get { return _fltTCUnit; } set { _fltTCUnit = value; } }
  public float OBUnit { get { return _fltOBUnit; } set { _fltOBUnit = value; } }
  public float ExcessUnit { get { return _fltExcessUnit; } set { _fltExcessUnit = value; } }
  public float RegularOT { get { return _fltRegularOT; } set { _fltRegularOT = value; } }
  public float RegularND { get { return _fltRegularND; } set { _fltRegularND = value; } }
  public float RestDayOT { get { return _fltRestDayOT; } set { _fltRestDayOT = value; } }
  public float RestDayND { get { return _fltRestDayND; } set { _fltRestDayND = value; } }
  public float RestDayEX { get { return _fltRestDayEX; } set { _fltRestDayEX = value; } }
  public float SpecialHolidayOT { get { return _fltSpecialHolidayOT; } set { _fltSpecialHolidayOT = value; } }
  public float SpecialHolidayND { get { return _fltSpecialHolidayND; } set { _fltSpecialHolidayND = value; } }
  public float SpecialHolidayEX { get { return _fltSpecialHolidayEX; } set { _fltSpecialHolidayEX = value; } }
  public float RegularHolidayOT { get { return _fltRegularHolidayOT; } set { _fltRegularHolidayOT = value; } }
  public float RegularHolidayND { get { return _fltRegularHolidayND; } set { _fltRegularHolidayND = value; } }
  public float RegularHolidayEX { get { return _fltRegularHolidayEX; } set { _fltRegularHolidayEX = value; } }
  public float RestDaySpecialHolidayOT { get { return _fltRestDaySpecialHolidayOT; } set { _fltRestDaySpecialHolidayOT = value; } }
  public float RestDaySpecialHolidayND { get { return _fltRestDaySpecialHolidayND; } set { _fltRestDaySpecialHolidayND = value; } }
  public float RestDaySpecialHolidayEX { get { return _fltRestDaySpecialHolidayEX; } set { _fltRestDaySpecialHolidayEX = value; } }
  public float RestDayRegularHolidayOT { get { return _fltRestDayRegularHolidayOT; } set { _fltRestDayRegularHolidayOT = value; } }
  public float RestDayRegularHolidayND { get { return _fltRestDayRegularHolidayND; } set { _fltRestDayRegularHolidayND = value; } }
  public float RestDayRegularHolidayEX { get { return _fltRestDayRegularHolidayEX; } set { _fltRestDayRegularHolidayEX = value; } }
  public string LastUpdateBy { get { return _strLastUpdateBy; } set { _strLastUpdateBy = value; } }
  public DateTime LastUpdateDate { get { return _dteLastUpdateDate; } set { _dteLastUpdateDate = value; } }
  public string Status { get { return _strStatus; } set { _strStatus = value; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Timesheet WHERE username='" + _strUsername + "' AND focsdate='" + _dteFocusDate + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _dteTimeIn = clsValidator.CheckDate(dr["timein"].ToString());
     _dteTimeOut = clsValidator.CheckDate(dr["timeout"].ToString());
     _strShiftCode = dr["shftcode"].ToString();
     _dteShiftIn = clsValidator.CheckDate(dr["shftin"].ToString());
     _dteShiftOut = clsValidator.CheckDate(dr["shftout"].ToString());
     _fltTotalUnit = clsValidator.CheckFloat(dr["ttalunit"].ToString());
     _fltWorkUnit = clsValidator.CheckFloat(dr["workunit"].ToString());
     _fltAbsentUnit = clsValidator.CheckFloat(dr["absunit"].ToString());
     _fltLeaveWithPay = clsValidator.CheckFloat(dr["lwithpay"].ToString());
     _fltLeaveWithoutPay = clsValidator.CheckFloat(dr["lwoutpay"].ToString());
     _fltLateUnit = clsValidator.CheckFloat(dr["lateunit"].ToString());
     _fltUndertimeUnit = clsValidator.CheckFloat(dr["undrunit"].ToString());
     _fltTCUnit = clsValidator.CheckFloat(dr["tcunit"].ToString());
     _fltOBUnit = clsValidator.CheckFloat(dr["obunit"].ToString());
     _fltExcessUnit = clsValidator.CheckFloat(dr["xcssunit"].ToString());
     _fltRegularOT = clsValidator.CheckFloat(dr["reguxcss"].ToString());
     _fltRegularND = clsValidator.CheckFloat(dr["regunght"].ToString());
     _fltRestDayOT = clsValidator.CheckFloat(dr["restover"].ToString());
     _fltRestDayND = clsValidator.CheckFloat(dr["restnght"].ToString());
     _fltRestDayEX = clsValidator.CheckFloat(dr["restxcss"].ToString());
     _fltSpecialHolidayOT = clsValidator.CheckFloat(dr["spclover"].ToString());
     _fltSpecialHolidayND = clsValidator.CheckFloat(dr["spclnght"].ToString());
     _fltSpecialHolidayEX = clsValidator.CheckFloat(dr["spclxcss"].ToString());
     _fltRegularHolidayOT = clsValidator.CheckFloat(dr["leglover"].ToString());
     _fltRegularHolidayND = clsValidator.CheckFloat(dr["leglnght"].ToString());
     _fltRegularHolidayEX = clsValidator.CheckFloat(dr["leglxcss"].ToString());
     _fltRestDaySpecialHolidayOT = clsValidator.CheckFloat(dr["shrdover"].ToString());
     _fltRestDaySpecialHolidayND = clsValidator.CheckFloat(dr["shrdnght"].ToString());
     _fltRestDaySpecialHolidayEX = clsValidator.CheckFloat(dr["shrdxcss"].ToString());
     _fltRestDayRegularHolidayOT = clsValidator.CheckFloat(dr["lerdover"].ToString());
     _fltRestDayRegularHolidayND = clsValidator.CheckFloat(dr["lerdnght"].ToString());
     _fltRestDayRegularHolidayEX = clsValidator.CheckFloat(dr["lerdxcss"].ToString());
     _strLastUpdateBy = dr["lastby"].ToString();
     _dteLastUpdateDate = clsValidator.CheckDate(dr["lastdate"].ToString());
     _strStatus = dr["pstatus"].ToString();
    }
    dr.Close();
   }
  }

  public int Insert(string pShiftMode)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "INSERT INTO HR.Timesheet VALUES(@username,@focsdate,@timein,@timeout,@shftcode,@shftin,@shftout,@ttalunit,@workunit,@absunit,@lwithpay,@lwoutpay,@lateunit,@undrunit,@tcunit,@obunit,@xcssunit,@reguxcss,@regunght,@restover,@restnght,@restxcss,@spclover,@spclnght,@spclxcss,@leglover,@leglnght,@leglxcss,@shrdover,@shrdnght,@shrdxcss,@lerdover,@lerdnght,@lerdxcss,@lastby,@lastdate,@pstatus)";    	
    cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@focsdate", SqlDbType.DateTime);
    cmd.Parameters.Add("@timein", SqlDbType.DateTime);
    cmd.Parameters.Add("@timeout", SqlDbType.DateTime);
    cmd.Parameters.Add("@shftcode", SqlDbType.Char, 8);
    cmd.Parameters.Add("@shftin", SqlDbType.DateTime);
    cmd.Parameters.Add("@shftout", SqlDbType.DateTime);
    cmd.Parameters.Add("@ttalunit", SqlDbType.Float);
    cmd.Parameters.Add("@workunit", SqlDbType.Float);
    cmd.Parameters.Add("@absunit", SqlDbType.Float);
    cmd.Parameters.Add("@lwithpay", SqlDbType.Float);
    cmd.Parameters.Add("@lwoutpay", SqlDbType.Float);
    cmd.Parameters.Add("@lateunit", SqlDbType.Float);
    cmd.Parameters.Add("@undrunit", SqlDbType.Float);
    cmd.Parameters.Add("@tcunit", SqlDbType.Float);
    cmd.Parameters.Add("@obunit", SqlDbType.Float);
    cmd.Parameters.Add("@xcssunit", SqlDbType.Float);
    cmd.Parameters.Add("@reguxcss", SqlDbType.Float);
    cmd.Parameters.Add("@regunght", SqlDbType.Float);
    cmd.Parameters.Add("@restover", SqlDbType.Float);
    cmd.Parameters.Add("@restnght", SqlDbType.Float);
    cmd.Parameters.Add("@restxcss", SqlDbType.Float);
    cmd.Parameters.Add("@spclover", SqlDbType.Float);
    cmd.Parameters.Add("@spclnght", SqlDbType.Float);
    cmd.Parameters.Add("@spclxcss", SqlDbType.Float);
    cmd.Parameters.Add("@leglover", SqlDbType.Float);
    cmd.Parameters.Add("@leglnght", SqlDbType.Float);
    cmd.Parameters.Add("@leglxcss", SqlDbType.Float);
    cmd.Parameters.Add("@shrdover", SqlDbType.Float);
    cmd.Parameters.Add("@shrdnght", SqlDbType.Float);
    cmd.Parameters.Add("@shrdxcss", SqlDbType.Float);
    cmd.Parameters.Add("@lerdover", SqlDbType.Float);
    cmd.Parameters.Add("@lerdnght", SqlDbType.Float);
    cmd.Parameters.Add("@lerdxcss", SqlDbType.Float);
    cmd.Parameters.Add("@lastby", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@lastdate", SqlDbType.DateTime);    
    cmd.Parameters.Add("@pstatus", SqlDbType.Char, 1);

    cmd.Parameters["@username"].Value = _strUsername;
    cmd.Parameters["@focsdate"].Value = _dteFocusDate;

    if (_dteTimeIn == clsDateTime.SystemMinDate)
     cmd.Parameters["@timein"].Value = DBNull.Value;
    else
     cmd.Parameters["@timein"].Value = _dteTimeIn;

    if (_dteTimeOut == clsDateTime.SystemMinDate)
     cmd.Parameters["@timeout"].Value = DBNull.Value;
    else
     cmd.Parameters["@timeout"].Value = _dteTimeOut;

    cmd.Parameters["@shftcode"].Value = _strShiftCode;

    if (_dteShiftIn == clsDateTime.SystemMinDate || pShiftMode != "W")
     cmd.Parameters["@shftin"].Value = DBNull.Value;
    else
     cmd.Parameters["@shftin"].Value = _dteShiftIn;

    if (_dteShiftOut == clsDateTime.SystemMinDate || pShiftMode != "W")
     cmd.Parameters["@shftout"].Value = DBNull.Value;
    else
     cmd.Parameters["@shftout"].Value = _dteShiftOut;

    cmd.Parameters["@ttalunit"].Value = _fltTotalUnit;
    cmd.Parameters["@workunit"].Value = _fltWorkUnit;
    cmd.Parameters["@absunit"].Value = _fltAbsentUnit;
    cmd.Parameters["@lwithpay"].Value = _fltLeaveWithPay;
    cmd.Parameters["@lwoutpay"].Value = _fltLeaveWithoutPay;
    cmd.Parameters["@lateunit"].Value = _fltLateUnit;
    cmd.Parameters["@undrunit"].Value = _fltUndertimeUnit;
    cmd.Parameters["@tcunit"].Value = _fltTCUnit;
    cmd.Parameters["@obunit"].Value = _fltOBUnit;
    cmd.Parameters["@xcssunit"].Value = _fltExcessUnit;
    cmd.Parameters["@reguxcss"].Value = _fltRegularOT;
    cmd.Parameters["@regunght"].Value = _fltRegularND;
    cmd.Parameters["@restover"].Value = _fltRestDayOT;
    cmd.Parameters["@restnght"].Value = _fltRestDayND;
    cmd.Parameters["@restxcss"].Value = _fltRestDayEX;
    cmd.Parameters["@spclover"].Value = _fltSpecialHolidayOT;
    cmd.Parameters["@spclnght"].Value = _fltSpecialHolidayND;
    cmd.Parameters["@spclxcss"].Value = _fltSpecialHolidayEX;
    cmd.Parameters["@leglover"].Value = _fltRegularHolidayOT;
    cmd.Parameters["@leglnght"].Value = _fltRegularHolidayND;
    cmd.Parameters["@leglxcss"].Value = _fltRegularHolidayEX;
    cmd.Parameters["@shrdover"].Value = _fltRestDaySpecialHolidayOT;
    cmd.Parameters["@shrdnght"].Value = _fltRestDaySpecialHolidayND;
    cmd.Parameters["@shrdxcss"].Value = _fltRestDaySpecialHolidayEX;
    cmd.Parameters["@lerdover"].Value = _fltRestDayRegularHolidayOT;
    cmd.Parameters["@lerdnght"].Value = _fltRestDayRegularHolidayND;
    cmd.Parameters["@lerdxcss"].Value = _fltRestDayRegularHolidayEX;
    cmd.Parameters["@lastby"].Value = _strLastUpdateBy;
    cmd.Parameters["@lastdate"].Value = _dteLastUpdateDate;
    cmd.Parameters["@pstatus"].Value = _strStatus;
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int Update(string pShiftMode)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Timesheet SET timein=@timein, timeout=@timeout, shftcode=@shftcode, shftin=@shftin, shftout=@shftout, ttalunit=@ttalunit, workunit=@workunit, absunit=@absunit, lwithpay=@lwithpay, lwoutpay=@lwoutpay, lateunit=@lateunit, undrunit=@undrunit, tcunit=@tcunit, obunit=@obunit, xcssunit=@xcssunit, reguxcss=@reguxcss, regunght=@regunght, restover=@restover, restnght=@restnght, restxcss=@restxcss, spclover=@spclover, spclnght=@spclnght, spclxcss=@spclxcss, leglover=@leglover, leglnght=@leglnght, leglxcss=@leglxcss, shrdover=@shrdover, shrdnght=@shrdnght, shrdxcss=@shrdxcss, lerdover=@lerdover, lerdnght=@lerdnght, lerdxcss=@lerdxcss, lastby=@lastby, lastdate=@lastdate, pstatus=@pstatus WHERE username=@username AND focsdate=@focsdate";
    cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@focsdate", SqlDbType.DateTime);
    cmd.Parameters.Add("@timein", SqlDbType.DateTime);
    cmd.Parameters.Add("@timeout", SqlDbType.DateTime);
    cmd.Parameters.Add("@shftcode", SqlDbType.Char, 8);
    cmd.Parameters.Add("@shftin", SqlDbType.DateTime);
    cmd.Parameters.Add("@shftout", SqlDbType.DateTime);
    cmd.Parameters.Add("@ttalunit", SqlDbType.Float);
    cmd.Parameters.Add("@workunit", SqlDbType.Float);
    cmd.Parameters.Add("@absunit", SqlDbType.Float);
    cmd.Parameters.Add("@lwithpay", SqlDbType.Float);
    cmd.Parameters.Add("@lwoutpay", SqlDbType.Float);
    cmd.Parameters.Add("@lateunit", SqlDbType.Float);
    cmd.Parameters.Add("@undrunit", SqlDbType.Float);
    cmd.Parameters.Add("@tcunit", SqlDbType.Float);
    cmd.Parameters.Add("@obunit", SqlDbType.Float);
    cmd.Parameters.Add("@xcssunit", SqlDbType.Float);
    cmd.Parameters.Add("@reguxcss", SqlDbType.Float);
    cmd.Parameters.Add("@regunght", SqlDbType.Float);
    cmd.Parameters.Add("@restover", SqlDbType.Float);
    cmd.Parameters.Add("@restnght", SqlDbType.Float);
    cmd.Parameters.Add("@restxcss", SqlDbType.Float);
    cmd.Parameters.Add("@spclover", SqlDbType.Float);
    cmd.Parameters.Add("@spclnght", SqlDbType.Float);
    cmd.Parameters.Add("@spclxcss", SqlDbType.Float);
    cmd.Parameters.Add("@leglover", SqlDbType.Float);
    cmd.Parameters.Add("@leglnght", SqlDbType.Float);
    cmd.Parameters.Add("@leglxcss", SqlDbType.Float);
    cmd.Parameters.Add("@shrdover", SqlDbType.Float);
    cmd.Parameters.Add("@shrdnght", SqlDbType.Float);
    cmd.Parameters.Add("@shrdxcss", SqlDbType.Float);
    cmd.Parameters.Add("@lerdover", SqlDbType.Float);
    cmd.Parameters.Add("@lerdnght", SqlDbType.Float);
    cmd.Parameters.Add("@lerdxcss", SqlDbType.Float);
    cmd.Parameters.Add("@lastby", SqlDbType.VarChar, 30);
    cmd.Parameters.Add("@lastdate", SqlDbType.DateTime);    
    cmd.Parameters.Add("@pstatus", SqlDbType.Char, 1);

    cmd.Parameters["@username"].Value = _strUsername;
    cmd.Parameters["@focsdate"].Value = _dteFocusDate;

    if (_dteTimeIn == clsDateTime.SystemMinDate)
     cmd.Parameters["@timein"].Value = DBNull.Value;
    else
     cmd.Parameters["@timein"].Value = _dteTimeIn;

    if (_dteTimeOut == clsDateTime.SystemMinDate)
     cmd.Parameters["@timeout"].Value = DBNull.Value;
    else
     cmd.Parameters["@timeout"].Value = _dteTimeOut;

    cmd.Parameters["@shftcode"].Value = _strShiftCode;

    if (_dteShiftIn == clsDateTime.SystemMinDate || pShiftMode != "W")
     cmd.Parameters["@shftin"].Value = DBNull.Value;
    else
     cmd.Parameters["@shftin"].Value = _dteShiftIn;

    if (_dteShiftOut == clsDateTime.SystemMinDate || pShiftMode != "W")
     cmd.Parameters["@shftout"].Value = DBNull.Value;
    else
     cmd.Parameters["@shftout"].Value = _dteShiftOut;

    cmd.Parameters["@ttalunit"].Value = _fltTotalUnit;
    cmd.Parameters["@workunit"].Value = _fltWorkUnit;
    cmd.Parameters["@lwithpay"].Value = _fltLeaveWithPay;
    cmd.Parameters["@lwoutpay"].Value = _fltLeaveWithoutPay;
    cmd.Parameters["@absunit"].Value = _fltAbsentUnit;
    cmd.Parameters["@lateunit"].Value = _fltLateUnit;
    cmd.Parameters["@undrunit"].Value = _fltUndertimeUnit;
    cmd.Parameters["@tcunit"].Value = _fltTCUnit;
    cmd.Parameters["@obunit"].Value = _fltOBUnit;
    cmd.Parameters["@xcssunit"].Value = _fltExcessUnit;
    cmd.Parameters["@reguxcss"].Value = _fltRegularOT;
    cmd.Parameters["@regunght"].Value = _fltRegularND;
    cmd.Parameters["@restover"].Value = _fltRestDayOT;
    cmd.Parameters["@restnght"].Value = _fltRestDayND;
    cmd.Parameters["@restxcss"].Value = _fltRestDayEX;
    cmd.Parameters["@spclover"].Value = _fltSpecialHolidayOT;
    cmd.Parameters["@spclnght"].Value = _fltSpecialHolidayND;
    cmd.Parameters["@spclxcss"].Value = _fltSpecialHolidayEX;
    cmd.Parameters["@leglover"].Value = _fltRegularHolidayOT;
    cmd.Parameters["@leglnght"].Value = _fltRegularHolidayND;
    cmd.Parameters["@leglxcss"].Value = _fltRegularHolidayEX;
    cmd.Parameters["@shrdover"].Value = _fltRestDaySpecialHolidayOT;
    cmd.Parameters["@shrdnght"].Value = _fltRestDaySpecialHolidayND;
    cmd.Parameters["@shrdxcss"].Value = _fltRestDaySpecialHolidayEX;
    cmd.Parameters["@lerdover"].Value = _fltRestDayRegularHolidayOT;
    cmd.Parameters["@lerdnght"].Value = _fltRestDayRegularHolidayND;
    cmd.Parameters["@lerdxcss"].Value = _fltRestDayRegularHolidayEX;
    cmd.Parameters["@lastby"].Value = _strLastUpdateBy;
    cmd.Parameters["@lastdate"].Value = _dteLastUpdateDate;
    cmd.Parameters["@pstatus"].Value = _strStatus;
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
    cmd.CommandText = "DELETE FROM HR.Timesheet WHERE username=@username AND focsdate=@focsdate";
    cmd.Parameters.Add(new SqlParameter("@username", _strUsername));
    cmd.Parameters.Add(new SqlParameter("@focsdate", _dteFocusDate));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void ProcessTimeSheet()
  {
   bool blnHasRecord = false;

   DataTable tblHolidays = Holiday.GetHoliday(_dtepDateStart, _dtepDateEnd);
   DataTable tblChangeShift = new DataTable();
   DataTable tblLeaveApplications;
   DataTable tblOvertimeApplications;
   //DataTable tblTimeCard;
   DataTable tblOBDetails;

   bool blnpWorkingDay = true;
   bool blnShiftChanged = false;
   string strUsername = "";
   DateTime dteFocusDate = clsDateTime.SystemMinDate;
   DateTime dteACMIn = clsDateTime.SystemMinDate;
   DateTime dteACMOut = clsDateTime.SystemMinDate;
   DateTime dteTimeCardIn = clsDateTime.SystemMinDate;
   DateTime dteTimeCardOut = clsDateTime.SystemMinDate;
   DateTime dteOBIn = clsDateTime.SystemMinDate;
   DateTime dteOBOut = clsDateTime.SystemMinDate;
   DateTime dteTimeIn = clsDateTime.SystemMinDate;
   DateTime dteTimeOut = clsDateTime.SystemMinDate;
   string strScheduleCode = "";
   string strShiftCode = "";
   string strShiftMode = "";

   // Shift details
   DateTime dteShiftIn = clsDateTime.SystemMinDate;
   DateTime dteShiftHalf = clsDateTime.SystemMinDate;
   DateTime dteShiftOut = clsDateTime.SystemMinDate;
   DateTime dteShiftBreakStart = clsDateTime.SystemMinDate;
   DateTime dteShiftBreakEnd = clsDateTime.SystemMinDate;
   DateTime dteShiftOvertime = clsDateTime.SystemMinDate;
   DateTime dteShiftLate = clsDateTime.SystemMinDate;
   DateTime dteShiftUndertime = clsDateTime.SystemMinDate;
   float fltShiftTotalWorkHours = 0;

   DateTime dteOvertimeIn = clsDateTime.SystemMinDate;
   DateTime dteOvertimeOut = clsDateTime.SystemMinDate;
   string strLastUpdateBy = "";
   DateTime dteLastUpdateDate = DateTime.Now;
   string strStatus = "";

   // Counters
   float fltTotalUnit = 0;
   float fltWorkUnit = 0;
   float fltAbsentUnit = 0;
   float fltLateUnit = 0;
   float fltUndertimeUnit = 0;
   float fltTCUnit = 0;
   float fltOBUnit = 0;
   float fltExcessUnit = 0;
   float fltRegularOT = 0;
   float fltRegularND = 0;
   float fltRestDayOT = 0;
   float fltRestDayND = 0;
   float fltRestDayEX = 0;
   float fltSpecialHolidayOT = 0;
   float fltSpecialHolidayND = 0;
   float fltSpecialHolidayEX = 0;
   float fltLegalHolidayOT = 0;
   float fltLegalHolidayND = 0;
   float fltLegalHolidayEX = 0;
   float fltSpecialHolidayRestDayOT = 0;
   float fltSpecialHolidayRestDayND = 0;
   float fltSpecialHolidayRestDayEX = 0;
   float fltLegalHolidayRestDayOT = 0;
   float fltLegalHolidayRestDayND = 0;
   float fltLegalHolidayRestDayEX = 0;
   float fltLeaveWithPay = 0;
   float fltLeaveWithOutPay = 0;
   float fltLeaveAM = 0;
   float fltLeavePM = 0;

   _frmpTimesheetProcessDialog.SetMinimumProgress(0);
   _frmpTimesheetProcessDialog.SetMaximumProgress(_strpEmployeeList.Length);

   for (int intCtr = 0; intCtr < _strpEmployeeList.Length; intCtr++)
   {
    strUsername = _strpEmployeeList[intCtr];
    tblChangeShift.Rows.Clear();
    tblChangeShift = clsChangeShiftBatch.DSChangeShift(strUsername, _dtepDateStart, _dtepDateEnd);
    dteFocusDate = clsDateTime.GetDateOnly(_dtepDateStart);
    tblOBDetails = OfficialBusinessDetails.ApprovedOBDetails(dteFocusDate, strUsername);

    _frmpTimesheetProcessDialog.UpdateLabeEmployee("Processsing " + Employee.GetName(strUsername));
    _frmpTimesheetProcessDialog.UpdateLabeRemarks("Processing " + (_prgpProgressBar.Value + 1).ToString() + " of " + _prgpProgressBar.Maximum.ToString());

    while (dteFocusDate <= _dtepDateEnd)
    {
     blnHasRecord = clsTimesheet.IsRecordExist(strUsername, dteFocusDate);

     // Check if the focus date is holiday
     // If it is holiday, the holiday's shift code will be used     
     blnpWorkingDay = true;
     blnShiftChanged = false;
     strScheduleCode = Employee.GetScheduleCurrent(strUsername, dteFocusDate);

     // Check if there is holiday
     foreach (DataRow drwHoliday in tblHolidays.Rows)
     {
      if (dteFocusDate == clsValidator.CheckDate(drwHoliday["dateapp"].ToString()))
      {
       blnpWorkingDay = false;
       strShiftCode = drwHoliday["shftcode"].ToString();
       break;
      }
     }

     // Check if there is early dismissal
     foreach (DataRow drw in tblChangeShift.Rows)
     {
      if (dteFocusDate == clsValidator.CheckDate(drw["appdate"].ToString()))
      {
       strShiftCode = drw["shftcode"].ToString();
       blnShiftChanged = true;
       break;
      }
     }

     // User the applicable shift if it is a working day and the shift is not changed
     if (blnpWorkingDay && !blnShiftChanged)
     {
      strShiftCode = clsSchedule.GetApplicableShiftCode(dteFocusDate, strScheduleCode);
     }

     // Retrieve the shift details of the given shift code
     using (clsShift shift = new clsShift(strShiftCode))
     {
      shift.Fill();
      strShiftMode = shift.ShiftModeCode;
      dteShiftIn = AdaptFocusDate(dteFocusDate, shift.TimeStart);
      dteShiftHalf = AdaptFocusDate(dteFocusDate, shift.TimeHalf);
      dteShiftOut = AdaptFocusDate(dteFocusDate, shift.TimeEnd);
      dteShiftBreakStart = AdaptFocusDate(dteFocusDate, shift.BreakTimeStart);
      dteShiftBreakEnd = AdaptFocusDate(dteFocusDate, shift.BreakTimeEnd);
      dteShiftLate = AdaptFocusDate(dteFocusDate, shift.LateTime);
      dteShiftUndertime = AdaptFocusDate(dteFocusDate, shift.UnderTime);
      fltShiftTotalWorkHours = shift.TotalWorkHours;
     }

     // Get the timecard and ob in and out and compare it to each other
     // Time In: First Key In First
     // Time Out: Last Key In Last

     dteTimeCardIn = clsTimeCard.GetExactIn(strUsername, dteFocusDate);
     dteTimeCardOut = clsTimeCard.GetExactOut(strUsername, dteFocusDate);
     dteACMIn = clsTimeCardACM.GetIn(strUsername, dteFocusDate);
     dteACMOut = clsTimeCardACM.GetOut(strUsername, dteFocusDate);
     dteOBIn = OfficialBusinessDetails.GetTimeIn(strUsername, dteFocusDate);
     dteOBOut = OfficialBusinessDetails.GetTimeOut(strUsername, dteFocusDate);
     dteTimeIn = GetTimeIn(GetTimeIn(dteACMIn, dteOBIn), dteTimeCardIn);
     dteTimeOut = GetTimeOut(GetTimeOut(dteACMOut, dteOBOut), dteTimeCardOut);

     // Get the applied leave
     fltLeaveWithPay = 0;
     fltLeaveWithOutPay = 0;
     fltLeaveAM = 0;
     fltLeavePM = 0;

     if (strShiftMode != "R")
     {
      tblLeaveApplications = LeaveApplication.GetApprovedLeave(dteFocusDate, strUsername);
      foreach (DataRow drowLeave in tblLeaveApplications.Rows)
      {
       DateTime dteLeaveStart = clsValidator.CheckDate(drowLeave["datestrt"].ToString());
       DateTime dteLeaveEnd = clsValidator.CheckDate(drowLeave["dateend"].ToString());
       float fltTempLeaveUnit = 0;

       if (dteLeaveStart <= dteShiftIn)
        fltTempLeaveUnit = (dteLeaveEnd >= dteShiftOut ? 1 : (float).5);
       else if (dteLeaveEnd >= dteShiftOut)
        fltTempLeaveUnit = (float).5;

       if (LeaveApplicationTypes.IsWithPay(drowLeave["leavtype"].ToString()))
        fltLeaveWithPay += fltTempLeaveUnit;
       else
        fltLeaveWithOutPay += fltTempLeaveUnit;

       if (dteLeaveStart <= dteShiftIn && dteLeaveEnd >= dteShiftHalf)
        fltLeaveAM = .5F;
       if (dteLeaveStart.Hour <= dteShiftHalf.Hour && dteLeaveEnd >= dteShiftOut)
        fltLeavePM = .5F;
      }
     }

     //Computation of the different time sheet units

     fltAbsentUnit = GetAbsentUnit(strShiftMode, dteTimeIn, dteTimeOut, dteShiftIn, dteShiftHalf, dteShiftOut, dteShiftLate, dteShiftUndertime, fltLeaveAM, fltLeavePM);
     if (fltLeaveAM == 0)
      fltLateUnit = GetLateUnit(strShiftMode, dteTimeIn, dteTimeOut, dteShiftIn, dteShiftHalf, dteShiftOut, dteShiftLate, dteShiftUndertime, fltLeaveAM, fltLeavePM);
     else
      fltLateUnit = 0;
     if (fltLeavePM == 0)
      fltUndertimeUnit = GetUndertimeUnit(strShiftMode, dteTimeIn, dteTimeOut, dteShiftIn, dteShiftOut, dteShiftUndertime, fltLeavePM);
     else
      fltUndertimeUnit = 0;

     fltTotalUnit = GetTimeAllUnit(dteTimeIn, dteTimeOut, dteShiftBreakStart, dteShiftBreakEnd);
     fltWorkUnit = GetWorkUnit(dteTimeIn, dteTimeOut, strShiftMode, dteShiftIn, dteShiftHalf, dteShiftOut, dteShiftBreakStart, dteShiftBreakEnd, dteShiftLate, dteShiftUndertime, fltLeaveAM, fltLeavePM);
     fltTCUnit = clsDateTime.DateDiff(pDateFormat.Hour, dteACMIn, dteACMOut);
     fltOBUnit = GetTimeWorkUnit(tblOBDetails, strShiftMode, dteShiftIn, dteShiftHalf, dteShiftOut, dteShiftBreakStart, dteShiftBreakEnd, dteShiftLate, dteShiftUndertime, fltLeaveAM, fltLeavePM);
     fltExcessUnit = GetExcess(strShiftMode, dteTimeIn, dteTimeOut, dteShiftIn, dteShiftOut);

     // Overtime Computation
     tblOvertimeApplications = clsOvertime.GetApprovedOvertime(dteFocusDate, strUsername);
     fltRegularOT = 0;
     fltRegularND = 0;
     fltRestDayOT = 0;
     fltRestDayND = 0;
     fltRestDayEX = 0;
     fltSpecialHolidayOT = 0;
     fltSpecialHolidayND = 0;
     fltSpecialHolidayEX = 0;
     fltLegalHolidayOT = 0;
     fltLegalHolidayND = 0;
     fltLegalHolidayEX = 0;
     fltSpecialHolidayRestDayOT = 0;
     fltSpecialHolidayRestDayND = 0;
     fltSpecialHolidayRestDayEX = 0;
     fltLegalHolidayRestDayOT = 0;
     fltLegalHolidayRestDayND = 0;
     fltLegalHolidayRestDayEX = 0;
     dteOvertimeIn = clsDateTime.SystemMinDate;
     dteOvertimeOut = clsDateTime.SystemMinDate;

     foreach (DataRow drwOT in tblOvertimeApplications.Rows)
     {
      dteOvertimeIn = clsValidator.CheckDate(drwOT["datestrt"].ToString());
      dteOvertimeOut = clsValidator.CheckDate(drwOT["dateend"].ToString());

      if ((dteOvertimeIn >= dteTimeIn && dteOvertimeIn < dteTimeOut) || (dteOvertimeOut > dteTimeIn && dteOvertimeOut <= dteTimeOut) || (dteOvertimeIn < dteTimeIn && dteOvertimeOut > dteTimeOut))
      {
       if (dteTimeIn > dteOvertimeIn)
        dteOvertimeIn = dteTimeIn;

       if (dteTimeOut < dteOvertimeOut)
        dteOvertimeOut = dteTimeOut;

       if (strShiftMode == "W")
       {
        fltRegularOT += GetOTRegUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, dteFocusDate);
        fltRegularND += GetNDUnit(dteOvertimeIn, dteOvertimeOut, dteFocusDate);
       }
       else if (strShiftMode == "R")
       {
        fltRestDayOT += GetOTUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, dteFocusDate);
        fltRestDayEX += GetExcessUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, dteFocusDate, strShiftCode, strUsername);
        fltRestDayND += GetNDUnit(dteOvertimeIn, dteOvertimeOut, dteFocusDate);
       }
       if (strShiftMode == "L")
       {
        if (clsShift.GetShiftMode(clsSchedule.GetApplicableShiftCode(dteFocusDate, strScheduleCode)) == "R")
        {
         fltLegalHolidayRestDayOT += GetOTUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, dteFocusDate);
         fltLegalHolidayRestDayEX += GetExcessUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, dteFocusDate, strShiftCode, strUsername);
         fltLegalHolidayRestDayND += GetNDUnit(dteOvertimeIn, dteOvertimeOut, dteFocusDate);
        }
        else
        {
         fltLegalHolidayOT += GetOTUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, dteFocusDate);
         fltLegalHolidayEX += GetExcessUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, dteFocusDate, strShiftCode, strUsername);
         fltLegalHolidayND += GetNDUnit(dteOvertimeIn, dteOvertimeOut, dteFocusDate);
        }
       }
       else if (strShiftMode == "S")
       {
        if (clsShift.GetShiftMode(clsSchedule.GetApplicableShiftCode(dteFocusDate, strScheduleCode)) == "R")
        {
         fltSpecialHolidayRestDayOT += GetOTUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, dteFocusDate);
         fltSpecialHolidayRestDayEX += GetExcessUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, dteFocusDate, strShiftCode, strUsername);
         fltSpecialHolidayRestDayND += GetNDUnit(dteOvertimeIn, dteOvertimeOut, dteFocusDate);
        }
        else
        {
         fltSpecialHolidayOT += GetOTUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, dteFocusDate);
         fltSpecialHolidayEX += GetExcessUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, dteFocusDate, strShiftCode, strUsername);
         fltSpecialHolidayND += GetNDUnit(dteOvertimeIn, dteOvertimeOut, dteFocusDate);
        }
       }
      }
     }

     // get the status
     if (blnpWorkingDay)
     {
      if (strShiftCode == clsShift.RestDay)
       strStatus = "R";
      else if (fltLeaveAM + fltLeavePM == 1)
       strStatus = "L";
      else if (dteTimeIn == clsDateTime.SystemMinDate && dteTimeIn == clsDateTime.SystemMinDate)
       strStatus = "A";
      else
       strStatus = "W";
     }
     else
     {
      strStatus = "N";
     }   

     using (clsTimesheet ts = new clsTimesheet())
     {
      ts.Username = strUsername;
      ts.FocusDate = dteFocusDate;
      ts.TimeIn = dteTimeIn;
      ts.TimeOut = dteTimeOut;
      ts.ShiftCode = strShiftCode;
      ts.ShiftIn = dteShiftIn;
      ts.ShiftOut = dteShiftOut;
      ts.TotalUnit = (float)Math.Round(fltTotalUnit, 2);
      ts.WorkUnit = (float)Math.Round(fltWorkUnit, 2);
      ts.AbsentUnit = (float)Math.Round(fltAbsentUnit, 2);
      ts.LeaveWithPay = (float)Math.Round(fltLeaveWithPay, 2);
      ts.LeaveWithoutPay = (float)Math.Round(fltLeaveWithOutPay, 2);
      ts.LateUnit = (float)Math.Round(fltLateUnit, 2);
      ts.UndertimeUnit = (float)Math.Round(fltUndertimeUnit, 2);
      ts.TCUnit = (float)Math.Round(fltTCUnit, 2);
      ts.OBUnit = (float)Math.Round(fltOBUnit, 2);
      ts.ExcessUnit = (float)Math.Round(fltExcessUnit, 2);
      ts.RegularOT = (float)Math.Round(fltRegularOT, 2);
      ts.RegularND = (float)Math.Round(fltRegularND, 2);
      ts.RestDayOT = (float)Math.Round(fltRestDayOT, 2);
      ts.RestDayND = (float)Math.Round(fltRestDayND, 2);
      ts.RestDayEX = (float)Math.Round(fltRestDayEX, 2);
      ts.SpecialHolidayOT = (float)Math.Round(fltSpecialHolidayOT, 2);
      ts.SpecialHolidayND = (float)Math.Round(fltSpecialHolidayND, 2);
      ts.SpecialHolidayEX = (float)Math.Round(fltSpecialHolidayEX, 2);
      ts.RegularHolidayOT = (float)Math.Round(fltLegalHolidayOT, 2);
      ts.RegularHolidayND = (float)Math.Round(fltLegalHolidayND, 2);
      ts.RegularHolidayEX = (float)Math.Round(fltLegalHolidayEX, 2);
      ts.RestDaySpecialHolidayOT = (float)Math.Round(fltSpecialHolidayRestDayOT, 2);
      ts.RestDaySpecialHolidayND = (float)Math.Round(fltSpecialHolidayRestDayND, 2);
      ts.RestDaySpecialHolidayEX = (float)Math.Round(fltSpecialHolidayRestDayEX, 2);
      ts.RestDayRegularHolidayOT = (float)Math.Round(fltLegalHolidayRestDayOT, 2);
      ts.RestDaySpecialHolidayND = (float)Math.Round(fltLegalHolidayRestDayND, 2);
      ts.RestDaySpecialHolidayEX = (float)Math.Round(fltLegalHolidayRestDayEX, 2);
      ts.LastUpdateBy = strLastUpdateBy;
      ts.LastUpdateDate = dteLastUpdateDate;
      ts.Status = strStatus;

      if (blnHasRecord)
       ts.Update(strShiftMode);
      else
       ts.Insert(strShiftMode);
     }

     dteFocusDate = clsDateTime.GetDateOnly(dteFocusDate.AddDays(1));
    }
    _frmpTimesheetProcessDialog.IncrementProgress();
   }
   _frmpTimesheetProcessDialog.MessageComplete();
   _frmpTimesheetProcessDialog.CloseForm();
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  ////////////////////////////////////
  ////////// Static Members //////////
  ////////////////////////////////////

  public static bool IsRecordExist(string pUsername, DateTime pFocusDate)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username FROM HR.Timesheet WHERE username='" + pUsername + "' AND focsdate='" + pFocusDate + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
   return blnReturn;
  }

  public static DataTable MergeTCOB(DataTable pTimeCard, DataTable pOB)
  {
   DataTable tblReturn = new DataTable();
   DataTable tblTC = pTimeCard;
   DataTable tblOB = pOB;
   tblReturn.Columns.Add("focsdate");
   tblReturn.Columns.Add("keyin");
   tblReturn.Columns.Add("keyout");
   bool blnCollisionDetected = false;

   foreach (DataRow drwTC in tblTC.Rows)
   {
    blnCollisionDetected = false;
    foreach (DataRow drwOB in tblOB.Rows)
    {
     DateTime dteTCIn = clsValidator.CheckDate(drwTC["keyin"].ToString());
     DateTime dteTCOut = clsValidator.CheckDate(drwTC["keyout"].ToString());
     DateTime dteOBIn = clsValidator.CheckDate(drwOB["keyin"].ToString());
     DateTime dteOBOut = clsValidator.CheckDate(drwOB["keyout"].ToString());

     if (dteOBIn < dteTCIn)
     {
      dteTCIn = dteOBIn;
      blnCollisionDetected = true;
     }

     if (dteOBOut > dteTCOut)
     {
      dteTCOut = dteOBOut;
      blnCollisionDetected = true;
     }

     if (blnCollisionDetected)
     {
      DataRow drwN = tblReturn.NewRow();
      drwN["focsdate"] = drwTC["focsdate"].ToString();
      drwN["keyin"] = dteTCIn;
      drwN["keyout"] = dteTCOut;
      tblReturn.Rows.Add(drwN);
      tblOB.Rows.Remove(drwOB);
      break;
     }
    }
    if (!blnCollisionDetected)
    {
     DataRow drwN = tblReturn.NewRow();
     drwN["focsdate"] = drwTC["focsdate"].ToString();
     drwN["keyin"] = drwTC["keyin"].ToString();
     drwN["keyout"] = drwTC["keyout"].ToString();
     tblReturn.Rows.Add(drwN);
    }
   }

   foreach (DataRow drwOB in tblOB.Rows)
   {
    DateTime dteOBIn = clsValidator.CheckDate(drwOB["keyin"].ToString());
    DateTime dteOBOut = clsValidator.CheckDate(drwOB["keyout"].ToString());

    DataRow drwN = tblReturn.NewRow();
    drwN["focsdate"] = drwOB["focsdate"].ToString();
    drwN["keyin"] = dteOBIn;
    drwN["keyout"] = dteOBOut;
    tblReturn.Rows.Add(drwN);
   }

   return tblReturn;
  }

  public static bool HasTimesheetRecord(string pUsername, DateTime pFocusDate)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username FROM HR.Timesheet WHERE username='" + pUsername + "' AND focsdate='" + pFocusDate + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
    return blnReturn;
  }

  public static void ProcessTimeSheet(string pUsername, DateTime pFocusDate)
  {
   bool blnHasRecord = false;

   DataTable tblHolidays = Holiday.GetHoliday(pFocusDate);
   DataTable tblChangeShift = new DataTable();
   DataTable tblLeaveApplications;
   DataTable tblOvertimeApplications;
   DataTable tblOBDetails;

   bool blnpWorkingDay = true;
   bool blnShiftChanged = false;
   DateTime dteACMIn = clsDateTime.SystemMinDate;
   DateTime dteACMOut = clsDateTime.SystemMinDate;
   DateTime dteTimeCardIn = clsDateTime.SystemMinDate;
   DateTime dteTimeCardOut = clsDateTime.SystemMinDate;
   DateTime dteOBIn = clsDateTime.SystemMinDate;
   DateTime dteOBOut = clsDateTime.SystemMinDate;
   DateTime dteTimeIn = clsDateTime.SystemMinDate;
   DateTime dteTimeOut = clsDateTime.SystemMinDate;
   string strScheduleCode = "";
   string strShiftCode = "";
   string strShiftMode = "";

   // Shift details
   DateTime dteShiftIn = clsDateTime.SystemMinDate;
   DateTime dteShiftHalf = clsDateTime.SystemMinDate;
   DateTime dteShiftOut = clsDateTime.SystemMinDate;
   DateTime dteShiftBreakStart = clsDateTime.SystemMinDate;
   DateTime dteShiftBreakEnd = clsDateTime.SystemMinDate;
   DateTime dteShiftOvertime = clsDateTime.SystemMinDate;
   DateTime dteShiftLate = clsDateTime.SystemMinDate;
   DateTime dteShiftUndertime = clsDateTime.SystemMinDate;
   float fltShiftTotalWorkHours = 0;

   DateTime dteOvertimeIn = clsDateTime.SystemMinDate;
   DateTime dteOvertimeOut = clsDateTime.SystemMinDate;
   string strLastUpdateBy = "";
   DateTime dteLastUpdateDate = DateTime.Now;
   string strStatus = "";

   // Counters
   float fltTotalUnit = 0;
   float fltWorkUnit = 0;
   float fltAbsentUnit = 0;
   float fltLateUnit = 0;
   float fltUndertimeUnit = 0;
   float fltTCUnit = 0;
   float fltOBUnit = 0;
   float fltExcessUnit = 0;
   float fltRegularOT = 0;
   float fltRegularND = 0;
   float fltRestDayOT = 0;
   float fltRestDayND = 0;
   float fltRestDayEX = 0;
   float fltSpecialHolidayOT = 0;
   float fltSpecialHolidayND = 0;
   float fltSpecialHolidayEX = 0;
   float fltLegalHolidayOT = 0;
   float fltLegalHolidayND = 0;
   float fltLegalHolidayEX = 0;
   float fltSpecialHolidayRestDayOT = 0;
   float fltSpecialHolidayRestDayND = 0;
   float fltSpecialHolidayRestDayEX = 0;
   float fltLegalHolidayRestDayOT = 0;
   float fltLegalHolidayRestDayND = 0;
   float fltLegalHolidayRestDayEX = 0;
   float fltLeaveWithPay = 0;
   float fltLeaveWithOutPay = 0;
   float fltLeaveAM = 0;
   float fltLeavePM = 0;

   tblChangeShift.Rows.Clear();
   tblChangeShift = clsChangeShiftBatch.GetDSChangeShift(pUsername, pFocusDate);
   tblOBDetails = OfficialBusinessDetails.ApprovedOBDetails(pFocusDate, pUsername);

   blnHasRecord = clsTimesheet.IsRecordExist(pUsername, pFocusDate);

   // Check if the focus date is holiday
   // If it is holiday, the holiday's shift code will be used     
   blnpWorkingDay = true;
   blnShiftChanged = false;
   strScheduleCode = Employee.GetScheduleCurrent(pUsername, pFocusDate);

   // Check if there is holiday
   foreach (DataRow drwHoliday in tblHolidays.Rows)
   {
    if (pFocusDate == clsValidator.CheckDate(drwHoliday["dateapp"].ToString()))
    {
     blnpWorkingDay = false;
     strShiftCode = drwHoliday["shftcode"].ToString();
     break;
    }
   }

   // Check if there is early dismissal
   foreach (DataRow drw in tblChangeShift.Rows)
   {
    if (pFocusDate == clsValidator.CheckDate(drw["appdate"].ToString()))
    {
     strShiftCode = drw["shftcode"].ToString();
     blnShiftChanged = true;
     break;
    }
   }

   // User the applicable shift if it is a working day and the shift is not changed
   if (blnpWorkingDay && !blnShiftChanged)
    strShiftCode = clsSchedule.GetApplicableShiftCode(pFocusDate, strScheduleCode);

   // Retrieve the shift details of the given shift code
   using (clsShift shift = new clsShift(strShiftCode))
   {
    shift.Fill();
    strShiftMode = shift.ShiftModeCode;
    dteShiftIn = AdaptFocusDate(pFocusDate, shift.TimeStart);
    dteShiftHalf = AdaptFocusDate(pFocusDate, shift.TimeHalf);
    dteShiftOut = AdaptFocusDate(pFocusDate, shift.TimeEnd);
    dteShiftBreakStart = AdaptFocusDate(pFocusDate, shift.BreakTimeStart);
    dteShiftBreakEnd = AdaptFocusDate(pFocusDate, shift.BreakTimeEnd);
    dteShiftLate = AdaptFocusDate(pFocusDate, shift.LateTime);
    dteShiftUndertime = AdaptFocusDate(pFocusDate, shift.UnderTime);
    fltShiftTotalWorkHours = shift.TotalWorkHours;
   }

   // Get the timecard and ob in and out and compare it to each other
   // Time In: First Key In First
   // Time Out: Last Key In Last

   dteTimeCardIn = clsTimeCard.GetExactIn(pUsername, pFocusDate);
   dteTimeCardOut = clsTimeCard.GetExactOut(pUsername, pFocusDate);
   dteACMIn = clsTimeCardACM.GetIn(pUsername, pFocusDate);
   dteACMOut = clsTimeCardACM.GetOut(pUsername, pFocusDate);
   dteOBIn = OfficialBusinessDetails.GetTimeIn(pUsername, pFocusDate);
   dteOBOut = OfficialBusinessDetails.GetTimeOut(pUsername, pFocusDate);
   dteTimeIn = GetTimeIn(GetTimeIn(dteACMIn, dteOBIn), dteTimeCardIn);
   dteTimeOut = GetTimeOut(GetTimeOut(dteACMOut, dteOBOut), dteTimeCardOut);

   // Get the applied leave
   fltLeaveWithPay = 0;
   fltLeaveWithOutPay = 0;
   fltLeaveAM = 0;
   fltLeavePM = 0;

   if (strShiftMode != "R")
   {
    tblLeaveApplications = LeaveApplication.GetApprovedLeave(pFocusDate, pUsername);
    foreach (DataRow drowLeave in tblLeaveApplications.Rows)
    {
     DateTime dteLeaveStart = clsValidator.CheckDate(drowLeave["datestrt"].ToString());
     DateTime dteLeaveEnd = clsValidator.CheckDate(drowLeave["dateend"].ToString());
     float fltTempLeaveUnit = 0;

     if (dteLeaveStart <= dteShiftIn)
      fltTempLeaveUnit = (dteLeaveEnd >= dteShiftOut ? 1 : (float).5);
     else if (dteLeaveEnd >= dteShiftOut)
      fltTempLeaveUnit = (float).5;

     if (LeaveApplicationTypes.IsWithPay(drowLeave["leavtype"].ToString()))
      fltLeaveWithPay += fltTempLeaveUnit;
     else
      fltLeaveWithOutPay += fltTempLeaveUnit;

     if (dteLeaveStart <= dteShiftIn && dteLeaveEnd >= dteShiftHalf)
      fltLeaveAM = .5F;
     if (dteLeaveStart.Hour <= dteShiftHalf.Hour && dteLeaveEnd >= dteShiftOut)
      fltLeavePM = .5F;
    }
   }

   //Computation of the different time sheet units

   fltAbsentUnit = GetAbsentUnit(strShiftMode, dteTimeIn, dteTimeOut, dteShiftIn, dteShiftHalf, dteShiftOut, dteShiftLate, dteShiftUndertime, fltLeaveAM, fltLeavePM);
   if (fltLeaveAM == 0)
    fltLateUnit = GetLateUnit(strShiftMode, dteTimeIn, dteTimeOut, dteShiftIn, dteShiftHalf, dteShiftOut, dteShiftLate, dteShiftUndertime, fltLeaveAM, fltLeavePM);
   else
    fltLateUnit = 0;
   if (fltLeavePM == 0)
    fltUndertimeUnit = GetUndertimeUnit(strShiftMode, dteTimeIn, dteTimeOut, dteShiftIn, dteShiftOut, dteShiftUndertime, fltLeavePM);
   else
    fltUndertimeUnit = 0;

   fltTotalUnit = GetTimeAllUnit(dteTimeIn, dteTimeOut, dteShiftBreakStart, dteShiftBreakEnd);
   fltWorkUnit = GetWorkUnit(dteTimeIn, dteTimeOut, strShiftMode, dteShiftIn, dteShiftHalf, dteShiftOut, dteShiftBreakStart, dteShiftBreakEnd, dteShiftLate, dteShiftUndertime, fltLeaveAM, fltLeavePM);
   fltTCUnit = clsDateTime.DateDiff(pDateFormat.Hour, dteACMIn, dteACMOut);
   fltOBUnit = GetTimeWorkUnit(tblOBDetails, strShiftMode, dteShiftIn, dteShiftHalf, dteShiftOut, dteShiftBreakStart, dteShiftBreakEnd, dteShiftLate, dteShiftUndertime, fltLeaveAM, fltLeavePM);
   fltExcessUnit = GetExcess(strShiftMode, dteTimeIn, dteTimeOut, dteShiftIn, dteShiftOut);

   // Overtime Computation
   tblOvertimeApplications = clsOvertime.GetApprovedOvertime(pFocusDate, pUsername);
   fltRegularOT = 0;
   fltRegularND = 0;
   fltRestDayOT = 0;
   fltRestDayND = 0;
   fltRestDayEX = 0;
   fltSpecialHolidayOT = 0;
   fltSpecialHolidayND = 0;
   fltSpecialHolidayEX = 0;
   fltLegalHolidayOT = 0;
   fltLegalHolidayND = 0;
   fltLegalHolidayEX = 0;
   fltSpecialHolidayRestDayOT = 0;
   fltSpecialHolidayRestDayND = 0;
   fltSpecialHolidayRestDayEX = 0;
   fltLegalHolidayRestDayOT = 0;
   fltLegalHolidayRestDayND = 0;
   fltLegalHolidayRestDayEX = 0;
   dteOvertimeIn = clsDateTime.SystemMinDate;
   dteOvertimeOut = clsDateTime.SystemMinDate;

   foreach (DataRow drwOT in tblOvertimeApplications.Rows)
   {
    dteOvertimeIn = clsValidator.CheckDate(drwOT["datestrt"].ToString());
    dteOvertimeOut = clsValidator.CheckDate(drwOT["dateend"].ToString());

    if ((dteOvertimeIn >= dteTimeIn && dteOvertimeIn < dteTimeOut) || (dteOvertimeOut > dteTimeIn && dteOvertimeOut <= dteTimeOut) || (dteOvertimeIn < dteTimeIn && dteOvertimeOut > dteTimeOut))
    {
     if (dteTimeIn > dteOvertimeIn)
      dteOvertimeIn = dteTimeIn;

     if (dteTimeOut < dteOvertimeOut)
      dteOvertimeOut = dteTimeOut;

     if (strShiftMode == "W")
     {
      fltRegularOT += GetOTRegUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, pFocusDate);
      fltRegularND += GetNDUnit(dteOvertimeIn, dteOvertimeOut, pFocusDate);
     }
     else if (strShiftMode == "R")
     {
      fltRestDayOT += GetOTUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, pFocusDate);
      fltRestDayEX += GetExcessUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, pFocusDate, strShiftCode, pUsername);
      fltRestDayND += GetNDUnit(dteOvertimeIn, dteOvertimeOut, pFocusDate);
     }
     if (strShiftMode == "L")
     {
      if (clsShift.GetShiftMode(clsSchedule.GetApplicableShiftCode(pFocusDate, strScheduleCode)) == "R")
      {
       fltLegalHolidayRestDayOT += GetOTUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, pFocusDate);
       fltLegalHolidayRestDayEX += GetExcessUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, pFocusDate, strShiftCode, pUsername);
       fltLegalHolidayRestDayND += GetNDUnit(dteOvertimeIn, dteOvertimeOut, pFocusDate);
      }
      else
      {
       fltLegalHolidayOT += GetOTUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, pFocusDate);
       fltLegalHolidayEX += GetExcessUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, pFocusDate, strShiftCode, pUsername);
       fltLegalHolidayND += GetNDUnit(dteOvertimeIn, dteOvertimeOut, pFocusDate);
      }
     }
     else if (strShiftMode == "S")
     {
      if (clsShift.GetShiftMode(clsSchedule.GetApplicableShiftCode(pFocusDate, strScheduleCode)) == "R")
      {
       fltSpecialHolidayRestDayOT += GetOTUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, pFocusDate);
       fltSpecialHolidayRestDayEX += GetExcessUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, pFocusDate, strShiftCode, pUsername);
       fltSpecialHolidayRestDayND += GetNDUnit(dteOvertimeIn, dteOvertimeOut, pFocusDate);
      }
      else
      {
       fltSpecialHolidayOT += GetOTUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, pFocusDate);
       fltSpecialHolidayEX += GetExcessUnit(dteOvertimeIn, dteOvertimeOut, dteShiftBreakStart, dteShiftBreakEnd, pFocusDate, strShiftCode, pUsername);
       fltSpecialHolidayND += GetNDUnit(dteOvertimeIn, dteOvertimeOut, pFocusDate);
      }
     }
    }
   }

   // get the status
   if (blnpWorkingDay)
   {
    if (strShiftCode == clsShift.RestDay)
     strStatus = "R";
    else if (fltLeaveAM + fltLeavePM == 1)
     strStatus = "L";
    else if (dteTimeIn == clsDateTime.SystemMinDate && dteTimeIn == clsDateTime.SystemMinDate)
     strStatus = "A";
    else
     strStatus = "W";
   }
   else
   {
    strStatus = "N";
   }

   using (clsTimesheet ts = new clsTimesheet())
   {
    ts.Username = pUsername;
    ts.FocusDate = pFocusDate;
    ts.TimeIn = dteTimeIn;
    ts.TimeOut = dteTimeOut;
    ts.ShiftCode = strShiftCode;
    ts.ShiftIn = dteShiftIn;
    ts.ShiftOut = dteShiftOut;
    ts.TotalUnit = (float)Math.Round(fltTotalUnit, 2);
    ts.WorkUnit = (float)Math.Round(fltWorkUnit, 2);
    ts.AbsentUnit = (float)Math.Round(fltAbsentUnit, 2);
    ts.LeaveWithPay = (float)Math.Round(fltLeaveWithPay, 2);
    ts.LeaveWithoutPay = (float)Math.Round(fltLeaveWithOutPay, 2);
    ts.LateUnit = (float)Math.Round(fltLateUnit, 2);
    ts.UndertimeUnit = (float)Math.Round(fltUndertimeUnit, 2);
    ts.TCUnit = (float)Math.Round(fltTCUnit, 2);
    ts.OBUnit = (float)Math.Round(fltOBUnit, 2);
    ts.ExcessUnit = (float)Math.Round(fltExcessUnit, 2);
    ts.RegularOT = (float)Math.Round(fltRegularOT, 2);
    ts.RegularND = (float)Math.Round(fltRegularND, 2);
    ts.RestDayOT = (float)Math.Round(fltRestDayOT, 2);
    ts.RestDayND = (float)Math.Round(fltRestDayND, 2);
    ts.RestDayEX = (float)Math.Round(fltRestDayEX, 2);
    ts.SpecialHolidayOT = (float)Math.Round(fltSpecialHolidayOT, 2);
    ts.SpecialHolidayND = (float)Math.Round(fltSpecialHolidayND, 2);
    ts.SpecialHolidayEX = (float)Math.Round(fltSpecialHolidayEX, 2);
    ts.RegularHolidayOT = (float)Math.Round(fltLegalHolidayOT, 2);
    ts.RegularHolidayND = (float)Math.Round(fltLegalHolidayND, 2);
    ts.RegularHolidayEX = (float)Math.Round(fltLegalHolidayEX, 2);
    ts.RestDaySpecialHolidayOT = (float)Math.Round(fltSpecialHolidayRestDayOT, 2);
    ts.RestDaySpecialHolidayND = (float)Math.Round(fltSpecialHolidayRestDayND, 2);
    ts.RestDaySpecialHolidayEX = (float)Math.Round(fltSpecialHolidayRestDayEX, 2);
    ts.RestDayRegularHolidayOT = (float)Math.Round(fltLegalHolidayRestDayOT, 2);
    ts.RestDaySpecialHolidayND = (float)Math.Round(fltLegalHolidayRestDayND, 2);
    ts.RestDaySpecialHolidayEX = (float)Math.Round(fltLegalHolidayRestDayEX, 2);
    ts.LastUpdateBy = strLastUpdateBy;
    ts.LastUpdateDate = dteLastUpdateDate;
    ts.Status = strStatus;

    if (blnHasRecord)
     ts.Update(strShiftMode);
    else
     ts.Insert(strShiftMode);
   }
  }

  public static DataTable DSGFormTimeSheet(string pUsername,DateTime pDateFrom, DateTime pDateTo)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Timesheet WHERE username='" + pUsername + "' AND focsdate BETWEEN '" + pDateFrom + "' AND '" + pDateTo + "' ORDER BY focsdate";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataSet GetEmployeeTimeSheetDataSet(string pUsername, DateTime pDateFrom, DateTime pDateTo, string pOrderBy)
  {
   DataSet dsReturn = new DataSet();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Timesheet WHERE username='" + pUsername + "' AND focsdate BETWEEN '" + pDateFrom + "' AND '" + pDateTo + "' ORDER BY " + pOrderBy;
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(dsReturn);
   }
   return dsReturn;
  }

  public static DataTable GetILALUDataSource(DateTime pDateFrom, DateTime pDateTo)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT HR.Employees.username, HR.Employees.lastname + ', ' + HR.Employees.firname AS pname, SUM(lwithpay) AS tlwithpay, SUM(lwoutpay) AS tlwoutpay, SUM(absunit) AS tabsunit, SUM(lateunit) AS tlateunit, SUM(undrunit) AS tundrunit FROM HR.Timesheet INNER JOIN HR.Employees ON HR.Timesheet.username = HR.Employees.username WHERE focsdate BETWEEN '" + pDateFrom + "' AND '" + pDateTo + "' GROUP BY HR.Employees.username,HR.Employees.lastname,HR.Employees.firname ORDER BY pname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static Color GetStatusForeColor(string pStatus)
  {
   switch (pStatus)
   {
    case "W":
     return Color.Black;
    case "N":
     return Color.Blue;
    case "A":
     return Color.Red;
    case "R":
     return Color.Green;
    case "L":
     return Color.DeepPink;
    default:
     return Color.Black;
   }
  }

  public static Color GetStatusListBackColor(string pStatus)
  {
   switch (pStatus)
   {
    case "W":
     return Color.AliceBlue;
    case "N":
     return Color.LightYellow;
    case "A":
     return Color.MistyRose;
    case "R":
     return Color.Honeydew;
    case "L":
     return Color.PeachPuff;
    default:
     return Color.AliceBlue;
   }
  }

  //////////////////////////////////
  ///////// Helper Methods /////////
  //////////////////////////////////

  private static bool IsWithinDateRange(DateTime pDateStart, DateTime pDateEnd, DateTime pRangeStart, DateTime pRangeEnd)
  {
   bool blnReturn = false;
   if (pRangeStart <= pDateStart && pRangeEnd > pDateStart)
    blnReturn = true;
   else if (pRangeStart < pDateEnd && pRangeEnd >= pDateEnd)
    blnReturn = true;
   else if (pRangeStart > pDateStart && pRangeEnd < pDateEnd)
    blnReturn = true;
   return blnReturn;
  }

  private static float GetOTRegUnit(DateTime pOTStart, DateTime pOTEnd, DateTime pBreakStart, DateTime pBreakEnd, DateTime pFocusDate)
  {
   float fltReturn = 0;
   DateTime dteDateStart = new DateTime(pFocusDate.Year, pFocusDate.Month, pFocusDate.Day, 0, 0, 0);
   DateTime dteDateEnd = new DateTime(pFocusDate.AddDays(1).Year, pFocusDate.AddDays(1).Month, pFocusDate.AddDays(1).Day, 0, 0, 0);

   DateTime dteOTStart = (pOTStart >= pBreakStart && pOTStart < pBreakEnd ? pBreakEnd : pOTStart);
   DateTime dteOTEnd = (pOTEnd > pBreakStart && pOTEnd <= pBreakEnd ? pBreakStart : pOTEnd);

   dteOTStart = (dteOTStart < dteDateStart ? dteDateStart : dteOTStart);
   dteOTEnd = (dteOTEnd > dteDateEnd ? dteDateEnd : dteOTEnd);

   fltReturn = clsDateTime.DateDiff(pDateFormat.Hour, clsDateTime.RemoveSeconds(dteOTStart), clsDateTime.RemoveSeconds(dteOTEnd));

   if (dteOTStart < pBreakStart && dteOTEnd > pBreakEnd)
    fltReturn -= clsDateTime.DateDiff(pDateFormat.Hour, pBreakStart, pBreakEnd);

   return fltReturn;
  }

  private static float GetOTUnit(DateTime pOTStart, DateTime pOTEnd, DateTime pBreakStart, DateTime pBreakEnd, DateTime pFocusDate)
  {
   float fltReturn = 0;
   int intOTHourLimit = (pOTStart < pBreakStart && pOTStart.AddHours(8) > pBreakEnd ? 9 : 8); ;
   DateTime dteDateStart = new DateTime(pFocusDate.Year, pFocusDate.Month, pFocusDate.Day, 0, 0, 0);
   DateTime dteDateEnd = new DateTime(pFocusDate.AddDays(1).Year, pFocusDate.AddDays(1).Month, pFocusDate.AddDays(1).Day, 0, 0, 0);

   DateTime dteOTStart = pOTStart;
   DateTime dteOTEnd = (pOTEnd < dteOTStart.AddHours(intOTHourLimit) ? pOTEnd : dteOTStart.AddHours(intOTHourLimit));

   if (dteOTStart < dteOTEnd && IsWithinDateRange(dteOTStart,dteOTEnd,dteDateStart,dteDateEnd))
   {
    // Check if the ot is within the lunch break
    dteOTStart = (pOTStart >= pBreakStart && pOTStart < pBreakEnd ? pBreakEnd : dteOTStart);
    dteOTEnd = (pOTEnd > pBreakStart && pOTEnd <= pBreakEnd ? pBreakStart : dteOTEnd);

    // Check if the ot is within the ot day bracket
    dteOTStart = (dteOTStart < dteDateStart ? dteDateStart : dteOTStart);
    dteOTEnd = (dteOTEnd > dteDateEnd ? dteDateEnd : dteOTEnd);

    fltReturn = clsDateTime.DateDiff(pDateFormat.Hour, clsDateTime.RemoveSeconds(dteOTStart), clsDateTime.RemoveSeconds(dteOTEnd));

    if (dteOTStart < pBreakStart && dteOTEnd > pBreakEnd)
     fltReturn -= clsDateTime.DateDiff(pDateFormat.Hour, pBreakStart, pBreakEnd);
   }

   return fltReturn;
  }

  private static float GetExcessUnit(DateTime pOTStart, DateTime pOTEnd, DateTime pBreakStart, DateTime pBreakEnd, DateTime pFocusDate,string pShiftCode, string pUsername)
  {
   float fltReturn = 0;
   string strShiftMode = clsShift.GetShiftMode(pShiftCode);
   DateTime dteDateStart = clsDateTime.GetDateOnly(pFocusDate);
   DateTime dteDateEnd = clsDateTime.GetDateOnly(pFocusDate.AddDays(1));
   DateTime dteOTStart = (pOTStart >= pBreakStart && pOTStart < pBreakEnd ? pBreakEnd : pOTStart);
   DateTime dteOTEnd = (pOTEnd > pBreakStart && pOTEnd <= pBreakEnd ? pBreakStart : pOTEnd);

   for (DateTime dteTemp = clsDateTime.GetDateOnly(pFocusDate); dteTemp >= clsDateTime.GetDateOnly(pOTStart);dteTemp = dteTemp.AddDays(-1))
   {
    if (strShiftMode == clsShift.GetShiftMode(dteTemp, pUsername))
     dteOTStart = (pOTStart < clsDateTime.GetDateOnly(dteTemp) ? clsDateTime.GetDateOnly(dteTemp) : pOTStart);
    else
     break;
   }

   dteOTStart = dteOTStart.AddHours(dteOTStart < pBreakStart && dteOTStart.AddHours(8) > pBreakEnd ? 9 : 8);

   if (dteOTStart < dteOTEnd && IsWithinDateRange(dteOTStart, dteOTEnd, dteDateStart, dteDateEnd))
   {
    dteOTStart = (dteOTStart >= pBreakStart && dteOTStart < pBreakEnd ? pBreakEnd : dteOTStart);
    dteOTEnd = (dteOTEnd > pBreakStart && dteOTEnd <= pBreakEnd ? pBreakStart : dteOTEnd);

    dteOTStart = (dteOTStart < dteDateStart ? dteDateStart : dteOTStart);
    dteOTEnd = (dteOTEnd > dteDateEnd ? dteDateEnd : dteOTEnd);

    fltReturn = clsDateTime.DateDiff(pDateFormat.Hour, clsDateTime.RemoveSeconds(dteOTStart), clsDateTime.RemoveSeconds(dteOTEnd));

    if (dteOTStart < pBreakStart && dteOTEnd > pBreakEnd)
     fltReturn -= clsDateTime.DateDiff(pDateFormat.Hour, pBreakStart, pBreakEnd);
   }

   return fltReturn;
  }

  //private static float GetExcessUnit(DateTime pOTStart, DateTime pOTEnd, DateTime pBreakStart, DateTime pBreakEnd, DateTime pFocusDate)
  //{
  // float fltReturn = 0;

  // DateTime dteDateStart = new DateTime(pFocusDate.Year, pFocusDate.Month, pFocusDate.Day, 0, 0, 0);
  // DateTime dteDateEnd = new DateTime(pFocusDate.Year, pFocusDate.Month, pFocusDate.AddDays(1).Day, 0, 0, 0);

  // DateTime dteOTStart = pOTStart;
  // DateTime dteOTEnd = pOTEnd;

  // dteOTStart = dteOTStart.AddHours(8);

  // if (dteOTStart < dteOTEnd && IsWithinDateRange(dteOTStart, dteOTEnd, dteDateStart, dteDateEnd))
  // {
  //  dteOTStart = (dteOTStart >= pBreakStart && dteOTStart < pBreakEnd ? pBreakEnd : dteOTStart);
  //  dteOTEnd = (dteOTEnd > pBreakStart && dteOTEnd <= pBreakEnd ? pBreakStart : dteOTEnd);

  //  dteOTStart = (dteOTStart < dteDateStart ? dteDateStart : dteOTStart);
  //  dteOTEnd = (dteOTEnd > dteDateEnd ? dteDateEnd : dteOTEnd);

  //  fltReturn = clsDateTime.DateDiff(pDateFormat.Hour, dteOTStart, dteOTEnd);

  //  if (dteOTStart < pBreakStart && dteOTEnd > pBreakEnd)
  //   fltReturn -= clsDateTime.DateDiff(pDateFormat.Hour, pBreakStart, pBreakEnd);
  // }

  // return fltReturn;
  //}

  private static float GetNDUnit(DateTime pTimeIn, DateTime pTimeOut, DateTime pFocusDate)
  {
   float fltReturn = 0;
   DateTime dteNDStart1 = AdaptFocusDate(pFocusDate, NightDifferentialStart1);
   DateTime dteNDEnd1 = AdaptFocusDate(pFocusDate, NightDifferentialEnd1);
   DateTime dteNDStart2 = AdaptFocusDate(pFocusDate, NightDifferentialStart2);
   DateTime dteNDEnd2 = AdaptFocusDate(pFocusDate.AddDays(1), NightDifferentialEnd2);

   // Check the morning night differential
   DateTime dteOTStart = pTimeIn;
   DateTime dteOTEnd = pTimeOut;
   if (IsWithinDateRange(dteOTStart, dteOTEnd, dteNDStart1, dteNDEnd1))
   {
    if (dteOTStart < dteNDStart1)
     dteOTStart = dteNDStart1;
    if (dteOTEnd > dteNDEnd1)
     dteOTEnd = dteNDEnd1;
    fltReturn += clsDateTime.DateDiff(pDateFormat.Hour, clsDateTime.RemoveSeconds(dteOTStart), clsDateTime.RemoveSeconds(dteOTEnd));
   }

   // Check the evening night differential
   dteOTStart = pTimeIn;
   dteOTEnd = pTimeOut;
   if (IsWithinDateRange(dteOTStart, dteOTEnd, dteNDStart2, dteNDEnd2))
   {
    if (dteOTStart < dteNDStart2)
     dteOTStart = dteNDStart2;
    if (dteOTEnd > dteNDEnd2)
     dteOTEnd = dteNDEnd2;
    fltReturn += clsDateTime.DateDiff(pDateFormat.Hour, clsDateTime.RemoveSeconds(dteOTStart), clsDateTime.RemoveSeconds(dteOTEnd));
   }

   return fltReturn;
  }

  private static DateTime GetTimeIn(DateTime pTimeIn1, DateTime pTimeIn2)
  {
   if (pTimeIn1 != clsDateTime.SystemMinDate && pTimeIn2 != clsDateTime.SystemMinDate)
    return (pTimeIn1 <= pTimeIn2 ? pTimeIn1 : pTimeIn2);
   else if (pTimeIn1 != clsDateTime.SystemMinDate && pTimeIn2 == clsDateTime.SystemMinDate)
    return pTimeIn1;
   else if (pTimeIn1 == clsDateTime.SystemMinDate && pTimeIn2 != clsDateTime.SystemMinDate)
    return pTimeIn2;
   else
    return clsDateTime.SystemMinDate;
  }

  private static DateTime GetTimeOut(DateTime pTimeOut1, DateTime pTimeOut2)
  {
   if (pTimeOut1 != clsDateTime.SystemMinDate && pTimeOut2 != clsDateTime.SystemMinDate)
    return (pTimeOut1 >= pTimeOut2 ? pTimeOut1 : pTimeOut2);
   else if (pTimeOut1 != clsDateTime.SystemMinDate && pTimeOut2 == clsDateTime.SystemMinDate)
    return pTimeOut1;
   else if (pTimeOut1 == clsDateTime.SystemMinDate && pTimeOut2 != clsDateTime.SystemMinDate)
    return pTimeOut2;
   else
    return clsDateTime.SystemMinDate;
  }

  private static DateTime AdaptFocusDate(DateTime pFocusDate, DateTime pDateTime)
  {
   return new DateTime(pFocusDate.Year, pFocusDate.Month, pFocusDate.Day, pDateTime.Hour, pDateTime.Minute, pDateTime.Second);
  }

  private static float GetWorkUnit(DateTime pTimeIn, DateTime pTimeOut, DateTime pBreakStart, DateTime pBreakEnd)
  {
   float fltReturn = 0;
   DateTime dteTempIn = (pTimeIn >= pBreakStart && pTimeIn < pBreakEnd ? pBreakEnd : pTimeIn);
   DateTime dteTempOut = (pTimeOut > pBreakStart && pTimeOut <= pBreakEnd ? pBreakStart : pTimeOut);

   fltReturn = clsDateTime.DateDiff(pDateFormat.Hour, clsDateTime.RemoveSeconds(dteTempIn), clsDateTime.RemoveSeconds(dteTempOut));

   if (dteTempIn < pBreakStart && dteTempOut > pBreakEnd)
    fltReturn -= clsDateTime.DateDiff(pDateFormat.Hour, clsDateTime.RemoveSeconds(pBreakStart), clsDateTime.RemoveSeconds(pBreakEnd));

   return fltReturn;
  }

  private static float GetTimeAllUnit(DateTime pTimeIn, DateTime pTimeOut, DateTime pBreakStart, DateTime pBreakEnd)
  {
   float fltReturn = 0;
   float fltBreakTotal = (float)(pBreakEnd - pBreakStart).Hours;
   DateTime dteTempIn = pTimeIn;
   DateTime dteTempOut = pTimeOut;

   if (dteTempIn >= pBreakStart && dteTempIn <= pBreakEnd)
    dteTempIn = pBreakEnd;
   if (dteTempOut >= pBreakStart && dteTempOut <= pBreakEnd)
    dteTempOut = pBreakStart;
   fltReturn += clsDateTime.DateDiff(pDateFormat.Hour, clsDateTime.RemoveSeconds(dteTempIn), clsDateTime.RemoveSeconds(dteTempOut));

   if (dteTempIn < pBreakStart && dteTempOut > pBreakEnd)
    fltReturn -= fltBreakTotal;

   return (float)Math.Round(fltReturn, RoundDecimal);
  }

  private static float GetWorkUnit(DateTime pTimeIn, DateTime pTimeOut, string pShiftMode, DateTime pShiftStart, DateTime pShiftHalf, DateTime pShiftEnd, DateTime pBreakStart, DateTime pBreakEnd, DateTime pShiftLate, DateTime pShiftUndertime, float pLeaveAM, float pLeavePM)
  {
   float fltReturn = 0;
   float fltBreakTotal = (float)(pBreakEnd - pBreakStart).Hours;
   DateTime dteTempIn = pTimeIn;
   DateTime dteTempOut = pTimeOut;

   if (pShiftMode == "W")
   {
    // Time in settings
    // Check if there is a filed morning halfday
    if (dteTempIn <= pShiftStart)
     dteTempIn = pShiftStart;
    else if (dteTempIn >= pBreakStart && dteTempIn < pBreakEnd)
     dteTempIn = pBreakEnd;
        //else if (dteTempIn > pShiftLate && dteTempIn < pShiftHalf)    
    else if (dteTempIn <= pShiftLate && dteTempIn >= pShiftHalf)    
     dteTempIn = pShiftHalf;

    // Time out settings
    if (dteTempOut >= pShiftEnd)
     dteTempOut = pShiftEnd;
    else if (dteTempOut >= pBreakStart && dteTempOut <= pBreakEnd)
     dteTempOut = pBreakStart;
    else if (dteTempOut > pShiftHalf && dteTempOut < pShiftUndertime)
     dteTempOut = pShiftHalf;

    
    if (pLeaveAM == .5 && dteTempIn < pShiftHalf)
     dteTempIn = pShiftHalf;
    if (pLeavePM == .5 && dteTempOut > pShiftHalf)
     dteTempOut = pShiftHalf;

    // Check if not whole day leave
    if ((pLeaveAM == 0 || pLeavePM == 0) && ((dteTempIn <= pShiftLate && dteTempOut >= pShiftHalf) || (dteTempIn < pShiftUndertime && dteTempOut >= pShiftUndertime)))
    {
     fltReturn += clsDateTime.DateDiff(pDateFormat.Hour, clsDateTime.RemoveSeconds(dteTempIn), clsDateTime.RemoveSeconds(dteTempOut));
     if (dteTempIn < pBreakStart && dteTempOut > pBreakEnd)
      fltReturn -= fltBreakTotal;
    }
   }

   return (float)Math.Round(fltReturn, RoundDecimal);
  }

  private static float GetTimeWorkUnit(DataTable pTimeInOut, string pShiftMode, DateTime pShiftStart, DateTime pShiftHalf, DateTime pShiftEnd, DateTime pBreakStart, DateTime pBreakEnd, DateTime pShiftLate, DateTime pShiftUndertime, float pLeaveAM, float pLeavePM)
  {
   float fltReturn = 0;
   float fltBreakTotal = (float)(pBreakEnd - pBreakStart).Hours;
   DateTime dteTempIn = clsDateTime.SystemMinDate;
   DateTime dteTempOut = clsDateTime.SystemMinDate;

   if (pShiftMode == "W")
   {
    foreach (DataRow drwTC in pTimeInOut.Rows)
    {
     dteTempIn = clsValidator.CheckDate(drwTC["keyin"].ToString());
     dteTempOut = clsValidator.CheckDate(drwTC["keyout"].ToString());

     // Time in settings
     // Check if there is a filed morning halfday
     if (dteTempIn <= pShiftStart)
      dteTempIn = pShiftStart;
     else if (dteTempIn >= pBreakStart && dteTempIn < pBreakEnd)
      dteTempIn = pBreakEnd;
     //else if (dteTempIn > pShiftLate && dteTempIn < pShiftHalf)
     else if (dteTempIn < pShiftLate && dteTempIn < pShiftHalf)
      dteTempIn = pShiftHalf;

     // Time out settings
     if (dteTempOut >= pShiftEnd)
      dteTempOut = pShiftEnd;
     else if (dteTempOut >= pBreakStart && dteTempOut <= pBreakEnd)
      dteTempOut = pBreakStart;
     else if (dteTempOut > pShiftHalf && dteTempOut < pShiftUndertime)
      dteTempOut = pShiftHalf;

     if (pLeaveAM == .5 && dteTempIn < pShiftHalf)
      dteTempIn = pShiftHalf;
     if (pLeavePM == .5 && dteTempOut > pShiftHalf)
      dteTempOut = pShiftHalf;

     // Check if not whole day leave
     if ((pLeaveAM != .5 && pLeavePM != .5) && ((dteTempIn >= pShiftLate && dteTempOut >= pShiftHalf) || (dteTempIn < pShiftUndertime && dteTempOut >= pShiftUndertime)))
         //if ((pLeaveAM != .5 && pLeavePM != .5) && ((dteTempIn <= pShiftLate && dteTempOut >= pShiftHalf) || (dteTempIn < pShiftUndertime && dteTempOut >= pShiftUndertime)))
     {
      fltReturn += clsDateTime.DateDiff(pDateFormat.Hour, clsDateTime.RemoveSeconds(dteTempIn), clsDateTime.RemoveSeconds(dteTempOut));
      if (dteTempIn < pBreakStart && dteTempOut > pBreakEnd)
       fltReturn -= fltBreakTotal;
     }
    }
   }

   return (float)Math.Round(fltReturn, RoundDecimal);
  }

  private static float GetAbsentUnit(string pShiftMode, DateTime pTimeIn, DateTime pTimeOut, DateTime pShiftIn, DateTime pShiftHalf, DateTime pShiftOut, DateTime pShiftLate, DateTime pShiftUndertime, float pLeaveAM, float pLeavePM)
  {
   float fltReturn = 0;
   if (pShiftMode == "W")
   {
    
    //if (((pTimeIn > pShiftLate && pTimeOut < pShiftUndertime) || (pTimeIn < pShiftHalf && pTimeOut < pShiftHalf) || (pTimeIn >= pShiftUndertime && pTimeOut >= pShiftUndertime)) && (pLeaveAM == 0 && pLeavePM == 0))
    //{
    // // whole day absent, with time in/out record
    // fltReturn = 1;
    //}
    if ((pTimeIn == clsDateTime.SystemMinDate && pTimeOut == clsDateTime.SystemMinDate) && (pLeaveAM == 0 && pLeavePM == 0))
    {
     // whole day absent, no time in/out record
     fltReturn = 1;
    }
    else if (pTimeIn <= pShiftLate && pTimeOut < pShiftHalf && pLeaveAM == 0)
    //else if ((pTimeIn > pShiftLate && pTimeIn < pShiftUndertime && pTimeOut >= pShiftUndertime) && pLeaveAM == 0)
    {
        // morning halfday, with time in/out record
        fltReturn = 0.5F;
    }
    else if ((pTimeIn == clsDateTime.SystemMinDate && pTimeOut == clsDateTime.SystemMinDate) && pLeaveAM == 0)
    {
     // morning halfday, no time in/out record
     fltReturn = 0.5F;
    }
    //else if ((pTimeIn <= pShiftLate && pTimeOut >= pShiftHalf && pTimeOut < pShiftUndertime) && pLeavePM == 0)
    else if (pTimeOut > pShiftHalf && pTimeOut < pShiftUndertime && pTimeOut > pShiftOut && pLeavePM == 0)
    {
        // afternoon halfday, with time in/out record
        fltReturn = 0.5F;
    }
    else if ((pTimeIn == clsDateTime.SystemMinDate && pTimeOut == clsDateTime.SystemMinDate) && pLeavePM == 0)
    {
     // afternoon halfday, no time in/out record
     fltReturn = 0.5F;
    }

   }
   return fltReturn;
  }

  private static float GetLateUnit(string pShiftMode, DateTime pTimeIn, DateTime pTimeOut, DateTime pShiftIn, DateTime pShiftHalf, DateTime pShiftOut, DateTime pShiftLate, DateTime pShiftUndertime, float pLeaveAM, float pLeavePM)
  {
   float fltReturn = 0;
   if (pShiftMode == "W")
   {
//    if (pTimeIn > pShiftIn && pTimeIn <= pShiftLate && pLeaveAM == 0)
       if (pTimeIn > pShiftIn && pTimeIn >= pShiftLate && pLeaveAM == 0)
     fltReturn = clsDateTime.DateDiff(pDateFormat.Hour, pShiftIn, clsDateTime.RemoveSeconds(pTimeIn));
    else if (pTimeIn > pShiftHalf && pTimeIn < pShiftUndertime && pLeavePM == 0)
     fltReturn = clsDateTime.DateDiff(pDateFormat.Hour, pShiftHalf, clsDateTime.RemoveSeconds(pTimeIn));
   }
   return (float)Math.Round(fltReturn, RoundDecimal);
  }

  private static float GetUndertimeUnit(string pShiftMode, DateTime pTimeIn, DateTime pTimeOut, DateTime pShiftIn, DateTime pShiftOut, DateTime pShiftUndertime, float pLeavePM)
  {
   float fltReturn = 0;
   if (pShiftMode == "W")
   {
    if (pTimeOut < pShiftOut && pTimeOut >= pShiftUndertime && pLeavePM == 0)
     fltReturn = clsDateTime.DateDiff(pDateFormat.Hour, clsDateTime.RemoveSeconds(pTimeOut), pShiftOut);
   }
   return (float)Math.Round(fltReturn, RoundDecimal);
  }

  private static float GetExcess(string pShiftMode, DateTime pTimeIn, DateTime pTimeOut, DateTime pShiftIn, DateTime pShiftOut)
  {
   float fltReturn = 0;
   if (pShiftMode == "W")
   {
    if (pTimeIn < pShiftIn && pTimeIn != clsDateTime.SystemMinDate)
     fltReturn += clsDateTime.DateDiff(pDateFormat.Hour, clsDateTime.RemoveSeconds(pTimeIn), pShiftIn);
    if (pTimeOut > pShiftOut && pTimeOut != clsDateTime.SystemMinDate)
     fltReturn += clsDateTime.DateDiff(pDateFormat.Hour, pShiftOut, clsDateTime.RemoveSeconds(pTimeOut));    
   }
   return fltReturn;
  }

  //private static float GetOverTimeUnit(DataTable ptblOvertimeApplications, DateTime pTimeIn, DateTime pTimeOut)
  //{
  // float fltReturn = 0;
  // foreach (DataRow drw in ptblOvertimeApplications.Rows)
  // {
  //  DateTime dteOTStart = clsValidator.CheckDate(drw["datestrt"].ToString());
  //  DateTime dteOTEnd = clsValidator.CheckDate(drw["dateend"].ToString());

  //  if (pTimeIn < dteOTEnd && pTimeOut > dteOTStart)
  //  {
  //   if (pTimeIn > dteOTStart)
  //    dteOTStart = pTimeIn;

  //   if (pTimeOut < dteOTEnd)
  //    dteOTEnd = pTimeOut;

  //   fltReturn += clsDateTime.DateDiff(pDateFormat.Hour, dteOTStart, dteOTEnd);
  //  }
  // }
  // return fltReturn;
  //}

 }

}