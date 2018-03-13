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
 public partial class frmRCList : Form
 {
  public frmRCList() { InitializeComponent(); }

  public void BindRCList()
  {
   dgRCList.AutoGenerateColumns = false;
   dgRCList.DataSource = clsRC.DSGMainForm();
   dgRCList.Columns[0].DataPropertyName = "RCCode";
   dgRCList.Columns[1].DataPropertyName = "RCName";
   dgRCList.Columns[2].DataPropertyName = "Division";
   dgRCList.Columns[3].DataPropertyName = "GPCode";
   dgRCList.Columns[4].DataPropertyName = "Company";
   dgRCList.Columns[5].DataPropertyName = "Status";
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgRCList.Rows.Count.ToString());
  }

  //////////////////////////////  
  ///////// Form Event ///////// 
  //////////////////////////////

  private void frmRCList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   BindRCList();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
      frmRCAdd frmAdd = new frmRCAdd();
      frmAdd.FormCallerRCList = this;
      frmAdd.ShowDialog();
  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {
      frmRCEdit objfrmRCEdit = new frmRCEdit();
      objfrmRCEdit.FormRCList = this;
      objfrmRCEdit.RCCode = dgRCList.SelectedRows[0].Cells[0].Value.ToString();
      objfrmRCEdit.ShowDialog();
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
      if(MessageBox.Show("Are you sure you want to delete the record " + dgRCList.SelectedRows[0].Cells[1].Value.ToString() + "?",clsMessageBox.MessageBoxText,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
      {
          using (clsRC objclsRc = new clsRC())
          {
              objclsRc.RcCode = dgRCList.SelectedRows[0].Cells[0].Value.ToString();
              objclsRc.Delete();
              BindRCList();
          }
      }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindRCList();
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void dgRCList_DoubleClick(object sender, EventArgs e)
  {
      tbtnEdit_Click(null, null);
  }
 }

}