namespace Ipanema.Forms
{
 partial class frmDepartmentAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmentAdd));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.cmbGroup = new System.Windows.Forms.ComboBox();
   this.label1 = new System.Windows.Forms.Label();
   this.txtDepartment = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.cmbDivision = new System.Windows.Forms.ComboBox();
   this.label3 = new System.Windows.Forms.Label();
   this.txtDepartmentCode = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(273, 156);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 4;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(185, 156);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(82, 38);
   this.btnSave.TabIndex = 3;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.cmbGroup);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Controls.Add(this.txtDepartment);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.cmbDivision);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.txtDepartmentCode);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox1.Location = new System.Drawing.Point(8, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(344, 142);
   this.groupBox1.TabIndex = 37;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Department Details";
   // 
   // cmbGroup
   // 
   this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbGroup.FormattingEnabled = true;
   this.cmbGroup.Location = new System.Drawing.Point(92, 106);
   this.cmbGroup.Name = "cmbGroup";
   this.cmbGroup.Size = new System.Drawing.Size(240, 23);
   this.cmbGroup.TabIndex = 2;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(13, 111);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(44, 15);
   this.label1.TabIndex = 38;
   this.label1.Text = "Group:";
   // 
   // txtDepartment
   // 
   this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDepartment.Location = new System.Drawing.Point(92, 51);
   this.txtDepartment.MaxLength = 50;
   this.txtDepartment.Multiline = true;
   this.txtDepartment.Name = "txtDepartment";
   this.txtDepartment.Size = new System.Drawing.Size(228, 21);
   this.txtDepartment.TabIndex = 0;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(13, 54);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(75, 15);
   this.label4.TabIndex = 36;
   this.label4.Text = "Department:";
   // 
   // cmbDivision
   // 
   this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbDivision.FormattingEnabled = true;
   this.cmbDivision.Location = new System.Drawing.Point(92, 77);
   this.cmbDivision.Name = "cmbDivision";
   this.cmbDivision.Size = new System.Drawing.Size(240, 23);
   this.cmbDivision.TabIndex = 1;
   this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(13, 83);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(53, 15);
   this.label3.TabIndex = 32;
   this.label3.Text = "Division:";
   // 
   // txtDepartmentCode
   // 
   this.txtDepartmentCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtDepartmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDepartmentCode.Location = new System.Drawing.Point(92, 24);
   this.txtDepartmentCode.Name = "txtDepartmentCode";
   this.txtDepartmentCode.ReadOnly = true;
   this.txtDepartmentCode.Size = new System.Drawing.Size(88, 21);
   this.txtDepartmentCode.TabIndex = 1;
   this.txtDepartmentCode.TabStop = false;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(13, 27);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(39, 15);
   this.label2.TabIndex = 28;
   this.label2.Text = "Code:";
   // 
   // frmDepartmentAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(361, 204);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmDepartmentAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add New Department";
   this.Load += new System.EventHandler(this.frmDepartmentAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.ComboBox cmbDivision;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtDepartmentCode;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.ComboBox cmbGroup;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtDepartment;
  private System.Windows.Forms.Label label4;
 }
}