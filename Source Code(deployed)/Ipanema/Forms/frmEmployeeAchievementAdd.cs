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
 public partial class frmEmployeeAchievementAdd : Form
 {

  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strUsername;
  private string _strEmployeeName;

  public frmEmployeeAchievementAdd(frmEmployeeDetails pfrmEmployeeDetails)
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
   txtAchievement.Text = "";
   txtAchieveDate.Text = "";
   txtDetails.Text = "";

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

  private void frmEmployeeAchievementAdd_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   ClearFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intResults = 0;
    using (clsEmployeeAchievement ea = new clsEmployeeAchievement())
    {
     ea.Username = _strUsername;
     ea.Achievement = txtAchievement.Text;
     ea.AchievementDate = txtAchieveDate.Text;
     ea.Details = txtDetails.Text;
     intResults = ea.Insert();
    }

    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadAchievementList();
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
