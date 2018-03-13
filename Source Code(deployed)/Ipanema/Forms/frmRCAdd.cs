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
 public partial class frmRCAdd : Form
 {
  public frmRCAdd() { InitializeComponent(); }

  private frmRCList _frmRCList;

  public frmRCList FormCallerRCList { set { _frmRCList = value; } }

  private void InitializeFields()
  {
   //txtRCCode.Text = clsRC.GenerateCode();
   //txtRCName.Text = "";

   cmbDivision.DataSource = Division.GetDSL();
   cmbDivision.ValueMember = "pvalue";
   cmbDivision.DisplayMember = "ptext";

   cmbCompany.DataSource = clsCompany.GetDSL();
   cmbCompany.DisplayMember = "ptext";
   cmbCompany.ValueMember = "pvalue";

   chkActive.Checked = false;
   txtRCCode.Focus();
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtRCCode.Text == "")
       strErrorMessage = "RC code is required.";

   if (txtRCName.Text == "")
    strErrorMessage = "RC name is required.";

   if (txtGPCode.Text == "")
   {
       strErrorMessage = "GP code is required.";
   }
   else if(clsRC.IsRcCodeExist(txtRCCode.Text))
   {
       strErrorMessage = "Rc code is exist.";
   }

   if (strErrorMessage != "")
   {
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////
  
  private void btnSave_Click(object sender, EventArgs e)
  {
      if (IsCorrectData())
      {
          using (clsRC objclsRC = new clsRC())
          {
              objclsRC.RcCode = txtRCCode.Text;
              objclsRC.RcName = txtRCName.Text;
              objclsRC.DivisionCode = cmbDivision.SelectedValue.ToString();
              objclsRC.GPCode = txtGPCode.Text;
              objclsRC.CompanyCode = cmbCompany.SelectedValue.ToString();
              objclsRC.Status = chkActive.Checked == true ? "1" : "0";
              objclsRC.Insert();
          }

          _frmRCList.BindRCList();
          this.Close();
      }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void frmRCAdd_Load(object sender, EventArgs e)
  {
      InitializeFields();
  }

 }
}