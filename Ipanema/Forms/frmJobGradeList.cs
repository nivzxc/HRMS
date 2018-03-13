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
 public partial class frmJobGradeList : Form
 {
  public frmJobGradeList() { InitializeComponent(); }

  public void BindJobGradeList()
  {
   DataTable tblJobGrade = JobGrade.DSJobGrade();
   dgJobGrade.AutoGenerateColumns = false;
   dgJobGrade.DataSource = tblJobGrade;
   dgJobGrade.Columns[0].DataPropertyName = "jgcode";
   dgJobGrade.Columns[1].DataPropertyName = "jgdesc";
   dgJobGrade.Columns[2].DataPropertyName = "jgorder";
   dgJobGrade.Columns[3].DataPropertyName = "dedulate";
   dgJobGrade.Columns[4].DataPropertyName = "deduut";
   dgJobGrade.Columns[5].DataPropertyName = "payot";
   dgJobGrade.Columns[6].DataPropertyName = "plntcnth";
   dgJobGrade.Columns[7].DataPropertyName = "plntcntb";
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmJobGradeList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   BindJobGradeList();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmJobGradeAdd pForm = new frmJobGradeAdd(this);
   pForm.FormCaller = FormCallers.JobGradeList;
   pForm.ShowDialog();
  }

  private void tbtnModify_Click(object sender, EventArgs e)
  {
   if (dgJobGrade.Rows.Count > 0)
   {
    frmJobGradeEdit pForm = new frmJobGradeEdit(this);
    pForm.FormCaller = FormCallers.JobGradeList;
    pForm.JGCode = dgJobGrade.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgJobGrade.Rows.Count > 0)
   {
    if (MessageBox.Show("Warning: \nModifying job grade settings might cause discrepancies on employee's details associated with it. \nIt is advisable to create a new job grade than to modify/delete existing one.\n\nAre you sure to continue?", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
    {
     JobGrade objJobGrade = new JobGrade();
     objJobGrade.JGCode = dgJobGrade.SelectedRows[0].Cells[0].Value.ToString();
     objJobGrade.Delete();
     this.BindJobGradeList();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindJobGradeList();
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void dgJobGrade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   tbtnModify_Click(null, null);
  }

  private void dgJobGrade_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {

  }

 }
}
