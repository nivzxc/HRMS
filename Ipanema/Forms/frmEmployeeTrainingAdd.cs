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
 public partial class frmEmployeeTrainingAdd : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strEmployeeName;
  private string _strUsername;

  public frmEmployeeTrainingAdd(frmEmployeeDetails pfrmEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pfrmEmployeeDetails;
  }

  public string EmployeeName { set { _strEmployeeName = value; } get { return _strEmployeeName; } }
  public string Username { set { _strUsername = value; } get { return _strUsername; } }

  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

  private void ClearFields()
  {
   txtTraining.Text = "";
   dtpDate.Value = DateTime.Now;
   txtDetails.Text = "";
   txtSponsor.Text = "";

   txtTraining.Focus();
  }

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtTraining.Text == "")
    strErrorMessage = "Training field is required.";
   if (txtDetails.Text == "")
    strErrorMessage += "\nTraining Details field is required.";

   if (strErrorMessage != "")
   {
    blnReturn = false;
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   }

   return blnReturn;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmEmployeeTrainingAdd_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   ClearFields();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intResults = 0;
    using (clsEmployeeTraining et = new clsEmployeeTraining())
    {
     et.Username = _strUsername;
     et.Training = txtTraining.Text;
     et.TrainingDate = dtpDate.Value;
     et.Details = txtDetails.Text;
     et.Sponsor = txtSponsor.Text;
     intResults = et.Add();
    }

    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadTrainingList();
     if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      ClearFields();
     else
      this.Close();
    }
   }
  }

 }
}