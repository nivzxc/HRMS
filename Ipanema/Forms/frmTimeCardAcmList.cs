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
 public partial class frmTimeCardAcmList : Form
 {
  public frmTimeCardAcmList() { InitializeComponent(); }

  public void LoadCurrentTimeSheetPeriod()
  {
   string strCurrentTimeSheetPeriod = clsTimeSheetPeriod.GetCurrentTimeSheetPeriod();
   using (clsTimeSheetPeriod tsp = new clsTimeSheetPeriod(strCurrentTimeSheetPeriod))
   {
    tsp.Fill();
    dtpFrom.Value = tsp.PeriodFrom;                                   
    dtpTo.Value = tsp.PeriodTo;
   }
  }

  public void BindClusterGrid()
  {   
   dgTimeCard.AutoGenerateColumns = false;
   if (chkViewFILO.Checked)
    dgTimeCard.DataSource = clsTimeCardACM.DSGTimeCardListFILO(dtpFrom.Value, dtpTo.Value, cmbEmployee.SelectedValue.ToString());
   else
    dgTimeCard.DataSource = clsTimeCardACM.DSGTimeCardList(dtpFrom.Value, dtpTo.Value, cmbEmployee.SelectedValue.ToString());
   dgTimeCard.Columns[0].DataPropertyName = "username";
   dgTimeCard.Columns[1].DataPropertyName = "pname";
   dgTimeCard.Columns[2].DataPropertyName = "tdate";
   dgTimeCard.Columns[3].DataPropertyName = "ttime";
   dgTimeCard.Columns[4].DataPropertyName = "action";
   dgTimeCard.Columns[5].DataPropertyName = "door";   
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmTimeCardAcmList_Load(object sender, EventArgs e)
  {
   cmbEmployee.DataSource = Employee.DSLActive();
   cmbEmployee.ValueMember = "pvalue";
   cmbEmployee.DisplayMember = "ptext";

   LoadCurrentTimeSheetPeriod();
   BindClusterGrid();
   this.WindowState = FormWindowState.Maximized;
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { BindClusterGrid(); }
   catch { }
  }

  private void dtpFrom_ValueChanged(object sender, EventArgs e)
  {
   try { BindClusterGrid(); }
   catch { }
  }

  private void dtpTo_ValueChanged(object sender, EventArgs e)
  {
   try { BindClusterGrid(); }
   catch { }
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {

  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {

  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   MessageBox.Show("Disabled");
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   try { BindClusterGrid(); }
   catch { }
  }

  private void dgTimeCard_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
  {
   Color clrBG = Color.LightYellow;
   foreach (DataGridViewRow drw in dgTimeCard.Rows)
   {
    switch (drw.Cells[4].Value.ToString())
    {
     case "In":
      clrBG = Color.Honeydew;
      break;
     case "Out":
      clrBG = Color.AliceBlue;
      break;
     default:
      clrBG = Color.MistyRose;
      break;
    }
    drw.DefaultCellStyle.BackColor = clrBG;
   }
  }

  private void chkViewFILO_CheckedChanged(object sender, EventArgs e)
  {
   BindClusterGrid();
  }

 }
}