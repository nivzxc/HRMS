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
 public partial class frmEmployeeTypeList : Form
 {
  public frmEmployeeTypeList() { InitializeComponent(); }


  public void BindEmployeeTypeList()
  {
   dgEmployeeTypeList.AutoGenerateColumns = false;
   dgEmployeeTypeList.DataSource = clsEmployeeType.DSGEmployeeTypeList();
   dgEmployeeTypeList.Columns[0].DataPropertyName = "etypcode";
   dgEmployeeTypeList.Columns[1].DataPropertyName = "etypname";
   dgEmployeeTypeList.Columns[2].DataPropertyName = "etypdesc";
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgEmployeeTypeList.Rows.Count.ToString());
  }

  //////////////////////////////  
  ///////// Form Event ///////// 
  //////////////////////////////

  private void frmEmployeeTypeList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   BindEmployeeTypeList();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmEmployeeTypeNew pForm = new frmEmployeeTypeNew(this);
   pForm.FormCaller = FormCallers.EmployeeTypeList;
   pForm.ShowDialog();
  }

  private void tbtnModify_Click(object sender, EventArgs e)
  {
   if (dgEmployeeTypeList.SelectedRows.Count > 0)
   {
    frmEmployeeTypeEdit pForm = new frmEmployeeTypeEdit();
    pForm.FormEmployeeTypeList = this;
    pForm.EmployeeTypeCode = dgEmployeeTypeList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgEmployeeTypeList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     using (clsEmployeeType et = new clsEmployeeType())
     {
      et.EmployeeTypeCode = dgEmployeeTypeList.SelectedRows[0].Cells[0].Value.ToString();
      et.Delete();
     }
     BindEmployeeTypeList();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindEmployeeTypeList();
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnEnabled_Click(object sender, EventArgs e)
  {
   if (dgEmployeeTypeList.SelectedRows.Count > 0)
   {
    clsEmployeeType.UpdateEnabledStatus(dgEmployeeTypeList.SelectedRows[0].Cells[0].Value.ToString(), "1", HRMSCore.Username);
    BindEmployeeTypeList();
   }
  }

  private void tbtnDisable_Click(object sender, EventArgs e)
  {
   if (dgEmployeeTypeList.SelectedRows.Count > 0)
   {
    clsEmployeeType.UpdateEnabledStatus(dgEmployeeTypeList.SelectedRows[0].Cells[0].Value.ToString(), "0", HRMSCore.Username);
    BindEmployeeTypeList();
   }
  }

  private void dgEmployeeTypeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgEmployeeTypeList.SelectedRows.Count > 0)
   {
    frmEmployeeTypeEdit pForm = new frmEmployeeTypeEdit();
    pForm.FormEmployeeTypeList = this;
    pForm.EmployeeTypeCode = dgEmployeeTypeList.Rows[e.RowIndex].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

 }
}
