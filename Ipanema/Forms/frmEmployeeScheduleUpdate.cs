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
 public partial class frmEmployeeScheduleUpdate : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private frmEmployeeScheduleList _frmEmployeeScheduleList;
  private string _strEmployeeScheduleCode;
  private string _strDefaultScheduleCode;

  public frmEmployeeDetails FormEmployeeDetails { set { _frmEmployeeDetails = value; } get { return _frmEmployeeDetails; } }
  public frmEmployeeScheduleList FormEmployeeScheduleList { set { _frmEmployeeScheduleList = value; } get { return _frmEmployeeScheduleList; } }
  public string EmployeeScheduleCode { set { _strEmployeeScheduleCode = value; } get { return _strEmployeeScheduleCode; } }
  public string DefaultScheduleCode { set { _strDefaultScheduleCode = value; } get { return _strDefaultScheduleCode; } }

  public frmEmployeeScheduleUpdate()
  {
   InitializeComponent();
  }

  public void SelectSchedule(string pScheduleCode)
  {
   cmbSchedule.SelectedValue = pScheduleCode;
  }
  
  public void BindDetails()
  {
   txtEmpSchdCode.Text = _strEmployeeScheduleCode;
   using (clsEmployeeSchedule es = new clsEmployeeSchedule())
   {
    es.EmployeeScheduleCode = _strEmployeeScheduleCode;
    es.Fill();    
    cmbSchedule.SelectedValue = es.ScheduleCode;
    dtpFrom.Value = es.DateFrom;
    dtpTo.Value = es.DateTo;
    txtReason.Text = es.Reason;
    txtRemarks.Text = es.Remarks;
    txtPostBy.Text = es.PostBy;
    txtPostDate.Text = es.PostDate.ToString("MMM dd, yyyy");
   }
  }

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;

   string strErrorMessage = "";

   if (dtpFrom.Value >= dtpTo.Value)
    strErrorMessage = "Invalid date entries.";

   if (txtReason.Text == "")
    strErrorMessage += "\nReason is required.";

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

  private void frmEmployeeScheduleUpdate_Load(object sender, EventArgs e)
  {
   cmbSchedule.DataSource = clsSchedule.DSLSchedule(_strDefaultScheduleCode);
   cmbSchedule.ValueMember = "pvalue";
   cmbSchedule.DisplayMember = "ptext";

   BindDetails();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    using (clsEmployeeSchedule es = new clsEmployeeSchedule())
    {
     es.EmployeeScheduleCode = _strEmployeeScheduleCode;
     es.ScheduleCode = cmbSchedule.SelectedValue.ToString();
     es.DateFrom = dtpFrom.Value;
     es.DateTo = dtpTo.Value;
     es.Reason = txtReason.Text;
     es.Remarks = txtRemarks.Text;
     es.Update();
    }
    _frmEmployeeDetails.LoadCurrentSchedule();
    this.Close();
   }
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
   frmScheduleSelector pForm = new frmScheduleSelector();
   pForm.FormCaller = FormCallers.EmployeeScheduleUpdate;
   pForm.FormEmployeeScheduleUpdate = this;   
   pForm.ShowDialog();
  }

 }
}