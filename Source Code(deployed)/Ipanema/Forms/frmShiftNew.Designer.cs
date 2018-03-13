namespace Ipanema.Forms
{
 partial class frmShiftNew
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShiftNew));
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.cmbShiftMode = new System.Windows.Forms.ComboBox();
   this.label13 = new System.Windows.Forms.Label();
   this.dtpLate = new System.Windows.Forms.DateTimePicker();
   this.label11 = new System.Windows.Forms.Label();
   this.dtpUndertime = new System.Windows.Forms.DateTimePicker();
   this.label12 = new System.Windows.Forms.Label();
   this.txtTotalHours = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.dtpTimeStart = new System.Windows.Forms.DateTimePicker();
   this.btnCheck = new System.Windows.Forms.Button();
   this.btnGenerateCode = new System.Windows.Forms.Button();
   this.txtShiftCode = new System.Windows.Forms.TextBox();
   this.label9 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.dtpBreakEnd = new System.Windows.Forms.DateTimePicker();
   this.label10 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.dtpBreakStart = new System.Windows.Forms.DateTimePicker();
   this.dtpTimeHalf = new System.Windows.Forms.DateTimePicker();
   this.label3 = new System.Windows.Forms.Label();
   this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
   this.label2 = new System.Windows.Forms.Label();
   this.txtRemarks = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.btnSave = new System.Windows.Forms.Button();
   this.btnClose = new System.Windows.Forms.Button();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.cmbShiftMode);
   this.groupBox1.Controls.Add(this.label13);
   this.groupBox1.Controls.Add(this.dtpLate);
   this.groupBox1.Controls.Add(this.label11);
   this.groupBox1.Controls.Add(this.dtpUndertime);
   this.groupBox1.Controls.Add(this.label12);
   this.groupBox1.Controls.Add(this.txtTotalHours);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.dtpTimeStart);
   this.groupBox1.Controls.Add(this.btnCheck);
   this.groupBox1.Controls.Add(this.btnGenerateCode);
   this.groupBox1.Controls.Add(this.txtShiftCode);
   this.groupBox1.Controls.Add(this.label9);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.dtpBreakEnd);
   this.groupBox1.Controls.Add(this.label10);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.dtpBreakStart);
   this.groupBox1.Controls.Add(this.dtpTimeHalf);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.dtpTimeEnd);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.txtRemarks);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(11, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(400, 292);
   this.groupBox1.TabIndex = 0;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Shift Details";
   // 
   // cmbShiftMode
   // 
   this.cmbShiftMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbShiftMode.FormattingEnabled = true;
   this.cmbShiftMode.Location = new System.Drawing.Point(86, 48);
   this.cmbShiftMode.Name = "cmbShiftMode";
   this.cmbShiftMode.Size = new System.Drawing.Size(177, 23);
   this.cmbShiftMode.TabIndex = 3;
   this.cmbShiftMode.SelectedIndexChanged += new System.EventHandler(this.cmbShiftMode_SelectedIndexChanged);
   // 
   // label13
   // 
   this.label13.AutoSize = true;
   this.label13.Location = new System.Drawing.Point(10, 53);
   this.label13.Name = "label13";
   this.label13.Size = new System.Drawing.Size(69, 15);
   this.label13.TabIndex = 21;
   this.label13.Text = "Shift Mode:";
   // 
   // dtpLate
   // 
   this.dtpLate.CustomFormat = "MMMM";
   this.dtpLate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpLate.Location = new System.Drawing.Point(86, 134);
   this.dtpLate.Name = "dtpLate";
   this.dtpLate.ShowUpDown = true;
   this.dtpLate.Size = new System.Drawing.Size(107, 21);
   this.dtpLate.TabIndex = 7;
   this.dtpLate.Value = new System.DateTime(1753, 1, 1, 9, 0, 0, 0);
   // 
   // label11
   // 
   this.label11.AutoSize = true;
   this.label11.Location = new System.Drawing.Point(206, 137);
   this.label11.Name = "label11";
   this.label11.Size = new System.Drawing.Size(68, 15);
   this.label11.TabIndex = 20;
   this.label11.Text = "Undertime:";
   // 
   // dtpUndertime
   // 
   this.dtpUndertime.CustomFormat = "MMMM";
   this.dtpUndertime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpUndertime.Location = new System.Drawing.Point(278, 134);
   this.dtpUndertime.Name = "dtpUndertime";
   this.dtpUndertime.ShowUpDown = true;
   this.dtpUndertime.Size = new System.Drawing.Size(107, 21);
   this.dtpUndertime.TabIndex = 8;
   this.dtpUndertime.Value = new System.DateTime(1753, 1, 1, 18, 0, 0, 0);
   // 
   // label12
   // 
   this.label12.AutoSize = true;
   this.label12.Location = new System.Drawing.Point(10, 137);
   this.label12.Name = "label12";
   this.label12.Size = new System.Drawing.Size(34, 15);
   this.label12.TabIndex = 19;
   this.label12.Text = "Late:";
   // 
   // txtTotalHours
   // 
   this.txtTotalHours.BackColor = System.Drawing.Color.AliceBlue;
   this.txtTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtTotalHours.Location = new System.Drawing.Point(86, 264);
   this.txtTotalHours.MaxLength = 8;
   this.txtTotalHours.Name = "txtTotalHours";
   this.txtTotalHours.Size = new System.Drawing.Size(101, 20);
   this.txtTotalHours.TabIndex = 13;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(10, 266);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(59, 15);
   this.label7.TabIndex = 15;
   this.label7.Text = "Total Hrs:";
   // 
   // dtpTimeStart
   // 
   this.dtpTimeStart.CustomFormat = "MMMM";
   this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpTimeStart.Location = new System.Drawing.Point(86, 78);
   this.dtpTimeStart.Name = "dtpTimeStart";
   this.dtpTimeStart.ShowUpDown = true;
   this.dtpTimeStart.Size = new System.Drawing.Size(107, 21);
   this.dtpTimeStart.TabIndex = 4;
   this.dtpTimeStart.Value = new System.DateTime(1753, 1, 1, 9, 0, 0, 0);
   // 
   // btnCheck
   // 
   this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
   this.btnCheck.Location = new System.Drawing.Point(224, 17);
   this.btnCheck.Name = "btnCheck";
   this.btnCheck.Size = new System.Drawing.Size(28, 28);
   this.btnCheck.TabIndex = 2;
   this.btnCheck.UseVisualStyleBackColor = true;
   this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
   // 
   // btnGenerateCode
   // 
   this.btnGenerateCode.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateCode.Image")));
   this.btnGenerateCode.Location = new System.Drawing.Point(192, 17);
   this.btnGenerateCode.Name = "btnGenerateCode";
   this.btnGenerateCode.Size = new System.Drawing.Size(28, 28);
   this.btnGenerateCode.TabIndex = 1;
   this.btnGenerateCode.UseVisualStyleBackColor = true;
   this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
   // 
   // txtShiftCode
   // 
   this.txtShiftCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtShiftCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtShiftCode.Location = new System.Drawing.Point(86, 20);
   this.txtShiftCode.MaxLength = 8;
   this.txtShiftCode.Name = "txtShiftCode";
   this.txtShiftCode.Size = new System.Drawing.Size(101, 20);
   this.txtShiftCode.TabIndex = 0;
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Location = new System.Drawing.Point(206, 238);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(67, 15);
   this.label9.TabIndex = 12;
   this.label9.Text = "Break End:";
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(10, 25);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(39, 15);
   this.label5.TabIndex = 9;
   this.label5.Text = "Code:";
   // 
   // dtpBreakEnd
   // 
   this.dtpBreakEnd.CustomFormat = "MMMM";
   this.dtpBreakEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpBreakEnd.Location = new System.Drawing.Point(278, 235);
   this.dtpBreakEnd.Name = "dtpBreakEnd";
   this.dtpBreakEnd.ShowUpDown = true;
   this.dtpBreakEnd.Size = new System.Drawing.Size(107, 21);
   this.dtpBreakEnd.TabIndex = 11;
   this.dtpBreakEnd.Value = new System.DateTime(1753, 1, 1, 16, 15, 0, 0);
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Location = new System.Drawing.Point(10, 238);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(70, 15);
   this.label10.TabIndex = 10;
   this.label10.Text = "Break Start:";
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(206, 82);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(63, 15);
   this.label4.TabIndex = 8;
   this.label4.Text = "Time Half:";
   // 
   // dtpBreakStart
   // 
   this.dtpBreakStart.CustomFormat = "MMMM";
   this.dtpBreakStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpBreakStart.Location = new System.Drawing.Point(86, 235);
   this.dtpBreakStart.Name = "dtpBreakStart";
   this.dtpBreakStart.ShowUpDown = true;
   this.dtpBreakStart.Size = new System.Drawing.Size(107, 21);
   this.dtpBreakStart.TabIndex = 10;
   this.dtpBreakStart.Value = new System.DateTime(1753, 1, 1, 16, 0, 0, 0);
   // 
   // dtpTimeHalf
   // 
   this.dtpTimeHalf.CustomFormat = "MMMM";
   this.dtpTimeHalf.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpTimeHalf.Location = new System.Drawing.Point(278, 78);
   this.dtpTimeHalf.Name = "dtpTimeHalf";
   this.dtpTimeHalf.ShowUpDown = true;
   this.dtpTimeHalf.Size = new System.Drawing.Size(107, 21);
   this.dtpTimeHalf.TabIndex = 5;
   this.dtpTimeHalf.Value = new System.DateTime(1753, 1, 1, 12, 0, 0, 0);
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(10, 111);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(63, 15);
   this.label3.TabIndex = 6;
   this.label3.Text = "Time End:";
   // 
   // dtpTimeEnd
   // 
   this.dtpTimeEnd.CustomFormat = "MMMM";
   this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpTimeEnd.Location = new System.Drawing.Point(86, 106);
   this.dtpTimeEnd.Name = "dtpTimeEnd";
   this.dtpTimeEnd.ShowUpDown = true;
   this.dtpTimeEnd.Size = new System.Drawing.Size(107, 21);
   this.dtpTimeEnd.TabIndex = 6;
   this.dtpTimeEnd.Value = new System.DateTime(1753, 1, 1, 18, 0, 0, 0);
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(10, 82);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(66, 15);
   this.label2.TabIndex = 4;
   this.label2.Text = "Time Start:";
   // 
   // txtRemarks
   // 
   this.txtRemarks.Location = new System.Drawing.Point(86, 162);
   this.txtRemarks.Multiline = true;
   this.txtRemarks.Name = "txtRemarks";
   this.txtRemarks.Size = new System.Drawing.Size(300, 66);
   this.txtRemarks.TabIndex = 9;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(10, 162);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(60, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Remarks:";
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(244, 306);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 16;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(332, 306);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 17;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // frmShiftNew
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(423, 352);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmShiftNew";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Add New Shift";
   this.Load += new System.EventHandler(this.frmShiftNew_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtRemarks;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.DateTimePicker dtpTimeStart;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.DateTimePicker dtpTimeHalf;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.DateTimePicker dtpTimeEnd;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.DateTimePicker dtpBreakEnd;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.DateTimePicker dtpBreakStart;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.TextBox txtShiftCode;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.Button btnGenerateCode;
  private System.Windows.Forms.Button btnCheck;
  private System.Windows.Forms.TextBox txtTotalHours;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.DateTimePicker dtpLate;
  private System.Windows.Forms.Label label11;
  private System.Windows.Forms.DateTimePicker dtpUndertime;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.ComboBox cmbShiftMode;
  private System.Windows.Forms.Label label13;
 }
}