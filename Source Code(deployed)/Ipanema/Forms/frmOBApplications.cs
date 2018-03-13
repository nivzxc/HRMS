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
 public partial class frmOBApplications : Form
 {
  private string _strUsername;
  private DateTime _dteFocusDate;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public DateTime FocusDate { set { _dteFocusDate = value; } get { return _dteFocusDate; } }

  public void BindOBList()
  {
   lvwOB.Items.Clear();
   DataTable tblOB = OfficialBusiness.GetDSGApplications(_dteFocusDate, _strUsername,cmbFilter.SelectedValue.ToString());
   foreach (DataRow drw in tblOB.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drw["obcode"].ToString();
    lvi.Tag = drw["obcode"].ToString();
    lvwOB.Items.Add(lvi);
   }
   if (lvwOB.Items.Count > 0)
    lvwOB.Items[0].Selected = true;
   else
    ClearFields();
  }

  private void ClearFields()
  {
   lblOBCode.Text = "";
   lblOBType.Text = "";
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
   lvOBDetails.Items.Clear();
  }

  private void BindDetails(string pObCode)
  {
   using (OfficialBusiness ob = new OfficialBusiness(pObCode))
   {
    ob.Fill();
    lblOBCode.Text = pObCode;
    lblOBType.Text = OfficialBusiness.GetOBTypeDesc(ob.OBType);
    lblDepartment.Text = Department.GetName(ob.DepartmentCode);
    lblRequestor.Text = Employee.GetName(ob.UserName);
    lblDateFile.Text = ob.DateFile.ToString("MMM dd, yyyy");
    lblReason.Text = ob.Reason;
    lblRApprover.Text = (ob.OBType == "1" ? Employee.GetName(ob.RAName) : "NA");
    lblRDate.Text = (ob.OBType == "1" ? ob.RADate.ToString("MM-dd-yyyy") : "NA");
    lblRRemarks.Text = (ob.OBType == "1" ? ob.RARemarks : "NA");
    lblHApprover.Text = Employee.GetName(ob.HAName);
    lblHDate.Text = ob.HADate.ToString("MM-dd-yyyy");
    lblHRemarks.Text = ob.HARemarks;
    lblStatus.Text = LeaveApplication.ToLeaveStatusDesc(ob.Status);
   }

   lvOBDetails.Items.Clear();
   DataTable tblOBDetails = OfficialBusinessDetails.DataTableByOBCode(pObCode);
   foreach (DataRow drw in tblOBDetails.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = clsValidator.CheckDate(drw["focsdate"].ToString()).ToString("MM-dd-yyyy");
    lvi.SubItems.Add(clsValidator.CheckDate(drw["keyin"].ToString()).ToString("MM-dd-yyyy hh:mm tt"));
    lvi.SubItems.Add(clsValidator.CheckDate(drw["keyout"].ToString()).ToString("MM-dd-yyyy hh:mm tt"));

    lvOBDetails.Items.Add(lvi);
   }
  }

  public frmOBApplications()
  {
   InitializeComponent();
  }

  ///////// Form Events /////////

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void lvwOB_SelectedIndexChanged(object sender, EventArgs e)
  {
   if (lvwOB.SelectedItems.Count > 0)
    BindDetails(lvwOB.SelectedItems[0].Tag.ToString());
  }

  private void frmOBApplications_Load(object sender, EventArgs e)
  {
   cmbFilter.DataSource = OfficialBusiness.DdlDsApproveFilter();
   cmbFilter.ValueMember = "pvalue";
   cmbFilter.DisplayMember = "ptext";
   BindOBList();
  }

  private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
  {
   BindOBList();
  }

 }
}