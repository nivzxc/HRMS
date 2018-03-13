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
    public partial class frmLeave3DaysMain : Form
    {
        private mdiIpanema _mdiIpanema;
        private Form _frmCaller;
        private string _strLeaveCode;
        private string _strusernamecode;
        private string _strIndicator;
        private string _stremployeename;

        public mdiIpanema MDIIpanema { get { return _mdiIpanema; } set { _mdiIpanema = value; } }
        public Form FormCaller { get { return _frmCaller; } set { _frmCaller = value; } }
        public string LeaveCodeIpanema { get { return _strLeaveCode; } set { _strLeaveCode = value; } }
        public string UserNameCode { get { return _strusernamecode; } set { _strusernamecode = value; } }
        public string Indicator { get { return _strIndicator; } set { _strIndicator = value; } }
        public string EmployeeNameCode { get { return _stremployeename; } set { _stremployeename = value; } }

        public frmLeave3DaysMain()
        {
            InitializeComponent();
        }

        private void frmLeave3DaysMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadEmployeeLeaveoffense();

            if(_strIndicator == "1")
            {
            frmLeave3DaysEdit objfrmLeave3DaysEdit = new frmLeave3DaysEdit();
            objfrmLeave3DaysEdit.MDIIpanema = _mdiIpanema;
            objfrmLeave3DaysEdit.FormCaller = _mdiIpanema;
            objfrmLeave3DaysEdit.FormLeave3DayMain = this;
            objfrmLeave3DaysEdit.LeaveCode = _strLeaveCode;
            objfrmLeave3DaysEdit.Username = _strusernamecode;
            objfrmLeave3DaysEdit.EmployeeName = _stremployeename;
            objfrmLeave3DaysEdit.ShowDialog();
            }
        }

        public void LoadEmployeeLeaveoffense()
        {
            dgLeaveList.AutoGenerateColumns = false;
            dgLeaveList.DataSource = clsLeave3Days.GetDSGMainForm();
            if (_strIndicator == "1")
            {
                _mdiIpanema.LoadDSGLeaveNotification();
            }
        }

        private void tbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployeeLeaveoffense();
        }

        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            frmLeave3DaysAdd objfrmLeave3DaysAdd = new frmLeave3DaysAdd();
            objfrmLeave3DaysAdd.FormLeave3DaysMain = this;
            objfrmLeave3DaysAdd.ShowDialog();
        }

        private void tbtnEdit_Click(object sender, EventArgs e)
        {
            if (dgLeaveList.Rows.Count > 0)
            {
                frmLeave3DaysEdit objfrmLeave3DayEdit = new frmLeave3DaysEdit();
                objfrmLeave3DayEdit.FormLeave3DayMain = this;
                objfrmLeave3DayEdit.FormCaller = this;
                objfrmLeave3DayEdit.LeaveCode = dgLeaveList.SelectedRows[0].Cells[0].Value.ToString();
                objfrmLeave3DayEdit.Username = dgLeaveList.SelectedRows[0].Cells[1].Value.ToString();
                objfrmLeave3DayEdit.EmployeeName = dgLeaveList.SelectedRows[0].Cells[2].Value.ToString();
                objfrmLeave3DayEdit.ShowDialog();
            }
        }

        private void dgLeaveList_DoubleClick(object sender, EventArgs e)
        {
            tbtnEdit_Click(null, null);
        }
    }
}
