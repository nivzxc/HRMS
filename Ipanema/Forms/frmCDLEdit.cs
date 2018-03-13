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
 public partial class frmCDLEdit : Form
 {
  public frmCDLEdit() { InitializeComponent(); }

  private string _strCDLCode;
  private frmCDLList _frmCDLList;

  public string CDLCode { set { _strCDLCode = value; } get { return _strCDLCode; } }
  public frmCDLList FormCDLList { set { _frmCDLList = value; } get { return _frmCDLList; } }

  private void BindDetails()
  {
   lblCDLCode.Text = _strCDLCode;
   using (CDL objCDL = new CDL())
   {
    objCDL.CDLCode = _strCDLCode;
    objCDL.Fill();
    dtpDateApplied.Value = objCDL.DateApplied;
    txtReason.Text = objCDL.Reason;
    lblCreatedBy.Text = objCDL.CreatedBy;
    lblDateCreated.Text = objCDL.CreatedOn.ToString("MMM dd, yyyy");
    lblModifiedBy.Text = objCDL.ModifiedBy;
    lblDateModified.Text = objCDL.ModifiedOn.ToString("MMM dd, yyyy");
   }
  }

  private void BindList()
  {
   DataTable tblIncluded = CDL.GetDSIncludedEmployee(_strCDLCode);
   lvIncluded.Items.Clear();
   foreach (DataRow drw in tblIncluded.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Tag = drw["username"].ToString();
    lvi.Text = drw["lastname"].ToString() + ", " + drw["firname"].ToString();
    lvIncluded.Items.Add(lvi);
   }

   DataTable tblExclude = CDL.GetDSExcludedEmployee(_strCDLCode);
   lvExcluded.Items.Clear();
   foreach (DataRow drw in tblExclude.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Tag = drw["username"].ToString();
    lvi.Text = drw["lastname"].ToString() + ", " + drw["firname"].ToString();
    lvi.SubItems.Add(LeaveApplicationBalance.GetRemainingBalance(drw["username"].ToString(), cmbLeaveType.SelectedValue.ToString()).ToString());
    lvExcluded.Items.Add(lvi);
   }
  }

  /////////////////////////////
  //////// Form Events ////////
  /////////////////////////////

  private void frmCDLEdit_Load(object sender, EventArgs e)
  {
   cmbLeaveType.DataSource = LeaveApplicationTypes.DSLLeaveType();

   this.BindDetails();
   this.BindList();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   using (CDL objCDL = new CDL())
   {
    objCDL.CDLCode = _strCDLCode;
    objCDL.Fill();
    objCDL.Reason = txtReason.Text;
    objCDL.Update();
   }
   _frmCDLList.LoadCDLList();
   this.Close();
  }

  private void cmbLeaveType_SelectedIndexChanged(object sender, EventArgs e)
  {
   try
   {
    DataTable tblExclude = CDL.GetDSExcludedEmployee(_strCDLCode);
    lvExcluded.Items.Clear();
    foreach (DataRow drw in tblExclude.Rows)
    {
     ListViewItem lvi = new ListViewItem();
     lvi.Tag = drw["username"].ToString();
     lvi.Text = drw["lastname"].ToString() + ", " + drw["firname"].ToString();
     lvi.SubItems.Add(LeaveApplicationBalance.GetRemainingBalance(drw["username"].ToString(), cmbLeaveType.SelectedValue.ToString()).ToString());
     lvExcluded.Items.Add(lvi);
    }
   }
   catch { }
  }

  private void btnInclude_Click(object sender, EventArgs e)
  {
   if (lvExcluded.SelectedItems.Count > 0)
   {
    bool blnInsertLeave = false;
    bool blnHasBalance = LeaveApplicationTypes.IsHasBalance(cmbLeaveType.SelectedValue.ToString());
    string strLeaveCode = "";
    string strUsername = lvExcluded.SelectedItems[0].Tag.ToString();
    DateTime dteDateStart = DateTime.Now;
    DateTime dteDateEnd = DateTime.Now;

    using (clsShift shift = new clsShift())
    {
     shift.ShiftCode = clsShift.GetDayShiftCode(strUsername, clsDateTime.GetDateOnly(dtpDateApplied.Value));
     shift.Fill();
     dteDateStart = clsDateTime.CombineDateTime(dtpDateApplied.Value, shift.TimeStart);
     dteDateEnd = clsDateTime.CombineDateTime(dtpDateApplied.Value, shift.TimeEnd);
    }

    if ((clsValidator.CheckFloat(lvExcluded.SelectedItems[0].SubItems[1].Text) >= 1) || (!blnHasBalance))
    {
     using (LeaveApplication leave = new LeaveApplication())
     {
      leave.LeaveType = cmbLeaveType.SelectedValue.ToString();
      leave.Requestor = strUsername;
      leave.DateFile = DateTime.Now;
      leave.DateStart = dteDateStart;
      leave.DateEnd = dteDateEnd;
      leave.Units = 1;
      leave.Reason = txtReason.Text;
      leave.Approver = HRMSCore.Username;
      leave.ApproverDate = DateTime.Now;
      leave.ApproverRemarks = "CDL Application. Auto-generated";
      leave.Status = "A";
      blnInsertLeave = leave.InsertAdmin();
      strLeaveCode = leave.LeaveCode;
     }
     if (blnHasBalance && blnInsertLeave)
      LeaveApplicationBalance.DeductLeaveBalance(1, strUsername, cmbLeaveType.SelectedValue.ToString());

     if (blnInsertLeave)
     {
      CDL.InsertMember(_strCDLCode, strUsername, strLeaveCode);
      this.BindList();
     }
    }
    else
    {
     MessageBox.Show(lvExcluded.SelectedItems[0].Tag.ToString() + " has not enough balance.", clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
   }

  }

  private void btnExclude_Click(object sender, EventArgs e)
  {
   if (lvIncluded.SelectedItems.Count > 0)
   {
    bool blnCancelLeave = false;
    bool blnHasBalance = false;
    string strLeaveTypeCode = "";
    string strUsername = lvIncluded.SelectedItems[0].Tag.ToString();
    string strLeaveCode = CDL.GetLeaveCode(strUsername, _strCDLCode);

    using (LeaveApplication leave = new LeaveApplication())
    {
     leave.LeaveCode = strLeaveCode;
     leave.Fill();
     strLeaveTypeCode = leave.LeaveType;
     leave.Status = "C";
     blnCancelLeave = leave.UpdateAdmin() > 0;
    }
    blnHasBalance = LeaveApplicationTypes.IsHasBalance(strLeaveTypeCode);
    if (blnHasBalance && blnCancelLeave)
     LeaveApplicationBalance.AddLeaveBalance(1, strUsername, strLeaveTypeCode);

    if (blnCancelLeave)
    {
     CDL.RemoveMember(_strCDLCode, strUsername);
     this.BindList();
    }
   }
  }

  private void btnIncludeAll_Click(object sender, EventArgs e)
  {
   foreach (ListViewItem itm in lvExcluded.Items)
   {
    bool blnInsertLeave = false;
    bool blnHasBalance = LeaveApplicationTypes.IsHasBalance(cmbLeaveType.SelectedValue.ToString());
    string strLeaveCode = "";
    string strUsername = itm.Tag.ToString();
    DateTime dteDateStart = DateTime.Now;
    DateTime dteDateEnd = DateTime.Now;

    using (clsShift shift = new clsShift())
    {
     shift.ShiftCode = clsShift.GetDayShiftCode(strUsername, clsDateTime.GetDateOnly(dtpDateApplied.Value));
     shift.Fill();
     dteDateStart = clsDateTime.CombineDateTime(dtpDateApplied.Value, shift.TimeStart);
     dteDateEnd = clsDateTime.CombineDateTime(dtpDateApplied.Value, shift.TimeEnd);
    }

    if ((clsValidator.CheckFloat(itm.SubItems[1].Text) >= 1) || (!blnHasBalance))
    {
     using (LeaveApplication leave = new LeaveApplication())
     {
      leave.LeaveType = cmbLeaveType.SelectedValue.ToString();
      leave.Requestor = strUsername;
      leave.DateFile = DateTime.Now;
      leave.DateStart = dteDateStart;
      leave.DateEnd = dteDateEnd;
      leave.Units = 1;
      leave.Reason = txtReason.Text;
      leave.Approver = HRMSCore.Username;
      leave.ApproverDate = DateTime.Now;
      leave.ApproverRemarks = "CDL Application. Auto-generated";
      leave.Status = "A";
      blnInsertLeave = leave.InsertAdmin();
      strLeaveCode = leave.LeaveCode;
     }
     if (blnHasBalance && blnInsertLeave)
      LeaveApplicationBalance.DeductLeaveBalance(1, strUsername, cmbLeaveType.SelectedValue.ToString());

     if (blnInsertLeave)
     {
      CDL.InsertMember(_strCDLCode, strUsername, strLeaveCode);
     }
    }
   }
   this.BindList();
  }

  private void btnExcludeAll_Click(object sender, EventArgs e)
  {
   foreach (ListViewItem itm in lvIncluded.Items)
   {
    bool blnCancelLeave = false;
    bool blnHasBalance = false;
    string strLeaveTypeCode = "";
    string strUsername = itm.Tag.ToString();
    string strLeaveCode = CDL.GetLeaveCode(strUsername, _strCDLCode);

    using (LeaveApplication leave = new LeaveApplication())
    {
     leave.LeaveCode = strLeaveCode;
     leave.Fill();
     strLeaveTypeCode = leave.LeaveType;
     leave.Status = "C";
     blnCancelLeave = leave.UpdateAdmin() > 0;
    }
    blnHasBalance = LeaveApplicationTypes.IsHasBalance(strLeaveTypeCode);

    if (blnHasBalance && blnCancelLeave)
     LeaveApplicationBalance.AddLeaveBalance(1, strUsername, strLeaveTypeCode);

    if (blnCancelLeave)
    {
     CDL.RemoveMember(_strCDLCode, strUsername);
    }
   }
   this.BindList();
  }

 }
}