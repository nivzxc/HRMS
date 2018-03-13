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
 public partial class frmEmployeeChildrenEdit : Form
 {
  private string _strChildCode;
  private string _strEmployeeName;
  private frmEmployeeDetails _frmEmployeeDetails;

  public frmEmployeeChildrenEdit(frmEmployeeDetails pfrmEmployeeDetails)
  {
   _frmEmployeeDetails = pfrmEmployeeDetails;
   InitializeComponent();
  }

  public string ChildCode { set { _strChildCode = value; } get { return _strChildCode; } }
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
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }

  //////////////////////////////////
  ///////// Helper Methods /////////
  //////////////////////////////////

  private void BindRecords()
  {
   txtEmpName.Text = _strEmployeeName;

   clsEmployeeChildren ec = new clsEmployeeChildren();
   ec.ChildCode = _strChildCode;
   ec.Fill();
   txtName.Text = ec.Name;
   dtpBirthDate.Value = ec.Birthdate;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmEmployeeChildrenEdit_Load(object sender, EventArgs e)
  {   
   BindRecords();
   txtName.Focus();
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

    clsEmployeeChildren ec = new clsEmployeeChildren();
    ec.ChildCode = _strChildCode;
    ec.Name = txtName.Text;
    ec.Birthdate = dtpBirthDate.Value;
    intResults = ec.Edit();

    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadChildrenList();
     Close();
    }
   }
  }

 }

}