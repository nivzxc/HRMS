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
 public partial class frmLeaveEntitlementProcess : Form
 {
  public frmLeaveEntitlementProcess() { InitializeComponent(); }

  public void LoadEmployee()
  {
   Cursor.Current = Cursors.WaitCursor;
   lvEmployee.Items.Clear();
   DataTable tblLeaveBalance = LeaveApplicationBalance.NoBalanceFormListDataSource(cmbLeaveType.SelectedValue.ToString());
   foreach (DataRow drw in tblLeaveBalance.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Tag = drw["username"].ToString();
    lvi.Text = drw["lastname"].ToString() + ", " + drw["firname"].ToString();
    lvi.BackColor = (lvEmployee.Items.Count % 2 == 0 ? Color.White : Color.Ivory);
    lvEmployee.Items.Add(lvi);
   }
   lblRecordsFound.Text = lvEmployee.Items.Count.ToString() + " records found";
   Cursor.Current = Cursors.Default;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void frmLeaveEntitlementProcess_Load(object sender, EventArgs e)
  {
   cmbLeaveType.DataSource = LeaveApplicationTypes.DSLLeaveType();
   cmbLeaveType.ValueMember = "pvalue";
   cmbLeaveType.DisplayMember = "ptext";

   if(cmbLeaveType.Items.Count > 0)    
    txtMaxBalance.Text = LeaveApplicationTypes.GetMaxBalance(cmbLeaveType.SelectedValue.ToString());

   LoadEmployee();
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
   foreach (ListViewItem itm in lvEmployee.Items)
    itm.Checked = true;
  }

  private void lnkUnSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
   foreach (ListViewItem itm in lvEmployee.Items)
    itm.Checked = false;
  }

  private void btnProcess_Click(object sender, EventArgs e)
  {
   if (lvEmployee.CheckedItems.Count > 0)
   {
    LeaveApplicationTypes lt = new LeaveApplicationTypes();
    lt.LeaveTypeCode = cmbLeaveType.SelectedValue.ToString();
    lt.Fill();
    foreach (ListViewItem itm in lvEmployee.CheckedItems)
    {
     LeaveApplicationBalance lb = new LeaveApplicationBalance();
     lb.Username = itm.Tag.ToString();
     lb.LeaveTypeCode = lt.LeaveTypeCode;
     lb.Entitlement = lt.MaximumBalance;
     lb.Balance = lt.MaximumBalance;
     lb.Status = "1";
     lb.Insert();
    }
    MessageBox.Show("Leave processing complete.", clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Information);
    LoadEmployee();
   }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void cmbLeaveType_SelectedIndexChanged(object sender, EventArgs e)
  {
   LoadEmployee();
   if (cmbLeaveType.Items.Count > 0)
    txtMaxBalance.Text = LeaveApplicationTypes.GetMaxBalance(cmbLeaveType.SelectedValue.ToString());
  }

 }
}