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
 public partial class frmEmployeeResearchEdit : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strEmployeeName;
  private string _strResearchCode;

  public frmEmployeeResearchEdit(frmEmployeeDetails pfrmEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pfrmEmployeeDetails;
  }

  public string ResearchCode { set { _strResearchCode = value; } get { return _strResearchCode; } }
  public string EmployeeName { set { _strEmployeeName = value; } get { return _strEmployeeName; } }

  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

  private void LoadDetails()
  {
   using (clsEmployeeResearch er = new clsEmployeeResearch(_strResearchCode))
   {
    er.Fill();
    txtTitle.Text = er.Title;
    txtDateCompleted.Text = er.DateCompleted;
    txtRemarks.Text = er.Remarks;
   }

   txtTitle.Focus();
  }

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtTitle.Text == "")
    strErrorMessage = "Title field is required.";
   if (txtDateCompleted.Text == "")
    strErrorMessage += "\nDate Completed field is required.";

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

  private void frmEmployeeResearchEdit_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   LoadDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intResults = 0;
    clsEmployeeResearch er = new clsEmployeeResearch();
    er.ResearchCode = _strResearchCode;
    er.Title = txtTitle.Text;
    er.DateCompleted = txtDateCompleted.Text;
    er.Remarks = txtRemarks.Text;
    intResults = er.Edit();
    if (intResults > 0)
    {
     _frmEmployeeDetails.LoadResearchList();
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
