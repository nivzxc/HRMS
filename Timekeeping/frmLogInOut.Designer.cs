namespace Ipanema
{
 partial class frmLogInOut
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
            this.components = new System.ComponentModel.Container();
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrIn = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picTime = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picEmp = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tmrLabel = new System.Windows.Forms.Timer(this.components);
            this.pnlRemarks = new System.Windows.Forms.Panel();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lvwHistory = new System.Windows.Forms.ListView();
            this.chDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).BeginInit();
            this.pnlRemarks.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmpNum
            // 
            this.txtEmpNum.BackColor = System.Drawing.Color.AliceBlue;
            this.txtEmpNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNum.ForeColor = System.Drawing.Color.Black;
            this.txtEmpNum.Location = new System.Drawing.Point(211, 77);
            this.txtEmpNum.MaxLength = 5;
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.Size = new System.Drawing.Size(318, 62);
            this.txtEmpNum.TabIndex = 0;
            this.txtEmpNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpNum_KeyDown);
            // 
            // txtEmpName
            // 
            this.txtEmpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(214)))), ((int)(((byte)(251)))));
            this.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.ForeColor = System.Drawing.Color.Black;
            this.txtEmpName.Location = new System.Drawing.Point(211, 160);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(318, 29);
            this.txtEmpName.TabIndex = 4;
            this.txtEmpName.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTime.Location = new System.Drawing.Point(206, 196);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 25);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // tmrIn
            // 
            this.tmrIn.Interval = 1000;
            this.tmrIn.Tick += new System.EventHandler(this.tmrIn_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please key in your employee number here:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.picTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 226);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ipanema.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::Ipanema.Properties.Resources.PFIClogo;
            this.pictureBox1.Location = new System.Drawing.Point(372, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picTime
            // 
            this.picTime.BackColor = System.Drawing.Color.Transparent;
            this.picTime.Image = global::Ipanema.Properties.Resources.ktimer128;
            this.picTime.Location = new System.Drawing.Point(211, 41);
            this.picTime.Name = "picTime";
            this.picTime.Size = new System.Drawing.Size(116, 128);
            this.picTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTime.TabIndex = 6;
            this.picTime.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDate.Location = new System.Drawing.Point(207, 172);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 24);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "DATE";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtEmpName);
            this.panel2.Controls.Add(this.picEmp);
            this.panel2.Controls.Add(this.txtEmpNum);
            this.panel2.Location = new System.Drawing.Point(0, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 520);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox3.Location = new System.Drawing.Point(552, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(3, 556);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // picEmp
            // 
            this.picEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmp.ErrorImage = global::Ipanema.Properties.Resources.icon_user;
            this.picEmp.Image = global::Ipanema.Properties.Resources.icon_user;
            this.picEmp.Location = new System.Drawing.Point(211, 199);
            this.picEmp.Name = "picEmp";
            this.picEmp.Size = new System.Drawing.Size(318, 296);
            this.picEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmp.TabIndex = 1;
            this.picEmp.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(627, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrLabel
            // 
            this.tmrLabel.Interval = 500;
            this.tmrLabel.Tick += new System.EventHandler(this.tmrLabel_Tick);
            // 
            // pnlRemarks
            // 
            this.pnlRemarks.BackColor = System.Drawing.Color.Transparent;
            this.pnlRemarks.Controls.Add(this.lblRemarks);
            this.pnlRemarks.Location = new System.Drawing.Point(16, 113);
            this.pnlRemarks.Name = "pnlRemarks";
            this.pnlRemarks.Size = new System.Drawing.Size(605, 119);
            this.pnlRemarks.TabIndex = 16;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRemarks.Location = new System.Drawing.Point(123, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(346, 112);
            this.lblRemarks.TabIndex = 3;
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwHistory
            // 
            this.lvwHistory.BackColor = System.Drawing.Color.AliceBlue;
            this.lvwHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDay,
            this.chIn,
            this.chOut});
            this.lvwHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwHistory.FullRowSelect = true;
            this.lvwHistory.GridLines = true;
            this.lvwHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwHistory.Location = new System.Drawing.Point(16, 258);
            this.lvwHistory.Name = "lvwHistory";
            this.lvwHistory.Size = new System.Drawing.Size(605, 237);
            this.lvwHistory.TabIndex = 2;
            this.lvwHistory.UseCompatibleStateImageBehavior = false;
            this.lvwHistory.View = System.Windows.Forms.View.Details;
            // 
            // chDay
            // 
            this.chDay.Text = "Day";
            this.chDay.Width = 187;
            // 
            // chIn
            // 
            this.chIn.Text = "In";
            this.chIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chIn.Width = 190;
            // 
            // chOut
            // 
            this.chOut.Text = "Out";
            this.chOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOut.Width = 190;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Time In-Out History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pnlRemarks);
            this.panel3.Controls.Add(this.lvwHistory);
            this.panel3.Location = new System.Drawing.Point(553, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 520);
            this.panel3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(209, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 54);
            this.label4.TabIndex = 11;
            this.label4.Text = "ACTION ";
            // 
            // frmLogInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogInOut";
            this.ShowInTaskbar = false;
            this.Text = "PFIC TIME-IN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogInOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).EndInit();
            this.pnlRemarks.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.TextBox txtEmpNum;
  private System.Windows.Forms.PictureBox picEmp;
  private System.Windows.Forms.TextBox txtEmpName;
  private System.Windows.Forms.Label lblTime;
  private System.Windows.Forms.Timer tmrIn;
  private System.Windows.Forms.PictureBox picTime;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Panel panel1;
  private System.Windows.Forms.Panel panel2;
  private System.Windows.Forms.PictureBox pictureBox3;
  private System.Windows.Forms.Timer tmrLabel;
  private System.Windows.Forms.Panel pnlRemarks;
  private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvwHistory;
        private System.Windows.Forms.ColumnHeader chDay;
        private System.Windows.Forms.ColumnHeader chIn;
        private System.Windows.Forms.ColumnHeader chOut;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}