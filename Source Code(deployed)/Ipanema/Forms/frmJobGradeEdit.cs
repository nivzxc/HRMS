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
 public partial class frmJobGradeEdit : Form
 {
  private string _strJGCode;
  private FormCallers _FormCaller;
  private frmJobGradeList _frmJobGradeList;

  public frmJobGradeEdit(frmJobGradeList pfrmJobGradeList)
  {
   _frmJobGradeList = pfrmJobGradeList;
   InitializeComponent();
  }

  public FormCallers FormCaller { get { return _FormCaller; } set { _FormCaller = value; } }
  public string JGCode { get { return _strJGCode; } set { _strJGCode = value; } }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (strErrorMessage != "")
   {
    MessageBox.Show("Data entry error:" + strErrorMessage, "HRMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }

  private void LoadDetails()
  {
   txtJGCode.Text = _strJGCode;
   using (JobGrade objJobGrade = new JobGrade())
   {
    objJobGrade.JGCode = _strJGCode;
    objJobGrade.Fill();
    txtDescription.Text = objJobGrade.JGDescription;
    txtLevel.Text = objJobGrade.JGOrder.ToString();
    chkDeductLate.Checked = (objJobGrade.DeductLate == "1" ? true : false);
    chkDeductUndertime.Checked = (objJobGrade.DeductUnderTime == "1" ? true : false);
    chkPayOvertime.Checked = (objJobGrade.PayOverTime == "1" ? true : false);
    txtPlantillaCountHQ.Text = objJobGrade.PlantillaCountHQ.ToString();
    txtPlantillaCountBillable.Text = objJobGrade.PlantillaCountBillable.ToString();
    txtCreateBy.Text = objJobGrade.CreateBy;
    txtCreateOn.Text = objJobGrade.CreateOn.ToString("MMM dd, yyyy hh:mm tt");
    txtModifyBy.Text = objJobGrade.ModifyBy;
    txtModifyOn.Text = objJobGrade.ModifyOn.ToString("MMM dd, yyyy hh:mm tt");
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmJobGradeEdit_Load(object sender, EventArgs e)
  {
   LoadDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    if (MessageBox.Show("Warning: \nModifying job grade settings might cause discrepancies on employee's details associated with it. \nIt is advisable to create a new job grade than to modify/delete existing one.\n\nAre you sure to continue?", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
    {
     using (JobGrade objJobGrade = new JobGrade())
     {
      objJobGrade.JGCode = txtJGCode.Text;
      objJobGrade.JGDescription = txtDescription.Text;
      objJobGrade.JGOrder = clsValidator.CheckInteger(txtLevel.Text);
      objJobGrade.DeductLate = (chkDeductLate.Checked ? "1" : "0");
      objJobGrade.DeductUnderTime = (chkDeductUndertime.Checked ? "1" : "0");
      objJobGrade.PayOverTime = (chkPayOvertime.Checked ? "1" : "0");
      objJobGrade.PlantillaCountHQ = clsValidator.CheckInteger(txtPlantillaCountHQ.Text);
      objJobGrade.PlantillaCountBillable = clsValidator.CheckInteger(txtPlantillaCountBillable.Text);
      objJobGrade.Update();
     }
     _frmJobGradeList.BindJobGradeList();
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