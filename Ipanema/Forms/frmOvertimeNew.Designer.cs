namespace Ipanema.Forms
{
 partial class frmOvertimeNew
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOvertimeNew));
   this.btnSave = new System.Windows.Forms.Button();
   this.btnClose = new System.Windows.Forms.Button();
   this.groupBox2 = new System.Windows.Forms.GroupBox();
   this.label8 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
   this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
   this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
   this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
   this.dtpHTime = new System.Windows.Forms.DateTimePicker();
   this.dtpRTime = new System.Windows.Forms.DateTimePicker();
   this.dtpFileTime = new System.Windows.Forms.DateTimePicker();
   this.txtOBCode = new System.Windows.Forms.TextBox();
   this.cmbHStatus = new System.Windows.Forms.ComboBox();
   this.dtpFileDate = new System.Windows.Forms.DateTimePicker();
   this.txtRRemarks = new System.Windows.Forms.TextBox();
   this.cmbStatus = new System.Windows.Forms.ComboBox();
   this.label13 = new System.Windows.Forms.Label();
   this.cmbRender = new System.Windows.Forms.ComboBox();
   this.lblRApprover = new System.Windows.Forms.Label();
   this.cmbChargeType = new System.Windows.Forms.ComboBox();
   this.txtReason = new System.Windows.Forms.TextBox();
   this.cmbRStatus = new System.Windows.Forms.ComboBox();
   this.cmbRequestor = new System.Windows.Forms.ComboBox();
   this.dtpHDate = new System.Windows.Forms.DateTimePicker();
   this.lblRRemarks = new System.Windows.Forms.Label();
   this.label9 = new System.Windows.Forms.Label();
   this.txtHRemarks = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.cmbHApprover = new System.Windows.Forms.ComboBox();
   this.label6 = new System.Windows.Forms.Label();
   this.lblRStatus = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.cmbRApprover = new System.Windows.Forms.ComboBox();
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
   this.btnSave.Location = new System.Drawing.Point(288, 489);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(75, 32);
   this.btnSave.TabIndex = 21;
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
   this.btnClose.Location = new System.Drawing.Point(372, 489);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(75, 32);
   this.btnClose.TabIndex = 22;
   this.btnClose.Text = "Close ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // groupBox2
   // 
   this.groupBox2.Controls.Add(this.label8);
   this.groupBox2.Controls.Add(this.label4);
   this.groupBox2.Controls.Add(this.dtpEndTime);
   this.groupBox2.Controls.Add(this.dtpEndDate);
   this.groupBox2.Controls.Add(this.dtpStartTime);
   this.groupBox2.Controls.Add(this.dtpStartDate);
   this.groupBox2.Controls.Add(this.dtpHTime);
   this.groupBox2.Controls.Add(this.dtpRTime);
   this.groupBox2.Controls.Add(this.dtpFileTime);
   this.groupBox2.Controls.Add(this.txtOBCode);
   this.groupBox2.Controls.Add(this.cmbHStatus);
   this.groupBox2.Controls.Add(this.dtpFileDate);
   this.groupBox2.Controls.Add(this.txtRRemarks);
   this.groupBox2.Controls.Add(this.cmbStatus);
   this.groupBox2.Controls.Add(this.label13);
   this.groupBox2.Controls.Add(this.cmbRender);
   this.groupBox2.Controls.Add(this.lblRApprover);
   this.groupBox2.Controls.Add(this.cmbChargeType);
   this.groupBox2.Controls.Add(this.txtReason);
   this.groupBox2.Controls.Add(this.cmbRStatus);
   this.groupBox2.Controls.Add(this.cmbRequestor);
   this.groupBox2.Controls.Add(this.dtpHDate);
   this.groupBox2.Controls.Add(this.lblRRemarks);
   this.groupBox2.Controls.Add(this.label9);
   this.groupBox2.Controls.Add(this.txtHRemarks);
   this.groupBox2.Controls.Add(this.label7);
   this.groupBox2.Controls.Add(this.cmbHApprover);
   this.groupBox2.Controls.Add(this.label6);
   this.groupBox2.Controls.Add(this.lblRStatus);
   this.groupBox2.Controls.Add(this.label5);
   this.groupBox2.Controls.Add(this.cmbRApprover);
   this.groupBox2.Controls.Add(this.dtpRDate);
   this.groupBox2.Controls.Add(this.label3);
   this.groupBox2.Controls.Add(this.label2);
   this.groupBox2.Controls.Add(this.label18);
   this.groupBox2.Controls.Add(this.label1);
   this.groupBox2.Controls.Add(this.label16);
   this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox2.Location = new System.Drawing.Point(9, 3);
   this.groupBox2.Name = "groupBox2";
   this.groupBox2.Size = new System.Drawing.Size(437, 477);
   this.groupBox2.TabIndex = 24;
   this.groupBox2.TabStop = false;
   this.groupBox2.Text = "Overtime Details";
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label8.Location = new System.Drawing.Point(10, 105);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(84, 15);
   this.label8.TabIndex = 76;
   this.label8.Text = "Overtime End:";
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(10, 79);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(87, 15);
   this.label4.TabIndex = 75;
   this.label4.Text = "Overtime Start:";
   // 
   // dtpEndTime
   // 
   this.dtpEndTime.CustomFormat = "hh:mm tt";
   this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpEndTime.Location = new System.Drawing.Point(215, 102);
   this.dtpEndTime.Name = "dtpEndTime";
   this.dtpEndTime.ShowUpDown = true;
   this.dtpEndTime.Size = new System.Drawing.Size(79, 21);
   this.dtpEndTime.TabIndex = 5;
   this.dtpEndTime.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
   // 
   // dtpEndDate
   // 
   this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
   this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpEndDate.Location = new System.Drawing.Point(104, 102);
   this.dtpEndDate.Name = "dtpEndDate";
   this.dtpEndDate.Size = new System.Drawing.Size(103, 21);
   this.dtpEndDate.TabIndex = 4;
   // 
   // dtpStartTime
   // 
   this.dtpStartTime.CustomFormat = "hh:mm tt";
   this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpStartTime.Location = new System.Drawing.Point(215, 76);
   this.dtpStartTime.Name = "dtpStartTime";
   this.dtpStartTime.ShowUpDown = true;
   this.dtpStartTime.Size = new System.Drawing.Size(79, 21);
   this.dtpStartTime.TabIndex = 3;
   this.dtpStartTime.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
   // 
   // dtpStartDate
   // 
   this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
   this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpStartDate.Location = new System.Drawing.Point(104, 76);
   this.dtpStartDate.Name = "dtpStartDate";
   this.dtpStartDate.Size = new System.Drawing.Size(103, 21);
   this.dtpStartDate.TabIndex = 2;
   // 
   // dtpHTime
   // 
   this.dtpHTime.CustomFormat = "hh:mm tt";
   this.dtpHTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpHTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpHTime.Location = new System.Drawing.Point(332, 401);
   this.dtpHTime.Name = "dtpHTime";
   this.dtpHTime.ShowUpDown = true;
   this.dtpHTime.Size = new System.Drawing.Size(80, 21);
   this.dtpHTime.TabIndex = 19;
   this.dtpHTime.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
   // 
   // dtpRTime
   // 
   this.dtpRTime.CustomFormat = "hh:mm tt";
   this.dtpRTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpRTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpRTime.Location = new System.Drawing.Point(332, 300);
   this.dtpRTime.Name = "dtpRTime";
   this.dtpRTime.ShowUpDown = true;
   this.dtpRTime.Size = new System.Drawing.Size(80, 21);
   this.dtpRTime.TabIndex = 14;
   this.dtpRTime.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
   // 
   // dtpFileTime
   // 
   this.dtpFileTime.CustomFormat = "hh:mm tt";
   this.dtpFileTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpFileTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFileTime.Location = new System.Drawing.Point(213, 188);
   this.dtpFileTime.Name = "dtpFileTime";
   this.dtpFileTime.ShowUpDown = true;
   this.dtpFileTime.Size = new System.Drawing.Size(89, 21);
   this.dtpFileTime.TabIndex = 9;
   this.dtpFileTime.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
   // 
   // txtOBCode
   // 
   this.txtOBCode.BackColor = System.Drawing.Color.Ivory;
   this.txtOBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtOBCode.Location = new System.Drawing.Point(104, 20);
   this.txtOBCode.MaxLength = 6;
   this.txtOBCode.Name = "txtOBCode";
   this.txtOBCode.ReadOnly = true;
   this.txtOBCode.Size = new System.Drawing.Size(75, 21);
   this.txtOBCode.TabIndex = 67;
   this.txtOBCode.TabStop = false;
   // 
   // cmbHStatus
   // 
   this.cmbHStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbHStatus.FormattingEnabled = true;
   this.cmbHStatus.Location = new System.Drawing.Point(104, 402);
   this.cmbHStatus.Name = "cmbHStatus";
   this.cmbHStatus.Size = new System.Drawing.Size(108, 23);
   this.cmbHStatus.TabIndex = 17;
   // 
   // dtpFileDate
   // 
   this.dtpFileDate.CustomFormat = "MMM dd, yyyy";
   this.dtpFileDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpFileDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFileDate.Location = new System.Drawing.Point(104, 188);
   this.dtpFileDate.Name = "dtpFileDate";
   this.dtpFileDate.Size = new System.Drawing.Size(103, 21);
   this.dtpFileDate.TabIndex = 8;
   // 
   // txtRRemarks
   // 
   this.txtRRemarks.BackColor = System.Drawing.Color.White;
   this.txtRRemarks.Location = new System.Drawing.Point(104, 329);
   this.txtRRemarks.MaxLength = 255;
   this.txtRRemarks.Multiline = true;
   this.txtRRemarks.Name = "txtRRemarks";
   this.txtRRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtRRemarks.Size = new System.Drawing.Size(320, 36);
   this.txtRRemarks.TabIndex = 15;
   // 
   // cmbStatus
   // 
   this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbStatus.FormattingEnabled = true;
   this.cmbStatus.Location = new System.Drawing.Point(235, 18);
   this.cmbStatus.Name = "cmbStatus";
   this.cmbStatus.Size = new System.Drawing.Size(135, 23);
   this.cmbStatus.TabIndex = 0;
   // 
   // label13
   // 
   this.label13.AutoSize = true;
   this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label13.Location = new System.Drawing.Point(10, 404);
   this.label13.Name = "label13";
   this.label13.Size = new System.Drawing.Size(44, 15);
   this.label13.TabIndex = 66;
   this.label13.Text = "Status:";
   // 
   // cmbRender
   // 
   this.cmbRender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbRender.FormattingEnabled = true;
   this.cmbRender.Location = new System.Drawing.Point(104, 159);
   this.cmbRender.Name = "cmbRender";
   this.cmbRender.Size = new System.Drawing.Size(320, 23);
   this.cmbRender.TabIndex = 7;
   this.cmbRender.SelectedIndexChanged += new System.EventHandler(this.cmbRender_SelectedIndexChanged);
   // 
   // lblRApprover
   // 
   this.lblRApprover.AutoSize = true;
   this.lblRApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRApprover.Location = new System.Drawing.Point(10, 272);
   this.lblRApprover.Name = "lblRApprover";
   this.lblRApprover.Size = new System.Drawing.Size(70, 15);
   this.lblRApprover.TabIndex = 20;
   this.lblRApprover.Text = "R Approver:";
   // 
   // cmbChargeType
   // 
   this.cmbChargeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbChargeType.FormattingEnabled = true;
   this.cmbChargeType.Location = new System.Drawing.Point(104, 130);
   this.cmbChargeType.Name = "cmbChargeType";
   this.cmbChargeType.Size = new System.Drawing.Size(274, 23);
   this.cmbChargeType.TabIndex = 6;
   this.cmbChargeType.SelectedIndexChanged += new System.EventHandler(this.cmbChargeType_SelectedIndexChanged);
   // 
   // txtReason
   // 
   this.txtReason.BackColor = System.Drawing.Color.White;
   this.txtReason.Location = new System.Drawing.Point(104, 214);
   this.txtReason.MaxLength = 255;
   this.txtReason.Multiline = true;
   this.txtReason.Name = "txtReason";
   this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtReason.Size = new System.Drawing.Size(320, 51);
   this.txtReason.TabIndex = 10;
   // 
   // cmbRStatus
   // 
   this.cmbRStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbRStatus.FormattingEnabled = true;
   this.cmbRStatus.Location = new System.Drawing.Point(104, 300);
   this.cmbRStatus.Name = "cmbRStatus";
   this.cmbRStatus.Size = new System.Drawing.Size(108, 23);
   this.cmbRStatus.TabIndex = 12;
   // 
   // cmbRequestor
   // 
   this.cmbRequestor.DropDownHeight = 300;
   this.cmbRequestor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbRequestor.FormattingEnabled = true;
   this.cmbRequestor.IntegralHeight = false;
   this.cmbRequestor.Location = new System.Drawing.Point(104, 47);
   this.cmbRequestor.Name = "cmbRequestor";
   this.cmbRequestor.Size = new System.Drawing.Size(290, 23);
   this.cmbRequestor.TabIndex = 1;
   this.cmbRequestor.SelectedIndexChanged += new System.EventHandler(this.cmbRequestor_SelectedIndexChanged);
   // 
   // dtpHDate
   // 
   this.dtpHDate.CustomFormat = "MMM dd, yyyy";
   this.dtpHDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpHDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpHDate.Location = new System.Drawing.Point(219, 401);
   this.dtpHDate.Name = "dtpHDate";
   this.dtpHDate.Size = new System.Drawing.Size(103, 21);
   this.dtpHDate.TabIndex = 18;
   // 
   // lblRRemarks
   // 
   this.lblRRemarks.AutoSize = true;
   this.lblRRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRRemarks.Location = new System.Drawing.Point(10, 328);
   this.lblRRemarks.Name = "lblRRemarks";
   this.lblRRemarks.Size = new System.Drawing.Size(72, 15);
   this.lblRRemarks.TabIndex = 25;
   this.lblRRemarks.Text = "R Remarks:";
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label9.Location = new System.Drawing.Point(10, 163);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(82, 15);
   this.label9.TabIndex = 50;
   this.label9.Text = "Rendered To:";
   // 
   // txtHRemarks
   // 
   this.txtHRemarks.BackColor = System.Drawing.Color.White;
   this.txtHRemarks.Location = new System.Drawing.Point(104, 431);
   this.txtHRemarks.MaxLength = 255;
   this.txtHRemarks.Multiline = true;
   this.txtHRemarks.Name = "txtHRemarks";
   this.txtHRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtHRemarks.Size = new System.Drawing.Size(320, 36);
   this.txtHRemarks.TabIndex = 20;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label7.Location = new System.Drawing.Point(10, 191);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(66, 15);
   this.label7.TabIndex = 12;
   this.label7.Text = "Date Filed:";
   // 
   // cmbHApprover
   // 
   this.cmbHApprover.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbHApprover.FormattingEnabled = true;
   this.cmbHApprover.Location = new System.Drawing.Point(104, 372);
   this.cmbHApprover.Name = "cmbHApprover";
   this.cmbHApprover.Size = new System.Drawing.Size(225, 23);
   this.cmbHApprover.TabIndex = 16;
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label6.Location = new System.Drawing.Point(189, 22);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(44, 15);
   this.label6.TabIndex = 10;
   this.label6.Text = "Status:";
   // 
   // lblRStatus
   // 
   this.lblRStatus.AutoSize = true;
   this.lblRStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRStatus.Location = new System.Drawing.Point(10, 302);
   this.lblRStatus.Name = "lblRStatus";
   this.lblRStatus.Size = new System.Drawing.Size(56, 15);
   this.lblRStatus.TabIndex = 64;
   this.lblRStatus.Text = "R Status:";
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label5.Location = new System.Drawing.Point(10, 134);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(79, 15);
   this.label5.TabIndex = 8;
   this.label5.Text = "Charge Type:";
   // 
   // cmbRApprover
   // 
   this.cmbRApprover.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbRApprover.FormattingEnabled = true;
   this.cmbRApprover.Location = new System.Drawing.Point(104, 271);
   this.cmbRApprover.Name = "cmbRApprover";
   this.cmbRApprover.Size = new System.Drawing.Size(225, 23);
   this.cmbRApprover.TabIndex = 11;
   // 
   // dtpRDate
   // 
   this.dtpRDate.CustomFormat = "MMM dd, yyyy";
   this.dtpRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpRDate.Location = new System.Drawing.Point(219, 300);
   this.dtpRDate.Name = "dtpRDate";
   this.dtpRDate.Size = new System.Drawing.Size(103, 21);
   this.dtpRDate.TabIndex = 13;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(10, 211);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(53, 15);
   this.label3.TabIndex = 4;
   this.label3.Text = "Reason:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(10, 49);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(67, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Requestor:";
   // 
   // label18
   // 
   this.label18.AutoSize = true;
   this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label18.Location = new System.Drawing.Point(10, 374);
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
   this.label16.Location = new System.Drawing.Point(10, 431);
   this.label16.Name = "label16";
   this.label16.Size = new System.Drawing.Size(72, 15);
   this.label16.TabIndex = 44;
   this.label16.Text = "H Remarks:";
   // 
   // frmOvertimeNew
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(455, 530);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.groupBox2);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmOvertimeNew";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Create New Overtime Application";
   this.Load += new System.EventHandler(this.frmOvertimeNew_Load);
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
  private System.Windows.Forms.TextBox txtOBCode;
  private System.Windows.Forms.ComboBox cmbHStatus;
  private System.Windows.Forms.DateTimePicker dtpFileDate;
  private System.Windows.Forms.TextBox txtRRemarks;
  private System.Windows.Forms.ComboBox cmbStatus;
  private System.Windows.Forms.Label label13;
  private System.Windows.Forms.ComboBox cmbRender;
  private System.Windows.Forms.Label lblRApprover;
  private System.Windows.Forms.ComboBox cmbChargeType;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.ComboBox cmbRStatus;
  private System.Windows.Forms.ComboBox cmbRequestor;
  private System.Windows.Forms.DateTimePicker dtpHDate;
  private System.Windows.Forms.Label lblRRemarks;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.TextBox txtHRemarks;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.ComboBox cmbHApprover;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label lblRStatus;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.ComboBox cmbRApprover;
  private System.Windows.Forms.DateTimePicker dtpRDate;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label18;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label16;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.DateTimePicker dtpEndTime;
  private System.Windows.Forms.DateTimePicker dtpEndDate;
  private System.Windows.Forms.DateTimePicker dtpStartTime;
  private System.Windows.Forms.DateTimePicker dtpStartDate;
 }
}