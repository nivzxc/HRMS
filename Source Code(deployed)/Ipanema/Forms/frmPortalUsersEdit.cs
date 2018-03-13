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
 public partial class frmPortalUsersEdit : Form
 {
  public frmPortalUsersEdit() { InitializeComponent(); }

  private string _strUsername;
  private frmPortalUsersList _frmPortalUsersList;

  public string Username { set { _strUsername = value; } get { return _strUsername; } }
  public frmPortalUsersList FormPortalUsersList { set { _frmPortalUsersList = value; } get { return _frmPortalUsersList; } }

  private bool IsCorrectData()
  {
   bool blnReturn = true;
   string strErrorMessage = "";

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

  private void BindDetails()
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

   txtUsername.Text = _strUsername;
   using (clsUsers user = new clsUsers())
   {
    user.Username = _strUsername;
    user.Fill();
    txtPassword.Text = user.Password;
    txtLastname.Text = user.LastName;
    txtFirstname.Text = user.FirstName;
    txtMiddleName.Text = user.MiddleName;
    txtNickName.Text = user.NickName;
    txtEmail.Text = user.Email;
    dtpBirthDate.Value = user.BirthDate;
    txtTitle.Text = user.Title;
    cmbSex.SelectedValue = user.Gender;
    cmbStatus.SelectedValue = user.Status;
   }
  }

  /////////////////////////////////
  ////////// Form Events //////////
  /////////////////////////////////

  private void frmPortalUsersEdit_Load(object sender, EventArgs e)
  {
   BindDetails();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
   if (IsCorrectData())
   {
    clsUsers users = new clsUsers();
    users.Username = _strUsername;
    users.Fill();
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
    users.Update();
    _frmPortalUsersList.BindUsersList();
    this.Close();
   }
  }

 }
}