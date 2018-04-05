using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HRMS;
using Ipanema;
namespace Ipanema.Forms
{
 public partial class mdiIpanema : Form
 {
     
  public mdiIpanema() { InitializeComponent(); }

  private frmLogin _frmLogin;
  private ToolStripStatusLabel _sslFormInfo;

  public frmLogin FormLogin { set { _frmLogin = value; } get { return _frmLogin; } }
  public ToolStripStatusLabel FormControlFormInfo { set { _sslFormInfo = value; } get { return _sslFormInfo; } }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////
  
  private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
  {
   LayoutMdi(MdiLayout.Cascade);
  }

  private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
  {
   LayoutMdi(MdiLayout.TileVertical);
  }

  private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
  {
   LayoutMdi(MdiLayout.TileHorizontal);
  }

  private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
  {
   LayoutMdi(MdiLayout.ArrangeIcons);
  }

  private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
  {
      this.CloseAll();
  }
  public void CloseAll()
  {
      foreach (Form childForm in MdiChildren)
      {
          childForm.Close();
      }
  }

  private void mdiIpanema_Load(object sender, EventArgs e)
  {          
   
   using (clsTimeSheetPeriod tsp = new clsTimeSheetPeriod(clsTimeSheetPeriod.GetCurrentTimeSheetPeriod()))
   {
    tsp.Fill();
    lblPeriodStart.Text = tsp.PeriodFrom.ToString("ddd, MMM dd, yyyy");
    lblPeriodEnd.Text = tsp.PeriodTo.ToString("ddd, MMM dd, yyyy");
   }  
   _sslFormInfo = sslFormInfo;

   HRMSCore.MDIParentIpanema = this;
   lblUsername.Text = "Welcome! " + HRMSCore.Username;
   tmrMain.Enabled = true;
   sslUsername.Text = "Logged User: " + HRMSCore.Username;
      
            this.DSGZeroEL();
            this.DSGZeroVL();
            this.DSGZeroSL();

            LoadDSGLeaveNotification();
            LoadDSGOffenseNotification();      
  }
        //coders
 public void LoadDSGLeaveNotification()
 {
      dgLeave.AutoGenerateColumns = false;
      dgLeave.DataSource = clsLeave3Days.GetDSGMainFormNotification();
 }
  public void LoadDSGOffenseNotification()
  {
      dgOffense.AutoGenerateColumns = false;
      dgOffense.DataSource = clsOffense.GetDSGMainFormNotification();
  }

  public void DSGZeroEL()
  {
      DateTime dt = DateTime.Now;
      dgNotify.AutoGenerateColumns = false;
      dgNotify.DataSource = LeaveApplicationBalance.DSGZeroEL(dt.ToString("yy") + "-" + dt.AddYears(1).ToString("yy") + " Emergency Leave");
      dgNotify.Columns[0].DataPropertyName = "lastname";
      dgNotify.Columns[1].DataPropertyName = "firname";
  }

  public void DSGZeroVL()
  {
      DateTime dt = DateTime.Now;
      dgNotify1.AutoGenerateColumns = false;
      dgNotify1.DataSource = LeaveApplicationBalance.DSGZeroVL(dt.ToString("yy") + "-" + dt.AddYears(1).ToString("yy") + " Vacation leave with pay");
      dgNotify1.Columns[0].DataPropertyName = "lastname";
      dgNotify1.Columns[1].DataPropertyName = "firname";
  }

  public void DSGZeroSL()
  {
      DateTime dt = DateTime.Now;
      dgNotify2.AutoGenerateColumns = false;
      dgNotify2.DataSource = LeaveApplicationBalance.DSGZeroSL(dt.ToString("yy") + "-" + dt.AddYears(1).ToString("yy") + " Sick leave with pay");
      dgNotify2.Columns[0].DataPropertyName = "lastname";
      dgNotify2.Columns[1].DataPropertyName = "firname";

  }
   
