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
 public partial class frmLeaveBalanceNew : Form
 {
  public frmLeaveBalanceNew() { InitializeComponent(); }

  private string _strUsername;
  private string _strLeaveTypeCode;
  private FormCallers _FormCaller;
  private frmEmployeeDetails _frmEmployeeDetails;
  private frmLeaveEntitlementList _frmLeaveEntitlementList;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public string LeaveTypeCode { set { _strLeaveTypeCode = value; } get { return _strLeaveTypeCode; } }
  public FormCallers FormCaller { set { _FormCaller = value; } get { return _FormCaller; } }
  public frmEmployeeDetails FormEmployeeDetails { set { _frmEmployeeDetails = value; } get { return _frmEmployeeDetails; } }
  public frmLeaveEntitlementList FormLeaveEntitlementList { set { _frmLeaveEntitlementList = value; } get { return _frmLeaveEntitlementList; } }

  private void InitializeFields()
  {
   cmbEmployee.DataSource = Employee.DSLActive();
   cmbEmployee.ValueMember = "pvalue";
   cmbEmployee.DisplayMember = "ptext";

   if (_FormCaller == FormCallers.EmployeeDetails)
    cmbLeaveType.DataSource = LeaveApplicationTypes.DSLLeaveType();
   else if (_FormCaller == FormCallers.LeaveEntitlementList)
    cmbLeaveType.DataSource = LeaveApplicationTypes.GetDSLActive(cmbEmployee.SelectedValue.ToString());
    cmbLeaveType.ValueMember = "pvalue";
    cmbLeaveType.DisplayMember = "ptext";
  }

  private void BindLeaveTypeDetails()
  {
   if (cmbLeaveType.Items.Count > 0)
   {        
       
    using (LeaveApplicationTypes lt = new LeaveApplicationTypes())
    {
                    lt.LeaveTypeCode = cmbLeaveType.SelectedValue.ToString();
                    lt.Fill();
                    txtWithPay.Text = clsValidator.ToYesNo(lt.WithPay);
                    txtHasBalance.Text = clsValidator.ToYesNo(lt.HasBalance);
                    txtMaxBalance.Text = lt.MaximumBalance.ToString();
                    txtEntitlement.Text = lt.MaximumBalance.ToString();
                    txtBalance.Text = txtMaxBalance.Text;
                    txtMaxBalance.Enabled = (lt.HasBalance == "1");
                    txtEntitlement.Enabled = (lt.HasBalance == "1");
                    txtBalance.Enabled = (lt.HasBalance == "1");
    }
   }
   else
   {
    txtWithPay.Text = "";
    txtHasBalance.Text = "";
    txtMaxBalance.Text = "";
    txtEntitlement.Text = "";
    txtBalance.Text = "";
   }
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtBalance.Text == "")
    strErrorMessage = "Current balance is required.";

   if (clsValidator.CheckFloat(txtBalance.Text) > clsValidator.CheckFloat(txtMaxBalance.Text))
    strErrorMessage = "Invalid balance is required.";

   if (cmbLeaveType.Items.Count <= 0)
    strErrorMessage = "Leave type is required.";

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

  private void frmLeaveBalanceNew_Load(object sender, EventArgs e)
  {
   InitializeFields();
   if (_FormCaller == FormCallers.EmployeeDetails)
   {
    cmbEmployee.SelectedValue = _strUsername;
    cmbLeaveType.SelectedValue = _strLeaveTypeCode;

    cmbEmployee.Enabled = false;
    cmbLeaveType.Enabled = false;
   }
   BindLeaveTypeDetails();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (LeaveApplicationBalance lb = new LeaveApplicationBalance())
    {
     lb.Username = cmbEmployee.SelectedValue.ToString();
     lb.LeaveTypeCode = _strLeaveTypeCode;
     lb.Balance = clsValidator.CheckFloat(txtBalance.Text);
     lb.Entitlement = clsValidator.CheckFloat(txtEntitlement.Text);
     lb.Status = "1";
     lb.Insert();
     if (_FormCaller == FormCallers.EmployeeDetails)
     {
      _frmEmployeeDetails.LoadLeaveTypes();
      _frmEmployeeDetails.LoadLeaveEntitlement();
     }
     else if (_FormCaller == FormCallers.LeaveEntitlementList)
     {
      _frmLeaveEntitlementList.BindLeaveBalanceList();
     }
     this.Close();
    }
   } 
  }

  private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (_FormCaller == FormCallers.LeaveEntitlementList)
   {
    //try
    //{
     cmbLeaveType.DataSource = LeaveApplicationTypes.GetDSLActive(cmbEmployee.SelectedValue.ToString());
     cmbLeaveType.ValueMember = "pvalue";
     cmbLeaveType.DisplayMember = "ptext";
    //}
    //catch { }
   }
  }

  private void cmbLeaveType_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (_FormCaller == FormCallers.LeaveEntitlementList)
   {
    try { BindLeaveTypeDetails(); }
    catch { }
   }
  }

 }
}
