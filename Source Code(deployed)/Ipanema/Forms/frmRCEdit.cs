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
    public partial class frmRCEdit : Form
    {
        private frmRCList _frmRCList;
        private string _strRccode;

        public frmRCList FormRCList { get { return _frmRCList; } set { _frmRCList = value; } }
        public string RCCode { get { return _strRccode; } set { _strRccode = value; } }

        public frmRCEdit()
        {
            InitializeComponent();
        }

        private void frmRCEdit_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadRCList();
        }

        private void LoadData()
        {
            cmbCompany.DataSource = clsCompany.GetDSL();
            cmbCompany.DisplayMember = "ptext";
            cmbCompany.ValueMember = "pvalue";

            cmbDivision.DataSource = Division.GetDSL();
            cmbDivision.DisplayMember = "ptext";
            cmbDivision.ValueMember = "pvalue";
        }

        private void LoadRCList()
        {
            clsRC objclsRc = new clsRC();
            objclsRc.RcCode = _strRccode;
            txtRCCode.Text = _strRccode;
            objclsRc.Fill();
            txtRCName.Text = objclsRc.RcName;
            cmbDivision.SelectedValue = objclsRc.DivisionCode;
            txtGPCode.Text = objclsRc.GPCode;
            cmbCompany.SelectedValue = objclsRc.CompanyCode;
            chkActive.Checked = objclsRc.Status == "1" ? true : false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsCorrectData())
            {
                using (clsRC objclSRC = new clsRC())
                {
                    objclSRC.RcCode = txtRCCode.Text;
                    objclSRC.RcName = txtRCName.Text;
                    objclSRC.DivisionCode = cmbDivision.SelectedValue.ToString();
                    objclSRC.GPCode = txtGPCode.Text;
                    objclSRC.CompanyCode = cmbCompany.SelectedValue.ToString();
                    objclSRC.Status = chkActive.Checked == true ? "1" : "0";
                    objclSRC.Update();
                }
                _frmRCList.BindRCList();
                this.Close();
            }
        }

        private bool IsCorrectData()
        {
            bool blnReturn = true;
            string strErrorMessage = "";

            if (txtRCCode.Text == "")
                strErrorMessage = "RC code is required.";

            if (txtRCName.Text == "")
                strErrorMessage = "RC name is required.";

            if (strErrorMessage != "")
            {
                MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                blnReturn = false;
            }

            return blnReturn;
        }

    }
}
