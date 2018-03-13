namespace Ipanema.Forms
{
 partial class frmOffenseEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOffenseEdit));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox2 = new System.Windows.Forms.GroupBox();
   this.txtDateModified = new System.Windows.Forms.TextBox();
   this.label10 = new System.Windows.Forms.Label();
   this.txtModifiedBy = new System.Windows.Forms.TextBox();
   this.label9 = new System.Windows.Forms.Label();
   this.txtDateCreated = new System.Windows.Forms.TextBox();
   this.label8 = new System.Windows.Forms.Label();
   this.txtCreatedBy = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtEmployeeName = new System.Windows.Forms.TextBox();
   this.txtOffenseCode = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
   this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
   this.label11 = new System.Windows.Forms.Label();
   this.label12 = new System.Windows.Forms.Label();
   this.cmbClass = new System.Windows.Forms.ComboBox();
   this.label13 = new System.Windows.Forms.Label();
   this.label14 = new System.Windows.Forms.Label();
   this.txtDetails = new System.Windows.Forms.TextBox();
   this.label15 = new System.Windows.Forms.Label();
   this.chkEnabled = new System.Windows.Forms.CheckBox();
   this.groupBox2.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(382, 350);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(76, 38);
   this.btnClose.TabIndex = 9;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(300, 350);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(76, 38);
   this.btnSave.TabIndex = 7;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox2
   // 
   this.groupBox2.Controls.Add(this.chkEnabled);
   this.groupBox2.Controls.Add(this.txtDateModified);
   this.groupBox2.Controls.Add(this.label10);
   this.groupBox2.Controls.Add(this.txtModifiedBy);
   this.groupBox2.Controls.Add(this.label9);
   this.groupBox2.Controls.Add(this.txtDateCreated);
   this.groupBox2.Controls.Add(this.label8);
   this.groupBox2.Controls.Add(this.txtCreatedBy);
   this.groupBox2.Controls.Add(this.label7);
   this.groupBox2.Controls.Add(this.txtEmployeeName);
   this.groupBox2.Controls.Add(this.txtOffenseCode);
   this.groupBox2.Controls.Add(this.label6);
   this.groupBox2.Controls.Add(this.dtpDateEnd);
   this.groupBox2.Controls.Add(this.dtpDateStart);
   this.groupBox2.Controls.Add(this.label11);
   this.groupBox2.Controls.Add(this.label12);
   this.groupBox2.Controls.Add(this.cmbClass);
   this.groupBox2.Controls.Add(this.label13);
   this.groupBox2.Controls.Add(this.label14);
   this.groupBox2.Controls.Add(this.txtDetails);
   this.groupBox2.Controls.Add(this.label15);
   this.groupBox2.Location = new System.Drawing.Point(10, 6);
   this.groupBox2.Name = "groupBox2";
   this.groupBox2.Size = new System.Drawing.Size(446, 335);
   this.groupBox2.TabIndex = 10;
   this.groupBox2.TabStop = false;
   this.groupBox2.Text = "Employee Offense Details";
   // 
   // txtDateModified
   // 
   this.txtDateModified.BackColor = System.Drawing.Color.AliceBlue;
   this.txtDateModified.Enabled = false;
   this.txtDateModified.Location = new System.Drawing.Point(124, 299);
   this.txtDateModified.MaxLength = 100;
   this.txtDateModified.Name = "txtDateModified";
   this.txtDateModified.Size = new System.Drawing.Size(170, 21);
   this.txtDateModified.TabIndex = 21;
   this.txtDateModified.TabStop = false;
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Location = new System.Drawing.Point(16, 302);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(87, 15);
   this.label10.TabIndex = 20;
   this.label10.Text = "Date Modified:";
   // 
   // txtModifiedBy
   // 
   this.txtModifiedBy.BackColor = System.Drawing.Color.AliceBlue;
   this.txtModifiedBy.Enabled = false;
   this.txtModifiedBy.Location = new System.Drawing.Point(124, 270);
   this.txtModifiedBy.MaxLength = 100;
   this.txtModifiedBy.Name = "txtModifiedBy";
   this.txtModifiedBy.Size = new System.Drawing.Size(250, 21);
   this.txtModifiedBy.TabIndex = 19;
   this.txtModifiedBy.TabStop = false;
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Location = new System.Drawing.Point(16, 272);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(74, 15);
   this.label9.TabIndex = 18;
   this.label9.Text = "Modified By:";
   // 
   // txtDateCreated
   // 
   this.txtDateCreated.BackColor = System.Drawing.Color.AliceBlue;
   this.txtDateCreated.Enabled = false;
   this.txtDateCreated.Location = new System.Drawing.Point(124, 240);
   this.txtDateCreated.MaxLength = 100;
   this.txtDateCreated.Name = "txtDateCreated";
   this.txtDateCreated.Size = new System.Drawing.Size(170, 21);
   this.txtDateCreated.TabIndex = 17;
   this.txtDateCreated.TabStop = false;
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Location = new System.Drawing.Point(16, 242);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(82, 15);
   this.label8.TabIndex = 16;
   this.label8.Text = "Date Created:";
   // 
   // txtCreatedBy
   // 
   this.txtCreatedBy.BackColor = System.Drawing.Color.AliceBlue;
   this.txtCreatedBy.Enabled = false;
   this.txtCreatedBy.Location = new System.Drawing.Point(124, 212);
   this.txtCreatedBy.MaxLength = 100;
   this.txtCreatedBy.Name = "txtCreatedBy";
   this.txtCreatedBy.Size = new System.Drawing.Size(250, 21);
   this.txtCreatedBy.TabIndex = 15;
   this.txtCreatedBy.TabStop = false;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(16, 214);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(69, 15);
   this.label7.TabIndex = 14;
   this.label7.Text = "Created By:";
   // 
   // txtEmployeeName
   // 
   this.txtEmployeeName.BackColor = System.Drawing.Color.AliceBlue;
   this.txtEmployeeName.Location = new System.Drawing.Point(124, 61);
   this.txtEmployeeName.MaxLength = 100;
   this.txtEmployeeName.Name = "txtEmployeeName";
   this.txtEmployeeName.ReadOnly = true;
   this.txtEmployeeName.Size = new System.Drawing.Size(306, 21);
   this.txtEmployeeName.TabIndex = 13;
   this.txtEmployeeName.TabStop = false;
   // 
   // txtOffenseCode
   // 
   this.txtOffenseCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtOffenseCode.Enabled = false;
   this.txtOffenseCode.Location = new System.Drawing.Point(124, 32);
   this.txtOffenseCode.MaxLength = 100;
   this.txtOffenseCode.Name = "txtOffenseCode";
   this.txtOffenseCode.Size = new System.Drawing.Size(122, 21);
   this.txtOffenseCode.TabIndex = 12;
   this.txtOffenseCode.TabStop = false;
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(16, 34);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(98, 15);
   this.label6.TabIndex = 11;
   this.label6.Text = "Record Number:";
   // 
   // dtpDateEnd
   // 
   this.dtpDateEnd.CustomFormat = "MMM dd, yyyy";
   this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpDateEnd.Location = new System.Drawing.Point(124, 119);
   this.dtpDateEnd.Name = "dtpDateEnd";
   this.dtpDateEnd.Size = new System.Drawing.Size(114, 21);
   this.dtpDateEnd.TabIndex = 2;
   // 
   // dtpDateStart
   // 
   this.dtpDateStart.CustomFormat = "MMM dd, yyyy";
   this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpDateStart.Location = new System.Drawing.Point(124, 90);
   this.dtpDateStart.Name = "dtpDateStart";
   this.dtpDateStart.Size = new System.Drawing.Size(114, 21);
   this.dtpDateStart.TabIndex = 1;
   // 
   // label11
   // 
   this.label11.AutoSize = true;
   this.label11.Location = new System.Drawing.Point(16, 121);
   this.label11.Name = "label11";
   this.label11.Size = new System.Drawing.Size(61, 15);
   this.label11.TabIndex = 10;
   this.label11.Text = "Date End:";
   // 
   // label12
   // 
   this.label12.AutoSize = true;
   this.label12.Location = new System.Drawing.Point(16, 94);
   this.label12.Name = "label12";
   this.label12.Size = new System.Drawing.Size(64, 15);
   this.label12.TabIndex = 9;
   this.label12.Text = "Date Start:";
   // 
   // cmbClass
   // 
   this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbClass.FormattingEnabled = true;
   this.cmbClass.Location = new System.Drawing.Point(124, 178);
   this.cmbClass.Name = "cmbClass";
   this.cmbClass.Size = new System.Drawing.Size(82, 23);
   this.cmbClass.TabIndex = 4;
   // 
   // label13
   // 
   this.label13.AutoSize = true;
   this.label13.Location = new System.Drawing.Point(16, 182);
   this.label13.Name = "label13";
   this.label13.Size = new System.Drawing.Size(91, 15);
   this.label13.TabIndex = 8;
   this.label13.Text = "Class Category:";
   // 
   // label14
   // 
   this.label14.AutoSize = true;
   this.label14.Location = new System.Drawing.Point(16, 64);
   this.label14.Name = "label14";
   this.label14.Size = new System.Drawing.Size(102, 15);
   this.label14.TabIndex = 6;
   this.label14.Text = "Employee Name:";
   // 
   // txtDetails
   // 
   this.txtDetails.Location = new System.Drawing.Point(124, 148);
   this.txtDetails.MaxLength = 100;
   this.txtDetails.Name = "txtDetails";
   this.txtDetails.Size = new System.Drawing.Size(306, 21);
   this.txtDetails.TabIndex = 3;
   // 
   // label15
   // 
   this.label15.AutoSize = true;
   this.label15.Location = new System.Drawing.Point(16, 150);
   this.label15.Name = "label15";
   this.label15.Size = new System.Drawing.Size(48, 15);
   this.label15.TabIndex = 2;
   this.label15.Text = "Details:";
   // 
   // chkEnabled
   // 
   this.chkEnabled.AutoSize = true;
   this.chkEnabled.Location = new System.Drawing.Point(258, 34);
   this.chkEnabled.Name = "chkEnabled";
   this.chkEnabled.Size = new System.Drawing.Size(72, 19);
   this.chkEnabled.TabIndex = 22;
   this.chkEnabled.Text = "Enabled";
   this.chkEnabled.UseVisualStyleBackColor = true;
   // 
   // frmOffenseEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.ClientSize = new System.Drawing.Size(470, 400);
   this.Controls.Add(this.groupBox2);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmOffenseEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit Employee Offense";
   this.Load += new System.EventHandler(this.frmOffenseEdit_Load);
   this.groupBox2.ResumeLayout(false);
   this.groupBox2.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox2;
  private System.Windows.Forms.TextBox txtDateModified;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.TextBox txtModifiedBy;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.TextBox txtDateCreated;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.TextBox txtCreatedBy;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtEmployeeName;
  private System.Windows.Forms.TextBox txtOffenseCode;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.DateTimePicker dtpDateEnd;
  private System.Windows.Forms.DateTimePicker dtpDateStart;
  private System.Windows.Forms.Label label11;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.ComboBox cmbClass;
  private System.Windows.Forms.Label label13;
  private System.Windows.Forms.Label label14;
  private System.Windows.Forms.TextBox txtDetails;
  private System.Windows.Forms.Label label15;
  private System.Windows.Forms.CheckBox chkEnabled;
 }
}