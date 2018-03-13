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
 public partial class frmTimeSheetPeriodEdit : Form
 {
  public frmTimeSheetPeriodEdit() { InitializeComponent(); }

  private string _strTimesheetPeriodCode;
  private frmTimeSheetPeriodList _frmTimeSheetPeriodList;
  private mdiIpanema _mdiIpanema;
  private FormCallers _FormCaller;
  
  public string TimesheetPeriodCode { get { return _strTimesheetPeriodCode; } set { _strTimesheetPeriodCode = value; } }
  public frmTimeSheetPeriodList FormTimeSheetPeriodList { get { return _frmTimeSheetPeriodList; } set { _frmTimeSheetPeriodList = value; } }
  public mdiIpanema FormMDIIpanema { get { return _mdiIpanema; } set { _mdiIpanema = value; } }
  public FormCallers FormCaller { get { return _FormCaller; } set { _FormCaller = value; } }  

  private void BindDetails()
  {
   txtPeriodCode.Text = _strTimesheetPeriodCode;
   using (clsTimeSheetPeriod tsp = new clsTimeSheetPeriod(_strTimesheetPeriodCode))
   {
    tsp.Fill();
    chkStatus.Checked = (tsp.Status == "1");
    chkPostData.Checked = (tsp.PostData == "1");
    dtpFrom.Value = tsp.PeriodFrom;
    dtpTo.Value = tsp.PeriodTo;
    txtDescription.Text = tsp.Description;
    if (tsp.Mode == "M")
     radMonthly.Checked = true;
    else if (tsp.Mode == "P")
     radMonthly.Checked = true;
    txtCreateBy.Text = tsp.CreateBy;
    txtCreateOn.Text = tsp.CreateOn.ToString("MMM dd, yyyy hh:mm tt");
    txtModifyBy.Text = tsp.ModifyBy;
    txtModifyOn.Text = tsp.ModifyOn.ToString("MMM dd, yyyy hh:mm tt");
   }
   txtPeriodCode.Focus();
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (dtpFrom.Value >= dtpTo.Value)
    strErrorMessage += "\nInvalid date entries.";

   if (strErrorMessage != "")
   {
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmTimeSheetPeriodEdit_Load(object sender, EventArgs e)
  {
   BindDetails();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (clsTimeSheetPeriod tsp = new clsTimeSheetPeriod(_strTimesheetPeriodCode))
    {
     tsp.PeriodFrom = dtpFrom.Value;
     tsp.PeriodTo = dtpTo.Value;
     tsp.Description = txtDescription.Text;
     tsp.Mode = (radMonthly.Checked ? "M" : "P");
     tsp.PostData = (chkPostData.Checked ? "1" : "0");
     tsp.Status = (chkStatus.Checked ? "1" : "0");
     tsp.ModifyBy = HRMSCore.Username;
     tsp.ModifyOn = DateTime.Now;
     tsp.Update();
    }
    if(_FormCaller == FormCallers.TimesheetPeriodList)
     _frmTimeSheetPeriodList.BindTimesheetPeriodList();
    this.Close();
   }
  }

 }
}
