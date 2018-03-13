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
 public partial class frmEmployeeTypeNew : Form
 {
  private FormCallers _FormCaller;
  private frmEmployeeDetails _frmEmployeeDetails;
  private frmEmployeeTypeList _frmEmployeeTypeList;

  public FormCallers FormCaller { set { _FormCaller = value; } }

  public frmEmployeeTypeNew(frmEmployeeDetails pfrmEmployeeDetails)
  {
   InitializeComponent();
   _frmEmployeeDetails = pfrmEmployeeDetails;
  }

  public frmEmployeeTypeNew(frmEmployeeTypeList pfrmEmployeeTypeList)
  {
   InitializeComponent();
   _frmEmployeeTypeList = pfrmEmployeeTypeList;
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   Close();
  }

  private void frmEmployeeTypeNew_Load(object sender, EventArgs e)
  {

  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   int intResult = 0;
   using (clsEmployeeType et = new clsEmployeeType())
   {
    et.Name = txtType.Text;
    et.Description = txtDetails.Text;
    et.Enabled = "1";
    et.CreateBy = HRMSCore.Username;
    et.CreateOn = DateTime.Now;
    et.ModifyBy = HRMSCore.Username;
    et.ModifyOn = DateTime.Now;
    intResult = et.Insert();
   }
   if (intResult > 0)
   {
    switch (_FormCaller)
    {
     case FormCallers.EmployeeDetails:
      _frmEmployeeDetails.BindEmployeeType();
      break;
     case FormCallers.EmployeeTypeList:
      _frmEmployeeTypeList.BindEmployeeTypeList();
      break;
    }
   }
   else
    MessageBox.Show("An error occured while adding employee type.\n\nPlease contact your system administrator.", clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error);
   this.Close();
  }

 }
}
