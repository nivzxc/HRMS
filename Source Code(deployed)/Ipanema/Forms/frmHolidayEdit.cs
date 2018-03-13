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
 public partial class frmHolidayEdit : Form
 {
  private string _strHolidayCode;
  private frmHolidayList _frmHolidayList;

  public frmHolidayList FormHolidayList { set { _frmHolidayList = value; } get { return _frmHolidayList; } }
  public string HolidayCode { get { return _strHolidayCode; } set { _strHolidayCode = value; } }

  public void BindShiftList()
  {
   cmbShift.DataSource = clsShift.GetDdlDS();
   cmbShift.ValueMember = "pvalue";
   cmbShift.DisplayMember = "pvalue";
  }

  public frmHolidayEdit() { InitializeComponent(); }

  private void frmHolidayEdit_Load(object sender, EventArgs e)
  {
   BindShiftList();

   using (Holiday objHoliday = new Holiday())
   {
    objHoliday.HolidayCode = _strHolidayCode;
    objHoliday.Fill();
    txtHolidayCode.Text = objHoliday.HolidayCode;
    txtDateApplied.Text = objHoliday.DateApplied.ToString("MMM dd, yyyy");
    cmbShift.SelectedValue = objHoliday.ShiftCode;
    txtDescription.Text = objHoliday.Description;
    txtCreatedBy.Text = objHoliday.CreateBy;
    txtCreatedOn.Text = objHoliday.ModifyOn.ToString("MMM dd, yyyy hh:mm tt");
    txtUpdateBy.Text = objHoliday.ModifyBy;
    txtUpdateOn.Text = objHoliday.ModifyOn.ToString("MMM dd, yyyy hh:mm tt");
   }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   using (Holiday objHoliday = new Holiday())
   {
    objHoliday.HolidayCode = txtHolidayCode.Text;
    objHoliday.Fill();
    objHoliday.ShiftCode = cmbShift.SelectedValue.ToString();
    objHoliday.Description = txtDescription.Text;
    if (objHoliday.Update() >= 1)
    {
     _frmHolidayList.BindHolidayList();
     this.Close();
    }
    else
     MessageBox.Show(clsMessageBox.MessageBoxErrorAdd, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}
