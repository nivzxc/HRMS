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
 public partial class frmEmployeeScheduleInsert : Form
 {
  private FormCallers _FormCaller;
  private frmEmployeeDetails _frmEmployeeDetails;
  private frmEmployeeScheduleList _frmEmployeeScheduleList;
  private string _strUsername;
  private string _strDefaultScheduleCode;  

  public FormCallers FormCaller { set { _FormCaller = value; } get { return _FormCaller; } }
  public frmEmployeeDetails FormEmployeeDetails { set { _frmEmployeeDetails = value; } get { return _frmEmployeeDetails; } }
  public frmEmployeeScheduleList FormEmployeeScheduleList { set { _frmEmployeeScheduleList = value; } get { return _frmEmployeeScheduleList; } }
  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public string DefaultScheduleCode { set { _strDefaultScheduleCode = value; } get { return _strDefaultScheduleCode; } }

  public frmEmployeeScheduleInsert() { InitializeComponent(); }

  public void SelectSchedule(string pScheduleCode)
  {
   cmbSchedule.SelectedValue = pScheduleCode;
  }

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;

   string strErrorMessage = "";

   if (dtpFrom.Value >= dtpTo.Value)
    strErrorMessage = "Invalid date entries.";

   if (txtReason.Text == "")
    strErrorMessage += "\nReason is required.";

   if (clsEmployeeSchedule.HasExistingApplication(_strUsername, clsDateTime.GetDateOnly(dtpFrom.Value), clsDateTime.GetDateOnly(dtpTo.Value)))
    strErrorMessage += "\nThere is already an existing application on the specified dates.";

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

  private void frmEmployeeScheduleInsert_Load(object sender, EventArgs e)
  {
   txtEmployeeName.Text = Employee.GetName(_strUsername);
   cmbSchedule.DataSource = clsSchedule.DSLSchedule(_strDefaultScheduleCode);
   cmbSchedule.ValueMember = "pvalue";
   cmbSchedule.DisplayMember = "ptext";
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intResult = 0;
    using (clsEmployeeSchedule es = new clsEmployeeSchedule())
    {
     es.ScheduleCode = cmbSchedule.SelectedValue.ToString();
     es.Username = _strUsername;
     es.DateFrom = clsDateTime.GetDateOnly(dtpFrom.Value);
     es.DateTo = clsDateTime.GetDateOnly(dtpTo.Value);
     es.Reason = txtReason.Text;
     es.Remarks = txtRemarks.Text;
     es.PostBy = HRMSCore.Username;
     es.PostDate = DateTime.Now;
     intResult = es.Insert();
    }
    if (intResult > 0)
    {
     if (_FormCaller == FormCallers.EmployeeDetails)
      _frmEmployeeDetails.LoadCurrentSchedule();
     else if (_FormCaller == FormCallers.EmployeeScheduleList)
      _frmEmployeeScheduleList.LoadSchedule();
     this.Close();
    }
   }
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
   frmScheduleSelector pForm = new frmScheduleSelector();
   pForm.FormEmployeeScheduleInsert = this;
   pForm.FormCaller = FormCallers.EmployeeScheduleInsert;
   pForm.ShowDialog();
  }

 }
}
