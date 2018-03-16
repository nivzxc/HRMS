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
 public partial class frmPortalUsersNew : Form
 {
  public frmPortalUsersNew() { InitializeComponent(); }

  private frmPortalUsersList _frmPortalUsersList;

  public frmPortalUsersList FormPortalUsersList { set { _frmPortalUsersList = value; } get { return _frmPortalUsersList; } }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

   if (cmbUsername.Text == "")
    strErrorMessage = "Username is required.";

   if (txtPassword.Text == "")
    strErrorMessage = "Password is required.";

   if (txtFirstname.Text == "")
    strErrorMessage = "First Name is required.";

   if (txtLastname.Text == "")
    strErrorMessage = "Last Name is required.";

   if (txtEmail.Text == "")
    strErrorMessage = "Email is required.";

   if (txtTitle.Text == "")
    strErrorMessage = "Title is required.";

   if (strErrorMessage != "")
   {
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    blnReturn = false;
   }

   return blnReturn;
  }

  private void InitializeFields()
  {
 

   DataTable tblSex = new DataTable();
   tblSex.Columns.Add(new DataColumn("pvalue"));
   tblSex.Columns.Add(new DataColumn("ptext"));
   DataRow drw = tblSex.NewRow();
   drw["pvalue"] = "M";
   drw["ptext"] = "Male";
   tblSex.Rows.Add(drw);

   drw = tblSex.NewRow();
   drw["pvalue"] = "F";
   drw["ptext"] = "Female";
   tblSex.Rows.Add(drw);

   cmbSex.DataSource = tblSex;
   cmbSex.ValueMember = "pvalue";
   cmbSex.DisplayMember = "ptext";

   cmbStatus.DataSource = clsUsers.GetDSLStatus();
   cmbStatus.ValueMember = "pvalue";
   cmbStatus.DisplayMember = "ptext";

   cmbUsername.DataSource = clsUsers.GetDSLUserName();
   cmbUsername.ValueMember = "pvalue";
   cmbUsername.DisplayMember = "ptext";

   cmbUsername.Focus();
  }

  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmPortalUsersNew_Load(object sender, EventArgs e)
  {
   InitializeFields();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    clsUsers users = new clsUsers();
    users.Username = cmbUsername.Text;
    users.Password = txtPassword.Text;
    users.LastName = txtLastname.Text;
    users.FirstName = txtFirstname.Text;
    users.MiddleName = txtMiddleName.Text;
    users.NickName = txtNickName.Text;
    users.Email = txtEmail.Text;
    users.BirthDate = dtpBirthDate.Value;
    users.Title = txtTitle.Text;
    users.Gender = cmbSex.SelectedValue.ToString();
    users.Online = "0";
    users.LastLog = DateTime.Now;
    users.UserClass = "H";
    users.Status = cmbStatus.SelectedValue.ToString();
    users.Insert();
    _frmPortalUsersList.BindUsersList();
                if (MessageBox.Show(clsMessageBox.MessageBoxSuccessAddAskNew, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InitializeFields();
                    txtPassword.Text = "";
                    txtFirstname.Text = "";
                    txtLastname.Text = "";
                    txtMiddleName.Text = "";
                    txtNickName.Text = "";
                    txtEmail.Text = "";
                    txtTitle.Text = "";
                }
                else { this.Close(); }
   }
  }

 }
}