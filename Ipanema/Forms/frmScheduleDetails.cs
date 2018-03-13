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
 public partial class frmScheduleDetails : Form
 {
  public frmScheduleDetails() { InitializeComponent(); }

  private string _strScheduleCode;
  private string _strUsername;
  private frmEmployeeDetails _frmEmployeeDetails;

  public string ScheduleCode { set { _strScheduleCode = value; } get { return _strScheduleCode; } }
  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public frmEmployeeDetails FormEmployeeDetails { set { _frmEmployeeDetails = value; } get { return _frmEmployeeDetails; } }  

  private void LoadScheduleDetails(string pScheduleCode)
  {
   using (clsSchedule schedule = new clsSchedule(pScheduleCode))
   {
    schedule.Fill();
    txtMonShift.Text = schedule.MondayShift;
    txtTueShift.Text = schedule.TuesdayShift;
    txtWedShift.Text = schedule.WednesdayShift;
    txtThuShift.Text = schedule.ThursdayShift;
    txtFriShift.Text = schedule.FridayShift;
    txtSatShift.Text = schedule.SaturdayShift;
    txtSunShift.Text = schedule.SundayShift;
   }
   Color clr = new Color();
   clsShift shift;

   #region " Monday "
   shift = new clsShift();
   shift.ShiftCode = txtMonShift.Text;
   shift.Fill();
   txtMonBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtMonBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtMonIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtMonHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtMonOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtMonLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtMonUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtMonShift.BackColor = clr;
   txtMonIn.BackColor = clr;
   txtMonHalf.BackColor = clr;
   txtMonOut.BackColor = clr;
   txtMonBS.BackColor = clr;
   txtMonBE.BackColor = clr;
   txtMonLate.BackColor = clr;
   txtMonUT.BackColor = clr;
   #endregion
   #region " Tuesday "
   shift = new clsShift();
   shift.ShiftCode = txtTueShift.Text;
   shift.Fill();
   txtTueBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtTueBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtTueIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtTueHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtTueOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtTueLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtTueUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtTueShift.BackColor = clr;
   txtTueIn.BackColor = clr;
   txtTueHalf.BackColor = clr;
   txtTueOut.BackColor = clr;
   txtTueBS.BackColor = clr;
   txtTueBE.BackColor = clr;
   txtTueLate.BackColor = clr;
   txtTueUT.BackColor = clr;
   #endregion
   #region " Wednesday "
   shift = new clsShift();
   shift.ShiftCode = txtWedShift.Text;
   shift.Fill();
   txtWedBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtWedBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtWedIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtWedHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtWedOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtWedLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtWedUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtWedShift.BackColor = clr;
   txtWedIn.BackColor = clr;
   txtWedHalf.BackColor = clr;
   txtWedOut.BackColor = clr;
   txtWedBS.BackColor = clr;
   txtWedBE.BackColor = clr;
   txtWedLate.BackColor = clr;
   txtWedUT.BackColor = clr;
   #endregion
   #region " Thursday "
   shift = new clsShift();
   shift.ShiftCode = txtThuShift.Text;
   shift.Fill();
   txtThuBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtThuBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtThuIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtThuHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtThuOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtThuLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtThuUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtThuShift.BackColor = clr;
   txtThuIn.BackColor = clr;
   txtThuHalf.BackColor = clr;
   txtThuOut.BackColor = clr;
   txtThuBS.BackColor = clr;
   txtThuBE.BackColor = clr;
   txtThuLate.BackColor = clr;
   txtThuUT.BackColor = clr;
   #endregion
   #region " Friday "
   shift = new clsShift();
   shift.ShiftCode = txtFriShift.Text;
   shift.Fill();
   txtFriBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtFriBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtFriIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtFriHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtFriOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtFriLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtFriUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtFriShift.BackColor = clr;
   txtFriIn.BackColor = clr;
   txtFriHalf.BackColor = clr;
   txtFriOut.BackColor = clr;
   txtFriBS.BackColor = clr;
   txtFriBE.BackColor = clr;
   txtFriLate.BackColor = clr;
   txtFriUT.BackColor = clr;
   #endregion
   #region " Saturday "
   shift = new clsShift();
   shift.ShiftCode = txtSatShift.Text;
   shift.Fill();
   txtSatBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtSatBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtSatIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtSatHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtSatOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtSatLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtSatUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtSatShift.BackColor = clr;
   txtSatIn.BackColor = clr;
   txtSatHalf.BackColor = clr;
   txtSatOut.BackColor = clr;
   txtSatBS.BackColor = clr;
   txtSatBE.BackColor = clr;
   txtSatLate.BackColor = clr;
   txtSatUT.BackColor = clr;
   #endregion
   #region " Sunday "
   shift = new clsShift();
   shift.ShiftCode = txtSunShift.Text;
   shift.Fill();
   txtSunBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtSunBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtSunIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtSunHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtSunOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtSunLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtSunUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtSunShift.BackColor = clr;
   txtSunIn.BackColor = clr;
   txtSunHalf.BackColor = clr;
   txtSunOut.BackColor = clr;
   txtSunBS.BackColor = clr;
   txtSunBE.BackColor = clr;
   txtSunLate.BackColor = clr;
   txtSunUT.BackColor = clr;
   #endregion
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmScheduleDetails_Load(object sender, EventArgs e)
  {
   cmbSchedule.DataSource = clsSchedule.DSLSchedule();
   cmbSchedule.ValueMember = "pvalue";
   cmbSchedule.DisplayMember = "ptext";

   cmbSchedule.SelectedValue = _strScheduleCode;
   LoadScheduleDetails(_strScheduleCode);

   btnSave.Visible = Convert.IsDBNull(_strUsername);
   cmbSchedule.Enabled = Convert.IsDBNull(_strUsername);
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void cmbSchedule_SelectedIndexChanged(object sender, EventArgs e)
  {
   LoadScheduleDetails(cmbSchedule.SelectedValue.ToString());
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (cmbSchedule.SelectedValue.ToString() != _strScheduleCode)
   {
    Employee.UpdateDefaultSchedule(_strUsername, cmbSchedule.SelectedValue.ToString());
    _frmEmployeeDetails.SetDefaultSchedule(cmbSchedule.SelectedValue.ToString());
    this.Close();
   }
    
  }

 }
}