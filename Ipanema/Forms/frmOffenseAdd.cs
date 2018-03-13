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
 public partial class frmOffenseAdd : Form
 {
  private frmOffenseList _frmOffenseList;
  public frmOffenseList FormOffenseList { get { return _frmOffenseList; } set { _frmOffenseList = value; } }

  public frmOffenseAdd() { InitializeComponent(); }

  private void InitializeFields()
  {
   cmbEmployeeName.DataSource = Employee.DSLActive();
   cmbEmployeeName.ValueMember = "pvalue";
   cmbEmployeeName.DisplayMember = "ptext";

   txtDetails.Text = "";

   cmbClass.DataSource = clsOffense.GetDSLClass();
   cmbClass.ValueMember = "pvalue";
   cmbClass.DisplayMember = "ptext";

   cmbEmployeeName.Focus();
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtDetails.Text == "")
    strErrorMessage += "\nDetails is required.";

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

  private void frmOffenseAdd_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (clsOffense objOffense = new clsOffense())
    {
     objOffense.Username = cmbEmployeeName.SelectedValue.ToString();
     objOffense.Details = txtDetails.Text;
     objOffense.ClassCode = cmbClass.SelectedValue.ToString();
     objOffense.DateStart = dtpDateStart.Value;
     objOffense.DateEnd = dtpDateEnd.Value;
     objOffense.Enabled = "1";
     objOffense.CreateBy = HRMSCore.Username;
     objOffense.ModifyBy = HRMSCore.Username;
     if (objOffense.Insert() > 0)
     {
      _frmOffenseList.BindOffenseList();
      if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
       InitializeFields();
      else
       this.Close();
     }
     else
     {
      MessageBox.Show(clsMessageBox.MessageBoxErrorAdd, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error);
     }
    }
   }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}