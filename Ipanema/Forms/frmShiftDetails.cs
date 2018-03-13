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
 public partial class frmShiftDetails : Form
 {

  private string strShiftCode;
  public string ShiftCode { get { return strShiftCode; } set { strShiftCode = value; } }

  public frmShiftDetails()
  {
   InitializeComponent();
  }

  public frmShiftDetails(string pShiftCode)
  {
   strShiftCode = pShiftCode;
   InitializeComponent();
  }

  private void btnClose_Click(object sender, EventArgs e) { Close(); }

  private void frmShiftDetails_Load(object sender, EventArgs e)
  {
   lblShiftCode.Text = strShiftCode;

   using (clsShift shift = new clsShift(strShiftCode))
   {
    shift.Fill();
    lblWorking.Text = (shift.ShiftModeCode == "W" ? "Yes" : "No");
    lblTimeStart.Text = shift.TimeStart.ToString("hh:mm tt");
    lblTimeHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    lblTimeEnd.Text = shift.TimeEnd.ToString("hh:mm tt");
    lblBreakStart.Text = shift.BreakTimeStart.ToString("hh:mm tt");
    lblBreakEnd.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
    lblLate.Text = shift.LateTime.ToString("hh:mm tt");
    lblUndertime.Text = shift.UnderTime.ToString("hh:mm tt");
    lblRemarks.Text = shift.Remarks;
    lblTotalWorkingHours.Text = shift.TotalWorkHours.ToString();
   }
  }

 }
}
