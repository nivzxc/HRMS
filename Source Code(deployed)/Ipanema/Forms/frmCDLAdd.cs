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
 public partial class frmCDLAdd : Form
 {
  public frmCDLAdd() { InitializeComponent(); }

  private frmCDLList _frmCDLList;
  public frmCDLList FormCDLList { set { _frmCDLList = value; } get { return _frmCDLList; } }

  private void InitializeFields()
  {
   dtpDateApplied.Value = DateTime.Now;
   txtReason.Text = "";
  }

  private bool IsCorrectData()
  {
   string strErrorMessage = "";

   if (txtReason.Text == "")
    strErrorMessage = "Reason field is required.";

   if (strErrorMessage != "")
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

   return strErrorMessage == "";
  }


  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmCDLAdd_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (CDL objCDL = new CDL())
    {
     objCDL.DateApplied = dtpDateApplied.Value;
     objCDL.Reason = txtReason.Text;
     objCDL.Insert();
    }
    this.Close();
    _frmCDLList.LoadCDLList();
   }
  }

 }
}
