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
 public partial class frmEmployeeDependentEdit : Form
 {
  private string _strUsername;
  private string _strEmployeeName;
  private string _strDependentCode;
  private frmEmployeeDetails _frmEmployeeDetails;
  private FormCallers _FormCaller;

  public frmEmployeeDependentEdit(frmEmployeeDetails pEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pEmployeeDetails;
  }

  public string Username { set { _strUsername = value; } }
  public string EmployeeName { set { _strEmployeeName = value; } }
  public string DependentCode { set { _strDependentCode = value; } }
  public FormCallers FormCaller { set { _FormCaller = value; } }

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

  private void BindRecord()
  {
   using (clsEmployeeDependent ed = new clsEmployeeDependent())
   {
    ed.DependentCode = _strDependentCode;
    ed.Fill();
    txtEmpName.Text = _strEmployeeName;
    txtName.Text = ed.Name;
    dtpBirthDate.Value = ed.Birthdate;
    txtRelation.Text = ed.Relation;
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmEmployeeDependentEdit_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   txtName.Focus();
   BindRecord();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (ValidateEntries())
   {
    int intResults = 0;
    using (clsEmployeeDependent ed = new clsEmployeeDependent())
    {
     ed.DependentCode = _strDependentCode;
     ed.Name = txtName.Text;
     ed.Birthdate = dtpBirthDate.Value;
     ed.Relation = txtRelation.Text;
     intResults = ed.Edit();
    }

    if (intResults > 0)
    {
     switch (_FormCaller)
     {
      case FormCallers.EmployeeDetails:
       _frmEmployeeDetails.LoadDependentsList();
       break;
     }
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
