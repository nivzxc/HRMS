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
 public partial class frmDepartmentEdit : Form
 {
  public frmDepartmentEdit() { InitializeComponent(); }

  private string _strDepartmentCode;
  private frmDepartmentList _frmDepartmentList;

  public string DepartmentCode { set { _strDepartmentCode = value; } get { return _strDepartmentCode; } }
  public frmDepartmentList FormDepartmentList { set { _frmDepartmentList = value; } get { return _frmDepartmentList; } }

  private void BindDetails()
  {
   cmbDivision.DataSource = Division.GetDSL();
   cmbDivision.ValueMember = "pvalue";
   cmbDivision.DisplayMember = "ptext";

   cmbGroup.DataSource = Group.GetDSL(cmbDivision.SelectedValue.ToString());
   cmbGroup.ValueMember = "pvalue";
   cmbGroup.DisplayMember = "ptext";

   txtDepartmentCode.Text = _strDepartmentCode;
   using (Department objDepartment = new Department())
   {
    objDepartment.DepartmentCode = _strDepartmentCode;
    objDepartment.Fill();
    txtDepartment.Text = objDepartment.DepartmentName;
    cmbDivision.SelectedValue = objDepartment.DivisionCode;
    cmbGroup.SelectedValue = objDepartment.GroupCode;
    chkActive.Checked = (objDepartment.Status == "1");
   }

   btnAdd.Enabled = chkActive.Checked;
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtDepartment.Text == "")
    strErrorMessage = "Department name is required.";

   if (strErrorMessage != "")
   {
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }

  public void LoadApproverList()
  {
   DataTable tblApprover = clsDepartmentApprover.GetDataTable(_strDepartmentCode);

   lvApprovers.Items.Clear();
   foreach (DataRow drw in tblApprover.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = Employee.GetName(drw["username"].ToString());
    lvi.Tag = drw["username"].ToString();
    lvi.SubItems.Add((drw["leave"].ToString() == "1" ? "Yes" : "No"));
    lvi.SubItems.Add((drw["ut"].ToString() == "1" ? "Yes" : "No"));
    lvi.SubItems.Add((drw["ot"].ToString() == "1" ? "Yes" : "No"));
    lvi.SubItems.Add((drw["ob"].ToString() == "1" ? "Yes" : "No"));    
    lvApprovers.Items.Add(lvi);
   }
   btnDelete.Enabled = lvApprovers.Items.Count > 0;
   btnEdit.Enabled = lvApprovers.Items.Count > 0;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmDepartmentEdit_Load(object sender, EventArgs e)
  {
   BindDetails();
   LoadApproverList();
  }

  private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
  {
   cmbGroup.DataSource = Group.GetDSL(cmbDivision.SelectedValue.ToString());
   cmbGroup.ValueMember = "pvalue";
   cmbGroup.DisplayMember = "ptext";
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (Department objDepartment = new Department())
    {
     objDepartment.DepartmentCode = _strDepartmentCode;
     objDepartment.DepartmentName = txtDepartment.Text;
     objDepartment.DivisionCode = cmbDivision.SelectedValue.ToString();
     objDepartment.GroupCode = cmbGroup.SelectedValue.ToString();
     objDepartment.Status = (chkActive.Checked ? "1" : "0");
     objDepartment.Update();
    }
    _frmDepartmentList.BindDepartmentList();
    this.Close();
   }
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
   frmDepartmentApproverAdd pForm = new frmDepartmentApproverAdd();
   pForm.FormDepartmentEdit = this;
   pForm.FormCaller = FormCallers.DepartmentApproverAdd;
   pForm.DepartmentCode = _strDepartmentCode;
   pForm.Show();
  }

  private void btnEdit_Click(object sender, EventArgs e)
  {

  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
   if (lvApprovers.SelectedItems.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsDepartmentApprover da = new clsDepartmentApprover();
     da.Username = lvApprovers.SelectedItems[0].Tag.ToString();
     da.DepartmentCode = _strDepartmentCode;
     da.Delete();
     LoadApproverList();
    }
   }
  }

 }
}