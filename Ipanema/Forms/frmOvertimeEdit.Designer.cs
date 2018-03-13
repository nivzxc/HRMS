namespace Ipanema.Forms
{
 partial class frmOvertimeEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOvertimeEdit));
   this.btnSave = new System.Windows.Forms.Button();
   this.btnClose = new System.Windows.Forms.Button();
   this.groupBox2 = new System.Windows.Forms.GroupBox();
   this.label8 = new System.Windows.Forms.Label();
   this.txtChargeType = new System.Windows.Forms.TextBox();
   this.label11 = new System.Windows.Forms.Label();
   this.txtHApprover = new System.Windows.Forms.TextBox();
   this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
   this.txtRApprover = new System.Windows.Forms.TextBox();
   this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
   this.txtRenderedTo = new System.Windows.Forms.TextBox();
   this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
   this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
   this.txtRequestor = new System.Windows.Forms.TextBox();
   this.dtpHTime = new System.Windows.Forms.DateTimePicker();
   this.dtpRTime = new System.Windows.Forms.DateTimePicker();
   this.dtpFileTime = new System.Windows.Forms.DateTimePicker();
   this.txtOvertimeCode = new System.Windows.Forms.TextBox();
   this.cmbHStatus = new System.Windows.Forms.ComboBox();
   this.dtpFileDate = new System.Windows.Forms.DateTimePicker();
   this.txtRRemarks = new System.Windows.Forms.TextBox();
   this.cmbStatus = new System.Windows.Forms.ComboBox();
   this.label13 = new System.Windows.Forms.Label();
   this.lblRApprover = new System.Windows.Forms.Label();
   this.txtReason = new System.Windows.Forms.TextBox();
   this.cmbRStatus = new System.Windows.Forms.ComboBox();
   this.dtpHDate = new System.Windows.Forms.DateTimePicker();
   this.lblRRemarks = new System.Windows.Forms.Label();
   this.label9 = new System.Windows.Forms.Label();
   this.txtHRemarks = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.label6 = new System.Windows.Forms.Label();
   this.lblRStatus = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.dtpRDate = new System.Windows.Forms.DateTimePicker();
   this.label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label18 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.label16 = new System.Windows.Forms.Label();
   this.groupBox2.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnSave
   // 
   this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(295, 479);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(75, 32);
   this.btnSave.TabIndex = 16;
   this.btnSave.Text = "Save  ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(377, 479);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(75, 32);
   this.btnClose.TabIndex = 17;
   this.btnClose.Text = "Close ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // groupBox2
   // 
   this.groupBox2.Controls.Add(this.label8);
   this.groupBox2.Controls.Add(this.txtChargeType);
   this.groupBox2.Controls.Add(this.label11);
   this.groupBox2.Controls.Add(this.txtHApprover);
   this.groupBox2.Controls.Add(this.dtpEndTime);
   this.groupBox2.Controls.Add(this.txtRApprover);
   this.groupBox2.Controls.Add(this.dtpEndDate);
   this.groupBox2.Controls.Add(this.txtRenderedTo);
   this.groupBox2.Controls.Add(this.dtpStartTime);
   this.groupBox2.Controls.Add(this.dtpStartDate);
   this.groupBox2.Controls.Add(this.txtRequestor);
   this.groupBox2.Controls.Add(this.dtpHTime);
   this.groupBox2.Controls.Add(this.dtpRTime);
   this.groupBox2.Controls.Add(this.dtpFileTime);
   this.groupBox2.Controls.Add(this.txtOvertimeCode);
   this.groupBox2.Controls.Add(this.cmbHStatus);
   this.groupBox2.Controls.Add(this.dtpFileDate);
   this.groupBox2.Controls.Add(this.txtRRemarks);
   this.groupBox2.Controls.Add(this.cmbStatus);
   this.groupBox2.Controls.Add(this.label13);
   this.groupBox2.Controls.Add(this.lblRApprover);
   this.groupBox2.Controls.Add(this.txtReason);
   this.groupBox2.Controls.Add(this.cmbRStatus);
   this.groupBox2.Controls.Add(this.dtpHDate);
   this.groupBox2.Controls.Add(this.lblRRemarks);
   this.groupBox2.Controls.Add(this.label9);
   this.groupBox2.Controls.Add(this.txtHRemarks);
   this.groupBox2.Controls.Add(this.label7);
   this.groupBox2.Controls.Add(this.label6);
   this.groupBox2.Controls.Add(this.lblRStatus);
   this.groupBox2.Controls.Add(this.label5);
   this.groupBox2.Controls.Add(this.dtpRDate);
   this.groupBox2.Controls.Add(this.label3);
   this.groupBox2.Controls.Add(this.label2);
   this.groupBox2.Controls.Add(this.label18);
   this.groupBox2.Controls.Add(this.label1);
   this.groupBox2.Controls.Add(this.label16);
   this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox2.Location = new System.Drawing.Point(10, 7);
   this.groupBox2.Name = "groupBox2";
   this.groupBox2.Size = new System.Drawing.Size(440, 465);
   this.groupBox2.TabIndex = 27;
   this.groupBox2.TabStop = false;
   this.groupBox2.Text = "Overtime Details";
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label8.Location = new System.Drawing.Point(10, 103);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(84, 15);
   this.label8.TabIndex = 82;
   this.label8.Text = "Overtime End:";
   // 
   // txtChargeType
   // 
   this.txtChargeType.BackColor = System.Drawing.Color.Ivory;
   this.txtChargeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtChargeType.Location = new System.Drawing.Point(104, 128);
   this.txtChargeType.MaxLength = 6;
   this.txtChargeType.Name = "txtChargeType";
   this.txtChargeType.ReadOnly = true;
   this.txtChargeType.Size = new System.Drawing.Size(240, 21);
   this.txtChargeType.TabIndex = 81;
   this.txtChargeType.TabStop = false;
   // 
   // label11
   // 
   this.label11.AutoSize = true;
   this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label11.Location = new System.Drawing.Point(10, 77);
   this.label11.Name = "label11";
   this.label11.Size = new System.Drawing.Size(87, 15);
   this.label11.TabIndex = 81;
   this.label11.Text = "Overtime Start:";
   // 
   // txtHApprover
   // 
   this.txtHApprover.BackColor = System.Drawing.Color.Ivory;
   this.txtHApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtHApprover.Location = new System.Drawing.Point(104, 363);
   this.txtHApprover.MaxLength = 6;
   this.txtHApprover.Name = "txtHApprover";
   this.txtHApprover.ReadOnly = true;
   this.txtHApprover.Size = new System.Drawing.Size(270, 21);
   this.txtHApprover.TabIndex = 80;
   this.txtHApprover.TabStop = false;
   // 
   // dtpEndTime
   // 
   this.dtpEndTime.CustomFormat = "hh:mm tt";
   this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpEndTime.Location = new System.Drawing.Point(213, 100);
   this.dtpEndTime.Name = "dtpEndTime";
   this.dtpEndTime.ShowUpDown = true;
   this.dtpEndTime.Size = new System.Drawing.Size(79, 21);
   this.dtpEndTime.TabIndex = 4;
   this.dtpEndTime.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
   // 
   // txtRApprover
   // 
   this.txtRApprover.BackColor = System.Drawing.Color.Ivory;
   this.txtRApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtRApprover.Location = new System.Drawing.Point(104, 266);
   this.txtRApprover.MaxLength = 6;
   this.txtRApprover.Name = "txtRApprover";
   this.txtRApprover.ReadOnly = true;
   this.txtRApprover.Size = new System.Drawing.Size(270, 21);
   this.txtRApprover.TabIndex = 79;
   this.txtRApprover.TabStop = false;
   // 
   // dtpEndDate
   // 
   this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
   this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpEndDate.Location = new System.Drawing.Point(104, 100);
   this.dtpEndDate.Name = "dtpEndDate";
   this.dtpEndDate.Size = new System.Drawing.Size(103, 21);
   this.dtpEndDate.TabIndex = 3;
   // 
   // txtRenderedTo
   // 
   this.txtRenderedTo.BackColor = System.Drawing.Color.Ivory;
   this.txtRenderedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtRenderedTo.Location = new System.Drawing.Point(104, 155);
   this.txtRenderedTo.MaxLength = 6;
   this.txtRenderedTo.Name = "txtRenderedTo";
   this.txtRenderedTo.ReadOnly = true;
   this.txtRenderedTo.Size = new System.Drawing.Size(320, 21);
   this.txtRenderedTo.TabIndex = 78;
   this.txtRenderedTo.TabStop = false;
   // 
   // dtpStartTime
   // 
   this.dtpStartTime.CustomFormat = "hh:mm tt";
   this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpStartTime.Location = new System.Drawing.Point(213, 74);
   this.dtpStartTime.Name = "dtpStartTime";
   this.dtpStartTime.ShowUpDown = true;
   this.dtpStartTime.Size = new System.Drawing.Size(79, 21);
   this.dtpStartTime.TabIndex = 2;
   this.dtpStartTime.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
   // 
   // dtpStartDate
   // 
   this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
   this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpStartDate.Location = new System.Drawing.Point(104, 74);
   this.dtpStartDate.Name = "dtpStartDate";
   this.dtpStartDate.Size = new System.Drawing.Size(103, 21);
   this.dtpStartDate.TabIndex = 1;
   // 
   // txtRequestor
   // 
   this.txtRequestor.BackColor = System.Drawing.Color.Ivory;
   this.txtRequestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtRequestor.Location = new System.Drawing.Point(104, 47);
   this.txtRequestor.MaxLength = 6;
   this.txtRequestor.Name = "txtRequestor";
   this.txtRequestor.ReadOnly = true;
   this.txtRequestor.Size = new System.Drawing.Size(270, 21);
   this.txtRequestor.TabIndex = 77;
   this.txtRequestor.TabStop = false;
   // 
   // dtpHTime
   // 
   this.dtpHTime.CustomFormat = "hh:mm tt";
   this.dtpHTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpHTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpHTime.Location = new System.Drawing.Point(335, 390);
   this.dtpHTime.Name = "dtpHTime";
   this.dtpHTime.ShowCheckBox = true;
   this.dtpHTime.ShowUpDown = true;
   this.dtpHTime.Size = new System.Drawing.Size(94, 21);
   this.dtpHTime.TabIndex = 14;
   this.dtpHTime.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
   // 
   // dtpRTime
   // 
   this.dtpRTime.CustomFormat = "hh:mm tt";
   this.dtpRTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpRTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpRTime.Location = new System.Drawing.Point(335, 293);
   this.dtpRTime.Name = "dtpRTime";
   this.dtpRTime.ShowCheckBox = true;
   this.dtpRTime.ShowUpDown = true;
   this.dtpRTime.Size = new System.Drawing.Size(94, 21);
   this.dtpRTime.TabIndex = 10;
   this.dtpRTime.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
   // 
   // dtpFileTime
   // 
   this.dtpFileTime.CustomFormat = "hh:mm tt";
   this.dtpFileTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpFileTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFileTime.Location = new System.Drawing.Point(213, 182);
   this.dtpFileTime.Name = "dtpFileTime";
   this.dtpFileTime.ShowUpDown = true;
   this.dtpFileTime.Size = new System.Drawing.Size(79, 21);
   this.dtpFileTime.TabIndex = 6;
   this.dtpFileTime.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
   // 
   // txtOvertimeCode
   // 
   this.txtOvertimeCode.BackColor = System.Drawing.Color.Ivory;
   this.txtOvertimeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtOvertimeCode.Location = new System.Drawing.Point(104, 20);
   this.txtOvertimeCode.MaxLength = 6;
   this.txtOvertimeCode.Name = "txtOvertimeCode";
   this.txtOvertimeCode.ReadOnly = true;
   this.txtOvertimeCode.Size = new System.Drawing.Size(90, 21);
   this.txtOvertimeCode.TabIndex = 67;
   this.txtOvertimeCode.TabStop = false;
   // 
   // cmbHStatus
   // 
   this.cmbHStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbHStatus.FormattingEnabled = true;
   this.cmbHStatus.Location = new System.Drawing.Point(104, 390);
   this.cmbHStatus.Name = "cmbHStatus";
   this.cmbHStatus.Size = new System.Drawing.Size(102, 23);
   this.cmbHStatus.TabIndex = 12;
   // 
   // dtpFileDate
   // 
   this.dtpFileDate.CustomFormat = "MMM dd, yyyy";
   this.dtpFileDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpFileDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFileDate.Location = new System.Drawing.Point(104, 182);
   this.dtpFileDate.Name = "dtpFileDate";
   this.dtpFileDate.Size = new System.Drawing.Size(103, 21);
   this.dtpFileDate.TabIndex = 5;
   // 
   // txtRRemarks
   // 
   this.txtRRemarks.BackColor = System.Drawing.Color.White;
   this.txtRRemarks.Location = new System.Drawing.Point(104, 321);
   this.txtRRemarks.MaxLength = 255;
   this.txtRRemarks.Multiline = true;
   this.txtRRemarks.Name = "txtRRemarks";
   this.txtRRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtRRemarks.Size = new System.Drawing.Size(320, 36);
   this.txtRRemarks.TabIndex = 11;
   // 
   // cmbStatus
   // 
   this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbStatus.FormattingEnabled = true;
   this.cmbStatus.Location = new System.Drawing.Point(253, 18);
   this.cmbStatus.Name = "cmbStatus";
   this.cmbStatus.Size = new System.Drawing.Size(135, 23);
   this.cmbStatus.TabIndex = 0;
   // 
   // label13
   // 
   this.label13.AutoSize = true;
   this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label13.Location = new System.Drawing.Point(10, 393);
   this.label13.Name = "label13";
   this.label13.Size = new System.Drawing.Size(44, 15);
   this.label13.TabIndex = 66;
   this.label13.Text = "Status:";
   // 
   // lblRApprover
   // 
   this.lblRApprover.AutoSize = true;
   this.lblRApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRApprover.Location = new System.Drawing.Point(10, 265);
   this.lblRApprover.Name = "lblRApprover";
   this.lblRApprover.Size = new System.Drawing.Size(70, 15);
   this.lblRApprover.TabIndex = 20;
   this.lblRApprover.Text = "R Approver:";
   // 
   // txtReason
   // 
   this.txtReason.BackColor = System.Drawing.Color.White;
   this.txtReason.Location = new System.Drawing.Point(104, 209);
   this.txtReason.MaxLength = 255;
   this.txtReason.Multiline = true;
   this.txtReason.Name = "txtReason";
   this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtReason.Size = new System.Drawing.Size(320, 51);
   this.txtReason.TabIndex = 7;
   // 
   // cmbRStatus
   // 
   this.cmbRStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbRStatus.FormattingEnabled = true;
   this.cmbRStatus.Location = new System.Drawing.Point(104, 293);
   this.cmbRStatus.Name = "cmbRStatus";
   this.cmbRStatus.Size = new System.Drawing.Size(102, 23);
   this.cmbRStatus.TabIndex = 8;
   // 
   // dtpHDate
   // 
   this.dtpHDate.CustomFormat = "MMM dd, yyyy";
   this.dtpHDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpHDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpHDate.Location = new System.Drawing.Point(213, 390);
   this.dtpHDate.Name = "dtpHDate";
   this.dtpHDate.ShowCheckBox = true;
   this.dtpHDate.Size = new System.Drawing.Size(117, 21);
   this.dtpHDate.TabIndex = 13;
   // 
   // lblRRemarks
   // 
   this.lblRRemarks.AutoSize = true;
   this.lblRRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRRemarks.Location = new System.Drawing.Point(10, 320);
   this.lblRRemarks.Name = "lblRRemarks";
   this.lblRRemarks.Size = new System.Drawing.Size(72, 15);
   this.lblRRemarks.TabIndex = 25;
   this.lblRRemarks.Text = "R Remarks:";
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label9.Location = new System.Drawing.Point(10, 158);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(82, 15);
   this.label9.TabIndex = 50;
   this.label9.Text = "Rendered To:";
   // 
   // txtHRemarks
   // 
   this.txtHRemarks.BackColor = System.Drawing.Color.White;
   this.txtHRemarks.Location = new System.Drawing.Point(104, 419);
   this.txtHRemarks.MaxLength = 255;
   this.txtHRemarks.Multiline = true;
   this.txtHRemarks.Name = "txtHRemarks";
   this.txtHRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtHRemarks.Size = new System.Drawing.Size(320, 36);
   this.txtHRemarks.TabIndex = 15;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label7.Location = new System.Drawing.Point(10, 185);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(66, 15);
   this.label7.TabIndex = 12;
   this.label7.Text = "Date Filed:";
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label6.Location = new System.Drawing.Point(207, 22);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(44, 15);
   this.label6.TabIndex = 10;
   this.label6.Text = "Status:";
   // 
   // lblRStatus
   // 
   this.lblRStatus.AutoSize = true;
   this.lblRStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRStatus.Location = new System.Drawing.Point(10, 294);
   this.lblRStatus.Name = "lblRStatus";
   this.lblRStatus.Size = new System.Drawing.Size(56, 15);
   this.lblRStatus.TabIndex = 64;
   this.lblRStatus.Text = "R Status:";
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label5.Location = new System.Drawing.Point(10, 131);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(79, 15);
   this.label5.TabIndex = 8;
   this.label5.Text = "Charge Type:";
   // 
   // dtpRDate
   // 
   this.dtpRDate.CustomFormat = "MMM dd, yyyy";
   this.dtpRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpRDate.Location = new System.Drawing.Point(213, 293);
   this.dtpRDate.Name = "dtpRDate";
   this.dtpRDate.ShowCheckBox = true;
   this.dtpRDate.Size = new System.Drawing.Size(117, 21);
   this.dtpRDate.TabIndex = 9;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(10, 206);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(53, 15);
   this.label3.TabIndex = 4;
   this.label3.Text = "Reason:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(10, 48);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(67, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Requestor:";
   // 
   // label18
   // 
   this.label18.AutoSize = true;
   this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label18.Location = new System.Drawing.Point(10, 365);
   this.label18.Name = "label18";
   this.label18.Size = new System.Drawing.Size(70, 15);
   this.label18.TabIndex = 42;
   this.label18.Text = "H Approver:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(10, 22);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(91, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Overtime Code:";
   // 
   // label16
   // 
   this.label16.AutoSize = true;
   this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label16.Location = new System.Drawing.Point(10, 418);
   this.label16.Name = "label16";
   this.label16.Size = new System.Drawing.Size(72, 15);
   this.label16.TabIndex = 44;
   this.label16.Text = "H Remarks:";
   // 
   // frmOvertimeEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(461, 518);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.groupBox2);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmOvertimeEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit Overtime Application";
   this.Load += new System.EventHandler(this.frmOvertimeEdit_Load);
   this.groupBox2.ResumeLayout(false);
   this.groupBox2.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.GroupBox groupBox2;
  private System.Windows.Forms.DateTimePicker dtpHTime;
  private System.Windows.Forms.DateTimePicker dtpRTime;
  private System.Windows.Forms.DateTimePicker dtpFileTime;
  private System.Windows.Forms.TextBox txtOvertimeCode;
  private System.Windows.Forms.ComboBox cmbHStatus;
  private System.Windows.Forms.DateTimePicker dtpFileDate;
  private System.Windows.Forms.TextBox txtRRemarks;
  private System.Windows.Forms.ComboBox cmbStatus;
  private System.Windows.Forms.Label label13;
  private System.Windows.Forms.Label lblRApprover;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.ComboBox cmbRStatus;
  private System.Windows.Forms.DateTimePicker dtpHDate;
  private System.Windows.Forms.Label lblRRemarks;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.TextBox txtHRemarks;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label lblRStatus;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.DateTimePicker dtpRDate;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label18;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label16;
  private System.Windows.Forms.TextBox txtRequestor;
  private System.Windows.Forms.TextBox txtHApprover;
  private System.Windows.Forms.TextBox txtRApprover;
  private System.Windows.Forms.TextBox txtRenderedTo;
  private System.Windows.Forms.TextBox txtChargeType;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.Label label11;
  private System.Windows.Forms.DateTimePicker dtpEndTime;
  private System.Windows.Forms.DateTimePicker dtpEndDate;
  private System.Windows.Forms.DateTimePicker dtpStartTime;
  private System.Windows.Forms.DateTimePicker dtpStartDate;
 }
}