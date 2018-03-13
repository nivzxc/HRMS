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
 public partial class frmShiftModify : Form
 {

  private string strShiftCode;
  private frmShiftList pfrmShiftList;

  public string ShiftCode { get { return strShiftCode; } set { strShiftCode = value; } }

  public frmShiftModify(frmShiftList pShiftList)
  {
   InitializeComponent();
   pfrmShiftList = pShiftList;
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtShiftCode.Text == "" || txtShiftCode.Text.Length != 8)
    strErrorMessage += "\nShift code is required and should contain 8 characters.";

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

  private void BindFields()
  {
   cmbShiftMode.DataSource = clsShiftMode.GetDdlDs();
   cmbShiftMode.ValueMember = "pvalue";
   cmbShiftMode.DisplayMember = "ptext";

   using (clsShift shift = new clsShift(strShiftCode))
   {
    shift.Fill();
    txtShiftCode.Text = strShiftCode;
    cmbShiftMode.SelectedValue = shift.ShiftModeCode;
    dtpTimeStart.Value = shift.TimeStart;
    dtpTimeHalf.Value = shift.TimeHalf;
    dtpTimeEnd.Value = shift.TimeEnd;
    dtpBreakStart.Value = shift.BreakTimeStart;
    dtpBreakEnd.Value = shift.BreakTimeEnd;
    dtpLate.Value = shift.LateTime;
    dtpUndertime.Value = shift.UnderTime;
    txtTotalHours.Text = shift.TotalWorkHours.ToString();
    txtRemarks.Text = shift.Remarks;
   }
   txtShiftCode.Focus();
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmShiftModify_Load(object sender, EventArgs e)
  {   
   BindFields();
  }

  private void btnClose_Click(object sender, EventArgs e) 
  { 
   this.Close(); 
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    if (MessageBox.Show("Warning: \nModifying shift settings might cause discrepancies on employee's schedule associated with it. \nIt is advisable to create a new shift than to modify/delete existing shift.\n\nAre you sure to continue?", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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
      shift.Update();
     }
     pfrmShiftList.BindShiftList();
     Close();
    }
   }
  }

  private void cmbShiftMode_SelectedIndexChanged(object sender, EventArgs e)
  {
   bool blnWorking = (cmbShiftMode.SelectedValue.ToString() == "W" ? true : false);

   dtpTimeStart.Enabled = blnWorking;
   dtpTimeHalf.Enabled = blnWorking;
   dtpTimeEnd.Enabled = blnWorking;
  }

 }
}
