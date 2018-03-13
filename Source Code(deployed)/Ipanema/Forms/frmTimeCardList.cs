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
 public partial class frmTimeCardList : Form
 {
  public frmTimeCardList() { InitializeComponent(); }

  private string _strOrderBy;  

  public void LoadCurrentTimeSheetPeriod()
  {
   string strCurrentTimeSheetPeriod = clsTimeSheetPeriod.GetCurrentTimeSheetPeriod();
   using (clsTimeSheetPeriod tsp = new clsTimeSheetPeriod(strCurrentTimeSheetPeriod))
   {
    tsp.Fill();
    dtpFrom.Value = tsp.PeriodFrom;
    dtpTo.Value = tsp.PeriodTo;
   }
  }

  public void LoadTimeCardList()
  {
   string strWhere = "";

   if(cmbEmployee.SelectedValue.ToString() == "ALL")
    strWhere = "WHERE focsdate BETWEEN '" + dtpFrom.Value + "' AND '" + dtpTo.Value + "' ";
   else
    strWhere = "WHERE focsdate BETWEEN '" + dtpFrom.Value + "' AND '" + dtpTo.Value + "' AND HR.Employees.username='" + cmbEmployee.SelectedValue.ToString() + "' ";

   DataTable tblTimeCard = clsTimeCard.GetTimeCardsList(strWhere, _strOrderBy);

   lvwTimeCard.Items.Clear();
   foreach (DataRow drw in tblTimeCard.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = Employee.GetName(drw["username"].ToString(), EmployeeNameFormat.LastFirst);
    lvi.Tag = drw["username"].ToString();
    lvi.SubItems.Add(clsValidator.CheckDate(drw["focsdate"].ToString()).ToString("ddd MMM dd, yyyy"));
    lvi.SubItems.Add(clsValidator.CheckDate(drw["keyin"].ToString()).ToString("hh:mm tt"));
    lvi.SubItems[2].Tag = drw["keyin"].ToString();
    if (clsValidator.CheckDate(drw["keyout"].ToString()) == clsDateTime.SystemMinDate)
     lvi.SubItems.Add("");
    else
    {
     if (clsDateTime.GetDateOnly(clsValidator.CheckDate(drw["focsdate"].ToString())) == clsDateTime.GetDateOnly(clsValidator.CheckDate(drw["keyout"].ToString())))
      lvi.SubItems.Add(clsValidator.CheckDate(drw["keyout"].ToString()).ToString("hh:mm tt"));
     else
      lvi.SubItems.Add(clsValidator.CheckDate(drw["keyout"].ToString()).ToString("ddd MMM dd, yyyy hh:mm tt"));
    }
    lvi.SubItems.Add(drw["updateby"].ToString());
    if (clsValidator.CheckDate(drw["keyin"].ToString()).ToString("tt") == "PM" && clsValidator.CheckDate(drw["keyout"].ToString()).ToString("tt") == "AM")
     lvi.BackColor = Color.MistyRose;
    lvwTimeCard.Items.Add(lvi);
   }
  }

  //////////////////////////////  
  ///////// Form Event ///////// 
  //////////////////////////////

  private void frmTimeCardList_Load(object sender, EventArgs e)
  {
   cmbEmployee.DataSource = Employee.DSLActiveAll();
   cmbEmployee.ValueMember = "pvalue";
   cmbEmployee.DisplayMember = "ptext";
   _strOrderBy = "HR.Employees.lastname";
   
   LoadCurrentTimeSheetPeriod();
   LoadTimeCardList();

   this.WindowState = FormWindowState.Maximized;
  }

  private void tmiAdd_Click(object sender, EventArgs e)
  {
   frmTimeCardAdd pForm = new frmTimeCardAdd();
   pForm.FormTimeCardList = this;
   pForm.FormCaller = FormCallers.TimeCardList;
   pForm.ShowDialog();
  }

  private void tmiRefresh_Click(object sender, EventArgs e)
  {
   LoadTimeCardList();
  }

  private void tmiDelete_Click(object sender, EventArgs e)
  {
   if (lvwTimeCard.SelectedItems.Count > 0)
   {
    if (MessageBox.Show("Are you sure to delete this time card entry?\n\nWARNING: Deleting a time card entry might cause discrepancies on your timesheet.", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsTimeCard tc = new clsTimeCard();
     tc.Username = lvwTimeCard.SelectedItems[0].Tag.ToString();
     tc.FocusDate = clsValidator.CheckDate(lvwTimeCard.SelectedItems[0].SubItems[1].Text);
     tc.KeyIn = clsValidator.CheckDate(lvwTimeCard.SelectedItems[0].SubItems[2].Tag.ToString());
     tc.KeyOut = clsValidator.CheckDate(lvwTimeCard.SelectedItems[0].SubItems[3].Text);
     tc.Delete();

     lvwTimeCard.SelectedItems[0].Remove();
     //LoadTimeCardList();
    }
   }
  }

  private void tmiEdit_Click(object sender, EventArgs e)
  {
   if (lvwTimeCard.SelectedItems.Count > 0)
   {
    frmTimeCardEdit pForm = new frmTimeCardEdit(this);
    pForm.Username = lvwTimeCard.SelectedItems[0].Tag.ToString();
    pForm.FocusDate = clsValidator.CheckDate(lvwTimeCard.SelectedItems[0].SubItems[1].Text);
    pForm.KeyIn = clsValidator.CheckDate(lvwTimeCard.SelectedItems[0].SubItems[2].Tag.ToString());
    pForm.ShowDialog();
   }
  }

  private void lvwTimeCard_DoubleClick(object sender, EventArgs e)
  {
   tmiEdit_Click(null, null);
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void lvwTimeCard_ColumnClick(object sender, ColumnClickEventArgs e)
  {
   switch (e.Column)
   {
    case 0:
     _strOrderBy = "HR.Employees.lastname";
     break;
    case 1:
     _strOrderBy = "focsdate";
     break;
    case 2:
     _strOrderBy = "keyin";
     break;
    case 3:
     _strOrderBy = "keyout";
     break;
    case 4:
     _strOrderBy = "updateby";
     break;
   }
   LoadTimeCardList();
  }

  private void txtEmployeeNumber_KeyUp(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Enter)
    LoadTimeCardList();
  }

  private void dtpFrom_ValueChanged(object sender, EventArgs e)
  {
   try { LoadTimeCardList(); }
   catch { }
  }

  private void dtpTo_ValueChanged(object sender, EventArgs e)
  {
   try { LoadTimeCardList(); }
   catch { }
  }

  private void lvwTimeCard_KeyUp(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Delete)
    tmiDelete_Click(null, null);
  }

  private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { LoadTimeCardList(); }
   catch { }
   }

 }
}