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
 public partial class frmACMMigration : Form
 {
  private DataTable _tblTransactMigratedACM;
  private DataTable _tblTransactInsertLogs;
  private DataTable _tblACMLog;

  public DataTable TableTransactACM { get { return _tblTransactMigratedACM; } set { _tblTransactMigratedACM = value; } }
  public DataTable TableTransactInsertLogs { get { return _tblTransactInsertLogs; } set { _tblTransactInsertLogs = value; } }
  public DataTable TableACMLog { get { return _tblACMLog; } set { _tblACMLog = value; } }

  public frmACMMigration()
  {
   InitializeComponent();
  }

  public void InitializeData()
  {
   _tblTransactMigratedACM = new DataTable();
   _tblTransactMigratedACM.Columns.Add("ControllerId");
   _tblTransactMigratedACM.Columns.Add("DoorId");
   _tblTransactMigratedACM.Columns.Add("Door");
   _tblTransactMigratedACM.Columns.Add("CardId");
   _tblTransactMigratedACM.Columns.Add("PersonalId");
   _tblTransactMigratedACM.Columns.Add("TDate");
   _tblTransactMigratedACM.Columns.Add("TTime");
   _tblTransactMigratedACM.Columns.Add("EventId");
   _tblTransactMigratedACM.Columns.Add("StaffId");
   _tblTransactMigratedACM.Columns.Add("DT");
   _tblTransactMigratedACM.Columns.Add("JobCode");
   _tblTransactMigratedACM.Columns.Add("JobInOut");
   _tblTransactMigratedACM.Columns.Add("TSurName");
   _tblTransactMigratedACM.Columns.Add("TName");

   _tblTransactInsertLogs = new DataTable();
   _tblTransactInsertLogs.Columns.Add("StaffId");
   _tblTransactInsertLogs.Columns.Add("DoorId");
   _tblTransactInsertLogs.Columns.Add("EventId");
   _tblTransactInsertLogs.Columns.Add("TDate");
   _tblTransactInsertLogs.Columns.Add("TTime");
   _tblTransactInsertLogs.Columns.Add("pviewed");

   _tblACMLog = new DataTable();
   _tblACMLog.Columns.Add("logdate");
   _tblACMLog.Columns.Add("logtime");
   _tblACMLog.Columns.Add("acmuser");
   _tblACMLog.Columns.Add("acmevent");
   _tblACMLog.Columns.Add("transid");
  }

  private void frmACMMigration_Load(object sender, EventArgs e)
  {
   InitializeData();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnProcess_Click(object sender, EventArgs e)
  {
   DateTime dteapril = new DateTime(2012,04,03);
   if ((dtpStart.Value < dteapril && dtpEnd.Value < dteapril))
   {
    if (dtpStart.Value <= dtpEnd.Value)
    {
     if (MessageBox.Show("Would you like to migrate the records?", "HRMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
     {
      DateTime _dteStart = new DateTime();
      DateTime _dteEnd = new DateTime();

      _dteStart = clsDateTime.GetDateOnly(dtpStart.Value);
      _dteEnd = clsDateTime.GetDateOnly(dtpEnd.Value);

      _tblTransactMigratedACM = MigrationACM.GetDSGTransact(_dteStart, _dteEnd);
      _tblTransactInsertLogs = MigrationACM.GetDSGTransactLogs(_dteStart, _dteEnd);
      _tblACMLog = MigrationACM.GetDSGACMLogs(_dteStart, _dteEnd);

      using (MigrationACM objMigrationAcm = new MigrationACM())
      {
       pbAcm.Value = 0;
       pbAcm.Minimum = 0;
       pbAcm.Maximum = MigrationACM.GetCountTransact(_dteStart, _dteEnd) + MigrationACM.GetCountTransactLogs(_dteStart, _dteEnd) + MigrationACM.GetCountACMlog(_dteStart, _dteEnd);

       //Table Transact
       objMigrationAcm.DeleteTransact(_dteStart, _dteEnd);
       foreach (DataRow dr in _tblTransactMigratedACM.Rows)
       {
        objMigrationAcm.ControllerID = clsValidator.CheckInteger(dr["ControllerId"].ToString());
        objMigrationAcm.DoorID = clsValidator.CheckInteger(dr["DoorId"].ToString());
        objMigrationAcm.Door = dr["Door"].ToString();
        objMigrationAcm.CardID = dr["CardId"].ToString();
        objMigrationAcm.PersonalID = clsValidator.CheckInteger(MigrationACM.GetPersonalID(dr["StaffId"].ToString()));
        objMigrationAcm.TDate = clsValidator.CheckDate(dr["TDate"].ToString());
        objMigrationAcm.TTime = clsValidator.CheckDate(dr["TTime"].ToString());
        objMigrationAcm.EventId = clsValidator.CheckInteger(dr["EventId"].ToString());
        objMigrationAcm.StaffID = dr["StaffId"].ToString();
        objMigrationAcm.DT = clsValidator.CheckDate(dr["DT"].ToString());
        objMigrationAcm.JobCode = dr["JobCode"].ToString();
        objMigrationAcm.JobInOut = clsValidator.CheckInteger(dr["JobInOut"].ToString());
        objMigrationAcm.TSurName = dr["TSurName"].ToString();
        objMigrationAcm.TName = dr["TName"].ToString();
        objMigrationAcm.InsertTransact();
        pbAcm.Value = pbAcm.Value + 1;
       }

       //Table TransactInsertLog
       objMigrationAcm.DeleteTransactLogs(_dteStart, _dteEnd);
       foreach (DataRow drLog in _tblTransactInsertLogs.Rows)
       {
        objMigrationAcm.StaffID = drLog["StaffId"].ToString();
        objMigrationAcm.DoorID = clsValidator.CheckInteger(drLog["DoorId"].ToString());
        objMigrationAcm.EventId = clsValidator.CheckInteger(drLog["EventId"].ToString());
        objMigrationAcm.TDate = clsValidator.CheckDate(drLog["TDate"].ToString());
        objMigrationAcm.TTime = clsValidator.CheckDate(drLog["TTime"].ToString());
        objMigrationAcm.pviewed = drLog["pviewed"].ToString();
        objMigrationAcm.InsertTransactLogs();
        pbAcm.Value = pbAcm.Value + 1;
       }

       //ACM Logs
       objMigrationAcm.DeleteACMLogs(_dteStart, _dteEnd);
       foreach (DataRow drAcm in _tblACMLog.Rows)
       {
        objMigrationAcm.TDate = clsValidator.CheckDate(drAcm["logdate"].ToString());
        objMigrationAcm.TTime = clsValidator.CheckDate(drAcm["logtime"].ToString());
        objMigrationAcm.ACMuser = drAcm["acmuser"].ToString();
        objMigrationAcm.ACMevent = drAcm["acmevent"].ToString();
        objMigrationAcm.TransID = clsValidator.CheckInteger(drAcm["transid"].ToString());
        pbAcm.Value = pbAcm.Value + 1;
       }
      }
      MessageBox.Show("Successfully migrated.", "HRMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
     }
    }
    else
    {
     MessageBox.Show("Invalid date range.", "HRMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
   }
   else
   {
    MessageBox.Show("Migrating of acm record must not be greater than April 2, 2012.", "HRMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
   }
  }
  
 }
}
