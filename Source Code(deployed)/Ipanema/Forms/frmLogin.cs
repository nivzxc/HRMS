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
 public partial class frmLogin : Form
 {
  public frmLogin()
  {
   InitializeComponent();
  }

  private void frmLogin_Load(object sender, EventArgs e)
  {

  }

  private void btnLogin_Click(object sender, EventArgs e)
  {
   if (HRMSCore.Login(txtUsername.Text, txtPassword.Text))
   {
    HRMSCore.Username = txtUsername.Text;
    HRMSCore.LoginDate = DateTime.Now;
    HRMSCore.Password = txtPassword.Text;
    mdiIpanema pForm = new mdiIpanema();
    pForm.FormLogin = this;
    pForm.Show();
    this.Hide();
    txtPassword.Text = "";
   }
   else
   {
    MessageBox.Show("Invalid username/password", clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    txtUsername.Focus();
   }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

  private void txtPassword_KeyDown(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Enter)
    btnLogin_Click(null, null);
  }

  private void txtUsername_KeyDown(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Enter)
    btnLogin_Click(null, null);
  }

 }
}