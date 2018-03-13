using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HRMS;

namespace Ipanema.Forms
{
    public partial class frmPerfectAttendance : Form
    {
        private int _intAbsentunit;
        private int _intLeaveWithPay;
        private int _intLeaveWithoutPay;
        private int _intLateUnit;
        private int _intUndertime;
        private int _intCDL;
        private DataTable _dtEmployee;
        private DataTable _dtEmployeeAttendance;
        private DataTable _dtEmployeePerfectAttendance;
        private DataTable _dtTimeSheet;
        private DataTable _dtPerfectAttendanceDetails;
        private DataTable _dtOfficialBusiness;
        private DataTable _dtEmployeeOfficialBusiness;
        private DateTime _dateStart;
        private DateTime _dateEnd;

        public int AbsentUnit { get { return _intAbsentunit; } set { _intAbsentunit = value; } }
        public int LeaveWithPay { get { return _intLeaveWithPay; } set { _intLeaveWithPay = value; } }
        public int LeaveWithoutPay { get { return _intLeaveWithoutPay; } set { _intLeaveWithoutPay = value; } }
        public int LateUnit { get { return _intLateUnit; } set { _intLateUnit = value; } }
        public int Undertime { get { return _intUndertime; } set { _intUndertime = value; } }
        public int CDL { get { return _intCDL; } set { _intCDL = value; } }
        public DataTable TableEmployee { get { return _dtEmployee; } set { _dtEmployee = value; } }
        public DataTable TableEmployeeAttendance { get { return _dtEmployeeAttendance; } set { _dtEmployeeAttendance = value; } }
        public DataTable TablePerfectAttendance { get { return _dtEmployeePerfectAttendance; } set { _dtEmployeePerfectAttendance = value; } }
        public DataTable TableTimeSheet { get { return _dtTimeSheet; } set { _dtTimeSheet = value; } }
        public DateTime DateStarted { get { return _dateStart; } set { _dateStart = value; } }
        public DateTime DateEnded { get { return _dateEnd; } set { _dateEnd = value; } }
        public DataTable PerfectAttendanceDetails { get { return _dtPerfectAttendanceDetails; } set { _dtPerfectAttendanceDetails = value; } }
        public DataTable OfficialBusiness { get { return _dtOfficialBusiness; } set { _dtOfficialBusiness = value; } }
        public DataTable EmployeeOfficialBusiness { get { return _dtEmployeeOfficialBusiness; } set { _dtEmployeeOfficialBusiness = value; } }

        public frmPerfectAttendance()
        {
            InitializeComponent();
        }

        private void frmPerfectAttendance_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadCurrentTimesheetPeriod();
            InitializeEmployee();
            InitializeEmployeeAttendance();
            InitializePerfectAttendance();
            InitializeEmployeeTimeSheet();
            InitializePerfectAttendanceDetails();
            InitializeEmployeeOBDetails();
            InitializeEmployeePAOBDetails();
            _dtEmployee = clsPerfectAttendance.DSTPerfectAttendance();
            rdSummary.Checked = true;
        }

        public void LoadCurrentTimesheetPeriod()
        {
            string strCurrentTimeSheetPeriod = clsTimeSheetPeriod.GetCurrentTimeSheetPeriod();
            using (clsTimeSheetPeriod tsp = new clsTimeSheetPeriod(strCurrentTimeSheetPeriod))
            {
                tsp.Fill();
                DateStart.Value = tsp.PeriodFrom;
                DateEnd.Value = tsp.PeriodTo;
            }
        }

        private void InitializeEmployee()
        {
            _dtEmployee = new DataTable();
            _dtEmployee.Columns.Add("username");
            _dtEmployee.Columns.Add("lastname");
            _dtEmployee.Columns.Add("firstname");
            _dtEmployee.Columns.Add("middlename");
            _dtEmployee.Columns.Add("nickname");
            _dtEmployee.Columns.Add("division");
            _dtEmployee.Columns.Add("pimage");
        }

