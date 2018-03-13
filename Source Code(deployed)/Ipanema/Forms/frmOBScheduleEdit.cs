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
 public partial class frmOBScheduleEdit : Form
 {
  public frmOBScheduleEdit() { InitializeComponent(); }

  private frmOBEdit _frmOBEdit;
  private string _strOBCode;
  private DateTime _dteFocusDate;

  public string OBCode { set { _strOBCode = value; } get { return _strOBCode; } }
  public DateTime FocusDate { set { _dteFocusDate = value; } get { return _dteFocusDate; } }
  public frmOBEdit FormOBEdit { set { _frmOBEdit = value; } get { return _frmOBEdit; } }

  private void BindDetails()
  {
   txtOBCode.Text = _strOBCode;
   dtpFocusDate.Value = _dteFocusDate;
   using (OfficialBusinessDetails obdetails = new OfficialBusinessDetails())
   {
    obdetails.OBCode = _strOBCode;
    obdetails.FocusDate = _dteFocusDate;
    obdetails.Fill();
    dtpInDate.Value = obdetails.KeyIn;
    dtpInTime.Value = obdetails.KeyIn;
    dtpOutDate.Value = obdetails.KeyOut;
    dtpOutTime.Value = obdetails.KeyOut;
    txtUpdateBy.Text = obdetails.UpdateBy;
    txtUpdateOn.Text = obdetails.UpdateOn.ToString("MMM dd, yyyy");
   }
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (dtpOutDate.Value < dtpInDate.Value)
    strErrorMessage = "Invalid date entries.";

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

  private void frmOBScheduleEdit_Load(object sender, EventArgs e)
  {
   BindDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {   
   if (IsCorrectData())
   {
    int intRecordsAffected = 0;
    using (OfficialBusinessDetails obdetails = new OfficialBusinessDetails())
    {
     obdetails.OBCode = _strOBCode;
     obdetails.FocusDate = clsDateTime.GetDateOnly(dtpFocusDate.Value);
     obdetails.KeyIn = clsDateTime.CombineDateTime(dtpInDate.Value, dtpInTime.Value);
     obdetails.KeyOut = clsDateTime.CombineDateTime(dtpOutDate.Value, dtpOutTime.Value);
     obdetails.UpdateBy = HRMSCore.Username;
     obdetails.UpdateOn = DateTime.Now;
     intRecordsAffected = obdetails.Update();
    }
    if (intRecordsAffected > 0)
    {
     _frmOBEdit.LoadOBDetails();
     this.Close();
    }
   }
  }

 }
}