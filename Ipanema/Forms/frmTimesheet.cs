using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HRMS;
using System.Xml;
using CarlosAg.ExcelXmlWriter;

namespace Ipanema.Forms
{
 public partial class frmTimesheet : Form
 {
  public frmTimesheet() { InitializeComponent(); }

  private frmPerfectAttendance _frmPerfectAttendance;
  private Form _frmCaller;
  private string _strUsername;
  private string _strFullName;
  private DateTime _dtStart;
  private DateTime _dtEnd;

  public frmPerfectAttendance FormPerfectAttendance { get { return _frmPerfectAttendance; } set { _frmPerfectAttendance = value; } }
  public Form FormCaller { get { return _frmCaller; } set { _frmCaller = value; } }
  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public string FullName { set { _strFullName = value; } get { return _strFullName; } }
  public DateTime DateStarted { get { return _dtStart; } set { _dtStart = value; } }
  public DateTime DateEnded { get { return _dtEnd; } set { _dtEnd = value; } }

  private void frmTimesheet_Load(object sender, EventArgs e)
  {
    txtLastName.Focus();
    dgvTimeSheet.AutoGenerateColumns = false;
    this.WindowState = FormWindowState.Maximized;

      LoadCurrentTimesheetPeriod();

            if (_strUsername != null && _strUsername.Length > 0)
            {
                BindTimeSheet();
            }
            else {

            }
  }
  private int GetImageListIndex(float pAbsentUnit, float pOBUnit, float pTCUnit)
  {
   if (pAbsentUnit > 0)
   {
    if (pOBUnit > 0 && pTCUnit == 0)
     return 5;
    else if (pOBUnit == 0 && pTCUnit > 0)
     return 4;
    else
     return 0;
   }
   else if (pOBUnit > 0 && pTCUnit == 0)
    return 3;
   else if (pOBUnit == 0 && pTCUnit > 0)
    return 2;
   else if (pOBUnit > 0 && pTCUnit > 0)
    return 1;
   else
    return 6;
  }

  private Color CheckZero(string pValue)
  {
   return (pValue == "0" ? Color.Gray : Color.Black);
  }

  private void LoadDataGridColorScheme()
  {
   foreach (DataGridViewRow drw in dgvTimeSheet.Rows)
   {
    drw.DefaultCellStyle.BackColor = clsTimesheet.GetStatusListBackColor(drw.Cells[0].Value.ToString());
    for (int ctr = 7; ctr <= 32; ctr++)
     drw.Cells[ctr].Style.ForeColor = CheckZero(drw.Cells[ctr].Value.ToString());
   }
  }

