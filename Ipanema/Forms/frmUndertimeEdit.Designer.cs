namespace Ipanema.Forms
{
 partial class frmUndertimeEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUndertimeEdit));
   this.btnSave = new System.Windows.Forms.Button();
   this.btnClose = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtApproverName = new System.Windows.Forms.TextBox();
   this.txtDateApplied = new System.Windows.Forms.TextBox();
   this.dtpApproverTime = new System.Windows.Forms.DateTimePicker();
   this.txtEmployeeName = new System.Windows.Forms.TextBox();
   this.txtRemarks = new System.Windows.Forms.TextBox();
   this.dtpDateProcess = new System.Windows.Forms.DateTimePicker();
   this.txtReason = new System.Windows.Forms.TextBox();
   this.dtpFileDate = new System.Windows.Forms.DateTimePicker();
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
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(220, 328);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 9;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(307, 328);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 10;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtApproverName);
   this.groupBox1.Controls.Add(this.txtDateApplied);
   this.groupBox1.Controls.Add(this.dtpApproverTime);
   this.groupBox1.Controls.Add(this.txtEmployeeName);
   this.groupBox1.Controls.Add(this.txtRemarks);
   this.groupBox1.Controls.Add(this.dtpDateProcess);
   this.groupBox1.Controls.Add(this.txtReason);
   this.groupBox1.Controls.Add(this.dtpFileDate);
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
   this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox1.Location = new System.Drawing.Point(9, 5);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(377, 316);
   this.groupBox1.TabIndex = 19;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Application For Undertime Details";
   // 
   // txtApproverName
   // 
   this.txtApproverName.BackColor = System.Drawing.Color.AliceBlue;
   this.txtApproverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtApproverName.Location = new System.Drawing.Point(111, 196);
   this.txtApproverName.MaxLength = 6;
   this.txtApproverName.Name = "txtApproverName";
   this.txtApproverName.ReadOnly = true;
   this.txtApproverName.Size = new System.Drawing.Size(256, 21);
   this.txtApproverName.TabIndex = 28;
   this.txtApproverName.TabStop = false;
   // 
   // txtDateApplied
   // 
   this.txtDateApplied.BackColor = System.Drawing.Color.AliceBlue;
   this.txtDateApplied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDateApplied.Location = new System.Drawing.Point(111, 107);
   this.txtDateApplied.MaxLength = 6;
   this.txtDateApplied.Name = "txtDateApplied";
   this.txtDateApplied.ReadOnly = true;
   this.txtDateApplied.Size = new System.Drawing.Size(188, 21);
   this.txtDateApplied.TabIndex = 27;
   this.txtDateApplied.TabStop = false;
   // 
   // dtpApproverTime
   // 
   this.dtpApproverTime.CustomFormat = "hh:mm tt";
   this.dtpApproverTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpApproverTime.Location = new System.Drawing.Point(221, 225);
   this.dtpApproverTime.Name = "dtpApproverTime";
   this.dtpApproverTime.ShowUpDown = true;
   this.dtpApproverTime.Size = new System.Drawing.Size(80, 21);
   this.dtpApproverTime.TabIndex = 7;
   // 
   // txtEmployeeName
   // 
   this.txtEmployeeName.BackColor = System.Drawing.Color.AliceBlue;
   this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtEmployeeName.Location = new System.Drawing.Point(111, 53);
   this.txtEmployeeName.MaxLength = 6;
   this.txtEmployeeName.Name = "txtEmployeeName";
   this.txtEmployeeName.ReadOnly = true;
   this.txtEmployeeName.Size = new System.Drawing.Size(256, 21);
   this.txtEmployeeName.TabIndex = 26;
   this.txtEmployeeName.TabStop = false;
   // 
   // txtRemarks
   // 
   this.txtRemarks.BackColor = System.Drawing.Color.White;
   this.txtRemarks.Location = new System.Drawing.Point(111, 252);
   this.txtRemarks.MaxLength = 255;
   this.txtRemarks.Multiline = true;
   this.txtRemarks.Name = "txtRemarks";
   this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtRemarks.Size = new System.Drawing.Size(255, 53);
   this.txtRemarks.TabIndex = 8;
   // 
   // dtpDateProcess
   // 
   this.dtpDateProcess.CustomFormat = "MMM dd, yyyy";
   this.dtpDateProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpDateProcess.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpDateProcess.Location = new System.Drawing.Point(111, 225);
   this.dtpDateProcess.Name = "dtpDateProcess";
   this.dtpDateProcess.Size = new System.Drawing.Size(103, 21);
   this.dtpDateProcess.TabIndex = 6;
   // 
   // txtReason
   // 
   this.txtReason.BackColor = System.Drawing.Color.White;
   this.txtReason.Location = new System.Drawing.Point(111, 134);
   this.txtReason.MaxLength = 255;
   this.txtReason.Multiline = true;
   this.txtReason.Name = "txtReason";
   this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtReason.Size = new System.Drawing.Size(255, 55);
   this.txtReason.TabIndex = 4;
   // 
   // dtpFileDate
   // 
   this.dtpFileDate.CustomFormat = "MMM dd, yyyy";
   this.dtpFileDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpFileDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFileDate.Location = new System.Drawing.Point(111, 80);
   this.dtpFileDate.Name = "dtpFileDate";
   this.dtpFileDate.Size = new System.Drawing.Size(103, 21);
   this.dtpFileDate.TabIndex = 1;
   // 
   // cmbStatus
   // 
   this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbStatus.FormattingEnabled = true;
   this.cmbStatus.Location = new System.Drawing.Point(262, 24);
   this.cmbStatus.Name = "cmbStatus";
   this.cmbStatus.Size = new System.Drawing.Size(105, 23);
   this.cmbStatus.TabIndex = 0;
   // 
   // label12
   // 
   this.label12.AutoSize = true;
   this.label12.Location = new System.Drawing.Point(9, 252);
   this.label12.Name = "label12";
   this.label12.Size = new System.Drawing.Size(60, 15);
   this.label12.TabIndex = 25;
   this.label12.Text = "Remarks:";
   // 
   // label11
   // 
   this.label11.AutoSize = true;
   this.label11.Location = new System.Drawing.Point(9, 228);
   this.label11.Name = "label11";
   this.label11.Size = new System.Drawing.Size(97, 15);
   this.label11.TabIndex = 22;
   this.label11.Text = "Date Processed:";
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Location = new System.Drawing.Point(9, 201);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(58, 15);
   this.label10.TabIndex = 20;
   this.label10.Text = "Approver:";
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Location = new System.Drawing.Point(9, 110);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(80, 15);
   this.label8.TabIndex = 14;
   this.label8.Text = "Date Applied:";
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(9, 83);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(66, 15);
   this.label7.TabIndex = 12;
   this.label7.Text = "Date Filed:";
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(216, 30);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(44, 15);
   this.label6.TabIndex = 10;
   this.label6.Text = "Status:";
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(9, 134);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(53, 15);
   this.label3.TabIndex = 4;
   this.label3.Text = "Reason:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(9, 56);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(67, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Requestor:";
   // 
   // txtUndertimeCode
   // 
   this.txtUndertimeCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtUndertimeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtUndertimeCode.Location = new System.Drawing.Point(111, 26);
   this.txtUndertimeCode.MaxLength = 6;
   this.txtUndertimeCode.Name = "txtUndertimeCode";
   this.txtUndertimeCode.ReadOnly = true;
   this.txtUndertimeCode.Size = new System.Drawing.Size(91, 21);
   this.txtUndertimeCode.TabIndex = 0;
   this.txtUndertimeCode.TabStop = false;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(9, 30);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(100, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Undertime Code:";
   // 
   // frmUndertimeEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(396, 375);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmUndertimeEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit Undertime Application";
   this.TopMost = true;
   this.Load += new System.EventHandler(this.frmUndertimeEdit_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtRemarks;
  private System.Windows.Forms.DateTimePicker dtpDateProcess;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.DateTimePicker dtpFileDate;
  private System.Windows.Forms.ComboBox cmbStatus;
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
  private System.Windows.Forms.TextBox txtEmployeeName;
  private System.Windows.Forms.DateTimePicker dtpApproverTime;
  private System.Windows.Forms.TextBox txtDateApplied;
  private System.Windows.Forms.TextBox txtApproverName;

 }
}