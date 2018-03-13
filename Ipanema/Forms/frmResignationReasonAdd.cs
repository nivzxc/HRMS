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
 public partial class frmResignationReasonAdd : Form
 {
  public frmResignationReasonAdd() { InitializeComponent(); }

  private frmResignationReasonList _frmResignationReasonList;
  private frmEmployeeDetails _frmEmployeeDetails;
  private FormCallers _FormCaller;

  public frmResignationReasonList FormResignationList { set { _frmResignationReasonList = value; } get { return _frmResignationReasonList; } }
  public frmEmployeeDetails FormEmployeeDetails { set { _frmEmployeeDetails = value; } get { return _frmEmployeeDetails; } }
  public FormCallers FormCaller { set { _FormCaller = value; } get { return _FormCaller; } }

  private void ClearFields()
  {
   txtCode.Text = clsResignationReason.GenerateCode();
   txtReason.Text = "";
   chkEnabled.Checked = false;
   txtReason.Focus();
  }

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtReason.Text == "")
    strErrorMessage += "\nResignation reason field is required.";

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

  private void frmResignationReasonAdd_Load(object sender, EventArgs e)
  {
   ClearFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intAffected = 0;
    using (clsResignationReason reason = new clsResignationReason())
    {
     reason.ResignationReasonName = txtReason.Text;
     reason.Enabled = (chkEnabled.Checked ? "1" : "0");
     intAffected = reason.Insert();
    }
    if (intAffected > 0)
    {
     switch (_FormCaller)
     {
      case FormCallers.ResignationReasonList:
       _frmResignationReasonList.BindResignationReasonList();
       break;
      case FormCallers.EmployeeDetails:
       _frmEmployeeDetails.BindResignationReason();
       break;
     }
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
