namespace Ipanema.Forms
{
 partial class frmUndertimeNew
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUndertimeNew));
   this.btnClose = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.dtpApproverTime = new System.Windows.Forms.DateTimePicker();
   this.txtRemarks = new System.Windows.Forms.TextBox();
   this.dtpDateProcess = new System.Windows.Forms.DateTimePicker();
   this.cmbApprover = new System.Windows.Forms.ComboBox();
   this.txtReason = new System.Windows.Forms.TextBox();
   this.dtpTimeApplied = new System.Windows.Forms.DateTimePicker();
   this.dtpDateApplied = new System.Windows.Forms.DateTimePicker();
   this.dtpFileDate = new System.Windows.Forms.DateTimePicker();
   this.cmbRequestor = new System.Windows.Forms.ComboBox();
   this.cmbStatus = new System.Windows.Forms.ComboBox();
   this.label12 = new System.Windows.Forms.Label();
   this.label11 = new System.Windows.Forms.Label();
   this.label10 = new System.Windows.Forms.Label();
   this.label8 = new System.Windows.Forms.Label();
   this.label7 = new System.Windows.Forms.Label();
   this.label6 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.txtUndertimeCode = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(304, 332);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(82, 38);
   this.btnClose.TabIndex = 10;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.dtpApproverTime);
   this.groupBox1.Controls.Add(this.txtRemarks);
   this.groupBox1.Controls.Add(this.dtpDateProcess);
   this.groupBox1.Controls.Add(this.cmbApprover);
   this.groupBox1.Controls.Add(this.txtReason);
   this.groupBox1.Controls.Add(this.dtpTimeApplied);
   this.groupBox1.Controls.Add(this.dtpDateApplied);
   this.groupBox1.Controls.Add(this.dtpFileDate);
   this.groupBox1.Controls.Add(this.cmbRequestor);
   this.groupBox1.Controls.Add(this.cmbStatus);
   this.groupBox1.Controls.Add(this.label12);
   this.groupBox1.Controls.Add(this.label11);
   this.groupBox1.Controls.Add(this.label10);
   this.groupBox1.Controls.Add(this.label8);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.txtUndertimeCode);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(10, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(374, 316);
   this.groupBox1.TabIndex = 16;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Application For Undertime Details";
   // 
   // dtpApproverTime
   // 
   this.dtpApproverTime.CustomFormat = "hh:mm tt";
   this.dtpApproverTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpApproverTime.Location = new System.Drawing.Point(220, 226);
   this.dtpApproverTime.Name = "dtpApproverTime";
   this.dtpApproverTime.ShowUpDown = true;
   this.dtpApproverTime.Size = new System.Drawing.Size(80, 21);
   this.dtpApproverTime.TabIndex = 26;
   // 
   // txtRemarks
   // 
   this.txtRemarks.BackColor = System.Drawing.Color.White;
   this.txtRemarks.Location = new System.Drawing.Point(108, 252);
   this.txtRemarks.MaxLength = 255;
   this.txtRemarks.Multiline = true;
   this.txtRemarks.Name = "txtRemarks";
   this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtRemarks.Size = new System.Drawing.Size(255, 54);
   this.txtRemarks.TabIndex = 8;
   // 
   // dtpDateProcess
   // 
   this.dtpDateProcess.CustomFormat = "MMM dd, yyyy";
   this.dtpDateProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpDateProcess.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpDateProcess.Location = new System.Drawing.Point(108, 226);
   this.dtpDateProcess.Name = "dtpDateProcess";
   this.dtpDateProcess.Size = new System.Drawing.Size(103, 21);
   this.dtpDateProcess.TabIndex = 7;
   // 
   // cmbApprover
   // 
   this.cmbApprover.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbApprover.FormattingEnabled = true;
   this.cmbApprover.Location = new System.Drawing.Point(108, 197);
   this.cmbApprover.Name = "cmbApprover";
   this.cmbApprover.Size = new System.Drawing.Size(221, 23);
   this.cmbApprover.TabIndex = 7;
   // 
   // txtReason
   // 
   this.txtReason.BackColor = System.Drawing.Color.White;
   this.txtReason.Location = new System.Drawing.Point(108, 138);
   this.txtReason.MaxLength = 255;
   this.txtReason.Multiline = true;
   this.txtReason.Name = "txtReason";
   this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtReason.Size = new System.Drawing.Size(255, 52);
   this.txtReason.TabIndex = 5;
   // 
   // dtpTimeApplied
   // 
   this.dtpTimeApplied.CustomFormat = "hh:mm tt";
   this.dtpTimeApplied.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpTimeApplied.Location = new System.Drawing.Point(220, 111);
   this.dtpTimeApplied.Name = "dtpTimeApplied";
   this.dtpTimeApplied.ShowUpDown = true;
   this.dtpTimeApplied.Size = new System.Drawing.Size(89, 21);
   this.dtpTimeApplied.TabIndex = 4;
   this.dtpTimeApplied.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
   // 
   // dtpDateApplied
   // 
   this.dtpDateApplied.CustomFormat = "MMM dd, yyyy";
   this.dtpDateApplied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpDateApplied.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpDateApplied.Location = new System.Drawing.Point(108, 111);
   this.dtpDateApplied.Name = "dtpDateApplied";
   this.dtpDateApplied.Size = new System.Drawing.Size(103, 21);
   this.dtpDateApplied.TabIndex = 3;
   // 
   // dtpFileDate
   // 
   this.dtpFileDate.CustomFormat = "MMM dd, yyyy";
   this.dtpFileDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpFileDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFileDate.Location = new System.Drawing.Point(108, 84);
   this.dtpFileDate.Name = "dtpFileDate";
   this.dtpFileDate.Size = new System.Drawing.Size(103, 21);
   this.dtpFileDate.TabIndex = 2;
   // 
   // cmbRequestor
   // 
   this.cmbRequestor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbRequestor.FormattingEnabled = true;
   this.cmbRequestor.Location = new System.Drawing.Point(108, 56);
   this.cmbRequestor.Name = "cmbRequestor";
   this.cmbRequestor.Size = new System.Drawing.Size(221, 23);
   this.cmbRequestor.TabIndex = 1;
   this.cmbRequestor.SelectedIndexChanged += new System.EventHandler(this.cmbRequestor_SelectedIndexChanged);
   // 
   // cmbStatus
   // 
   this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbStatus.FormattingEnabled = true;
   this.cmbStatus.Location = new System.Drawing.Point(259, 27);
   this.cmbStatus.Name = "cmbStatus";
   this.cmbStatus.Size = new System.Drawing.Size(105, 23);
   this.cmbStatus.TabIndex = 0;
   this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
   // 
   // label12
   // 
   this.label12.AutoSize = true;
   this.label12.Location = new System.Drawing.Point(9, 253);
   this.label12.Name = "label12";
   this.label12.Size = new System.Drawing.Size(60, 15);
   this.label12.TabIndex = 25;
   this.label12.Text = "Remarks:";
   // 
   // label11
   // 
   this.label11.AutoSize = true;
   this.label11.Location = new System.Drawing.Point(9, 229);
   this.label11.Name = "label11";
   this.label11.Size = new System.Drawing.Size(97, 15);
   this.label11.TabIndex = 22;
   this.label11.Text = "Date Processed:";
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Location = new System.Drawing.Point(9, 203);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(58, 15);
   this.label10.TabIndex = 20;
   this.label10.Text = "Approver:";
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Location = new System.Drawing.Point(9, 114);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(80, 15);
   this.label8.TabIndex = 14;
   this.label8.Text = "Date Applied:";
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(9, 87);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(66, 15);
   this.label7.TabIndex = 12;
   this.label7.Text = "Date Filed:";
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(213, 31);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(44, 15);
   this.label6.TabIndex = 10;
   this.label6.Text = "Status:";
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(9, 138);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(53, 15);
   this.label3.TabIndex = 4;
   this.label3.Text = "Reason:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(9, 60);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(67, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Requestor:";
   // 
   // txtUndertimeCode
   // 
   this.txtUndertimeCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtUndertimeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtUndertimeCode.Location = new System.Drawing.Point(108, 27);
   this.txtUndertimeCode.MaxLength = 6;
   this.txtUndertimeCode.Name = "txtUndertimeCode";
   this.txtUndertimeCode.ReadOnly = true;
   this.txtUndertimeCode.Size = new System.Drawing.Size(91, 20);
   this.txtUndertimeCode.TabIndex = 0;
   this.txtUndertimeCode.TabStop = false;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(9, 31);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(58, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "UT Code:";
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(218, 332);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 9;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // frmUndertimeNew
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(394, 378);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmUndertimeNew";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Create New Undertime Application";
   this.Load += new System.EventHandler(this.frmUndertimeNew_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.Label label11;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtUndertimeCode;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.ComboBox cmbStatus;
  private System.Windows.Forms.ComboBox cmbRequestor;
  private System.Windows.Forms.DateTimePicker dtpDateApplied;
  private System.Windows.Forms.DateTimePicker dtpFileDate;
  private System.Windows.Forms.DateTimePicker dtpTimeApplied;
  private System.Windows.Forms.TextBox txtRemarks;
  private System.Windows.Forms.DateTimePicker dtpDateProcess;
  private System.Windows.Forms.ComboBox cmbApprover;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.DateTimePicker dtpApproverTime;
 }
}