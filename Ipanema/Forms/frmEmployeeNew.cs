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
 public partial class frmEmployeeNew : Form
 {
  public frmEmployeeNew()
  {
   InitializeComponent();
  }

  private bool IsCorrectData()
  {
   string strErrorMessage = "";

   if (txtEmployeeNumber.Text == "")
    strErrorMessage += "Employee number is required.";

   if (txtUsername.Text == "")
    strErrorMessage += "Username is required.";

   if (txtUsername.Text.IndexOf(" ") >= 0)
    strErrorMessage += "Black space is not allowed in username.";

   if (txtLastName.Text == "")
    strErrorMessage += "Last name is required.";

   if (txtFirstName.Text == "")
    strErrorMessage += "\nFirst name is required.";

   if (txtMiddleName.Text == "")
    strErrorMessage += "\nMiddle name is required.";

   if (txtNickName.Text == "")
    strErrorMessage += "\nNick name is required.";

   if (cmbGender.SelectedItem.ToString() == "")
    strErrorMessage += "\nGender is required.";

   if (cmbCivilStatus.Text == "")
    strErrorMessage += "\nCivil status is required.";

   if (txtPosition.Text == "")
    strErrorMessage += "\nPosition is required.";

   if (txtAssignment.Text == "")
    strErrorMessage += "\nAssignment is required.";

   if (txtEmailOfficial.Text == "")
    strErrorMessage += "\nOfficial email is required.";

   if (strErrorMessage != "")
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

   return strErrorMessage == "";
  }

  public void BindRecruitmentSourceList()
  {
   cmbRecruitmentSource.DataSource = clsRecruitmentSource.DSLRecruitmentSource();
   cmbRecruitmentSource.DisplayMember = "ptext";
   cmbRecruitmentSource.ValueMember = "pvalue";
  }

  private void InitializeFields()
  {
   dtpDateStart.Value = DateTime.Now;
   dtpRegular.Value = DateTime.Now.AddMonths(6);

   cmbSchedule.DataSource = clsSchedule.DSLSchedule();
   cmbSchedule.ValueMember = "pvalue";
   cmbSchedule.DisplayMember = "ptext";

   cmbGender.DataSource = Employee.DSLGender();
   cmbGender.ValueMember = "pvalue";
   cmbGender.DisplayMember = "ptext";

   cmbCivilStatus.DataSource = Employee.DSLCivilStatus();
   cmbCivilStatus.ValueMember = "pvalue";
   cmbCivilStatus.DisplayMember = "ptext";

   cmbEmploymentStatus.DataSource = clsEmploymentStatus.DSLEmploymentStatus();
   cmbEmploymentStatus.ValueMember = "pvalue";
   cmbEmploymentStatus.DisplayMember = "ptext";

   cmbJGCode.DataSource = JobGrade.DSLJGCode();
   cmbJGCode.DisplayMember = "ptext";
   cmbJGCode.ValueMember = "pvalue";

            cmbDivision.DataSource = Division.GetDSL();
            cmbDivision.DisplayMember = "ptext";
            cmbDivision.ValueMember = "pvalue";

            //cmbGroup.DataSource = Group.GetDSL();
            //cmbGroup.DisplayMember = "ptext";
            //cmbGroup.ValueMember = "pvalue";

            //cmbDepartment.DataSource = Department.GetDSL();
            //cmbDepartment.DisplayMember = "ptext";
            //cmbDepartment.ValueMember = "pvalue";

            cmbRC.DataSource = clsRC.GetDdlDs();
   cmbRC.DisplayMember = "ptext";
   cmbRC.ValueMember = "pvalue";

   cmbCompany.DataSource = clsCompany.GetDSL();
   cmbCompany.DisplayMember = "ptext";
   cmbCompany.ValueMember = "pvalue";

   cmbEmployeeType.DataSource = clsEmployeeType.DSLEmployeeType();
   cmbEmployeeType.DisplayMember = "ptext";
   cmbEmployeeType.ValueMember = "pvalue";

   this.BindRecruitmentSourceList();
  }

  private void GenerateUserName()
  {
   txtUsername.Text = txtNickName.Text.Trim().Replace(" ", "").ToLower() + "." + txtLastName.Text.Trim().Replace(" ", "").ToLower();
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmEmployeeNew_Load(object sender, EventArgs e)
  {
   //txtEmployeeNumber.Text = Employee.GenerateEmployeeNumber();
   InitializeFields(); 
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnScheduleDetails_Click(object sender, EventArgs e)
  {
   frmScheduleDetails pForm = new frmScheduleDetails();
   pForm.ScheduleCode = cmbSchedule.SelectedValue.ToString();
   pForm.ShowDialog();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (Employee employee = new Employee())
    {
     employee.Username = txtUsername.Text;
     employee.EmployeeNumber = txtEmployeeNumber.Text;
     employee.LastName = txtLastName.Text;
     employee.FirstName = txtFirstName.Text;
     employee.MiddleName = txtMiddleName.Text;
     employee.MiddleInitial = txtMiddleInitial.Text;
     employee.NickName = txtNickName.Text;
     employee.BirthDate = clsDateTime.GetDateOnly(dtpBirthDate.Value);
     employee.Gender = cmbGender.SelectedValue.ToString();
     employee.EmploymentTypeCode = cmbEmployeeType.SelectedValue.ToString();
     employee.EmploymentStatusCode = cmbEmploymentStatus.SelectedValue.ToString();
     employee.CompanyCode = cmbCompany.SelectedValue.ToString();
     employee.Position = txtPosition.Text;
     employee.CivilStatus = cmbCivilStatus.SelectedValue.ToString();
     employee.EmailOfficial = txtEmailOfficial.Text;
     employee.ScheduleCode = cmbSchedule.SelectedValue.ToString();
     employee.DivisionCode = cmbDivision.SelectedValue.ToString();
     employee.GroupCode = cmbGroup.SelectedValue.ToString();
     employee.DepartmentCode = cmbDepartment.SelectedValue.ToString();
     employee.RcCode = cmbRC.SelectedValue.ToString();
     employee.JGCode = cmbJGCode.SelectedValue.ToString();
     employee.Assignment = txtAssignment.Text;
     employee.DateStart = dtpDateStart.Value.Date;
     employee.DateRegular = dtpRegular.Value.Date;
     employee.UpdatedBy = HRMSCore.Username;
     employee.UpdatedOn = DateTime.Now;
     employee.Status = (chkEnabled.Checked ? "1" : "0");
     employee.IsBillable = (chkBillable.Checked ? "1" : "0");
     employee.RecruitmentSourceCode = cmbRecruitmentSource.SelectedValue.ToString();
     employee.RecruitmentSourceRemarks = txtRecruitmentRemarks.Text;
     if (employee.Insert() !=0)
     {
         MessageBox.Show("New Employee Added Successfully", "NEW EMPLOYEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
     }
     
    
    

     /// ADDED Jan 12, 2018 /// by calvin cavite
     //frmEmployeeList emp_list = new frmEmployeeList();
     //emp_list.BindEmployeeList();
     ///////////////
     this.Close();

    }
   }
  }
  private void UpdateKet()
  {

  }
  private void btnGenerate_Click(object sender, EventArgs e)
  {
   this.GenerateUserName();
  }

  private void btnGenerateEmployeeNumber_Click(object sender, EventArgs e)
  {
   txtEmployeeNumber.Text = Employee.GenerateEmployeeNumber();
  }

  private void txtNickName_TextChanged(object sender, EventArgs e)
  {
   this.GenerateUserName();
  }

  private void txtLastName_TextChanged(object sender, EventArgs e)
  {
   this.GenerateUserName();
  }

  private void dtpDateStart_ValueChanged(object sender, EventArgs e)
  {
   dtpRegular.Value = dtpDateStart.Value.AddMonths(6);
  }

  private void btnRecruitmentSourceAdd_Click(object sender, EventArgs e)
  {
   Cursor.Current = Cursors.AppStarting;
   frmRecruitmentSourceAdd pForm = new frmRecruitmentSourceAdd();
   pForm.FormCaller = FormCallers.EmployeeNew;
   pForm.FormEmployeeNew = this;
   pForm.Show();
   Cursor.Current = Cursors.Default;
  }

        private void label92_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeNumber_KeyDown(object sender, KeyEventArgs e)
        {
       
        }

        private void txtEmployeeNumber_Leave(object sender, EventArgs e)
        {
            if (Employee.IsEmployeeExistByNumber(txtEmployeeNumber.Text) == true )
            {
                //TextBox tb = (TextBox)sender;
                //int visibletime = 10000;
                //ToolTip tt = new ToolTip();
                //tt.Show("Employee Number " + txtEmployeeNumber.Text + " is already assigned to " + Employee.checkEmployeeNumber(txtEmployeeNumber.Text), tb,0,0,visibletime);

                MessageBox.Show("Employee Number " +txtEmployeeNumber.Text + " is already assigned to " + Employee.checkEmployeeNumber(txtEmployeeNumber.Text),"Employee Number already Taken", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmployeeNumber.Clear();
                this.ActiveControl = txtEmployeeNumber;
            }
        }

        private void txtEmployeeNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDivision.Text != "") {
                cmbGroup.DataSource = Group.GetGroup(cmbDivision.SelectedValue.ToString());
                cmbGroup.DisplayMember = "ptext";
                cmbGroup.ValueMember = "pvalue";
                this.ActiveControl = cmbGroup;
            }
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedValue.ToString() !="")
            {
                cmbDepartment.DataSource = Department.GetDepartment(cmbGroup.SelectedValue.ToString());
                cmbDepartment.DisplayMember = "ptext";
                cmbDepartment.ValueMember = "pvalue";
                this.ActiveControl = cmbDepartment;
            }
        }

        private void chkBillable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkEnabled_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}