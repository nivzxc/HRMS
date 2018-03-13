namespace Ipanema.Forms
{
 partial class frmEmployeeMovementAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeMovementAdd));
   this.btnClose = new System.Windows.Forms.Button();
   this.label7 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.txtEmpName = new System.Windows.Forms.TextBox();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtRemarks = new System.Windows.Forms.TextBox();
   this.label8 = new System.Windows.Forms.Label();
   this.txtPosition = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.cmbJGCode = new System.Windows.Forms.ComboBox();
   this.label5 = new System.Windows.Forms.Label();
   this.cmbDepartment = new System.Windows.Forms.ComboBox();
   this.cmbGroup = new System.Windows.Forms.ComboBox();
   this.cmbDivision = new System.Windows.Forms.ComboBox();
   this.label3 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.dtpFrom = new System.Windows.Forms.DateTimePicker();
   this.dtpTo = new System.Windows.Forms.DateTimePicker();
   this.label9 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(388, 411);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 9;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(12, 148);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(75, 15);
   this.label7.TabIndex = 11;
   this.label7.Text = "Department:";
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(12, 115);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(44, 15);
   this.label4.TabIndex = 9;
   this.label4.Text = "Group:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(12, 86);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(53, 15);
   this.label2.TabIndex = 7;
   this.label2.Text = "Division:";
   // 
   // txtEmpName
   // 
   this.txtEmpName.BackColor = System.Drawing.Color.AliceBlue;
   this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtEmpName.Location = new System.Drawing.Point(101, 25);
   this.txtEmpName.Name = "txtEmpName";
   this.txtEmpName.ReadOnly = true;
   this.txtEmpName.Size = new System.Drawing.Size(340, 21);
   this.txtEmpName.TabIndex = 0;
   this.txtEmpName.TabStop = false;
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(298, 411);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 8;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.label9);
   this.groupBox1.Controls.Add(this.dtpTo);
   this.groupBox1.Controls.Add(this.dtpFrom);
   this.groupBox1.Controls.Add(this.txtRemarks);
   this.groupBox1.Controls.Add(this.label8);
   this.groupBox1.Controls.Add(this.txtPosition);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.cmbJGCode);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.cmbDepartment);
   this.groupBox1.Controls.Add(this.cmbGroup);
   this.groupBox1.Controls.Add(this.cmbDivision);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.txtEmpName);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(13, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(454, 393);
   this.groupBox1.TabIndex = 23;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Movement Details";
   // 
   // txtRemarks
   // 
   this.txtRemarks.Location = new System.Drawing.Point(101, 234);
   this.txtRemarks.MaxLength = 255;
   this.txtRemarks.Multiline = true;
   this.txtRemarks.Name = "txtRemarks";
   this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtRemarks.Size = new System.Drawing.Size(340, 144);
   this.txtRemarks.TabIndex = 7;
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Location = new System.Drawing.Point(12, 232);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(60, 15);
   this.label8.TabIndex = 19;
   this.label8.Text = "Remarks:";
   // 
   // txtPosition
   // 
   this.txtPosition.Location = new System.Drawing.Point(101, 204);
   this.txtPosition.MaxLength = 50;
   this.txtPosition.Name = "txtPosition";
   this.txtPosition.Size = new System.Drawing.Size(340, 21);
   this.txtPosition.TabIndex = 6;
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(12, 206);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(54, 15);
   this.label6.TabIndex = 17;
   this.label6.Text = "Position:";
   // 
   // cmbJGCode
   // 
   this.cmbJGCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbJGCode.FormattingEnabled = true;
   this.cmbJGCode.Location = new System.Drawing.Point(101, 174);
   this.cmbJGCode.Name = "cmbJGCode";
   this.cmbJGCode.Size = new System.Drawing.Size(132, 23);
   this.cmbJGCode.TabIndex = 5;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(12, 176);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(57, 15);
   this.label5.TabIndex = 15;
   this.label5.Text = "JG Code:";
   // 
   // cmbDepartment
   // 
   this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbDepartment.FormattingEnabled = true;
   this.cmbDepartment.Location = new System.Drawing.Point(101, 144);
   this.cmbDepartment.Name = "cmbDepartment";
   this.cmbDepartment.Size = new System.Drawing.Size(294, 23);
   this.cmbDepartment.TabIndex = 4;
   // 
   // cmbGroup
   // 
   this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbGroup.FormattingEnabled = true;
   this.cmbGroup.Location = new System.Drawing.Point(101, 114);
   this.cmbGroup.Name = "cmbGroup";
   this.cmbGroup.Size = new System.Drawing.Size(294, 23);
   this.cmbGroup.TabIndex = 3;
   // 
   // cmbDivision
   // 
   this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbDivision.FormattingEnabled = true;
   this.cmbDivision.Location = new System.Drawing.Point(101, 83);
   this.cmbDivision.Name = "cmbDivision";
   this.cmbDivision.Size = new System.Drawing.Size(294, 23);
   this.cmbDivision.TabIndex = 2;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(12, 28);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(65, 15);
   this.label3.TabIndex = 6;
   this.label3.Text = "Employee:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 56);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(59, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Effectivity:";
   // 
   // dtpFrom
   // 
   this.dtpFrom.CustomFormat = "MMM dd, yyyy";
   this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFrom.Location = new System.Drawing.Point(101, 54);
   this.dtpFrom.Name = "dtpFrom";
   this.dtpFrom.Size = new System.Drawing.Size(104, 21);
   this.dtpFrom.TabIndex = 0;
   // 
   // dtpTo
   // 
   this.dtpTo.CustomFormat = "MMM dd, yyyy";
   this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpTo.Location = new System.Drawing.Point(230, 54);
   this.dtpTo.Name = "dtpTo";
   this.dtpTo.Size = new System.Drawing.Size(104, 21);
   this.dtpTo.TabIndex = 1;
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Location = new System.Drawing.Point(210, 56);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(17, 15);
   this.label9.TabIndex = 22;
   this.label9.Text = "to";
   // 
   // frmEmployeeMovementAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(480, 459);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmEmployeeMovementAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add New Employee Movement";
   this.Load += new System.EventHandler(this.frmEmployeeMovementAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtEmpName;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.ComboBox cmbJGCode;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.ComboBox cmbDepartment;
  private System.Windows.Forms.ComboBox cmbGroup;
  private System.Windows.Forms.ComboBox cmbDivision;
  private System.Windows.Forms.TextBox txtRemarks;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.TextBox txtPosition;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.DateTimePicker dtpTo;
  private System.Windows.Forms.DateTimePicker dtpFrom;
 }
}