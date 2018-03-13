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
 public partial class frmLeaveNew : Form
 {
  private frmLeaveList _frmLeaveList;

  public frmLeaveList FormLeaveList { set { _frmLeaveList = value; } get { return _frmLeaveList; } }

  public frmLeaveNew() { InitializeComponent(); }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtReason.Text == "")
    strErrorMessage = "Reason is required.";

   if (LeaveApplicationTypes.IsHasBalance(cmbLeaveType.SelectedValue.ToString()))
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

  private void InitializeFields()
  {
   cmbRequestor.DataSource = Employee.DSLActive();
   cmbRequestor.ValueMember = "pvalue";
   cmbRequestor.DisplayMember = "ptext";

   cmbApprover.DataSource = clsDepartmentApprover.DdlDsByEmployee(cmbRequestor.SelectedValue.ToString(), EFormType.Leave);
   cmbApprover.ValueMember = "pvalue";
   cmbApprover.DisplayMember = "ptext";

   cmbStatus.DataSource = LeaveApplication.DdlDsStatus();
   cmbStatus.ValueMember = "pvalue";
   cmbStatus.DisplayMember = "ptext";

   cmbLeaveType.DataSource = LeaveApplicationTypes.DSLLeaveType();
   cmbLeaveType.ValueMember = "pvalue";
   cmbLeaveType.DisplayMember = "ptext";

   txtUnits.Text = "0";
   dtpDateFile.Value = DateTime.Now;
   dtpDateStart.Value = DateTime.Now;
   dtpDateStart_ValueChanged(null, null);
   dtpDateEnd.Value = DateTime.Now;
   dtpDateEnd_ValueChanged(null, null);
   txtReason.Text = "";
   dtpApproverDate.Value = DateTime.Now;
   dtpApproverTime.Value = DateTime.Now;
   txtARemarks.Text = "";

   cmbStatus.Focus();
  }

  private void ComputeUnits()
  {
   try { txtUnits.Text = LeaveApplication.GetLeaveUnits(dtpDateStart.Value, dtpDateEnd.Value, clsValidator.CheckFloat(cmbTimeFrom.SelectedValue.ToString()), clsValidator.CheckFloat(cmbTimeTo.SelectedValue.ToString()), cmbRequestor.SelectedValue.ToString()).ToString(); }
   catch { }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmLeaveNew_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void cmbRequestor_SelectedIndexChanged(object sender, EventArgs e)
  {
   try
   {
    cmbApprover.DataSource = clsDepartmentApprover.DdlDsByEmployee(cmbRequestor.SelectedValue.ToString(), EFormType.Leave);
    cmbApprover.ValueMember = "pvalue";
    cmbApprover.DisplayMember = "ptext";

    cmbLeaveType_SelectedIndexChanged(null, null);
    dtpDateStart_ValueChanged(null, null);
    dtpDateEnd_ValueChanged(null, null);
   }
   catch { }
  }

  private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
  {
   bool blnApproverWrite = (cmbStatus.SelectedValue.ToString() == "A" || cmbStatus.SelectedValue.ToString() == "D");
   dtpApproverDate.Enabled = blnApproverWrite;
   dtpApproverTime.Enabled = blnApproverWrite;
   txtARemarks.Enabled = blnApproverWrite;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    DateTime dteDateStart = clsDateTime.CombineDateTime(dtpDateStart.Value, cmbTimeFrom.Text);
    DateTime dteDateEnd = clsDateTime.CombineDateTime(dtpDateEnd.Value, cmbTimeTo.Text);
    if (!LeaveApplication.HasExistingApplication(cmbRequestor.SelectedValue.ToString(), dteDateStart, dteDateEnd))
    {
     LeaveApplication leave = new LeaveApplication();
     leave.LeaveType = cmbLeaveType.SelectedValue.ToString();
     leave.Requestor = cmbRequestor.SelectedValue.ToString();
     leave.DateFile = DateTime.Now;
     leave.DateStart = dteDateStart;
     leave.DateEnd = dteDateEnd;
     leave.Units = clsValidator.CheckFloat(txtUnits.Text);
     leave.Reason = txtReason.Text;
     leave.Approver = cmbApprover.SelectedValue.ToString();
     leave.ApproverDate = clsDateTime.CombineDateTime(dtpDateEnd.Value, dtpApproverTime.Value);
     leave.ApproverRemarks = txtARemarks.Text;
     leave.Status = cmbStatus.SelectedValue.ToString();
     leave.InsertAdmin();

     if (cmbStatus.SelectedValue.ToString() == "A" && LeaveApplicationTypes.IsHasBalance(cmbLeaveType.SelectedValue.ToString()))
      LeaveApplicationBalance.DeductLeaveBalance(clsValidator.CheckFloat(txtUnits.Text), cmbRequestor.SelectedValue.ToString(), cmbLeaveType.SelectedValue.ToString());

     _frmLeaveList.BindLeaveList();
     this.Close();
    }
    else
    {
     MessageBox.Show("There is already an existing leave application on specified dates.", clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

   }
  }

  private void btnBalance_Click(object sender, EventArgs e)
  {
   frmLeaveBalanceRemaining pForm = new frmLeaveBalanceRemaining();
   pForm.Username = cmbRequestor.SelectedValue.ToString();
   pForm.ShowDialog();
  }

  private void cmbLeaveType_SelectedIndexChanged(object sender, EventArgs e)
  {
   try 
   {
    if (LeaveApplicationTypes.GetHasBalance(cmbLeaveType.SelectedValue.ToString()) == "1")
     txtBalance.Text = LeaveApplicationBalance.GetRemainingBalance(cmbRequestor.SelectedValue.ToString(), cmbLeaveType.SelectedValue.ToString()).ToString();
    else
     txtBalance.Text = "NA";
   }
   catch { }
  }

  private void dtpDateStart_ValueChanged(object sender, EventArgs e)
  {
   DataTable tblTime = new DataTable();
   tblTime.Columns.Add("pvalue");
   tblTime.Columns.Add("ptext");
   DataRow drw;
   using (clsShift shift = new clsShift())
   {
    shift.ShiftCode = clsShift.GetDayShiftCode(cmbRequestor.SelectedValue.ToString(), dtpDateStart.Value);
    shift.Fill();
    drw = tblTime.NewRow();
    drw["pvalue"] = "0";
    drw["ptext"] = shift.TimeStart.ToString("hh:mm tt");
    tblTime.Rows.Add(drw);

    drw = tblTime.NewRow();
    drw["pvalue"] = ".5";
    drw["ptext"] = shift.TimeHalf.ToString("hh:mm tt");
    tblTime.Rows.Add(drw);
   }
   cmbTimeFrom.DataSource = tblTime;
   cmbTimeFrom.ValueMember = "pvalue";
   cmbTimeFrom.DisplayMember = "ptext";

   ComputeUnits();
  }

  private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
  {
   DataTable tblTime = new DataTable();
   tblTime.Columns.Add("pvalue");
   tblTime.Columns.Add("ptext");
   DataRow drw;
   using (clsShift shift = new clsShift())
   {
    shift.ShiftCode = clsShift.GetDayShiftCode(cmbRequestor.SelectedValue.ToString(), dtpDateEnd.Value);
    shift.Fill();
    drw = tblTime.NewRow();
    drw["pvalue"] = ".5";
    drw["ptext"] = shift.TimeHalf.ToString("hh:mm tt");
    tblTime.Rows.Add(drw);

    drw = tblTime.NewRow();
    drw["pvalue"] = "1";
    drw["ptext"] = shift.TimeEnd.ToString("hh:mm tt");
    tblTime.Rows.Add(drw);
   }
   cmbTimeTo.DataSource = tblTime;
   cmbTimeTo.ValueMember = "pvalue";
   cmbTimeTo.DisplayMember = "ptext";

   ComputeUnits();
  }

  private void cmbTimeFrom_SelectedIndexChanged(object sender, EventArgs e)
  {
   ComputeUnits();
  }

  private void cmbTimeTo_SelectedIndexChanged(object sender, EventArgs e)
  {
   ComputeUnits();
  }

 }
}