namespace Ipanema.Forms
{
 partial class frmLeaveEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaveEdit));
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtLeaveType = new System.Windows.Forms.TextBox();
   this.dtpApproverTime = new System.Windows.Forms.DateTimePicker();
   this.dtpApproverDate = new System.Windows.Forms.DateTimePicker();
   this.txtLeaveCode = new System.Windows.Forms.TextBox();
   this.txtDateEnd = new System.Windows.Forms.TextBox();
   this.txtDateStart = new System.Windows.Forms.TextBox();
   this.txtBalance = new System.Windows.Forms.TextBox();
   this.cmbStatus = new System.Windows.Forms.ComboBox();
   this.txtApproverRemarks = new System.Windows.Forms.TextBox();
   this.label12 = new System.Windows.Forms.Label();
   this.label11 = new System.Windows.Forms.Label();
   this.txtApprover = new System.Windows.Forms.TextBox();
   this.label10 = new System.Windows.Forms.Label();
   this.txtUnits = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.label9 = new System.Windows.Forms.Label();
   this.label8 = new System.Windows.Forms.Label();
   this.txtFiled = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.label6 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.txtRequestor = new System.Windows.Forms.TextBox();
   this.txtReason = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.btnSave = new System.Windows.Forms.Button();
   this.btnClose = new System.Windows.Forms.Button();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtLeaveType);
   this.groupBox1.Controls.Add(this.dtpApproverTime);
   this.groupBox1.Controls.Add(this.dtpApproverDate);
   this.groupBox1.Controls.Add(this.txtLeaveCode);
   this.groupBox1.Controls.Add(this.txtDateEnd);
   this.groupBox1.Controls.Add(this.txtDateStart);
   this.groupBox1.Controls.Add(this.txtBalance);
   this.groupBox1.Controls.Add(this.cmbStatus);
   this.groupBox1.Controls.Add(this.txtApproverRemarks);
   this.groupBox1.Controls.Add(this.label12);
   this.groupBox1.Controls.Add(this.label11);
   this.groupBox1.Controls.Add(this.txtApprover);
   this.groupBox1.Controls.Add(this.label10);
   this.groupBox1.Controls.Add(this.txtUnits);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.label9);
   this.groupBox1.Controls.Add(this.label8);
   this.groupBox1.Controls.Add(this.txtFiled);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.txtRequestor);
   this.groupBox1.Controls.Add(this.txtReason);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(9, 4);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(377, 366);
   this.groupBox1.TabIndex = 7;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Application For Leave Details";
   // 
   // txtLeaveType
   // 
   this.txtLeaveType.BackColor = System.Drawing.Color.AliceBlue;
   this.txtLeaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtLeaveType.Location = new System.Drawing.Point(91, 80);
   this.txtLeaveType.MaxLength = 6;
   this.txtLeaveType.Name = "txtLeaveType";
   this.txtLeaveType.ReadOnly = true;
   this.txtLeaveType.Size = new System.Drawing.Size(227, 21);
   this.txtLeaveType.TabIndex = 44;
   this.txtLeaveType.TabStop = false;
   // 
   // dtpApproverTime
   // 
   this.dtpApproverTime.CustomFormat = "hh:mm tt";
   this.dtpApproverTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpApproverTime.Location = new System.Drawing.Point(211, 288);
   this.dtpApproverTime.Name = "dtpApproverTime";
   this.dtpApproverTime.ShowCheckBox = true;
   this.dtpApproverTime.ShowUpDown = true;
   this.dtpApproverTime.Size = new System.Drawing.Size(92, 21);
   this.dtpApproverTime.TabIndex = 4;
   // 
   // dtpApproverDate
   // 
   this.dtpApproverDate.CustomFormat = "MMM dd, yyyy";
   this.dtpApproverDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpApproverDate.Location = new System.Drawing.Point(91, 288);
   this.dtpApproverDate.Name = "dtpApproverDate";
   this.dtpApproverDate.ShowCheckBox = true;
   this.dtpApproverDate.Size = new System.Drawing.Size(113, 21);
   this.dtpApproverDate.TabIndex = 3;
   // 
   // txtLeaveCode
   // 
   this.txtLeaveCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtLeaveCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtLeaveCode.Location = new System.Drawing.Point(91, 23);
   this.txtLeaveCode.MaxLength = 6;
   this.txtLeaveCode.Name = "txtLeaveCode";
   this.txtLeaveCode.ReadOnly = true;
   this.txtLeaveCode.Size = new System.Drawing.Size(95, 21);
   this.txtLeaveCode.TabIndex = 43;
   this.txtLeaveCode.TabStop = false;
   // 
   // txtDateEnd
   // 
   this.txtDateEnd.BackColor = System.Drawing.Color.AliceBlue;
   this.txtDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDateEnd.Location = new System.Drawing.Point(91, 161);
   this.txtDateEnd.MaxLength = 6;
   this.txtDateEnd.Name = "txtDateEnd";
   this.txtDateEnd.ReadOnly = true;
   this.txtDateEnd.Size = new System.Drawing.Size(139, 21);
   this.txtDateEnd.TabIndex = 42;
   this.txtDateEnd.TabStop = false;
   // 
   // txtDateStart
   // 
   this.txtDateStart.BackColor = System.Drawing.Color.AliceBlue;
   this.txtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDateStart.Location = new System.Drawing.Point(91, 135);
   this.txtDateStart.MaxLength = 6;
   this.txtDateStart.Name = "txtDateStart";
   this.txtDateStart.ReadOnly = true;
   this.txtDateStart.Size = new System.Drawing.Size(139, 21);
   this.txtDateStart.TabIndex = 41;
   this.txtDateStart.TabStop = false;
   // 
   // txtBalance
   // 
   this.txtBalance.BackColor = System.Drawing.Color.AliceBlue;
   this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtBalance.Location = new System.Drawing.Point(325, 80);
   this.txtBalance.MaxLength = 6;
   this.txtBalance.Name = "txtBalance";
   this.txtBalance.Size = new System.Drawing.Size(37, 21);
   this.txtBalance.TabIndex = 40;
   this.txtBalance.TabStop = false;
   // 
   // cmbStatus
   // 
   this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbStatus.FormattingEnabled = true;
   this.cmbStatus.Location = new System.Drawing.Point(239, 23);
   this.cmbStatus.Name = "cmbStatus";
   this.cmbStatus.Size = new System.Drawing.Size(123, 23);
   this.cmbStatus.TabIndex = 0;
   // 
   // txtApproverRemarks
   // 
   this.txtApproverRemarks.BackColor = System.Drawing.Color.AliceBlue;
   this.txtApproverRemarks.Location = new System.Drawing.Point(91, 314);
   this.txtApproverRemarks.MaxLength = 255;
   this.txtApproverRemarks.Multiline = true;
   this.txtApproverRemarks.Name = "txtApproverRemarks";
   this.txtApproverRemarks.ReadOnly = true;
   this.txtApproverRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtApproverRemarks.Size = new System.Drawing.Size(276, 41);
   this.txtApproverRemarks.TabIndex = 13;
   this.txtApproverRemarks.TabStop = false;
   // 
   // label12
   // 
   this.label12.AutoSize = true;
   this.label12.Location = new System.Drawing.Point(11, 312);
   this.label12.Name = "label12";
   this.label12.Size = new System.Drawing.Size(60, 15);
   this.label12.TabIndex = 25;
   this.label12.Text = "Remarks:";
   // 
   // label11
   // 
   this.label11.AutoSize = true;
   this.label11.Location = new System.Drawing.Point(11, 289);
   this.label11.Name = "label11";
   this.label11.Size = new System.Drawing.Size(68, 15);
   this.label11.TabIndex = 22;
   this.label11.Text = "Processed:";
   // 
   // txtApprover
   // 
   this.txtApprover.BackColor = System.Drawing.Color.AliceBlue;
   this.txtApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtApprover.Location = new System.Drawing.Point(91, 261);
   this.txtApprover.MaxLength = 6;
   this.txtApprover.Name = "txtApprover";
   this.txtApprover.ReadOnly = true;
   this.txtApprover.Size = new System.Drawing.Size(277, 21);
   this.txtApprover.TabIndex = 11;
   this.txtApprover.TabStop = false;
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Location = new System.Drawing.Point(11, 262);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(58, 15);
   this.label10.TabIndex = 20;
   this.label10.Text = "Approver:";
   // 
   // txtUnits
   // 
   this.txtUnits.BackColor = System.Drawing.Color.AliceBlue;
   this.txtUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtUnits.Location = new System.Drawing.Point(252, 108);
   this.txtUnits.MaxLength = 6;
   this.txtUnits.Name = "txtUnits";
   this.txtUnits.ReadOnly = true;
   this.txtUnits.Size = new System.Drawing.Size(69, 21);
   this.txtUnits.TabIndex = 5;
   this.txtUnits.TabStop = false;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(210, 112);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(38, 15);
   this.label4.TabIndex = 18;
   this.label4.Text = "Units:";
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Location = new System.Drawing.Point(11, 163);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(61, 15);
   this.label9.TabIndex = 16;
   this.label9.Text = "Date End:";
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Location = new System.Drawing.Point(11, 136);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(64, 15);
   this.label8.TabIndex = 14;
   this.label8.Text = "Date Start:";
   // 
   // txtFiled
   // 
   this.txtFiled.BackColor = System.Drawing.Color.AliceBlue;
   this.txtFiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtFiled.Location = new System.Drawing.Point(91, 108);
   this.txtFiled.MaxLength = 6;
   this.txtFiled.Name = "txtFiled";
   this.txtFiled.ReadOnly = true;
   this.txtFiled.Size = new System.Drawing.Size(108, 21);
   this.txtFiled.TabIndex = 4;
   this.txtFiled.TabStop = false;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(11, 109);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(66, 15);
   this.label7.TabIndex = 12;
   this.label7.Text = "Date Filed:";
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(193, 27);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(44, 15);
   this.label6.TabIndex = 10;
   this.label6.Text = "Status:";
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(11, 82);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(72, 15);
   this.label5.TabIndex = 8;
   this.label5.Text = "Leave Type:";
   // 
   // txtRequestor
   // 
   this.txtRequestor.BackColor = System.Drawing.Color.AliceBlue;
   this.txtRequestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtRequestor.Location = new System.Drawing.Point(91, 52);
   this.txtRequestor.MaxLength = 6;
   this.txtRequestor.Name = "txtRequestor";
   this.txtRequestor.ReadOnly = true;
   this.txtRequestor.Size = new System.Drawing.Size(264, 21);
   this.txtRequestor.TabIndex = 2;
   this.txtRequestor.TabStop = false;
   // 
   // txtReason
   // 
   this.txtReason.BackColor = System.Drawing.Color.White;
   this.txtReason.Location = new System.Drawing.Point(91, 188);
   this.txtReason.MaxLength = 255;
   this.txtReason.Multiline = true;
   this.txtReason.Name = "txtReason";
   this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtReason.Size = new System.Drawing.Size(276, 66);
   this.txtReason.TabIndex = 2;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(11, 186);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(53, 15);
   this.label3.TabIndex = 4;
   this.label3.Text = "Reason:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(11, 55);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(67, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Requestor:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(11, 26);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(75, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Leave Code:";
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(221, 380);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 15;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(307, 380);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 16;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // frmLeaveEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(396, 428);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmLeaveEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit Application For Leave";
   this.Load += new System.EventHandler(this.frmLeaveEdit_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtRequestor;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.TextBox txtFiled;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtApproverRemarks;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.Label label11;
  private System.Windows.Forms.TextBox txtApprover;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.TextBox txtUnits;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.ComboBox cmbStatus;
  private System.Windows.Forms.TextBox txtBalance;
  private System.Windows.Forms.TextBox txtLeaveCode;
  private System.Windows.Forms.TextBox txtDateEnd;
  private System.Windows.Forms.TextBox txtDateStart;
  private System.Windows.Forms.DateTimePicker dtpApproverDate;
  private System.Windows.Forms.DateTimePicker dtpApproverTime;
  private System.Windows.Forms.TextBox txtLeaveType;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.Button btnClose;
 }
}