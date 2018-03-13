namespace Ipanema.Forms
{
 partial class frmDepartmentApproverAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmentApproverAdd));
   this.cmbDepartment = new System.Windows.Forms.ComboBox();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.chkOB = new System.Windows.Forms.CheckBox();
   this.chkOvertime = new System.Windows.Forms.CheckBox();
   this.chkUndertime = new System.Windows.Forms.CheckBox();
   this.chkLeave = new System.Windows.Forms.CheckBox();
   this.cmbEmployee = new System.Windows.Forms.ComboBox();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // cmbDepartment
   // 
   this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbDepartment.FormattingEnabled = true;
   this.cmbDepartment.Location = new System.Drawing.Point(99, 24);
   this.cmbDepartment.Name = "cmbDepartment";
   this.cmbDepartment.Size = new System.Drawing.Size(285, 23);
   this.cmbDepartment.TabIndex = 0;
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.chkOB);
   this.groupBox1.Controls.Add(this.chkOvertime);
   this.groupBox1.Controls.Add(this.chkUndertime);
   this.groupBox1.Controls.Add(this.chkLeave);
   this.groupBox1.Controls.Add(this.cmbDepartment);
   this.groupBox1.Controls.Add(this.cmbEmployee);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(10, 8);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(397, 176);
   this.groupBox1.TabIndex = 4;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Approver Details";
   // 
   // chkOB
   // 
   this.chkOB.AutoSize = true;
   this.chkOB.Location = new System.Drawing.Point(99, 154);
   this.chkOB.Name = "chkOB";
   this.chkOB.Size = new System.Drawing.Size(106, 17);
   this.chkOB.TabIndex = 5;
   this.chkOB.Text = "Can Approve OB";
   this.chkOB.UseVisualStyleBackColor = true;
   // 
   // chkOvertime
   // 
   this.chkOvertime.AutoSize = true;
   this.chkOvertime.Location = new System.Drawing.Point(99, 130);
   this.chkOvertime.Name = "chkOvertime";
   this.chkOvertime.Size = new System.Drawing.Size(133, 17);
   this.chkOvertime.TabIndex = 4;
   this.chkOvertime.Text = "Can Approve Overtime";
   this.chkOvertime.UseVisualStyleBackColor = true;
   // 
   // chkUndertime
   // 
   this.chkUndertime.AutoSize = true;
   this.chkUndertime.Location = new System.Drawing.Point(99, 106);
   this.chkUndertime.Name = "chkUndertime";
   this.chkUndertime.Size = new System.Drawing.Size(139, 17);
   this.chkUndertime.TabIndex = 3;
   this.chkUndertime.Text = "Can Approve Undertime";
   this.chkUndertime.UseVisualStyleBackColor = true;
   // 
   // chkLeave
   // 
   this.chkLeave.AutoSize = true;
   this.chkLeave.Location = new System.Drawing.Point(99, 82);
   this.chkLeave.Name = "chkLeave";
   this.chkLeave.Size = new System.Drawing.Size(121, 17);
   this.chkLeave.TabIndex = 2;
   this.chkLeave.Text = "Can Approve Leave";
   this.chkLeave.UseVisualStyleBackColor = true;
   // 
   // cmbEmployee
   // 
   this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbEmployee.FormattingEnabled = true;
   this.cmbEmployee.Location = new System.Drawing.Point(99, 53);
   this.cmbEmployee.Name = "cmbEmployee";
   this.cmbEmployee.Size = new System.Drawing.Size(285, 23);
   this.cmbEmployee.TabIndex = 1;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(13, 28);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(75, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Department:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(13, 58);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(65, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Employee:";
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(334, 191);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(76, 30);
   this.btnClose.TabIndex = 7;
   this.btnClose.Text = "Close  ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(252, 191);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(76, 30);
   this.btnSave.TabIndex = 6;
   this.btnSave.Text = "Save   ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // frmDepartmentApproverAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.ClientSize = new System.Drawing.Size(419, 229);
   this.Controls.Add(this.groupBox1);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmDepartmentApproverAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add Department Approver";
   this.Load += new System.EventHandler(this.frmDepartmentApproverAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.ComboBox cmbDepartment;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.ComboBox cmbEmployee;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.CheckBox chkOB;
  private System.Windows.Forms.CheckBox chkOvertime;
  private System.Windows.Forms.CheckBox chkUndertime;
  private System.Windows.Forms.CheckBox chkLeave;
 }
}