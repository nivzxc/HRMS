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
 public partial class frmEmployeeTitleNew : Form
 {
  private FormCallers _FormCaller;
  private frmEmployeeDetails pfrmEmployeeDetails;

  public FormCallers FormCaller { set { _FormCaller = value; } }

  public frmEmployeeTitleNew(frmEmployeeDetails pEmployeeDetails)
  {
   InitializeComponent();
   pfrmEmployeeDetails = pEmployeeDetails;
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (txtTitle.Text == "")
   {
    MessageBox.Show("Employee title field is required.", clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   }
   else
   {
    int intResult = 0;
    clsEmployeeTitle employeetitle = new clsEmployeeTitle();
    employeetitle.Title = txtTitle.Text;
    intResult = employeetitle.Add();

    if (intResult > 0)
    {
     switch (_FormCaller)
     {
      case FormCallers.EmployeeDetails:
       pfrmEmployeeDetails.BindEmployeeTitle();
       break;
     }
    }
    else
     MessageBox.Show("An error occured while adding a new record.", clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Error);

    Close();
   }
  }

  private void txtTitle_KeyDown(object sender, KeyEventArgs e)
  {
   if(e.KeyCode == Keys.Enter)
    btnSave_Click(null, null);
  }

 }
}
