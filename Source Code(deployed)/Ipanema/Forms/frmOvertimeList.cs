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
 public partial class frmOvertimeList : Form
 {
  public frmOvertimeList() { InitializeComponent(); }

  private string _strOrderBy;
  private int _intToolTipX;
  private int _intToolTipY;


  public void LoadOvertimeList()
  {
   string strWhere = "WHERE ((HR.Overtime.datestrt BETWEEN '" + dtpFrom.Value + "' AND '" + clsDateTime.ChangeTimeToEnd(dtpTo.Value) + "') OR (HR.Overtime.dateend BETWEEN '" + dtpFrom.Value + "' AND '" + clsDateTime.ChangeTimeToEnd(dtpTo.Value) + "')) ";

   if (cmbStatus.SelectedValue.ToString() != "ALL")
    strWhere = strWhere + "AND HR.Overtime.otstat='" + cmbStatus.SelectedValue + "' ";

   if (cmbRequestor.SelectedValue.ToString() != "ALL")
    strWhere = strWhere + "AND HR.Overtime.username='" + cmbRequestor.SelectedValue + "' ";

   if (cmbChargeType.SelectedValue.ToString() != "ALL")
    strWhere = strWhere + "AND HR.Overtime.chartype='" + cmbChargeType.SelectedValue + "' ";

   lvOvertimeList.Items.Clear();
   DataTable tblOvertime = clsOvertime.FormListDataSource(strWhere, _strOrderBy);
   foreach (DataRow drw in tblOvertime.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drw["otcode"].ToString();
    lvi.Tag = drw["otcode"].ToString();
    lvi.SubItems.Add(Employee.GetName(drw["username"].ToString(), EmployeeNameFormat.LastFirst));
    lvi.SubItems[0].Tag = drw["reason"].ToString();
    lvi.SubItems.Add(clsOvertime.GetChargeTypeDesc(drw["chartype"].ToString()));
    lvi.SubItems.Add(Department.GetName(drw["deptcode"].ToString()));
    lvi.SubItems.Add(clsValidator.CheckDate(drw["datefile"].ToString()).ToString("MMM dd, yyyy"));
    lvi.SubItems.Add(clsValidator.CheckDate(drw["datestrt"].ToString()).ToString("MMM dd, yyyy hh:mm tt"));
    lvi.SubItems.Add(clsValidator.CheckDate(drw["dateend"].ToString()).ToString("MMM dd, yyyy hh:mm tt"));
    lvi.SubItems.Add(clsOvertime.ToStatusDesc(drw["otstat"].ToString()));
    lvi.BackColor = clsOvertime.GetLVBGColor(drw["otstat"].ToString());
    lvOvertimeList.Items.Add(lvi);
   }

   if (lvOvertimeList.Items.Count > 0)
    lvOvertimeList.Items[0].Selected = true;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmOvertimeList_Load(object sender, EventArgs e)
  {
   cmbRequestor.DataSource = Employee.DSLAll();
   cmbRequestor.ValueMember = "pvalue";
   cmbRequestor.DisplayMember = "ptext";

   cmbChargeType.DataSource = clsOvertime.DdlDsChargeTypeAll();
   cmbChargeType.ValueMember = "pvalue";
   cmbChargeType.DisplayMember = "ptext";

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
   
   _strOrderBy = "otcode";
   LoadOvertimeList();

   this.WindowState = FormWindowState.Maximized;
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmOvertimeNew pForm = new frmOvertimeNew();
   pForm.FormOvertimeList = this;
   pForm.ShowDialog();
  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {
   if (lvOvertimeList.SelectedItems.Count > 0)
   {
    frmOvertimeEdit pForm = new frmOvertimeEdit();
    pForm.OvertimeCode = lvOvertimeList.SelectedItems[0].Tag.ToString();
    pForm.FormOvertimeList = this;
    pForm.ShowDialog();
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (lvOvertimeList.SelectedItems.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsOvertime overtime = new clsOvertime();
     overtime.OvertimeCode = lvOvertimeList.SelectedItems[0].Tag.ToString();
     overtime.Delete();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   LoadOvertimeList();
  }

  private void lvOvertimeList_MouseMove(object sender, MouseEventArgs e)
  {
   try 
   {
    if (_intToolTipX == e.X && _intToolTipY == e.Y)
    {
    }
    else
    {
     ttReason.SetToolTip(lvOvertimeList, lvOvertimeList.GetItemAt(e.X, e.Y).SubItems[0].Tag.ToString());
     _intToolTipX = e.X;
     _intToolTipY = e.Y;
    }
   }
   catch { }
  }

  private void cmbRequestor_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { LoadOvertimeList(); }
   catch { }
  }

  private void cmbChargeType_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { LoadOvertimeList(); }
   catch { }
  }

  private void dtpFrom_ValueChanged(object sender, EventArgs e)
  {
   try { LoadOvertimeList(); }
   catch { }
  }

  private void dtpTo_ValueChanged(object sender, EventArgs e)
  {
   try { LoadOvertimeList(); }
   catch { }
  }

  private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { LoadOvertimeList(); }
   catch { }
  }

  private void lvOvertimeList_ColumnClick(object sender, ColumnClickEventArgs e)
  {
   switch (e.Column)
   {
    case 0:
     _strOrderBy = "otcode";
     break;
    case 1:
     _strOrderBy = "lastname";
     break;
    case 2:
     _strOrderBy = "chartype";
     break;
    case 3:
     _strOrderBy = "deptname";
     break;
    case 4:
     _strOrderBy = "datefile";
     break;
    case 5:
     _strOrderBy = "datestrt";
     break;
    case 6:
     _strOrderBy = "dateend";
     break;
    case 7:
     _strOrderBy = "otstat";
     break;
   }
   LoadOvertimeList();
  }

 }
}