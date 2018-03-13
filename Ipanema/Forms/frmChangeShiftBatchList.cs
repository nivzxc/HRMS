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
 public partial class frmChangeShiftBatchList : Form
 {
  public frmChangeShiftBatchList() { InitializeComponent(); }

  public void BindChangeShiftGrid()
  {
   DataTable tblChangeShift = clsChangeShiftBatch.GetDataTable();
   dgChangeShiftList.AutoGenerateColumns = false;
   dgChangeShiftList.DataSource = tblChangeShift;
   dgChangeShiftList.Columns[0].DataPropertyName = "csbcode";
   dgChangeShiftList.Columns[1].DataPropertyName = "shftcode";
   dgChangeShiftList.Columns[2].DataPropertyName = "appdate";
   dgChangeShiftList.Columns[3].DataPropertyName = "preason";

   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgChangeShiftList.Rows.Count.ToString());
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmChangeShiftBatchList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   this.BindChangeShiftGrid();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.AppStarting;
   frmChangeShiftBatchAdd pForm = new frmChangeShiftBatchAdd();
   pForm.FormChangeShiftBatchList = this;
   pForm.ShowDialog();
   this.Cursor = Cursors.Default;
  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {   
   if (dgChangeShiftList.Rows.Count > 0)
   {
    this.Cursor = Cursors.AppStarting;
    frmChangeShiftBatchEdit pForm = new frmChangeShiftBatchEdit();
    pForm.FormChangeShiftBatchList = this;
    pForm.ChangeShiftBatchCode = dgChangeShiftList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
    this.Cursor = Cursors.Default;
   }   
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgChangeShiftList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsChangeShiftBatch changeshift = new clsChangeShiftBatch();
     changeshift.ChangeScheduleBatchCode = dgChangeShiftList.SelectedRows[0].Cells[0].Value.ToString();
     changeshift.Delete();
     this.BindChangeShiftGrid();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindChangeShiftGrid();
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void dgChangeShiftList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   tbtnEdit_Click(null, null);
  }

  private void frmChangeShiftBatchList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgChangeShiftList.Rows.Count.ToString());
  }

  private void frmChangeShiftBatchList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");
  }

 }
}