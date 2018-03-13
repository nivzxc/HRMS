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
 public partial class frmClusterList : Form
 {
  public frmClusterList() { InitializeComponent(); }

  public void BindClusterGrid()
  {
   DataTable tblCluster = clsCluster.GetDataTable();
   dgClusterList.AutoGenerateColumns = false;
   dgClusterList.DataSource = tblCluster;
   dgClusterList.Columns[0].DataPropertyName = "cluscode";
   dgClusterList.Columns[1].DataPropertyName = "clusname";
   dgClusterList.Columns[2].DataPropertyName = "penabled";

   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgClusterList.Rows.Count.ToString());
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmClusterList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   this.BindClusterGrid();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmClusterAdd pForm = new frmClusterAdd();
   pForm.FormClusterList = this;
   pForm.ShowDialog();
   this.Cursor = Cursors.Default;
  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {
   if (dgClusterList.SelectedRows.Count > 0)
   {
    this.Cursor = Cursors.WaitCursor;
    frmClusterEdit pForm = new frmClusterEdit();
    pForm.ClusterCode = dgClusterList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.FormClusterList = this;
    pForm.ShowDialog();
    this.Cursor = Cursors.Default;
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgClusterList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsCluster cluster = new clsCluster();
     cluster.ClusterCode = dgClusterList.SelectedRows[0].Cells[0].Value.ToString();
     cluster.Delete();
     this.BindClusterGrid();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   this.BindClusterGrid();
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnEnable_Click(object sender, EventArgs e)
  {
   if (dgClusterList.SelectedRows.Count > 0)
   {
    clsCluster.Enable(dgClusterList.SelectedRows[0].Cells[0].Value.ToString());
    this.BindClusterGrid();
   }
  }

  private void tbtnDisable_Click(object sender, EventArgs e)
  {
   if (dgClusterList.SelectedRows.Count > 0)
   {
    clsCluster.Disable(dgClusterList.SelectedRows[0].Cells[0].Value.ToString());
    BindClusterGrid();
   }
  }

  private void dgClusterList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   tbtnEdit_Click(null, null);
  }

  private void btnMembers_Click(object sender, EventArgs e)
  {
   if (dgClusterList.SelectedRows.Count > 0)
   {
    this.Cursor = Cursors.WaitCursor;
    frmClusterMembers pForm = new frmClusterMembers();
    pForm.ClusterCode = dgClusterList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
    this.Cursor = Cursors.Default;
   }
  }

  private void frmClusterList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgClusterList.Rows.Count.ToString());
  }

  private void frmClusterList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");
  }

 }
}