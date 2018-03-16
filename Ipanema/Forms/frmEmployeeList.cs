using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HRMS;
using CarlosAg.ExcelXmlWriter;
//using Excel = Microsoft.Office.Interop.Excel;
//using System.Reflection;

namespace Ipanema.Forms
{
 public partial class frmEmployeeList : Form
 {
     private string _strUsername;

     private mdiIpanema _frmMDiCaller;
     public mdiIpanema FormMDICaller { get { return _frmMDiCaller; } set { _frmMDiCaller = value; } }

     public string Username { set { _strUsername = value; } get { return _strUsername; } }

  public frmEmployeeList() { InitializeComponent(); }

  public void BindEmployeeList() //edited Jan 12, 2018 by calvin cavite (UPDATE Frm: private void, UPDATE To: public void)
  {
   string strWhere = "";

   strWhere = "WHERE lastname LIKE '" + txtLastName.Text.Replace("'", "") + "%' ";
   if (cmbJobGrade.SelectedValue.ToString() != "ALL")
    strWhere += "AND jgcode='" + cmbJobGrade.SelectedValue.ToString() + "' ";
   if (cmbStatus.SelectedValue.ToString() != "ALL")
    strWhere += "AND pstatus='" + cmbStatus.SelectedValue.ToString() + "' ";
   if (cmbEmployeeType.SelectedValue.ToString() != "ALL")
    strWhere += "AND etypcode='" + cmbEmployeeType.SelectedValue.ToString() + "' ";
   if (cmbEmployeeStatus.SelectedValue.ToString() != "ALL")
    strWhere += "AND esttcode='" + cmbEmployeeStatus.SelectedValue.ToString() + "' ";
   if (cmbDivision.SelectedValue.ToString() != "ALL")
    strWhere += "AND divicode='" + cmbDivision.SelectedValue.ToString() + "' ";
   if (cmbGroup.SelectedValue.ToString() != "ALL")
    strWhere += "AND grpcode='" + cmbGroup.SelectedValue.ToString() + "' ";
   if (cmbDepartment.SelectedValue.ToString() != "ALL")
    strWhere += "AND deptcode='" + cmbDepartment.SelectedValue.ToString() + "' ";
   if (cmbGender.SelectedValue.ToString() != "ALL")
    strWhere += "AND gender='" + cmbGender.SelectedValue.ToString() + "' ";

   System.Data.DataTable tblEmployeeList = Employee.DSGEmployeeList(strWhere);
   dgEmployeeList.AutoGenerateColumns = false;
   dgEmployeeList.DataSource = tblEmployeeList;
   dgEmployeeList.Columns[0].DataPropertyName = "Username";
   dgEmployeeList.Columns[1].DataPropertyName = "EmployeeNumber";
   dgEmployeeList.Columns[2].DataPropertyName = "Lastname";
   dgEmployeeList.Columns[3].DataPropertyName = "Firstname";
   dgEmployeeList.Columns[4].DataPropertyName = "JGCode";
   dgEmployeeList.Columns[5].DataPropertyName = "EmployeeType";
   dgEmployeeList.Columns[6].DataPropertyName = "EmploymentStatus";
   dgEmployeeList.Columns[7].DataPropertyName = "Division";
   dgEmployeeList.Columns[8].DataPropertyName = "Group";
   dgEmployeeList.Columns[9].DataPropertyName = "Department";

   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgEmployeeList.Rows.Count.ToString());
  }
  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmEmployeeList_Load(object sender, EventArgs e)
  {
   txtLastName.Text = Username;      
   this.WindowState = FormWindowState.Maximized;

   cmbGender.DataSource = Employee.DSLGenderAll();
   cmbGender.ValueMember = "pvalue";
   cmbGender.DisplayMember = "ptext";

   cmbDivision.DataSource = Division.DSLDivisionAll();
   cmbDivision.ValueMember = "pvalue";
   cmbDivision.DisplayMember = "ptext";

   cmbGroup.DataSource = Group.GetDSLAll(cmbDivision.SelectedValue.ToString());
   cmbGroup.ValueMember = "pvalue";
   cmbGroup.DisplayMember = "ptext";

   cmbDepartment.DataSource = Department.GetDSLAll(cmbGroup.SelectedValue.ToString());
   cmbDepartment.ValueMember = "pvalue";
   cmbDepartment.DisplayMember = "ptext";

   cmbJobGrade.DataSource = JobGrade.DSLJGCodeAll();
   cmbJobGrade.ValueMember = "pvalue";
   cmbJobGrade.DisplayMember = "ptext";

   cmbEmployeeType.DataSource = clsEmployeeType.DSLEmployeeTypeAll();
   cmbEmployeeType.ValueMember = "pvalue";
   cmbEmployeeType.DisplayMember = "ptext";

   cmbEmployeeStatus.DataSource = clsEmploymentStatus.DSLEmploymentStatusAll();
   cmbEmployeeStatus.ValueMember = "pvalue";
   cmbEmployeeStatus.DisplayMember = "ptext";

   cmbStatus.DataSource = Employee.DSLStatusAll();
   cmbStatus.ValueMember = "pvalue";   
   cmbStatus.DisplayMember = "ptext";

   cmbStatus.SelectedValue = "1";
   BindEmployeeList();   
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
      mdiIpanema objmdi = new mdiIpanema();
      objmdi.DSGZeroEL();
      Close();
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {
   frmEmployeeNew pForm = new frmEmployeeNew();
   pForm.ShowDialog();
  }

  private void tbtnModify_Click(object sender, EventArgs e)
  {
   if (dgEmployeeList.SelectedRows.Count > 0)
   {
    frmEmployeeDetails pForm = new frmEmployeeDetails();
    pForm.FormEmployeeList = this;
    pForm.FormMDICaller = _frmMDiCaller;
    pForm.Username = dgEmployeeList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.Show();

   }
  }

  private void tbtnEnable_Click(object sender, EventArgs e)
  {
   if (dgEmployeeList.SelectedRows.Count > 0)
   {
    Employee.EnableAccount(dgEmployeeList.SelectedRows[0].Cells[0].Value.ToString());
    BindEmployeeList();
   }
  }

  private void tbtnDisable_Click(object sender, EventArgs e)
  {
   if (dgEmployeeList.SelectedRows.Count > 0)
   {
    Employee.DisableAccount(dgEmployeeList.SelectedRows[0].Cells[0].Value.ToString());
    BindEmployeeList();
   }
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindEmployeeList();
  }

  private void frmEmployeeList_Activated(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("Total Records: " + dgEmployeeList.Rows.Count.ToString());
  }

  private void frmEmployeeList_Deactivate(object sender, EventArgs e)
  {
   HRMSCore.UpdateStatusBarFormInfo("");
  }

  private void dgEmployeeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   tbtnModify_Click(null, null);
  }

