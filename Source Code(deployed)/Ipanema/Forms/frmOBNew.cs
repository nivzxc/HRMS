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
 public partial class frmOBNew : Form
 {
  public frmOBNew() { InitializeComponent(); }

  private string _strDepartmentCode;
  private frmOBList _frmOBList;

  public frmOBList FormObList { get { return _frmOBList; } set { _frmOBList = value; } }  

  private void InitializeFields()
  {
   txtOBCode.Text = "";
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

   cmbOBType.DataSource = OfficialBusiness.DdlDsOBType();
   cmbOBType.ValueMember = "pvalue";
   cmbOBType.DisplayMember = "ptext";

   cmbRender.DataSource = Department.GetDSL();
   cmbRender.ValueMember = "pvalue";
   cmbRender.DisplayMember = "ptext";

   cmbRStatus.DataSource = OfficialBusiness.DdlDsStatusApprover();
   cmbRStatus.ValueMember = "pvalue";
   cmbRStatus.DisplayMember = "ptext";
   
   cmbHStatus.DataSource = OfficialBusiness.DdlDsStatusApprover();
   cmbHStatus.ValueMember = "pvalue";
   cmbHStatus.DisplayMember = "ptext";

   BindApprovers();

   CheckRender();
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

  private void CheckRender()
  {
   try
   {
    if (cmbOBType.SelectedValue.ToString() == "0")
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

  private void frmOBNew_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void cmbOBType_SelectedIndexChanged(object sender, EventArgs e)
  {
   CheckRender();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (OfficialBusiness ob = new OfficialBusiness())
    {
     ob.UserName = cmbRequestor.SelectedValue.ToString();
     ob.DateFile = clsDateTime.CombineDateTime(dtpFileDate.Value, dtpFileTime.Value);
     ob.Reason = txtReason.Text;
     ob.OBType = cmbOBType.SelectedValue.ToString();
     ob.DepartmentCode = cmbRender.SelectedValue.ToString();
     if (cmbOBType.SelectedValue.ToString() == "1")
     {
      ob.RAName = cmbRApprover.SelectedValue.ToString();
      ob.RADate = clsDateTime.CombineDateTime(dtpRDate.Value, dtpRTime.Value);
      ob.RARemarks = txtRRemarks.Text;
      ob.RAStatus = cmbRStatus.SelectedValue.ToString();
     }
     ob.HAName = cmbHApprover.SelectedValue.ToString();
     ob.HADate = clsDateTime.CombineDateTime(dtpHDate.Value, dtpHTime.Value);
     ob.HARemarks = txtHRemarks.Text;
     ob.HAStatus = cmbHStatus.SelectedValue.ToString();
     ob.Status = cmbStatus.SelectedValue.ToString();
     if (ob.InsertAdmin() > 0)
     {
      frmOBEdit pForm = new frmOBEdit();
      pForm.FormOBList = _frmOBList;
      pForm.FormOBNew = this;
      pForm.OBCode = ob.OBCode;
      pForm.FormCaller = FormCallers.OBNew;
      pForm.ShowDialog();
     }
    }
   }
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
   try
   {
    BindApprovers();
   }
   catch
   {
   }
  }

 }
}
