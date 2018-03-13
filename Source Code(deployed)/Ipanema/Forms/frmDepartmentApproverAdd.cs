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
 public partial class frmDepartmentApproverAdd : Form
 {
  public frmDepartmentApproverAdd() { InitializeComponent(); }

  private string _strDepartmentCode;
  private FormCallers _FormCaller;
  private frmDepartmentEdit _frmDepartmentEdit;

  public frmDepartmentEdit FormDepartmentEdit { set { _frmDepartmentEdit = value; } get { return _frmDepartmentEdit; } }
  public FormCallers FormCaller { set { _FormCaller = value; } get { return _FormCaller; } }
  public string DepartmentCode { set { _strDepartmentCode = value; } get { return _strDepartmentCode; } }

  private void InitializeFields()
  {
   cmbEmployee.DataSource = Employee.DSLActive();
   cmbEmployee.ValueMember = "pvalue";
   cmbEmployee.DisplayMember = "ptext";

   cmbDepartment.DataSource = Department.GetDSLActive();
   cmbDepartment.ValueMember = "pvalue";
   cmbDepartment.DisplayMember = "ptext";

   chkLeave.Checked = false;
   chkUndertime.Checked = false;
   chkOB.Checked = false;
   chkOvertime.Checked = false;
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";


   if (chkLeave.Checked == false && chkUndertime.Checked == false && chkOB.Checked == false && chkOvertime.Checked == false)
    strErrorMessage = "You should atleast check 1 item.<br>";

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

  private void frmDepartmentApproverAdd_Load(object sender, EventArgs e)
  {
   InitializeFields();
   if (_FormCaller == FormCallers.DepartmentApproverAdd)
   {
    if (cmbDepartment.Items.Count > 0)
    {
     cmbDepartment.SelectedValue = _strDepartmentCode;
     cmbDepartment.Enabled = false;
    }
   }

  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (clsDepartmentApprover cda = new clsDepartmentApprover())
    {
     cda.DepartmentCode = cmbDepartment.SelectedValue.ToString();
     cda.Username = cmbEmployee.SelectedValue.ToString();
     cda.CanApproveLeave = (chkLeave.Checked ? "1" : "0");
     cda.CanApproveUT = (chkUndertime.Checked ? "1" : "0");
     cda.CanApproveOB = (chkOB.Checked ? "1" : "0");
     cda.CanApproveOT = (chkOvertime.Checked ? "1" : "0");
     cda.Insert();
    }
    _frmDepartmentEdit.LoadApproverList();
   }
   this.Close();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}
