using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Media;
using System.IO;

namespace Ipanema
{
 public partial class frmLogInOut : Form
 {

  public static byte[] ReadFile(string pPath)
  {
   byte[] data = null;
   FileInfo fInfo = new FileInfo(pPath);
   long numBytes = fInfo.Length;
   FileStream fStream = new FileStream(pPath, FileMode.Open, FileAccess.Read);
   BinaryReader br = new BinaryReader(fStream);
   data = br.ReadBytes((int)numBytes);
   return data;
  }

  public static Image GetImage(object pImage)
  {
   Image imgReturn;
   byte[] bytImage;
   try
   {
    bytImage = (byte[])pImage;
   }
   catch
   {
    bytImage = ReadFile(System.Windows.Forms.Application.StartupPath + @"\default.jpg");
   }

   using (MemoryStream ms = new MemoryStream(bytImage, 0, bytImage.Length))
   {
    ms.Write(bytImage, 0, bytImage.Length);
    imgReturn = Image.FromStream(ms, true);
   }
   return imgReturn;
  }

  public frmLogInOut() { InitializeComponent(); }

  private DateTime FirstDayOfWeek()
  {
   DateTime dteFirstDay = DateTime.Now;
   switch (DateTime.Now.DayOfWeek)
   {
    case DayOfWeek.Sunday:
     dteFirstDay = DateTime.Now;
     break;
    case DayOfWeek.Monday:
     dteFirstDay = DateTime.Now.AddDays(-1);
     break;
    case DayOfWeek.Tuesday:
     dteFirstDay = DateTime.Now.AddDays(-2);
     break;
    case DayOfWeek.Wednesday:
     dteFirstDay = DateTime.Now.AddDays(-3);
     break;
    case DayOfWeek.Thursday:
     dteFirstDay = DateTime.Now.AddDays(-4);
     break;
    case DayOfWeek.Friday:
     dteFirstDay = DateTime.Now.AddDays(-5);
     break;
    case DayOfWeek.Saturday:
     dteFirstDay = DateTime.Now.AddDays(-6);
     break;
   }
   return dteFirstDay;
  }

  private void LoadLogHistory(string pUsername)
  {
   using (SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["cnSpeedo"].ToString()))
   {
    ListViewItem lvi;
    SqlCommand cmd = cn.CreateCommand();
    SqlDataReader dr;
    DateTime dteTemp = FirstDayOfWeek();
    cn.Open();
    lvwHistory.Items.Clear();
    for (int intCtr = 0; intCtr <= 6; intCtr++)
    {     
     lvi = new ListViewItem();
     lvi.SubItems[0].Text = dteTemp.ToString("MMM dd [ddd]");
     cmd.CommandText = "SELECT TOP 1 keyin FROM HR.TimeCard WHERE username='" + pUsername + "' AND focsdate = '" + dteTemp.Date + "' ORDER BY keyin";
     dr = cmd.ExecuteReader();
     if (dr.Read())
      lvi.SubItems.Add(Convert.ToDateTime(dr["keyin"].ToString()).ToString("MMM dd - hh:mm tt"));
     else
      lvi.SubItems.Add("-");
     dr.Close();

     cmd.CommandText = "SELECT TOP 1 keyout FROM HR.TimeCard WHERE username='" + pUsername + "' AND focsdate = '" + dteTemp.Date + "' ORDER BY keyout DESC";
     dr = cmd.ExecuteReader();
     if (dr.Read())
     {
      if (Convert.IsDBNull(dr["keyout"]))
       lvi.SubItems.Add("-");
      else
       lvi.SubItems.Add(Convert.ToDateTime(dr["keyout"].ToString()).ToString("MMM dd - hh:mm tt"));
     }
     else
      lvi.SubItems.Add("-");
     dr.Close();

     if (dteTemp.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy"))
      lvi.ForeColor = Color.LimeGreen;
     lvwHistory.Items.Add(lvi);
     dteTemp =  dteTemp.AddDays(1);
    }
   }

  }

