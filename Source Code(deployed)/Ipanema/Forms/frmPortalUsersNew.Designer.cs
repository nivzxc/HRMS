namespace Ipanema.Forms
{
 partial class frmPortalUsersNew
 {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing)
  {
   if (disposing && (components != null))
   {
    components.Dispose();
   }
   base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPortalUsersNew));
      this.btnSave = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.cmbStatus = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      this.cmbSex = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtTitle = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.txtNickName = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.txtMiddleName = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.txtFirstname = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtLastname = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label16 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
      this.cmbUsername = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
      this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSave.Location = new System.Drawing.Point(221, 360);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 32);
      this.btnSave.TabIndex = 12;
      this.btnSave.Text = "Save  ";
      this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
      this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnClose.Location = new System.Drawing.Point(303, 360);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 32);
      this.btnClose.TabIndex = 13;
      this.btnClose.Text = "Close ";
      this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.cmbStatus);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.cmbSex);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.txtTitle);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.txtEmail);
      this.groupBox2.Controls.Add(this.label12);
      this.groupBox2.Controls.Add(this.txtNickName);
      this.groupBox2.Controls.Add(this.label11);
      this.groupBox2.Controls.Add(this.txtMiddleName);
      this.groupBox2.Controls.Add(this.label10);
      this.groupBox2.Controls.Add(this.txtFirstname);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.txtLastname);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.txtPassword);
      this.groupBox2.Controls.Add(this.label16);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.dtpBirthDate);
      this.groupBox2.Controls.Add(this.cmbUsername);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(11, 6);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(365, 344);
      this.groupBox2.TabIndex = 27;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Portal User Details";
      // 
      // cmbStatus
      // 
      this.cmbStatus.BackColor = System.Drawing.Color.White;
      this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbStatus.FormattingEnabled = true;
      this.cmbStatus.Location = new System.Drawing.Point(121, 311);
      this.cmbStatus.MaxLength = 30;
      this.cmbStatus.Name = "cmbStatus";
      this.cmbStatus.Size = new System.Drawing.Size(127, 23);
      this.cmbStatus.TabIndex = 11;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(10, 314);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(44, 15);
      this.label7.TabIndex = 96;
      this.label7.Text = "Status:";
      // 
      // cmbSex
      // 
      this.cmbSex.BackColor = System.Drawing.Color.White;
      this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSex.FormattingEnabled = true;
      this.cmbSex.Location = new System.Drawing.Point(121, 281);
      this.cmbSex.MaxLength = 30;
      this.cmbSex.Name = "cmbSex";
      this.cmbSex.Size = new System.Drawing.Size(71, 23);
      this.cmbSex.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(10, 285);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(31, 15);
      this.label5.TabIndex = 94;
      this.label5.Text = "Sex:";
      // 
      // txtTitle
      // 
      this.txtTitle.BackColor = System.Drawing.Color.White;
      this.txtTitle.Location = new System.Drawing.Point(121, 253);
      this.txtTitle.MaxLength = 150;
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtTitle.Size = new System.Drawing.Size(230, 21);
      this.txtTitle.TabIndex = 9;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(10, 255);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(33, 15);
      this.label8.TabIndex = 92;
      this.label8.Text = "Title:";
      // 
      // txtEmail
      // 
      this.txtEmail.BackColor = System.Drawing.Color.White;
      this.txtEmail.Location = new System.Drawing.Point(121, 196);
      this.txtEmail.MaxLength = 50;
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtEmail.Size = new System.Drawing.Size(230, 21);
      this.txtEmail.TabIndex = 7;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(10, 198);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(42, 15);
      this.label12.TabIndex = 90;
      this.label12.Text = "Email:";
      // 
      // txtNickName
      // 
      this.txtNickName.BackColor = System.Drawing.Color.White;
      this.txtNickName.Location = new System.Drawing.Point(121, 168);
      this.txtNickName.MaxLength = 20;
      this.txtNickName.Name = "txtNickName";
      this.txtNickName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtNickName.Size = new System.Drawing.Size(230, 21);
      this.txtNickName.TabIndex = 6;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(10, 170);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(71, 15);
      this.label11.TabIndex = 88;
      this.label11.Text = "Nick Name:";
      // 
      // txtMiddleName
      // 
      this.txtMiddleName.BackColor = System.Drawing.Color.White;
      this.txtMiddleName.Location = new System.Drawing.Point(121, 140);
      this.txtMiddleName.MaxLength = 30;
      this.txtMiddleName.Name = "txtMiddleName";
      this.txtMiddleName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtMiddleName.Size = new System.Drawing.Size(230, 21);
      this.txtMiddleName.TabIndex = 5;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(10, 142);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(85, 15);
      this.label10.TabIndex = 86;
      this.label10.Text = "Middle Name:";
      // 
      // txtFirstname
      // 
      this.txtFirstname.BackColor = System.Drawing.Color.White;
      this.txtFirstname.Location = new System.Drawing.Point(121, 112);
      this.txtFirstname.MaxLength = 30;
      this.txtFirstname.Name = "txtFirstname";
      this.txtFirstname.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtFirstname.Size = new System.Drawing.Size(230, 21);
      this.txtFirstname.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(10, 114);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(70, 15);
      this.label3.TabIndex = 84;
      this.label3.Text = "First Name:";
      // 
      // txtLastname
      // 
      this.txtLastname.BackColor = System.Drawing.Color.White;
      this.txtLastname.Location = new System.Drawing.Point(121, 84);
      this.txtLastname.MaxLength = 30;
      this.txtLastname.Name = "txtLastname";
      this.txtLastname.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtLastname.Size = new System.Drawing.Size(230, 21);
      this.txtLastname.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(10, 84);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 15);
      this.label2.TabIndex = 82;
      this.label2.Text = "Last Name:";
      // 
      // txtPassword
      // 
      this.txtPassword.BackColor = System.Drawing.Color.White;
      this.txtPassword.Location = new System.Drawing.Point(121, 56);
      this.txtPassword.MaxLength = 15;
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtPassword.Size = new System.Drawing.Size(181, 21);
      this.txtPassword.TabIndex = 1;
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label16.Location = new System.Drawing.Point(10, 58);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(64, 15);
      this.label16.TabIndex = 78;
      this.label16.Text = "Password:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(10, 228);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(64, 15);
      this.label4.TabIndex = 75;
      this.label4.Text = "Birth Date:";
      // 
      // dtpBirthDate
      // 
      this.dtpBirthDate.CalendarTitleBackColor = System.Drawing.Color.Honeydew;
      this.dtpBirthDate.CustomFormat = "MMM dd, yyyy";
      this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpBirthDate.Location = new System.Drawing.Point(121, 225);
      this.dtpBirthDate.Name = "dtpBirthDate";
      this.dtpBirthDate.Size = new System.Drawing.Size(103, 21);
      this.dtpBirthDate.TabIndex = 8;
      // 
      // cmbUsername
      // 
      this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbUsername.FormattingEnabled = true;
      this.cmbUsername.Location = new System.Drawing.Point(121, 26);
      this.cmbUsername.MaxLength = 30;
      this.cmbUsername.Name = "cmbUsername";
      this.cmbUsername.Size = new System.Drawing.Size(230, 23);
      this.cmbUsername.TabIndex = 0;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(10, 29);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(68, 15);
      this.label6.TabIndex = 10;
      this.label6.Text = "Username:";
      // 
      // frmPortalUsersNew
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.AliceBlue;
      this.CancelButton = this.btnClose;
      this.ClientSize = new System.Drawing.Size(389, 400);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.groupBox2);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmPortalUsersNew";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Add New Portal User";
      this.Load += new System.EventHandler(this.frmPortalUsersNew_Load);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.GroupBox groupBox2;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.DateTimePicker dtpBirthDate;
  private System.Windows.Forms.ComboBox cmbUsername;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtPassword;
  private System.Windows.Forms.Label label16;
  private System.Windows.Forms.TextBox txtMiddleName;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.TextBox txtFirstname;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtLastname;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.ComboBox cmbStatus;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.ComboBox cmbSex;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtTitle;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.TextBox txtEmail;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.TextBox txtNickName;
  private System.Windows.Forms.Label label11;

 }
}