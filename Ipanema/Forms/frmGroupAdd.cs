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
 public partial class frmGroupAdd : Form
 {
  private frmGroupList _frmGroupList;

  public frmGroupList FormGroupList { get { return _frmGroupList; } set { _frmGroupList = value; } }

  public frmGroupAdd()
  {
   InitializeComponent();
  }

  private void InitializeFields()
  {
   txtGroupCode.Text = Group.GenerateCode();
   txtGroupName.Text = "";
   cmbDivision.DataSource = Division.GetDSL();
   cmbDivision.ValueMember = "pvalue";
   cmbDivision.DisplayMember = "ptext";

   txtGroupName.Focus();
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtGroupName.Text == "")
    strErrorMessage += "\nGroup name is required.";

   if (strErrorMessage != "")
   {
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }


  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////
  
  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void frmGroupAdd_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    Group group = new Group();
    group.GroupCode = txtGroupCode.Text;
    group.GroupName = txtGroupName.Text;
    group.DivisionCode = cmbDivision.SelectedValue.ToString();
    if (group.Insert() > 0)
    {

                    if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        _frmGroupList.BindGroupList();
                        InitializeFields();
                    }
                    else {
                        this.Close();
                    }
                        
    }
    else
    {
     MessageBox.Show(clsMessageBox.MessageBoxErrorAdd, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
   }
  }

 }
}
