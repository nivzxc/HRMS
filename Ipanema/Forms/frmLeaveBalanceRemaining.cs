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
 public partial class frmLeaveBalanceRemaining : Form
 {
  public frmLeaveBalanceRemaining() { InitializeComponent(); }

  private string _strUsername;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }

  public void BindBalanceList()
  {
   lvBalance.Items.Clear();
   DataTable tblBalance = LeaveApplicationBalance.GetDataTableEntitlementHasBalance(_strUsername);
   foreach (DataRow drw in tblBalance.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = LeaveApplicationTypes.GetDescription(drw["leavtype"].ToString());
    lvi.Tag = drw["leavtype"].ToString();
    lvi.SubItems.Add(drw["entitle"].ToString());
    lvi.SubItems.Add(drw["pbalance"].ToString());
    lvBalance.Items.Add(lvi);
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmLeaveBalanceRemaining_Load(object sender, EventArgs e)
  {
   BindBalanceList();
  }
 }
}
