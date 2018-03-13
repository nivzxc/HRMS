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
 public partial class frmTimeCardAdd : Form
 {
  public frmTimeCardAdd() { InitializeComponent(); }

  private string _strUsername;
  private DateTime _dteFocusDate;
  private FormCallers _FormCaller;
  private frmTimeCardList _frmTimeCardList;
  private frmTimesheet _frmTimesheet;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public DateTime FocusDate { set { _dteFocusDate = value; } get { return _dteFocusDate; } }
  public FormCallers FormCaller { set { _FormCaller = value; } get { return _FormCaller; } }
  public frmTimeCardList FormTimeCardList { set { _frmTimeCardList = value; } get { return _frmTimeCardList; } }
  public frmTimesheet FormTimesheet { set { _frmTimesheet = value; } get { return _frmTimesheet; } }

  ///////////////////////////
  ///////// Methods ///////// 
  ///////////////////////////

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (dtpInDate.Value > dtpOutDate.Value)
    strErrorMessage = "Key Out field cannot be greater than Key In field.";

   if (strErrorMessage != "")
   {
    blnReturn = false;
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   }

   return blnReturn;
  }

  private void InitializeFields()
  {
   cmbUsername.DataSource = Employee.DSLActive();
   cmbUsername.ValueMember = "pvalue";
   cmbUsername.DisplayMember = "ptext";

   dtpFocusDate.Value = DateTime.Now;
   dtpInDate.Value = DateTime.Now;
   dtpOutDate.Value = DateTime.Now;

   SetTimeInOut();

   if (_FormCaller == FormCallers.Timesheet)
   {
    cmbUsername.SelectedValue = _strUsername;
    dtpFocusDate.Value = _dteFocusDate;
    dtpInDate.Value = _dteFocusDate;
    dtpOutDate.Value = _dteFocusDate;

    cmbUsername.Enabled = false;
    dtpFocusDate.Enabled = false;
    dtpInDate.Enabled = false;
   }
  }

  private void SetTimeInOut()
  {
   using (clsShift shift = new clsShift())
   {
    shift.ShiftCode = clsShift.GetDayShiftCode(cmbUsername.SelectedValue.ToString(), dtpFocusDate.Value);
    shift.Fill();
    dtpInTime.Value = shift.TimeStart;
    dtpOutTime.Value = shift.TimeEnd;
   }
  }

  private void ReInitializeFields()
  {
   dtpFocusDate.Value = dtpFocusDate.Value.AddDays(1);
   dtpInDate.Value = dtpInDate.Value.AddDays(1);
   dtpOutDate.Value = dtpOutDate.Value.AddDays(1);
   dtpFocusDate.Focus();
  }

  //////////////////////////////  
  ///////// Form Event ///////// 
  //////////////////////////////

  private void btnClear_Click(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   int intResult = 0;
   if (IsCorrectEntries())
   {
    clsTimeCard tc = new clsTimeCard();
    tc.Username = cmbUsername.SelectedValue.ToString();
    tc.FocusDate = dtpFocusDate.Value;
    tc.KeyIn = clsDateTime.CombineDateTime(dtpInDate.Value, dtpInTime.Value);
    tc.KeyOut = clsDateTime.CombineDateTime(dtpOutDate.Value, dtpOutTime.Value);
    tc.UpdateBy = HRMSCore.Username;
    tc.UpdateOn = DateTime.Now;
    tc.Remarks = txtRemarks.Text;
    intResult = tc.Insert();
   }

   if (intResult > 0)
   {
    if (_FormCaller == FormCallers.TimeCardList)
    {
     _frmTimeCardList.LoadTimeCardList();
     if (MessageBox.Show("You time card was successfully added.\n\nDo you want to add another time card?", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      ReInitializeFields();
     else
      this.Close();
    }
    else if (_FormCaller == FormCallers.Timesheet)
    {
     if (MessageBox.Show("You time card was successfully saved.\nHowever, you need to reprocess the timesheet to reflect the changes.\n\nDo you want to reprocess " + _dteFocusDate.ToString("MMM dd, yyyy") + "?", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
     {
      clsTimesheet.ProcessTimeSheet(_strUsername, _dteFocusDate);
      _frmTimesheet.BindTimeSheet();
     }
     this.Close();
    }
   }

  }

  private void frmTimeCardAdd_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { SetTimeInOut(); }
   catch { }
  }

  private void dtpFocusDate_ValueChanged(object sender, EventArgs e)
  {
   SetTimeInOut();
  }

 }
}
