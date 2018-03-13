namespace Ipanema.Forms
{
 partial class frmEmployeeResearchAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeResearchAdd));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtDateCompleted = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.txtRemarks = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtEmpName = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.txtTitle = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(405, 240);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(73, 30);
   this.btnClose.TabIndex = 5;
   this.btnClose.Text = "Close  ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(323, 240);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(73, 30);
   this.btnSave.TabIndex = 4;
   this.btnSave.Text = "Save  ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtDateCompleted);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.txtRemarks);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.txtEmpName);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.txtTitle);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(9, 5);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(468, 228);
   this.groupBox1.TabIndex = 47;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Research/Publication Details";
   this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
   // 
   // txtDateCompleted
   // 
   this.txtDateCompleted.Location = new System.Drawing.Point(98, 78);
   this.txtDateCompleted.MaxLength = 50;
   this.txtDateCompleted.Name = "txtDateCompleted";
   this.txtDateCompleted.Size = new System.Drawing.Size(249, 20);
   this.txtDateCompleted.TabIndex = 1;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(9, 82);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(86, 13);
   this.label4.TabIndex = 28;
   this.label4.Text = "Date Completed:";
   // 
   // txtRemarks
   // 
   this.txtRemarks.Location = new System.Drawing.Point(98, 106);
   this.txtRemarks.MaxLength = 50;
   this.txtRemarks.Multiline = true;
   this.txtRemarks.Name = "txtRemarks";
   this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtRemarks.Size = new System.Drawing.Size(356, 110);
   this.txtRemarks.TabIndex = 2;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(9, 108);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(52, 13);
   this.label7.TabIndex = 26;
   this.label7.Text = "Remarks:";
   // 
   // txtEmpName
   // 
   this.txtEmpName.BackColor = System.Drawing.Color.Ivory;
   this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtEmpName.Location = new System.Drawing.Point(98, 24);
   this.txtEmpName.Name = "txtEmpName";
   this.txtEmpName.ReadOnly = true;
   this.txtEmpName.Size = new System.Drawing.Size(247, 21);
   this.txtEmpName.TabIndex = 0;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(9, 29);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(56, 13);
   this.label3.TabIndex = 6;
   this.label3.Text = "Employee:";
   // 
   // txtTitle
   // 
   this.txtTitle.Location = new System.Drawing.Point(98, 51);
   this.txtTitle.MaxLength = 50;
   this.txtTitle.Name = "txtTitle";
   this.txtTitle.Size = new System.Drawing.Size(355, 20);
   this.txtTitle.TabIndex = 0;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(9, 56);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(30, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "Title:";
   // 
   // frmEmployeeResearchAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(486, 277);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmEmployeeResearchAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add New Employee\'s Research/Publication";
   this.Load += new System.EventHandler(this.frmEmployeeResearchAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtRemarks;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtEmpName;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtTitle;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtDateCompleted;
 }
}