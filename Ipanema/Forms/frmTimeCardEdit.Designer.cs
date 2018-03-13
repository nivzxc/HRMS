namespace Ipanema.Forms
{
 partial class frmTimeCardEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeCardEdit));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtRemarks = new System.Windows.Forms.TextBox();
   this.label9 = new System.Windows.Forms.Label();
   this.txtUpdateOn = new System.Windows.Forms.TextBox();
   this.label8 = new System.Windows.Forms.Label();
   this.txtUpdateBy = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtUsername = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.dtpOutTime = new System.Windows.Forms.DateTimePicker();
   this.dtpOutDate = new System.Windows.Forms.DateTimePicker();
   this.dtpInTime = new System.Windows.Forms.DateTimePicker();
   this.label3 = new System.Windows.Forms.Label();
   this.dtpInDate = new System.Windows.Forms.DateTimePicker();
   this.dtpFocusDate = new System.Windows.Forms.DateTimePicker();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.label5 = new System.Windows.Forms.Label();
   this.label6 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(331, 337);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(73, 30);
   this.btnClose.TabIndex = 7;
   this.btnClose.Text = "Close ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(250, 337);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(73, 30);
   this.btnSave.TabIndex = 6;
   this.btnSave.Text = "Save  ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtRemarks);
   this.groupBox1.Controls.Add(this.label9);
   this.groupBox1.Controls.Add(this.txtUpdateOn);
   this.groupBox1.Controls.Add(this.label8);
   this.groupBox1.Controls.Add(this.txtUpdateBy);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.txtUsername);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.dtpOutTime);
   this.groupBox1.Controls.Add(this.dtpOutDate);
   this.groupBox1.Controls.Add(this.dtpInTime);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.dtpInDate);
   this.groupBox1.Controls.Add(this.dtpFocusDate);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(9, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(393, 278);
   this.groupBox1.TabIndex = 9;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Time Card Details";
   // 
   // txtRemarks
   // 
   this.txtRemarks.BackColor = System.Drawing.Color.White;
   this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtRemarks.Location = new System.Drawing.Point(108, 132);
   this.txtRemarks.Multiline = true;
   this.txtRemarks.Name = "txtRemarks";
   this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtRemarks.Size = new System.Drawing.Size(272, 82);
   this.txtRemarks.TabIndex = 5;
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Location = new System.Drawing.Point(11, 131);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(60, 15);
   this.label9.TabIndex = 17;
   this.label9.Text = "Remarks:";
   // 
   // txtUpdateOn
   // 
   this.txtUpdateOn.BackColor = System.Drawing.Color.Ivory;
   this.txtUpdateOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtUpdateOn.Location = new System.Drawing.Point(108, 247);
   this.txtUpdateOn.Name = "txtUpdateOn";
   this.txtUpdateOn.ReadOnly = true;
   this.txtUpdateOn.Size = new System.Drawing.Size(272, 21);
   this.txtUpdateOn.TabIndex = 16;
   this.txtUpdateOn.TabStop = false;
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Location = new System.Drawing.Point(11, 250);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(36, 15);
   this.label8.TabIndex = 15;
   this.label8.Text = "Date:";
   // 
   // txtUpdateBy
   // 
   this.txtUpdateBy.BackColor = System.Drawing.Color.Ivory;
   this.txtUpdateBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtUpdateBy.Location = new System.Drawing.Point(108, 221);
   this.txtUpdateBy.Name = "txtUpdateBy";
   this.txtUpdateBy.ReadOnly = true;
   this.txtUpdateBy.Size = new System.Drawing.Size(272, 21);
   this.txtUpdateBy.TabIndex = 14;
   this.txtUpdateBy.TabStop = false;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(11, 224);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(92, 15);
   this.label7.TabIndex = 13;
   this.label7.Text = "Last Update By:";
   // 
   // txtUsername
   // 
   this.txtUsername.BackColor = System.Drawing.Color.Ivory;
   this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtUsername.Location = new System.Drawing.Point(108, 24);
   this.txtUsername.Name = "txtUsername";
   this.txtUsername.ReadOnly = true;
   this.txtUsername.Size = new System.Drawing.Size(272, 21);
   this.txtUsername.TabIndex = 12;
   this.txtUsername.TabStop = false;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(11, 107);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(60, 15);
   this.label4.TabIndex = 11;
   this.label4.Text = "Time Out:";
   // 
   // dtpOutTime
   // 
   this.dtpOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpOutTime.Location = new System.Drawing.Point(246, 105);
   this.dtpOutTime.Name = "dtpOutTime";
   this.dtpOutTime.ShowUpDown = true;
   this.dtpOutTime.Size = new System.Drawing.Size(99, 21);
   this.dtpOutTime.TabIndex = 4;
   // 
   // dtpOutDate
   // 
   this.dtpOutDate.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpOutDate.Location = new System.Drawing.Point(108, 105);
   this.dtpOutDate.Name = "dtpOutDate";
   this.dtpOutDate.Size = new System.Drawing.Size(130, 21);
   this.dtpOutDate.TabIndex = 3;
   // 
   // dtpInTime
   // 
   this.dtpInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpInTime.Location = new System.Drawing.Point(246, 78);
   this.dtpInTime.Name = "dtpInTime";
   this.dtpInTime.ShowUpDown = true;
   this.dtpInTime.Size = new System.Drawing.Size(99, 21);
   this.dtpInTime.TabIndex = 2;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(11, 81);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(51, 15);
   this.label3.TabIndex = 5;
   this.label3.Text = "Time In:";
   // 
   // dtpInDate
   // 
   this.dtpInDate.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpInDate.Location = new System.Drawing.Point(108, 78);
   this.dtpInDate.Name = "dtpInDate";
   this.dtpInDate.Size = new System.Drawing.Size(130, 21);
   this.dtpInDate.TabIndex = 1;
   // 
   // dtpFocusDate
   // 
   this.dtpFocusDate.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpFocusDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFocusDate.Location = new System.Drawing.Point(108, 51);
   this.dtpFocusDate.Name = "dtpFocusDate";
   this.dtpFocusDate.Size = new System.Drawing.Size(130, 21);
   this.dtpFocusDate.TabIndex = 0;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(11, 54);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(72, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Focus Date:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(11, 27);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(65, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Employee:";
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(10, 291);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(34, 34);
   this.pictureBox1.TabIndex = 0;
   this.pictureBox1.TabStop = false;
   // 
   // label5
   // 
   this.label5.Location = new System.Drawing.Point(46, 310);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(296, 27);
   this.label5.TabIndex = 13;
   this.label5.Text = "Modifying time card entry might cause discrepancy on your timesheet. ";
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label6.Location = new System.Drawing.Point(46, 291);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(64, 15);
   this.label6.TabIndex = 14;
   this.label6.Text = "Warning:";
   // 
   // frmTimeCardEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(414, 376);
   this.Controls.Add(this.label6);
   this.Controls.Add(this.label5);
   this.Controls.Add(this.pictureBox1);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmTimeCardEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit Time Card Details";
   this.Load += new System.EventHandler(this.frmTimeCardEdit_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.DateTimePicker dtpOutTime;
  private System.Windows.Forms.DateTimePicker dtpOutDate;
  private System.Windows.Forms.DateTimePicker dtpInTime;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.DateTimePicker dtpInDate;
  private System.Windows.Forms.DateTimePicker dtpFocusDate;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtUsername;
  private System.Windows.Forms.PictureBox pictureBox1;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtRemarks;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.TextBox txtUpdateOn;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.TextBox txtUpdateBy;
  private System.Windows.Forms.Label label7;

 }
}