  private void dgEmployeeList_SelectionChanged(object sender, EventArgs e)
  {
   if (dgEmployeeList.SelectedRows.Count > 0 && dgEmployeeList.SelectedRows[0].Cells[0].Value != null)
   {
    using (Employee employee = new Employee())
    {
     employee.Username = dgEmployeeList.SelectedRows[0].Cells[0].Value.ToString();
     employee.Fill();
     picEmployee.Image = employee.Image;
     lvEmployeeDetails.Items[0].SubItems[1].Text = employee.EmployeeNumber;
     lvEmployeeDetails.Items[1].SubItems[1].Text = employee.Username;
     lvEmployeeDetails.Items[2].SubItems[1].Text = employee.LastName + ", " + employee.FirstName;
     lvEmployeeDetails.Items[3].SubItems[1].Text = employee.NickName;
     lvEmployeeDetails.Items[4].SubItems[1].Text = employee.EmailOfficial;
     lvEmployeeDetails.Items[5].SubItems[1].Text = employee.BirthDate.ToString("MMM dd, yyyy");
     lvEmployeeDetails.Items[6].SubItems[1].Text = employee.Position;
     lvEmployeeDetails.Items[7].SubItems[1].Text = employee.EmploymentStatusCode;
     lvEmployeeDetails.Items[8].SubItems[1].Text = (employee.DateStart == clsDateTime.SystemMinDate ? "-" : employee.DateStart.ToString("MMM dd, yyyy"));
     lvEmployeeDetails.Items[9].SubItems[1].Text = (employee.DateRegular == clsDateTime.SystemMinDate ? "-" : employee.DateRegular.ToString("MMM dd, yyyy"));
     lvEmployeeDetails.Items[10].SubItems[1].Text = employee.UpdatedBy;
     lvEmployeeDetails.Items[11].SubItems[1].Text = (employee.UpdatedOn == clsDateTime.SystemMinDate ? "-" : employee.UpdatedOn.ToString("MMM dd, yyyy"));
     tbtnEnable.Enabled = (employee.Status == "0");
     tbtnDisable.Enabled = (employee.Status == "1");
    }
   }
  }

