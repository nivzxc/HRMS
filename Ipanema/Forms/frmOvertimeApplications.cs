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
 public partial class frmOvertimeApplications : Form
 {

  public frmOvertimeApplications()
  {
   InitializeComponent();
  }

  private string _strUsername;
  private DateTime _dteFocusDate;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public DateTime FocusDate { set { _dteFocusDate = value; } get { return _dteFocusDate; } }

  public void BindOTList()
  {
   lvwOT.Items.Clear();
   DataTable tblOT = clsOvertime.Applications(_dteFocusDate, _strUsername,cmbFilter.SelectedValue.ToString());
   foreach (DataRow drw in tblOT.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drw["otcode"].ToString();
    lvi.Tag = drw["otcode"].ToString();
    lvwOT.Items.Add(lvi);
   }
   if (lvwOT.Items.Count > 0)
    lvwOT.Items[0].Selected = true;
   else
    ClearFields();
  }

  private void ClearFields()
  {
   lblOTCode.Text = "";
   lblDepartment.Text = "";
   lblChargeType.Text = "";
   lblDepartment.Text = "";
   lblRequestor.Text = "";
   lblDateFile.Text = "";
   lblReason.Text = "";
   lblRApprover.Text = "";
   lblRDate.Text = "";
   lblRRemarks.Text = "";
   lblHApprover.Text = "";
   lblHDate.Text = "";
   lblHRemarks.Text = "";
   lblStatus.Text = "";
  }

  private void BindDetails(string pOTCode)
  {
   using (clsOvertime ot = new clsOvertime(pOTCode))
   {
    ot.Fill();
    lblOTCode.Text = pOTCode;
    lblDepartment.Text = (ot.ChargeType == "0" ? "Charge within the department" : Department.GetName(ot.DepartmentCode));
    lblChargeType.Text = clsOvertime.GetChargeTypeDesc(ot.ChargeType);
    lblDepartment.Text = Department.GetName(ot.DepartmentCode);
    lblRequestor.Text = Employee.GetName(ot.Username);
    lblDateFile.Text = ot.DateFile.ToString("MMM dd, yyyy hh:mm tt");
    lblDateStart.Text = ot.DateStart.ToString("ddd MMM dd, yyyy hh:mm tt");
    lblDateEnd.Text = ot.DateEnd.ToString("ddd MMM dd, yyyy hh:mm tt");
    lblReason.Text = ot.Reason;
    lblRApprover.Text = (ot.ChargeType == "1" ? Employee.GetName(ot.RequestorApproverName) : "NA");
    lblRDate.Text = (ot.ChargeType == "1" ? ot.RequestorApproverDate.ToString("MM-dd-yyyy") : "NA");
    lblRRemarks.Text = (ot.ChargeType == "1" ? ot.RequestorApproverRemarks : "NA");
    lblHApprover.Text = Employee.GetName(ot.HeadApproverName);
    lblHDate.Text = ot.HeadApproverDate.ToString("MM-dd-yyyy");
    lblHRemarks.Text = ot.HeadApproverRemarks;
    lblStatus.Text = clsOvertime.ToStatusDesc(ot.Status);
   }
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void frmOvertimeApplications_Load(object sender, EventArgs e)
  {
   cmbFilter.DataSource = clsOvertime.DdlDsApproveFilter();
   cmbFilter.ValueMember = "pvalue";
   cmbFilter.DisplayMember = "ptext";

   BindOTList();
  }

  private void lvwOT_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (lvwOT.SelectedItems.Count > 0)
   {
    BindDetails(lvwOT.SelectedItems[0].Tag.ToString());
   }
  }

 }
}