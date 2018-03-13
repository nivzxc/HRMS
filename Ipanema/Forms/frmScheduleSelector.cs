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
 public partial class frmScheduleSelector : Form
 {
  private FormCallers _FormCaller;
  private frmEmployeeScheduleInsert _frmEmployeeScheduleInsert;
  private frmEmployeeScheduleUpdate _frmEmployeeScheduleUpdate;

  public FormCallers FormCaller { get { return _FormCaller; } set { _FormCaller = value; } }
  public frmEmployeeScheduleInsert FormEmployeeScheduleInsert { get { return _frmEmployeeScheduleInsert; } set { _frmEmployeeScheduleInsert = value; } }
  public frmEmployeeScheduleUpdate FormEmployeeScheduleUpdate { get { return _frmEmployeeScheduleUpdate; } set { _frmEmployeeScheduleUpdate = value; } }

  public frmScheduleSelector()
  {
   InitializeComponent();
  }

  public void BindScheduleList()
  {
   lvScheduleList.Items.Clear();
   DataTable tblSchdule = clsSchedule.DSGScheduleList();
   foreach (DataRow drow in tblSchdule.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drow["schdcode"].ToString();
    lvi.Tag = drow["schdcode"].ToString();
    lvi.SubItems.Add(drow["monshift"].ToString());
    lvi.SubItems.Add(drow["tueshift"].ToString());
    lvi.SubItems.Add(drow["wedshift"].ToString());
    lvi.SubItems.Add(drow["thushift"].ToString());
    lvi.SubItems.Add(drow["frishift"].ToString());
    lvi.SubItems.Add(drow["satshift"].ToString());
    lvi.SubItems.Add(drow["sunshift"].ToString());
    lvScheduleList.Items.Add(lvi);
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmScheduleSelector_Load(object sender, EventArgs e)
  {
   BindScheduleList();
  }

  private void lvScheduleList_DoubleClick(object sender, EventArgs e)
  {
   if (lvScheduleList.SelectedItems.Count > 0)
   {
    if(_FormCaller == FormCallers.EmployeeScheduleInsert)
     _frmEmployeeScheduleInsert.SelectSchedule(lvScheduleList.SelectedItems[0].Tag.ToString());
    else if (_FormCaller == FormCallers.EmployeeScheduleUpdate)
     _frmEmployeeScheduleUpdate.SelectSchedule(lvScheduleList.SelectedItems[0].Tag.ToString());
    this.Close();
   }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}