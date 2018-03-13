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
 public partial class frmEmployeeEducationEdit : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strEducationCode;
  private string _strEmployeeName;

  public frmEmployeeEducationEdit(frmEmployeeDetails pfrmEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pfrmEmployeeDetails;
  }

  public string EducationCode { set { _strEducationCode = value; } get { return _strEducationCode; } }
  public string EmployeeName { set { _strEmployeeName = value; } get { return _strEmployeeName; } }

  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

  private void LoadDetails()
  {
   cmbLevel.DataSource = EducationLevel.GetDSL();
   cmbLevel.DisplayMember = "pText";
   cmbLevel.ValueMember = "pValue";

   using (clsEmployeeEducation ed = new clsEmployeeEducation(_strEducationCode))
   {
    ed.Fill();
    cmbLevel.SelectedValue = ed.EducationLevelCode;
    txtCourse.Text = ed.Course;
    txtInclusiveDates.Text = ed.InclusiveDates;
    txtRecognition.Text = ed.Recognition;
    txtSchoolName.Text = ed.SchoolName;
    txtSchoolAddress.Text = ed.SchoolAddress;
    chkComplete.Checked = (ed.Complete == "1" ? true : false);
   }

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

  private void frmEmployeeEducationEdit_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   LoadDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intResults = 0;

    clsEmployeeEducation ed = new clsEmployeeEducation();
    ed.EducationCode = _strEducationCode;
    ed.EducationLevelCode = cmbLevel.SelectedValue.ToString();
    ed.Course = txtCourse.Text;
    ed.InclusiveDates = txtInclusiveDates.Text;
    ed.Recognition = txtRecognition.Text;
    ed.SchoolName = txtSchoolName.Text;
    ed.SchoolAddress = txtSchoolAddress.Text;
    ed.Complete = (chkComplete.Checked ? "1" : "0");
    intResults = ed.Edit();

    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadEducationList();
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
