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
 public partial class frmUndertimeView : Form
 {
  private string _strUndertimeCode;
  private frmUndertimeList _frmUndertimeList;
  private FormCallers _FormCaller;

  public string UndertimeCode { set { _strUndertimeCode = value; } get { return _strUndertimeCode; } }
  public frmUndertimeList FormUndertimeList { set { _frmUndertimeList = value; } get { return _frmUndertimeList; } }
  public FormCallers FormCaller { set { _FormCaller = value; } get { return _FormCaller; } }

  public frmUndertimeView()
  {
   InitializeComponent();
  }

  private void BindDetails()
  {
   using (clsUndertime undertime = new clsUndertime(_strUndertimeCode))
   {
    undertime.Fill();
    txtUndertimeCode.Text = _strUndertimeCode;
    txtRequestor.Text = Employee.GetName(undertime.Username);
    txtFiled.Text = undertime.DateFiled.ToString("MMM dd, yyyy");
    txtApplied.Text = undertime.DateApplied.ToString("MMM dd, yyyy hh:mm tt");
    txtReason.Text = undertime.Reason;
    txtApprover.Text = Employee.GetName(undertime.ApproverUsername);
    txtDateProcessed.Text = undertime.ApproverDate.ToString("MMM dd, yyyy hh:mm tt");
    txtApproverRemarks.Text = undertime.ApproverRemarks;
    txtStatus.Text = clsUndertime.ToUndertimeStatusText(undertime.Status);
   }
  }

  ///////// Form Events /////////

  private void frmUndertimeView_Load(object sender, EventArgs e)
  {
   BindDetails();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 }
}