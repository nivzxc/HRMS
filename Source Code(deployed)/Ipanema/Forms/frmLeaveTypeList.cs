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
 public partial class frmLeaveTypeList : Form
 {
  public frmLeaveTypeList() { InitializeComponent(); }

  public void BindLeaveTypeList()
  {
   DataTable tblCluster = LeaveApplicationTypes.DSGLeaveTypeList();
   dgLeaveTypeList.AutoGenerateColumns = false;
   dgLeaveTypeList.DataSource = tblCluster;
   dgLeaveTypeList.Columns[0].DataPropertyName = "leavtype";
   dgLeaveTypeList.Columns[1].DataPropertyName = "ltdesc";
   dgLeaveTypeList.Columns[2].DataPropertyName = "withpay";
   dgLeaveTypeList.Columns[3].DataPropertyName = "maxbal";
   dgLeaveTypeList.Columns[4].DataPropertyName = "hasbal";
   dgLeaveTypeList.Columns[5].DataPropertyName = "pstatus";
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgLeaveTypeList.Rows.Count.ToString());
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmLeaveTypeList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   BindLeaveTypeList();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmLeaveTypeNew pForm = new frmLeaveTypeNew();
   pForm.FormLeaveTypeList = this;
   pForm.ShowDialog();
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgLeaveTypeList.Rows.Count != 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     LeaveApplicationTypes lt = new LeaveApplicationTypes();
     lt.LeaveTypeCode = dgLeaveTypeList.SelectedRows[0].Cells[0].Value.ToString();
     lt.Delete();
     BindLeaveTypeList();
    }
   }
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindLeaveTypeList();
  }

  private void tbtnModify_Click(object sender, EventArgs e)
  {
   if (dgLeaveTypeList.Rows.Count != 0)
   {
    frmLeaveTypeEdit pForm = new frmLeaveTypeEdit();
    pForm.FormLeaveTypeList = this;
    pForm.LeaveTypeCode = dgLeaveTypeList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

  private void frmLeaveTypeList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgLeaveTypeList.Rows.Count.ToString());
  }

  private void frmLeaveTypeList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");
  }

  private void dgLeaveTypeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgLeaveTypeList.Rows.Count != 0)
   {
    frmLeaveTypeEdit pForm = new frmLeaveTypeEdit();
    pForm.FormLeaveTypeList = this;
    pForm.LeaveTypeCode = dgLeaveTypeList.Rows[e.RowIndex].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

  private void dgLeaveTypeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {

  }

 }
}
