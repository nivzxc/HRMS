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
 public partial class frmLeaveTypeNew : Form
 {
  private frmLeaveTypeList _frmLeaveTypeList;

  public frmLeaveTypeList FormLeaveTypeList { set { _frmLeaveTypeList = value; } get { return _frmLeaveTypeList; } }

  public frmLeaveTypeNew()
  {
   InitializeComponent();
  }

  private void ClearFields()
  {
   txtCode.Text = LeaveApplicationTypes.GenerateCode();
   txtLeaveType.Text = "";
   chkWithPay.Checked = false;
   chkHasBalance.Checked = false;
   txtMaxBalance.Text = "";

   txtLeaveType.Focus();
  }

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtLeaveType.Text == "")
    strErrorMessage += "\nLeave type field is required.";

   if (strErrorMessage != "")
   {
    blnReturn = false;
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   }

   return blnReturn;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmLeaveTypeNew_Load(object sender, EventArgs e)
  {
   ClearFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intAffected = 0;
    using (LeaveApplicationTypes lt = new LeaveApplicationTypes())
    {
     lt.LeaveType = txtLeaveType.Text;
     lt.WithPay = (chkWithPay.Checked ? "1" : "0");
     lt.HasBalance = (chkHasBalance.Checked ? "1" : "0");
     lt.MaximumBalance = (chkHasBalance.Checked ? clsValidator.CheckFloat(txtMaxBalance.Text) : 0);
     intAffected = lt.Insert();
    }
    if (intAffected > 0)
    {
     _frmLeaveTypeList.BindLeaveTypeList();
     if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      ClearFields();
     else
      this.Close();
    }
   }
  }

  private void chkHasBalance_CheckedChanged(object sender, EventArgs e)
  {
   txtMaxBalance.Enabled = chkHasBalance.Checked;
  }

 }
}