  private void frmLogInOut_Load(object sender, EventArgs e)
  {
   tmrIn.Enabled = true;
   tmrLabel.Enabled = true;
   txtEmpNum.Focus();
  }

  private void tmrIn_Tick(object sender, EventArgs e)
  {
   lblDate.Text = DateTime.Now.ToString("dddd - MMMM dd, yyyy");
   lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
   if (DateTime.Now.Hour >= 9 || DateTime.Now.Hour <= 6)
    lblTime.ForeColor = Color.DarkSalmon;
   else
    lblTime.ForeColor = Color.RoyalBlue;
  }

  private void txtEmpNum_KeyDown(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Enter)
   {
    string strUserName = "";
    bool blnValidUser = false;
    bool blnHasLoginRecord = false;
    DateTime dteFocusDate = DateTime.Now;
    DateTime dteLatestKeyIn = DateTime.Now;

    pnlRemarks.Visible = true;
    SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["cnSpeedo"].ToString());
    cn.Open();
    SqlTransaction tran = cn.BeginTransaction();
    SqlCommand cmd = cn.CreateCommand();
    cmd.Transaction = tran;
    try
    {
     cmd.CommandText = "SELECT lastname + ', ' + firname AS name,username,pimage FROM HR.Employees WHERE empnum=@empnum";
     cmd.Parameters.Add("@empnum", SqlDbType.VarChar, 30);
     cmd.Parameters["@empnum"].Value = txtEmpNum.Text;
     SqlDataReader dr = cmd.ExecuteReader();
     blnValidUser = dr.Read();
     if (blnValidUser)
     {
      txtEmpName.Text = dr["name"].ToString();
      strUserName = dr["username"].ToString();
      if (Convert.IsDBNull(dr["pimage"]))
       picEmp.ImageLocation = Application.StartupPath + @"\icon-user.png";
      else
       picEmp.Image = GetImage(dr["pimage"]);
     }
     else
     {
      txtEmpName.Text = "Invalid Account!";
      lblRemarks.Text = "X";
      lblRemarks.ForeColor = Color.Red;
      picEmp.ImageLocation = Application.StartupPath + @"\icon-user.png";
     }
     dr.Close();

     if (blnValidUser)
     {
      cmd.Parameters.Clear();
      cmd.CommandText = "SELECT TOP 1 focsdate,keyin FROM HR.TimeCard WHERE username='" + strUserName + "' AND keyout is null ORDER BY focsdate,keyin DESC";
      dr = cmd.ExecuteReader();
      blnHasLoginRecord = dr.Read();
      if (blnHasLoginRecord)
      {
       dteLatestKeyIn = Convert.ToDateTime(dr["keyin"].ToString());
       dteFocusDate = Convert.ToDateTime(dr["focsdate"].ToString());
      }
      dr.Close();

      if (blnHasLoginRecord)
      {
       cmd.CommandText = "UPDATE HR.TimeCard SET keyout='" + DateTime.Now + "' WHERE username='" + strUserName + "' AND focsdate='" + dteFocusDate + "' AND keyin='" + dteLatestKeyIn + "'";
       lblRemarks.ForeColor = Color.RoyalBlue;
       lblRemarks.Text = "OUT";
       ACMTimeOut(); //ADDED by Calvin 03142018
      }
      else
      {
       cmd.CommandText = "INSERT INTO HR.TimeCard(username,focsdate,keyin,updateby,updateon) VALUES('" + strUserName + "','" + DateTime.Now.Date + "','" + DateTime.Now + "','" + strUserName + "','" + DateTime.Now + "')";
       lblRemarks.ForeColor = Color.LimeGreen;
       lblRemarks.Text = "IN";
       ACMTimeIN(); //ADDED by Calvin 03142018
                        }
      cmd.ExecuteNonQuery();
     }
     tran.Commit();
    }
    catch (Exception exp)
    { 
     tran.Rollback();
     MessageBox.Show("An error occured while saving your time sheet entry.\n\nPlease reenter your employee number.\n\n\nError Source: " + exp.Source + "\nMessage:" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally { cn.Close(); }

    if (lblRemarks.Text == "X")
     lvwHistory.Items.Clear();
    else
     LoadLogHistory(strUserName);
    txtEmpNum.Text = "";
   }
  }
    //ADDED by Calvin 03142018
  public void ACMTimeIN()
  {
            SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["cnSpeedo"].ToString());
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT INTO ACM.TimeCard(ControllerID,DoorID,Door,CardID,PersonalID,TDate,TTime,EventID,StaffID) "+
                              "VALUES (@ControllerID,@DoorID,@Door,@CardID,@PersonalID,@TDate,@TTime,@EventID,@StaffID)";
            cmd.Parameters.Add(new SqlParameter("@ControllerID", txtEmpNum.Text));
            cmd.Parameters.Add(new SqlParameter("@DoorID", 1));
            cmd.Parameters.Add(new SqlParameter("@Door", "PFICHQ"));
            cmd.Parameters.Add(new SqlParameter("@CardID", txtEmpNum.Text));
            cmd.Parameters.Add(new SqlParameter("@PersonalID", txtEmpNum.Text));
            cmd.Parameters.Add(new SqlParameter("@TDate", DateTime.Now.Date));
            cmd.Parameters.Add(new SqlParameter("@TTime", DateTime.Now));
            cmd.Parameters.Add(new SqlParameter("@EventID", 1));
            cmd.Parameters.Add(new SqlParameter("@StaffID", txtEmpNum.Text));
            cn.Open();
            cmd.ExecuteNonQuery();
  }

