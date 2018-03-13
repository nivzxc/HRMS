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
 public partial class frmJobGradeAdd : Form
 {
  private FormCallers _FormCaller;
  private frmJobGradeList _frmJobGradeList;

  public frmJobGradeAdd(frmJobGradeList pfrmJobGradeList)
  {
   _frmJobGradeList = pfrmJobGradeList;
   InitializeComponent();   
  }

  public FormCallers FormCaller { get { return _FormCaller; } set { _FormCaller = value; } }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtJGCode.Text == "")
   {
    strErrorMessage += "\nJob grade code is required.";
   }
   else
   {
    if (JobGrade.IsCodeExist(txtJGCode.Text))
     strErrorMessage += "\nJob grade code already exist.";
   }

   if (strErrorMessage != "")
   {
    MessageBox.Show("Data entry error:" + strErrorMessage, "HRMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }

  private void ClearFields()
  {
   txtJGCode.Text = "";
   txtDescription.Text = "";
   txtLevel.Text = "";
   chkDeductLate.Checked = false;
   chkDeductUndertime.Checked = false;
   chkPayOvertime.Checked = false;
   txtPlantillaCountHQ.Text = "0";
   txtPlantillaCountBillable.Text = "0";
   txtJGCode.Focus();
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmJobGradeAdd_Load(object sender, EventArgs e)
  {
   ClearFields();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (JobGrade jobgrade = new JobGrade())
    {
     jobgrade.JGCode = txtJGCode.Text;
     jobgrade.JGDescription = txtDescription.Text;
     jobgrade.JGOrder = clsValidator.CheckInteger(txtLevel.Text);
     jobgrade.DeductLate = (chkDeductLate.Checked ? "1" : "0");
     jobgrade.DeductUnderTime = (chkDeductUndertime.Checked ? "1" : "0");
     jobgrade.PayOverTime = (chkPayOvertime.Checked ? "1" : "0");
     jobgrade.PlantillaCountHQ = clsValidator.CheckInteger(txtPlantillaCountHQ.Text);
     jobgrade.PlantillaCountBillable = clsValidator.CheckInteger(txtPlantillaCountBillable.Text);
     jobgrade.Insert();
    }

    switch (_FormCaller)
    {
     case FormCallers.JobGradeList:
      _frmJobGradeList.BindJobGradeList();
      break;
    }

    if (MessageBox.Show("Your record was successfully added.\n\nWould you like to add another record?", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
     ClearFields();
    else
     this.Close();
   }
  }

 }
}
