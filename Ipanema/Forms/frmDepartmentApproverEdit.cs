
// frmDepartmentApproveEdit.cs ADDED (JAN 1, 2017) by calvin cavite
// not yet implemented 
// updated: 1/15/2018
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
    public partial class frmDepartmentApproverEdit : Form
    {
        private string dept_id = "";
        private string approver_id = "";
        private string approver_nm = "";
        private frmDepartmentEdit _frmDepartmentEdit;
        public frmDepartmentEdit FormDepartmentEdit { set { _frmDepartmentEdit = value; } get { return _frmDepartmentEdit; } }
        public frmDepartmentApproverEdit(string Apprv_usernm, string Apprv_ID, string deptID)
        {
            dept_id = deptID;
            approver_id = Apprv_ID;
            approver_nm = Apprv_usernm;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDepartmentApproverEdit_Load(object sender, EventArgs e)
        {
            InitializeFields();
           
        }
        private bool IsCorrectData()
        {
            bool blnReturn = true;
            string strErrorMessage = "";


            if (chkLeave.Checked == false && chkUndertime.Checked == false && chkOB.Checked == false && chkOvertime.Checked == false)
                strErrorMessage = "You should atleast check 1 item.<br>";

            if (strErrorMessage != "")
            {
                MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                blnReturn = false;
            }

            return blnReturn;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsCorrectData())
            {
                using (clsDepartmentApprover cda = new clsDepartmentApprover())
                {
                    cda.ApproverID = tbApprvID.Text;
                    cda.DepartmentCode = dept_id;
                    cda.Username = approver_nm;
                    cda.CanApproveLeave = (chkLeave.Checked ? "1" : "0");
                    cda.CanApproveUT = (chkUndertime.Checked ? "1" : "0");
                    cda.CanApproveOB = (chkOB.Checked ? "1" : "0");
                    cda.CanApproveOT = (chkOvertime.Checked ? "1" : "0");
                    cda.Update();
                }
                _frmDepartmentEdit.LoadApproverList();
                MessageBox.Show("You have successfully added new Approver", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
        private void InitializeFields()
        {
            SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString);
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT "
                             + "HR.Employees.firname,"
                             + "HR.Employees.lastname,"
                             + "HR.DepartmentApprover.approver_id,"
                             + "HR.Department.deptname,"
                             + "HR.DepartmentApprover.leave,"
                             + "HR.DepartmentApprover.ut,"
                             + "HR.DepartmentApprover.ob,"
                             + "HR.DepartmentApprover.ot,"
                             + "HR.DepartmentApprover.rfiflag"
                             +" FROM HR.Employees"
                                +" INNER JOIN HR.DepartmentApprover on HR.Employees.username = HR.DepartmentApprover.username"
                                +" LEFT JOIN HR.Department on HR.DepartmentApprover.deptcode = HR.Department.deptcode"
                             +" WHERE"
                             +" HR.Employees.username = '"+approver_nm+"' AND HR.DepartmentApprover.approver_id = '"+approver_id+"'";
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbApprvID.Text = dr["approver_id"].ToString();
                tbDepartment.Text = dr["deptname"].ToString();
                tbEmployee.Text = dr["firname"].ToString() + " " + dr["lastname"].ToString();
                if (dr["leave"].ToString()=="1") { chkLeave.CheckState= CheckState.Checked; }
                if (dr["ut"].ToString() == "1") { chkUndertime.CheckState = CheckState.Checked; }
                if (dr["ob"].ToString() == "1") { chkOB.CheckState = CheckState.Checked; }
                if (dr["ot"].ToString() == "1") { chkOvertime.CheckState = CheckState.Checked; }

            }
            dr.Close();
        }
    }
}
