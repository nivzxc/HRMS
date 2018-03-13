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
 public partial class frmClusterAdd : Form
 {
  public frmClusterAdd() { InitializeComponent(); }
  private frmClusterList _frmClusterList;

  public frmClusterList FormClusterList { set { _frmClusterList = value; } get { return _frmClusterList; } }

  private void InitializeFields()
  {
   txtClusterCode.Text = clsCluster.GenerateCode();
   txtClusterName.Text = "";
   txtDescription.Text = "";
   txtClusterName.Focus();
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

  private void frmClusterAdd_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (this.IsCorrectData())
   {
    using (clsCluster cluster = new clsCluster())
    {
     cluster.ClusterName = txtClusterName.Text;
     cluster.Description = txtDescription.Text;
     cluster.Enabled = "1";
     cluster.Insert();
    }
    _frmClusterList.BindClusterGrid();
    this.Close();    
   }
  }

 }
}
