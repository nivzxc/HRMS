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
 public partial class frmClusterMembers : Form
 {
  public frmClusterMembers() { InitializeComponent(); }

  private string _strClusterCode;

  public string ClusterCode { set { _strClusterCode = value; } get { return _strClusterCode; } }

  private void LoadIncluded()
  {
   lvIEmployee.Items.Clear();
   DataTable tblIncluded = clsClusterMembers.DSGIncluded(_strClusterCode);
   foreach (DataRow drw in tblIncluded.Rows)
   {
    ListViewItem itm = new ListViewItem();
    itm.Text = drw["pname"].ToString();
    itm.Tag = drw["username"].ToString();    
    itm.SubItems.Add(drw["jgcode"].ToString());
    itm.SubItems.Add(drw["etypname"].ToString());
    itm.BackColor = (lvIEmployee.Items.Count % 2 == 0 ? Color.White : Color.AliceBlue);
    lvIEmployee.Items.Add(itm);
   }
   lblIncludedTotal.Text = "Total Items: " + lvIEmployee.Items.Count.ToString();
  }

  private void LoadExcluded()
  {
   lvLEmployee.Items.Clear();
   DataTable tblExcluded = clsClusterMembers.DSGExcluded(_strClusterCode);
   foreach (DataRow drw in tblExcluded.Rows)
   {
    ListViewItem itm = new ListViewItem();
    itm.Text = drw["pname"].ToString();
    itm.Tag = drw["username"].ToString();
    itm.SubItems.Add(drw["jgcode"].ToString());
    itm.SubItems.Add(drw["etypname"].ToString());
    itm.BackColor = (lvLEmployee.Items.Count % 2 == 0 ? Color.White : Color.AliceBlue);
    lvLEmployee.Items.Add(itm);
    lblLTotal.Text = "Total Items: " + lvLEmployee.Items.Count.ToString();
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmClusterMembers_Load(object sender, EventArgs e)
  {
   LoadIncluded();
   LoadExcluded();
  }

  private void btnInclude_Click(object sender, EventArgs e)
  {
   if (lvLEmployee.SelectedItems.Count > 0)
   {
    clsClusterMembers cm = new clsClusterMembers();
    cm.ClusterCode = _strClusterCode;
    cm.Username = lvLEmployee.SelectedItems[0].Tag.ToString();
    cm.Insert();

    LoadIncluded();
    LoadExcluded();
   }
  }

  private void btnExclude_Click(object sender, EventArgs e)
  {
   if (lvIEmployee.SelectedItems.Count > 0)
   {
    clsClusterMembers cm = new clsClusterMembers();
    cm.ClusterCode = _strClusterCode;
    cm.Username = lvIEmployee.SelectedItems[0].Tag.ToString();
    cm.Delete();

    LoadIncluded();
    LoadExcluded();
   }
  }

  private void btnIncludeAll_Click(object sender, EventArgs e)
  {
   foreach (ListViewItem itm in lvLEmployee.Items)
   {
    clsClusterMembers cm = new clsClusterMembers();
    cm.ClusterCode = _strClusterCode;
    cm.Username = itm.Tag.ToString();
    cm.Insert();
   }
   LoadIncluded();
   LoadExcluded();
  }

  private void btnExcludeAll_Click(object sender, EventArgs e)
  {
   foreach (ListViewItem itm in lvIEmployee.Items)
   {
    clsClusterMembers cm = new clsClusterMembers();
    cm.ClusterCode = _strClusterCode;
    cm.Username = itm.Tag.ToString();
    cm.Delete();
   }
   LoadIncluded();
   LoadExcluded();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void chkActiveOnly_CheckedChanged(object sender, EventArgs e)
  {

  }

 }
}