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
 public partial class frmLeaveEdit : Form
 {
  public frmLeaveEdit() { InitializeComponent(); }

  private string _strLeaveCode;
  private frmLeaveList _frmLeaveList;
  private string _strUsername;
  private string _strStatus;
  private string _strLeaveTypeCode;
 
  public string LeaveCode { set { _strLeaveCode = value; } get { return _strLeaveCode; } }
  public frmLeaveList FormLeaveList { set { _frmLeaveList = value; } get { return _frmLeaveList; } }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtReason.Text == "")
    strErrorMessage = "Reason is required.";

   if (LeaveApplicationTypes.IsHasBalance(_strLeaveTypeCode) && cmbStatus.SelectedValue.ToString() == "A" && _strStatus != "A")
   {
    if (clsValidator.CheckFloat(txtUnits.Text) > clsValidator.CheckFloat(txtBalance.Text))
     strErrorMessage += "\nNot enough leave balance.";
   }

   if (strErrorMessage != "")
   {
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }
  
  private void BindDetails()
  {
   using (LeaveApplication leave = new LeaveApplication(_strLeaveCode))
   {
    leave.Fill();
    txtLeaveCode.Text = _strLeaveCode;
    txtLeaveType.Text = LeaveApplicationTypes.GetDescription(leave.LeaveType);
    txtRequestor.Text = Employee.GetName(leave.Requestor);
    txtFiled.Text = leave.DateFile.ToString("MMM dd, yyyy");
    txtDateStart.Text = leave.DateStart.ToString("MMM dd, yyyy hh:mm tt");
    txtDateEnd.Text = leave.DateEnd.ToString("MMM dd, yyyy hh:mm tt");
    txtUnits.Text = leave.Units.ToString("####0.00");
    txtReason.Text = leave.Reason;
    txtApprover.Text = Employee.GetName(leave.Approver);
    dtpApproverDate.Value = leave.ApproverDate;
    dtpApproverTime.Value = leave.ApproverDate;
    txtApproverRemarks.Text = leave.ApproverRemarks;
    cmbStatus.SelectedValue = leave.Status;
    _strLeaveTypeCode = leave.LeaveType;
    _strUsername = leave.Requestor;
    _strStatus = leave.Status;
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmLeaveEdit_Load(object sender, EventArgs e)
  {
   cmbStatus.DataSource = LeaveApplication.DdlDsStatus();
   cmbStatus.ValueMember = "pvalue";
   cmbStatus.DisplayMember = "ptext";

   BindDetails();
   cmbLeaveType_SelectedIndexChanged(null, null);
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (LeaveApplication leave = new LeaveApplication())
    {
     leave.LeaveCode = txtLeaveCode.Text;
     leave.Fill();
     leave.Reason = txtReason.Text;
     leave.ApproverDate = clsDateTime.CombineDateTime(dtpApproverDate.Value, dtpApproverTime.Value);
     leave.Status = cmbStatus.SelectedValue.ToString();
     leave.UpdateAdmin();
     if (cmbStatus.SelectedValue.ToString() == "A" && _strStatus != "A" && LeaveApplicationTypes.IsHasBalance(_strLeaveTypeCode))
      LeaveApplicationBalance.DeductLeaveBalance(clsValidator.CheckFloat(txtUnits.Text), _strUsername, _strLeaveTypeCode);
     else if(cmbStatus.SelectedValue.ToString() != "A" && _strStatus == "A" && LeaveApplicationTypes.IsHasBalance(_strLeaveTypeCode))
      LeaveApplicationBalance.AddLeaveBalance(clsValidator.CheckFloat(txtUnits.Text), _strUsername, _strLeaveTypeCode);
    }
    _frmLeaveList.BindLeaveList();
    this.Close();
   }
  }

  private void cmbLeaveType_SelectedIndexChanged(object sender, EventArgs e)
  {
   try
   {
    if (LeaveApplicationTypes.GetHasBalance(_strLeaveTypeCode) == "1")
     txtBalance.Text = LeaveApplicationBalance.GetRemainingBalance(_strUsername, _strLeaveTypeCode).ToString();
    else
     txtBalance.Text = "NA";
   }
   catch { }
  }

 }
}
