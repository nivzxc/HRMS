using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HRMS;
using CarlosAg.ExcelXmlWriter;

namespace Ipanema.Forms
{
 public partial class frmLeaveList : Form
 {
  public frmLeaveList() { InitializeComponent(); }

  public void BindLeaveList()
  {
   dgLeaveList.AutoGenerateColumns = false;
   dgLeaveList.DataSource = LeaveApplication.GetDSGFormLeaveList(txtRequestor.Text, txtReason.Text, cmbStatus.SelectedValue.ToString(), cmbLeaveType.SelectedValue.ToString(), dtpFrom.Value.Date, clsDateTime.ChangeTimeToEnd(dtpTo.Value));
   dgLeaveList.Columns[0].DataPropertyName = "leavcode";
   dgLeaveList.Columns[1].DataPropertyName = "status";
   dgLeaveList.Columns[2].DataPropertyName = "requestor";
   dgLeaveList.Columns[3].DataPropertyName = "leavtype";   
   dgLeaveList.Columns[4].DataPropertyName = "datefile";
   dgLeaveList.Columns[5].DataPropertyName = "datestart";
   dgLeaveList.Columns[6].DataPropertyName = "dateend";
   dgLeaveList.Columns[7].DataPropertyName = "unit";
   dgLeaveList.Columns[8].DataPropertyName = "approver";
   dgLeaveList.Columns[9].DataPropertyName = "reason";
   dgLeaveList.Columns[10].DataPropertyName = "statuscode";
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgLeaveList.Rows.Count.ToString());
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmLeaveList_Load(object sender, EventArgs e)
  {
   cmbLeaveType.DataSource = LeaveApplicationTypes.GetDSLAll();
   cmbLeaveType.ValueMember = "pvalue";
   cmbLeaveType.DisplayMember = "ptext";

   // Load the current time sheet period
   string strCurrentTimeSheetPeriod = clsTimeSheetPeriod.GetCurrentTimeSheetPeriod();
   using (clsTimeSheetPeriod tsp = new clsTimeSheetPeriod(strCurrentTimeSheetPeriod))
   {
    tsp.Fill();
    dtpFrom.Value = tsp.PeriodFrom;
    dtpTo.Value = tsp.PeriodTo;
   }

   cmbStatus.DataSource = LeaveApplication.DdlDsStatusAll();
   cmbStatus.ValueMember = "pvalue";
   cmbStatus.DisplayMember = "ptext";

   BindLeaveList();
   this.WindowState = FormWindowState.Maximized;
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindLeaveList();
  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {
   if (dgLeaveList.SelectedRows.Count > 0)
   {
    frmLeaveEdit pForm = new frmLeaveEdit();
    pForm.LeaveCode = dgLeaveList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.FormLeaveList = this;
    pForm.ShowDialog();
   }
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmLeaveNew pForm = new frmLeaveNew();
   pForm.FormLeaveList = this;
   pForm.ShowDialog();
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgLeaveList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     LeaveApplication leave = new LeaveApplication();
     leave.LeaveCode = dgLeaveList.SelectedRows[0].Cells[0].Value.ToString();
     leave.DeleteAdmin();
     BindLeaveList();
    }
   }
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void dgLeaveList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
  {
   try
   {
    foreach (DataGridViewRow drw in dgLeaveList.Rows)
     drw.DefaultCellStyle.BackColor = LeaveApplication.GetLVBGColor(drw.Cells[10].Value.ToString());
   }
   catch 
   { 
   }
  }

  private void dgLeaveList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   try
   {
    if (dgLeaveList.SelectedRows.Count > 0)
    {
     frmLeaveEdit pForm = new frmLeaveEdit();
     pForm.LeaveCode = dgLeaveList.Rows[e.RowIndex].Cells[0].Value.ToString();
     pForm.FormLeaveList = this;
     pForm.ShowDialog();
    }
   }
   catch { }
  }

  private void frmLeaveList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgLeaveList.Rows.Count.ToString());
  }

  private void frmLeaveList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");
  }

  private void tbtnExportExcel_Click(object sender, EventArgs e)
  {
   sfdExportExcel.FileName = "LeaveApplications_" + DateTime.Now.ToString("yyMMdd_HHmmss") + ".xls";
   sfdExportExcel.ShowDialog();
  }

  private void sfdExportExcel_FileOk(object sender, CancelEventArgs e)
  {
   Workbook xlsBook = new Workbook();
   Worksheet xlsSheet = xlsBook.Worksheets.Add("EmployeeeList");
   WorksheetRow xlsRow = xlsSheet.Table.Rows.Add();
   xlsRow.Cells.Add("Leave Code");
   xlsRow.Cells.Add("Status");
   xlsRow.Cells.Add("Requestor");
   xlsRow.Cells.Add("Leave Type");
   xlsRow.Cells.Add("Date File");
   xlsRow.Cells.Add("Date Start");
   xlsRow.Cells.Add("Date End");
   xlsRow.Cells.Add("Unit");
   xlsRow.Cells.Add("Approver");
   xlsRow.Cells.Add("Reason");

   foreach (DataGridViewRow drw in dgLeaveList.Rows)
   {
    xlsRow = xlsSheet.Table.Rows.Add();
    xlsRow.Cells.Add(drw.Cells[0].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[1].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[2].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[3].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[4].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[5].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[6].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[7].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[8].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[9].Value.ToString());
   }
   xlsBook.Save(sfdExportExcel.FileName);
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
   BindLeaveList();
  }

 }
}