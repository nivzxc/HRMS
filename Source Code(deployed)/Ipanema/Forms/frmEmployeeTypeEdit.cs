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
 public partial class frmEmployeeTypeEdit : Form
 {
  public frmEmployeeTypeEdit() { InitializeComponent(); }

  private string _strEmployeeTypeCode;
  private frmEmployeeTypeList _frmEmployeeTypeList;

  public string EmployeeTypeCode { set { _strEmployeeTypeCode = value; } get { return _strEmployeeTypeCode; } }
  public frmEmployeeTypeList FormEmployeeTypeList { set { _frmEmployeeTypeList = value; } get { return _frmEmployeeTypeList; } }

  private void BindFields()
  {
   txtEmployeeTypeCode.Text = _strEmployeeTypeCode;
   using (clsEmployeeType et = new clsEmployeeType())
   {
    et.EmployeeTypeCode = _strEmployeeTypeCode;
    et.Fill();
    txtType.Text = et.Name;
    txtDetails.Text = et.Description;
   }
   txtType.Focus();
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtType.Text == "")
    strErrorMessage = "Employee type name is required.";

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
 
  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (clsEmployeeType et = new clsEmployeeType())
    {
     et.EmployeeTypeCode = _strEmployeeTypeCode;
     et.Name = txtType.Text;
     et.Description = txtDetails.Text;
     et.Update();
     _frmEmployeeTypeList.BindEmployeeTypeList();
     this.Close();
    }
   }
  }

  private void frmEmployeeTypeEdit_Load(object sender, EventArgs e)
  {
   BindFields();
  }

 }
}
