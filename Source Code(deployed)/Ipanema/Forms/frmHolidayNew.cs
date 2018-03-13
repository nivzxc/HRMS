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
 public partial class frmHolidayNew : Form
 {
  public frmHolidayNew() { InitializeComponent(); }

  private frmHolidayList _frmHolidayList;
  public frmHolidayList FormHolidayList { set { _frmHolidayList = value; } get { return _frmHolidayList; } }

  public void BindShiftList()
  {
   cmbShift.DataSource = clsShift.GetDdlDS();
   cmbShift.ValueMember = "pvalue";
   cmbShift.DisplayMember = "pvalue";
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   using (Holiday objHoliday = new Holiday())
   {
    objHoliday.HolidayCode = txtHolidayCode.Text;
    objHoliday.DateApplied = clsDateTime.GetDateOnly(dteDateApplied.Value);
    objHoliday.ShiftCode = cmbShift.SelectedValue.ToString();
    objHoliday.Description = txtRemarks.Text;
    objHoliday.Insert();
    _frmHolidayList.BindHolidayList();
    this.Close();
   }
  }

  private void frmHolidayNew_Load(object sender, EventArgs e)
  {
   dteDateApplied.Value = DateTime.Now;
   txtHolidayCode.Text = dteDateApplied.Value.ToString("yy") + dteDateApplied.Value.Month.ToString("00") + dteDateApplied.Value.Day.ToString("00");
   BindShiftList();
  }

  private void dteDateApplied_ValueChanged(object sender, EventArgs e)
  {
   try
   { txtHolidayCode.Text = dteDateApplied.Value.ToString("yy") + dteDateApplied.Value.Month.ToString("00") + dteDateApplied.Value.Day.ToString("00"); }
   catch
   { }
  }

  private void btnShiftDetails_Click(object sender, EventArgs e)
  {
   frmShiftDetails pForm = new frmShiftDetails();
   pForm.ShiftCode = cmbShift.SelectedValue.ToString();
   pForm.ShowDialog();
  }

  private void btnShiftAdd_Click(object sender, EventArgs e)
  {
   frmShiftNew pForm = new frmShiftNew(this);
   pForm.FormCaller = FormCallers.HolidayNew;
   pForm.ShowDialog();
  }

 }
}