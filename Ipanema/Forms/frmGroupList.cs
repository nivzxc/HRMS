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
 public partial class frmGroupList : Form
 {
  public frmGroupList() { InitializeComponent(); }

  public void BindGroupList()
  {
   dgGroupList.AutoGenerateColumns = false;
   dgGroupList.DataSource = Group.DSGFormGroupList();
   dgGroupList.Columns[0].DataPropertyName = "GroupCode";
   dgGroupList.Columns[1].DataPropertyName = "GroupName";
   dgGroupList.Columns[2].DataPropertyName = "Division";
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgGroupList.Rows.Count.ToString());
  }

  //////////////////////////////  
  ///////// Form Event ///////// 
  //////////////////////////////

  private void frmGroupList_Load(object sender, EventArgs e)
  {
   BindGroupList();
   this.WindowState = FormWindowState.Maximized;
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmGroupAdd pForm = new frmGroupAdd();
   pForm.FormGroupList = this;
   pForm.ShowDialog();
  }

  private void tbtnModify_Click(object sender, EventArgs e)
  {
   if (dgGroupList.SelectedRows.Count > 0)
   {
    frmGroupEdit pForm = new frmGroupEdit();
    pForm.FormGroupList = this;
    pForm.GroupCode = dgGroupList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgGroupList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     Group group = new Group();
     group.GroupCode = dgGroupList.SelectedRows[0].Cells[0].Value.ToString();
     group.Delete();
     BindGroupList();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindGroupList();
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void lvGroup_DoubleClick(object sender, EventArgs e)
  {
   tbtnModify_Click(null, null);
  }

  private void dgGroupList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgGroupList.SelectedRows.Count > 0)
   {
    frmGroupEdit pForm = new frmGroupEdit();
    pForm.FormGroupList = this;
    pForm.GroupCode = dgGroupList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

 }
}
