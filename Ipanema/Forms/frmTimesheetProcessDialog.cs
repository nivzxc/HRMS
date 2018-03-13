using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HRMS;
using System.Threading;

namespace Ipanema.Forms
{
 public partial class frmTimesheetProcessDialog : Form
 {
  public frmTimesheetProcessDialog() { InitializeComponent(); }

  private string[] _strEmployeeList;
  private DateTime _dteDateStart;  
  private DateTime _dteDateEnd;

  public string[] EmployeeList { set { _strEmployeeList = value; } get { return _strEmployeeList; } }
  public DateTime DateStart { set { _dteDateStart = value; } get { return _dteDateStart; } }
  public DateTime DateEnd { set { _dteDateEnd = value; } get { return _dteDateEnd; } }

  public delegate void MessageCompleteDelegate();
  public void MessageComplete()
  {
   if (this.InvokeRequired)
   {
    this.BeginInvoke(new MessageCompleteDelegate(MessageComplete));
    return;
   }
   MessageBox.Show("Processing complete.", clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Information);
  }

  public delegate void CloseFormDelegate();
  public void CloseForm()
  {
   if (this.InvokeRequired)
   {
    this.BeginInvoke(new CloseFormDelegate(CloseForm));
    return;
   }
   this.Close();
  }

  public delegate void SetMinimumProgressDelegate(int pMinValue);

  public void SetMinimumProgress(int pMinValue)
  {
   if (this.InvokeRequired)
   {
    this.BeginInvoke(new SetMinimumProgressDelegate(SetMinimumProgress), new object[] { pMinValue });
    return;
   }
   prgTimeSheet.Minimum = pMinValue;
  }

  public delegate void SetMaximumProgressDelegate(int pMaxValue);
  public void SetMaximumProgress(int pMaxValue)
  {
   if (this.InvokeRequired)
   {
    this.BeginInvoke(new SetMaximumProgressDelegate(SetMaximumProgress), new object[] { pMaxValue });
    return;
   }
   prgTimeSheet.Maximum = pMaxValue;
  }

  public delegate void IncrementProgressDelegate();
  public void IncrementProgress()
  {
   if (this.InvokeRequired)
   {
    this.BeginInvoke(new IncrementProgressDelegate(IncrementProgress));
    return;
   }
   prgTimeSheet.Value += 1;
  }

  public delegate void UpdateLabeEmployeeDelegate(string pText);
  public void UpdateLabeEmployee(string pText)
  {
   if (this.InvokeRequired)
   {
    this.BeginInvoke(new UpdateLabeEmployeeDelegate(UpdateLabeEmployee), new object[] { pText });
    return;
   }
   lblProcessEmployee.Text = pText;
  }

  public delegate void UpdateLabeRemarksDelegate(string pText);
  public void UpdateLabeRemarks(string pText)
  {
   if (this.InvokeRequired)
   {
    this.BeginInvoke(new UpdateLabeRemarksDelegate(UpdateLabeRemarks), new object[] { pText });
    return;
   }
   lblProcessRemarks.Text = pText;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmTimesheetProcessDialog_Load(object sender, EventArgs e)
  {
  }

  private void frmTimesheetProcessDialog_Shown(object sender, EventArgs e)
  {
   //clsTimesheet.ProcessTimeSheet(_strEmployeeList, _dteDateStart, _dteDateEnd, prgTimeSheet, lblProcessEmployee, lblProcessRemarks, this)
   DateTime dteProcessDateStart = DateTime.Now;
   clsTimesheet timesheet = new clsTimesheet();
   timesheet.pEmployeeList = _strEmployeeList;
   timesheet.pDateStart = _dteDateStart;
   timesheet.pDateEnd = _dteDateEnd;
   timesheet.pProgressBar = prgTimeSheet;
   timesheet.pLabelProcessEmployee = lblProcessEmployee;
   timesheet.pLabelProcessRemarks = lblProcessRemarks;
   timesheet.pTimesheetProcessDialog = this;
   ThreadStart thds = new ThreadStart(timesheet.ProcessTimeSheet);
   Thread thd = new Thread(thds);
   thd.Start();
   //timesheet.ProcessTimeSheet();
   //MessageBox.Show("Processing complete!\n\nElapsed time: " + clsDateTime.DateDiff(pDateFormat.Minute, dteProcessDateStart, DateTime.Now), clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Information);
   //this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}
