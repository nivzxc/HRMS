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
 public partial class frmDivisionEdit : Form
 {

  private string _strDivisionCode;
  private frmDivisionList _frmDivisionList;

  public string DivisionCode { set { _strDivisionCode = value; } }
  public frmDivisionList FormDivisionList { set { _frmDivisionList = value; } get { return _frmDivisionList; } }

  public frmDivisionEdit(frmDivisionList pfrmDivisionList)
  {
   _frmDivisionList = pfrmDivisionList;
   InitializeComponent();
  }

  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

  private void LoadDetails()
  {
   cmbDivisionHead.DataSource = Employee.DSLActive();
   cmbDivisionHead.DisplayMember = "ptext";
   cmbDivisionHead.ValueMember = "pvalue";

   txtDivisionCode.Text = _strDivisionCode;
   Division objDivision = new Division(_strDivisionCode);
   objDivision.Fill();
   txtDivisionName.Text = objDivision.Name;
   txtDescription.Text = objDivision.Description;
   txtDivisionShortName.Text = objDivision.ShortName;
   cmbDivisionHead.SelectedValue = objDivision.Head;
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtDivisionName.Text == "")
    strErrorMessage += "\nDivision name is required.";

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

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    Division objDivision = new Division();
    objDivision.Code = txtDivisionCode.Text;
    objDivision.Name = txtDivisionName.Text;
    objDivision.ShortName = txtDivisionShortName.Text;
    objDivision.Description = txtDescription.Text;
    objDivision.Head = cmbDivisionHead.SelectedValue.ToString();
    if (objDivision.Update() > 0)
    {
     _frmDivisionList.BindDivisionList();
     this.Close();
    }
    else
    {
     MessageBox.Show(clsMessageBox.MessageBoxErrorAdd, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
   }
  }

  private void frmDivisionEdit_Load(object sender, EventArgs e)
  {
   txtDivisionName.Focus();
   LoadDetails();
  }

 }
}