  public void BindTimeSheet()
  {
   txtName.Text = _strFullName;
   DataTable tblTimesheet = clsTimesheet.DSGFormTimeSheet(_strUsername, dtpFrom.Value, dtpTo.Value);
   dgvTimeSheet.DataSource = tblTimesheet;   
   dgvTimeSheet.Columns[0].DataPropertyName = "pstatus";
   dgvTimeSheet.Columns[1].DataPropertyName = "focsdate";
   dgvTimeSheet.Columns[2].DataPropertyName = "shftcode";
   dgvTimeSheet.Columns[3].DataPropertyName = "timein";
   dgvTimeSheet.Columns[4].DataPropertyName = "timeout";
   dgvTimeSheet.Columns[5].DataPropertyName = "shftin";
   dgvTimeSheet.Columns[6].DataPropertyName = "shftout";
   dgvTimeSheet.Columns[7].DataPropertyName = "ttalunit";
   dgvTimeSheet.Columns[8].DataPropertyName = "workunit";
   dgvTimeSheet.Columns[9].DataPropertyName = "absunit";
   dgvTimeSheet.Columns[10].DataPropertyName = "lwithpay";
   dgvTimeSheet.Columns[11].DataPropertyName = "lwoutpay";
   dgvTimeSheet.Columns[12].DataPropertyName = "lateunit";
   dgvTimeSheet.Columns[13].DataPropertyName = "undrunit";
   dgvTimeSheet.Columns[14].DataPropertyName = "obunit";
   dgvTimeSheet.Columns[15].DataPropertyName = "xcssunit";
   dgvTimeSheet.Columns[16].DataPropertyName = "reguxcss";
   dgvTimeSheet.Columns[17].DataPropertyName = "regunght";
   dgvTimeSheet.Columns[18].DataPropertyName = "restover";
   dgvTimeSheet.Columns[19].DataPropertyName = "restxcss";
   dgvTimeSheet.Columns[20].DataPropertyName = "restnght";
   dgvTimeSheet.Columns[21].DataPropertyName = "leglover";
   dgvTimeSheet.Columns[22].DataPropertyName = "leglxcss";
   dgvTimeSheet.Columns[23].DataPropertyName = "leglnght";
   dgvTimeSheet.Columns[24].DataPropertyName = "spclover";
   dgvTimeSheet.Columns[25].DataPropertyName = "spclxcss";
   dgvTimeSheet.Columns[26].DataPropertyName = "spclnght";
   dgvTimeSheet.Columns[27].DataPropertyName = "shrdover";
   dgvTimeSheet.Columns[28].DataPropertyName = "shrdxcss";
   dgvTimeSheet.Columns[29].DataPropertyName = "shrdnght";
   dgvTimeSheet.Columns[30].DataPropertyName = "lerdover";
   dgvTimeSheet.Columns[31].DataPropertyName = "lerdxcss";
   dgvTimeSheet.Columns[32].DataPropertyName = "lerdnght";

   LoadDataGridColorScheme();
  }


  //public void BindTimeSheetPerfectAttendance()
  //{
  //    txtName.Text = _strFullName;
  //    DataTable tblTimesheet = clsTimesheet.DSGFormTimeSheet(_strUsername, _dtStart, _dtEnd);
  //    dgvTimeSheet.DataSource = tblTimesheet;
  //    dgvTimeSheet.Columns[0].DataPropertyName = "pstatus";
  //    dgvTimeSheet.Columns[1].DataPropertyName = "focsdate";
  //    dgvTimeSheet.Columns[2].DataPropertyName = "shftcode";
  //    dgvTimeSheet.Columns[3].DataPropertyName = "timein";
  //    dgvTimeSheet.Columns[4].DataPropertyName = "timeout";
  //    dgvTimeSheet.Columns[5].DataPropertyName = "shftin";
  //    dgvTimeSheet.Columns[6].DataPropertyName = "shftout";
  //    dgvTimeSheet.Columns[7].DataPropertyName = "ttalunit";
  //    dgvTimeSheet.Columns[8].DataPropertyName = "workunit";
  //    dgvTimeSheet.Columns[9].DataPropertyName = "absunit";
  //    dgvTimeSheet.Columns[10].DataPropertyName = "lwithpay";
  //    dgvTimeSheet.Columns[11].DataPropertyName = "lwoutpay";
  //    dgvTimeSheet.Columns[12].DataPropertyName = "lateunit";
  //    dgvTimeSheet.Columns[13].DataPropertyName = "undrunit";
  //    dgvTimeSheet.Columns[14].DataPropertyName = "obunit";
  //    dgvTimeSheet.Columns[15].DataPropertyName = "xcssunit";
  //    dgvTimeSheet.Columns[16].DataPropertyName = "reguxcss";
  //    dgvTimeSheet.Columns[17].DataPropertyName = "regunght";
  //    dgvTimeSheet.Columns[18].DataPropertyName = "restover";
  //    dgvTimeSheet.Columns[19].DataPropertyName = "restxcss";
  //    dgvTimeSheet.Columns[20].DataPropertyName = "restnght";
  //    dgvTimeSheet.Columns[21].DataPropertyName = "leglover";
  //    dgvTimeSheet.Columns[22].DataPropertyName = "leglxcss";
  //    dgvTimeSheet.Columns[23].DataPropertyName = "leglnght";
  //    dgvTimeSheet.Columns[24].DataPropertyName = "spclover";
  //    dgvTimeSheet.Columns[25].DataPropertyName = "spclxcss";
  //    dgvTimeSheet.Columns[26].DataPropertyName = "spclnght";
  //    dgvTimeSheet.Columns[27].DataPropertyName = "shrdover";
  //    dgvTimeSheet.Columns[28].DataPropertyName = "shrdxcss";
  //    dgvTimeSheet.Columns[29].DataPropertyName = "shrdnght";
  //    dgvTimeSheet.Columns[30].DataPropertyName = "lerdover";
  //    dgvTimeSheet.Columns[31].DataPropertyName = "lerdxcss";
  //    dgvTimeSheet.Columns[32].DataPropertyName = "lerdnght";

