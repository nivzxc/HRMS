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
 public partial class frmGroupEdit : Form
 {
  private string _strGroupCode;
  private frmGroupList _frmGroupList;

  public string GroupCode { get { return _strGroupCode; } set { _strGroupCode = value; } }
  public frmGroupList FormGroupList { get { return _frmGroupList; } set { _frmGroupList = value; } }

  public frmGroupEdit()
  {
   InitializeComponent();
  }

  private void BindDetails()
  {
   cmbDivision.DataSource = Division.GetDSL();
   cmbDivision.ValueMember = "pvalue";
   cmbDivision.DisplayMember = "ptext";

   using (Group group = new Group(_strGroupCode))
   {
    group.Fill();
    txtGroupCode.Text = _strGroupCode;
    txtGroupName.Text = group.GroupName;
    cmbDivision.SelectedValue = group.DivisionCode;
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void frmGroupEdit_Load(object sender, EventArgs e)
  {
   BindDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   int intResults = 0;
   using (Group group = new Group(_strGroupCode))
   {
    group.GroupName = txtGroupName.Text;
    group.DivisionCode = cmbDivision.SelectedValue.ToString();
    intResults = group.Update();
   }

   if (intResults > 0)
   {
    _frmGroupList.BindGroupList();
    this.Close();
   }
   else
   {
    MessageBox.Show(clsMessageBox.MessageBoxErrorUpdate, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error);
   }
  }

 }
}
