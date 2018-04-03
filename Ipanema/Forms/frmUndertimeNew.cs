using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using HRMS;

namespace Ipanema.Forms
{
    public partial class frmUndertimeNew : Form
    {
        public frmUndertimeNew() { InitializeComponent(); }

        frmUndertimeList _frmUndertimeList;
        private string UT_Code;
        public frmUndertimeList FormUndertimeList { set { _frmUndertimeList = value; } get { return _frmUndertimeList; } }

        private void InitializeFields()
        {
            UT_code();
            cmbStatus.DataSource = clsUndertime.DdlDsStatus();
            cmbStatus.ValueMember = "pvalue";
            cmbStatus.DisplayMember = "ptext";

            cmbRequestor.DataSource = Employee.DSLActive();
            cmbRequestor.ValueMember = "pvalue";
            cmbRequestor.DisplayMember = "ptext";

            cmbApprover.DataSource = clsDepartmentApprover.DdlDsByEmployee(cmbRequestor.SelectedValue.ToString(), EFormType.Undertime);
            cmbApprover.ValueMember = "pvalue";
            cmbApprover.DisplayMember = "ptext";
        }

        private bool IsCorrectData()
        {
            bool blnReturn = true;
            string strErrorMessage = "";

            if (txtReason.Text == "")
                strErrorMessage += "\nReason is required.";

            if (clsUndertime.HasExistingApplication(cmbRequestor.SelectedValue.ToString(), dtpDateApplied.Value))
                strErrorMessage += "\nThere is already an application on the specified date.";

            if (strErrorMessage != "")
            {
                MessageBox.Show("Data entry error:" + strErrorMessage, "HRMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                blnReturn = false;
            }

            return blnReturn;
        }

        private void UT_code()
        {
            string get_code;
            int intSeed = 0;
            SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString);
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT pvalue FROM Speedo.Keys WHERE pkey='utcode'";
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                UT_Code = dr["pvalue"].ToString();
            }
            dr.Close();
            if (UT_Code == null || UT_Code == "")
            {
                get_code = UT_Code;
                intSeed = clsValidator.CheckInteger(UT_Code) + 1;
                UT_Code = ("UT" + intSeed.ToString());
                txtUndertimeCode.Text = UT_Code;
            }
            else {
                char[] removeChar = { 'U', 'T' };
                string digits = UT_Code.TrimStart(removeChar);
                intSeed = clsValidator.CheckInteger(digits) + 1;
                digits = ("UT" + intSeed.ToString());
                txtUndertimeCode.Text = digits;

            }


        }
        /////////////////////////////
        //////// Form Events ////////
        /////////////////////////////

  private void frmUndertimeNew_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (clsUndertime undertime = new clsUndertime())
    {
     undertime.UndertimeCode = txtUndertimeCode.Text;
     undertime.Username = cmbRequestor.SelectedValue.ToString();
     undertime.DateFiled = dtpFileDate.Value;
     undertime.DateApplied = clsDateTime.CombineDateTime(dtpDateApplied.Value, dtpTimeApplied.Value);
     undertime.Reason = txtReason.Text;
     undertime.ApproverUsername = cmbApprover.SelectedValue.ToString();
     undertime.ApproverDate = dtpDateProcess.Value;
     undertime.ApproverRemarks = txtRemarks.Text;
     undertime.Status = cmbStatus.SelectedValue.ToString();
     undertime.InsertAdmin();
    }
    _frmUndertimeList.BindUndertimeList();
    this.Close();
                MessageBox.Show("Undertime has been filed successfully","Undertime File", MessageBoxButtons.OK,MessageBoxIcon.Information);
   }
  }

  private void cmbRequestor_SelectedIndexChanged(object sender, EventArgs e)
  {
   try
   {
    cmbApprover.DataSource = clsDepartmentApprover.DdlDsByEmployee(cmbRequestor.SelectedValue.ToString(), EFormType.Undertime);
    cmbApprover.ValueMember = "pvalue";
    cmbApprover.DisplayMember = "ptext";
   }
   catch { }
  }

  private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
  {
   bool blnEnabled = cmbStatus.SelectedValue.ToString() != "F";
   dtpDateProcess.Enabled = blnEnabled;
   txtRemarks.Enabled = blnEnabled;
  }

        private void cmbApprover_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
