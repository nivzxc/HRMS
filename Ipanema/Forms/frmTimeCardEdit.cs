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
 public partial class frmTimeCardEdit : Form
 {
  private frmTimeCardList _frmTimeCardList;
  private string _strUsername;
  private DateTime _dteFocusDate;
  private DateTime _dteKeyIn;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public DateTime FocusDate { set { _dteFocusDate = value; } get { return _dteFocusDate; } }
  public DateTime KeyIn { set { _dteKeyIn = value; } get { return _dteKeyIn; } }

  public frmTimeCardEdit(frmTimeCardList pfrmTimeCardList)
  {
   InitializeComponent();
   _frmTimeCardList = pfrmTimeCardList;
  }

  ///////////////////////////
  ///////// Methods ///////// 
  ///////////////////////////

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (clsDateTime.CombineDateTime(dtpInDate.Value, dtpInTime.Value) > clsDateTime.CombineDateTime(dtpOutDate.Value, dtpOutTime.Value))
    strErrorMessage = "Key Out field cannot be greater than Key In field.";

   if (strErrorMessage != "")
   {
    blnReturn = false;
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   }

   return blnReturn;
  }

  private void LoadDetails()
  {
   txtUsername.Text = _strUsername;
   dtpFocusDate.Value = _dteFocusDate;
   dtpInDate.Value = _dteKeyIn;
   dtpInTime.Value = _dteKeyIn;
   using (clsTimeCard tc = new clsTimeCard())
   {
    tc.Username = _strUsername;
    tc.FocusDate = _dteFocusDate;
    tc.KeyIn = _dteKeyIn;
    tc.Fill();
    dtpOutDate.Value = tc.KeyOut;
    dtpOutTime.Value = tc.KeyOut;
    txtUpdateBy.Text = tc.UpdateBy;
    txtUpdateOn.Text = tc.UpdateOn.ToString("ddd MMM dd, yyyy");
    txtRemarks.Text = tc.Remarks;
   }
  }

  //////////////////////////////  
  ///////// Form Event ///////// 
  //////////////////////////////

  private void frmTimeCardEdit_Load(object sender, EventArgs e)
  {
   LoadDetails();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {   
   if (IsCorrectEntries())
   {
    clsTimeCard tc = new clsTimeCard();
    tc.Username = _strUsername;
    tc.FocusDate = dtpFocusDate.Value;
    tc.KeyIn = clsDateTime.CombineDateTime(dtpInDate.Value, dtpInTime.Value);
    tc.KeyOut = clsDateTime.CombineDateTime(dtpOutDate.Value, dtpOutTime.Value);
    tc.UpdateBy = HRMSCore.Username;
    tc.UpdateOn = DateTime.Now;
    tc.Remarks = txtRemarks.Text;
    if (tc.Update(_dteKeyIn) > 0)
    {
     _frmTimeCardList.LoadTimeCardList();
     this.Close();
    }
   }
  }

 }
}
