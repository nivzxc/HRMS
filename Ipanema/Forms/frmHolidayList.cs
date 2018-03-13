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
 public partial class frmHolidayList : Form
 {
  public frmHolidayList() { InitializeComponent(); }

  public void BindHolidayList()
  {
   dgHolidayList.AutoGenerateColumns = false;
   dgHolidayList.DataSource = Holiday.DSGFormHolidayList();
   dgHolidayList.Columns[0].DataPropertyName = "holicode";
   dgHolidayList.Columns[1].DataPropertyName = "dateapp";
   dgHolidayList.Columns[2].DataPropertyName = "shftcode";
   dgHolidayList.Columns[3].DataPropertyName = "holidesc";
   
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgHolidayList.Rows.Count.ToString());
  }

  private void frmHolidayList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   BindHolidayList();  
  }

  private void tbtnClose_Click(object sender, EventArgs e) { Close(); }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmHolidayNew pForm = new frmHolidayNew();
   pForm.FormHolidayList = this;
   pForm.ShowDialog();
  }

  private void tbtnModify_Click(object sender, EventArgs e)
  {
   if (dgHolidayList.SelectedRows.Count > 0)
   {
    frmHolidayEdit pForm = new frmHolidayEdit();
    pForm.HolidayCode = dgHolidayList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.FormHolidayList = this;
    pForm.ShowDialog();
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgHolidayList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     Holiday objHoliday = new Holiday();
     objHoliday.HolidayCode = dgHolidayList.SelectedRows[0].Cells[0].Value.ToString();
     objHoliday.Delete();
     this.BindHolidayList();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindHolidayList();
  }

  private void dgHolidayList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgHolidayList.SelectedRows.Count > 0)
   {
    frmHolidayEdit pForm = new frmHolidayEdit();
    pForm.HolidayCode = dgHolidayList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.FormHolidayList = this;
    pForm.ShowDialog();
   }
  }

  private void frmHolidayList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgHolidayList.Rows.Count.ToString());
  }

  private void frmHolidayList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");
  }

 }
}