  private void chkShowDetails_CheckedChanged(object sender, EventArgs e)
  {
   pnlEmployeeDetails.Visible = chkShowDetails.Checked;
  }

  private void tbtnExport_Click(object sender, EventArgs e)
  {
   //Excel.Application xapList;
   //Excel._Workbook xwbList;
   //Excel._Worksheet xwsList;
   //try
   //{
   // xapList = new Excel.Application();
   // xapList.Visible = true;
   // xwbList = (Excel._Workbook)(xapList.Workbooks.Add(Missing.Value));
   // xwsList = (Excel._Worksheet)xwbList.ActiveSheet;
   // xwsList.Cells[1, 1] = "First Name";
   // xwsList.Cells[1, 2] = "Last Name";
   // xwsList.Cells[1, 3] = "Full Name";
   // xwsList.Cells[1, 4] = "Salary";
   //}
   //catch(Exception pException)
   //{
   // MessageBox.Show("An error occured while processing your request.\n\n" + pException.Message);
   //}

  }

  private void tbtnExportExcel_Click(object sender, EventArgs e)
  {
   sfdExportExcel.FileName = "EmployeeList_" + DateTime.Now.ToString("yyMMdd_HHmmss") + ".xls";
   sfdExportExcel.ShowDialog();  
  }

  private void sfdExportExcel_FileOk(object sender, CancelEventArgs e)
  {
   Workbook xlsBook = new Workbook();
   Worksheet xlsSheet = xlsBook.Worksheets.Add("EmployeeeList");
   WorksheetRow xlsRow = xlsSheet.Table.Rows.Add();
   xlsRow.Cells.Add("Number");
   xlsRow.Cells.Add("Last Name");
   xlsRow.Cells.Add("First Name");
   xlsRow.Cells.Add("JG Code");
   xlsRow.Cells.Add("Employee Type");
   xlsRow.Cells.Add("Employment Status");
   xlsRow.Cells.Add("Division");
   xlsRow.Cells.Add("Group");
   xlsRow.Cells.Add("Department");

   foreach (DataGridViewRow drw in dgEmployeeList.Rows)
   {
    xlsRow = xlsSheet.Table.Rows.Add();
    xlsRow.Cells.Add(drw.Cells[1].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[2].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[3].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[4].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[5].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[6].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[7].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[8].Value.ToString());
    xlsRow.Cells.Add(drw.Cells[9].Value.ToString());
   }
   xlsBook.Save(sfdExportExcel.FileName);
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
   try { BindEmployeeList(); }
   catch { }
  }

  private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
  {
   try
   {
    cmbGroup.DataSource = Group.GetDSLAll(cmbDivision.SelectedValue.ToString());
    cmbGroup.ValueMember = "pvalue";
    cmbGroup.DisplayMember = "ptext";
   }
   catch
   {
   }
  }

  private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
  {
   try
   {
    cmbDepartment.DataSource = Department.GetDSLAll(cmbGroup.SelectedValue.ToString());
    cmbDepartment.ValueMember = "pvalue";
    cmbDepartment.DisplayMember = "ptext";
   }
   catch
   {
   }
  }

        private void btnSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
       
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            btnSearch_Click(null, null);
        }
    }
}