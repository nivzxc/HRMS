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
 public partial class frmOBList : Form
 {
  public frmOBList() { InitializeComponent(); }

  public void BindOBList()
  {
   dgOBList.AutoGenerateColumns = false;
   dgOBList.DataSource = OfficialBusiness.GetDSGOBMainForm(txtRequestor.Text, txtReason.Text, dtpFrom.Value, dtpTo.Value, cmbOBType.SelectedValue.ToString(), cmbStatus.SelectedValue.ToString());
   dgOBList.Columns[0].DataPropertyName = "OBCode";
   dgOBList.Columns[1].DataPropertyName = "StatusCode";
   dgOBList.Columns[2].DataPropertyName = "StatusDesc";
   dgOBList.Columns[3].DataPropertyName = "Requestor";
   dgOBList.Columns[4].DataPropertyName = "OBTypeDesc";
   dgOBList.Columns[5].DataPropertyName = "DateFile";
   dgOBList.Columns[6].DataPropertyName = "DateStart";
   dgOBList.Columns[7].DataPropertyName = "DateEnd";
   dgOBList.Columns[8].DataPropertyName = "RenderedTo";
   dgOBList.Columns[9].DataPropertyName = "Reason";
   dgOBList.Columns[10].DataPropertyName = "RApprover";
   dgOBList.Columns[11].DataPropertyName = "HApprover";   
  
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgOBList.Rows.Count.ToString());
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindOBList();
  }

  private void frmOBList_Load(object sender, EventArgs e)
  {
   cmbOBType.DataSource = OfficialBusiness.DdlDsOBTypeAll();
   cmbOBType.ValueMember = "pvalue";
   cmbOBType.DisplayMember = "ptext";

   // Load the current time sheet period
   string strCurrentTimeSheetPeriod = clsTimeSheetPeriod.GetCurrentTimeSheetPeriod();
   using (clsTimeSheetPeriod tsp = new clsTimeSheetPeriod(strCurrentTimeSheetPeriod))
   {
    tsp.Fill();
    dtpFrom.Value = tsp.PeriodFrom;
    dtpTo.Value = tsp.PeriodTo;
   }

   cmbStatus.DataSource = LeaveApplication.DdlDsStatusAll();
   cmbStatus.ValueMember = "pvalue";
   cmbStatus.DisplayMember = "ptext";

   BindOBList();

   this.WindowState = FormWindowState.Maximized;
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmOBNew pForm = new frmOBNew();
   pForm.FormObList = this;
   pForm.ShowDialog();
  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {
   if (dgOBList.SelectedRows.Count > 0)
   {
    frmOBEdit pForm = new frmOBEdit();
    pForm.FormOBList = this;
    pForm.OBCode = dgOBList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgOBList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     OfficialBusiness ob = new OfficialBusiness();
     ob.OBCode = dgOBList.SelectedRows[0].Cells[0].Value.ToString();
     if (ob.DeleteAdmin() > 0)
      BindOBList();
    }
   }
  }

  private void cmbOBType_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { BindOBList(); }
   catch { }
  }

  private void dtpFrom_ValueChanged(object sender, EventArgs e)
  {
   try { BindOBList(); }
    catch { }

  }

  private void dtpTo_ValueChanged(object sender, EventArgs e)
  {
   if (dtpFrom.Value <= dtpTo.Value)
   {
    try { BindOBList(); }
    catch { }
   }
  }

  private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { BindOBList(); }
   catch { }
  }

  private void dgOBList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
  {
   try
   {
    foreach (DataGridViewRow drw in dgOBList.Rows)
     drw.DefaultCellStyle.BackColor = OfficialBusiness.GetLVBGColor(drw.Cells[1].Value.ToString());
   }
   catch { }
  }

  private void txtRequestor_TextChanged(object sender, EventArgs e)
  {
   try { BindOBList(); }
   catch { }
  }

  private void txtReason_TextChanged(object sender, EventArgs e)
  {
   try { BindOBList(); }
   catch { }
  }

  private void dgOBList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgOBList.SelectedRows.Count > 0)
   {
    frmOBEdit pForm = new frmOBEdit();
    pForm.FormOBList = this;
    pForm.OBCode = dgOBList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.ShowDialog();
   }
  }

  private void frmOBList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgOBList.Rows.Count.ToString());
  }

  private void frmOBList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");
  }

 }
}