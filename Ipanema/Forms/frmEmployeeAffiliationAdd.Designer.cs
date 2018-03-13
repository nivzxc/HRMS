namespace Ipanema.Forms
{
 partial class frmEmployeeAffiliationAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeAffiliationAdd));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtPosition = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.txtInclusiveDates = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.txtRemarks = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtEmpName = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.txtOrganization = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(476, 322);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(75, 32);
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
   this.btnSave.Location = new System.Drawing.Point(393, 322);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(75, 32);
   this.btnSave.TabIndex = 5;
   this.btnSave.Text = "Save  ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtPosition);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.txtInclusiveDates);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.txtRemarks);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.txtEmpName);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.txtOrganization);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(10, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(540, 305);
   this.groupBox1.TabIndex = 39;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Training Attended Details";
   // 
   // txtPosition
   // 
   this.txtPosition.Location = new System.Drawing.Point(112, 79);
   this.txtPosition.MaxLength = 50;
   this.txtPosition.Name = "txtPosition";
   this.txtPosition.Size = new System.Drawing.Size(366, 21);
   this.txtPosition.TabIndex = 1;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(12, 85);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(54, 15);
   this.label4.TabIndex = 28;
   this.label4.Text = "Position:";
   // 
   // txtInclusiveDates
   // 
   this.txtInclusiveDates.Location = new System.Drawing.Point(112, 106);
   this.txtInclusiveDates.MaxLength = 50;
   this.txtInclusiveDates.Name = "txtInclusiveDates";
   this.txtInclusiveDates.Size = new System.Drawing.Size(313, 21);
   this.txtInclusiveDates.TabIndex = 2;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(12, 110);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(92, 15);
   this.label2.TabIndex = 27;
   this.label2.Text = "Inclusive Dates:";
   // 
   // txtRemarks
   // 
   this.txtRemarks.Location = new System.Drawing.Point(112, 133);
   this.txtRemarks.MaxLength = 50;
   this.txtRemarks.Multiline = true;
   this.txtRemarks.Name = "txtRemarks";
   this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtRemarks.Size = new System.Drawing.Size(415, 160);
   this.txtRemarks.TabIndex = 3;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(12, 135);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(60, 15);
   this.label7.TabIndex = 26;
   this.label7.Text = "Remarks:";
   // 
   // txtEmpName
   // 
   this.txtEmpName.BackColor = System.Drawing.Color.Ivory;
   this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtEmpName.Location = new System.Drawing.Point(112, 25);
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
   // txtOrganization
   // 
   this.txtOrganization.Location = new System.Drawing.Point(112, 52);
   this.txtOrganization.MaxLength = 50;
   this.txtOrganization.Name = "txtOrganization";
   this.txtOrganization.Size = new System.Drawing.Size(413, 21);
   this.txtOrganization.TabIndex = 0;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 57);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(80, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Organization:";
   // 
   // frmEmployeeAffiliationAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(560, 362);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmEmployeeAffiliationAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add New Employee\'s Affiliation";
   this.Load += new System.EventHandler(this.frmEmployeeAffiliationAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtInclusiveDates;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtRemarks;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtEmpName;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtOrganization;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtPosition;
  private System.Windows.Forms.Label label4;
 }
}