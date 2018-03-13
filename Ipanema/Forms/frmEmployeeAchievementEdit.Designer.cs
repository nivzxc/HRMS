namespace Ipanema.Forms
{
 partial class frmEmployeeAchievementEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeAchievementEdit));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtAchieveDate = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.txtDetails = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtEmpName = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.txtAchievement = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(423, 262);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(73, 30);
   this.btnClose.TabIndex = 6;
   this.btnClose.Text = "Close  ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(345, 262);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(73, 30);
   this.btnSave.TabIndex = 5;
   this.btnSave.Text = "Save  ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtAchieveDate);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.txtDetails);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.txtEmpName);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.txtAchievement);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(9, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(485, 249);
   this.groupBox1.TabIndex = 47;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Training Attended Details";
   // 
   // txtAchieveDate
   // 
   this.txtAchieveDate.Location = new System.Drawing.Point(94, 84);
   this.txtAchieveDate.MaxLength = 50;
   this.txtAchieveDate.Name = "txtAchieveDate";
   this.txtAchieveDate.Size = new System.Drawing.Size(237, 21);
   this.txtAchieveDate.TabIndex = 2;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(12, 89);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(36, 15);
   this.label4.TabIndex = 28;
   this.label4.Text = "Date:";
   // 
   // txtDetails
   // 
   this.txtDetails.Location = new System.Drawing.Point(94, 113);
   this.txtDetails.MaxLength = 50;
   this.txtDetails.Multiline = true;
   this.txtDetails.Name = "txtDetails";
   this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtDetails.Size = new System.Drawing.Size(378, 125);
   this.txtDetails.TabIndex = 3;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(12, 117);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(48, 15);
   this.label7.TabIndex = 26;
   this.label7.Text = "Details:";
   // 
   // txtEmpName
   // 
   this.txtEmpName.BackColor = System.Drawing.Color.Ivory;
   this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtEmpName.Location = new System.Drawing.Point(94, 28);
   this.txtEmpName.Name = "txtEmpName";
   this.txtEmpName.ReadOnly = true;
   this.txtEmpName.Size = new System.Drawing.Size(287, 21);
   this.txtEmpName.TabIndex = 0;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(12, 31);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(65, 15);
   this.label3.TabIndex = 6;
   this.label3.Text = "Employee:";
   // 
   // txtAchievement
   // 
   this.txtAchievement.Location = new System.Drawing.Point(94, 56);
   this.txtAchievement.MaxLength = 50;
   this.txtAchievement.Name = "txtAchievement";
   this.txtAchievement.Size = new System.Drawing.Size(376, 21);
   this.txtAchievement.TabIndex = 1;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 59);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(80, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Achievement:";
   // 
   // frmEmployeeAchievementEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(504, 299);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmEmployeeAchievementEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit Employee\'s Achievement/Award";
   this.Load += new System.EventHandler(this.frmEmployeeAchievementEdit_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtDetails;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtEmpName;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtAchievement;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtAchieveDate;
 }
}