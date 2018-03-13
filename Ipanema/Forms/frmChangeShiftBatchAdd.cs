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
 public partial class frmChangeShiftBatchAdd : Form
 {
  public frmChangeShiftBatchAdd() { InitializeComponent(); }

  private frmChangeShiftBatchList _frmChangeShiftBatchList;
  public frmChangeShiftBatchList FormChangeShiftBatchList { set { _frmChangeShiftBatchList = value; } get { return _frmChangeShiftBatchList; } }

  private bool IsCorrectData()
  {
   string strErrorMessage = "";

   if (txtReason.Text == "")
    strErrorMessage = "Reason is required.";

   if(clsChangeShiftBatch.CodeExist(txtChangeShiftBatchCode.Text))
    strErrorMessage = "Code already exist.";

   if (strErrorMessage != "")
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

   return strErrorMessage == "";
  }

  private void InitializeFields()
  {
   cmbShiftCode.DataSource = clsShift.GetDdlDS();
   dtpApplicationDate.Value = DateTime.Now;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmChangeShiftBatchAdd_Load(object sender, EventArgs e)
  {
   InitializeFields();   
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (clsChangeShiftBatch csb = new clsChangeShiftBatch())
    {
     csb.ChangeScheduleBatchCode = txtChangeShiftBatchCode.Text;
     csb.ShiftCode = cmbShiftCode.SelectedValue.ToString();
     csb.ApplicationDate = dtpApplicationDate.Value;
     csb.Reason = txtReason.Text;
     csb.Insert();
    }
    _frmChangeShiftBatchList.BindChangeShiftGrid();
    this.Close();    
   }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void dtpApplicationDate_ValueChanged(object sender, EventArgs e)
  {
   txtChangeShiftBatchCode.Text = dtpApplicationDate.Value.ToString("yyMMdd");
  }

 }
}