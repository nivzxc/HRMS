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
 public partial class frmEmployeeAchievementEdit : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strEmployeeName;
  private string _strAchievementCode;

  public frmEmployeeAchievementEdit(frmEmployeeDetails pfrmEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pfrmEmployeeDetails;
  }

  public string AchievementCode { set { _strAchievementCode = value; } get { return _strAchievementCode; } }
  public string EmployeeName { set { _strEmployeeName = value; } get { return _strEmployeeName; } }

  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

  private void LoadDetails()
  {
   using (clsEmployeeAchievement ea = new clsEmployeeAchievement(_strAchievementCode))
   {
    ea.Fill();
    txtAchievement.Text = ea.Achievement;
    txtAchieveDate.Text = ea.AchievementDate;
    txtDetails.Text = ea.Details;
   }

   txtAchievement.Focus();
  }

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtAchievement.Text == "")
    strErrorMessage = "Achievement field is required.";
   if (txtAchieveDate.Text == "")
    strErrorMessage += "\nInvalid Date.";
   if (txtDetails.Text == "")
    strErrorMessage += "\nDetails field is required.";

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

  private void frmEmployeeAchievementEdit_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   LoadDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intResults = 0;
    clsEmployeeAchievement ea = new clsEmployeeAchievement();
    ea.AchievementCode = _strAchievementCode;
    ea.Achievement = txtAchievement.Text;
    ea.AchievementDate = txtAchieveDate.Text;
    ea.Details = txtDetails.Text;
    intResults = ea.Update();
    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadAchievementList();
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