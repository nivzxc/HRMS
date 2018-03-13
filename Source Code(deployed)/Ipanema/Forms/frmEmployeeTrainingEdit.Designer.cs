namespace Ipanema.Forms
{
 partial class frmEmployeeTrainingEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeTrainingEdit));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.dtpDate = new System.Windows.Forms.DateTimePicker();
   this.txtDetails = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.txtSponsor = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.txtEmpName = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.txtTraining = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(352, 294);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(73, 30);
   this.btnClose.TabIndex = 34;
   this.btnClose.Text = "Close  ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(270, 294);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(73, 30);
   this.btnSave.TabIndex = 33;
   this.btnSave.Text = "Save  ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.dtpDate);
   this.groupBox1.Controls.Add(this.txtDetails);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.txtSponsor);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.txtEmpName);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.txtTraining);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(8, 5);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(415, 281);
   this.groupBox1.TabIndex = 35;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Training Attended Details";
   // 
   // dtpDate
   // 
   this.dtpDate.CustomFormat = "MMM dd, yyyy";
   this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpDate.Location = new System.Drawing.Point(74, 78);
   this.dtpDate.Name = "dtpDate";
   this.dtpDate.Size = new System.Drawing.Size(96, 20);
   this.dtpDate.TabIndex = 1;
   // 
   // txtDetails
   // 
   this.txtDetails.Location = new System.Drawing.Point(74, 106);
   this.txtDetails.MaxLength = 50;
   this.txtDetails.Multiline = true;
   this.txtDetails.Name = "txtDetails";
   this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtDetails.Size = new System.Drawing.Size(326, 139);
   this.txtDetails.TabIndex = 2;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(10, 107);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(42, 13);
   this.label7.TabIndex = 26;
   this.label7.Text = "Details:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(10, 82);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(33, 13);
   this.label2.TabIndex = 20;
   this.label2.Text = "Date:";
   // 
   // txtSponsor
   // 
   this.txtSponsor.Location = new System.Drawing.Point(74, 252);
   this.txtSponsor.MaxLength = 50;
   this.txtSponsor.Name = "txtSponsor";
   this.txtSponsor.Size = new System.Drawing.Size(244, 20);
   this.txtSponsor.TabIndex = 3;
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(10, 255);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(49, 13);
   this.label6.TabIndex = 17;
   this.label6.Text = "Sponsor:";
   // 
   // txtEmpName
   // 
   this.txtEmpName.BackColor = System.Drawing.Color.Ivory;
   this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtEmpName.Location = new System.Drawing.Point(74, 25);
   this.txtEmpName.Name = "txtEmpName";
   this.txtEmpName.ReadOnly = true;
   this.txtEmpName.Size = new System.Drawing.Size(247, 21);
   this.txtEmpName.TabIndex = 0;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(10, 31);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(56, 13);
   this.label3.TabIndex = 6;
   this.label3.Text = "Employee:";
   // 
   // txtTraining
   // 
   this.txtTraining.Location = new System.Drawing.Point(74, 52);
   this.txtTraining.MaxLength = 100;
   this.txtTraining.Name = "txtTraining";
   this.txtTraining.Size = new System.Drawing.Size(326, 20);
   this.txtTraining.TabIndex = 0;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(10, 56);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(48, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "Training:";
   // 
   // frmEmployeeTrainingEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(431, 330);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmEmployeeTrainingEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit Employee\'s Training Attended";
   this.Load += new System.EventHandler(this.frmEmployeeTrainingEdit_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.DateTimePicker dtpDate;
  private System.Windows.Forms.TextBox txtDetails;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtSponsor;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtEmpName;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtTraining;
  private System.Windows.Forms.Label label1;
 }
}