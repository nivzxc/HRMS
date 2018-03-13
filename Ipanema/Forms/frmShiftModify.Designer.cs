namespace Ipanema.Forms
{
 partial class frmShiftModify
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShiftModify));
   this.btnSave = new System.Windows.Forms.Button();
   this.label9 = new System.Windows.Forms.Label();
   this.dtpBreakEnd = new System.Windows.Forms.DateTimePicker();
   this.label10 = new System.Windows.Forms.Label();
   this.dtpBreakStart = new System.Windows.Forms.DateTimePicker();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.cmbShiftMode = new System.Windows.Forms.ComboBox();
   this.label13 = new System.Windows.Forms.Label();
   this.dtpUndertime = new System.Windows.Forms.DateTimePicker();
   this.dtpLate = new System.Windows.Forms.DateTimePicker();
   this.label11 = new System.Windows.Forms.Label();
   this.label12 = new System.Windows.Forms.Label();
   this.txtTotalHours = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtShiftCode = new System.Windows.Forms.TextBox();
   this.label5 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.dtpTimeHalf = new System.Windows.Forms.DateTimePicker();
   this.label3 = new System.Windows.Forms.Label();
   this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
   this.label2 = new System.Windows.Forms.Label();
   this.dtpTimeStart = new System.Windows.Forms.DateTimePicker();
   this.txtRemarks = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.btnClose = new System.Windows.Forms.Button();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnSave
   // 
   this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(277, 319);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 14;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label9.Location = new System.Drawing.Point(220, 247);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(60, 13);
   this.label9.TabIndex = 12;
   this.label9.Text = "Break End:";
   // 
   // dtpBreakEnd
   // 
   this.dtpBreakEnd.CustomFormat = "MMMM";
   this.dtpBreakEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpBreakEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpBreakEnd.Location = new System.Drawing.Point(290, 242);
   this.dtpBreakEnd.Name = "dtpBreakEnd";
   this.dtpBreakEnd.ShowUpDown = true;
   this.dtpBreakEnd.Size = new System.Drawing.Size(111, 21);
   this.dtpBreakEnd.TabIndex = 8;
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label10.Location = new System.Drawing.Point(9, 247);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(63, 13);
   this.label10.TabIndex = 10;
   this.label10.Text = "Break Start:";
   // 
   // dtpBreakStart
   // 
   this.dtpBreakStart.CustomFormat = "MMMM";
   this.dtpBreakStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpBreakStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpBreakStart.Location = new System.Drawing.Point(92, 242);
   this.dtpBreakStart.Name = "dtpBreakStart";
   this.dtpBreakStart.ShowUpDown = true;
   this.dtpBreakStart.Size = new System.Drawing.Size(111, 21);
   this.dtpBreakStart.TabIndex = 7;
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.cmbShiftMode);
   this.groupBox1.Controls.Add(this.label13);
   this.groupBox1.Controls.Add(this.dtpUndertime);
   this.groupBox1.Controls.Add(this.dtpLate);
   this.groupBox1.Controls.Add(this.label11);
   this.groupBox1.Controls.Add(this.label12);
   this.groupBox1.Controls.Add(this.txtTotalHours);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.txtShiftCode);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.dtpTimeHalf);
   this.groupBox1.Controls.Add(this.label9);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.dtpBreakEnd);
   this.groupBox1.Controls.Add(this.label10);
   this.groupBox1.Controls.Add(this.dtpTimeEnd);
   this.groupBox1.Controls.Add(this.dtpBreakStart);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.dtpTimeStart);
   this.groupBox1.Controls.Add(this.txtRemarks);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox1.Location = new System.Drawing.Point(12, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(432, 304);
   this.groupBox1.TabIndex = 4;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Shift Details";
   // 
   // cmbShiftMode
   // 
   this.cmbShiftMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbShiftMode.FormattingEnabled = true;
   this.cmbShiftMode.Location = new System.Drawing.Point(92, 49);
   this.cmbShiftMode.Name = "cmbShiftMode";
   this.cmbShiftMode.Size = new System.Drawing.Size(177, 23);
   this.cmbShiftMode.TabIndex = 0;
   this.cmbShiftMode.SelectedIndexChanged += new System.EventHandler(this.cmbShiftMode_SelectedIndexChanged);
   // 
   // label13
   // 
   this.label13.AutoSize = true;
   this.label13.Location = new System.Drawing.Point(9, 55);
   this.label13.Name = "label13";
   this.label13.Size = new System.Drawing.Size(69, 15);
   this.label13.TabIndex = 26;
   this.label13.Text = "Shift Mode:";
   // 
   // dtpUndertime
   // 
   this.dtpUndertime.CustomFormat = "MMMM";
   this.dtpUndertime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpUndertime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpUndertime.Location = new System.Drawing.Point(290, 137);
   this.dtpUndertime.Name = "dtpUndertime";
   this.dtpUndertime.ShowUpDown = true;
   this.dtpUndertime.Size = new System.Drawing.Size(114, 21);
   this.dtpUndertime.TabIndex = 5;
   this.dtpUndertime.Value = new System.DateTime(1753, 1, 1, 18, 0, 0, 0);
   // 
   // dtpLate
   // 
   this.dtpLate.CustomFormat = "MMMM";
   this.dtpLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpLate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpLate.Location = new System.Drawing.Point(92, 137);
   this.dtpLate.Name = "dtpLate";
   this.dtpLate.ShowUpDown = true;
   this.dtpLate.Size = new System.Drawing.Size(111, 21);
   this.dtpLate.TabIndex = 4;
   this.dtpLate.Value = new System.DateTime(1753, 1, 1, 9, 0, 0, 0);
   // 
   // label11
   // 
   this.label11.AutoSize = true;
   this.label11.Location = new System.Drawing.Point(220, 140);
   this.label11.Name = "label11";
   this.label11.Size = new System.Drawing.Size(68, 15);
   this.label11.TabIndex = 24;
   this.label11.Text = "Undertime:";
   // 
   // label12
   // 
   this.label12.AutoSize = true;
   this.label12.Location = new System.Drawing.Point(9, 140);
   this.label12.Name = "label12";
   this.label12.Size = new System.Drawing.Size(34, 15);
   this.label12.TabIndex = 23;
   this.label12.Text = "Late:";
   // 
   // txtTotalHours
   // 
   this.txtTotalHours.BackColor = System.Drawing.Color.AliceBlue;
   this.txtTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtTotalHours.Location = new System.Drawing.Point(92, 272);
   this.txtTotalHours.MaxLength = 8;
   this.txtTotalHours.Name = "txtTotalHours";
   this.txtTotalHours.Size = new System.Drawing.Size(101, 20);
   this.txtTotalHours.TabIndex = 12;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(9, 274);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(59, 15);
   this.label7.TabIndex = 18;
   this.label7.Text = "Total Hrs:";
   // 
   // txtShiftCode
   // 
   this.txtShiftCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtShiftCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtShiftCode.Location = new System.Drawing.Point(92, 21);
   this.txtShiftCode.Name = "txtShiftCode";
   this.txtShiftCode.ReadOnly = true;
   this.txtShiftCode.Size = new System.Drawing.Size(108, 20);
   this.txtShiftCode.TabIndex = 0;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label5.Location = new System.Drawing.Point(9, 27);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(59, 13);
   this.label5.TabIndex = 9;
   this.label5.Text = "Shift Code:";
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(220, 85);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(55, 13);
   this.label4.TabIndex = 8;
   this.label4.Text = "Time Half:";
   // 
   // dtpTimeHalf
   // 
   this.dtpTimeHalf.CustomFormat = "MMMM";
   this.dtpTimeHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpTimeHalf.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpTimeHalf.Location = new System.Drawing.Point(290, 80);
   this.dtpTimeHalf.Name = "dtpTimeHalf";
   this.dtpTimeHalf.ShowUpDown = true;
   this.dtpTimeHalf.Size = new System.Drawing.Size(114, 21);
   this.dtpTimeHalf.TabIndex = 2;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(9, 114);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(55, 13);
   this.label3.TabIndex = 6;
   this.label3.Text = "Time End:";
   // 
   // dtpTimeEnd
   // 
   this.dtpTimeEnd.CustomFormat = "MMMM";
   this.dtpTimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpTimeEnd.Location = new System.Drawing.Point(92, 109);
   this.dtpTimeEnd.Name = "dtpTimeEnd";
   this.dtpTimeEnd.ShowUpDown = true;
   this.dtpTimeEnd.Size = new System.Drawing.Size(111, 21);
   this.dtpTimeEnd.TabIndex = 3;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(9, 85);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(58, 13);
   this.label2.TabIndex = 4;
   this.label2.Text = "Time Start:";
   // 
   // dtpTimeStart
   // 
   this.dtpTimeStart.CustomFormat = "MMMM";
   this.dtpTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpTimeStart.Location = new System.Drawing.Point(92, 80);
   this.dtpTimeStart.Name = "dtpTimeStart";
   this.dtpTimeStart.ShowUpDown = true;
   this.dtpTimeStart.Size = new System.Drawing.Size(111, 21);
   this.dtpTimeStart.TabIndex = 1;
   // 
   // txtRemarks
   // 
   this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtRemarks.Location = new System.Drawing.Point(92, 167);
   this.txtRemarks.Multiline = true;
   this.txtRemarks.Name = "txtRemarks";
   this.txtRemarks.Size = new System.Drawing.Size(324, 66);
   this.txtRemarks.TabIndex = 6;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(9, 167);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(52, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "Remarks:";
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(366, 319);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 15;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // frmShiftModify
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(456, 366);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmShiftModify";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Shift Details";
   this.Load += new System.EventHandler(this.frmShiftModify_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.DateTimePicker dtpBreakEnd;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.DateTimePicker dtpBreakStart;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.DateTimePicker dtpTimeHalf;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.DateTimePicker dtpTimeEnd;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.DateTimePicker dtpTimeStart;
  private System.Windows.Forms.TextBox txtRemarks;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtShiftCode;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtTotalHours;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.DateTimePicker dtpLate;
  private System.Windows.Forms.Label label11;
  private System.Windows.Forms.DateTimePicker dtpUndertime;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.ComboBox cmbShiftMode;
  private System.Windows.Forms.Label label13;
  private System.Windows.Forms.Button btnClose;
 }
}