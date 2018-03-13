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
 public partial class frmEmployeeMovementEdit : Form
 {
  private frmEmployeeDetails _frmEmployeeDetails;
  private string _strMovementCode;
  private string _strEmployeeName;

  public frmEmployeeMovementEdit(frmEmployeeDetails pfrmEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pfrmEmployeeDetails;
  }

  public string MovementCode { set { _strMovementCode = value; } get { return _strMovementCode; } }
  public string EmployeeName { set { _strEmployeeName = value; } get { return _strEmployeeName; } }

  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////

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

  private void LoadDetails()
  {
   BindDivision();
   BindGroup();
   BindDepartment();
   BindJGCode();

   using (clsEmployeeMovement em = new clsEmployeeMovement())
   {
    em.MovementCode = _strMovementCode;
    em.Fill();
    dtpFrom.Value = em.EffectivityFrom;
    dtpTo.Value = em.EffectivityTo;
    cmbDivision.SelectedValue = em.DivisionCode;
    cmbGroup.SelectedValue = em.GroupCode;
    cmbDepartment.SelectedValue = em.DepartmentCode;
    cmbJGCode.SelectedValue = em.JGCode;
    txtPosition.Text = em.Position;
    txtRemarks.Text = em.Remarks;
   }

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

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmEmployeeMovementEdit_Load(object sender, EventArgs e)
  {
   txtEmpName.Text = _strEmployeeName;
   LoadDetails();
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

    clsEmployeeMovement em = new clsEmployeeMovement();
    em.MovementCode = _strMovementCode;
    em.EffectivityFrom = dtpFrom.Value;
    em.EffectivityTo = dtpTo.Value;
    em.DivisionCode = cmbDivision.SelectedValue.ToString();
    em.GroupCode = cmbGroup.SelectedValue.ToString();
    em.DepartmentCode = cmbDepartment.SelectedValue.ToString();
    em.JGCode = cmbJGCode.SelectedValue.ToString();
    em.Position = txtPosition.Text;
    em.Remarks = txtRemarks.Text;
    em.ModifyBy = HRMSCore.Username;
    em.ModifyOn = DateTime.Now;
    intResults = em.Edit();

    if (intResults > 0)
    {
     _frmEmployeeDetails.BindMovementList();
     this.Close();
    }
   }
  }

 }
}
