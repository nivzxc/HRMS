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
 public partial class frmOffenseList : Form
 {

     private string _strIndicator;
     private mdiIpanema _mdiIpanema;
     private Form _frmCaller;
     private string _stroffensecode;

     public string Indicator { get { return _strIndicator; } set { _strIndicator = value; } }
     public mdiIpanema MDIIpanema { get { return _mdiIpanema; } set { _mdiIpanema = value; } }
     public Form FormCaller { get { return _frmCaller; } set { _frmCaller = value; } }
     public string OffenseCode { get { return _stroffensecode; } set { _stroffensecode = value; } }

  public void BindOffenseList()
  {
   dgOffenseList.AutoGenerateColumns = false;
   dgOffenseList.DataSource = clsOffense.GetDSGMainForm();
   dgOffenseList.Columns[0].DataPropertyName = "OffenseCode";
   dgOffenseList.Columns[1].DataPropertyName = "Name";
   dgOffenseList.Columns[2].DataPropertyName = "Details";
   dgOffenseList.Columns[3].DataPropertyName = "Class";
   dgOffenseList.Columns[4].DataPropertyName = "DateStart";
   dgOffenseList.Columns[5].DataPropertyName = "DateEnd";
   dgOffenseList.Columns[6].DataPropertyName = "Enabled";
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgOffenseList.Rows.Count.ToString());

   if (_strIndicator == "1")
   {
       _mdiIpanema.LoadDSGOffenseNotification();
   }
  }

  //////////////////////////////  
  ///////// Form Event ///////// 
  //////////////////////////////

  public frmOffenseList()
  {
   InitializeComponent();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmOffenseAdd xForm = new frmOffenseAdd();
   xForm.FormOffenseList = this;
   xForm.ShowDialog();
  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {
   if (dgOffenseList.SelectedRows.Count > 0)
   {
    frmOffenseEdit xForm = new frmOffenseEdit();
    xForm.FormOffenseList = this;
    xForm.FormCaller = this;
    xForm.OffenseCode = dgOffenseList.SelectedRows[0].Cells[0].Value.ToString();
    xForm.ShowDialog();
   }
  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   if (dgOffenseList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
    {
     using (clsOffense objOffense = new clsOffense())
     {
      objOffense.OffenseCode = dgOffenseList.SelectedRows[0].Cells[0].Value.ToString();
      objOffense.Delete();
      BindOffenseList();
     }
    }
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindOffenseList(); 
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void frmOffenseList_Load(object sender, EventArgs e)
  {
   this.WindowState = FormWindowState.Maximized;
   BindOffenseList();

   if (_strIndicator == "1")
   {
       frmOffenseEdit objfrmOffenseEdit = new frmOffenseEdit();
       objfrmOffenseEdit.MDIIpanema = _mdiIpanema;
       objfrmOffenseEdit.FormCaller = _mdiIpanema;
       objfrmOffenseEdit.OffenseCode = _stroffensecode;
       objfrmOffenseEdit.FormOffenseList = this;
       objfrmOffenseEdit.ShowDialog();
   }
  }

  private void dgOffenseList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgOffenseList.SelectedRows.Count > 0)
   {
    frmOffenseEdit xForm = new frmOffenseEdit();
    xForm.FormOffenseList = this;
    xForm.FormCaller = this;
    xForm.OffenseCode = dgOffenseList.SelectedRows[0].Cells[0].Value.ToString();
    xForm.ShowDialog();
   }
  }

 }
}