        private void InitializeEmployeeAttendance()
        {
            _dtEmployeeAttendance = new DataTable();
            _dtEmployeeAttendance.Columns.Add("username");
            _dtEmployeeAttendance.Columns.Add("lastname");
            _dtEmployeeAttendance.Columns.Add("firstname");
            _dtEmployeeAttendance.Columns.Add("middlename");
            _dtEmployeeAttendance.Columns.Add("nickname");
            _dtEmployeeAttendance.Columns.Add("division");
            _dtEmployeeAttendance.Columns.Add("pimage");
        }

        private void InitializePerfectAttendance()
        {
            _dtEmployeePerfectAttendance = new DataTable();
            _dtEmployeePerfectAttendance.Columns.Add("username");
            _dtEmployeePerfectAttendance.Columns.Add("lastname");
            _dtEmployeePerfectAttendance.Columns.Add("firstname");
            _dtEmployeePerfectAttendance.Columns.Add("middlename");
            _dtEmployeePerfectAttendance.Columns.Add("nickname");
            _dtEmployeePerfectAttendance.Columns.Add("division");
            _dtEmployeePerfectAttendance.Columns.Add("pimage");
            _dtEmployeePerfectAttendance.Columns.Add("daterangestart");
            _dtEmployeePerfectAttendance.Columns.Add("daterangeend");
        }

        private void InitializeEmployeeTimeSheet()
        {
            _dtTimeSheet = new DataTable();
            _dtTimeSheet.Columns.Add("username");
            _dtTimeSheet.Columns.Add("timestart");
            _dtTimeSheet.Columns.Add("timeend");
            _dtTimeSheet.Columns.Add("shiftin");
            _dtTimeSheet.Columns.Add("shiftout");
            _dtTimeSheet.Columns.Add("lastname");
            _dtTimeSheet.Columns.Add("firstname");
            _dtTimeSheet.Columns.Add("middlename");
            _dtTimeSheet.Columns.Add("division");
            _dtTimeSheet.Columns.Add("pstatus");
            _dtTimeSheet.Columns.Add("obunit");
            _dtTimeSheet.Columns.Add("ttalunit");
            _dtTimeSheet.Columns.Add("workunit");
            _dtTimeSheet.Columns.Add("tworkhrs");
        }

        private void InitializeEmployeeOBDetails()
        {
            _dtOfficialBusiness = new DataTable();
            _dtOfficialBusiness.Columns.Add("employeename");
            _dtOfficialBusiness.Columns.Add("focsdate");
            _dtOfficialBusiness.Columns.Add("reason");
        }

        private void InitializeEmployeePAOBDetails()
        {
            _dtEmployeeOfficialBusiness = new DataTable();
            _dtEmployeeOfficialBusiness.Columns.Add("employeename");
            _dtEmployeeOfficialBusiness.Columns.Add("focsdate");
            _dtEmployeeOfficialBusiness.Columns.Add("reason");
        }

