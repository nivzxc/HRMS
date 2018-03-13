namespace Ipanema.Forms
{
 partial class frmTimeSheetPeriodEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeSheetPeriodEdit));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtModifyOn = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.txtModifyBy = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtCreateOn = new System.Windows.Forms.TextBox();
   this.label5 = new System.Windows.Forms.Label();
   this.txtCreateBy = new System.Windows.Forms.TextBox();
   this.label8 = new System.Windows.Forms.Label();
   this.radPayroll = new System.Windows.Forms.RadioButton();
   this.radMonthly = new System.Windows.Forms.RadioButton();
   this.chkStatus = new System.Windows.Forms.CheckBox();
   this.txtDescription = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.txtPeriodCode = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.dtpTo = new System.Windows.Forms.DateTimePicker();
   this.dtpFrom = new System.Windows.Forms.DateTimePicker();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.chkPostData = new System.Windows.Forms.CheckBox();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(330, 325);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 4;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(242, 325);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 3;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.chkPostData);
   this.groupBox1.Controls.Add(this.txtModifyOn);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.txtModifyBy);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.txtCreateOn);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.txtCreateBy);
   this.groupBox1.Controls.Add(this.label8);
   this.groupBox1.Controls.Add(this.radPayroll);
   this.groupBox1.Controls.Add(this.radMonthly);
   this.groupBox1.Controls.Add(this.chkStatus);
   this.groupBox1.Controls.Add(this.txtDescription);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.txtPeriodCode);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.dtpTo);
   this.groupBox1.Controls.Add(this.dtpFrom);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(11, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(398, 309);
   this.groupBox1.TabIndex = 16;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Timesheet Period Details";
   // 
   // txtModifyOn
   // 
   this.txtModifyOn.BackColor = System.Drawing.Color.AliceBlue;
   this.txtModifyOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtModifyOn.Location = new System.Drawing.Point(101, 275);
   this.txtModifyOn.MaxLength = 8;
   this.txtModifyOn.Name = "txtModifyOn";
   this.txtModifyOn.ReadOnly = true;
   this.txtModifyOn.Size = new System.Drawing.Size(245, 21);
   this.txtModifyOn.TabIndex = 40;
   this.txtModifyOn.TabStop = false;
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(11, 277);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(87, 15);
   this.label6.TabIndex = 41;
   this.label6.Text = "Date Modified:";
   // 
   // txtModifyBy
   // 
   this.txtModifyBy.BackColor = System.Drawing.Color.AliceBlue;
   this.txtModifyBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtModifyBy.Location = new System.Drawing.Point(101, 245);
   this.txtModifyBy.MaxLength = 8;
   this.txtModifyBy.Name = "txtModifyBy";
   this.txtModifyBy.ReadOnly = true;
   this.txtModifyBy.Size = new System.Drawing.Size(220, 21);
   this.txtModifyBy.TabIndex = 38;
   this.txtModifyBy.TabStop = false;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(11, 248);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(74, 15);
   this.label7.TabIndex = 39;
   this.label7.Text = "Modified By:";
   // 
   // txtCreateOn
   // 
   this.txtCreateOn.BackColor = System.Drawing.Color.AliceBlue;
   this.txtCreateOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtCreateOn.Location = new System.Drawing.Point(101, 216);
   this.txtCreateOn.MaxLength = 8;
   this.txtCreateOn.Name = "txtCreateOn";
   this.txtCreateOn.ReadOnly = true;
   this.txtCreateOn.Size = new System.Drawing.Size(245, 21);
   this.txtCreateOn.TabIndex = 36;
   this.txtCreateOn.TabStop = false;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(11, 218);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(82, 15);
   this.label5.TabIndex = 37;
   this.label5.Text = "Date Created:";
   // 
   // txtCreateBy
   // 
   this.txtCreateBy.BackColor = System.Drawing.Color.AliceBlue;
   this.txtCreateBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtCreateBy.Location = new System.Drawing.Point(101, 187);
   this.txtCreateBy.MaxLength = 8;
   this.txtCreateBy.Name = "txtCreateBy";
   this.txtCreateBy.ReadOnly = true;
   this.txtCreateBy.Size = new System.Drawing.Size(220, 21);
   this.txtCreateBy.TabIndex = 34;
   this.txtCreateBy.TabStop = false;
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Location = new System.Drawing.Point(11, 190);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(69, 15);
   this.label8.TabIndex = 35;
   this.label8.Text = "Created By:";
   // 
   // radPayroll
   // 
   this.radPayroll.AutoSize = true;
   this.radPayroll.Location = new System.Drawing.Point(237, 161);
   this.radPayroll.Name = "radPayroll";
   this.radPayroll.Size = new System.Drawing.Size(101, 19);
   this.radPayroll.TabIndex = 6;
   this.radPayroll.Text = "Payroll Period";
   this.radPayroll.UseVisualStyleBackColor = true;
   // 
   // radMonthly
   // 
   this.radMonthly.AutoSize = true;
   this.radMonthly.Checked = true;
   this.radMonthly.Location = new System.Drawing.Point(102, 161);
   this.radMonthly.Name = "radMonthly";
   this.radMonthly.Size = new System.Drawing.Size(129, 19);
   this.radMonthly.TabIndex = 5;
   this.radMonthly.TabStop = true;
   this.radMonthly.Text = "Timesheet Monthly";
   this.radMonthly.UseVisualStyleBackColor = true;
   // 
   // chkStatus
   // 
   this.chkStatus.AutoSize = true;
   this.chkStatus.Location = new System.Drawing.Point(101, 53);
   this.chkStatus.Name = "chkStatus";
   this.chkStatus.Size = new System.Drawing.Size(56, 19);
   this.chkStatus.TabIndex = 0;
   this.chkStatus.Text = "Open";
   this.chkStatus.UseVisualStyleBackColor = true;
   // 
   // txtDescription
   // 
   this.txtDescription.Location = new System.Drawing.Point(101, 134);
   this.txtDescription.MaxLength = 50;
   this.txtDescription.Name = "txtDescription";
   this.txtDescription.Size = new System.Drawing.Size(284, 21);
   this.txtDescription.TabIndex = 4;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(11, 137);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(72, 15);
   this.label4.TabIndex = 13;
   this.label4.Text = "Description:";
   // 
   // txtPeriodCode
   // 
   this.txtPeriodCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtPeriodCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtPeriodCode.Location = new System.Drawing.Point(101, 25);
   this.txtPeriodCode.Name = "txtPeriodCode";
   this.txtPeriodCode.ReadOnly = true;
   this.txtPeriodCode.Size = new System.Drawing.Size(114, 21);
   this.txtPeriodCode.TabIndex = 0;
   this.txtPeriodCode.TabStop = false;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(11, 109);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(53, 15);
   this.label3.TabIndex = 5;
   this.label3.Text = "Date To:";
   // 
   // dtpTo
   // 
   this.dtpTo.CustomFormat = "ddd MMM dd. yyyy";
   this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpTo.Location = new System.Drawing.Point(101, 106);
   this.dtpTo.Name = "dtpTo";
   this.dtpTo.Size = new System.Drawing.Size(132, 21);
   this.dtpTo.TabIndex = 3;
   // 
   // dtpFrom
   // 
   this.dtpFrom.CustomFormat = "ddd MMM dd. yyyy";
   this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFrom.Location = new System.Drawing.Point(101, 77);
   this.dtpFrom.Name = "dtpFrom";
   this.dtpFrom.Size = new System.Drawing.Size(132, 21);
   this.dtpFrom.TabIndex = 2;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(11, 80);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(68, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Date From:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(11, 28);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(78, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Period Code:";
   // 
   // chkPostData
   // 
   this.chkPostData.AutoSize = true;
   this.chkPostData.Location = new System.Drawing.Point(163, 53);
   this.chkPostData.Name = "chkPostData";
   this.chkPostData.Size = new System.Drawing.Size(79, 19);
   this.chkPostData.TabIndex = 1;
   this.chkPostData.Text = "Post Data";
   this.chkPostData.UseVisualStyleBackColor = true;
   // 
   // frmTimeSheetPeriodEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(421, 372);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmTimeSheetPeriodEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Modify Timesheet Period";
   this.Load += new System.EventHandler(this.frmTimeSheetPeriodEdit_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtDescription;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtPeriodCode;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.DateTimePicker dtpTo;
  private System.Windows.Forms.DateTimePicker dtpFrom;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.CheckBox chkStatus;
  private System.Windows.Forms.RadioButton radPayroll;
  private System.Windows.Forms.RadioButton radMonthly;
  private System.Windows.Forms.TextBox txtModifyOn;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtModifyBy;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtCreateOn;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtCreateBy;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.CheckBox chkPostData;
 }
}