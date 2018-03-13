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
 public partial class frmTimesheetEmployeeSelector : Form
 {
  public frmTimesheetEmployeeSelector() { InitializeComponent(); }

  private string _strLastName;
  private frmTimesheet _frmTimesheet;

  public string LastName { set { _strLastName = value; } get { return _strLastName; } }
  public frmTimesheet FormTimeSheet { set { _frmTimesheet = value; } }

  private void frmTimesheetEmployeeSelector_Load(object sender, EventArgs e)
  {
   DataTable tblEmployees = Employee.DSLFormTimesheetEmployeeSelector(_strLastName);
   foreach (DataRow drw in tblEmployees.Rows)
   {
    ListViewItem itm = new ListViewItem();
    itm.Text = drw["lastname"].ToString() + ", " + drw["firname"].ToString();
    itm.Tag = drw["username"].ToString();
    lvwEmployee.Items.Add(itm);
   }
   if (lvwEmployee.Items.Count > 0)
    lvwEmployee.Items[0].Selected = true;
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void lvwEmployee_KeyUp(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Enter)
   {
    if (lvwEmployee.SelectedItems.Count > 0)
    {
     _frmTimesheet.Username = lvwEmployee.SelectedItems[0].Tag.ToString();
     _frmTimesheet.FullName = lvwEmployee.SelectedItems[0].Text;
     _frmTimesheet.BindTimeSheet();
     this.Close();
    }    
   }
  }

  private void lvwEmployee_DoubleClick(object sender, EventArgs e)
  {
   if (lvwEmployee.SelectedItems.Count > 0)
   {
    _frmTimesheet.Username = lvwEmployee.SelectedItems[0].Tag.ToString();
    _frmTimesheet.FullName = lvwEmployee.SelectedItems[0].Text;
    _frmTimesheet.BindTimeSheet();
    this.Close();
   }
  }

 }
}