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
 public partial class frmDepartmentList : Form
 {
  public frmDepartmentList() { InitializeComponent(); }

  public void BindDepartmentList()
  {
   dgDepartmentList.AutoGenerateColumns = false;
   dgDepartmentList.DataSource = Department.GetDSGFormDepartmentList();
   dgDepartmentList.Columns[0].DataPropertyName = "DepartmentCode";
   dgDepartmentList.Columns[1].DataPropertyName = "DepartmentName";
   dgDepartmentList.Columns[2].DataPropertyName = "Group";
   dgDepartmentList.Columns[3].DataPropertyName = "Division";
   dgDepartmentList.Columns[4].DataPropertyName = "Enabled";
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgDepartmentList.Rows.Count.ToString());
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmDepartmentList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   BindDepartmentList();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmDepartmentAdd pForm = new frmDepartmentAdd();
   pForm.FormDepartmentList = this;
   pForm.ShowDialog();
  }

  private void tbtnModify_Click(object sender, EventArgs e)
  {
   if (dgDepartmentList.SelectedRows.Count > 0)
   {
    frmDepartmentEdit pForm = new frmDepartmentEdit();
    pForm.FormDepartmentList = this;
    pForm.DepartmentCode = dgDepartmentList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgDepartmentList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     Department objDepartment = new Department();
     objDepartment.DepartmentCode = dgDepartmentList.SelectedRows[0].Cells[0].Value.ToString();
     objDepartment.Delete();
     BindDepartmentList();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindDepartmentList();
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnActive_Click(object sender, EventArgs e)
  {
   if (dgDepartmentList.SelectedRows.Count > 0)
   {
    string department_name = dgDepartmentList.SelectedRows[0].Cells[1].Value.ToString();
    Department.SetActive(dgDepartmentList.SelectedRows[0].Cells[0].Value.ToString()); 
    BindDepartmentList();
    MessageBox.Show(department_name + " has set to Active", "Activate", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
   }
  }

  private void tbtnInActive_Click(object sender, EventArgs e)
  {
   if (dgDepartmentList.SelectedRows.Count > 0)
   {
    string department_name = dgDepartmentList.SelectedRows[0].Cells[1].Value.ToString();
    Department.SetInactive(dgDepartmentList.SelectedRows[0].Cells[0].Value.ToString()); 
    BindDepartmentList();
    MessageBox.Show(department_name + " has set to InActive", "InActivate", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
   }
  }

  private void dgDepartmentList_SelectionChanged(object sender, EventArgs e)
  {
   if (dgDepartmentList.SelectedRows.Count > 0)
   {
    try
    {
     tbtnActive.Enabled = dgDepartmentList.SelectedRows[0].Cells[4].Value.ToString() == "0";
     tbtnInActive.Enabled = dgDepartmentList.SelectedRows[0].Cells[4].Value.ToString() == "1";
    }
    catch { }
   }
  }

  private void dgDepartmentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   tbtnModify_Click(null, null);
  }

  private void frmDepartmentList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgDepartmentList.Rows.Count.ToString());
  }

  private void frmDepartmentList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");
  }
  private void dgDepartmentList_KeyDown(object sender, KeyEventArgs e)
  {
   if (e.KeyCode==Keys.Enter) {

    if (dgDepartmentList.SelectedRows.Count > 0)
    {
      tbtnModify_Click(null, null);
    }
      e.SuppressKeyPress = true;              
   } 
  }
 }
}
