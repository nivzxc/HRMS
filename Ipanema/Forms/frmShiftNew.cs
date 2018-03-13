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
 public partial class frmShiftNew : Form
 {
  private FormCallers _FormCaller;
  private frmHolidayNew pfrmHolidayNew;
  private frmShiftList pfrmShiftList;

  public frmShiftNew(frmHolidayNew pHolidayNew)
  {
   InitializeComponent();
   pfrmHolidayNew = pHolidayNew;
  }

  public frmShiftNew(frmShiftList pShiftList)
  {
   InitializeComponent();
   pfrmShiftList = pShiftList;
  }

  public FormCallers FormCaller { get { return _FormCaller; } set { _FormCaller = value; } }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtShiftCode.Text == "" || txtShiftCode.Text.Length != 8)
    strErrorMessage += "\nShift code is required and should contain 8 characters.";
   else
   {
    if(clsShift.IsCodeExist(txtShiftCode.Text))
     strErrorMessage += "\nShift code already exist.";
   }

   if (txtTotalHours.Text == "")
    strErrorMessage += "\nTotal hours is required.";

   if (cmbShiftMode.SelectedValue.ToString() == "W")
   {
    if (dtpTimeStart.Value >= dtpTimeHalf.Value)
     strErrorMessage += "\nTime start should be less than time half.";

    if (dtpTimeHalf.Value >= dtpTimeEnd.Value)
     strErrorMessage += "\nTime half should be less than time end.";

    if ((dtpBreakStart.Value <= dtpTimeStart.Value) || (dtpBreakStart.Value >= dtpTimeEnd.Value))
     strErrorMessage += "\nBreak time start should be within the shift time.";

    if ((dtpBreakEnd.Value <= dtpTimeStart.Value) || (dtpBreakEnd.Value >= dtpTimeEnd.Value))
     strErrorMessage += "\nBreak time end should be within the shift time.";
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
   cmbShiftMode.DataSource = clsShiftMode.GetDdlDs();
   cmbShiftMode.ValueMember = "pvalue";   
   cmbShiftMode.DisplayMember = "ptext";
   txtShiftCode.Focus();
  }

  ///////// Form Events /////////
  
  private void frmShiftNew_Load(object sender, EventArgs e)
  {
   ClearFields();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (clsShift shift = new clsShift())
    {
     shift.ShiftCode = txtShiftCode.Text;
     shift.ShiftModeCode = cmbShiftMode.SelectedValue.ToString();
     shift.TimeStart = dtpTimeStart.Value;
     shift.TimeHalf = dtpTimeHalf.Value;
     shift.TimeEnd = dtpTimeEnd.Value;
     shift.BreakTimeStart = dtpBreakStart.Value;
     shift.BreakTimeEnd = dtpBreakEnd.Value;
     shift.LateTime = dtpLate.Value;
     shift.UnderTime = dtpUndertime.Value;
     shift.TotalWorkHours = float.Parse(txtTotalHours.Text);
     shift.Remarks = txtRemarks.Text;
     shift.Insert();
    }

    switch(_FormCaller)
    {
     case FormCallers.ShiftList:
      pfrmShiftList.BindShiftList();
      break;
     case FormCallers.HolidayNew:
      pfrmHolidayNew.BindShiftList();
      break;
    }
    Close();
   }
  }

  private void btnGenerateCode_Click(object sender, EventArgs e)
  {
   txtShiftCode.Text = dtpTimeStart.Value.ToString("HHmm") + dtpTimeEnd.Value.ToString("HHmm");
  }

  private void btnCheck_Click(object sender, EventArgs e)
  {
   if (txtShiftCode.Text != "")
   {
    if (clsShift.IsCodeExist(txtShiftCode.Text))
     MessageBox.Show("Code: " + txtShiftCode.Text + " already exist", "Validator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    else
     MessageBox.Show("Code: " + txtShiftCode.Text + " is available", "Validator", MessageBoxButtons.OK, MessageBoxIcon.Information);
   }
   else
   {
    MessageBox.Show("Shift code is requied", "Validator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   }
  }

  private void cmbShiftMode_SelectedIndexChanged(object sender, EventArgs e)
  {
   bool blnWorking = (cmbShiftMode.SelectedValue.ToString() == "W" ? true : false);

   dtpTimeStart.Enabled = blnWorking;
   dtpTimeHalf.Enabled = blnWorking;
   dtpTimeEnd.Enabled = blnWorking;
   dtpLate.Enabled = blnWorking;
   dtpUndertime.Enabled = blnWorking;
  }

 }
}
