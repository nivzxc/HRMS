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
 public partial class frmIEmployeeLeaveUnderLateSummary : Form
 {
  public frmIEmployeeLeaveUnderLateSummary() { InitializeComponent(); }

  public void BindInquiryList()
  {
   DataTable tblInquiry = clsTimesheet.GetILALUDataSource(dtpFrom.Value, dtpTo.Value);
   dgInquiry.AutoGenerateColumns = false;
   dgInquiry.DataSource = tblInquiry;
   dgInquiry.Columns[0].DataPropertyName = "pname";
   dgInquiry.Columns[1].DataPropertyName = "tlwithpay";
   dgInquiry.Columns[2].DataPropertyName = "tlwoutpay";
   dgInquiry.Columns[3].DataPropertyName = "tabsunit";
   dgInquiry.Columns[4].DataPropertyName = "tlateunit";
   dgInquiry.Columns[5].DataPropertyName = "tundrunit";
  }

  private void LoadCurrentTimeSheetPeriod()
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

  private void frmIEmployeeLeaveUnderLateSummary_Load(object sender, EventArgs e)
  {
   LoadCurrentTimeSheetPeriod();
   BindInquiryList();
   this.WindowState = FormWindowState.Maximized;
  }

  private void dtpTo_ValueChanged(object sender, EventArgs e)
  {
   BindInquiryList();
  }

  private void dtpFrom_ValueChanged(object sender, EventArgs e)
  {
   BindInquiryList();
  }
 }

}