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
 public partial class frmTimeSheetPeriodInsert : Form
 {

  private frmTimeSheetPeriodList _frmTimeSheetPeriodList;

  public frmTimeSheetPeriodList FormTimeSheetPeriodList { set { _frmTimeSheetPeriodList = value; } get { return _frmTimeSheetPeriodList; } }

  private void GenerateCode()
  {
   txtPeriodCode.Text = dtpFrom.Value.ToString("yyMMdd") + dtpTo.Value.ToString("yyMMdd");
  }

  private void InitializeFields()
  {
   DateTime dteFrom = new DateTime();

   using (clsTimeSheetPeriod tsp = new clsTimeSheetPeriod(clsTimeSheetPeriod.GetCurrentTimeSheetPeriod()))
   {
    tsp.Fill();
    dteFrom = tsp.PeriodFrom.AddMonths(1);
   }

   dtpFrom.Value = new DateTime(dteFrom.Year, dteFrom.Month, 1);
   dtpTo.Value = new DateTime(dteFrom.Year, dteFrom.Month, dteFrom.AddMonths(1).AddDays(-1).Day);
   txtPeriodCode.Text = dtpFrom.Value.ToString("yyMMdd") + dtpTo.Value.ToString("yyMMdd");
   txtDescription.Text = "";
   dtpFrom.Focus();
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (dtpFrom.Value >= dtpTo.Value)
    strErrorMessage = "Invalid date settings.";

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

  public frmTimeSheetPeriodInsert()
  {
   InitializeComponent();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void frmTimeSheetPeriodInsert_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   int intResult = 0;

   if (IsCorrectData())
   {
    if (clsTimeSheetPeriod.IsCodeExist(txtPeriodCode.Text))
    {
     MessageBox.Show("Timesheet Code already exist.", clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    else
    {
     clsTimeSheetPeriod tsp = new clsTimeSheetPeriod();
     tsp.TimeSheetPeriodCode = txtPeriodCode.Text;
     tsp.PeriodFrom = dtpFrom.Value;
     tsp.PeriodTo = dtpTo.Value;
     tsp.Description = txtDescription.Text;
     tsp.Mode = (radMonthly.Checked ? "M" : "P");
     tsp.PostData = "0";
     tsp.Status = "1";
     tsp.CreateBy = HRMSCore.Username;
     tsp.CreateOn = DateTime.Now;
     tsp.ModifyBy = HRMSCore.Username;
     tsp.ModifyOn = DateTime.Now;
     intResult = tsp.Insert();
    }
   }

   if (intResult > 0)
   {
    _frmTimeSheetPeriodList.BindTimesheetPeriodList();
    if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
     InitializeFields();
    else
     this.Close();
   }
   else
   {
    MessageBox.Show(clsMessageBox.MessageBoxErrorAdd, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error);
   }
  }

  private void dtpFrom_ValueChanged(object sender, EventArgs e)
  {
   GenerateCode();
  }

  private void dtpTo_ValueChanged(object sender, EventArgs e)
  {
   GenerateCode();
  }

 }
}
