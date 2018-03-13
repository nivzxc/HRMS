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
 public partial class frmLeaveTypeEdit : Form
 {
  public frmLeaveTypeEdit() { InitializeComponent(); }

  private string _strStatus;
  private string _strLeaveTypeCode;
  private frmLeaveTypeList _frmLeaveTypeList;

  public string LeaveTypeCode { set { _strLeaveTypeCode = value; } get { return _strLeaveTypeCode; } }
  public frmLeaveTypeList FormLeaveTypeList { set { _frmLeaveTypeList = value; } get { return _frmLeaveTypeList; } }

  private void BindDetails()
  {
   txtCode.Text = _strLeaveTypeCode;
   using (LeaveApplicationTypes lt = new LeaveApplicationTypes())
   {
    lt.LeaveTypeCode = _strLeaveTypeCode;
    lt.Fill();
    txtLeaveType.Text = lt.LeaveType;
    chkWithPay.Checked = (lt.WithPay == "1" ? true : false);
    chkHasBalance.Checked = (lt.HasBalance == "1" ? true : false);
    txtMaxBalance.Text = lt.MaximumBalance.ToString();
    chkStatus.Checked = (lt.Status == "1" ? true : false);
    _strStatus = lt.Status;
   }
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

  private void frmLeaveTypeEdit_Load(object sender, EventArgs e)
  {
   BindDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    if (_strStatus == "1" && !chkStatus.Checked)
    {
     if (MessageBox.Show("You choose to set inactive this leave type.\nThis action will disable " + txtLeaveType.Text + " to all employee.\n\nDo you want to continue", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
     {
      using (LeaveApplicationTypes lt = new LeaveApplicationTypes())
      {
       lt.LeaveTypeCode = _strLeaveTypeCode;
       lt.LeaveType = txtLeaveType.Text;
       lt.WithPay = (chkWithPay.Checked ? "1" : "0");
       lt.HasBalance = (chkHasBalance.Checked ? "1" : "0");
       lt.MaximumBalance = clsValidator.CheckFloat(txtMaxBalance.Text);
       lt.Status = (chkStatus.Checked ? "1" : "0");
       lt.Update();
      }
      LeaveApplicationBalance.DisableRecords(_strLeaveTypeCode);
     }
    }
    else
    {
     using (LeaveApplicationTypes lt = new LeaveApplicationTypes())
     {
      lt.LeaveTypeCode = _strLeaveTypeCode;
      lt.LeaveType = txtLeaveType.Text;
      lt.WithPay = (chkWithPay.Checked ? "1" : "0");
      lt.HasBalance = (chkHasBalance.Checked ? "1" : "0");
      lt.MaximumBalance = clsValidator.CheckFloat(txtMaxBalance.Text);
      lt.Status = (chkStatus.Checked ? "1" : "0");
      lt.Update();
     }
    }
    _frmLeaveTypeList.BindLeaveTypeList();
    this.Close();
   }
  }

  private void chkHasBalance_CheckedChanged(object sender, EventArgs e)
  {
   txtMaxBalance.Enabled = chkHasBalance.Checked;
  }

 }
}