  private void tmiShift_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmShiftList pForm = new frmShiftList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiEmployee_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmEmployeeList pForm = new frmEmployeeList();
   pForm.MdiParent = this;
   pForm.FormMDICaller = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiScheduleList_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmScheduleList pForm = new frmScheduleList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiTimesheetProcess_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmTimesheetProcess pForm = new frmTimesheetProcess();
   pForm.ShowDialog();
   this.Cursor = Cursors.Default;
  }

  private void tmiEmployeeType_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmEmployeeTypeList pForm = new frmEmployeeTypeList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiEmployeeClass_Click(object sender, EventArgs e)
  {

  }

  private void tmiTimeSheetPeriod_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmTimeSheetPeriodList pForm = new frmTimeSheetPeriodList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiTimesheetEmployee_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmTimesheet pForm = new frmTimesheet();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiHoliday_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmHolidayList pForm = new frmHolidayList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiDivisionList_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmDivisionList pForm = new frmDivisionList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiTimeCards_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmTimeCardList pForm = new frmTimeCardList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiJGCodeList_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmJobGradeList pForm = new frmJobGradeList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiSystemExplorer_Click(object sender, EventArgs e)
  {
   tmiSystemExplorer.Checked = !tmiSystemExplorer.Checked;
   pnlLeft.Visible = tmiSystemExplorer.Checked;
  }

  private void mdiIpanema_FormClosed(object sender, FormClosedEventArgs e)
  {
   //Application.Exit();
  }

  private void tmiLeave_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmLeaveList pForm = new frmLeaveList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiUndertime_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmUndertimeList pForm = new frmUndertimeList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiOB_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmOBList pForm = new frmOBList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiGroupList_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmGroupList pForm = new frmGroupList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiDepartmentList_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmDepartmentList pForm = new frmDepartmentList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiEmployeeSchedule_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmEmployeeScheduleList pForm = new frmEmployeeScheduleList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiOvertime_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmOvertimeList pForm = new frmOvertimeList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void mdiIpanema_FormClosing(object sender, FormClosingEventArgs e)
  {

  _frmLogin.Show();
  }

  private void tmiLogout_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tmiReportLeaveWithoutPay_Click(object sender, EventArgs e)
  {
     
  }

  private void tmiCalculator_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   if (!clsShell.StartProcess("calc.exe"))
    MessageBox.Show("No Calculator installed in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
   this.Cursor = Cursors.Default;
  }

  private void tmrMain_Tick(object sender, EventArgs e)
  {
   sslDate.Text = "Date: " + DateTime.Now.ToString("MMM dd, yyyy");
   sslTime.Text = "Time: " + DateTime.Now.ToString("hh:mm:ss tt");
  }

  private void tmiLeaveEntitlement_Click(object sender, EventArgs e)
  {
   frmLeaveEntitlementList pForm = new frmLeaveEntitlementList();
   pForm.MdiParent = this;
   pForm.FormMdiCaller = this;
   pForm.Show();
  }

  private void tmiUsers_Click(object sender, EventArgs e)
  {
   frmPortalUsersList pForm = new frmPortalUsersList();
   pForm.MdiParent = this;
   pForm.Show();
  }

  private void tmiLLUSummary_Click(object sender, EventArgs e)
  {
   frmIEmployeeLeaveUnderLateSummary pForm = new frmIEmployeeLeaveUnderLateSummary();
   pForm.MdiParent = this;
   pForm.Show();
  }

