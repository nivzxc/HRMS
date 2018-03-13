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
 public partial class frmLeaveDetails : Form
 {
  private string _strLeaveCode;
  private frmLeaveList _frmLeaveList;

  public string LeaveCode { set { _strLeaveCode = value; } get { return _strLeaveCode; } }
  public frmLeaveList FormLeaveList { set { _frmLeaveList = value; } get { return _frmLeaveList; } }

  public frmLeaveDetails()
  {
   InitializeComponent();
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
    txtStart.Text = leave.DateStart.ToString("MMM dd, yyyy hh:mm tt");
    txtEnd.Text = leave.DateEnd.ToString("MMM dd, yyyy hh:mm tt");
    txtUnits.Text = leave.Units.ToString("####0.00");
    txtReason.Text = leave.Reason;
    txtApprover.Text = Employee.GetName(leave.Approver);
    txtDateProcessed.Text = leave.ApproverDate.ToString("MMM dd, yyyy");
    txtApproverRemarks.Text = leave.ApproverRemarks;
    txtStatus.Text = LeaveApplication.ToLeaveStatusDesc(leave.Status);
   }
  }

  ///////// Form Events /////////

  private void frmLeaveDetails_Load(object sender, EventArgs e)
  {
   BindDetails();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}
