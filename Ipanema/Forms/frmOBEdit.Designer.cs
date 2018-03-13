namespace Ipanema.Forms
{
 partial class frmOBEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOBEdit));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHApprover = new System.Windows.Forms.TextBox();
            this.txtRenderTo = new System.Windows.Forms.TextBox();
            this.dtpHTime = new System.Windows.Forms.DateTimePicker();
            this.txtOBtype = new System.Windows.Forms.TextBox();
            this.cmbRStatus = new System.Windows.Forms.ComboBox();
            this.txtRequestor = new System.Windows.Forms.TextBox();
            this.txtRApprover = new System.Windows.Forms.TextBox();
            this.dtpHDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFileTime = new System.Windows.Forms.DateTimePicker();
            this.dtpRTime = new System.Windows.Forms.DateTimePicker();
            this.txtOBCode = new System.Windows.Forms.TextBox();
            this.dtpFileDate = new System.Windows.Forms.DateTimePicker();
            this.lblRRemarks = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtHRemarks = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblRApprover = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbHStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lvOBDetails = new System.Windows.Forms.ListView();
            this.chFocusDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKeyIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKeyOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabOB = new System.Windows.Forms.TabControl();
            this.tbpOB = new System.Windows.Forms.TabPage();
            this.tbpOBDetails = new System.Windows.Forms.TabPage();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabOB.SuspendLayout();
            this.tbpOB.SuspendLayout();
            this.tbpOBDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(351, 515);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 38);
            this.btnSave.TabIndex = 22;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(436, 515);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 38);
            this.btnClose.TabIndex = 23;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHApprover);
            this.groupBox2.Controls.Add(this.txtRenderTo);
            this.groupBox2.Controls.Add(this.dtpHTime);
            this.groupBox2.Controls.Add(this.txtOBtype);
            this.groupBox2.Controls.Add(this.cmbRStatus);
            this.groupBox2.Controls.Add(this.txtRequestor);
            this.groupBox2.Controls.Add(this.txtRApprover);
            this.groupBox2.Controls.Add(this.dtpHDate);
            this.groupBox2.Controls.Add(this.dtpFileTime);
            this.groupBox2.Controls.Add(this.dtpRTime);
            this.groupBox2.Controls.Add(this.txtOBCode);
            this.groupBox2.Controls.Add(this.dtpFileDate);
            this.groupBox2.Controls.Add(this.lblRRemarks);
            this.groupBox2.Controls.Add(this.cmbStatus);
            this.groupBox2.Controls.Add(this.txtHRemarks);
            this.groupBox2.Controls.Add(this.txtReason);
            this.groupBox2.Controls.Add(this.lblRApprover);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbHStatus);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblRStatus);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRRemarks);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpRDate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 457);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OB Details";
            // 
            // txtHApprover
            // 
            this.txtHApprover.BackColor = System.Drawing.Color.Ivory;
            this.txtHApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHApprover.Location = new System.Drawing.Point(98, 335);
            this.txtHApprover.MaxLength = 6;
            this.txtHApprover.Name = "txtHApprover";
            this.txtHApprover.ReadOnly = true;
            this.txtHApprover.Size = new System.Drawing.Size(366, 21);
            this.txtHApprover.TabIndex = 71;
            this.txtHApprover.TabStop = false;
            // 
            // txtRenderTo
            // 
            this.txtRenderTo.BackColor = System.Drawing.Color.Ivory;
            this.txtRenderTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenderTo.Location = new System.Drawing.Point(98, 103);
            this.txtRenderTo.MaxLength = 6;
            this.txtRenderTo.Name = "txtRenderTo";
            this.txtRenderTo.ReadOnly = true;
            this.txtRenderTo.Size = new System.Drawing.Size(366, 21);
            this.txtRenderTo.TabIndex = 71;
            this.txtRenderTo.TabStop = false;
            // 
            // dtpHTime
            // 
            this.dtpHTime.CustomFormat = "hh:mm tt";
            this.dtpHTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHTime.Location = new System.Drawing.Point(384, 364);
            this.dtpHTime.Name = "dtpHTime";
            this.dtpHTime.ShowUpDown = true;
            this.dtpHTime.Size = new System.Drawing.Size(80, 21);
            this.dtpHTime.TabIndex = 70;
            this.dtpHTime.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
            // 
            // txtOBtype
            // 
            this.txtOBtype.BackColor = System.Drawing.Color.Ivory;
            this.txtOBtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOBtype.Location = new System.Drawing.Point(98, 75);
            this.txtOBtype.MaxLength = 6;
            this.txtOBtype.Name = "txtOBtype";
            this.txtOBtype.ReadOnly = true;
            this.txtOBtype.Size = new System.Drawing.Size(366, 21);
            this.txtOBtype.TabIndex = 70;
            this.txtOBtype.TabStop = false;
            // 
            // cmbRStatus
            // 
            this.cmbRStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRStatus.FormattingEnabled = true;
            this.cmbRStatus.Location = new System.Drawing.Point(98, 245);
            this.cmbRStatus.Name = "cmbRStatus";
            this.cmbRStatus.Size = new System.Drawing.Size(108, 23);
            this.cmbRStatus.TabIndex = 8;
            // 
            // txtRequestor
            // 
            this.txtRequestor.BackColor = System.Drawing.Color.Ivory;
            this.txtRequestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestor.Location = new System.Drawing.Point(98, 47);
            this.txtRequestor.MaxLength = 6;
            this.txtRequestor.Name = "txtRequestor";
            this.txtRequestor.ReadOnly = true;
            this.txtRequestor.Size = new System.Drawing.Size(366, 21);
            this.txtRequestor.TabIndex = 69;
            this.txtRequestor.TabStop = false;
            // 
            // txtRApprover
            // 
            this.txtRApprover.BackColor = System.Drawing.Color.Ivory;
            this.txtRApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRApprover.Location = new System.Drawing.Point(98, 218);
            this.txtRApprover.MaxLength = 6;
            this.txtRApprover.Name = "txtRApprover";
            this.txtRApprover.ReadOnly = true;
            this.txtRApprover.Size = new System.Drawing.Size(366, 21);
            this.txtRApprover.TabIndex = 70;
            this.txtRApprover.TabStop = false;
            // 
            // dtpHDate
            // 
            this.dtpHDate.CustomFormat = "MMM dd, yyyy";
            this.dtpHDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHDate.Location = new System.Drawing.Point(221, 364);
            this.dtpHDate.Name = "dtpHDate";
            this.dtpHDate.Size = new System.Drawing.Size(152, 21);
            this.dtpHDate.TabIndex = 11;
            // 
            // dtpFileTime
            // 
            this.dtpFileTime.CustomFormat = "hh:mm tt";
            this.dtpFileTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFileTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFileTime.Location = new System.Drawing.Point(379, 130);
            this.dtpFileTime.Name = "dtpFileTime";
            this.dtpFileTime.ShowUpDown = true;
            this.dtpFileTime.Size = new System.Drawing.Size(85, 21);
            this.dtpFileTime.TabIndex = 68;
            this.dtpFileTime.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
            // 
            // dtpRTime
            // 
            this.dtpRTime.CustomFormat = "hh:mm tt";
            this.dtpRTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRTime.Location = new System.Drawing.Point(379, 245);
            this.dtpRTime.Name = "dtpRTime";
            this.dtpRTime.ShowUpDown = true;
            this.dtpRTime.Size = new System.Drawing.Size(85, 21);
            this.dtpRTime.TabIndex = 69;
            this.dtpRTime.Value = new System.DateTime(2009, 1, 24, 9, 0, 0, 0);
            // 
            // txtOBCode
            // 
            this.txtOBCode.BackColor = System.Drawing.Color.Ivory;
            this.txtOBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOBCode.Location = new System.Drawing.Point(98, 20);
            this.txtOBCode.MaxLength = 6;
            this.txtOBCode.Name = "txtOBCode";
            this.txtOBCode.ReadOnly = true;
            this.txtOBCode.Size = new System.Drawing.Size(116, 21);
            this.txtOBCode.TabIndex = 67;
            this.txtOBCode.TabStop = false;
            // 
            // dtpFileDate
            // 
            this.dtpFileDate.CustomFormat = "MMM dd, yyyy";
            this.dtpFileDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFileDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFileDate.Location = new System.Drawing.Point(98, 130);
            this.dtpFileDate.Name = "dtpFileDate";
            this.dtpFileDate.Size = new System.Drawing.Size(168, 21);
            this.dtpFileDate.TabIndex = 4;
            // 
            // lblRRemarks
            // 
            this.lblRRemarks.AutoSize = true;
            this.lblRRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRRemarks.Location = new System.Drawing.Point(8, 274);
            this.lblRRemarks.Name = "lblRRemarks";
            this.lblRRemarks.Size = new System.Drawing.Size(72, 15);
            this.lblRRemarks.TabIndex = 25;
            this.lblRRemarks.Text = "R Remarks:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(326, 18);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(138, 23);
            this.cmbStatus.TabIndex = 0;
            // 
            // txtHRemarks
            // 
            this.txtHRemarks.BackColor = System.Drawing.Color.White;
            this.txtHRemarks.Location = new System.Drawing.Point(98, 394);
            this.txtHRemarks.MaxLength = 255;
            this.txtHRemarks.Multiline = true;
            this.txtHRemarks.Name = "txtHRemarks";
            this.txtHRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHRemarks.Size = new System.Drawing.Size(366, 52);
            this.txtHRemarks.TabIndex = 13;
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.White;
            this.txtReason.Location = new System.Drawing.Point(98, 157);
            this.txtReason.MaxLength = 255;
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.Size = new System.Drawing.Size(366, 54);
            this.txtReason.TabIndex = 5;
            // 
            // lblRApprover
            // 
            this.lblRApprover.AutoSize = true;
            this.lblRApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRApprover.Location = new System.Drawing.Point(8, 220);
            this.lblRApprover.Name = "lblRApprover";
            this.lblRApprover.Size = new System.Drawing.Size(70, 15);
            this.lblRApprover.TabIndex = 20;
            this.lblRApprover.Text = "R Approver:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 50;
            this.label9.Text = "Rendered To:";
            // 
            // cmbHStatus
            // 
            this.cmbHStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHStatus.FormattingEnabled = true;
            this.cmbHStatus.Location = new System.Drawing.Point(98, 364);
            this.cmbHStatus.Name = "cmbHStatus";
            this.cmbHStatus.Size = new System.Drawing.Size(108, 23);
            this.cmbHStatus.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date Filed:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 394);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 15);
            this.label16.TabIndex = 44;
            this.label16.Text = "H Remarks:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status:";
            // 
            // lblRStatus
            // 
            this.lblRStatus.AutoSize = true;
            this.lblRStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRStatus.Location = new System.Drawing.Point(8, 247);
            this.lblRStatus.Name = "lblRStatus";
            this.lblRStatus.Size = new System.Drawing.Size(56, 15);
            this.lblRStatus.TabIndex = 64;
            this.lblRStatus.Text = "R Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "OB Type:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 337);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 15);
            this.label18.TabIndex = 42;
            this.label18.Text = "H Approver:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reason:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 66;
            this.label13.Text = "H Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Requestor:";
            // 
            // txtRRemarks
            // 
            this.txtRRemarks.BackColor = System.Drawing.Color.White;
            this.txtRRemarks.Location = new System.Drawing.Point(98, 275);
            this.txtRRemarks.MaxLength = 255;
            this.txtRRemarks.Multiline = true;
            this.txtRRemarks.Name = "txtRRemarks";
            this.txtRRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRRemarks.Size = new System.Drawing.Size(366, 52);
            this.txtRRemarks.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "OB Code:";
            // 
            // dtpRDate
            // 
            this.dtpRDate.CustomFormat = "MMM dd, yyyy";
            this.dtpRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRDate.Location = new System.Drawing.Point(221, 245);
            this.dtpRDate.Name = "dtpRDate";
            this.dtpRDate.Size = new System.Drawing.Size(152, 21);
            this.dtpRDate.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.lvOBDetails);
            this.groupBox3.Location = new System.Drawing.Point(11, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 457);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OB Schedule Details";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(11, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Add    ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(260, 420);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 28);
            this.btnRefresh.TabIndex = 49;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(94, 420);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 28);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "Edit    ";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(177, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lvOBDetails
            // 
            this.lvOBDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFocusDate,
            this.chKeyIn,
            this.chKeyOut});
            this.lvOBDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOBDetails.FullRowSelect = true;
            this.lvOBDetails.GridLines = true;
            this.lvOBDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvOBDetails.HideSelection = false;
            this.lvOBDetails.Location = new System.Drawing.Point(12, 22);
            this.lvOBDetails.Name = "lvOBDetails";
            this.lvOBDetails.Size = new System.Drawing.Size(454, 392);
            this.lvOBDetails.TabIndex = 1;
            this.lvOBDetails.UseCompatibleStateImageBehavior = false;
            this.lvOBDetails.View = System.Windows.Forms.View.Details;
            this.lvOBDetails.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // chFocusDate
            // 
            this.chFocusDate.Text = "Focus Date";
            this.chFocusDate.Width = 132;
            // 
            // chKeyIn
            // 
            this.chKeyIn.Text = "Time In";
            this.chKeyIn.Width = 150;
            // 
            // chKeyOut
            // 
            this.chKeyOut.Text = "Time Out";
            this.chKeyOut.Width = 150;
            // 
            // tabOB
            // 
            this.tabOB.Controls.Add(this.tbpOB);
            this.tabOB.Controls.Add(this.tbpOBDetails);
            this.tabOB.Location = new System.Drawing.Point(9, 9);
            this.tabOB.Name = "tabOB";
            this.tabOB.SelectedIndex = 0;
            this.tabOB.Size = new System.Drawing.Size(509, 499);
            this.tabOB.TabIndex = 73;
            // 
            // tbpOB
            // 
            this.tbpOB.BackColor = System.Drawing.Color.AliceBlue;
            this.tbpOB.Controls.Add(this.groupBox2);
            this.tbpOB.Location = new System.Drawing.Point(4, 24);
            this.tbpOB.Name = "tbpOB";
            this.tbpOB.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOB.Size = new System.Drawing.Size(501, 471);
            this.tbpOB.TabIndex = 0;
            this.tbpOB.Text = "OB Details";
            // 
            // tbpOBDetails
            // 
            this.tbpOBDetails.BackColor = System.Drawing.Color.AliceBlue;
            this.tbpOBDetails.Controls.Add(this.groupBox3);
            this.tbpOBDetails.Location = new System.Drawing.Point(4, 24);
            this.tbpOBDetails.Name = "tbpOBDetails";
            this.tbpOBDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOBDetails.Size = new System.Drawing.Size(501, 471);
            this.tbpOBDetails.TabIndex = 1;
            this.tbpOBDetails.Text = "Schedule Details";
            // 
            // frmOBEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(529, 562);
            this.Controls.Add(this.tabOB);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOBEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OB Application Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOBEdit_FormClosing);
            this.Load += new System.EventHandler(this.frmOBEdit_Load);
            this.Shown += new System.EventHandler(this.frmOBEdit_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabOB.ResumeLayout(false);
            this.tbpOB.ResumeLayout(false);
            this.tbpOBDetails.ResumeLayout(false);
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
  private System.Windows.Forms.GroupBox groupBox3;
  private System.Windows.Forms.ListView lvOBDetails;
  private System.Windows.Forms.ColumnHeader chFocusDate;
  private System.Windows.Forms.ColumnHeader chKeyIn;
  private System.Windows.Forms.ColumnHeader chKeyOut;
  private System.Windows.Forms.Button btnAdd;
  private System.Windows.Forms.Button btnRefresh;
  private System.Windows.Forms.Button btnEdit;
  private System.Windows.Forms.Button btnDelete;
  private System.Windows.Forms.TextBox txtRequestor;
  private System.Windows.Forms.TextBox txtRenderTo;
  private System.Windows.Forms.TextBox txtOBtype;
  private System.Windows.Forms.TextBox txtHApprover;
  private System.Windows.Forms.TextBox txtRApprover;
  private System.Windows.Forms.TabControl tabOB;
  private System.Windows.Forms.TabPage tbpOB;
  private System.Windows.Forms.TabPage tbpOBDetails;
 }
}