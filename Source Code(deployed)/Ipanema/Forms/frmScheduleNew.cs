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
 public partial class frmScheduleNew : Form
 {
  private FormCallers _FormCaller;
  private frmScheduleList pfrmScheduleList;

  public frmScheduleNew()
  {
   InitializeComponent();
  }

  public frmScheduleNew(frmScheduleList pScheduleList)
  {
   InitializeComponent();
   pfrmScheduleList = pScheduleList;
  }

  public FormCallers FormCaller { get { return _FormCaller; } set { _FormCaller = value; } }

  private bool CheckShift()
  {
   return cmbShiftMon.Items.Count != 0 && cmbShiftTue.Items.Count != 0 && cmbShiftWed.Items.Count != 0 & cmbShiftThu.Items.Count != 0 && cmbShiftFri.Items.Count != 0 && cmbShiftSat.Items.Count != 0 && cmbShiftSun.Items.Count != 0;
  }

  private void RefreshTotalWorkingHours()
  {
   float fltRequiredWorkingHours = float.Parse(clsSystemSettings.GetValue(HRMSCore.RequiredTotalWorkHoursKey));
   float fltTotalWorkingHours = 0;
   clsSchedule schedule = new clsSchedule();
   schedule.MondayShift = cmbShiftMon.SelectedValue.ToString();
   schedule.TuesdayShift = cmbShiftTue.SelectedValue.ToString();
   schedule.WednesdayShift = cmbShiftWed.SelectedValue.ToString();
   schedule.ThursdayShift = cmbShiftThu.SelectedValue.ToString();
   schedule.FridayShift = cmbShiftFri.SelectedValue.ToString();
   schedule.SaturdayShift = cmbShiftSat.SelectedValue.ToString();
   schedule.SundayShift = cmbShiftSun.SelectedValue.ToString();
   fltTotalWorkingHours = schedule.GetTotalWorkingHours();
   txtTotalHours.Text = fltTotalWorkingHours.ToString();
   txtTotalHours.BackColor = (fltTotalWorkingHours < fltRequiredWorkingHours ? Color.MistyRose : Color.AliceBlue);
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void frmScheduleNew_Load(object sender, EventArgs e)
  {
   DataTable tblShiftMon = clsShift.GetDdlDS();
   DataTable tblShiftTue = clsShift.GetDdlDS();
   DataTable tblShiftWed = clsShift.GetDdlDS();
   DataTable tblShiftThu = clsShift.GetDdlDS();
   DataTable tblShiftFri = clsShift.GetDdlDS();
   DataTable tblShiftSat = clsShift.GetDdlDS();
   DataTable tblShiftSun = clsShift.GetDdlDS();

   cmbShiftMon.DataSource = tblShiftMon;
   cmbShiftMon.DisplayMember = "ptext";
   cmbShiftMon.ValueMember = "pvalue";

   cmbShiftTue.DataSource = tblShiftTue;
   cmbShiftTue.DisplayMember = "ptext";
   cmbShiftTue.ValueMember = "pvalue";

   cmbShiftWed.DataSource = tblShiftWed;
   cmbShiftWed.DisplayMember = "ptext";
   cmbShiftWed.ValueMember = "pvalue";

   cmbShiftThu.DataSource = tblShiftThu;
   cmbShiftThu.DisplayMember = "ptext";
   cmbShiftThu.ValueMember = "pvalue";

   cmbShiftFri.DataSource = tblShiftFri;
   cmbShiftFri.DisplayMember = "ptext";
   cmbShiftFri.ValueMember = "pvalue";

   cmbShiftSat.DataSource = tblShiftSat;
   cmbShiftSat.DisplayMember = "ptext";
   cmbShiftSat.ValueMember = "pvalue";

   cmbShiftSun.DataSource = tblShiftSun;
   cmbShiftSun.DisplayMember = "ptext";
   cmbShiftSun.ValueMember = "pvalue";

   RefreshTotalWorkingHours();
  }

  private void cmbShiftMon_SelectedIndexChanged(object sender, EventArgs e)
  {
   if(CheckShift()) RefreshTotalWorkingHours();
  }

  private void cmbShiftTue_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (CheckShift())  RefreshTotalWorkingHours();
  }

  private void cmbShiftWed_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (CheckShift())  RefreshTotalWorkingHours();
  }

  private void cmbShiftThu_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (CheckShift())  RefreshTotalWorkingHours();
  }

  private void cmbShiftFri_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (CheckShift())  RefreshTotalWorkingHours();
  }

  private void cmbShiftSat_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (CheckShift())  RefreshTotalWorkingHours();
  }

  private void cmbShiftSun_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (CheckShift())  RefreshTotalWorkingHours();
  }

  private void btnViewMon_Click(object sender, EventArgs e)
  {
   frmShiftDetails sd = new frmShiftDetails(cmbShiftMon.SelectedValue.ToString());
   sd.ShowDialog();
  }

  private void btnViewTue_Click(object sender, EventArgs e)
  {
   frmShiftDetails sd = new frmShiftDetails(cmbShiftTue.SelectedValue.ToString());
   sd.ShowDialog();
  }

  private void btnViewWed_Click(object sender, EventArgs e)
  {
   frmShiftDetails sd = new frmShiftDetails(cmbShiftWed.SelectedValue.ToString());
   sd.ShowDialog();
  }

  private void btnViewThu_Click(object sender, EventArgs e)
  {
   frmShiftDetails sd = new frmShiftDetails(cmbShiftThu.SelectedValue.ToString());
   sd.ShowDialog();
  }

  private void btnViewFri_Click(object sender, EventArgs e)
  {
   frmShiftDetails sd = new frmShiftDetails(cmbShiftFri.SelectedValue.ToString());
   sd.ShowDialog();
  }

  private void btnViewSat_Click(object sender, EventArgs e)
  {
   frmShiftDetails sd = new frmShiftDetails(cmbShiftSat.SelectedValue.ToString());
   sd.ShowDialog();
  }

  private void btnViewSun_Click(object sender, EventArgs e)
  {
   frmShiftDetails sd = new frmShiftDetails(cmbShiftSun.SelectedValue.ToString());
   sd.ShowDialog();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   int intRecordAffected = 0;

   clsSchedule schedule = new clsSchedule();
   schedule.SundayShift = cmbShiftSun.SelectedValue.ToString();
   schedule.MondayShift = cmbShiftMon.SelectedValue.ToString();
   schedule.TuesdayShift = cmbShiftTue.SelectedValue.ToString();
   schedule.WednesdayShift = cmbShiftWed.SelectedValue.ToString();
   schedule.ThursdayShift = cmbShiftThu.SelectedValue.ToString();
   schedule.FridayShift = cmbShiftFri.SelectedValue.ToString();
   schedule.SaturdayShift = cmbShiftSat.SelectedValue.ToString();
   schedule.Remarks = txtRemarks.Text;
   schedule.LastUpdateDate = DateTime.Now;
   schedule.LastUpdateBy = HRMSCore.Username;
   intRecordAffected = schedule.Add();

   if (intRecordAffected < 1)
    MessageBox.Show(clsMessageBox.MessageBoxErrorAdd, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   else
   {    
    switch (_FormCaller)
    {
     case FormCallers.ScheduleList:
      pfrmScheduleList.BindScheduleList();
      break;
    }
    this.Close();
   }
  }

 }
}
