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
 public partial class frmEmployeeTrainingEdit : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strTrainingCode;
  private string _strEmployeeName;

  public frmEmployeeTrainingEdit(frmEmployeeDetails pfrmEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pfrmEmployeeDetails;
  }

  public string TrainingCode { set { _strTrainingCode = value; } get { return _strTrainingCode; } }
  public string EmployeeName { set { _strEmployeeName = value; } get { return _strEmployeeName; } }

  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

  private void LoadDetails()
  {
   using (clsEmployeeTraining et = new clsEmployeeTraining(_strTrainingCode))
   {
    et.Fill();
    txtTraining.Text = et.Training;
    dtpDate.Value = et.TrainingDate;
    txtDetails.Text = et.Details;
    txtSponsor.Text = et.Sponsor;
   }
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

  private void frmEmployeeTrainingEdit_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   LoadDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intResults = 0;

    clsEmployeeTraining et = new clsEmployeeTraining();
    et.TrainingCode = _strTrainingCode;
    et.Training = txtTraining.Text;
    et.TrainingDate = dtpDate.Value;
    et.Details = txtDetails.Text;
    et.Sponsor = txtSponsor.Text;
    intResults = et.Edit();

    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadTrainingList();
     Close();
    }
   }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}
