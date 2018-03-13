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
 public partial class frmOBEdit : Form
 {
  public frmOBEdit() { InitializeComponent(); }

  private string _strOBCode;
  private string _strOBType;
  private frmOBList _frmOBList;
  private frmOBNew _frmOBNew;
  private FormCallers _FormCallers;

  public string OBCode { set { _strOBCode = value; } get { return _strOBCode; } }
  public frmOBList FormOBList { set { _frmOBList = value; } get { return _frmOBList; } }
  public frmOBNew FormOBNew { set { _frmOBNew = value; } get { return _frmOBNew; } }
  public FormCallers FormCaller { get { return _FormCallers; } set { _FormCallers = value; } }

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

   txtOBCode.Text = _strOBCode;
   using (OfficialBusiness objOfficialBusiness = new OfficialBusiness())
   {
    objOfficialBusiness.OBCode = _strOBCode;
    objOfficialBusiness.Fill();
    txtRequestor.Text = Employee.GetName(objOfficialBusiness.UserName);
    _strOBType = objOfficialBusiness.OBType;
    txtOBtype.Text = OfficialBusiness.GetOBTypeDesc(objOfficialBusiness.OBType);
    txtRenderTo.Text = Department.GetName(objOfficialBusiness.DepartmentCode);
    dtpFileDate.Value = objOfficialBusiness.DateFile;
    dtpFileTime.Value = objOfficialBusiness.DateFile;
    txtReason.Text = objOfficialBusiness.Reason;
    if (objOfficialBusiness.OBType == "1")
    {
     txtRApprover.Text = Employee.GetName(objOfficialBusiness.RAName);
     dtpRDate.Value = objOfficialBusiness.RADate;
     dtpRTime.Value = objOfficialBusiness.RADate;
     cmbRStatus.SelectedValue = objOfficialBusiness.RAStatus;
     txtRRemarks.Text = objOfficialBusiness.RARemarks;
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
    txtHApprover.Text = Employee.GetName(objOfficialBusiness.HAName);
    dtpHDate.Value = objOfficialBusiness.HADate;
    dtpHTime.Value = objOfficialBusiness.HADate;
    cmbHStatus.SelectedValue = objOfficialBusiness.HAStatus;
    txtHRemarks.Text = objOfficialBusiness.HARemarks;
    cmbStatus.SelectedValue = objOfficialBusiness.Status;
   }
   LoadOBDetails();
  }

  public void LoadOBDetails()
  {
   lvOBDetails.Items.Clear();
   DataTable tblOBDetails = OfficialBusinessDetails.DataTableByOBCode(_strOBCode);
   foreach (DataRow drw in tblOBDetails.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = clsValidator.CheckDate(drw["focsdate"].ToString()).ToString("MMM dd, yyyy");
    lvi.Tag = drw["focsdate"].ToString();
    lvi.SubItems.Add(clsValidator.CheckDate(drw["keyin"].ToString()).ToString("MMM dd, yyyy hh:mm tt"));
    lvi.SubItems.Add(clsValidator.CheckDate(drw["keyout"].ToString()).ToString("MMM dd, yyyy hh:mm tt"));
    lvOBDetails.Items.Add(lvi);
   }

   if (lvOBDetails.Items.Count > 0)
    lvOBDetails.Items[0].Selected = true;
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

  private void frmOBEdit_Load(object sender, EventArgs e)
  {
   BindDetails();
  }

  private void btnEdit_Click(object sender, EventArgs e)
  {
   if (lvOBDetails.SelectedItems.Count > 0)
   {
    frmOBScheduleEdit pForm = new frmOBScheduleEdit();
    pForm.FormOBEdit = this;
    pForm.OBCode = _strOBCode;
    pForm.FocusDate = clsValidator.CheckDate(lvOBDetails.SelectedItems[0].Tag.ToString());
    pForm.ShowDialog();
   }
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
   frmOBDetailsNew pForm = new frmOBDetailsNew();
   pForm.FormOBEdit = this;
   pForm.OBCode = _strOBCode;
   pForm.ShowDialog();
  }

  private void frmOBEdit_Shown(object sender, EventArgs e)
  {
   if (_FormCallers == FormCallers.OBNew)
    _frmOBNew.Hide();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
   if (lvOBDetails.Items.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     OfficialBusinessDetails obd = new OfficialBusinessDetails();
     obd.OBCode = _strOBCode;
     obd.FocusDate = clsValidator.CheckDate(lvOBDetails.SelectedItems[0].Tag.ToString());
     obd.Delete();
     LoadOBDetails();
    }
   }
  }

  private void frmOBEdit_FormClosing(object sender, FormClosingEventArgs e)
  {
   if (OfficialBusinessDetails.CountSchedule(_strOBCode) == 0)
   {
    MessageBox.Show("There is no OB schedule specified.", clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error);
    e.Cancel = true;
   }
   if (!e.Cancel && _FormCallers == FormCallers.OBNew)
    _frmOBList.BindOBList();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   using (OfficialBusiness ob = new OfficialBusiness())
   {
    ob.OBCode = _strOBCode;
    ob.Fill();
    ob.DateFile = clsDateTime.CombineDateTime(dtpFileDate.Value, dtpFileTime.Value);
    ob.Reason = txtReason.Text;
    if (_strOBType == "1")
    {
     ob.RADate = clsDateTime.CombineDateTime(dtpRDate.Value, dtpRTime.Value);
     ob.RARemarks = txtRRemarks.Text;
     ob.RAStatus = cmbRStatus.SelectedValue.ToString();
    }
    ob.HADate = clsDateTime.CombineDateTime(dtpHDate.Value, dtpHTime.Value);
    ob.HARemarks = txtHRemarks.Text;
    ob.HAStatus = cmbHStatus.SelectedValue.ToString();
    ob.Status = cmbStatus.SelectedValue.ToString();
    if (ob.UpdateAdmin() > 0)
    {
     _frmOBList.BindOBList();
     this.Close();
    }
   }
  }

  private void btnRefresh_Click(object sender, EventArgs e)
  {
   LoadOBDetails();
  }

 }
}