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
    public partial class frmLeave3DaysEdit : Form
    {
        private frmLeave3DaysMain _frmLeave3DayMain;
        private mdiIpanema _mdiIpanema;
        private Form _frmCaller;
        private string _strLeaveCode;
        private string _strUserName;
        private string _strEmployeeName;

        public mdiIpanema MDIIpanema { get { return _mdiIpanema; } set { _mdiIpanema = value; } }
        public Form FormCaller { get { return _frmCaller; } set { _frmCaller = value; } }
        public frmLeave3DaysMain FormLeave3DayMain { get { return _frmLeave3DayMain; } set { _frmLeave3DayMain = value; } }
        public string LeaveCode { get { return _strLeaveCode; } set { _strLeaveCode = value; } }
        public string Username { get { return _strUserName; } set { _strUserName = value; } }
        public string EmployeeName { get { return _strEmployeeName; } set { _strEmployeeName = value; } }

        public frmLeave3DaysEdit()
        {
            InitializeComponent();
        }

        private void frmLeave3DaysEdit_Load(object sender, EventArgs e)
        {
           LoadData();
        }

        private void LoadData()
        {
            clsLeave3Days objfrmLeave3Days = new clsLeave3Days();
            objfrmLeave3Days.LeaveCode = _strLeaveCode;
            txtOffenseCode.Text = _strLeaveCode;
            objfrmLeave3Days.Fill();
            txtEmployeeName.Text = _strEmployeeName;
            txtUnit.Text = objfrmLeave3Days.Unit.ToString();
            dtpDateStart.Value = objfrmLeave3Days.DateStart;
            dtpDateEnd.Value = objfrmLeave3Days.DateEnd;
            txtRemarks.Text = objfrmLeave3Days.Remarks;
            txtCreatedBy.Text = objfrmLeave3Days.Createby.ToString();
            txtDateCreated.Text = objfrmLeave3Days.CreateOn.ToString();
            txtModifiedBy.Text = objfrmLeave3Days.ModifyBy.ToString();
            txtDateModified.Text = objfrmLeave3Days.ModifyOn.ToString();
            chkEnabled.Checked =  objfrmLeave3Days.Enabled == "1" ? true : false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpDateStart.Value > dtpDateEnd.Value)
            {
                MessageBox.Show("Invalid date.", "HRMS");
            }
            else if (clsValidator.CheckDouble(txtUnit.Text) < 3)
            {
                MessageBox.Show("Leave unit is lower than 3.", "HRMS");
            }
            else
            {
                clsLeave3Days objfrmclsLeave3Days = new clsLeave3Days();
                objfrmclsLeave3Days.LeaveCode = _strLeaveCode;
                objfrmclsLeave3Days.Username = _strUserName;
                objfrmclsLeave3Days.Unit = clsValidator.CheckDouble(txtUnit.Text);
                objfrmclsLeave3Days.DateStart = dtpDateStart.Value;
                objfrmclsLeave3Days.DateEnd = dtpDateEnd.Value;
                objfrmclsLeave3Days.Remarks = txtRemarks.Text;
                objfrmclsLeave3Days.Enabled = chkEnabled.Checked == true ? "1" : "0";
                objfrmclsLeave3Days.Update();

                if (_frmCaller == _frmLeave3DayMain)
                {
                    _frmLeave3DayMain.LoadEmployeeLeaveoffense();
                }
                else if(_frmCaller == _mdiIpanema)
                {
                    _mdiIpanema.LoadDSGLeaveNotification();
                    _frmLeave3DayMain.LoadEmployeeLeaveoffense();
                }

                this.Close();
            }
        }
    }
}