  //    LoadDataGridColorScheme();
  //}

  public void LoadCurrentTimesheetPeriod()
  {
   string strCurrentTimeSheetPeriod = clsTimeSheetPeriod.GetCurrentTimeSheetPeriod();
   using (clsTimeSheetPeriod tsp = new clsTimeSheetPeriod(strCurrentTimeSheetPeriod))
   {
    tsp.Fill();
    dtpFrom.Value = tsp.PeriodFrom;
    dtpTo.Value = tsp.PeriodTo;
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void tsmiShowLegend_Click(object sender, EventArgs e)
  {
   pnlFooter.Visible = tsmiShowLegend.Checked;
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   BindTimeSheet();
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void tbtnViewTimesheet_Click(object sender, EventArgs e)
  {
   if (dgvTimeSheet.SelectedRows.Count > 0)
   {
    frmTimesheetDetails pForm = new frmTimesheetDetails();
    pForm.FormTimesheet = this;
    pForm.Username = _strUsername;
    pForm.FocusDate = clsValidator.CheckDate(dgvTimeSheet.SelectedRows[0].Cells[1].Value.ToString());
    pForm.Show();
   }
  }

  private void tbtnShiftDetails_Click(object sender, EventArgs e)
  {
   if (dgvTimeSheet.SelectedRows.Count > 0)
   {
    frmShiftDetails pForm = new frmShiftDetails();
    pForm.ShiftCode = dgvTimeSheet.SelectedRows[0].Cells[2].Value.ToString();
    pForm.Show();
   }
  }

  private void tbtnApplications_Click(object sender, EventArgs e)
  {
   if (dgvTimeSheet.SelectedRows.Count > 0)
   {
    frmTimesheetApplication pForm = new frmTimesheetApplication();
    pForm.Username = _strUsername;
    pForm.FocusDate = clsValidator.CheckDate(dgvTimeSheet.SelectedRows[0].Cells[1].Value.ToString());
    pForm.Show();
   }
  }

  private void tbtnProcess_Click(object sender, EventArgs e)
  {
            if (dgvTimeSheet.Rows.Count != 0)
            {

                if (MessageBox.Show("Are you sure to reprocess " + dgvTimeSheet.SelectedRows[0].Cells[1].Value.ToString() + "?", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    clsTimesheet.ProcessTimeSheet(_strUsername, clsValidator.CheckDate(dgvTimeSheet.SelectedRows[0].Cells[1].Value.ToString()));
            }
            else
            {
                MessageBox.Show("No Data to be process");
            }

  }

  private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
  {
   try { BindTimeSheet(); }
   catch { }
  }

  private void dgvTimeSheet_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
  {
   LoadDataGridColorScheme();
  }

  private void frmTimesheet_Shown(object sender, EventArgs e)
  {
   LoadDataGridColorScheme();
  }

  private void dtpFrom_ValueChanged(object sender, EventArgs e)
  {
   try { BindTimeSheet(); }
   catch { }
  }

  private void dtpTo_ValueChanged(object sender, EventArgs e)
  {
   try { BindTimeSheet(); }
   catch { }
  }

  private void tbtnExportExcel_Click(object sender, EventArgs e)
  {
   sfdExportExcel.FileName = "Timesheet-" + txtName.Text + "_" + DateTime.Now.ToString("yyMMdd_HHmmss") + ".xls";
   sfdExportExcel.ShowDialog();
  }

  private void chkViewOvertime_CheckedChanged(object sender, EventArgs e)
  {
   for (int i = 16; i < 33; i++)
    dgvTimeSheet.Columns[i].Visible = chkViewOvertime.Checked;
  }

  private void btnReloadTimesheet_Click(object sender, EventArgs e)
  {
   LoadCurrentTimesheetPeriod();
  }

  private void txtLastName_KeyUp(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Enter)
   {
    frmTimesheetEmployeeSelector pForm = new frmTimesheetEmployeeSelector();
    pForm.LastName = txtLastName.Text;
    pForm.FormTimeSheet = this;
    pForm.ShowDialog();
   }

  }

  private void sfdExportExcel_FileOk(object sender, CancelEventArgs e)
  {
       Workbook xlsBook = new Workbook();
       Worksheet xlsSheet = xlsBook.Worksheets.Add("Timesheet");
       WorksheetRow xlsRow = xlsSheet.Table.Rows.Add();

       xlsRow.Cells.Add("EMPLOYEE NAME:");
       xlsRow.Cells.Add();
       xlsRow.Cells.Add(txtName.Text);

            xlsRow = xlsSheet.Table.Rows.Add();
       xlsRow = xlsSheet.Table.Rows.Add();

       xlsRow.Cells.Add("Status");
       xlsRow.Cells.Add("Date");
       xlsRow.Cells.Add("Shift");
       xlsRow.Cells.Add("Time In");
       xlsRow.Cells.Add("Time Out");
       xlsRow.Cells.Add("Schedule In");
       xlsRow.Cells.Add("Schedule Out");
       xlsRow.Cells.Add("Total");
       xlsRow.Cells.Add("Work");
       xlsRow.Cells.Add("Absent");
       xlsRow.Cells.Add("LWP");
       xlsRow.Cells.Add("LWOP");
       xlsRow.Cells.Add("Late");
       xlsRow.Cells.Add("Undertime");

       foreach (DataGridViewRow drw in dgvTimeSheet.Rows)
       {
        xlsRow = xlsSheet.Table.Rows.Add();
        xlsRow.Cells.Add(drw.Cells[0].Value.ToString());
        xlsRow.Cells.Add(drw.Cells[1].Value.ToString());
        xlsRow.Cells.Add(drw.Cells[2].Value.ToString());
        xlsRow.Cells.Add(drw.Cells[3].Value.ToString());
        xlsRow.Cells.Add(drw.Cells[4].Value.ToString());
        xlsRow.Cells.Add(drw.Cells[5].Value.ToString());
        xlsRow.Cells.Add(drw.Cells[6].Value.ToString());
        xlsRow.Cells.Add(drw.Cells[7].Value.ToString());
        xlsRow.Cells.Add(drw.Cells[8].Value.ToString());
        xlsRow.Cells.Add(drw.Cells[9].Value.ToString());
        xlsRow.Cells.Add(drw.Cells[10].Value.ToString());
        xlsRow.Cells.Add(drw.Cells[11].Value.ToString());
        xlsRow.Cells.Add(drw.Cells[12].Value.ToString());
        xlsRow.Cells.Add(drw.Cells[13].Value.ToString());
       }
       xlsBook.Save(sfdExportExcel.FileName);
  }

  private void btnDeleteTimesheet_Click(object sender, EventArgs e)
  {
   if (dgvTimeSheet.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
    {
     using (clsTimesheet objTimesheet = new clsTimesheet())
     {
      objTimesheet.Username = _strUsername;
      objTimesheet.FocusDate = clsValidator.CheckDate(dgvTimeSheet.SelectedRows[0].Cells[1].Value.ToString());
      objTimesheet.Delete();
     }
     BindTimeSheet();
    }
   }
  }

  private void dgvTimeSheet_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgvTimeSheet.SelectedRows.Count > 0 && e.RowIndex != -1)
   {
    frmTimesheetDetails pForm = new frmTimesheetDetails();
    pForm.FormTimesheet = this;
    pForm.Username = _strUsername;
    pForm.FocusDate = clsValidator.CheckDate(dgvTimeSheet.Rows[e.RowIndex].Cells[1].Value.ToString());
    pForm.Show();
   }
  }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmsTimesheet_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgvTimeSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}