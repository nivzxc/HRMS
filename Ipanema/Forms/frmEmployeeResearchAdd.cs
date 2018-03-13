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
 public partial class frmEmployeeResearchAdd : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strUsername;
  private string _strEmployeeName;

  public frmEmployeeResearchAdd(frmEmployeeDetails pfrmEmployeeDetails)
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
   txtTitle.Text = "";
   txtDateCompleted.Text = "";
   txtRemarks.Text = "";

   txtTitle.Focus();
  }

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtTitle.Text == "")
    strErrorMessage = "Title field is required.";
   if (txtDateCompleted.Text == "")
    strErrorMessage += "\nDate Completed is required.";
   if (txtRemarks.Text == "")
    strErrorMessage += "\nRemarks field is required.";

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

  private void frmEmployeeResearchAdd_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   ClearFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intResults = 0;
    using (clsEmployeeResearch er = new clsEmployeeResearch())
    {
     er.Username = _strUsername;
     er.Title = txtTitle.Text;
     er.DateCompleted = txtDateCompleted.Text;
     er.Remarks = txtRemarks.Text;
     intResults = er.Add();
    }

    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadResearchList();
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

  private void groupBox1_Enter(object sender, EventArgs e)
  {

  }

 }
}
