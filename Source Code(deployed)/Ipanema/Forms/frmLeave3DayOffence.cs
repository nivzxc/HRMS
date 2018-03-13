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
    public partial class frmLeave3DayOffence : Form
    {
        private DataTable _tblLeave;
        private DataTable _tblEmployeeLeave;

        public DataTable TableLeave { get { return _tblLeave; } set { _tblLeave = value; } }
        public DataTable TableEmployeeLeave { get { return _tblEmployeeLeave; } set { _tblEmployeeLeave = value; } }

        public frmLeave3DayOffence()
        {
            InitializeComponent();
        }

        private void InitializeLeaveOffense()
        {
            _tblLeave = new DataTable();
            _tblLeave.Columns.Add("username");
            _tblLeave.Columns.Add("employeename");
            _tblLeave.Columns.Add("units");
        }

        private void InitializeEmployeeLeaveOffense()
        {
            _tblEmployeeLeave = new DataTable();
            _tblEmployeeLeave.Columns.Add("username");
            _tblEmployeeLeave.Columns.Add("employeename");
            _tblEmployeeLeave.Columns.Add("units");
            _tblEmployeeLeave.Columns.Add("datestart");
            _tblEmployeeLeave.Columns.Add("dateend");
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

        private void tbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLeave3DayOffence_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeLeaveOffense();
            InitializeEmployeeLeaveOffense();
            LoadCurrentTimesheetPeriod();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (DateStart.Value >= DateEnd.Value)
            {
                MessageBox.Show("Invalid dates.", "HRMS");
            }
            else
            {
                _tblLeave.Clear();
                _tblEmployeeLeave.Clear();

                DateTime _dtstart = clsDateTime.GetDateOnly(DateStart.Value);
                DateTime _dtend = clsDateTime.GetDateOnly(DateEnd.Value).AddDays(1);
                _tblLeave = LeaveApplication.GETDSGLeaveOffense(_dtstart, _dtend);

                foreach (DataRow dtrow in _tblLeave.Rows)
                {
                    if (clsValidator.CheckDouble(dtrow["units"].ToString()) >= clsValidator.CheckDouble(txtNoLeave.Text))
                    {
                        DataRow dtemployee = _tblEmployeeLeave.NewRow();
                        dtemployee["username"] = dtrow["username"].ToString();
                        dtemployee["employeename"] = dtrow["employeename"].ToString();
                        dtemployee["units"] = clsValidator.CheckDouble(dtrow["units"].ToString()).ToString();
                        dtemployee["datestart"] = _dtstart.ToShortDateString();
                        dtemployee["dateend"] = clsDateTime.GetDateOnly(DateEnd.Value).ToShortDateString();
                        _tblEmployeeLeave.Rows.Add(dtemployee);
                        _tblEmployeeLeave.AcceptChanges();
                    }
                }

                try
                {
                    dsLeaveOffenseBindingSource.DataSource = _tblEmployeeLeave;
                    rptLeaveOffense.RefreshReport();
                }
                catch
                {
                    rptLeaveOffense.RefreshReport();
                }
            }
        }
    }
}
