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
 public partial class frmResignationReasonEdit : Form
 {
  public frmResignationReasonEdit() { InitializeComponent(); }

  private string _strResignationReasonCode;
  private frmResignationReasonList _frmResignationReasonList;

  public string ResignationReasonCode { set { _strResignationReasonCode = value; } get { return _strResignationReasonCode; } }
  public frmResignationReasonList FormResignationReasonList { set { _frmResignationReasonList = value; } get { return _frmResignationReasonList; } }

  private void BindResignationFields()
  {
   txtCode.Text = _strResignationReasonCode;
   using (clsResignationReason reason = new clsResignationReason())
   {
    reason.ResignationReasonCode = _strResignationReasonCode;
    reason.Fill();
    txtReason.Text = reason.ResignationReasonName;
    chkEnabled.Checked = (reason.Enabled == "1");
   }
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtReason.Text == "")
    strErrorMessage += "\nResignation reason is required.";

   if (strErrorMessage != "")
   {
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmResignationReasonEdit_Load(object sender, EventArgs e)
  {
   this.BindResignationFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (this.IsCorrectData())
   {
    using (clsResignationReason reason = new clsResignationReason())
    {
     reason.ResignationReasonCode = _strResignationReasonCode;
     reason.Fill();
     reason.ResignationReasonName = txtReason.Text;
     reason.Enabled = (chkEnabled.Checked ? "1" : "0");
     if (reason.Update() > 0)
     {
      _frmResignationReasonList.BindResignationReasonList();
      this.Close();
     }
    }
   }
  }

 }
}