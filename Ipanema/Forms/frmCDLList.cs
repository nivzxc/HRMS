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
 public partial class frmCDLList : Form
 {
  public frmCDLList() { InitializeComponent(); }

  public void LoadCDLList()
  {
   DataTable tblCDL = CDL.GetDSGMainForm();

   lvCDL.Items.Clear();
   foreach (DataRow drw in tblCDL.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drw["cdlcode"].ToString();
    lvi.Tag = drw["cdlcode"].ToString();
    lvi.SubItems.Add(clsValidator.CheckDate(drw["dateapp"].ToString()).ToString("MMM dd, yyyy"));
    lvi.SubItems.Add(drw["preason"].ToString());
    lvi.BackColor = (lvCDL.Items.Count % 2 == 0 ? Color.White : Color.Ivory);
    lvCDL.Items.Add(lvi);
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   frmCDLAdd pForm = new frmCDLAdd();
   pForm.FormCDLList = this;
   pForm.ShowDialog();
   this.Cursor = Cursors.Default;
  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {
   if (lvCDL.SelectedItems.Count > 0)
   {
    this.Cursor = Cursors.WaitCursor;
    frmCDLEdit pForm = new frmCDLEdit();
    pForm.FormCDLList = this;
    pForm.CDLCode = lvCDL.SelectedItems[0].Tag.ToString();
    pForm.ShowDialog();
    this.Cursor = Cursors.Default;
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (lvCDL.SelectedItems.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     CDL objCDL = new CDL();
     objCDL.CDLCode = lvCDL.SelectedItems[0].Tag.ToString();
     objCDL.Delete();
     LoadCDLList();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   LoadCDLList();
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void frmCDLList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   this.LoadCDLList();
  }

 }
}