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
 public partial class frmDivisionAdd : Form
 {
  private FormCallers _FormCaller;
  private frmDivisionList _frmDivisionList;

  public frmDivisionAdd(frmDivisionList pfrmDivisionList)
  {
   _frmDivisionList = pfrmDivisionList;
   InitializeComponent();
  }

  public FormCallers FormCaller { get { return _FormCaller; } set { _FormCaller = value; } }

  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

  private void InitializeFields()
  {
   txtDivisionCode.Text = "";
   txtDivisionName.Text = "";
   txtDescription.Text = "";
   LoadEmployees();
   txtDivisionCode.Focus();
  }

  public void LoadEmployees()
  {
   cmbDivisionHead.DataSource = Employee.DSLActive();
   cmbDivisionHead.DisplayMember = "ptext";
   cmbDivisionHead.ValueMember = "pvalue";
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtDivisionCode.Text == "")
    strErrorMessage = "Division code is required.";
   else if (txtDivisionCode.Text.Length != 6)
    strErrorMessage = "Division code should contain 6 characters.";

   if (txtDivisionName.Text == "")
    strErrorMessage += "\nDivision name is required.";
   if (txtDivisionShortName.Text.TrimEnd().Length == 0)
       strErrorMessage += "\nShort name is required.";
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
  
  private void frmDivisionAdd_Load(object sender, EventArgs e)
  {
   txtDivisionCode.Focus();
   LoadEmployees();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    Division objDivision = new Division();
    objDivision.Code = txtDivisionCode.Text;
    objDivision.Name = txtDivisionName.Text;
    objDivision.Description = txtDescription.Text;
    objDivision.ShortName = txtDivisionShortName.Text;
    objDivision.Head = cmbDivisionHead.SelectedValue.ToString();
    if (objDivision.Insert() > 0)
    {
     switch (_FormCaller)
     {
      case FormCallers.DivisionList:
       _frmDivisionList.BindDivisionList();
       break;
     }

     if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
      InitializeFields();
     else
      this.Close();
    }
    else
    {
     MessageBox.Show(clsMessageBox.MessageBoxErrorAdd, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
   }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}
