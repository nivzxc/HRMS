namespace Ipanema.Forms
{
 partial class frmEmployeeEducationAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeEducationAdd));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.chkComplete = new System.Windows.Forms.CheckBox();
   this.cmbLevel = new System.Windows.Forms.ComboBox();
   this.txtInclusiveDates = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtSchoolAddress = new System.Windows.Forms.TextBox();
   this.label5 = new System.Windows.Forms.Label();
   this.txtSchoolName = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.txtCourse = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.txtRecognition = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.txtEmpName = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(431, 244);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(73, 31);
   this.btnClose.TabIndex = 9;
   this.btnClose.Text = "Close ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(350, 244);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(73, 31);
   this.btnSave.TabIndex = 8;
   this.btnSave.Text = "Save  ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.chkComplete);
   this.groupBox1.Controls.Add(this.cmbLevel);
   this.groupBox1.Controls.Add(this.txtInclusiveDates);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.txtSchoolAddress);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.txtSchoolName);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.txtCourse);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.txtRecognition);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.txtEmpName);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(9, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(493, 228);
   this.groupBox1.TabIndex = 27;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Education Background Details";
   // 
   // chkComplete
   // 
   this.chkComplete.AutoSize = true;
   this.chkComplete.Location = new System.Drawing.Point(342, 58);
   this.chkComplete.Name = "chkComplete";
   this.chkComplete.Size = new System.Drawing.Size(79, 19);
   this.chkComplete.TabIndex = 1;
   this.chkComplete.Text = "Complete";
   this.chkComplete.UseVisualStyleBackColor = true;
   // 
   // cmbLevel
   // 
   this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbLevel.FormattingEnabled = true;
   this.cmbLevel.Location = new System.Drawing.Point(114, 53);
   this.cmbLevel.Name = "cmbLevel";
   this.cmbLevel.Size = new System.Drawing.Size(222, 23);
   this.cmbLevel.TabIndex = 0;
   // 
   // txtInclusiveDates
   // 
   this.txtInclusiveDates.Location = new System.Drawing.Point(114, 111);
   this.txtInclusiveDates.MaxLength = 50;
   this.txtInclusiveDates.Name = "txtInclusiveDates";
   this.txtInclusiveDates.Size = new System.Drawing.Size(297, 21);
   this.txtInclusiveDates.TabIndex = 3;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(12, 114);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(92, 15);
   this.label7.TabIndex = 26;
   this.label7.Text = "Inclusive Dates:";
   // 
   // txtSchoolAddress
   // 
   this.txtSchoolAddress.Location = new System.Drawing.Point(114, 197);
   this.txtSchoolAddress.MaxLength = 50;
   this.txtSchoolAddress.Name = "txtSchoolAddress";
   this.txtSchoolAddress.Size = new System.Drawing.Size(366, 21);
   this.txtSchoolAddress.TabIndex = 6;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(12, 200);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(54, 15);
   this.label5.TabIndex = 24;
   this.label5.Text = "Address:";
   // 
   // txtSchoolName
   // 
   this.txtSchoolName.Location = new System.Drawing.Point(114, 168);
   this.txtSchoolName.MaxLength = 50;
   this.txtSchoolName.Name = "txtSchoolName";
   this.txtSchoolName.Size = new System.Drawing.Size(366, 21);
   this.txtSchoolName.TabIndex = 5;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(12, 170);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(48, 15);
   this.label4.TabIndex = 22;
   this.label4.Text = "School:";
   // 
   // txtCourse
   // 
   this.txtCourse.Location = new System.Drawing.Point(114, 83);
   this.txtCourse.MaxLength = 50;
   this.txtCourse.Name = "txtCourse";
   this.txtCourse.Size = new System.Drawing.Size(366, 21);
   this.txtCourse.TabIndex = 2;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(12, 85);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(49, 15);
   this.label2.TabIndex = 20;
   this.label2.Text = "Course:";
   // 
   // txtRecognition
   // 
   this.txtRecognition.Location = new System.Drawing.Point(114, 139);
   this.txtRecognition.MaxLength = 50;
   this.txtRecognition.Name = "txtRecognition";
   this.txtRecognition.Size = new System.Drawing.Size(366, 21);
   this.txtRecognition.TabIndex = 4;
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(12, 143);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(76, 15);
   this.label6.TabIndex = 17;
   this.label6.Text = "Recognition:";
   // 
   // txtEmpName
   // 
   this.txtEmpName.BackColor = System.Drawing.Color.Ivory;
   this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtEmpName.Location = new System.Drawing.Point(114, 25);
   this.txtEmpName.Name = "txtEmpName";
   this.txtEmpName.ReadOnly = true;
   this.txtEmpName.Size = new System.Drawing.Size(287, 21);
   this.txtEmpName.TabIndex = 0;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(12, 30);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(65, 15);
   this.label3.TabIndex = 6;
   this.label3.Text = "Employee:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 57);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(39, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Level:";
   // 
   // frmEmployeeEducationAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(515, 283);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmEmployeeEducationAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add New Employee\'s Education Background";
   this.Load += new System.EventHandler(this.frmEmployeeEducationAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtRecognition;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtEmpName;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtSchoolAddress;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtSchoolName;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtCourse;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtInclusiveDates;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.ComboBox cmbLevel;
  private System.Windows.Forms.CheckBox chkComplete;
 }
}