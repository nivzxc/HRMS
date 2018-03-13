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
 public partial class frmRecruitmentSourceEdit : Form
 {
  public frmRecruitmentSourceEdit() { InitializeComponent(); }

  private string _strRecruitmentSourceCode;
  private frmRecruitmentSourceList _frmRecruitmentSourceList;

  public string RecruitmentSourceCode { set { _strRecruitmentSourceCode = value; } get { return _strRecruitmentSourceCode; } }
  public frmRecruitmentSourceList FormRecruitmentSourceList { set { _frmRecruitmentSourceList = value; } get { return _frmRecruitmentSourceList; } }

  private void BindRecruitmentSourceFields()
  {
   txtCode.Text = _strRecruitmentSourceCode;
   using (clsRecruitmentSource crs = new clsRecruitmentSource())
   {
    crs.RecruitmentSourceCode = _strRecruitmentSourceCode;
    crs.Fill();
    txtSource.Text = crs.RecruitmentSourceName;
    chkEnabled.Checked = (crs.Enabled == "1");
   }
  }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtSource.Text == "")
    strErrorMessage += "\nSource is required.";

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

  private void frmRecruitmentSourceEdit_Load(object sender, EventArgs e)
  {
   this.BindRecruitmentSourceFields();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (this.IsCorrectData())
   {
    using (clsRecruitmentSource crs = new clsRecruitmentSource())
    {
     crs.RecruitmentSourceCode = _strRecruitmentSourceCode;
     crs.Fill();
     crs.RecruitmentSourceName = txtSource.Text;
     crs.Enabled = (chkEnabled.Checked ? "1" : "0");
     if (crs.Update() > 0)
     {
      _frmRecruitmentSourceList.BindRecruitmentSourceList();
      this.Close();
     }
    }
   }
  }

 }
}