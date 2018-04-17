namespace Ipanema.Forms
{
 partial class frmEmployeeNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeNew));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.label89 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cmbEmployeeType = new System.Windows.Forms.ComboBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.cmbCivilStatus = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.txtEmailOfficial = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.dtpRegular = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnScheduleDetails = new System.Windows.Forms.Button();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.cmbRC = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.label66 = new System.Windows.Forms.Label();
            this.cmbEmploymentStatus = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.cmbJGCode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.chkBillable = new System.Windows.Forms.CheckBox();
            this.btnGenerateEmployeeNumber = new System.Windows.Forms.Button();
            this.btnGenerateUsername = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRecruitmentSourceAdd = new System.Windows.Forms.Button();
            this.txtRecruitmentRemarks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbRecruitmentSource = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPersonal = new System.Windows.Forms.TabControl();
            this.tbpPersonal = new System.Windows.Forms.TabPage();
            this.tabEmployment = new System.Windows.Forms.TabControl();
            this.tbpEmployment = new System.Windows.Forms.TabPage();
            this.tabPersonal.SuspendLayout();
            this.tbpPersonal.SuspendLayout();
            this.tabEmployment.SuspendLayout();
            this.tbpEmployment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(854, 570);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 38);
            this.btnClose.TabIndex = 28;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(767, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 38);
            this.btnSave.TabIndex = 27;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(96, 157);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(125, 19);
            this.chkEnabled.TabIndex = 7;
            this.chkEnabled.Text = "Enable this record";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.Location = new System.Drawing.Point(229, 20);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(68, 15);
            this.label89.TabIndex = 30;
            this.label89.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(301, 17);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(209, 21);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.BackColor = System.Drawing.Color.White;
            this.txtEmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNumber.Location = new System.Drawing.Point(95, 17);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(90, 21);
            this.txtEmployeeNumber.TabIndex = 0;
            this.txtEmployeeNumber.TabStop = false;
            this.txtEmployeeNumber.TextChanged += new System.EventHandler(this.txtEmployeeNumber_TextChanged);
            this.txtEmployeeNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeNumber_KeyDown);
            this.txtEmployeeNumber.Leave += new System.EventHandler(this.txtEmployeeNumber_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(351, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(603, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Middle Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Company:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(491, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Position:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(95, 48);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(249, 21);
            this.txtFirstName.TabIndex = 0;
            // 
            // cmbEmployeeType
            // 
            this.cmbEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployeeType.FormattingEnabled = true;
            this.cmbEmployeeType.Location = new System.Drawing.Point(578, 136);
            this.cmbEmployeeType.Name = "cmbEmployeeType";
            this.cmbEmployeeType.Size = new System.Drawing.Size(236, 23);
            this.cmbEmployeeType.TabIndex = 22;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.White;
            this.txtMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(605, 48);
            this.txtMiddleName.MaxLength = 30;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(243, 21);
            this.txtMiddleName.TabIndex = 2;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(491, 144);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(36, 15);
            this.label30.TabIndex = 19;
            this.label30.Text = "Type:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(353, 48);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(243, 21);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // cmbCompany
            // 
            this.cmbCompany.BackColor = System.Drawing.Color.White;
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(95, 45);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(306, 23);
            this.cmbCompany.TabIndex = 11;
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.White;
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(578, 106);
            this.txtPosition.MaxLength = 150;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(236, 21);
            this.txtPosition.TabIndex = 20;
            // 
            // cmbCivilStatus
            // 
            this.cmbCivilStatus.BackColor = System.Drawing.Color.White;
            this.cmbCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCivilStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCivilStatus.FormattingEnabled = true;
            this.cmbCivilStatus.Location = new System.Drawing.Point(351, 125);
            this.cmbCivilStatus.Name = "cmbCivilStatus";
            this.cmbCivilStatus.Size = new System.Drawing.Size(104, 23);
            this.cmbCivilStatus.TabIndex = 6;
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.White;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(351, 94);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(104, 23);
            this.cmbGender.TabIndex = 4;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(276, 128);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(69, 15);
            this.label36.TabIndex = 55;
            this.label36.Text = "Civil Status:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(13, 97);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 15);
            this.label29.TabIndex = 20;
            this.label29.Text = "Nick Name:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(13, 128);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 15);
            this.label27.TabIndex = 22;
            this.label27.Text = "Date of Birth:";
            // 
            // txtNickName
            // 
            this.txtNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickName.Location = new System.Drawing.Point(95, 94);
            this.txtNickName.MaxLength = 30;
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(164, 21);
            this.txtNickName.TabIndex = 3;
            this.txtNickName.TextChanged += new System.EventHandler(this.txtNickName_TextChanged);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dtpBirthDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpBirthDate.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dtpBirthDate.CustomFormat = "MMM dd, yyyy";
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(95, 125);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(119, 21);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(276, 97);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(51, 15);
            this.label25.TabIndex = 40;
            this.label25.Text = "Gender:";
            // 
            // txtEmailOfficial
            // 
            this.txtEmailOfficial.BackColor = System.Drawing.Color.White;
            this.txtEmailOfficial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailOfficial.Location = new System.Drawing.Point(95, 16);
            this.txtEmailOfficial.MaxLength = 40;
            this.txtEmailOfficial.Name = "txtEmailOfficial";
            this.txtEmailOfficial.Size = new System.Drawing.Size(306, 21);
            this.txtEmailOfficial.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(13, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 15);
            this.label20.TabIndex = 20;
            this.label20.Text = "Email:";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.Location = new System.Drawing.Point(491, 54);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(62, 15);
            this.label92.TabIndex = 84;
            this.label92.Text = "Schedule:";
            this.label92.Click += new System.EventHandler(this.label92_Click);
            // 
            // dtpRegular
            // 
            this.dtpRegular.CustomFormat = "MMM dd, yyyy";
            this.dtpRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegular.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegular.Location = new System.Drawing.Point(578, 16);
            this.dtpRegular.Name = "dtpRegular";
            this.dtpRegular.Size = new System.Drawing.Size(236, 21);
            this.dtpRegular.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(491, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 89;
            this.label5.Text = "Permanency:";
            // 
            // btnScheduleDetails
            // 
            this.btnScheduleDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnScheduleDetails.Image")));
            this.btnScheduleDetails.Location = new System.Drawing.Point(790, 46);
            this.btnScheduleDetails.Name = "btnScheduleDetails";
            this.btnScheduleDetails.Size = new System.Drawing.Size(24, 24);
            this.btnScheduleDetails.TabIndex = 19;
            this.btnScheduleDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScheduleDetails.UseVisualStyleBackColor = true;
            this.btnScheduleDetails.Click += new System.EventHandler(this.btnScheduleDetails_Click);
            // 
            // txtAssignment
            // 
            this.txtAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignment.Location = new System.Drawing.Point(578, 79);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(236, 21);
            this.txtAssignment.TabIndex = 17;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(491, 85);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(74, 15);
            this.label64.TabIndex = 19;
            this.label64.Text = "Assignment:";
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.BackColor = System.Drawing.Color.White;
            this.cmbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Location = new System.Drawing.Point(578, 46);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(206, 23);
            this.cmbSchedule.TabIndex = 18;
            // 
            // cmbDivision
            // 
            this.cmbDivision.BackColor = System.Drawing.Color.White;
            this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(578, 167);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(320, 23);
            this.cmbDivision.TabIndex = 15;
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
            // 
            // cmbRC
            // 
            this.cmbRC.BackColor = System.Drawing.Color.White;
            this.cmbRC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRC.Enabled = false;
            this.cmbRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRC.FormattingEnabled = true;
            this.cmbRC.Location = new System.Drawing.Point(95, 196);
            this.cmbRC.Name = "cmbRC";
            this.cmbRC.Size = new System.Drawing.Size(330, 23);
            this.cmbRC.TabIndex = 24;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.Black;
            this.label60.Location = new System.Drawing.Point(491, 175);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(53, 15);
            this.label60.TabIndex = 29;
            this.label60.Text = "Division:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.Black;
            this.label63.Location = new System.Drawing.Point(13, 204);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(27, 15);
            this.label63.TabIndex = 35;
            this.label63.Text = "RC:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.Black;
            this.label61.Location = new System.Drawing.Point(491, 204);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(44, 15);
            this.label61.TabIndex = 31;
            this.label61.Text = "Group:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.BackColor = System.Drawing.Color.White;
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(577, 225);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(321, 23);
            this.cmbDepartment.TabIndex = 16;
            // 
            // cmbGroup
            // 
            this.cmbGroup.BackColor = System.Drawing.Color.White;
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(578, 196);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(320, 23);
            this.cmbGroup.TabIndex = 23;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.Black;
            this.label62.Location = new System.Drawing.Point(490, 233);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(75, 15);
            this.label62.TabIndex = 33;
            this.label62.Text = "Department:";
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.CustomFormat = "MMM dd, yyyy";
            this.dtpDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateStart.Location = new System.Drawing.Point(95, 107);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(159, 21);
            this.dtpDateStart.TabIndex = 13;
            this.dtpDateStart.ValueChanged += new System.EventHandler(this.dtpDateStart_ValueChanged);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.Black;
            this.label66.Location = new System.Drawing.Point(13, 108);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(64, 15);
            this.label66.TabIndex = 23;
            this.label66.Text = "Start Date:";
            // 
            // cmbEmploymentStatus
            // 
            this.cmbEmploymentStatus.BackColor = System.Drawing.Color.White;
            this.cmbEmploymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmploymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmploymentStatus.FormattingEnabled = true;
            this.cmbEmploymentStatus.Location = new System.Drawing.Point(95, 136);
            this.cmbEmploymentStatus.Name = "cmbEmploymentStatus";
            this.cmbEmploymentStatus.Size = new System.Drawing.Size(159, 23);
            this.cmbEmploymentStatus.TabIndex = 14;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.Black;
            this.label65.Location = new System.Drawing.Point(13, 139);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(44, 15);
            this.label65.TabIndex = 21;
            this.label65.Text = "Status:";
            // 
            // cmbJGCode
            // 
            this.cmbJGCode.BackColor = System.Drawing.Color.White;
            this.cmbJGCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJGCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJGCode.FormattingEnabled = true;
            this.cmbJGCode.Location = new System.Drawing.Point(95, 76);
            this.cmbJGCode.Name = "cmbJGCode";
            this.cmbJGCode.Size = new System.Drawing.Size(159, 23);
            this.cmbJGCode.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Job Grade:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(856, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 60;
            this.label12.Text = "M.I.";
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.BackColor = System.Drawing.Color.White;
            this.txtMiddleInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleInitial.Location = new System.Drawing.Point(857, 48);
            this.txtMiddleInitial.MaxLength = 2;
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(44, 21);
            this.txtMiddleInitial.TabIndex = 59;
            // 
            // chkBillable
            // 
            this.chkBillable.AutoSize = true;
            this.chkBillable.Location = new System.Drawing.Point(223, 157);
            this.chkBillable.Name = "chkBillable";
            this.chkBillable.Size = new System.Drawing.Size(67, 19);
            this.chkBillable.TabIndex = 9;
            this.chkBillable.Text = "Billable";
            this.chkBillable.UseVisualStyleBackColor = true;
            // 
            // btnGenerateEmployeeNumber
            // 
            this.btnGenerateEmployeeNumber.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateEmployeeNumber.Image")));
            this.btnGenerateEmployeeNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateEmployeeNumber.Location = new System.Drawing.Point(189, 16);
            this.btnGenerateEmployeeNumber.Name = "btnGenerateEmployeeNumber";
            this.btnGenerateEmployeeNumber.Size = new System.Drawing.Size(24, 24);
            this.btnGenerateEmployeeNumber.TabIndex = 58;
            this.btnGenerateEmployeeNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerateEmployeeNumber.UseVisualStyleBackColor = true;
            this.btnGenerateEmployeeNumber.Click += new System.EventHandler(this.btnGenerateEmployeeNumber_Click);
            // 
            // btnGenerateUsername
            // 
            this.btnGenerateUsername.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateUsername.Image")));
            this.btnGenerateUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateUsername.Location = new System.Drawing.Point(514, 16);
            this.btnGenerateUsername.Name = "btnGenerateUsername";
            this.btnGenerateUsername.Size = new System.Drawing.Size(24, 24);
            this.btnGenerateUsername.TabIndex = 57;
            this.btnGenerateUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerateUsername.UseVisualStyleBackColor = true;
            this.btnGenerateUsername.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(94, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "First Name";
            // 
            // btnRecruitmentSourceAdd
            // 
            this.btnRecruitmentSourceAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnRecruitmentSourceAdd.Image")));
            this.btnRecruitmentSourceAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecruitmentSourceAdd.Location = new System.Drawing.Point(407, 228);
            this.btnRecruitmentSourceAdd.Name = "btnRecruitmentSourceAdd";
            this.btnRecruitmentSourceAdd.Size = new System.Drawing.Size(24, 24);
            this.btnRecruitmentSourceAdd.TabIndex = 59;
            this.btnRecruitmentSourceAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecruitmentSourceAdd.UseVisualStyleBackColor = true;
            this.btnRecruitmentSourceAdd.Click += new System.EventHandler(this.btnRecruitmentSourceAdd_Click);
            // 
            // txtRecruitmentRemarks
            // 
            this.txtRecruitmentRemarks.BackColor = System.Drawing.Color.White;
            this.txtRecruitmentRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecruitmentRemarks.Location = new System.Drawing.Point(95, 260);
            this.txtRecruitmentRemarks.MaxLength = 40;
            this.txtRecruitmentRemarks.Name = "txtRecruitmentRemarks";
            this.txtRecruitmentRemarks.Size = new System.Drawing.Size(803, 21);
            this.txtRecruitmentRemarks.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Remarks:";
            // 
            // cmbRecruitmentSource
            // 
            this.cmbRecruitmentSource.BackColor = System.Drawing.Color.White;
            this.cmbRecruitmentSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecruitmentSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecruitmentSource.FormattingEnabled = true;
            this.cmbRecruitmentSource.Location = new System.Drawing.Point(95, 229);
            this.cmbRecruitmentSource.Name = "cmbRecruitmentSource";
            this.cmbRecruitmentSource.Size = new System.Drawing.Size(306, 23);
            this.cmbRecruitmentSource.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Source:";
            // 
            // tabPersonal
            // 
            this.tabPersonal.Controls.Add(this.tbpPersonal);
            this.tabPersonal.Location = new System.Drawing.Point(10, 11);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.SelectedIndex = 0;
            this.tabPersonal.Size = new System.Drawing.Size(924, 215);
            this.tabPersonal.TabIndex = 88;
            // 
            // tbpPersonal
            // 
            this.tbpPersonal.Controls.Add(this.chkBillable);
            this.tbpPersonal.Controls.Add(this.txtEmployeeNumber);
            this.tbpPersonal.Controls.Add(this.label12);
            this.tbpPersonal.Controls.Add(this.dtpBirthDate);
            this.tbpPersonal.Controls.Add(this.txtMiddleInitial);
            this.tbpPersonal.Controls.Add(this.label27);
            this.tbpPersonal.Controls.Add(this.btnGenerateEmployeeNumber);
            this.tbpPersonal.Controls.Add(this.label29);
            this.tbpPersonal.Controls.Add(this.btnGenerateUsername);
            this.tbpPersonal.Controls.Add(this.txtNickName);
            this.tbpPersonal.Controls.Add(this.label9);
            this.tbpPersonal.Controls.Add(this.label89);
            this.tbpPersonal.Controls.Add(this.cmbCivilStatus);
            this.tbpPersonal.Controls.Add(this.label25);
            this.tbpPersonal.Controls.Add(this.txtFirstName);
            this.tbpPersonal.Controls.Add(this.txtUsername);
            this.tbpPersonal.Controls.Add(this.txtMiddleName);
            this.tbpPersonal.Controls.Add(this.label1);
            this.tbpPersonal.Controls.Add(this.label4);
            this.tbpPersonal.Controls.Add(this.label36);
            this.tbpPersonal.Controls.Add(this.cmbGender);
            this.tbpPersonal.Controls.Add(this.chkEnabled);
            this.tbpPersonal.Controls.Add(this.label3);
            this.tbpPersonal.Controls.Add(this.label2);
            this.tbpPersonal.Controls.Add(this.txtLastName);
            this.tbpPersonal.Location = new System.Drawing.Point(4, 24);
            this.tbpPersonal.Name = "tbpPersonal";
            this.tbpPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPersonal.Size = new System.Drawing.Size(916, 187);
            this.tbpPersonal.TabIndex = 0;
            this.tbpPersonal.Text = "Personal Information";
            this.tbpPersonal.UseVisualStyleBackColor = true;
            // 
            // tabEmployment
            // 
            this.tabEmployment.Controls.Add(this.tbpEmployment);
            this.tabEmployment.Location = new System.Drawing.Point(10, 236);
            this.tabEmployment.Name = "tabEmployment";
            this.tabEmployment.SelectedIndex = 0;
            this.tabEmployment.Size = new System.Drawing.Size(924, 322);
            this.tabEmployment.TabIndex = 89;
            // 
            // tbpEmployment
            // 
            this.tbpEmployment.Controls.Add(this.btnRecruitmentSourceAdd);
            this.tbpEmployment.Controls.Add(this.dtpRegular);
            this.tbpEmployment.Controls.Add(this.txtRecruitmentRemarks);
            this.tbpEmployment.Controls.Add(this.txtEmailOfficial);
            this.tbpEmployment.Controls.Add(this.label11);
            this.tbpEmployment.Controls.Add(this.label5);
            this.tbpEmployment.Controls.Add(this.cmbRecruitmentSource);
            this.tbpEmployment.Controls.Add(this.label10);
            this.tbpEmployment.Controls.Add(this.label6);
            this.tbpEmployment.Controls.Add(this.cmbCompany);
            this.tbpEmployment.Controls.Add(this.btnScheduleDetails);
            this.tbpEmployment.Controls.Add(this.label8);
            this.tbpEmployment.Controls.Add(this.txtAssignment);
            this.tbpEmployment.Controls.Add(this.cmbJGCode);
            this.tbpEmployment.Controls.Add(this.label64);
            this.tbpEmployment.Controls.Add(this.label65);
            this.tbpEmployment.Controls.Add(this.cmbSchedule);
            this.tbpEmployment.Controls.Add(this.txtPosition);
            this.tbpEmployment.Controls.Add(this.label20);
            this.tbpEmployment.Controls.Add(this.cmbEmploymentStatus);
            this.tbpEmployment.Controls.Add(this.cmbDivision);
            this.tbpEmployment.Controls.Add(this.label66);
            this.tbpEmployment.Controls.Add(this.cmbEmployeeType);
            this.tbpEmployment.Controls.Add(this.dtpDateStart);
            this.tbpEmployment.Controls.Add(this.label7);
            this.tbpEmployment.Controls.Add(this.label62);
            this.tbpEmployment.Controls.Add(this.cmbRC);
            this.tbpEmployment.Controls.Add(this.cmbGroup);
            this.tbpEmployment.Controls.Add(this.label60);
            this.tbpEmployment.Controls.Add(this.cmbDepartment);
            this.tbpEmployment.Controls.Add(this.label63);
            this.tbpEmployment.Controls.Add(this.label92);
            this.tbpEmployment.Controls.Add(this.label30);
            this.tbpEmployment.Controls.Add(this.label61);
            this.tbpEmployment.Location = new System.Drawing.Point(4, 24);
            this.tbpEmployment.Name = "tbpEmployment";
            this.tbpEmployment.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEmployment.Size = new System.Drawing.Size(916, 294);
            this.tbpEmployment.TabIndex = 0;
            this.tbpEmployment.Text = "Employment Details";
            this.tbpEmployment.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(946, 618);
            this.Controls.Add(this.tabEmployment);
            this.Controls.Add(this.tabPersonal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployeeNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.frmEmployeeNew_Load);
            this.tabPersonal.ResumeLayout(false);
            this.tbpPersonal.ResumeLayout(false);
            this.tbpPersonal.PerformLayout();
            this.tabEmployment.ResumeLayout(false);
            this.tbpEmployment.ResumeLayout(false);
            this.tbpEmployment.PerformLayout();
            this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.CheckBox chkEnabled;
  private System.Windows.Forms.Label label89;
  private System.Windows.Forms.TextBox txtUsername;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtEmployeeNumber;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtFirstName;
  private System.Windows.Forms.ComboBox cmbEmployeeType;
  private System.Windows.Forms.TextBox txtMiddleName;
  private System.Windows.Forms.Label label30;
  private System.Windows.Forms.TextBox txtLastName;
  private System.Windows.Forms.ComboBox cmbCompany;
  private System.Windows.Forms.TextBox txtPosition;
  private System.Windows.Forms.ComboBox cmbCivilStatus;
  private System.Windows.Forms.ComboBox cmbGender;
  private System.Windows.Forms.Label label36;
  private System.Windows.Forms.Label label29;
  private System.Windows.Forms.Label label27;
  private System.Windows.Forms.TextBox txtNickName;
  private System.Windows.Forms.DateTimePicker dtpBirthDate;
  private System.Windows.Forms.Label label25;
  private System.Windows.Forms.TextBox txtEmailOfficial;
  private System.Windows.Forms.Label label20;
  private System.Windows.Forms.Label label92;
  private System.Windows.Forms.DateTimePicker dtpDateStart;
  private System.Windows.Forms.Label label66;
  private System.Windows.Forms.ComboBox cmbEmploymentStatus;
  private System.Windows.Forms.Label label65;
  private System.Windows.Forms.TextBox txtAssignment;
  private System.Windows.Forms.Label label64;
  private System.Windows.Forms.ComboBox cmbJGCode;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.ComboBox cmbDivision;
  private System.Windows.Forms.ComboBox cmbRC;
  private System.Windows.Forms.Label label60;
  private System.Windows.Forms.Label label63;
  private System.Windows.Forms.Label label61;
  private System.Windows.Forms.ComboBox cmbDepartment;
  private System.Windows.Forms.ComboBox cmbGroup;
  private System.Windows.Forms.Label label62;
  private System.Windows.Forms.ComboBox cmbSchedule;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.Button btnScheduleDetails;
  private System.Windows.Forms.Button btnGenerateUsername;
  private System.Windows.Forms.Button btnGenerateEmployeeNumber;
  private System.Windows.Forms.CheckBox chkBillable;
  private System.Windows.Forms.DateTimePicker dtpRegular;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtRecruitmentRemarks;
  private System.Windows.Forms.Label label11;
  private System.Windows.Forms.ComboBox cmbRecruitmentSource;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.Button btnRecruitmentSourceAdd;
  private System.Windows.Forms.TextBox txtMiddleInitial;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.TabControl tabPersonal;
  private System.Windows.Forms.TabPage tbpPersonal;
  private System.Windows.Forms.TabControl tabEmployment;
  private System.Windows.Forms.TabPage tbpEmployment;

 }
}