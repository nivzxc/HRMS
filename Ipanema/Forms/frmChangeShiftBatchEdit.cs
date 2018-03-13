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
 public partial class frmChangeShiftBatchEdit : Form
 {
  public frmChangeShiftBatchEdit() { InitializeComponent(); }

  private string _strChangeShiftBatchCode;
  private frmChangeShiftBatchList _frmChangeShiftBatchList;
  public string ChangeShiftBatchCode { set { _strChangeShiftBatchCode = value; } get { return _strChangeShiftBatchCode; } }
  public frmChangeShiftBatchList FormChangeShiftBatchList { set { _frmChangeShiftBatchList = value; } get { return _frmChangeShiftBatchList; } }
  
  private bool IsCorrectData()
  {
   string strErrorMessage = "";

   if (txtReason.Text == "")
    strErrorMessage = "Reason is required.";

   if (strErrorMessage != "")
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

   return strErrorMessage == "";
  }

  private void BindDetails()
  {
   cmbShiftCode.DataSource = clsShift.GetDdlDS();
   cmbShiftCode.ValueMember = "pvalue";
   cmbShiftCode.DisplayMember = "ptext";

   txtChangeShiftBatchCode.Text = _strChangeShiftBatchCode;
   using (clsChangeShiftBatch csb = new clsChangeShiftBatch())
   {
    csb.ChangeScheduleBatchCode = _strChangeShiftBatchCode;
    csb.Fill();
    txtApplicationDate.Text = csb.ApplicationDate.ToString("MMM dd, yyyy");
    cmbShiftCode.SelectedValue = csb.ShiftCode;
    txtReason.Text = csb.Reason;
    txtCreatedBy.Text = csb.CreatedBy;
    txtCreatedDate.Text = csb.CreatedOn.ToString("MMM dd, yyyy hh:mm tt");
    txtModifiedBy.Text = csb.ModifiedBy;
    txtModifiedDate.Text = csb.ModifiedOn.ToString("MMM dd, yyyy hh:mm tt");
   }
  }

  private void BindList()
  {
   DataTable tblIncluded = clsChangeShiftBatch.GetIncludedEmployee(_strChangeShiftBatchCode);
   lvIncluded.Items.Clear();
   foreach (DataRow drw in tblIncluded.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Tag = drw["username"].ToString();
    lvi.Text = drw["lastname"].ToString() + ", " + drw["firname"].ToString();
    lvIncluded.Items.Add(lvi);
   }

   DataTable tblExclude = clsChangeShiftBatch.GetExcludedEmployee(_strChangeShiftBatchCode);
   lvExcluded.Items.Clear();
   foreach (DataRow drw in tblExclude.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Tag = drw["username"].ToString();
    lvi.Text = drw["lastname"].ToString() + ", " + drw["firname"].ToString();
    lvExcluded.Items.Add(lvi);
   }

   lvIncluded.Columns[0].Width = (lvIncluded.Items.Count > 22 ? 182 : 200);
   lvExcluded.Columns[0].Width = (lvExcluded.Items.Count > 22 ? 182 : 200);
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (clsChangeShiftBatch objChangeShiftBatch = new clsChangeShiftBatch())
    {
     objChangeShiftBatch.ChangeScheduleBatchCode = _strChangeShiftBatchCode;
     objChangeShiftBatch.Fill();
     objChangeShiftBatch.Reason = txtReason.Text;
     objChangeShiftBatch.ShiftCode = cmbShiftCode.SelectedValue.ToString();
     objChangeShiftBatch.Update();
    }
    _frmChangeShiftBatchList.BindChangeShiftGrid();
    this.Close();
   }
  }

  private void frmChangeShiftBatchEdit_Load(object sender, EventArgs e)
  {
   this.BindDetails();
   this.BindList();
  }

  private void btnInclude_Click(object sender, EventArgs e)
  {
   if (lvExcluded.SelectedItems.Count > 0)
   {
    clsChangeShiftBatch.InsertMember(_strChangeShiftBatchCode, lvExcluded.SelectedItems[0].Tag.ToString());
    this.BindList();
   }
  }

  private void btnExclude_Click(object sender, EventArgs e)
  {
   if (lvIncluded.SelectedItems.Count > 0)
   {
    clsChangeShiftBatch.RemoveMember(_strChangeShiftBatchCode, lvIncluded.SelectedItems[0].Tag.ToString());
    this.BindList();
   }
  }

  private void btnIncludeAll_Click(object sender, EventArgs e)
  {
   foreach (ListViewItem itm in lvExcluded.Items)
   {
    clsChangeShiftBatch.InsertMember(_strChangeShiftBatchCode, itm.Tag.ToString());
   }
   this.BindList();
  }

  private void btnExcludeAll_Click(object sender, EventArgs e)
  {
   foreach (ListViewItem itm in lvIncluded.Items)
   {
    clsChangeShiftBatch.RemoveMember(_strChangeShiftBatchCode, itm.Tag.ToString());
   }
   this.BindList();
  }

 }
}