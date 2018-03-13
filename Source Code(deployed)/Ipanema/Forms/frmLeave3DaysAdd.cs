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
    public partial class frmLeave3DaysAdd : Form
    {

        private frmLeave3DaysMain _frmLeave3DaysMain;

        public frmLeave3DaysMain FormLeave3DaysMain { get { return _frmLeave3DaysMain; } set { _frmLeave3DaysMain = value; } }

        public frmLeave3DaysAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsValidator.CheckDouble(txtUnits.Text) < 3)
            {
                MessageBox.Show("Leave Unit is lower than three.", "HRMS");
            }
            else if (dtpDateStart.Value > dtpDateEnd.Value)
            {
                MessageBox.Show("Invalid date start and end.", "HRMS");
            }
            else
            {
                clsLeave3Days objfrmclsLeave3Days = new clsLeave3Days();
                objfrmclsLeave3Days.Username = cmbEmployeeName.SelectedValue.ToString();
                objfrmclsLeave3Days.Unit = clsValidator.CheckDouble(txtUnits.Text);
                objfrmclsLeave3Days.DateStart = dtpDateStart.Value;
                objfrmclsLeave3Days.DateEnd = dtpDateEnd.Value;
                objfrmclsLeave3Days.Remarks = txtRemarks.Text;
                objfrmclsLeave3Days.Enabled = "1";
                objfrmclsLeave3Days.Insert();
                _frmLeave3DaysMain.LoadEmployeeLeaveoffense();
                this.Close();
            }
        }

        private void dtpDateStart_ValueChanged(object sender, EventArgs e)
        {
            LoadDate();
        }

        private void LoadDate()
        {
            dtpDateEnd.Value = dtpDateStart.Value.AddMonths(3);
        }

        private void LoadData()
        {
            cmbEmployeeName.DataSource = Employee.DSLActive();
            cmbEmployeeName.ValueMember = "pvalue";
            cmbEmployeeName.DisplayMember = "ptext";

        }

        private void frmLeave3DaysAdd_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == 46) && e.KeyChar != Delete;
        }
    }
}
