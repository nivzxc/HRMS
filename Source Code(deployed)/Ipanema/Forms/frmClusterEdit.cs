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
 public partial class frmClusterEdit : Form
 {
  public frmClusterEdit() { InitializeComponent(); }

  private string _strClusterCode;
  private frmClusterList _frmClusterList;

  public string ClusterCode { set { _strClusterCode = value; } get { return _strClusterCode; } }
  public frmClusterList FormClusterList { set { _frmClusterList = value; } get { return _frmClusterList; } }

  private void BindDetails()
  {
   txtClusterCode.Text = _strClusterCode;
   using (clsCluster cluster = new clsCluster())
   {
    cluster.ClusterCode = _strClusterCode;
    cluster.Fill();
    txtClusterName.Text = cluster.ClusterName;
    txtDescription.Text = cluster.Description;
    chkEnabled.Checked = (cluster.Enabled == "1" ? true : false);
    txtCreatedBy.Text = cluster.CreateBy;
    txtCreateDate.Text = cluster.CreateOn.ToString("MMM dd, yyyy hh:mm tt");
    txtModifiedBy.Text = cluster.UpdateBy;
    txtDateModified.Text = cluster.UpdateOn.ToString("MMM dd, yyyy hh:mm tt");
   }
  }

  private bool IsCorrectData()
  {
   string strErrorMessage = "";

   if (txtClusterName.Text == "")
    strErrorMessage = "Cluster name is required.";

   if (strErrorMessage != "")
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

   return strErrorMessage == "";
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmClusterEdit_Load(object sender, EventArgs e)
  {
   BindDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (clsCluster cluster = new clsCluster())
    {
     cluster.ClusterCode = _strClusterCode;
     cluster.ClusterName = txtClusterName.Text;
     cluster.Description = txtDescription.Text;
     cluster.Enabled = (chkEnabled.Checked ? "1" : "0");      
     cluster.Update();
    }
    _frmClusterList.BindClusterGrid();
    this.Close();
   }
  }
 }
}
