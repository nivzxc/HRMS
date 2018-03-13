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

 public partial class frmLeaveBalanceEdit : Form
 {  
  private string _strUsername;
  private string _strLeaveTypeCode;
  private frmEmployeeDetails _frmEmployeeDetails;
  private frmLeaveEntitlementList _frmLeaveEntitlementList;
  
     private FormCallers _FormCaller;
     private mdiIpanema _frmMdiCaller;
     //private mdiIpanema _mdiIpanema;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public string LeaveTypeCode { set { _strLeaveTypeCode = value; } get { return _strLeaveTypeCode; } }
  public frmEmployeeDetails FormEmployeeDetails { set { _frmEmployeeDetails = value; } get { return _frmEmployeeDetails; } }
  public frmLeaveEntitlementList FormLeaveEntitlementList { set { _frmLeaveEntitlementList = value; } get { return _frmLeaveEntitlementList; } }
  
     public FormCallers FormCaller { set { _FormCaller = value; } get { return _FormCaller; } }
     public mdiIpanema FormMdiCaller { get { return _frmMdiCaller; } set { _frmMdiCaller = value; } }
     //public mdiIpanema MDIIpanema { get { return _mdiIpanema; } set { _mdiIpanema = value; } }

  private void InitializeFields()
  {
   txtEmployee.Text = Employee.GetName(_strUsername);
   using (LeaveApplicationTypes lt = new LeaveApplicationTypes())
   {
    lt.LeaveTypeCode = _strLeaveTypeCode;
    lt.Fill();
    txtLeaveTypeCode.Text = _strLeaveTypeCode;
    txtLeaveType.Text = lt.LeaveType;
    txtWithPay.Text = clsValidator.ToYesNo(lt.WithPay);    
    txtMaxBalance.Text = lt.MaximumBalance.ToString();
    txtHasBalance.Text = clsValidator.ToYesNo(lt.HasBalance);
    txtBalance.Enabled = (lt.HasBalance == "1");
    txtEntitlement.Enabled = (lt.HasBalance == "1");
   }

   using (LeaveApplicationBalance lb = new LeaveApplicationBalance())
   {
    lb.LeaveTypeCode = _strLeaveTypeCode;
    lb.Username = _strUsername;
    lb.Fill();
    txtBalance.Text = lb.Balance.ToString();
    chkStatus.Checked = (lb.Status == "1" ? true : false);
    txtEntitlement.Text = lb.Entitlement.ToString();
   }
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtBalance.Text == "")
    strErrorMessage = "Current balance is required.";

   if(clsValidator.CheckFloat(txtBalance.Text) > clsValidator.CheckFloat(txtMaxBalance.Text))
    strErrorMessage = "Invalid balance is required.";

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

  public frmLeaveBalanceEdit()
  {
   InitializeComponent();
  }

  private void frmLeaveBalanceEdit_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (LeaveApplicationBalance lb = new LeaveApplicationBalance())
    {
        lb.Username = _strUsername;
        lb.LeaveTypeCode = _strLeaveTypeCode;
        lb.Balance = clsValidator.CheckFloat(txtBalance.Text);
        lb.Entitlement = clsValidator.CheckFloat(txtEntitlement.Text);
        lb.Status = (chkStatus.Checked ? "1" : "0");
        lb.Update();

        if (_FormCaller == FormCallers.EmployeeDetails)
            _frmEmployeeDetails.LoadLeaveEntitlement();
        else if (_FormCaller == FormCallers.LeaveEntitlementList)
            _frmLeaveEntitlementList.BindLeaveBalanceList();

        _frmMdiCaller.DSGZeroEL();
        _frmMdiCaller.DSGZeroVL();
        _frmMdiCaller.DSGZeroSL();

        this.Close();
    }
   }
  }

  private void frmLeaveBalanceEdit_FormClosing(object sender, FormClosingEventArgs e)
  {
    
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
      this.Close();
  }

 }
}