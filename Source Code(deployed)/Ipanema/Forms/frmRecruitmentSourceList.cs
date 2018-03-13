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
 public partial class frmRecruitmentSourceList : Form
 {
  public frmRecruitmentSourceList() { InitializeComponent(); }

  public void BindRecruitmentSourceList()
  {
   dgRecruitmentSourceList.AutoGenerateColumns = false;
   dgRecruitmentSourceList.DataSource = clsRecruitmentSource.DSGRecruitmentSourceList(); ;
   dgRecruitmentSourceList.Columns[0].DataPropertyName = "rsrccode";
   dgRecruitmentSourceList.Columns[1].DataPropertyName = "rsrcname";
   dgRecruitmentSourceList.Columns[2].DataPropertyName = "enabled";
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgRecruitmentSourceList.Rows.Count.ToString());
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   this.Cursor = Cursors.AppStarting;
   frmRecruitmentSourceAdd pForm = new frmRecruitmentSourceAdd();
   pForm.FormCaller = FormCallers.RecruitmentSourceList;
   pForm.FormRecruitmentSourceList = this;
   pForm.ShowDialog();
   this.Cursor = Cursors.Default;
  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {
   if (dgRecruitmentSourceList.SelectedRows.Count > 0)
   {
    this.Cursor = Cursors.AppStarting;
    frmRecruitmentSourceEdit pForm = new frmRecruitmentSourceEdit();
    pForm.RecruitmentSourceCode = dgRecruitmentSourceList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.FormRecruitmentSourceList = this;
    pForm.ShowDialog();
    this.Cursor = Cursors.Default;
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgRecruitmentSourceList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     using (clsRecruitmentSource source = new clsRecruitmentSource())
     {
      source.RecruitmentSourceCode = dgRecruitmentSourceList.SelectedRows[0].Cells[0].Value.ToString();
      source.Delete();
     }
     BindRecruitmentSourceList();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindRecruitmentSourceList();
  }

  private void frmRecruitmentSourceList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   BindRecruitmentSourceList();
  }

  private void dgRecruitmentSourceList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgRecruitmentSourceList.SelectedRows.Count > 0)
   {
    this.Cursor = Cursors.AppStarting;
    frmRecruitmentSourceEdit pForm = new frmRecruitmentSourceEdit();
    pForm.RecruitmentSourceCode = dgRecruitmentSourceList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.FormRecruitmentSourceList = this;
    pForm.ShowDialog();
    this.Cursor = Cursors.Default;
   }
  }

 }
}