namespace Ipanema.Forms
{
 partial class frmLeaveNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaveNew));
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpApproverTime = new System.Windows.Forms.DateTimePicker();
            this.cmbTimeTo = new System.Windows.Forms.ComboBox();
            this.cmbTimeFrom = new System.Windows.Forms.ComboBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnBalance = new System.Windows.Forms.Button();
            this.txtLeaveCode = new System.Windows.Forms.TextBox();
            this.dtpDateFile = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpApproverDate = new System.Windows.Forms.DateTimePicker();
            this.txtARemarks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbApprover = new System.Windows.Forms.ComboBox();
            this.cmbRequestor = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(309, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 38);
            this.btnClose.TabIndex = 14;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpApproverTime);
            this.groupBox1.Controls.Add(this.cmbTimeTo);
            this.groupBox1.Controls.Add(this.cmbTimeFrom);
            this.groupBox1.Controls.Add(this.txtBalance);
            this.groupBox1.Controls.Add(this.btnBalance);
            this.groupBox1.Controls.Add(this.txtLeaveCode);
            this.groupBox1.Controls.Add(this.dtpDateFile);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpApproverDate);
            this.groupBox1.Controls.Add(this.txtARemarks);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbApprover);
            this.groupBox1.Controls.Add(this.cmbRequestor);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.dtpDateEnd);
            this.groupBox1.Controls.Add(this.dtpDateStart);
            this.groupBox1.Controls.Add(this.cmbLeaveType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUnits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtReason);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 395);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application For Leave Details";
            // 
            // dtpApproverTime
            // 
            this.dtpApproverTime.CustomFormat = "hh:mm tt";
            this.dtpApproverTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpApproverTime.Location = new System.Drawing.Point(284, 302);
            this.dtpApproverTime.Name = "dtpApproverTime";
            this.dtpApproverTime.ShowUpDown = true;
            this.dtpApproverTime.Size = new System.Drawing.Size(80, 21);
            this.dtpApproverTime.TabIndex = 11;
            // 
            // cmbTimeTo
            // 
            this.cmbTimeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeTo.FormattingEnabled = true;
            this.cmbTimeTo.Location = new System.Drawing.Point(284, 168);
            this.cmbTimeTo.Name = "cmbTimeTo";
            this.cmbTimeTo.Size = new System.Drawing.Size(80, 23);
            this.cmbTimeTo.TabIndex = 7;
            this.cmbTimeTo.SelectedIndexChanged += new System.EventHandler(this.cmbTimeTo_SelectedIndexChanged);
            // 
            // cmbTimeFrom
            // 
            this.cmbTimeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeFrom.FormattingEnabled = true;
            this.cmbTimeFrom.Location = new System.Drawing.Point(284, 139);
            this.cmbTimeFrom.Name = "cmbTimeFrom";
            this.cmbTimeFrom.Size = new System.Drawing.Size(80, 23);
            this.cmbTimeFrom.TabIndex = 5;
            this.cmbTimeFrom.SelectedIndexChanged += new System.EventHandler(this.cmbTimeFrom_SelectedIndexChanged);
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.AliceBlue;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(292, 85);
            this.txtBalance.MaxLength = 6;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(37, 21);
            this.txtBalance.TabIndex = 39;
            this.txtBalance.TabStop = false;
            // 
            // btnBalance
            // 
            this.btnBalance.Image = ((System.Drawing.Image)(resources.GetObject("btnBalance.Image")));
            this.btnBalance.Location = new System.Drawing.Point(336, 83);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(28, 26);
            this.btnBalance.TabIndex = 38;
            this.btnBalance.TabStop = false;
            this.btnBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // txtLeaveCode
            // 
            this.txtLeaveCode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtLeaveCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaveCode.Location = new System.Drawing.Point(88, 27);
            this.txtLeaveCode.MaxLength = 6;
            this.txtLeaveCode.Name = "txtLeaveCode";
            this.txtLeaveCode.Size = new System.Drawing.Size(94, 21);
            this.txtLeaveCode.TabIndex = 37;
            this.txtLeaveCode.TabStop = false;
            // 
            // dtpDateFile
            // 
            this.dtpDateFile.CustomFormat = "MMM dd, yyyy";
            this.dtpDateFile.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFile.Location = new System.Drawing.Point(88, 114);
            this.dtpDateFile.Name = "dtpDateFile";
            this.dtpDateFile.Size = new System.Drawing.Size(167, 21);
            this.dtpDateFile.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "Processed:";
            // 
            // dtpApproverDate
            // 
            this.dtpApproverDate.CustomFormat = "MMM dd, yyyy";
            this.dtpApproverDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpApproverDate.Location = new System.Drawing.Point(88, 302);
            this.dtpApproverDate.Name = "dtpApproverDate";
            this.dtpApproverDate.Size = new System.Drawing.Size(167, 21);
            this.dtpApproverDate.TabIndex = 10;
            // 
            // txtARemarks
            // 
            this.txtARemarks.BackColor = System.Drawing.Color.White;
            this.txtARemarks.Location = new System.Drawing.Point(88, 330);
            this.txtARemarks.MaxLength = 255;
            this.txtARemarks.Multiline = true;
            this.txtARemarks.Name = "txtARemarks";
            this.txtARemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtARemarks.Size = new System.Drawing.Size(276, 54);
            this.txtARemarks.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 32;
            this.label11.Text = "Remarks:";
            // 
            // cmbApprover
            // 
            this.cmbApprover.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApprover.FormattingEnabled = true;
            this.cmbApprover.Location = new System.Drawing.Point(88, 272);
            this.cmbApprover.Name = "cmbApprover";
            this.cmbApprover.Size = new System.Drawing.Size(276, 23);
            this.cmbApprover.TabIndex = 9;
            // 
            // cmbRequestor
            // 
            this.cmbRequestor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequestor.FormattingEnabled = true;
            this.cmbRequestor.Location = new System.Drawing.Point(88, 54);
            this.cmbRequestor.Name = "cmbRequestor";
            this.cmbRequestor.Size = new System.Drawing.Size(276, 23);
            this.cmbRequestor.TabIndex = 1;
            this.cmbRequestor.SelectedIndexChanged += new System.EventHandler(this.cmbRequestor_SelectedIndexChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(236, 24);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(128, 23);
            this.cmbStatus.TabIndex = 0;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.CustomFormat = "MMM dd, yyyy";
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateEnd.Location = new System.Drawing.Point(88, 170);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(167, 21);
            this.dtpDateEnd.TabIndex = 6;
            this.dtpDateEnd.ValueChanged += new System.EventHandler(this.dtpDateEnd_ValueChanged);
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.CustomFormat = "MMM dd, yyyy";
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateStart.Location = new System.Drawing.Point(88, 141);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(167, 21);
            this.dtpDateStart.TabIndex = 4;
            this.dtpDateStart.ValueChanged += new System.EventHandler(this.dtpDateStart_ValueChanged);
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeaveType.FormattingEnabled = true;
            this.cmbLeaveType.Location = new System.Drawing.Point(88, 84);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(194, 23);
            this.cmbLeaveType.TabIndex = 2;
            this.cmbLeaveType.SelectedIndexChanged += new System.EventHandler(this.cmbLeaveType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Approver:";
            // 
            // txtUnits
            // 
            this.txtUnits.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnits.Location = new System.Drawing.Point(305, 113);
            this.txtUnits.MaxLength = 6;
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.ReadOnly = true;
            this.txtUnits.Size = new System.Drawing.Size(59, 21);
            this.txtUnits.TabIndex = 4;
            this.txtUnits.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Units:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Date End:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Date Start:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date Filed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Leave Type:";
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.White;
            this.txtReason.Location = new System.Drawing.Point(88, 199);
            this.txtReason.MaxLength = 255;
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.Size = new System.Drawing.Size(276, 66);
            this.txtReason.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reason:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Requestor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leave Code:";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(220, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 38);
            this.btnSave.TabIndex = 13;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmLeaveNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(400, 464);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLeaveNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Leave Application";
            this.Load += new System.EventHandler(this.frmLeaveNew_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.ComboBox cmbStatus;
  private System.Windows.Forms.DateTimePicker dtpDateEnd;
  private System.Windows.Forms.DateTimePicker dtpDateStart;
  private System.Windows.Forms.ComboBox cmbLeaveType;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.TextBox txtUnits;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.ComboBox cmbRequestor;
  private System.Windows.Forms.ComboBox cmbApprover;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.DateTimePicker dtpApproverDate;
  private System.Windows.Forms.TextBox txtARemarks;
  private System.Windows.Forms.Label label11;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.DateTimePicker dtpDateFile;
  private System.Windows.Forms.TextBox txtLeaveCode;
  private System.Windows.Forms.Button btnBalance;
  private System.Windows.Forms.TextBox txtBalance;
  private System.Windows.Forms.ComboBox cmbTimeTo;
  private System.Windows.Forms.ComboBox cmbTimeFrom;
  private System.Windows.Forms.DateTimePicker dtpApproverTime;
 }
}