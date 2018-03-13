namespace Ipanema.Forms
{
 partial class frmTimeCardAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeCardAdd));
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtRemarks = new System.Windows.Forms.TextBox();
   this.label9 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.dtpOutTime = new System.Windows.Forms.DateTimePicker();
   this.dtpOutDate = new System.Windows.Forms.DateTimePicker();
   this.dtpInTime = new System.Windows.Forms.DateTimePicker();
   this.label3 = new System.Windows.Forms.Label();
   this.dtpInDate = new System.Windows.Forms.DateTimePicker();
   this.dtpFocusDate = new System.Windows.Forms.DateTimePicker();
   this.label2 = new System.Windows.Forms.Label();
   this.cmbUsername = new System.Windows.Forms.ComboBox();
   this.label1 = new System.Windows.Forms.Label();
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtRemarks);
   this.groupBox1.Controls.Add(this.label9);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.dtpOutTime);
   this.groupBox1.Controls.Add(this.dtpOutDate);
   this.groupBox1.Controls.Add(this.dtpInTime);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.dtpInDate);
   this.groupBox1.Controls.Add(this.dtpFocusDate);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.cmbUsername);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(10, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(338, 228);
   this.groupBox1.TabIndex = 0;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Time Card Details";
   // 
   // txtRemarks
   // 
   this.txtRemarks.BackColor = System.Drawing.Color.White;
   this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtRemarks.Location = new System.Drawing.Point(88, 135);
   this.txtRemarks.Multiline = true;
   this.txtRemarks.Name = "txtRemarks";
   this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtRemarks.Size = new System.Drawing.Size(240, 82);
   this.txtRemarks.TabIndex = 6;
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Location = new System.Drawing.Point(10, 135);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(60, 15);
   this.label9.TabIndex = 19;
   this.label9.Text = "Remarks:";
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(10, 109);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(60, 15);
   this.label4.TabIndex = 11;
   this.label4.Text = "Time Out:";
   // 
   // dtpOutTime
   // 
   this.dtpOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpOutTime.Location = new System.Drawing.Point(228, 107);
   this.dtpOutTime.Name = "dtpOutTime";
   this.dtpOutTime.ShowUpDown = true;
   this.dtpOutTime.Size = new System.Drawing.Size(99, 21);
   this.dtpOutTime.TabIndex = 5;
   // 
   // dtpOutDate
   // 
   this.dtpOutDate.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpOutDate.Location = new System.Drawing.Point(88, 107);
   this.dtpOutDate.Name = "dtpOutDate";
   this.dtpOutDate.Size = new System.Drawing.Size(132, 21);
   this.dtpOutDate.TabIndex = 4;
   // 
   // dtpInTime
   // 
   this.dtpInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpInTime.Location = new System.Drawing.Point(228, 80);
   this.dtpInTime.Name = "dtpInTime";
   this.dtpInTime.ShowUpDown = true;
   this.dtpInTime.Size = new System.Drawing.Size(99, 21);
   this.dtpInTime.TabIndex = 3;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(10, 83);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(51, 15);
   this.label3.TabIndex = 5;
   this.label3.Text = "Time In:";
   // 
   // dtpInDate
   // 
   this.dtpInDate.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpInDate.Location = new System.Drawing.Point(88, 80);
   this.dtpInDate.Name = "dtpInDate";
   this.dtpInDate.Size = new System.Drawing.Size(132, 21);
   this.dtpInDate.TabIndex = 2;
   // 
   // dtpFocusDate
   // 
   this.dtpFocusDate.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpFocusDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFocusDate.Location = new System.Drawing.Point(88, 53);
   this.dtpFocusDate.Name = "dtpFocusDate";
   this.dtpFocusDate.Size = new System.Drawing.Size(132, 21);
   this.dtpFocusDate.TabIndex = 1;
   this.dtpFocusDate.ValueChanged += new System.EventHandler(this.dtpFocusDate_ValueChanged);
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(10, 56);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(72, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Focus Date:";
   // 
   // cmbUsername
   // 
   this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbUsername.FormattingEnabled = true;
   this.cmbUsername.Location = new System.Drawing.Point(88, 24);
   this.cmbUsername.Name = "cmbUsername";
   this.cmbUsername.Size = new System.Drawing.Size(240, 23);
   this.cmbUsername.TabIndex = 0;
   this.cmbUsername.SelectedIndexChanged += new System.EventHandler(this.cmbUsername_SelectedIndexChanged);
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(10, 28);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(65, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Employee:";
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(277, 243);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(73, 30);
   this.btnClose.TabIndex = 8;
   this.btnClose.Text = "Close ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(196, 243);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(73, 30);
   this.btnSave.TabIndex = 7;
   this.btnSave.Text = "Save  ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // frmTimeCardAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(358, 281);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmTimeCardAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add Time Card";
   this.Load += new System.EventHandler(this.frmTimeCardAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.DateTimePicker dtpOutTime;
  private System.Windows.Forms.DateTimePicker dtpOutDate;
  private System.Windows.Forms.DateTimePicker dtpInTime;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.DateTimePicker dtpInDate;
  private System.Windows.Forms.DateTimePicker dtpFocusDate;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.ComboBox cmbUsername;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtRemarks;
  private System.Windows.Forms.Label label9;
 }
}