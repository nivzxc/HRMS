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
 public partial class frmScheduleList : Form
 {

  public frmScheduleList() { InitializeComponent(); }

  public void BindScheduleList()
  {
   dgScheduleList.AutoGenerateColumns = false;
   dgScheduleList.DataSource = clsSchedule.DSGScheduleList();
   dgScheduleList.Columns[0].DataPropertyName = "schdcode";
   dgScheduleList.Columns[1].DataPropertyName = "monshift";
   dgScheduleList.Columns[2].DataPropertyName = "tueshift";
   dgScheduleList.Columns[3].DataPropertyName = "wedshift";
   dgScheduleList.Columns[4].DataPropertyName = "thushift";
   dgScheduleList.Columns[5].DataPropertyName = "frishift";
   dgScheduleList.Columns[6].DataPropertyName = "satshift";
   dgScheduleList.Columns[7].DataPropertyName = "sunshift";
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgScheduleList.Rows.Count.ToString());
  }

  private void frmScheduleList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   BindScheduleList();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmScheduleNew pForm = new frmScheduleNew(this);
   pForm.FormCaller = FormCallers.ScheduleList;
   pForm.ShowDialog();
  }

  private void tbtnModify_Click(object sender, EventArgs e)
  {
   if (dgScheduleList.SelectedRows.Count != 0)
   {
    frmScheduleModify pForm = new frmScheduleModify();
    pForm.FormScheduleList = this;
    pForm.ScheduleCode = dgScheduleList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindScheduleList();
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgScheduleList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show("Warning: \nDeleting schedule settings might cause discrepancies on employee's schedule associated with it. \nIt is advisable to disable the shift than to delete it.\n\nAre you sure to continue?", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
    {
     clsSchedule schedule = new clsSchedule();
     schedule.ScheduleCode = dgScheduleList.SelectedRows[0].Cells[0].Value.ToString();
     schedule.Delete();
     BindScheduleList();
    }
   }
  }

  private void frmScheduleList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgScheduleList.Rows.Count.ToString());
  }

  private void frmScheduleList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");
  }

  private void dgScheduleList_DoubleClick(object sender, EventArgs e)
  {
   if (dgScheduleList.SelectedRows.Count > 0)
   {
    frmScheduleModify pForm = new frmScheduleModify();
    pForm.FormScheduleList = this;
    pForm.ScheduleCode = dgScheduleList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

 }
}
