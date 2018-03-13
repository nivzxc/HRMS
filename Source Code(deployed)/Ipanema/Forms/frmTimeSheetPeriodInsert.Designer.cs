namespace Ipanema.Forms
{
 partial class frmTimeSheetPeriodInsert
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeSheetPeriodInsert));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.radPayroll = new System.Windows.Forms.RadioButton();
   this.radMonthly = new System.Windows.Forms.RadioButton();
   this.txtDescription = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.txtPeriodCode = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.dtpTo = new System.Windows.Forms.DateTimePicker();
   this.dtpFrom = new System.Windows.Forms.DateTimePicker();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(322, 188);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(79, 38);
   this.btnClose.TabIndex = 6;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(235, 188);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(79, 38);
   this.btnSave.TabIndex = 5;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.radPayroll);
   this.groupBox1.Controls.Add(this.radMonthly);
   this.groupBox1.Controls.Add(this.txtDescription);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.txtPeriodCode);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.dtpTo);
   this.groupBox1.Controls.Add(this.dtpFrom);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(11, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(388, 172);
   this.groupBox1.TabIndex = 13;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Timesheet Period Details";
   // 
   // radPayroll
   // 
   this.radPayroll.AutoSize = true;
   this.radPayroll.Location = new System.Drawing.Point(229, 141);
   this.radPayroll.Name = "radPayroll";
   this.radPayroll.Size = new System.Drawing.Size(101, 19);
   this.radPayroll.TabIndex = 4;
   this.radPayroll.Text = "Payroll Period";
   this.radPayroll.UseVisualStyleBackColor = true;
   // 
   // radMonthly
   // 
   this.radMonthly.AutoSize = true;
   this.radMonthly.Checked = true;
   this.radMonthly.Location = new System.Drawing.Point(94, 141);
   this.radMonthly.Name = "radMonthly";
   this.radMonthly.Size = new System.Drawing.Size(129, 19);
   this.radMonthly.TabIndex = 3;
   this.radMonthly.TabStop = true;
   this.radMonthly.Text = "Timesheet Monthly";
   this.radMonthly.UseVisualStyleBackColor = true;
   // 
   // txtDescription
   // 
   this.txtDescription.Location = new System.Drawing.Point(94, 114);
   this.txtDescription.MaxLength = 50;
   this.txtDescription.Name = "txtDescription";
   this.txtDescription.Size = new System.Drawing.Size(284, 21);
   this.txtDescription.TabIndex = 2;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(13, 117);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(72, 15);
   this.label4.TabIndex = 13;
   this.label4.Text = "Description:";
   // 
   // txtPeriodCode
   // 
   this.txtPeriodCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtPeriodCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtPeriodCode.Location = new System.Drawing.Point(94, 27);
   this.txtPeriodCode.Name = "txtPeriodCode";
   this.txtPeriodCode.ReadOnly = true;
   this.txtPeriodCode.Size = new System.Drawing.Size(114, 21);
   this.txtPeriodCode.TabIndex = 12;
   this.txtPeriodCode.TabStop = false;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(13, 88);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(53, 15);
   this.label3.TabIndex = 5;
   this.label3.Text = "Date To:";
   // 
   // dtpTo
   // 
   this.dtpTo.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpTo.Location = new System.Drawing.Point(94, 85);
   this.dtpTo.Name = "dtpTo";
   this.dtpTo.Size = new System.Drawing.Size(130, 21);
   this.dtpTo.TabIndex = 1;
   this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
   // 
   // dtpFrom
   // 
   this.dtpFrom.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFrom.Location = new System.Drawing.Point(94, 56);
   this.dtpFrom.Name = "dtpFrom";
   this.dtpFrom.Size = new System.Drawing.Size(130, 21);
   this.dtpFrom.TabIndex = 0;
   this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(13, 59);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(68, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Date From:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(13, 30);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(78, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Period Code:";
   // 
   // frmTimeSheetPeriodInsert
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(410, 235);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmTimeSheetPeriodInsert";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Create New Timesheet Period";
   this.Load += new System.EventHandler(this.frmTimeSheetPeriodInsert_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtPeriodCode;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.DateTimePicker dtpTo;
  private System.Windows.Forms.DateTimePicker dtpFrom;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtDescription;
  private System.Windows.Forms.RadioButton radPayroll;
  private System.Windows.Forms.RadioButton radMonthly;
 }
}