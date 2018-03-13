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
 public partial class frmRecruitmentSourceAdd : Form
 {
  public frmRecruitmentSourceAdd() { InitializeComponent(); }

  private frmRecruitmentSourceList _frmRecruitmentSourceList;
  private frmEmployeeNew _frmEmployeeNew;
  private frmEmployeeDetails _frmEmployeeDetails;
  private FormCallers _FormCaller;

  public frmRecruitmentSourceList FormRecruitmentSourceList { set { _frmRecruitmentSourceList = value; } get { return _frmRecruitmentSourceList; } }
  public frmEmployeeNew FormEmployeeNew { set { _frmEmployeeNew = value; } get { return _frmEmployeeNew; } }
  public frmEmployeeDetails FormEmployeeDetails { set { _frmEmployeeDetails = value; } get { return _frmEmployeeDetails; } }
  public FormCallers FormCaller { set { _FormCaller = value; } get { return _FormCaller; } }

  private void ClearFields()
  {
   txtCode.Text = clsRecruitmentSource.GenerateCode();
   txtSource.Text = "";
   chkEnabled.Checked = false;
   txtSource.Focus();
  }

  private bool IsCorrectEntries()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (txtSource.Text == "")
    strErrorMessage += "\nSource field is required.";

   if (strErrorMessage != "")
   {
    blnReturn = false;
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   }

   return blnReturn;
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmRecruitmentSourceAdd_Load(object sender, EventArgs e)
  {
   ClearFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectEntries())
   {
    int intAffected = 0;
    using (clsRecruitmentSource source = new clsRecruitmentSource())
    {
     source.RecruitmentSourceName = txtSource.Text;
     source.Enabled = (chkEnabled.Checked ? "1" : "0");
     intAffected = source.Insert();
    }
    if (intAffected > 0)
    {
     switch (_FormCaller)
     {
      case FormCallers.RecruitmentSourceList:
       _frmRecruitmentSourceList.BindRecruitmentSourceList();
       break;
      case FormCallers.EmployeeNew:
       _frmEmployeeNew.BindRecruitmentSourceList();
       break;
      case FormCallers.EmployeeDetails:
       _frmEmployeeDetails.BindRecruitmentSource();
       break;
     }
     if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      ClearFields();
     else
      this.Close();
    }
   }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}