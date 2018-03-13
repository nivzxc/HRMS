using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HRMS;
using System.Data.SqlClient;
namespace Ipanema.Forms
{
 public partial class frmOvertimeNew : Form
 {
  public frmOvertimeNew() { InitializeComponent(); }
  private string OT_code;
  private frmOvertimeList _frmOvertimeList;
  private string _strDepartmentCode;

  public frmOvertimeList FormOvertimeList { set { _frmOvertimeList = value; } get { return _frmOvertimeList; } }

  private void InitializeFields()
  {
   OT_Code();   
   dtpFileDate.Value = DateTime.Now;
   dtpFileTime.Value = DateTime.Now;
   dtpRDate.Value = DateTime.Now;
   dtpRTime.Value = DateTime.Now;
   dtpHDate.Value = DateTime.Now;
   dtpHTime.Value = DateTime.Now;
   txtReason.Text = "";
   txtRRemarks.Text = "";
   txtHRemarks.Text = "";

   cmbStatus.DataSource = OfficialBusiness.DdlDsStatus();
   cmbStatus.ValueMember = "pvalue";
   cmbStatus.DisplayMember = "ptext";

   cmbRequestor.DataSource = Employee.DSLActive();
   cmbRequestor.ValueMember = "pvalue";
   cmbRequestor.DisplayMember = "ptext";

   _strDepartmentCode = Employee.GetDepartmentCode(cmbRequestor.SelectedValue.ToString());

   cmbChargeType.DataSource = clsOvertime.DdlDsChargeType();
   cmbChargeType.ValueMember = "pvalue";
   cmbChargeType.DisplayMember = "ptext";

   cmbRender.DataSource = Department.GetDSL();
   cmbRender.ValueMember = "pvalue";
   cmbRender.DisplayMember = "ptext";

   cmbRStatus.DataSource = OfficialBusiness.DdlDsStatusApprover();
   cmbRStatus.ValueMember = "pvalue";
   cmbRStatus.DisplayMember = "ptext";

   cmbHStatus.DataSource = OfficialBusiness.DdlDsStatusApprover();
   cmbHStatus.ValueMember = "pvalue";
   cmbHStatus.DisplayMember = "ptext";
  }

  // ADDED BY: Calvin
  private void OT_Code()
  {
    string get_code;
    int intSeed = 0;
            
    SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString);
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 otcode from HR.OverTime ORDER BY otcode DESC";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()){
                OT_code = dr["otcode"].ToString();
            }
            dr.Close();
            if (OT_code == null || OT_code == ""){
                get_code = OT_code;
                intSeed = clsValidator.CheckInteger(OT_code) + 1;
                OT_code = ("OT00" + intSeed.ToString()).Substring(intSeed.ToString().Length - 1);
                txtOBCode.Text = OT_code;
            }
            else{
                char[] removeChar = { 'O', 'T' };
                string code_on = OT_code.TrimStart(removeChar);               
                get_code = code_on;               
                intSeed = clsValidator.CheckInteger(code_on) + 1;              
                code_on = ("OT00" + intSeed.ToString()).Substring(intSeed.ToString().Length - 1);
                txtOBCode.Text = code_on;   
            }


  }
  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtReason.Text == "")
    strErrorMessage = "Reason is required.";

   if (clsDateTime.CombineDateTime(dtpStartDate.Value, dtpStartTime.Value) > clsDateTime.CombineDateTime(dtpEndDate.Value, dtpEndTime.Value))
    strErrorMessage += "\nNot enough leave balance.";

   if (strErrorMessage != "")
   {
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }

  private void CheckRender()
  {
   try
   {
    if (cmbChargeType.SelectedValue.ToString() == "0")
    {
     cmbRender.SelectedValue = _strDepartmentCode;
     cmbRender.Enabled = false;
     cmbRApprover.Visible = false;
     cmbRStatus.Visible = false;
     dtpRDate.Visible = false;
     dtpRTime.Visible = false;
     txtRRemarks.Visible = false;
     lblRApprover.Visible = false;
     lblRStatus.Visible = false;
     lblRRemarks.Visible = false;
    }
    else
    {
     cmbRender.Enabled = true;
     cmbRApprover.Visible = true;
     cmbRStatus.Visible = true;
     dtpRDate.Visible = true;
     dtpRTime.Visible = true;
     txtRRemarks.Visible = true;
     lblRApprover.Visible = true;
     lblRStatus.Visible = true;
     lblRRemarks.Visible = true;
    }
   }
   catch { }
  }

  private void BindApprovers()
  {
   try
   {
    cmbRApprover.DataSource = clsDepartmentApprover.DdlDsByDepartment(cmbRender.SelectedValue.ToString(), EFormType.OfficialBussiness);
    cmbRApprover.ValueMember = "pvalue";
    cmbRApprover.DisplayMember = "ptext";

    cmbHApprover.DataSource = clsDepartmentApprover.DdlDsByDepartment(_strDepartmentCode, EFormType.OfficialBussiness);
    cmbHApprover.ValueMember = "pvalue";
    cmbHApprover.DisplayMember = "ptext";
   }
   catch { }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmOvertimeNew_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void cmbChargeType_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { CheckRender(); }
   catch { }   
  }

  private void cmbRequestor_SelectedIndexChanged(object sender, EventArgs e)
  {
   try
   {
    _strDepartmentCode = Employee.GetDepartmentCode(cmbRequestor.SelectedValue.ToString());
    CheckRender();
    BindApprovers();
   }
   catch { }
  }

  private void cmbRender_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { BindApprovers(); }
   catch { }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (clsOvertime overtime = new clsOvertime())
    {
     overtime.OvertimeCode = txtOBCode.Text;
     overtime.Username = cmbRequestor.SelectedValue.ToString();
     overtime.DateFile = clsDateTime.CombineDateTime(dtpFileDate.Value, dtpFileTime.Value);
     overtime.DateStart = clsDateTime.CombineDateTime(dtpStartDate.Value, dtpStartTime.Value);
     overtime.DateEnd = clsDateTime.CombineDateTime(dtpEndDate.Value, dtpEndTime.Value);
     overtime.Units = 0;
     overtime.Reason = txtReason.Text;
     overtime.ChargeType = cmbChargeType.SelectedValue.ToString();
     overtime.DepartmentCode = cmbRender.SelectedValue.ToString();
     if (cmbChargeType.SelectedValue.ToString() == "1")
     {
      overtime.RequestorApproverName = cmbRApprover.SelectedValue.ToString();
      overtime.RequestorApproverDate = clsDateTime.CombineDateTime(dtpRDate.Value, dtpRTime.Value);
      overtime.RequestorApproverRemarks = txtRRemarks.Text;
      overtime.RequestorApproverStatus = cmbRStatus.SelectedValue.ToString();
     }
     overtime.HeadApproverName = cmbHApprover.SelectedValue.ToString();
     overtime.HeadApproverDate = clsDateTime.CombineDateTime(dtpHDate.Value, dtpHTime.Value);
     overtime.HeadApproverRemarks = txtHRemarks.Text;
     overtime.HeadApproverStatus = cmbHStatus.SelectedValue.ToString();
     overtime.Status = cmbStatus.SelectedValue.ToString();
     overtime.InsertAdmin();
     if (overtime.MessageAlert == 1)
     {
       MessageBox.Show("Overtime Request has been added", "Overtime Request Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
     }     
    }
    _frmOvertimeList.LoadOvertimeList();
    this.Close();
   }
  }
  
 }
}