        //ADDED by Calvin 03142018
  public void ACMTimeOut() 
  {
            SqlConnection cn = new SqlConnection(ConfigurationSettings.AppSettings["cnSpeedo"].ToString());
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT INTO ACM.TimeCard(ControllerID,DoorID,Door,CardID,PersonalID,TDate,TTime,EventID,StaffID) " +
                              "VALUES (@ControllerID,@DoorID,@Door,@CardID,@PersonalID,@TDate,@TTime,@EventID,@StaffID)";
            cmd.Parameters.Add(new SqlParameter("@ControllerID", txtEmpNum.Text));
            cmd.Parameters.Add(new SqlParameter("@DoorID", 1));
            cmd.Parameters.Add(new SqlParameter("@Door", "PFICHQ"));
            cmd.Parameters.Add(new SqlParameter("@CardID", txtEmpNum.Text));
            cmd.Parameters.Add(new SqlParameter("@PersonalID", txtEmpNum.Text));
            cmd.Parameters.Add(new SqlParameter("@TDate", DateTime.Now.Date));
            cmd.Parameters.Add(new SqlParameter("@TTime", DateTime.Now));
            cmd.Parameters.Add(new SqlParameter("@EventID", 5));
            cmd.Parameters.Add(new SqlParameter("@StaffID", txtEmpNum.Text));
            cn.Open();
            cmd.ExecuteNonQuery();
  }


  private void tmrLabel_Tick(object sender, EventArgs e)
  {
   if (lblRemarks.Text == "IN")
   {
    if (lblRemarks.ForeColor == Color.LimeGreen)
     lblRemarks.ForeColor = Color.LawnGreen;
    else if (lblRemarks.ForeColor == Color.LawnGreen)
     lblRemarks.ForeColor = Color.LimeGreen;
   }
   else if (lblRemarks.Text == "OUT")
   {
    if (lblRemarks.ForeColor == Color.RoyalBlue)
     lblRemarks.ForeColor = Color.LightBlue;
    else if (lblRemarks.ForeColor == Color.LightBlue)
     lblRemarks.ForeColor = Color.RoyalBlue;
   }
   else if (lblRemarks.Text == "X")
   {
    if (lblRemarks.ForeColor == Color.Red)
     lblRemarks.ForeColor = Color.LightCoral;
    else if (lblRemarks.ForeColor == Color.LightCoral)
     lblRemarks.ForeColor = Color.Red;
   }
  }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Closing Application", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                this.Close();
            }
            
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}