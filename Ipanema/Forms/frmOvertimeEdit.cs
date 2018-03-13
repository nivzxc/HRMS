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
 public partial class frmOvertimeEdit : Form
 {
  public frmOvertimeEdit() { InitializeComponent(); }

  private string _strChargeType;
  private string _strOvertimeCode;
  private frmOvertimeList _frmOvertimeList;

  public string OvertimeCode { set { _strOvertimeCode = value; } get { return _strOvertimeCode; } }
  public frmOvertimeList FormOvertimeList { set { _frmOvertimeList = value; } get { return _frmOvertimeList; } }

  private void BindDetails()
  {
   cmbStatus.DataSource = OfficialBusiness.DdlDsStatus();
   cmbStatus.ValueMember = "pvalue";
   cmbStatus.DisplayMember = "ptext";

   cmbRStatus.DataSource = OfficialBusiness.DdlDsStatusApprover();
   cmbRStatus.ValueMember = "pvalue";
   cmbRStatus.DisplayMember = "ptext";

   cmbHStatus.DataSource = OfficialBusiness.DdlDsStatusApprover();
   cmbHStatus.ValueMember = "pvalue";
   cmbHStatus.DisplayMember = "ptext";

   txtOvertimeCode.Text = _strOvertimeCode;
   using (clsOvertime overtime = new clsOvertime())
   {
    overtime.OvertimeCode = _strOvertimeCode;
    overtime.Fill();
    txtRequestor.Text = Employee.GetName(overtime.Username);
    _strChargeType = overtime.ChargeType;
    txtChargeType.Text = clsOvertime.GetChargeTypeDesc(overtime.ChargeType);
    txtRenderedTo.Text = Department.GetName(overtime.DepartmentCode);
    dtpFileDate.Value = overtime.DateFile;
    dtpFileTime.Value = overtime.DateFile;
    dtpStartDate.Value = overtime.DateStart;
    dtpStartTime.Value = overtime.DateStart;
    dtpEndDate.Value = overtime.DateEnd;
    dtpEndTime.Value = overtime.DateEnd;
    txtReason.Text = overtime.Reason;
    if (overtime.ChargeType == "1")
    {
     txtRApprover.Text = Employee.GetName(overtime.RequestorApproverName);
     dtpRDate.Value = overtime.RequestorApproverDate;
     dtpRTime.Value = overtime.RequestorApproverDate;
     cmbRStatus.SelectedValue = overtime.RequestorApproverStatus;
     txtRRemarks.Text = overtime.RequestorApproverRemarks;
     dtpRDate.Checked = (overtime.RequestorApproverDate != clsDateTime.SystemMinDate);
     dtpRTime.Checked = (overtime.RequestorApproverDate != clsDateTime.SystemMinDate);
    }
    else
    {
     txtRApprover.Visible = false;
     dtpRDate.Visible = false;
     dtpRTime.Visible = false;
     cmbRStatus.Visible = false;
     txtRRemarks.Visible = false;
     lblRApprover.Visible = false;
     lblRStatus.Visible = false;
     lblRRemarks.Visible = false;
    }
    txtHApprover.Text = Employee.GetName(overtime.HeadApproverName);
    dtpHDate.Value = overtime.HeadApproverDate;
    dtpHTime.Value = overtime.HeadApproverDate;
    cmbHStatus.SelectedValue = overtime.HeadApproverStatus;
    txtHRemarks.Text = overtime.HeadApproverRemarks;
    cmbStatus.SelectedValue = overtime.Status;

    dtpHDate.Checked = (overtime.HeadApproverDate != clsDateTime.SystemMinDate);
    dtpHTime.Checked = (overtime.HeadApproverDate != clsDateTime.SystemMinDate);
   }
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtReason.Text == "")
    strErrorMessage = "Reason is required.";

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

  private void frmOvertimeEdit_Load(object sender, EventArgs e)
  {
   BindDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   using (clsOvertime overtime = new clsOvertime())
   {
    overtime.OvertimeCode = _strOvertimeCode;
    overtime.Fill();
    overtime.DateStart = clsDateTime.CombineDateTime(dtpStartDate.Value, dtpStartTime.Value);
    overtime.DateEnd = clsDateTime.CombineDateTime(dtpEndDate.Value, dtpEndTime.Value);
    overtime.DateFile = clsDateTime.CombineDateTime(dtpFileDate.Value, dtpFileTime.Value);
    overtime.Reason = txtReason.Text;
    if (_strChargeType == "1")
    {
     overtime.RequestorApproverDate = clsDateTime.CombineDateTime(dtpRDate.Value, dtpRTime.Value);
     overtime.RequestorApproverRemarks = txtRRemarks.Text;
     overtime.RequestorApproverStatus = cmbRStatus.SelectedValue.ToString();
    }
    overtime.HeadApproverDate = clsDateTime.CombineDateTime(dtpHDate.Value, dtpHTime.Value);
    overtime.HeadApproverRemarks = txtHRemarks.Text;
    overtime.HeadApproverStatus = cmbHStatus.SelectedValue.ToString();
    overtime.Status = cmbStatus.SelectedValue.ToString();
    if (overtime.UpdateAdmin() > 0)
    {
     _frmOvertimeList.LoadOvertimeList();
     this.Close();
    }
   }
  }
 }
}
