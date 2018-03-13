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
 public partial class frmUndertimeList : Form
 {
  public frmUndertimeList() { InitializeComponent(); }

  public void BindUndertimeList()
  {
   string strWhere = "WHERE username IN (SELECT username FROM HR.Employees WHERE lastname LIKE '" + txtRequestor.Text.Replace("'", "") + "%') AND (dateapp BETWEEN '" + clsDateTime.ChangeTimeToStart(dtpFrom.Value).ToString() + "' AND '" + clsDateTime.ChangeTimeToEnd(dtpTo.Value).ToString() + "') AND reason LIKE '%" + txtReason.Text.Replace("'", "") + "%' ";

   if (cmbStatus.SelectedValue.ToString() != "ALL")
    strWhere = strWhere + "AND utstat='" + cmbStatus.SelectedValue + "' ";

   dgUndertimeList.AutoGenerateColumns = false;
   dgUndertimeList.DataSource = clsUndertime.DSGFormUndertimeList(strWhere);
   dgUndertimeList.Columns[0].DataPropertyName = "utcode";
   dgUndertimeList.Columns[1].DataPropertyName = "statuscode";
   dgUndertimeList.Columns[2].DataPropertyName = "status";
   dgUndertimeList.Columns[3].DataPropertyName = "requestor";
   dgUndertimeList.Columns[4].DataPropertyName = "datefile";
   dgUndertimeList.Columns[5].DataPropertyName = "dateapp";
   dgUndertimeList.Columns[6].DataPropertyName = "approver";
   dgUndertimeList.Columns[7].DataPropertyName = "reason";
   
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgUndertimeList.Rows.Count.ToString());
  }

  private Color GetColor(string pStatus)
  {
   Color clrReturn = Color.White;
   switch (pStatus)
   {
    case "F":
     clrReturn = Color.AliceBlue;
     break;
    case "D":
     clrReturn = Color.MistyRose;
     break;
    case "A":
     clrReturn = Color.Honeydew;
     break;
    case "C":
     clrReturn = Color.PeachPuff;
     break;
   }
   return clrReturn;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmUndertimeList_Load(object sender, EventArgs e)
  {
   // Load the current time sheet period
   string strCurrentTimeSheetPeriod = clsTimeSheetPeriod.GetCurrentTimeSheetPeriod();
   using (clsTimeSheetPeriod tsp = new clsTimeSheetPeriod(strCurrentTimeSheetPeriod))
   {
    tsp.Fill();
    dtpFrom.Value = tsp.PeriodFrom;
    dtpTo.Value = tsp.PeriodTo;
   }

   cmbStatus.DataSource = clsUndertime.DdlDsStatusAll();
   cmbStatus.ValueMember = "pvalue";
   cmbStatus.DisplayMember = "ptext";

   BindUndertimeList();
   this.WindowState = FormWindowState.Maximized;
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindUndertimeList();
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgUndertimeList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsUndertime undertime = new clsUndertime();
     undertime.UndertimeCode = dgUndertimeList.SelectedRows[0].Cells[0].Value.ToString();
     undertime.DeleteAdmin();
     BindUndertimeList();
    }
   }
  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {
   if (dgUndertimeList.SelectedRows.Count > 0)
   {
    frmUndertimeEdit pForm = new frmUndertimeEdit();
    pForm.UndertimeCode = dgUndertimeList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.FormUndertimeList = this;
    pForm.ShowDialog();
   }
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmUndertimeNew pForm = new frmUndertimeNew();
   pForm.FormUndertimeList = this;
   pForm.ShowDialog();
  }


  private void dtpFrom_ValueChanged(object sender, EventArgs e)
  {
   try { BindUndertimeList(); }
   catch { }
  }

  private void dtpTo_ValueChanged(object sender, EventArgs e)
  {
   try { BindUndertimeList(); }
   catch { }
  }

  private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { BindUndertimeList(); }
   catch { }
  }

  private void txtRequestor_TextChanged(object sender, EventArgs e)
  {
   BindUndertimeList();
  }

  private void txtReason_TextChanged(object sender, EventArgs e)
  {
   BindUndertimeList();
  }

  private void frmUndertimeList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgUndertimeList.Rows.Count.ToString());
  }

  private void frmUndertimeList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");
  }

  private void dgUndertimeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   try
   {
    if (dgUndertimeList.SelectedRows.Count > 0)
    {
     frmUndertimeEdit pForm = new frmUndertimeEdit();
     pForm.UndertimeCode = dgUndertimeList.Rows[e.RowIndex].Cells[0].Value.ToString();
     pForm.FormUndertimeList = this;
     pForm.ShowDialog();
    }
   }
   catch { }
  }

  private void dgUndertimeList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
  {
   foreach (DataGridViewRow drw in dgUndertimeList.Rows)
    drw.DefaultCellStyle.BackColor = GetColor(drw.Cells[1].Value.ToString());
  }

 }
}
