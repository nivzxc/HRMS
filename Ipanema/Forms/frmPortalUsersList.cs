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
 public partial class frmPortalUsersList : Form
 {
  public frmPortalUsersList() { InitializeComponent(); }


  public void BindUsersList()
  {
   string strWhere = "";
   if (cmbStatus.SelectedValue.ToString() != "ALL")
    strWhere = "WHERE Users.Users.pstatus='" + cmbStatus.SelectedValue + "' ";

   dgPortalUsersList.AutoGenerateColumns = false;
   dgPortalUsersList.DataSource = clsUsers.GetDSG(strWhere);
   dgPortalUsersList.Columns[0].DataPropertyName = "username";
   dgPortalUsersList.Columns[1].DataPropertyName = "pname";
   dgPortalUsersList.Columns[2].DataPropertyName = "emptitle";
   dgPortalUsersList.Columns[3].DataPropertyName = "pstatus";

   foreach (DataGridViewRow dgvr in dgPortalUsersList.Rows)
    dgvr.Cells[3].Value = (dgvr.Cells[3].Value.ToString() == "1" ? "Enabled" : "Disabled");
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgPortalUsersList.Rows.Count.ToString());
  }

  ////////////////////////////////
  ///////// Forms Events /////////
  ////////////////////////////////

  private void frmPortalUsersList_Load(object sender, EventArgs e)
  {
   cmbStatus.DataSource = clsUsers.GetDSLStatusAll();
   cmbStatus.ValueMember = "pvalue";
   cmbStatus.DisplayMember = "ptext";

   BindUsersList();

   this.WindowState = FormWindowState.Maximized;
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   Cursor.Current = Cursors.AppStarting;
   frmPortalUsersNew pForm = new frmPortalUsersNew();
   pForm.FormPortalUsersList = this;
   pForm.ShowDialog();
   Cursor.Current = Cursors.Default;
  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {
   if (dgPortalUsersList.SelectedRows.Count > 0)
   {
    Cursor.Current = Cursors.AppStarting;
    frmPortalUsersEdit pForm = new frmPortalUsersEdit();
    pForm.Username = dgPortalUsersList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.FormPortalUsersList = this;
    pForm.ShowDialog();
    Cursor.Current = Cursors.Default;
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgPortalUsersList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsUsers users = new clsUsers();
     users.Username = dgPortalUsersList.SelectedRows[0].Cells[0].Value.ToString();
     users.Delete();
     BindUsersList();
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindUsersList();
  }

  private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
  {
   BindUsersList();
  }

  private void dgPortalUsersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   tbtnEdit_Click(null, null);
  }

  private void frmPortalUsersList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgPortalUsersList.Rows.Count.ToString());
  }

  private void frmPortalUsersList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");
  }

 }
}