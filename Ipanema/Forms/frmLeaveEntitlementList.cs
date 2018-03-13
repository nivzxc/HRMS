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
 public partial class frmLeaveEntitlementList : Form
 {
     private mdiIpanema _frmMdiCaller;

  public frmLeaveEntitlementList() { InitializeComponent(); }
  public mdiIpanema FormMdiCaller { get { return _frmMdiCaller; } set { _frmMdiCaller = value; } }

  public void BindLeaveBalanceList()
  {
   Cursor.Current = Cursors.WaitCursor;
   string strWhere = "WHERE username IN (SELECT username FROM HR.Employees WHERE lastname LIKE '" + txtLastName.Text.Replace("'", "") + "%') ";

   if (cmbLeaveType.Items.Count > 0)
    if (cmbLeaveType.SelectedValue.ToString() != "ALL")
     strWhere += "AND leavtype='" + cmbLeaveType.SelectedValue.ToString() + "' ";

   if (cmbStatus.Items.Count > 0)
    if (cmbStatus.SelectedValue.ToString() != "ALL")
     strWhere += "AND pstatus='" + cmbStatus.SelectedValue.ToString() + "' ";

   dgEntitlementList.AutoGenerateColumns = false;
   dgEntitlementList.DataSource = LeaveApplicationBalance.DSGFormLeaveEntitlementList(strWhere);
   dgEntitlementList.Columns[0].DataPropertyName = "Username";
   dgEntitlementList.Columns[1].DataPropertyName = "LeaveTypeCode";
   dgEntitlementList.Columns[2].DataPropertyName = "EmployeeName";
   dgEntitlementList.Columns[3].DataPropertyName = "LeaveType";
   dgEntitlementList.Columns[4].DataPropertyName = "Entitled";
   dgEntitlementList.Columns[5].DataPropertyName = "Used";
   dgEntitlementList.Columns[6].DataPropertyName = "Balance";
   dgEntitlementList.Columns[7].DataPropertyName = "Status";

   foreach (DataGridViewRow dgvr in dgEntitlementList.Rows)
    dgvr.Cells[7].Value = (dgvr.Cells[7].Value.ToString() == "1" ? "Enabled" : "Disabled");
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgEntitlementList.Rows.Count.ToString());
   
   Cursor.Current = Cursors.Default;
  }

  ////////////////////////////////
  ///////// Forms Events /////////
  ////////////////////////////////

  private void frmLeaveEntitlementList_Load(object sender, EventArgs e)
  {
   cmbLeaveType.DataSource = LeaveApplicationTypes.GetDSLActiveAll();
   cmbLeaveType.ValueMember = "pvalue";
   cmbLeaveType.DisplayMember = "ptext";

   cmbStatus.DataSource = LeaveApplicationBalance.DdlDsStatusAll();
   cmbStatus.ValueMember = "pvalue";
   cmbStatus.DisplayMember = "ptext";

   BindLeaveBalanceList();

   this.WindowState = FormWindowState.Maximized;
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmLeaveBalanceNew pForm = new frmLeaveBalanceNew();
   pForm.FormCaller = FormCallers.LeaveEntitlementList;
   pForm.FormLeaveEntitlementList = this;
   pForm.ShowDialog();
  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {
   if (dgEntitlementList.SelectedRows.Count > 0)
   {
    frmLeaveBalanceEdit pForm = new frmLeaveBalanceEdit();
    pForm.Username = dgEntitlementList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.LeaveTypeCode = dgEntitlementList.SelectedRows[0].Cells[1].Value.ToString();
    pForm.FormCaller = FormCallers.LeaveEntitlementList;
    pForm.FormLeaveEntitlementList = this;
    pForm.ShowDialog();
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgEntitlementList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     LeaveApplicationBalance lb = new LeaveApplicationBalance();
     lb.Username = dgEntitlementList.SelectedRows[0].Cells[0].Value.ToString();
     lb.LeaveTypeCode = dgEntitlementList.SelectedRows[0].Cells[1].Value.ToString();
     lb.Delete();
     BindLeaveBalanceList();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindLeaveBalanceList();
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnActivate_Click(object sender, EventArgs e)
  {
   foreach (DataGridViewRow drw in dgEntitlementList.SelectedRows)
    LeaveApplicationBalance.SetActive(dgEntitlementList.SelectedRows[0].Cells[0].Value.ToString(), dgEntitlementList.SelectedRows[0].Cells[1].Value.ToString());
   BindLeaveBalanceList();
  }

  private void tbtnDeactivate_Click(object sender, EventArgs e)
  {
   foreach (DataGridViewRow drw in dgEntitlementList.SelectedRows)
    LeaveApplicationBalance.SetInActive(dgEntitlementList.SelectedRows[0].Cells[0].Value.ToString(), dgEntitlementList.SelectedRows[0].Cells[1].Value.ToString());
   BindLeaveBalanceList();
  }

  private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { BindLeaveBalanceList(); }
   catch (Exception ex) { MessageBox.Show("An error occured while displaying the list.\n\nSource : " + ex.Source + "\nMessage: " + ex.Message, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error); }
  }

  private void cmbLeaveType_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { BindLeaveBalanceList(); }
   catch (Exception ex) { MessageBox.Show("An error occured while displaying the list.\n\nSource : " + ex.Source + "\nMessage: " + ex.Message, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error); }
  }

  private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { BindLeaveBalanceList(); }
   catch (Exception ex) { MessageBox.Show("An error occured while displaying the list.\n\nSource : " + ex.Source + "\nMessage: " + ex.Message, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error); }
  }

  private void tbtnProcess_Click(object sender, EventArgs e)
  {
   frmLeaveEntitlementProcess pForm = new frmLeaveEntitlementProcess();
   pForm.ShowDialog();
  }

  private void dgEntitlementList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgEntitlementList.SelectedRows.Count > 0)
   {
    frmLeaveBalanceEdit pForm = new frmLeaveBalanceEdit();
    pForm.Username = dgEntitlementList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.LeaveTypeCode = dgEntitlementList.SelectedRows[0].Cells[1].Value.ToString();
    pForm.FormCaller = FormCallers.LeaveEntitlementList;
    pForm.FormLeaveEntitlementList = this;
    pForm.FormMdiCaller = _frmMdiCaller;
    pForm.ShowDialog();
   }
  }

  private void txtLastName_TextChanged(object sender, EventArgs e)
  {
   try { BindLeaveBalanceList(); }
   catch (Exception ex) { MessageBox.Show("An error occured while displaying the list.\n\nSource : " + ex.Source + "\nMessage: " + ex.Message, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error); }
  }

  private void dgEntitlementList_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {

  }

 }
}