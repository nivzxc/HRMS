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
 public partial class frmEmployeeAffiliationEdit : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strEmployeeName;
  private string _strAffiliationCode;

  public frmEmployeeAffiliationEdit(frmEmployeeDetails pfrmEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pfrmEmployeeDetails;
  }

  public string EmployeeName { set { _strEmployeeName = value; } get { return _strEmployeeName; } }
  public string AffiliationCode { set { _strAffiliationCode = value; } get { return _strAffiliationCode; } }

  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

  private void LoadDetails()
  {
   using (clsEmployeeAffiliation ea = new clsEmployeeAffiliation(_strAffiliationCode))
   {
    ea.Fill();
    txtOrganization.Text = ea.Organization;
    txtPosition.Text = ea.Position;
    txtInclusiveDates.Text = ea.InclusiveDates;
    txtRemarks.Text = ea.Remarks;
   }

   txtOrganization.Focus();
  }

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtOrganization.Text == "")
    strErrorMessage = "Organization field is required.";
   if (txtPosition.Text == "")
    strErrorMessage += "\nPosition field is required.";
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

  private void frmEmployeeAffiliationEdit_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   LoadDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intResults = 0;
    clsEmployeeAffiliation ea = new clsEmployeeAffiliation();
    ea.AffiliationCode = _strAffiliationCode;
    ea.Organization = txtOrganization.Text;
    ea.Position = txtPosition.Text;
    ea.InclusiveDates = txtInclusiveDates.Text;
    ea.Remarks = txtRemarks.Text;
    intResults = ea.Edit();
    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadAffiliationList();
     this.Close();
    }
   }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}
