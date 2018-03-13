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
 public partial class frmUndertimeEdit : Form
 {
  public frmUndertimeEdit() { InitializeComponent(); }

  frmUndertimeList _frmUndertimeList;
  private string _strUndertimeCode;
  private string _strUsername;

  public frmUndertimeList FormUndertimeList { set { _frmUndertimeList = value; } get { return _frmUndertimeList; } }
  public string UndertimeCode { set { _strUndertimeCode = value; } get { return _strUndertimeCode; } }

  private void BindFields()
  {
   cmbStatus.DataSource = clsUndertime.DdlDsStatus();
   cmbStatus.ValueMember = "pvalue";
   cmbStatus.DisplayMember = "ptext";

   txtUndertimeCode.Text = _strUndertimeCode;
   using (clsUndertime undertime = new clsUndertime())
   {
    undertime.UndertimeCode = _strUndertimeCode;
    undertime.Fill();
    _strUsername = undertime.Username;

    txtEmployeeName.Text = Employee.GetName(undertime.Username);
    cmbStatus.SelectedValue = undertime.Status;
    dtpFileDate.Value = undertime.DateFiled;
    txtDateApplied.Text = undertime.DateApplied.ToString("MMM dd, yyyy hh:mm tt");
    txtReason.Text = undertime.Reason;
    txtApproverName.Text = Employee.GetName(undertime.ApproverUsername);
    dtpDateProcess.Value = undertime.ApproverDate;
    txtRemarks.Text = undertime.ApproverRemarks;
   }

  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtReason.Text == "")
    strErrorMessage += "\nReason is required.";

   if (strErrorMessage != "")
   {
    MessageBox.Show("Data entry error:" + strErrorMessage, "HRMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }

  /////////////////////////////
  //////// Form Events ////////
  /////////////////////////////

  private void frmUndertimeEdit_Load(object sender, EventArgs e)
  {
   BindFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (clsUndertime undertime = new clsUndertime())
    {
     undertime.UndertimeCode = _strUndertimeCode;
     undertime.Fill();
     undertime.Username = _strUsername;
     undertime.DateFiled = dtpFileDate.Value;
     undertime.Reason = txtReason.Text;
     undertime.ApproverDate = clsDateTime.CombineDateTime(dtpDateProcess.Value, dtpApproverTime.Value);
     undertime.ApproverRemarks = txtRemarks.Text;
     undertime.Status = cmbStatus.SelectedValue.ToString();
     undertime.UpdateAdmin();
    }
    _frmUndertimeList.BindUndertimeList();
    this.Close();
   }
  }

 }
}