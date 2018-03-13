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
 public partial class frmEmployeeChildrenAdd : Form
 {

  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strUsername;
  private string _strEmployeeName;

  public frmEmployeeChildrenAdd(frmEmployeeDetails pfrmEmployeeDetails)
  {
   _frmEmployeeDetails = pfrmEmployeeDetails;
   InitializeComponent();
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

   if (txtName.Text == "")
    strErrorMessage = "Child's name field is required.";

   if (dtpBirthDate.Value >= DateTime.Now)
    strErrorMessage += "\nInvalid birth date entry.";

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
   txtName.Focus();
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intResults = 0;

    clsEmployeeChildren ec = new clsEmployeeChildren();
    ec.Username = _strUsername;
    ec.Name = txtName.Text;    
    ec.Birthdate = dtpBirthDate.Value;
    intResults = ec.Add();

    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadChildrenList();
     if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      ClearFields();
     else
      this.Close();
    }
   }
  }

  private void frmEmployeeChildrenAdd_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   txtName.Focus();
  }  

 }
}
