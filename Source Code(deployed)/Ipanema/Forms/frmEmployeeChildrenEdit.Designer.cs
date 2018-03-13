namespace Ipanema.Forms
{
 partial class frmEmployeeChildrenEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeChildrenEdit));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtEmpName = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
   this.txtName = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(317, 126);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(72, 31);
   this.btnClose.TabIndex = 17;
   this.btnClose.Text = "Close ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(238, 126);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(72, 31);
   this.btnSave.TabIndex = 16;
   this.btnSave.Text = "Save  ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtEmpName);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.dtpBirthDate);
   this.groupBox1.Controls.Add(this.txtName);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(9, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(379, 112);
   this.groupBox1.TabIndex = 18;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Child Details";
   // 
   // txtEmpName
   // 
   this.txtEmpName.BackColor = System.Drawing.Color.Ivory;
   this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtEmpName.Location = new System.Drawing.Point(95, 24);
   this.txtEmpName.Name = "txtEmpName";
   this.txtEmpName.ReadOnly = true;
   this.txtEmpName.Size = new System.Drawing.Size(275, 21);
   this.txtEmpName.TabIndex = 0;
   this.txtEmpName.TabStop = false;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(13, 27);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(65, 15);
   this.label3.TabIndex = 6;
   this.label3.Text = "Employee:";
   // 
   // dtpBirthDate
   // 
   this.dtpBirthDate.CustomFormat = "MMM dd, yyyy";
   this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpBirthDate.Location = new System.Drawing.Point(95, 80);
   this.dtpBirthDate.Name = "dtpBirthDate";
   this.dtpBirthDate.Size = new System.Drawing.Size(101, 21);
   this.dtpBirthDate.TabIndex = 2;
   // 
   // txtName
   // 
   this.txtName.Location = new System.Drawing.Point(95, 52);
   this.txtName.MaxLength = 100;
   this.txtName.Name = "txtName";
   this.txtName.Size = new System.Drawing.Size(275, 21);
   this.txtName.TabIndex = 1;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(13, 84);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(77, 15);
   this.label2.TabIndex = 1;
   this.label2.Text = "Date of Birth:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(13, 56);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(44, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Name:";
   // 
   // frmEmployeeChildrenEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(398, 165);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmEmployeeChildrenEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit Employee Child Details";
   this.Load += new System.EventHandler(this.frmEmployeeChildrenEdit_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtEmpName;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.DateTimePicker dtpBirthDate;
  private System.Windows.Forms.TextBox txtName;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
 }
}