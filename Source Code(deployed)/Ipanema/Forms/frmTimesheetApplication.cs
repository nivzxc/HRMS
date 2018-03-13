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
 public partial class frmTimesheetApplication : Form
 {
  public frmTimesheetApplication() { InitializeComponent(); }

  private string _strUsername;
  private DateTime _dteFocusDate;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public DateTime FocusDate { set { _dteFocusDate = value; } get { return _dteFocusDate; } }

  private void BindTimeCardList()
  {
   lvTimeCardList.Items.Clear();
   DataTable tblTimeCardList = clsTimeCardACM.DSGTimeCardList(_dteFocusDate, _dteFocusDate, _strUsername);
   foreach (DataRow drw in tblTimeCardList.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = clsValidator.CheckDate(drw["tdate"].ToString()).ToString("MMMM dd, yyyy");
    lvi.SubItems.Add(clsValidator.CheckDate(drw["ttime"].ToString()).ToString("hh:mm tt"));
    lvi.SubItems.Add(drw["action"].ToString());
    lvi.BackColor = (drw["action"].ToString() == "In" ? Color.Honeydew : Color.MistyRose);
    lvTimeCardList.Items.Add(lvi);
   }

   tbpTimeCard.Text = "Time Card (" + lvTimeCardList.Items.Count.ToString() + ")";
  }

  #region Leave Applications

  public void LoadLeaveList()
  {
   lvwLeave.Items.Clear();
   DataTable tblLeave = LeaveApplication.GetDSApplications(_dteFocusDate, _strUsername, cmbLeave.SelectedValue.ToString());
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
    LeaveClearFields();

   tbpLeave.Text = "Leave (" + lvwLeave.Items.Count.ToString() + ")";
  }

  private void LeaveClearFields()
  {
   lblLeaveCode.Text = "";
   lblLeaveType.Text = "";
   lblLeaveRequestor.Text = "";
   lblLeaveDateFile.Text = "";
   lblLeaveStart.Text = "";
   lblLeaveEnd.Text = "";
   lblLeaveUnit.Text = "";
   lblOBReason.Text = "";
   lblLeaveAName.Text = "";
   lblLeaveADate.Text = "";
   lblLeaveARemarks.Text = "";
   lblLeaveStatus.Text = "";
  }

  private void BindLeaveDetails(string pLeaveCode)
  {
   using (LeaveApplication leave = new LeaveApplication(pLeaveCode))
   {
    leave.Fill();
    lblLeaveCode.Text = pLeaveCode;
    lblLeaveType.Text = LeaveApplicationTypes.GetDescription(leave.LeaveType);
    lblLeaveRequestor.Text = Employee.GetName(leave.Requestor);
    lblLeaveDateFile.Text = leave.DateFile.ToString("MMM dd, yyyy hh:mm tt");
    lblLeaveStart.Text = leave.DateStart.ToString("MMM dd, yyyy hh:mm tt");
    lblLeaveEnd.Text = leave.DateEnd.ToString("MMM dd, yyyy hh:mm tt");
    lblLeaveUnit.Text = leave.Units.ToString("####0.00");
    lblLeaveReason.Text = leave.Reason;
    lblLeaveAName.Text = Employee.GetName(leave.Approver);
    lblLeaveADate.Text = leave.ApproverDate.ToString("MMM dd, yyyy");
    lblLeaveARemarks.Text = leave.ApproverRemarks;
    lblLeaveStatus.Text = LeaveApplication.ToLeaveStatusDesc(leave.Status);
   }
  }

#endregion

  #region Undertime Applications

  public void LoadUndertimeList()
  {
   lvwUndertime.Items.Clear();
   DataTable tblUndertime = clsUndertime.Applications(_dteFocusDate, _strUsername, cmbUndertime.SelectedValue.ToString());
   foreach (DataRow drw in tblUndertime.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drw["utcode"].ToString();
    lvi.Tag = drw["utcode"].ToString();
    lvwUndertime.Items.Add(lvi);
   }

   if (lvwUndertime.Items.Count > 0)
    lvwUndertime.Items[0].Selected = true;
   else
    UndertimeClearFields();

   tbpUndertime.Text = "Undertime (" + lvwUndertime.Items.Count.ToString() + ")";
  }

  private void UndertimeClearFields()
  {
   lblUTCode.Text = "";
   lblUTRequestor.Text = "";
   lblUTDateFile.Text = "";
   lblUTApplication.Text = "";
   lblUTReason.Text = "";
   lblUTAName.Text = "";
   lblUTADate.Text = "";
   lblUTARemarks.Text = "";
   lblUTStatus.Text = "";
  }

  private void BindUndertimeDetails(string pUTCode)
  {
   using (clsUndertime ut = new clsUndertime(pUTCode))
   {
    ut.Fill();
    lblUTCode.Text = pUTCode;
    lblUTRequestor.Text = Employee.GetName(ut.Username);
    lblUTDateFile.Text = ut.DateFiled.ToString("MMM dd, yyyy hh:mm tt");
    lblUTApplication.Text = ut.DateApplied.ToString("MMM dd, yyyy hh:mm tt");
    lblUTReason.Text = ut.Reason;
    lblUTAName.Text = Employee.GetName(ut.ApproverUsername);
    lblUTADate.Text = ut.ApproverDate.ToString("MMM dd, yyyy");
    lblUTARemarks.Text = ut.ApproverRemarks;
    lblUTStatus.Text = clsUndertime.ToUndertimeStatusText(ut.Status);
   }
  }
  #endregion

  #region OB Applications

  public void LoadOBList()
  {
   lvwOB.Items.Clear();
   DataTable tblOB = OfficialBusiness.GetDSGApplications(_dteFocusDate, _strUsername, cmbOB.SelectedValue.ToString());
   foreach (DataRow drw in tblOB.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drw["obcode"].ToString();
    lvi.Tag = drw["obcode"].ToString();
    lvwOB.Items.Add(lvi);
   }
   if (lvwOB.Items.Count > 0)
    lvwOB.Items[0].Selected = true;
   else
    OBClearFields();

   tbpOB.Text = "OB (" + lvwOB.Items.Count.ToString() + ")";
  }

  private void OBClearFields()
  {
   lblOBCode.Text = "";
   lblOBType.Text = "";
   lblOBDepartment.Text = "";
   lblOBRequestor.Text = "";
   lblOBDateFile.Text = "";
   lblOBReason.Text = "";
   lblOBRApprover.Text = "";
   lblOBRDate.Text = "";
   lblOBRRemarks.Text = "";
   lblOBHApprover.Text = "";
   lblOBHDate.Text = "";
   lblOBHRemarks.Text = "";
   lblOBStatus.Text = "";
   lvOBDetails.Items.Clear();
  }

  private void BindOBDetails(string pObCode)
  {
   using (OfficialBusiness ob = new OfficialBusiness(pObCode))
   {
    ob.Fill();
    lblOBCode.Text = pObCode;
    lblOBType.Text = OfficialBusiness.GetOBTypeDesc(ob.OBType);
    lblOBDepartment.Text = Department.GetName(ob.DepartmentCode);
    lblOBRequestor.Text = Employee.GetName(ob.UserName);
    lblOBDateFile.Text = ob.DateFile.ToString("MMM dd, yyyy hh:mm tt");
    lblOBReason.Text = ob.Reason;
    lblOBRApprover.Text = (ob.OBType == "1" ? Employee.GetName(ob.RAName) : "NA");
    lblOBRDate.Text = (ob.OBType == "1" ? ob.RADate.ToString("MM-dd-yyyy") : "NA");
    lblOBRRemarks.Text = (ob.OBType == "1" ? ob.RARemarks : "NA");
    lblOBHApprover.Text = Employee.GetName(ob.HAName);
    lblOBHDate.Text = ob.HADate.ToString("MM-dd-yyyy");
    lblOBHRemarks.Text = ob.HARemarks;
    lblOBStatus.Text = LeaveApplication.ToLeaveStatusDesc(ob.Status);
   }

   lvOBDetails.Items.Clear();
   DataTable tblOBDetails = OfficialBusinessDetails.DataTableByOBCode(pObCode);
   foreach (DataRow drw in tblOBDetails.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = clsValidator.CheckDate(drw["focsdate"].ToString()).ToString("MMM dd, yyyy");
    lvi.SubItems.Add(clsValidator.CheckDate(drw["keyin"].ToString()).ToString("MMM dd, yyyy hh:mm tt"));
    lvi.SubItems.Add(clsValidator.CheckDate(drw["keyout"].ToString()).ToString("MMM dd, yyyy hh:mm tt"));

    lvOBDetails.Items.Add(lvi);
   }
  }

  #endregion

  #region Overtime Applications

  public void LoadOvertimeList()
  {
   lvwOT.Items.Clear();
   DataTable tblOT = clsOvertime.Applications(_dteFocusDate, _strUsername, cmbOvertime.SelectedValue.ToString());
   foreach (DataRow drw in tblOT.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drw["otcode"].ToString();
    lvi.Tag = drw["otcode"].ToString();
    lvwOT.Items.Add(lvi);
   }
   if (lvwOT.Items.Count > 0)
    lvwOT.Items[0].Selected = true;
   else
    OvertimeClearFields();

   tbpOvertime.Text = "Overtime (" + lvwOT.Items.Count.ToString() + ")";
  }

  private void OvertimeClearFields()
  {
   lblOTCode.Text = "";
   lblOTDepartment.Text = "";
   lblOTChargeType.Text = "";
   lblOTDepartment.Text = "";
   lblOTRequestor.Text = "";
   lblOTDateFile.Text = "";
   lblOTStart.Text = "";
   lblOTEnd.Text = "";
   lblOTReason.Text = "";
   lblOTRAName.Text = "";
   lblOTRADate.Text = "";
   lblOTRARemaks.Text = "";
   lblOTHAName.Text = "";
   lblOTHADate.Text = "";
   lblOTHARemarks.Text = "";
   lblOTStatus.Text = "";
  }

  private void BindOvertimeDetails(string pOTCode)
  {
   using (clsOvertime ot = new clsOvertime(pOTCode))
   {
    ot.Fill();
    lblOTCode.Text = pOTCode;
    lblOTDepartment.Text = (ot.ChargeType == "0" ? "Charge within the department" : Department.GetName(ot.DepartmentCode));
    lblOTChargeType.Text = clsOvertime.GetChargeTypeDesc(ot.ChargeType);
    lblOTDepartment.Text = Department.GetName(ot.DepartmentCode);
    lblOTRequestor.Text = Employee.GetName(ot.Username);
    lblOTDateFile.Text = ot.DateFile.ToString("MMM dd, yyyy hh:mm tt");
    lblOTStart.Text = ot.DateStart.ToString("ddd MMM dd, yyyy hh:mm tt");
    lblOTEnd.Text = ot.DateEnd.ToString("ddd MMM dd, yyyy hh:mm tt");
    lblOTReason.Text = ot.Reason;
    lblOTRAName.Text = (ot.ChargeType == "1" ? Employee.GetName(ot.RequestorApproverName) : "NA");
    lblOTRADate.Text = (ot.ChargeType == "1" ? ot.RequestorApproverDate.ToString("MM-dd-yyyy") : "NA");
    lblOTRARemaks.Text = (ot.ChargeType == "1" ? ot.RequestorApproverRemarks : "NA");
    lblOTHAName.Text = Employee.GetName(ot.HeadApproverName);
    lblOTHADate.Text = ot.HeadApproverDate.ToString("MM-dd-yyyy");
    lblOTHARemarks.Text = ot.HeadApproverRemarks;
    lblOTStatus.Text = clsOvertime.ToStatusDesc(ot.Status);
   }
  }

  #endregion

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmTimesheetApplication_Load(object sender, EventArgs e)
  {
   // Initialize Time Card Details
   BindTimeCardList();

   // Initialize Leave Tab
   cmbLeave.DataSource = LeaveApplication.GetDSLApproveFilter();
   cmbLeave.ValueMember = "pvalue";
   cmbLeave.DisplayMember = "ptext";
   LoadLeaveList();

   // Initialize Undertime Tab
   cmbUndertime.DataSource = clsUndertime.DdlDsApproveFilter();
   cmbUndertime.ValueMember = "pvalue";
   cmbUndertime.DisplayMember = "ptext";
   LoadUndertimeList();

   // Initialize OB Tab
   cmbOB.DataSource = OfficialBusiness.DdlDsApproveFilter();
   cmbOB.ValueMember = "pvalue";
   cmbOB.DisplayMember = "ptext";
   LoadOBList();

   // Initialize Overtime Tab
   cmbOvertime.DataSource = clsOvertime.DdlDsApproveFilter();
   cmbOvertime.ValueMember = "pvalue";
   cmbOvertime.DisplayMember = "ptext";
   LoadOvertimeList();
  }

  private void cmbLeave_SelectedIndexChanged(object sender, EventArgs e)
  {
   LoadLeaveList();
  }

  private void lvwLeave_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (lvwLeave.SelectedItems.Count > 0)
    BindLeaveDetails(lvwLeave.SelectedItems[0].Tag.ToString());
  }

  private void cmbUndertime_SelectedIndexChanged(object sender, EventArgs e)
  {
   LoadUndertimeList();
  }

  private void lvwUndertime_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (lvwUndertime.SelectedItems.Count > 0)
    BindUndertimeDetails(lvwUndertime.SelectedItems[0].Tag.ToString());
  }

  private void cmbOB_SelectedIndexChanged(object sender, EventArgs e)
  {
   LoadOBList();
  }

  private void lvwOB_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (lvwOB.SelectedItems.Count > 0)
    BindOBDetails(lvwOB.SelectedItems[0].Tag.ToString());
  }

  private void cmbOvertime_SelectedIndexChanged(object sender, EventArgs e)
  {
   LoadOvertimeList();
  }

  private void lvwOT_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (lvwOT.SelectedItems.Count > 0)
    BindOvertimeDetails(lvwOT.SelectedItems[0].Tag.ToString());
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}