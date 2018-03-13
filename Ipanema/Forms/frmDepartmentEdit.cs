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
    lvi.Text = drw["approver_id"].ToString();
    lvi.Tag = drw["approver_id"].ToString();
    lvi.SubItems.Add(drw["username"].ToString());
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
     try {
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
        MessageBox.Show("Changes Save", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
        this.Close();

     }catch(Exception err)
     {
       MessageBox.Show("ERROR:"+ err);
     }      
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
            if (lvApprovers.SelectedItems.Count > 0)
            {
                string deptID = txtDepartmentCode.Text;
                string Apprv_ID = lvApprovers.SelectedItems[0].Text;
                string Apprv_usernm = lvApprovers.SelectedItems[0].SubItems[1].Text;
             
                frmDepartmentApproverEdit Edit_approver = new frmDepartmentApproverEdit(Apprv_usernm, Apprv_ID, deptID);
                Edit_approver.FormDepartmentEdit = this;
                Edit_approver.Show();
            }
            else { MessageBox.Show("Please select approver","Unable to Edit",MessageBoxButtons.OK,MessageBoxIcon.Stop); }
            
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
   if (lvApprovers.SelectedItems.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsDepartmentApprover da = new clsDepartmentApprover();
     da.ApproverID = lvApprovers.SelectedItems[0].Text;
     da.Username = lvApprovers.SelectedItems[0].SubItems[1].Text;
     da.DepartmentCode = _strDepartmentCode;
     da.Delete();
     LoadApproverList();
    }
   }
  }

        private void lvApprovers_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}