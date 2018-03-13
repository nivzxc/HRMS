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
 public partial class frmEmployeeAffiliationAdd : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strEmployeeName;
  private string _strUsername;

  public frmEmployeeAffiliationAdd(frmEmployeeDetails pfrmEmployeeDetails)
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
   txtOrganization.Text = "";
   txtPosition.Text = "";
   txtInclusiveDates.Text = "";
   txtRemarks.Text = "";

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

  private void frmEmployeeAffiliationAdd_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   ClearFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intResults = 0;
    using (clsEmployeeAffiliation ef = new clsEmployeeAffiliation())
    {
     ef.Username = _strUsername;
     ef.Organization = txtOrganization.Text;
     ef.Position = txtPosition.Text;
     ef.InclusiveDates = txtInclusiveDates.Text;
     ef.Remarks = txtRemarks.Text;
     intResults = ef.Add();
    }

    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadAffiliationList();
     if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      ClearFields();
     else
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
