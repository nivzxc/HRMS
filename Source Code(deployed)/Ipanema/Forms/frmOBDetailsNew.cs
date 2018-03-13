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
 public partial class frmOBDetailsNew : Form
 {
  public frmOBDetailsNew() { InitializeComponent(); }

  private frmOBEdit _frmOBEdit;
  private string _strOBCode;

  public string OBCode { set { _strOBCode = value; } get { return _strOBCode; } }
  public frmOBEdit FormOBEdit { set { _frmOBEdit = value; } get { return _frmOBEdit; } }

  private void InitializeFields()
  {
   dtpFocusDate.Value = DateTime.Now;
   dtpInDate.Value = DateTime.Now;
   dtpOutDate.Value = DateTime.Now;

   using (clsShift shift = new clsShift())
   {
    shift.ShiftCode = clsShift.GetDayShiftCode(OfficialBusiness.GetRequestor(_strOBCode), DateTime.Now);
    shift.Fill();    
    dtpInTime.Value = shift.TimeStart;    
    dtpOutTime.Value = shift.TimeEnd;
   }
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (dtpOutDate.Value < dtpInDate.Value)
    strErrorMessage = "Invalid date entries.";

   if (OfficialBusinessDetails.HasExistingApplication(_strOBCode, clsDateTime.CombineDateTime(dtpInDate.Value, dtpInTime.Value), clsDateTime.CombineDateTime(dtpOutDate.Value, dtpOutTime.Value)))
    strErrorMessage = "OB date already exist.";

   if (strErrorMessage != "")
   {
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmOBDetailsNew_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    using (OfficialBusinessDetails obdetails = new OfficialBusinessDetails())
    {
     obdetails.OBCode = _strOBCode;
     obdetails.FocusDate = dtpFocusDate.Value;
     obdetails.KeyIn = clsDateTime.CombineDateTime(dtpInDate.Value, dtpInTime.Value);
     obdetails.KeyOut = clsDateTime.CombineDateTime(dtpOutDate.Value, dtpOutTime.Value);
     obdetails.UpdateBy = HRMSCore.Username;
     obdetails.UpdateOn = DateTime.Now;
     obdetails.Insert();
    }
    _frmOBEdit.LoadOBDetails();
    this.Close();
   }
  }

  private void dtpFocusDate_ValueChanged(object sender, EventArgs e)
  {
   try
   {
    dtpInDate.Value = dtpFocusDate.Value;
    dtpOutDate.Value = dtpFocusDate.Value;
    using (clsShift shift = new clsShift())
    {
     shift.ShiftCode = clsShift.GetDayShiftCode(OfficialBusiness.GetRequestor(_strOBCode), dtpFocusDate.Value);
     shift.Fill();
     dtpInTime.Value = shift.TimeStart;
     dtpOutTime.Value = shift.TimeEnd;
    }
   }
   catch { }
  }

 }
}