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
 public partial class frmEmployeeMovementAdd : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strEmployeeName;
  private string _strUsername;

  public frmEmployeeMovementAdd(frmEmployeeDetails pfrmEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pfrmEmployeeDetails;
  }

  public string EmployeeName { set { _strEmployeeName = value; } get { return _strEmployeeName; } }
  public string Username { set { _strUsername = value; } get { return _strUsername; } }

  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

  private void ClearFields()
  {
   dtpFrom.Value = DateTime.Now;
   dtpTo.Value = DateTime.Now;
   txtPosition.Text = "";
   txtRemarks.Text = "";
   BindDivision();
   BindGroup();
   BindDepartment();
   BindJGCode();

   dtpFrom.Focus();
  }

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (dtpFrom.Value >= dtpTo.Value)
    strErrorMessage = "Invalid effectivity date range.";
   if (txtPosition.Text == "")
    strErrorMessage += "\nPosition field is required.";

   if (strErrorMessage != "")
   {
    blnReturn = false;
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   }

   return blnReturn;
  }

  private void BindDivision()
  {
   cmbDivision.DataSource = Division.GetDSL();
   cmbDivision.DisplayMember = "ptext";
   cmbDivision.ValueMember = "pvalue";
  }

  private void BindGroup()
  {
   cmbGroup.DataSource = Group.GetDSL();
   cmbGroup.DisplayMember = "ptext";
   cmbGroup.ValueMember = "pvalue";
  }

  private void BindDepartment()
  {
   cmbDepartment.DataSource = Department.GetDSL();
   cmbDepartment.DisplayMember = "ptext";
   cmbDepartment.ValueMember = "pvalue";
  }

  private void BindJGCode()
  {
   cmbJGCode.DataSource = JobGrade.DSLJGCode();
   cmbJGCode.DisplayMember = "ptext";
   cmbJGCode.ValueMember = "pvalue";
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmEmployeeMovementAdd_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   ClearFields();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intResults = 0;
    using (clsEmployeeMovement em = new clsEmployeeMovement())
    {
     em.Username = _strUsername;
     em.EffectivityFrom = dtpFrom.Value;
     em.EffectivityTo = dtpTo.Value;
     em.DivisionCode = cmbDivision.SelectedValue.ToString();
     em.GroupCode = cmbGroup.SelectedValue.ToString();
     em.DepartmentCode = cmbDepartment.SelectedValue.ToString();
     em.JGCode = cmbJGCode.SelectedValue.ToString();
     em.Position = txtPosition.Text;
     em.Remarks = txtRemarks.Text;
     em.CreateBy = HRMSCore.Username;
     em.CreateOn = DateTime.Now;
     em.ModifyBy = HRMSCore.Username;
     em.ModifyOn = DateTime.Now;
     intResults = em.Add();
    }

    if (intResults > 0)
    {
     _frmEmployeeDetails.BindMovementList();
     if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      ClearFields();
     else
      this.Close();
    }
   }
  }

 }
}
