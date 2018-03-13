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
 public partial class frmDepartmentAdd : Form
 {
  public frmDepartmentAdd() { InitializeComponent(); }

  private frmDepartmentList _frmDepartmentList;

  public frmDepartmentList FormDepartmentList { set { _frmDepartmentList = value; } get { return _frmDepartmentList; } }

  private void InitializeFields()
  {

   txtDepartmentCode.Text = Department.GenerateCode();
   txtDepartment.Text = "";

   cmbDivision.DataSource = Division.GetDSL();
   cmbDivision.ValueMember = "pvalue";
   cmbDivision.DisplayMember = "ptext";

   if (cmbDivision.Items.Count > 0)
   {
    cmbGroup.DataSource = Group.GetDSL(cmbDivision.SelectedValue.ToString());
    cmbGroup.ValueMember = "pvalue";
    cmbGroup.DisplayMember = "ptext";
   }
   txtDepartment.Focus();
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtDepartment.Text == "")
    strErrorMessage = "Department name is required.";

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

  private void frmDepartmentAdd_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (Department objDepartment = new Department())
    {
     objDepartment.DepartmentName = txtDepartment.Text;
     objDepartment.GroupCode = cmbGroup.SelectedValue.ToString();
     objDepartment.DivisionCode = cmbDivision.SelectedValue.ToString();
     objDepartment.Status = "1";
     objDepartment.Insert();
    }
    if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
     InitializeFields();
    else
     this.Close();
    _frmDepartmentList.BindDepartmentList();
   }
  }

  private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
  {
   try
   {
    cmbGroup.DataSource = Group.GetDSL(cmbDivision.SelectedValue.ToString());
    cmbGroup.ValueMember = "pvalue";
    cmbGroup.DisplayMember = "ptext";
   }
   catch { }
  }

 }
}