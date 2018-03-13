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
 public partial class frmOffenseEdit : Form
 {
  public frmOffenseEdit() { InitializeComponent(); }
  private frmOffenseList _frmOffenseList;
  private string _strOffenseCode;
  private mdiIpanema _mdiIpanema;
  private Form _frmCaller;

  public string OffenseCode { get { return _strOffenseCode; } set { _strOffenseCode = value; } }
  public frmOffenseList FormOffenseList { get { return _frmOffenseList; } set { _frmOffenseList = value; } }
  public mdiIpanema MDIIpanema { get { return _mdiIpanema; } set { _mdiIpanema = value; } }
  public Form FormCaller { get { return _frmCaller; } set { _frmCaller = value; } }

  private void LoadDetails()
  {
   cmbClass.DataSource = clsOffense.GetDSLClass();
   cmbClass.ValueMember = "pvalue";
   cmbClass.DisplayMember = "ptext";

   using (clsOffense objOffense = new clsOffense())
   {
    objOffense.OffenseCode = _strOffenseCode;
    objOffense.Fill();
    txtOffenseCode.Text = _strOffenseCode;
    chkEnabled.Checked = objOffense.Enabled == "1";
    txtEmployeeName.Text = Employee.GetName(objOffense.Username);
    dtpDateStart.Value = objOffense.DateStart;
    dtpDateEnd.Value = objOffense.DateEnd;
    txtDetails.Text = objOffense.Details;
    cmbClass.SelectedValue = objOffense.ClassCode;
    txtCreatedBy.Text = objOffense.CreateBy;
    txtDateCreated.Text = objOffense.CreateOn.ToString("MMM dd, yyyy");
    txtModifiedBy.Text = objOffense.ModifyBy;
    txtDateModified.Text = objOffense.ModifyOn.ToString("MMM dd, yyyy");
   }
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtDetails.Text == "")
    strErrorMessage += "\nDetails is required.";

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

  private void frmOffenseEdit_Load(object sender, EventArgs e)
  {
   LoadDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (clsOffense objOffense = new clsOffense())
    {
     objOffense.OffenseCode = _strOffenseCode;
     objOffense.Fill();
     objOffense.Details = txtDetails.Text;
     objOffense.ClassCode = cmbClass.SelectedValue.ToString();
     objOffense.DateStart = dtpDateStart.Value;
     objOffense.DateEnd = dtpDateEnd.Value;
     objOffense.Enabled = (chkEnabled.Checked ? "1" : "0");
     objOffense.ModifyBy = HRMSCore.Username;
     objOffense.Update();
     if (_frmCaller == _mdiIpanema)
     {
         _mdiIpanema.LoadDSGOffenseNotification();
         _frmOffenseList.BindOffenseList();
     }
     else
     {
         _frmOffenseList.BindOffenseList();
     }
     this.Close();
    }
   }
   else
   {
    MessageBox.Show(clsMessageBox.MessageBoxErrorAdd, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error);
   }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}