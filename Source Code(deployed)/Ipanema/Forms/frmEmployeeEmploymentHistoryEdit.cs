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
 public partial class frmEmployeeEmploymentHistoryEdit : Form
 {
  public frmEmployeeEmploymentHistoryEdit() { InitializeComponent(); }

  private string _strEmploymentHistoryCode;
  private string _strEmployeeName;
  private frmEmployeeDetails _frmEmployeeDetails;

  public string EmploymentHistoryCode { set { _strEmploymentHistoryCode = value; } get { return _strEmploymentHistoryCode; } }
  public string EmployeeName { set { _strEmployeeName = value; } get { return _strEmployeeName; } }
  public frmEmployeeDetails FormEmployeeDetails { set { _frmEmployeeDetails = value; } get { return _frmEmployeeDetails; } }

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

  private void LoadDetails()
  {
   cmbEmploymentStatus.DataSource = clsEmploymentStatus.DSLEmploymentStatus();
   cmbEmploymentStatus.ValueMember = "pvalue";
   cmbEmploymentStatus.DisplayMember = "ptext";

   using (clsEmployeeEmploymentHistory eeh = new clsEmployeeEmploymentHistory(_strEmploymentHistoryCode))
   {
    eeh.Fill();
    txtInclusiveDates.Text = eeh.InclusiveDates;
    txtPosition.Text = eeh.Position;
    txtResponsibility.Text = eeh.Responsibility;
    cmbEmploymentStatus.SelectedValue = eeh.EmploymentStatusCode;
    txtCompanyName.Text = eeh.CompanyName;
    txtCompanyAddress.Text = eeh.CompanyAddress;
    txtContactNumber.Text = eeh.CompanyContactNumber;
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmEmployeeEmploymentHistoryEdit_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   LoadDetails();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    clsEmployeeEmploymentHistory eeh = new clsEmployeeEmploymentHistory(_strEmploymentHistoryCode);
    eeh.InclusiveDates = txtInclusiveDates.Text;
    eeh.Position = txtPosition.Text;
    eeh.Responsibility = txtResponsibility.Text;
    eeh.EmploymentStatusCode = cmbEmploymentStatus.SelectedValue.ToString();
    eeh.CompanyName = txtCompanyName.Text;
    eeh.CompanyAddress = txtCompanyAddress.Text;
    eeh.CompanyContactNumber = txtContactNumber.Text;
    if (eeh.Edit() > 0)
    {
     _frmEmployeeDetails.BindEmploymentHistoryList();
     this.Close();
    }
   }
  }

 }
}
