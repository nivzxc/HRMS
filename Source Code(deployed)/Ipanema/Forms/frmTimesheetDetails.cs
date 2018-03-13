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
 public partial class frmTimesheetDetails : Form
 {
  public frmTimesheetDetails() { InitializeComponent(); }

  private string _strUsername;
  private DateTime _dteFocusDate;
  private frmTimesheet _frmTimesheet;
  private string _strStatus;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public DateTime FocusDate { set { _dteFocusDate = value; } get { return _dteFocusDate; } }
  public frmTimesheet FormTimesheet { set { _frmTimesheet = value; } get { return _frmTimesheet; } }

  private void BindDetails()
  {
   cmbShiftCode.DataSource = clsShift.GetDdlDS();
   cmbShiftCode.ValueMember = "pvalue";
   cmbShiftCode.DisplayMember = "ptext";

   using (clsTimesheet timesheet = new clsTimesheet())
   {
    timesheet.FocusDate = _dteFocusDate;
    timesheet.Username = _strUsername;
    timesheet.Fill();
    txtEmployeeName.Text = Employee.GetName(_strUsername);
    txtFocusDate.Text = _dteFocusDate.ToString("ddd MMM dd, yyyy");
    dtpTimeInDate.Value = timesheet.TimeIn;
    dtpTimeInTime.Value = timesheet.TimeIn;
    dtpTimeOutDate.Value = timesheet.TimeOut;
    dtpTimeOutTime.Value = timesheet.TimeOut;
    cmbShiftCode.SelectedValue = timesheet.ShiftCode;
    txtShiftIn.Text = timesheet.ShiftIn.ToString("MMM dd, yyyy hh:mm tt");
    txtShiftOut.Text = timesheet.ShiftOut.ToString("MMM dd, yyyy hh:mm tt");
    txtTotalHours.Text = timesheet.TotalUnit.ToString();
    txtWorkHours.Text = timesheet.WorkUnit.ToString();
    txtAbsent.Text = timesheet.AbsentUnit.ToString();
    txtLeaveWithPay.Text = timesheet.LeaveWithPay.ToString();
    txtLeaveWithoutPay.Text = timesheet.LeaveWithoutPay.ToString();
    txtLate.Text = timesheet.LateUnit.ToString();
    txtUndertime.Text = timesheet.UndertimeUnit.ToString();
    txtExcess.Text = timesheet.ExcessUnit.ToString();
    txtTimeCard.Text = timesheet.TCUnit.ToString();
    txtOB.Text = timesheet.OBUnit.ToString();
    txtRegOT.Text = timesheet.RegularOT.ToString();
    txtRegND.Text = timesheet.RegularND.ToString();
    txtRestOT.Text = timesheet.RestDayOT.ToString();
    txtRestEX.Text = timesheet.RestDayEX.ToString();
    txtRestND.Text = timesheet.RestDayND.ToString();
    txtRHolidayOT.Text = timesheet.RegularHolidayOT.ToString();
    txtRHolidayEX.Text = timesheet.RegularHolidayEX.ToString();
    txtRHolidayND.Text = timesheet.RegularHolidayND.ToString();
    txtSpecOT.Text = timesheet.SpecialHolidayOT.ToString();
    txtSpecEX.Text = timesheet.SpecialHolidayEX.ToString();
    txtSpecND.Text = timesheet.SpecialHolidayND.ToString();
    txtRRHolidayOT.Text = timesheet.RestDayRegularHolidayOT.ToString();
    txtRRHolidayEX.Text = timesheet.RestDayRegularHolidayEX.ToString();
    txtRRHolidayND.Text = timesheet.RestDayRegularHolidayND.ToString();
    txtRSpecOT.Text = timesheet.RestDaySpecialHolidayOT.ToString();
    txtRSpecEX.Text = timesheet.RestDaySpecialHolidayEX.ToString();
    txtRSpecND.Text = timesheet.RestDaySpecialHolidayND.ToString();
    _strStatus = timesheet.Status;
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmTimesheetDetails_Load(object sender, EventArgs e)
  {
   BindDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (MessageBox.Show(clsMessageBox.MessageBoxUpdateAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
   {
    using (clsTimesheet timesheet = new clsTimesheet())
    {
     timesheet.FocusDate = _dteFocusDate;
     timesheet.Username = _strUsername;
     timesheet.TimeIn = clsDateTime.CombineDateTime(dtpTimeInDate.Value, dtpTimeInTime.Value);
     timesheet.TimeOut = clsDateTime.CombineDateTime(dtpTimeOutDate.Value, dtpTimeOutTime.Value);
     timesheet.ShiftCode = cmbShiftCode.SelectedValue.ToString();
     timesheet.ShiftIn = clsValidator.CheckDate(txtShiftIn.Text);
     timesheet.ShiftOut = clsValidator.CheckDate(txtShiftOut.Text);
     timesheet.TotalUnit = clsValidator.CheckFloat(txtTotalHours.Text);
     timesheet.WorkUnit = clsValidator.CheckFloat(txtWorkHours.Text);
     timesheet.AbsentUnit = clsValidator.CheckFloat(txtAbsent.Text);
     timesheet.LeaveWithPay = clsValidator.CheckFloat(txtLeaveWithPay.Text);
     timesheet.LeaveWithoutPay = clsValidator.CheckFloat(txtLeaveWithoutPay.Text);
     timesheet.LateUnit = clsValidator.CheckFloat(txtLate.Text);
     timesheet.UndertimeUnit = clsValidator.CheckFloat(txtUndertime.Text);
     timesheet.TCUnit = clsValidator.CheckFloat(txtTimeCard.Text);
     timesheet.OBUnit = clsValidator.CheckFloat(txtOB.Text);
     timesheet.ExcessUnit = clsValidator.CheckFloat(txtExcess.Text);
     timesheet.RegularOT = clsValidator.CheckFloat(txtRegOT.Text);
     timesheet.RegularND = clsValidator.CheckFloat(txtRegND.Text);
     timesheet.RestDayOT = clsValidator.CheckFloat(txtRestOT.Text);
     timesheet.RestDayEX = clsValidator.CheckFloat(txtRestEX.Text);
     timesheet.RestDayND = clsValidator.CheckFloat(txtRestND.Text);
     timesheet.SpecialHolidayOT = clsValidator.CheckFloat(txtSpecOT.Text);
     timesheet.SpecialHolidayEX = clsValidator.CheckFloat(txtSpecEX.Text);
     timesheet.SpecialHolidayND = clsValidator.CheckFloat(txtSpecND.Text);
     timesheet.RegularHolidayOT = clsValidator.CheckFloat(txtRHolidayOT.Text);
     timesheet.RegularHolidayEX = clsValidator.CheckFloat(txtRHolidayEX.Text);
     timesheet.RegularHolidayND = clsValidator.CheckFloat(txtRHolidayND.Text);
     timesheet.RestDaySpecialHolidayOT = clsValidator.CheckFloat(txtRSpecOT.Text);
     timesheet.RestDaySpecialHolidayEX = clsValidator.CheckFloat(txtRSpecEX.Text);
     timesheet.RestDaySpecialHolidayND = clsValidator.CheckFloat(txtRSpecND.Text);
     timesheet.RestDayRegularHolidayOT = clsValidator.CheckFloat(txtRRHolidayOT.Text);
     timesheet.RestDayRegularHolidayEX = clsValidator.CheckFloat(txtRRHolidayEX.Text);
     timesheet.RestDayRegularHolidayND = clsValidator.CheckFloat(txtRRHolidayND.Text);
     timesheet.LastUpdateBy = HRMSCore.Username;
     timesheet.LastUpdateDate = DateTime.Now;
     timesheet.Status = _strStatus;
     timesheet.Update(clsShift.GetShiftMode(cmbShiftCode.SelectedValue.ToString()));
    }
    _frmTimesheet.BindTimeSheet();
    this.Close();
   }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}