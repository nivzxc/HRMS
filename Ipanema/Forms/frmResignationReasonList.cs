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
 public partial class frmResignationReasonList : Form
 {
  public frmResignationReasonList() { InitializeComponent(); }

  public void BindResignationReasonList()
  {
   dgResignationReasonList.AutoGenerateColumns = false;
   dgResignationReasonList.DataSource = clsResignationReason.DSGResignationReasonList(); ;
   dgResignationReasonList.Columns[0].DataPropertyName = "rsgncode";
   dgResignationReasonList.Columns[1].DataPropertyName = "rsgnname";
   dgResignationReasonList.Columns[2].DataPropertyName = "enabled";
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgResignationReasonList.Rows.Count.ToString());
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmResignationReasonList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   BindResignationReasonList();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.AppStarting;
   frmResignationReasonAdd pForm = new frmResignationReasonAdd();
   pForm.FormCaller = FormCallers.ResignationReasonList;
   pForm.FormResignationList = this;
   pForm.ShowDialog();
   this.Cursor = Cursors.Default;
  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {
   if (dgResignationReasonList.SelectedRows.Count > 0)
   {
    this.Cursor = Cursors.AppStarting;
    frmResignationReasonEdit pForm = new frmResignationReasonEdit();
    pForm.ResignationReasonCode = dgResignationReasonList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.FormResignationReasonList = this;
    pForm.ShowDialog();
    this.Cursor = Cursors.Default;
   }
  }

  private void dgResignationReasonList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgResignationReasonList.SelectedRows.Count > 0)
   {
    this.Cursor = Cursors.AppStarting;
    frmResignationReasonEdit pForm = new frmResignationReasonEdit();
    pForm.ResignationReasonCode = dgResignationReasonList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.FormResignationReasonList = this;
    pForm.ShowDialog();
    this.Cursor = Cursors.Default;
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgResignationReasonList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     using (clsResignationReason crr = new clsResignationReason())
     {
      crr.ResignationReasonCode = dgResignationReasonList.SelectedRows[0].Cells[0].Value.ToString();
      crr.Delete();
     }
     BindResignationReasonList();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindResignationReasonList();
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}