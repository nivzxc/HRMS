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
 public partial class frmEmployeeDependentAdd : Form
 {
  private string _strUsername;
  private string _strEmployeeName;
  private frmEmployeeDetails _frmEmployeeDetails;

  public frmEmployeeDependentAdd(frmEmployeeDetails pEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pEmployeeDetails;
  }

  public string Username { set { _strUsername = value; } }
  public string EmployeeName { set { _strEmployeeName = value; } }

  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

  private bool ValidateEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (dtpBirthDate.Value >= DateTime.Now)
    strErrorMessage += "Invalid birth date entry.\n";
   if (txtName.Text == "")
    strErrorMessage += "Dependent name field is required.\n";
   if (txtRelation.Text == "")
    strErrorMessage += "Relation field is required.\n";

   if (strErrorMessage != "")
   {
    MessageBox.Show("You have invalid entry(s):\n\n" + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }

  private void ClearFields()
  {
   txtName.Text = "";
   dtpBirthDate.Value = DateTime.Now;
   txtRelation.Text = "";
   txtName.Focus();
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmEmployeeDependentAdd_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   txtName.Focus();
   ClearFields();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (ValidateEntries())
   {
    int intResults = 0;
    using (clsEmployeeDependent ed = new clsEmployeeDependent())
    {
     ed.Username = _strUsername;
     ed.Name = txtName.Text;
     ed.Birthdate = dtpBirthDate.Value;
     ed.Relation = txtRelation.Text;
     intResults = ed.Add();
    }

    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadDependentsList();
     if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      ClearFields();
     else
      this.Close();
    }
   }
  }

 }
}
