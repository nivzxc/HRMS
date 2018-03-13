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
 public partial class frmEmployeeEmploymentHistoryAdd : Form
 {

  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strUsername;
  private string _strEmployeeName;

  public frmEmployeeEmploymentHistoryAdd(frmEmployeeDetails pfrmEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pfrmEmployeeDetails;
  }

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public string EmployeeName { set { _strEmployeeName = value; } get { return _strEmployeeName; } }


  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtInclusiveDates.Text == "")
    strErrorMessage = "Inclusive dates field is required.";
   if (txtPosition.Text == "")
    strErrorMessage += "\nPosition field is required.";
   if (txtResponsibility.Text == "")
    strErrorMessage += "\nResponsibility field is required.";
   if (txtCompanyName.Text == "")
    strErrorMessage += "\nCompany name field is required.";
   if (txtCompanyAddress.Text == "")
    strErrorMessage += "\nCompany address field is required.";

   if (strErrorMessage != "")
   {
    blnReturn = false;
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   }
   
   return blnReturn;
  }

  private void ClearFields()
  {
   cmbEmploymentStatus.DataSource = clsEmploymentStatus.DSLEmploymentStatus();
   cmbEmploymentStatus.ValueMember = "pvalue";
   cmbEmploymentStatus.DisplayMember = "ptext";

   txtInclusiveDates.Text = "";
   txtPosition.Text = "";
   txtResponsibility.Text = "";
   txtCompanyName.Text = "";
   txtCompanyAddress.Text = "";
   txtContactNumber.Text = "";

   txtInclusiveDates.Focus();
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmEmployeeEmploymentHistoryAdd_Load(object sender, EventArgs e)
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
    using (clsEmployeeEmploymentHistory eeh = new clsEmployeeEmploymentHistory())
    {
     eeh.Username = _strUsername;
     eeh.InclusiveDates = txtInclusiveDates.Text;
     eeh.Position = txtPosition.Text;     
     eeh.Responsibility = txtResponsibility.Text;
     eeh.EmploymentStatusCode = cmbEmploymentStatus.SelectedValue.ToString();
     eeh.CompanyName = txtCompanyName.Text;
     eeh.CompanyAddress = txtCompanyAddress.Text;
     eeh.CompanyContactNumber = txtContactNumber.Text;
     intResults = eeh.Add();
    }

    if (intResults > 0)
    {
     _frmEmployeeDetails.BindEmploymentHistoryList();
     if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      ClearFields();
     else
      this.Close();
    }
   }
  }

 }
}
