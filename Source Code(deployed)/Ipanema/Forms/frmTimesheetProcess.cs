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
 public partial class frmTimesheetProcess : Form
 {
  string _strOrderBy;

  public frmTimesheetProcess()
  {
   InitializeComponent();
  }

  private void LoadCurrentTimeSheetPeriod()
  {
   string strCurrentTimeSheetPeriod = clsTimeSheetPeriod.GetCurrentTimeSheetPeriod();
   using (clsTimeSheetPeriod tsp = new clsTimeSheetPeriod(strCurrentTimeSheetPeriod))
   {
    tsp.Fill();
    dtpStart.Value = tsp.PeriodFrom;
    dtpEnd.Value = tsp.PeriodTo;
   }
  }

  private void LoadEmployee()
  {
   int intCtr = 0;
   DataTable tblEmployee = Employee.GetDSGTimesheetProcess(cmbCluster.SelectedValue.ToString(), txtLastName.Text);
   DataView dvEmployee = new DataView(tblEmployee);
   dvEmployee.Sort = _strOrderBy;

   lvEmployee.Items.Clear();
   foreach (DataRowView drw in dvEmployee)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drw["empnum"].ToString();
    lvi.Tag = drw["username"].ToString();
    lvi.SubItems.Add(drw["pname"].ToString());
    lvi.SubItems.Add(drw["pEmploymentStatus"].ToString());
    lvi.SubItems.Add(drw["pDepartmentName"].ToString());
    lvi.SubItems.Add(drw["jgcode"].ToString());
    lvi.BackColor = (lvEmployee.Items.Count % 2 == 0 ? Color.White : Color.AliceBlue);
    lvEmployee.Items.Add(lvi);
    intCtr++;
   }
   lvEmployee.Columns[4].Width = (tblEmployee.Rows.Count > 20 ? 60 : 77);

   lblRecordsFound.Text = intCtr.ToString() + " records found";
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void frmTimesheetProcess_Load(object sender, EventArgs e)
  {
   _strOrderBy = "pname";
   cmbCluster.DataSource = clsCluster.GetDdlDs();
   cmbCluster.DisplayMember = "ptext";
   cmbCluster.ValueMember = "pvalue";

   LoadCurrentTimeSheetPeriod();
   LoadEmployee();

   ToolTip ttTimesheet;
   ttTimesheet = new ToolTip();
   ttTimesheet.SetToolTip(btnResetPeriod, "Reset timesheet period");

  }

  private void lvEmployee_ColumnClick(object sender, ColumnClickEventArgs e)
  {
   if (e.Column == 0)
    _strOrderBy = "empnum";
   else if (e.Column == 1)
    _strOrderBy = "pname";
   else if (e.Column == 2)
    _strOrderBy = "pEmploymentStatus";
   else if (e.Column == 3)
    _strOrderBy = "pDepartmentName";
   LoadEmployee();
  }

  private void btnProcess_Click(object sender, EventArgs e)
  {
   if (dtpStart.Value > dtpEnd.Value)
   {
    MessageBox.Show("Date inclusive 'start date' cannot be greater than 'end date'.", clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   }
   else
   {
    int intCtr = 0;
    string[] strEmpList = new string[lvEmployee.CheckedItems.Count];
    foreach (ListViewItem lvi in lvEmployee.CheckedItems)
    {
     strEmpList[intCtr] = lvi.Tag.ToString();
     intCtr++;
    }
    frmTimesheetProcessDialog pForm = new frmTimesheetProcessDialog();
    pForm.EmployeeList = strEmpList;
    pForm.DateStart = dtpStart.Value;
    pForm.DateEnd = dtpEnd.Value;
    pForm.ShowDialog();
    //clsTimesheet.ProcessTimeSheet(strEmpList, dtpStart.Value, dtpEnd.Value, prgTimeSheet);
    //MessageBox.Show("Processing Complete", "HRMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
   }
  }

  private void btnResetPeriod_Click(object sender, EventArgs e)
  {
   LoadCurrentTimeSheetPeriod();
  }

  private void btnEmpProfile_Click(object sender, EventArgs e)
  {
   if (lvEmployee.SelectedItems.Count != 0)
   {
    frmEmployeeDetails pForm = new frmEmployeeDetails();
    pForm.FormTimesheetProcess = this;
    pForm.Username = lvEmployee.SelectedItems[0].Tag.ToString();
    pForm.Show();
   }
  }

  private void btnViewTimesheet_Click(object sender, EventArgs e)
  {
   if (lvEmployee.SelectedItems.Count != 0)
   {
    frmTimesheet pForm = new frmTimesheet();
    pForm.Username = lvEmployee.SelectedItems[0].Tag.ToString();
    pForm.Show();
   }
  }

  private void cmbCluster_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { LoadEmployee(); }
   catch { }
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
   foreach (ListViewItem lvi in lvEmployee.Items)
    lvi.Checked = true;
  }

  private void lnkUnSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
   foreach (ListViewItem lvi in lvEmployee.Items)
    lvi.Checked = false;
  }

  private void txtLastName_TextChanged(object sender, EventArgs e)
  {
   LoadEmployee();
  }

 }
}