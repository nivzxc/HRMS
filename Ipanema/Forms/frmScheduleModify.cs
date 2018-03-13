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
 public partial class frmScheduleModify : Form
 {
  public frmScheduleModify() { InitializeComponent(); }

  private string _strScheduleCode;
  private frmScheduleList _frmScheduleList;
  
  public string ScheduleCode { get { return _strScheduleCode; } set { _strScheduleCode = value; } }
  public frmScheduleList FormScheduleList { get { return _frmScheduleList; } set { _frmScheduleList = value; } }

  private bool CheckShift()
  {
   return cmbShiftMon.Items.Count != 0 && cmbShiftTue.Items.Count != 0 && cmbShiftWed.Items.Count != 0 & cmbShiftThu.Items.Count != 0 && cmbShiftFri.Items.Count != 0 && cmbShiftSat.Items.Count != 0 && cmbShiftSun.Items.Count != 0;
  }

  private void RefreshTotalWorkingHours()
  {
   //float fltRequiredWorkingHours = float.Parse(clsSystemSettings.GetValue(HRMSCore.RequiredTotalWorkHoursKey));
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
   //txtTotalHours.BackColor = (fltTotalWorkingHours < fltRequiredWorkingHours ? Color.MistyRose : Color.AliceBlue);
  }

  private void BindDetails()
  {
   clsSchedule schedule = new clsSchedule(_strScheduleCode);
   schedule.Fill();
   cmbShiftSun.SelectedValue = schedule.SundayShift;
   cmbShiftMon.SelectedValue = schedule.MondayShift;
   cmbShiftTue.SelectedValue = schedule.TuesdayShift;
   cmbShiftWed.SelectedValue = schedule.WednesdayShift;
   cmbShiftThu.SelectedValue = schedule.ThursdayShift;
   cmbShiftFri.SelectedValue = schedule.FridayShift;
   cmbShiftSat.SelectedValue = schedule.SaturdayShift;
   txtRemarks.Text = schedule.Remarks;
  }

  private void BindDefaultList()
  {
   DataTable tblDefaultList = clsSchedule.DSGEmployeeUsingDefault(_strScheduleCode);
   foreach (DataRow drw in tblDefaultList.Rows)
   {
    ListViewItem itm = new ListViewItem();
    itm.Text = drw["pName"].ToString();
    itm.SubItems.Add(drw["deptname"].ToString());
    lvDefault.Items.Add(itm);
   }
   tbpDefault.Text = "Default (" + tblDefaultList.Rows.Count.ToString() + ")";
   lvDefault.Columns[1].Width = (tblDefaultList.Rows.Count > 19 ? 300 : 317);
  }

  private void BindSpecialList()
  {
   DataTable tblSpecialList = clsSchedule.DSGEmployeeUsingSpecial(_strScheduleCode);
   foreach (DataRow drw in tblSpecialList.Rows)
   {
    ListViewItem itm = new ListViewItem();
    itm.Text = drw["pName"].ToString();
    itm.SubItems.Add(drw["deptname"].ToString());
    lvSpecial.Items.Add(itm);
   }
   tbpSpecial.Text = "Special (" + tblSpecialList.Rows.Count.ToString() + ")";
   lvSpecial.Columns[1].Width = (tblSpecialList.Rows.Count > 19 ? 300 : 317);
  }

  private void frmScheduleModify_Load(object sender, EventArgs e)
  {
   txtScheduleCode.Text = _strScheduleCode;

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

   BindDetails();
   BindDefaultList();
   BindSpecialList();
   if (CheckShift()) RefreshTotalWorkingHours();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnViewMon_Click(object sender, EventArgs e)
  {
   frmShiftDetails pForm = new frmShiftDetails(cmbShiftMon.SelectedValue.ToString());
   pForm.ShowDialog();
  }

  private void btnViewTue_Click(object sender, EventArgs e)
  {
   frmShiftDetails pForm = new frmShiftDetails(cmbShiftTue.SelectedValue.ToString());
   pForm.ShowDialog();
  }

  private void btnViewWed_Click(object sender, EventArgs e)
  {
   frmShiftDetails pForm = new frmShiftDetails(cmbShiftWed.SelectedValue.ToString());
   pForm.ShowDialog();
  }

  private void btnViewThu_Click(object sender, EventArgs e)
  {
   frmShiftDetails pForm = new frmShiftDetails(cmbShiftThu.SelectedValue.ToString());
   pForm.ShowDialog();
  }

  private void btnViewFri_Click(object sender, EventArgs e)
  {
   frmShiftDetails pForm = new frmShiftDetails(cmbShiftFri.SelectedValue.ToString());
   pForm.ShowDialog();
  }

  private void btnViewSat_Click(object sender, EventArgs e)
  {
   frmShiftDetails pForm = new frmShiftDetails(cmbShiftSat.SelectedValue.ToString());
   pForm.ShowDialog();
  }

  private void btnViewSun_Click(object sender, EventArgs e)
  {
   frmShiftDetails pForm = new frmShiftDetails(cmbShiftSun.SelectedValue.ToString());
   pForm.ShowDialog();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (MessageBox.Show("Warning: \nModifying schedule settings might cause discrepancies on employee's schedule associated with it. \nIt is advisable to create a new schedule than to modify it.\n\nAre you sure to continue?", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
   {
    int intRecordsAffected = 0;
    clsSchedule schedule = new clsSchedule();
    schedule.ScheduleCode = txtScheduleCode.Text;
    schedule.SundayShift = cmbShiftSun.SelectedValue.ToString();
    schedule.MondayShift = cmbShiftMon.SelectedValue.ToString();
    schedule.TuesdayShift = cmbShiftTue.SelectedValue.ToString();
    schedule.WednesdayShift = cmbShiftWed.SelectedValue.ToString();
    schedule.ThursdayShift = cmbShiftThu.SelectedValue.ToString();
    schedule.FridayShift = cmbShiftFri.SelectedValue.ToString();
    schedule.SaturdayShift = cmbShiftSat.SelectedValue.ToString();
    schedule.Remarks = txtRemarks.Text;
    schedule.LastUpdateBy = HRMSCore.Username;
    schedule.LastUpdateDate = DateTime.Now;
    intRecordsAffected = schedule.Edit();

    if (intRecordsAffected < 1)
     MessageBox.Show("Error: An error occured while updating your record.\n\nPlease contact your system administrator", clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error);
    else
    {
     _frmScheduleList.BindScheduleList();
     this.Close();
    }
   }

  }

  private void cmbShiftMon_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (CheckShift()) RefreshTotalWorkingHours();
  }

  private void cmbShiftTue_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (CheckShift()) RefreshTotalWorkingHours();
  }

  private void cmbShiftWed_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (CheckShift()) RefreshTotalWorkingHours();
  }

  private void cmbShiftThu_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (CheckShift()) RefreshTotalWorkingHours();
  }

  private void cmbShiftFri_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (CheckShift()) RefreshTotalWorkingHours();
  }

  private void cmbShiftSat_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (CheckShift()) RefreshTotalWorkingHours();
  }

  private void cmbShiftSun_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (CheckShift()) RefreshTotalWorkingHours();
  }

 }
}
