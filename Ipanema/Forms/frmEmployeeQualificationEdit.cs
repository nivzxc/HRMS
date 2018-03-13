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
 public partial class frmEmployeeQualificationEdit : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strQualificationCode;
  private string _strEmployeeName;

  public frmEmployeeQualificationEdit(frmEmployeeDetails pfrmEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pfrmEmployeeDetails;
  }

  public string QualificationCode { set { _strQualificationCode = value; } get { return _strQualificationCode; } }
  public string EmployeeName { set { _strEmployeeName = value; } get { return _strEmployeeName; } }

  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

  private void LoadDetails()
  {
   using (clsEmployeeQualification eq = new clsEmployeeQualification(_strQualificationCode))
   {
    eq.Fill();
    txtQualification.Text = eq.Qualification;
    txtInclusiveDates.Text = eq.InclusiveDates;
    txtRemarks.Text = eq.Remarks;
   }
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

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intResults = 0;
    clsEmployeeQualification eq = new clsEmployeeQualification();
    eq.QualificationCode = _strQualificationCode;
    eq.Qualification = txtQualification.Text;
    eq.InclusiveDates = txtInclusiveDates.Text;
    eq.Remarks = txtRemarks.Text;
    intResults = eq.Edit();
    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadQualificationList();
     this.Close();
    }
   }
  }

  private void frmEmployeeQualificationEdit_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   LoadDetails();
  }

 }
}
