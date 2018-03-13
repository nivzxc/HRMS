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
 public partial class frmEmployeeQualificationAdd : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strUsername;
  private string _strEmployeeName;

  public frmEmployeeQualificationAdd(frmEmployeeDetails pfrmEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pfrmEmployeeDetails;
  }

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public string EmployeeName { set { _strEmployeeName = value; } get { return _strEmployeeName; } }

  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

  private void ClearFields()
  {
   txtQualification.Text = "";
   txtInclusiveDates.Text = "";
   txtRemarks.Text = "";
   txtQualification.Focus();
  }

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtQualification.Text == "")
    strErrorMessage = "Qualification field is required.";
   if (txtInclusiveDates.Text == "")
    strErrorMessage += "\nInclusive Dates field is required.";

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

  private void frmEmployeeQualificationAdd_Load(object sender, EventArgs e)
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
    using (clsEmployeeQualification eq = new clsEmployeeQualification())
    {
     eq.Username = _strUsername;
     eq.Qualification = txtQualification.Text;
     eq.InclusiveDates = txtInclusiveDates.Text;
     eq.Remarks = txtRemarks.Text;
     intResults = eq.Add();
    }

    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadQualificationList();
     if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      ClearFields();
     else
      this.Close();
    }
   }
  }

 }
}
