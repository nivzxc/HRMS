using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using HRMS;

namespace Ipanema.Forms
{
 public partial class frmShiftList : Form
 {
  public frmShiftList() { InitializeComponent(); }

  public void BindShiftList()
  {
   dgShiftList.AutoGenerateColumns = false;
   dgShiftList.DataSource = clsShift.DSGFormShiftList(); ;
   dgShiftList.Columns[0].DataPropertyName = "ShiftCode";
   dgShiftList.Columns[1].DataPropertyName = "ShiftMode";
   dgShiftList.Columns[2].DataPropertyName = "TotalHours";
   dgShiftList.Columns[3].DataPropertyName = "TimeStart";
   dgShiftList.Columns[4].DataPropertyName = "TimeHalf";
   dgShiftList.Columns[5].DataPropertyName = "TimeEnd";
   dgShiftList.Columns[6].DataPropertyName = "BreakStart";
   dgShiftList.Columns[7].DataPropertyName = "BreakEnd";
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgShiftList.Rows.Count.ToString());   
  }

  private void frmShiftList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   BindShiftList();
  }

  private void tbtnClose_Click(object sender, EventArgs e) { Close(); }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmShiftNew pForm = new frmShiftNew(this);
   pForm.FormCaller = FormCallers.ShiftList;
   pForm.ShowDialog();
  }

  private void tbtnModify_Click(object sender, EventArgs e)
  {
   if (dgShiftList.SelectedRows.Count > 0)
   {
    frmShiftModify pForm = new frmShiftModify(this);
    pForm.ShiftCode = dgShiftList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (MessageBox.Show("Warning: \nDeleting shift settings might cause discrepancies on employee's schedule associated with it. \nIt is advisable to disable the shift than to delete it.\n\nAre you sure to continue?", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
   {
    if (dgShiftList.SelectedRows.Count > 0)
    {
     clsShift shift = new clsShift();
     shift.ShiftCode = dgShiftList.SelectedRows[0].Cells[0].Value.ToString();
     shift.Delete();
     BindShiftList();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindShiftList();
  }

  private void dgShiftList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgShiftList.SelectedRows.Count > 0)
   {
    frmShiftModify pForm = new frmShiftModify(this);
    pForm.ShiftCode = dgShiftList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

  private void frmShiftList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgShiftList.Rows.Count.ToString());   
  }

  private void frmShiftList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");   
  }

  //private void lvShiftList_MouseMove(object sender, MouseEventArgs e)
  //{
  // try
  // {
  //  ttRemarks.SetToolTip(lvShiftList, lvShiftList.GetItemAt(e.X, e.Y).SubItems[0].Tag.ToString());
  // }
  // catch { }
  //}


 }
}