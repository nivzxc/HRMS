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
 public partial class frmUndertimeApplications : Form
 {

  private string _strUsername;
  private DateTime _dteFocusDate;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public DateTime FocusDate { set { _dteFocusDate = value; } get { return _dteFocusDate; } }

  public void BindList()
  {
   lvwUndertime.Items.Clear();
   DataTable tblUndertime = clsUndertime.Applications(_dteFocusDate, _strUsername, cmbFilter.SelectedValue.ToString());
   foreach (DataRow drw in tblUndertime.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drw["utcode"].ToString();
    lvi.Tag = drw["utcode"].ToString();
    lvwUndertime.Items.Add(lvi);
   }

   if (lvwUndertime.Items.Count > 0)
    lvwUndertime.Items[0].Selected = true;
   else
    ClearFields();
  }

  private void ClearFields()
  {
   lblUTCode.Text = "";
   lblRequestor.Text = "";
   lblDateFile.Text = "";
   lblApplication.Text = "";
   lblReason.Text = "";
   lblApprover.Text = "";
   lblDate.Text = "";
   lblRemarks.Text = "";
   lblStatus.Text = "";
  }

  private void BindDetails(string pUTCode)
  {
   using (clsUndertime ut = new clsUndertime(pUTCode))
   {
    ut.Fill();
    lblUTCode.Text = pUTCode;
    lblRequestor.Text = Employee.GetName(ut.Username);
    lblDateFile.Text = ut.DateFiled.ToString("MMM dd, yyyy");
    lblApplication.Text = ut.DateApplied.ToString("MMM dd, yyyy hh:mm tt");
    lblReason.Text = ut.Reason;
    lblApprover.Text = Employee.GetName(ut.ApproverUsername);
    lblDate.Text = ut.ApproverDate.ToString("MMM dd, yyyy");
    lblRemarks.Text = ut.ApproverRemarks;
    lblStatus.Text = clsUndertime.ToUndertimeStatusText(ut.Status);
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  public frmUndertimeApplications()
  {
   InitializeComponent();
  }

  private void frmUndertimeApplications_Load(object sender, EventArgs e)
  {
   cmbFilter.DataSource = clsUndertime.DdlDsApproveFilter();
   cmbFilter.ValueMember= "pvalue";
   cmbFilter.DisplayMember = "ptext";

   BindList();
  }

  private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
  {
   BindList();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void lvwUndertime_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (lvwUndertime.SelectedItems.Count > 0)
    BindDetails(lvwUndertime.SelectedItems[0].Tag.ToString());
  }

 }
}