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
 public partial class frmTimeSheetAccessMain : Form
 {
  public frmTimeSheetAccessMain()
  {
   InitializeComponent();
  }

  private void FillCombobox()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("ptext");
   tblReturn.Columns.Add("pvalue");
   DataRow drw; 
   drw = tblReturn.NewRow();
   drw["ptext"] = "Username";
   drw["pvalue"] = "username";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["ptext"] = "First Name";
   drw["pvalue"] = "firstname";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["ptext"] = "Last Name";
   drw["pvalue"] = "lastname";
   tblReturn.Rows.Add(drw);

   cboSearch.DataSource = tblReturn;
   cboSearch.DisplayMember = "ptext";
   cboSearch.ValueMember = "pvalue";
   cboSearch.SelectedIndex = 0;

  }

  private void LoadUsername()
  {
   dgvUsername.DataSource = "";
   TimeSheetAccess objTimeSheetAccess = new TimeSheetAccess();
   cboUsername.DataSource = objTimeSheetAccess.DSLActive(cboSearch.SelectedValue.ToString(),txtSearch.Text);
   cboUsername.DisplayMember = "ptext";
   cboUsername.ValueMember = "pvalue";
   cboUsername.SelectedIndex = 0;
   
  }

  private void LoadDepartment()
  {
   cboDepartment.DataSource = Department.GetDSL();
   cboDepartment.DisplayMember = "ptext";
   cboDepartment.ValueMember = "pvalue";
   cboDepartment.SelectedIndex = 0;
  }

  private void LoadUsernameAccess()
  {
   try
   {
    dgvUsername.DataSource = "";
    TimeSheetAccess objTimesheetAccess = new TimeSheetAccess();
    dgvUsername.AutoGenerateColumns = false;
    dgvUsername.Columns[1].DataPropertyName = "ptext";
    dgvUsername.Columns[2].DataPropertyName = "pvalue";
    dgvUsername.DataSource = objTimesheetAccess.DSLUsernameAccess(cboUsername.SelectedValue.ToString());

    foreach (DataGridViewRow dgRow in dgvUsername.Rows)
    {
     dgRow.Cells[0].Value = false;
    }
   }
   catch (Exception)
   {
    throw;
   }
  }

  private void LoadDepartmentEmployees()
  {
   try
   {
    TimeSheetAccess objTimesheetAccess = new TimeSheetAccess();
    dgvDepartment.DataSource = objTimesheetAccess.DSLDepartmentEmployees(cboDepartment.SelectedValue.ToString(), cboUsername.SelectedValue.ToString());
    dgvDepartment.AutoGenerateColumns = false;
    dgvDepartment.Columns[1].DataPropertyName = "ptext";
    dgvDepartment.Columns[2].DataPropertyName = "pvalue";

    foreach (DataGridViewRow dgRow in dgvDepartment.Rows)
    {
     dgRow.Cells[0].Value = false;
    }

   }
   catch (Exception)
   {

    throw;
   }
  }


  /////////////////////////////////////
  //////////// FORM EVENTS ////////////
  /////////////////////////////////////

  private void frmTimeSheetAccessMain_Load(object sender, EventArgs e)
  {
   this.Cursor = Cursors.WaitCursor;
   FillCombobox();
   LoadUsername();
   LoadDepartment();
   LoadDepartmentEmployees();
   cboDepartment.SelectedIndex = 0;
   cboUsername.SelectedIndex = 0;
   LoadUsernameAccess();
   this.Cursor = Cursors.Default;
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
   LoadUsername();
   cboUsername.SelectedIndex = 0;
  }

  private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
  {
   if(e.KeyChar == 13)
   {
    LoadUsername();
   }
  }

  private void cboUsername_SelectedIndexChanged(object sender, EventArgs e)
  {
   LoadUsernameAccess();
  }

  private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
  {
   LoadDepartmentEmployees();
  }

  private void btnMoveLeft_Click(object sender, EventArgs e)
  {
   TimeSheetAccess objTimesheet = new TimeSheetAccess();
   DataTable tblSource = new DataTable();
   tblSource.Columns.Add("username");
   tblSource.Columns.Add("approver");

   DataRow drw;
   foreach (DataGridViewRow dgRow in dgvDepartment.Rows)
   { 
    if(bool.Parse(dgRow.Cells[0].Value.ToString()) == true)
    {
     drw = tblSource.NewRow();
     drw["approver"] = cboUsername.SelectedValue.ToString();
     drw["username"] = dgRow.Cells[2].Value.ToString();
     tblSource.Rows.Add(drw);
    }
   }
   objTimesheet.TimesheetGrantAccess(tblSource);
   LoadUsernameAccess();
   LoadDepartmentEmployees();
  }

  private void btnMoveRight_Click(object sender, EventArgs e)
  {
   TimeSheetAccess objTimesheet = new TimeSheetAccess();
   DataRow drw;
   DataTable tblSource = new DataTable();
   tblSource.Columns.Add("username");
   tblSource.Columns.Add("approver");

   foreach (DataGridViewRow dgRow in dgvUsername.Rows)
   {
    if (bool.Parse(dgRow.Cells[0].Value.ToString()) == true)
    {
     drw = tblSource.NewRow();
     drw["approver"] = cboUsername.SelectedValue.ToString();
     drw["username"] = dgRow.Cells[2].Value.ToString();
     tblSource.Rows.Add(drw);
    }
   }
   objTimesheet.TimesheetRemoveAccess(tblSource);
   LoadUsernameAccess();
   LoadDepartmentEmployees();
  }

  private void btnSelectAllUsername_Click(object sender, EventArgs e)
  {
   foreach (DataGridViewRow dgRow in dgvUsername.Rows)
   {
    dgRow.Cells[0].Value = "True";
   }
  }

  private void btnCheckAllDepartment_Click(object sender, EventArgs e)
  {
   foreach (DataGridViewRow dgRow in dgvDepartment.Rows)
   {
    dgRow.Cells[0].Value = "True";
   }
  }

  private void btnUnmarkAllUsername_Click(object sender, EventArgs e)
  {
   foreach (DataGridViewRow dgRow in dgvUsername.Rows)
   {
    dgRow.Cells[0].Value = "False";
   }
  }

  private void btnUnmarkAllDepartment_Click(object sender, EventArgs e)
  {
   foreach (DataGridViewRow dgRow in dgvDepartment.Rows)
   {
    dgRow.Cells[0].Value = "False";
   }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }
 }
}
