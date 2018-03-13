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
 public partial class frmEmployeeEducationAdd : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strEmployeeName;
  private string _strUsername;

  public frmEmployeeEducationAdd(frmEmployeeDetails pfrmEmployeeDetails)
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
   cmbLevel.DataSource = EducationLevel.GetDSL();
   cmbLevel.DisplayMember = "pText";
   cmbLevel.ValueMember = "pValue";

   chkComplete.Checked = false;
   txtCourse.Text = "";
   txtInclusiveDates.Text = "";
   txtRecognition.Text = "";
   txtSchoolName.Text = "";
   txtSchoolAddress.Text = "";

   cmbLevel.Focus();
  }

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtInclusiveDates.Text == "")
    strErrorMessage += "\nInclusive Dates field is required.";
   if (txtSchoolName.Text == "")
    strErrorMessage += "\nSchool field is required.";

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

  private void frmEmployeeEducationAdd_Load(object sender, EventArgs e)
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
    using (clsEmployeeEducation ed = new clsEmployeeEducation())
    {
     ed.Username = _strUsername;
     ed.EducationLevelCode = cmbLevel.SelectedValue.ToString();
     ed.Course = txtCourse.Text;
     ed.SchoolName = txtSchoolName.Text;
     ed.SchoolAddress = txtSchoolAddress.Text;
     ed.InclusiveDates = txtInclusiveDates.Text;
     ed.Recognition = txtRecognition.Text;
     ed.Complete = (chkComplete.Checked ? "1" : "0");
     intResults = ed.Add();
    }

    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadEducationList();
     if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      ClearFields();
     else
      this.Close();
    }
   }
  }

 }
}
