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
 public partial class frmTimeSheetPeriodList : Form
 {

  public frmTimeSheetPeriodList()
  {
   InitializeComponent();
  }

  public void BindTimesheetPeriodList()
  {
   dgTSPList.AutoGenerateColumns = false;
   dgTSPList.DataSource = clsTimeSheetPeriod.DSGTimeSheetPeriodList();
   dgTSPList.Columns[0].DataPropertyName = "tspcode";
   dgTSPList.Columns[1].DataPropertyName = "tspfrom";
   dgTSPList.Columns[2].DataPropertyName = "tspto";
   dgTSPList.Columns[3].DataPropertyName = "tspdesc";
   dgTSPList.Columns[4].DataPropertyName = "tspmode";
   dgTSPList.Columns[5].DataPropertyName = "postdata";
   dgTSPList.Columns[6].DataPropertyName = "pstatus";
   foreach (DataGridViewRow dgvr in dgTSPList.Rows)
   {
    dgvr.Cells[5].Value = (dgvr.Cells[5].Value.ToString() == "1" ? true : false);
    dgvr.Cells[6].Value = (dgvr.Cells[6].Value.ToString() == "1" ? true : false);
   }
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgTSPList.Rows.Count.ToString());
  }

  private void frmTimeSheetPeriodList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   BindTimesheetPeriodList();
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   Close();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmTimeSheetPeriodInsert pForm = new frmTimeSheetPeriodInsert();
   pForm.FormTimeSheetPeriodList = this;
   pForm.ShowDialog();
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgTSPList.SelectedRows.Count != 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsTimeSheetPeriod tsp = new clsTimeSheetPeriod();
     tsp.TimeSheetPeriodCode = dgTSPList.SelectedRows[0].Cells[0].Value.ToString();
     tsp.Delete();
     BindTimesheetPeriodList();
    }
   }
  }

  private void tbtnModify_Click(object sender, EventArgs e)
  {
   if (dgTSPList.SelectedRows.Count > 0)
   {
    frmTimeSheetPeriodEdit pForm = new frmTimeSheetPeriodEdit();
    pForm.TimesheetPeriodCode = dgTSPList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.FormCaller = FormCallers.TimesheetPeriodList;
    pForm.FormTimeSheetPeriodList = this;
    
    pForm.ShowDialog();
   }
  }

  private void lvTimeSheetPeriod_DoubleClick(object sender, EventArgs e)
  {
   tbtnModify_Click(null, null);
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindTimesheetPeriodList();
  }

  private void tbtnCloseP_Click(object sender, EventArgs e)
  {
   if (dgTSPList.SelectedRows.Count > 0)
   {
    clsTimeSheetPeriod.SetClose(dgTSPList.SelectedRows[0].Cells[0].Value.ToString());
    BindTimesheetPeriodList();
   }
  }

  private void tbtnOpenP_Click(object sender, EventArgs e)
  {
   if (dgTSPList.SelectedRows.Count > 0)
   {
    clsTimeSheetPeriod.SetOpen(dgTSPList.SelectedRows[0].Cells[0].Value.ToString());
    BindTimesheetPeriodList();
   }
  }

  private void frmTimeSheetPeriodList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgTSPList.Rows.Count.ToString());
  }

  private void frmTimeSheetPeriodList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");
  }

  private void dgTSPList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgTSPList.SelectedRows.Count > 0)
   {
    frmTimeSheetPeriodEdit pForm = new frmTimeSheetPeriodEdit();
    pForm.TimesheetPeriodCode = dgTSPList.Rows[e.RowIndex].Cells[0].Value.ToString();
    pForm.FormCaller = FormCallers.TimesheetPeriodList;
    pForm.FormTimeSheetPeriodList = this;

    pForm.ShowDialog();
   }
  }

 }
}
