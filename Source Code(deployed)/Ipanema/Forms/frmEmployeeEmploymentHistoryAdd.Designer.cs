namespace Ipanema.Forms
{
 partial class frmEmployeeEmploymentHistoryAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeEmploymentHistoryAdd));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.cmbEmploymentStatus = new System.Windows.Forms.ComboBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtResponsibility = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.txtPosition = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.txtEmpName = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.txtInclusiveDates = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox2 = new System.Windows.Forms.GroupBox();
   this.txtContactNumber = new System.Windows.Forms.TextBox();
   this.label5 = new System.Windows.Forms.Label();
   this.txtCompanyAddress = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.txtCompanyName = new System.Windows.Forms.TextBox();
   this.label8 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.groupBox2.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(446, 301);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(79, 38);
   this.btnClose.TabIndex = 10;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(359, 301);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(79, 38);
   this.btnSave.TabIndex = 9;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.cmbEmploymentStatus);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.txtResponsibility);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.txtPosition);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.txtEmpName);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.txtInclusiveDates);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(11, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(513, 169);
   this.groupBox1.TabIndex = 18;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Employment Details";
   // 
   // cmbEmploymentStatus
   // 
   this.cmbEmploymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbEmploymentStatus.FormattingEnabled = true;
   this.cmbEmploymentStatus.Location = new System.Drawing.Point(145, 133);
   this.cmbEmploymentStatus.Name = "cmbEmploymentStatus";
   this.cmbEmploymentStatus.Size = new System.Drawing.Size(254, 23);
   this.cmbEmploymentStatus.TabIndex = 12;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(11, 137);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(129, 15);
   this.label7.TabIndex = 11;
   this.label7.Text = "Status of Appointment:";
   // 
   // txtResponsibility
   // 
   this.txtResponsibility.Location = new System.Drawing.Point(145, 106);
   this.txtResponsibility.MaxLength = 100;
   this.txtResponsibility.Name = "txtResponsibility";
   this.txtResponsibility.Size = new System.Drawing.Size(355, 21);
   this.txtResponsibility.TabIndex = 3;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(11, 109);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(86, 15);
   this.label4.TabIndex = 9;
   this.label4.Text = "Responsibility:";
   // 
   // txtPosition
   // 
   this.txtPosition.Location = new System.Drawing.Point(145, 79);
   this.txtPosition.MaxLength = 100;
   this.txtPosition.Name = "txtPosition";
   this.txtPosition.Size = new System.Drawing.Size(355, 21);
   this.txtPosition.TabIndex = 2;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(11, 82);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(54, 15);
   this.label2.TabIndex = 7;
   this.label2.Text = "Position:";
   // 
   // txtEmpName
   // 
   this.txtEmpName.BackColor = System.Drawing.Color.AliceBlue;
   this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtEmpName.Location = new System.Drawing.Point(145, 23);
   this.txtEmpName.Name = "txtEmpName";
   this.txtEmpName.ReadOnly = true;
   this.txtEmpName.Size = new System.Drawing.Size(287, 21);
   this.txtEmpName.TabIndex = 0;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(11, 26);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(65, 15);
   this.label3.TabIndex = 6;
   this.label3.Text = "Employee:";
   // 
   // txtInclusiveDates
   // 
   this.txtInclusiveDates.Location = new System.Drawing.Point(145, 51);
   this.txtInclusiveDates.MaxLength = 100;
   this.txtInclusiveDates.Name = "txtInclusiveDates";
   this.txtInclusiveDates.Size = new System.Drawing.Size(317, 21);
   this.txtInclusiveDates.TabIndex = 1;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(11, 54);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(92, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Inclusive Dates:";
   // 
   // groupBox2
   // 
   this.groupBox2.Controls.Add(this.txtContactNumber);
   this.groupBox2.Controls.Add(this.label5);
   this.groupBox2.Controls.Add(this.txtCompanyAddress);
   this.groupBox2.Controls.Add(this.label6);
   this.groupBox2.Controls.Add(this.txtCompanyName);
   this.groupBox2.Controls.Add(this.label8);
   this.groupBox2.Location = new System.Drawing.Point(11, 183);
   this.groupBox2.Name = "groupBox2";
   this.groupBox2.Size = new System.Drawing.Size(513, 109);
   this.groupBox2.TabIndex = 19;
   this.groupBox2.TabStop = false;
   this.groupBox2.Text = "Company Details";
   // 
   // txtContactNumber
   // 
   this.txtContactNumber.Location = new System.Drawing.Point(146, 75);
   this.txtContactNumber.MaxLength = 100;
   this.txtContactNumber.Name = "txtContactNumber";
   this.txtContactNumber.Size = new System.Drawing.Size(331, 21);
   this.txtContactNumber.TabIndex = 7;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(12, 78);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(99, 15);
   this.label5.TabIndex = 9;
   this.label5.Text = "Contact Number:";
   // 
   // txtCompanyAddress
   // 
   this.txtCompanyAddress.Location = new System.Drawing.Point(146, 48);
   this.txtCompanyAddress.MaxLength = 100;
   this.txtCompanyAddress.Name = "txtCompanyAddress";
   this.txtCompanyAddress.Size = new System.Drawing.Size(355, 21);
   this.txtCompanyAddress.TabIndex = 6;
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(12, 51);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(109, 15);
   this.label6.TabIndex = 7;
   this.label6.Text = "Company Address:";
   // 
   // txtCompanyName
   // 
   this.txtCompanyName.Location = new System.Drawing.Point(146, 21);
   this.txtCompanyName.MaxLength = 100;
   this.txtCompanyName.Name = "txtCompanyName";
   this.txtCompanyName.Size = new System.Drawing.Size(355, 21);
   this.txtCompanyName.TabIndex = 5;
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Location = new System.Drawing.Point(12, 24);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(99, 15);
   this.label8.TabIndex = 0;
   this.label8.Text = "Company Name:";
   // 
   // frmEmployeeEmploymentHistoryAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(536, 350);
   this.Controls.Add(this.groupBox2);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmEmployeeEmploymentHistoryAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add New Employment History";
   this.Load += new System.EventHandler(this.frmEmployeeEmploymentHistoryAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.groupBox2.ResumeLayout(false);
   this.groupBox2.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtEmpName;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtInclusiveDates;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtResponsibility;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtPosition;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.GroupBox groupBox2;
  private System.Windows.Forms.TextBox txtContactNumber;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtCompanyAddress;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtCompanyName;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.ComboBox cmbEmploymentStatus;
 }
}