        private void InitializePerfectAttendanceDetails()
        {
            _dtPerfectAttendanceDetails = new DataTable();
            _dtPerfectAttendanceDetails.Columns.Add("username");
            _dtPerfectAttendanceDetails.Columns.Add("timestart");
            _dtPerfectAttendanceDetails.Columns.Add("timeend");
            _dtPerfectAttendanceDetails.Columns.Add("shiftin");
            _dtPerfectAttendanceDetails.Columns.Add("shiftout");
            _dtPerfectAttendanceDetails.Columns.Add("lastname");
            _dtPerfectAttendanceDetails.Columns.Add("firstname");
            _dtPerfectAttendanceDetails.Columns.Add("middlename");
            _dtPerfectAttendanceDetails.Columns.Add("division");
            _dtPerfectAttendanceDetails.Columns.Add("pstatus");
            _dtPerfectAttendanceDetails.Columns.Add("counter");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (DateStart.Value >= DateEnd.Value)
            {
                MessageBox.Show("Invalid date.","HRMS");
            }
            else
            {
                prog1.Visible = true;
                _dtEmployeeAttendance.Clear();
                _dateStart = clsDateTime.ChangeTimeToStart(DateStart.Value);
                _dateEnd = clsDateTime.ChangeTimeToEnd(DateEnd.Value);

                //checking of employe without late, undertime, and leave
                foreach (DataRow dgRow in _dtEmployee.Rows)
                {
                    _intAbsentunit = 0;
                    _intLateUnit = 0;
                    _intLeaveWithoutPay = 0;
                    _intLeaveWithPay = 0;
                    _intUndertime = 0;
                    _intCDL = 0;

                    _intAbsentunit = clsPerfectAttendance.CountAbsentTotal(dgRow["username"].ToString(), _dateStart, _dateEnd);
                    _intLeaveWithPay = clsPerfectAttendance.CountLeaveWithPayTotal(dgRow["username"].ToString(), _dateStart, _dateEnd);
                    _intLeaveWithoutPay = clsPerfectAttendance.CountLeaveWithoutPayTotal(dgRow["username"].ToString(), _dateStart, _dateEnd);
                    _intLateUnit = clsPerfectAttendance.CountLateTotal(dgRow["username"].ToString(), _dateStart, _dateEnd);
                    _intUndertime = clsPerfectAttendance.CountUndertimeTotal(dgRow["username"].ToString(), _dateStart, _dateEnd);
                    _intCDL = clsPerfectAttendance.CountCDLTotal(dgRow["username"].ToString(), _dateStart, _dateEnd);


                    if (_intAbsentunit == 0 && _intLeaveWithoutPay == 0 && _intLateUnit == 0 && _intUndertime == 0 && _intLeaveWithPay == 0)
                    {
                        //MessageBox.Show(_intLeaveWithPay.ToString() + '=' + _intCDL.ToString());
                        DataRow drw = _dtEmployeeAttendance.NewRow();
                        drw["username"] = dgRow["username"].ToString();
                        drw["lastname"] = dgRow["lastname"].ToString();
                        drw["firstname"] = dgRow["firstname"].ToString();
                        drw["middlename"] = dgRow["middlename"].ToString();
                        drw["nickname"] = dgRow["nickname"].ToString();
                        drw["division"] = dgRow["division"].ToString();
                        drw["pimage"] = dgRow["pimage"].ToString();
                        _dtEmployeeAttendance.Rows.Add(drw);
                        _dtEmployeeAttendance.AcceptChanges();
                    }
                    try
                    {
                        prog1.Value = prog1.Value + 1;
                    }
                    catch
                    {
                        prog1.Value = 0;
                    }
                }

                _dtEmployeePerfectAttendance.Clear();
                _dtPerfectAttendanceDetails.Clear();
                int z = 1;
                

                // checking of OB employees
                foreach (DataRow drw in _dtEmployeeAttendance.Rows)
                {
                    int i = 0;
                    int j = 0;


                    _dtTimeSheet.Clear();
                    _dtOfficialBusiness.Clear();
                    _dtTimeSheet = clsPerfectAttendance.DSTTimeSheet(drw["username"].ToString(), DateStart.Value, DateEnd.Value);
                    _dtOfficialBusiness = OfficialBusinessDetails.DSGEmployeeOBDetails(drw["username"].ToString(), DateStart.Value, DateEnd.Value);

                    foreach (DataRow dgtRow in _dtTimeSheet.Rows)
                    {
                        if (dgtRow["timestart"].ToString() == dgtRow["shiftin"].ToString() && clsValidator.CheckFloat(dgtRow["workunit"].ToString()) >= clsValidator.CheckFloat(dgtRow["tworkhrs"].ToString()) && dgtRow["pstatus"].ToString() == "W")
                        {
                            j = 1;
                        }
                        else if (clsDateTime.RemoveSeconds(clsDateTime.CombineDateTime(clsValidator.CheckDate(dgtRow["timestart"].ToString()), clsValidator.CheckDate(dgtRow["shiftin"].ToString()).AddMinutes(-clsValidator.CheckInteger(txtinterval.Text)))) < clsDateTime.RemoveSeconds(clsValidator.CheckDate(dgtRow["timestart"].ToString())) && dgtRow["pstatus"].ToString() == "W")
                        {
                            i = 1;
                        }
                    }


                    ///employees with perfect attendance
                    if (i == 0)
                    {
                        DataRow drwPA = _dtEmployeePerfectAttendance.NewRow();
                        drwPA["username"] = drw["username"].ToString();
                        drwPA["lastname"] = drw["lastname"].ToString();
                        drwPA["firstname"] = drw["firstname"].ToString();
                        drwPA["middlename"] = drw["middlename"].ToString();
                        drwPA["nickname"] = drw["nickname"].ToString();
                        drwPA["division"] = drw["division"].ToString();
                        drwPA["pimage"] = drw["pimage"].ToString();
                        drwPA["daterangestart"] =clsDateTime.GetDateOnly(_dateStart);
                        drwPA["daterangeend"] = clsDateTime.GetDateOnly(_dateEnd);
                        _dtEmployeePerfectAttendance.Rows.Add(drwPA);
                        _dtEmployeeAttendance.AcceptChanges();

                        //employees with perfect attendance with details
                        foreach (DataRow dgvPADetails in _dtTimeSheet.Rows)
                        {
                            if (dgvPADetails["pstatus"].ToString() == "W")
                            {
                                DataRow drwPADetails = _dtPerfectAttendanceDetails.NewRow();
                                drwPADetails["username"] = dgvPADetails["username"].ToString();
                                drwPADetails["timestart"] = dgvPADetails["timestart"].ToString();
                                drwPADetails["timeend"] = dgvPADetails["timeend"].ToString();
                                drwPADetails["shiftin"] = dgvPADetails["shiftin"].ToString();
                                drwPADetails["shiftout"] = dgvPADetails["shiftout"].ToString();
                                drwPADetails["lastname"] = dgvPADetails["lastname"].ToString();
                                drwPADetails["firstname"] = dgvPADetails["firstname"].ToString();
                                drwPADetails["middlename"] = dgvPADetails["middlename"].ToString();
                                drwPADetails["counter"] = z;
                                _dtPerfectAttendanceDetails.Rows.Add(drwPADetails);
                                _dtPerfectAttendanceDetails.AcceptChanges();
                            }
                        }

                        //employee with perfect attendace OB Details
                        if (j == 1)
                        {
                            foreach (DataRow dgob in _dtOfficialBusiness.Rows)
                            {
                                DataRow drob = _dtEmployeeOfficialBusiness.NewRow();
                                drob["employeename"] = dgob["employeename"].ToString();
                                drob["focsdate"] = dgob["focsdate"].ToString();
                                drob["reason"] = dgob["reason"].ToString();
                                _dtEmployeeOfficialBusiness.Rows.Add(drob);
                                _dtEmployeeOfficialBusiness.AcceptChanges();
                            }
                        }
                        z = z + 1;
                        
                    }
                    try
                    {
                        prog1.Value = prog1.Value + 1;
                    }
                    catch
                    {
                    }
                }

                try
                {
                    bsPA.DataSource = _dtEmployeePerfectAttendance;
                    this.rptPerfectAttendance.RefreshReport();

                    bsPADetails.DataSource = _dtPerfectAttendanceDetails;
                    this.rptPADetails.RefreshReport();

                    bsPAOB.DataSource = _dtEmployeeOfficialBusiness;
                    this.rptPAOB.RefreshReport();

                    MessageBox.Show(_dtEmployeePerfectAttendance.Rows.Count.ToString() +" employee(s) found.","HRMS");

                }
                catch
                {
                    this.rptPerfectAttendance.RefreshReport();
                    this.rptPADetails.RefreshReport();
                    this.rptPAOB.RefreshReport();
                }

                prog1.Visible = false;

            }
        }

        private void txtinterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !(Char.IsDigit(e.KeyChar)) && e.KeyChar != Delete;
        }

        private void tbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdSummary_CheckedChanged(object sender, EventArgs e)
        {
            pnlSummary.Dock = DockStyle.Fill;
            pnlSummary.Visible = true;
            pnlOB.Visible = false;
            pnlDetail.Visible = false;
        }

        private void rdDetail_CheckedChanged(object sender, EventArgs e)
        {
            pnlDetail.Dock = DockStyle.Fill;
            pnlDetail.Visible = true;
            pnlSummary.Visible = false;
            pnlOB.Visible = false;
        }

        private void rdPAOB_CheckedChanged(object sender, EventArgs e)
        {
           this.pnlOB.Dock = DockStyle.Fill;
            pnlDetail.Visible = false;
            pnlSummary.Visible = false;
            pnlOB.Visible = true;
        }
    }
}
