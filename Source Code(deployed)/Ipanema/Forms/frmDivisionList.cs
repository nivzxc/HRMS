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
 public partial class frmDivisionList : Form
 {
  public frmDivisionList() { InitializeComponent(); }

  public void BindDivisionList()
  {
   dgDivisionList.AutoGenerateColumns = false;
   dgDivisionList.DataSource = Division.GetDSGFormDivisionList();
   dgDivisionList.Columns[0].DataPropertyName = "divicode";
   dgDivisionList.Columns[1].DataPropertyName = "division";
   dgDivisionList.Columns[2].DataPropertyName = "divihead";
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgDivisionList.Rows.Count.ToString());
  }
    
  //////////////////////////////  
  ///////// Form Event ///////// 
  //////////////////////////////
  
  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmDivisionAdd pDivisionAdd = new frmDivisionAdd(this);
   pDivisionAdd.FormCaller = FormCallers.DivisionList;
   pDivisionAdd.ShowDialog();
  }

  private void tbtnModify_Click(object sender, EventArgs e)
  {
   if (dgDivisionList.SelectedRows.Count > 0)
   {
    frmDivisionEdit pDivisionEdit = new frmDivisionEdit(this);
    pDivisionEdit.DivisionCode = dgDivisionList.SelectedRows[0].Cells[0].Value.ToString();
    pDivisionEdit.ShowDialog();
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgDivisionList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show("Are you sure to delete " + dgDivisionList.SelectedRows[0].Cells[1].Value.ToString() + "?", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     Division objDivision = new Division();
     objDivision.Code = dgDivisionList.SelectedRows[0].Cells[0].Value.ToString();
     objDivision.Delete();
     BindDivisionList();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindDivisionList();
  }

  private void frmDivisionList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   BindDivisionList();   
  }

  private void frmDivisionList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgDivisionList.Rows.Count.ToString());
  }

  private void frmDivisionList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");
  }

  private void dgDivisionList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgDivisionList.SelectedRows.Count > 0)
   {
    frmDivisionEdit pDivisionEdit = new frmDivisionEdit(this);
    pDivisionEdit.DivisionCode = dgDivisionList.SelectedRows[0].Cells[0].Value.ToString();
    pDivisionEdit.ShowDialog();
   }
  }

 }
}