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
 public partial class frmLeaveApplications : Form
 {
  private string _strUsername;
  private DateTime _dteFocusDate;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public DateTime FocusDate { set { _dteFocusDate = value; } get { return _dteFocusDate; } }

  public void LoadLeaveList()
  {
   lvwLeave.Items.Clear();
   DataTable tblLeave = HRMS.LeaveApplication.GetDSApplications(_dteFocusDate, _strUsername,cmbFilter.SelectedValue.ToString());
   foreach (DataRow drw in tblLeave.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drw["leavcode"].ToString();
    lvi.Tag = drw["leavcode"].ToString();
    lvwLeave.Items.Add(lvi);
   }

   if (lvwLeave.Items.Count > 0)
    lvwLeave.Items[0].Selected = true;
   else
    ClearFields();
  }

  private void ClearFields()
  {
   lblLeaveCode.Text = "";
   lblLeaveType.Text = "";
   lblRequestor.Text = "";
   lblDateFile.Text = "";
   lblDateStart.Text = "";
   lblDateEnd.Text = "";
   lblUnit.Text = "";
   lblReason.Text = "";
   lblApprover.Text = "";
   lblDate.Text = "";
   lblRemarks.Text = "";
   lblStatus.Text = "";
  }

  private void BindDetails(string pLeaveCode)
  {
   using (LeaveApplication leave = new LeaveApplication(pLeaveCode))
   {
    leave.Fill();
    lblLeaveCode.Text = pLeaveCode;
    lblLeaveType.Text = LeaveApplicationTypes.GetDescription(leave.LeaveType);
    lblRequestor.Text = Employee.GetName(leave.Requestor);
    lblDateFile.Text = leave.DateFile.ToString("MMM dd, yyyy");
    lblDateStart.Text = leave.DateStart.ToString("MMM dd, yyyy hh:mm tt");
    lblDateEnd.Text = leave.DateEnd.ToString("MMM dd, yyyy hh:mm tt");
    lblUnit.Text = leave.Units.ToString("####0.00");
    lblReason.Text = leave.Reason;
    lblApprover.Text = Employee.GetName(leave.Approver);
    lblDate.Text = leave.ApproverDate.ToString("MMM dd, yyyy");
    lblRemarks.Text = leave.ApproverRemarks;
    lblStatus.Text = LeaveApplication.ToLeaveStatusDesc(leave.Status);
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  public frmLeaveApplications()
  {
   InitializeComponent();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void frmLeaveApplications_Load(object sender, EventArgs e)
  {
   cmbFilter.DataSource = LeaveApplication.GetDSLApproveFilter();
   cmbFilter.ValueMember = "pvalue";
   cmbFilter.DisplayMember = "ptext";

   LoadLeaveList();
  }

  private void lvwLeave_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (lvwLeave.SelectedItems.Count > 0)
    BindDetails(lvwLeave.SelectedItems[0].Tag.ToString());
  }

  private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
  {
   LoadLeaveList();
  }

 }
}