  private void lnkActiveTimesheet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
   frmTimeSheetPeriodEdit pForm = new frmTimeSheetPeriodEdit();
   pForm.TimesheetPeriodCode = clsTimeSheetPeriod.GetCurrentTimeSheetPeriod();
   pForm.FormCaller = FormCallers.MdiIpanema;
   pForm.FormMDIIpanema = this;
   pForm.ShowDialog();
  }

  private void tmiLeaveTypes_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmLeaveTypeList pForm = new frmLeaveTypeList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiCluster_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmClusterList pForm = new frmClusterList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiCDL_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmCDLList pForm = new frmCDLList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiChangeScheduleBatch_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmChangeShiftBatchList pForm = new frmChangeShiftBatchList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiTimeCardACM_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmTimeCardAcmList pForm = new frmTimeCardAcmList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiMSPaint_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   if (!clsShell.StartProcess("mspaint.exe"))
    MessageBox.Show("No MS Paint installed in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
   this.Cursor = Cursors.Default;
  }

  private void tmiOSK_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   if (!clsShell.StartProcess("osk.exe"))
    MessageBox.Show("No On-Screen Keyboard installed in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
   this.Cursor = Cursors.Default;
  }

  private void tmiRecruitmentSource_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmRecruitmentSourceList pForm = new frmRecruitmentSourceList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiResignationReason_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmResignationReasonList pForm = new frmResignationReasonList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiStatusBar_CheckStateChanged(object sender, EventArgs e)
  {
   ssMain.Visible = tmiStatusBar.Checked;
  }

  private void tmiRCList_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmRCList pForm = new frmRCList();
   pForm.MdiParent = this;
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void tmiOffense_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmOffenseList pForm = new frmOffenseList();
   pForm.MdiParent = this;
   pForm.Indicator = "0";
   pForm.Show();
   this.Cursor = Cursors.Default;
  }

  private void mnuiTimesheetAccess_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmTimeSheetAccessMain pForm = new frmTimeSheetAccessMain();
   pForm.Show();
   this.Cursor = Cursors.Default;
  }
  
  private void timBalance_Click(object sender, EventArgs e)
  {
      timBalance.Checked = !timBalance.Checked;
      this.pnlNotifyLeaveBalance.Visible = timBalance.Checked;
  }

  private void tminotifybal_Click(object sender, EventArgs e)
  {
      frmLeaveSettingList pForm = new frmLeaveSettingList();
      pForm.FormMDICaller = this;
      pForm.ShowDialog();
  }

  private void tbtnPAEmployee_Click(object sender, EventArgs e)
  {
      frmPerfectAttendance objfrmPerfectAttendance = new frmPerfectAttendance();
      objfrmPerfectAttendance.MdiParent = this;
      objfrmPerfectAttendance.Show();
  }

  private void perfectAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
  {
      frmPerfectAttendance objfrmPerfectAttendance = new frmPerfectAttendance();
      objfrmPerfectAttendance.MdiParent = this;
      objfrmPerfectAttendance.Show();
  }

  private void employeeLeaveOffenseToolStripMenuItem_Click(object sender, EventArgs e)
  {
      frmLeave3DaysMain objfrmLeave3DaysMain = new frmLeave3DaysMain();
      objfrmLeave3DaysMain.MdiParent = this;
      objfrmLeave3DaysMain.Indicator = "0";
      objfrmLeave3DaysMain.Show();
  }

  private void employeeLeave3DaysToolStripMenuItem_Click(object sender, EventArgs e)
  {      

      //frmLeave3DayOffence objfrmLeave3offense = new frmLeave3DayOffence();
      //objfrmLeave3offense.MdiParent = this;
      //objfrmLeave3offense.Show();
  }

  private void btnClose_Click_2(object sender, EventArgs e)
  {
      timBalance.Checked = !timBalance.Checked;
      this.pnlNotifyLeaveBalance.Visible = timBalance.Checked;
  }

  private void dgNotify_DoubleClick(object sender, EventArgs e)
  {
      if (dgNotify.RowCount > 0)
      {
          this.CloseAll();
          frmEmployeeList pForm = new frmEmployeeList();
          pForm.MdiParent = this;
          pForm.FormMDICaller = this;
          pForm.Username = dgNotify.SelectedRows[0].Cells[0].Value.ToString();
          pForm.Show();
          this.Cursor = Cursors.Default;
      }
  }

  private void dgNotify1_DoubleClick(object sender, EventArgs e)
  {
      if (dgNotify1.RowCount > 0)
      {
          this.CloseAll();
          frmEmployeeList pForm = new frmEmployeeList();
          pForm.MdiParent = this;
          pForm.FormMDICaller = this;
          pForm.Username = dgNotify1.SelectedRows[0].Cells[0].Value.ToString();
          pForm.Show();
          this.Cursor = Cursors.Default;
      }
  }

  private void dgNotify2_DoubleClick(object sender, EventArgs e)
  {
      if (dgNotify2.RowCount > 0)
      {
          this.CloseAll();
          frmEmployeeList pForm = new frmEmployeeList();
          pForm.MdiParent = this;
          pForm.FormMDICaller = this;
          pForm.Username = dgNotify2.SelectedRows[0].Cells[0].Value.ToString();
          pForm.Show();
          this.Cursor = Cursors.Default;
      }
  }

  private void btnClose1_Click(object sender, EventArgs e)
  {
      timexpiredoffleave.Checked = !timexpiredoffleave.Checked;
      this.pnlNotificationoffleave.Visible = timexpiredoffleave.Checked;
  }

  private void timexpiredoffleave_Click(object sender, EventArgs e)
  {
      timexpiredoffleave.Checked = !timexpiredoffleave.Checked;
      this.pnlNotificationoffleave.Visible = timexpiredoffleave.Checked;
  }

  private void dgLeave_DoubleClick(object sender, EventArgs e)
  {
      CloseAll();
      frmLeave3DaysMain objfrmLeave3DaysMain = new frmLeave3DaysMain();
      objfrmLeave3DaysMain.MDIIpanema = this;
      objfrmLeave3DaysMain.FormCaller = this;
      objfrmLeave3DaysMain.LeaveCodeIpanema = dgLeave.SelectedRows[0].Cells[0].Value.ToString();
      objfrmLeave3DaysMain.UserNameCode = dgLeave.SelectedRows[0].Cells[1].Value.ToString();
      objfrmLeave3DaysMain.EmployeeNameCode = dgLeave.SelectedRows[0].Cells[2].Value.ToString() + ", " + dgLeave.SelectedRows[0].Cells[3].Value.ToString();
      objfrmLeave3DaysMain.MdiParent = this;
      objfrmLeave3DaysMain.Indicator = "1";
      objfrmLeave3DaysMain.Show();
  }

  private void dgOffense_DoubleClick(object sender, EventArgs e)
  {
      CloseAll();
      frmOffenseList objfrmOffenseList = new frmOffenseList();
      objfrmOffenseList.MDIIpanema = this;
      objfrmOffenseList.FormCaller = this;
      objfrmOffenseList.Indicator = "1";
      objfrmOffenseList.OffenseCode = dgOffense.SelectedRows[0].Cells[0].Value.ToString();
      objfrmOffenseList.MdiParent = this;
      objfrmOffenseList.Show();
  }

  private void btnRefreshOffense_Click(object sender, EventArgs e)
  {
      LoadDSGOffenseNotification();
  }

  private void btnRefreshLeave_Click(object sender, EventArgs e)
  {
      LoadDSGLeaveNotification();
  }

  private void aCMMigrationToolStripMenuItem_Click(object sender, EventArgs e)
  {
   frmACMMigration objfrmAcmMigration = new frmACMMigration();
   objfrmAcmMigration.Show();
  }

        private void lnkActiveTimesheet_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tsMainTimesheet_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlActiveForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void runTimeKeepingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmLogInOut employee_log = new frmLogInOut();
            Form forms = Application.OpenForms["frmLogInOut"];
            if (forms == null)
            {
                employee_log.Show();
            }
            else { MessageBox.Show("Time Keeping Application is currently running, Please close it first before running it again", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }             

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }      

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
       
    } 
}
