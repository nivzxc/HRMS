using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using HRMS;

namespace Ipanema.Forms
{
    public partial class frmLeaveSettingEdit : Form
    {
        public frmLeaveSettingList _frmCaller;
        public string _strLeaveName;
        public string _strLeaveType;
        private mdiIpanema _frmMdiCaller;

        public mdiIpanema FormMDICaller { get { return _frmMdiCaller; } set { _frmMdiCaller = value; } }
        public frmLeaveSettingList FormLeaveSettingList { get { return _frmCaller; } set { _frmCaller = value; } }
        public string LeaveName { get { return _strLeaveName; } set { _strLeaveName = value; } }
        public string LeaveType { get { return _strLeaveType; } set { _strLeaveType = value; } }

        public frmLeaveSettingEdit()
        {
            InitializeComponent();
        }

        private void frmLeaveSetting_Load(object sender, EventArgs e)
        {
            using (clsLeaveSetting objLeaveSetting = new clsLeaveSetting())
            {
                lblEL.Text = LeaveName;
                objLeaveSetting.LeaveName = LeaveName;
                objLeaveSetting.Fill();
                txtCode.Text = objLeaveSetting.LeaveCode;
            }

            LeaveApplicationTypes objfill = new LeaveApplicationTypes();
            objfill.LeaveTypeCode = txtCode.Text;
            objfill.Fill();
            cmbELwp.DataSource = LeaveApplicationTypes.DSLLeaveTypeWithPay();
            cmbELwp.ValueMember = "pvalue";
            cmbELwp.DisplayMember = "ptext";
            cmbELwp.SelectedValue = objfill.LeaveTypeCode;
            cmbELwp.Text = objfill.LeaveType;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (clsLeaveSetting objFill = new clsLeaveSetting())
            {
                objFill.LeaveName = LeaveName;
                objFill.LeaveCode = cmbELwp.SelectedValue.ToString();
                objFill.Update();
                _frmCaller.LoadLeaveSetting();
            }
            _frmMdiCaller.DSGZeroEL();
            _frmMdiCaller.DSGZeroSL();
            _frmMdiCaller.DSGZeroVL();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbELwp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCode.Text = cmbELwp.SelectedValue.ToString();
        }
    }
}
