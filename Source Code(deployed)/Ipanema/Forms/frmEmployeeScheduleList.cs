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
 public partial class frmEmployeeScheduleList : Form
 {
  public void LoadSchedule()
  {
   string strCurrentScheduleCode = "";
   DataTable tblEmployee = Employee.DSGEmployeeScheduleList(EmployeeAccountType.Active);
   lvScheduleManagement.Items.Clear();
   foreach (DataRow drw in tblEmployee.Rows)
   {
    strCurrentScheduleCode = Employee.GetScheduleCurrent(drw["username"].ToString(), DateTime.Now);
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drw["empnum"].ToString();
    lvi.Tag = drw["username"].ToString();
    lvi.SubItems.Add(drw["pname"].ToString());    
    lvi.SubItems.Add(strCurrentScheduleCode);
    using (clsSchedule schedule = new clsSchedule())
    {     
     schedule.ScheduleCode = strCurrentScheduleCode;
     schedule.Fill();
     lvi.SubItems.Add(schedule.MondayShift);
     lvi.SubItems.Add(schedule.TuesdayShift);
     lvi.SubItems.Add(schedule.WednesdayShift);
     lvi.SubItems.Add(schedule.ThursdayShift);
     lvi.SubItems.Add(schedule.FridayShift);
     lvi.SubItems.Add(schedule.SaturdayShift);
     lvi.SubItems.Add(schedule.SundayShift);
    }
    lvi.SubItems.Add(drw["schdcode"].ToString());

    lvi.BackColor = (drw["schdcode"].ToString() == strCurrentScheduleCode ? Color.White : Color.Honeydew);
    lvScheduleManagement.Items.Add(lvi);
   }
   if (lvScheduleManagement.Items.Count > 0)
    lvScheduleManagement.Items[0].Selected = true;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////


  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  public frmEmployeeScheduleList() { InitializeComponent(); }

  private void frmEmployeeScheduleList_Load(object sender, EventArgs e)
  {
   LoadSchedule();
   this.WindowState = FormWindowState.Maximized;
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   LoadSchedule();
  }

  private void tbtnModify_Click(object sender, EventArgs e)
  {
   if (lvScheduleManagement.SelectedItems.Count > 0)
   {
    if (clsEmployeeSchedule.HasExistingApplication(lvScheduleManagement.SelectedItems[0].Tag.ToString(), DateTime.Now))
    {
     frmEmployeeScheduleUpdate pForm = new frmEmployeeScheduleUpdate();
     pForm.FormEmployeeScheduleList = this;
     pForm.EmployeeScheduleCode = clsEmployeeSchedule.GetEmployeeScheduleCode(lvScheduleManagement.SelectedItems[0].Tag.ToString(), DateTime.Now);
     pForm.DefaultScheduleCode = lvScheduleManagement.SelectedItems[0].SubItems[10].Text;
     pForm.ShowDialog();
    }
    else
    {
     MessageBox.Show("The employee is using the default schedule.", clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
   }
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   if (lvScheduleManagement.SelectedItems.Count > 0)
   {
    frmEmployeeScheduleInsert pForm = new frmEmployeeScheduleInsert();
    pForm.FormEmployeeScheduleList = this;
    pForm.FormCaller = FormCallers.EmployeeScheduleList;
    pForm.DefaultScheduleCode = lvScheduleManagement.SelectedItems[0].SubItems[10].Text;
    pForm.Username = lvScheduleManagement.SelectedItems[0].Tag.ToString();
    pForm.ShowDialog();
   }
  }

 }
}