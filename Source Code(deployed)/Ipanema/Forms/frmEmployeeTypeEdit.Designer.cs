namespace Ipanema.Forms
{
 partial class frmEmployeeTypeEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeTypeEdit));
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtEmployeeTypeCode = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.txtType = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.txtDetails = new System.Windows.Forms.TextBox();
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtEmployeeTypeCode);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.txtType);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Controls.Add(this.txtDetails);
   this.groupBox1.Location = new System.Drawing.Point(9, 5);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(372, 183);
   this.groupBox1.TabIndex = 0;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Employee Type Details";
   // 
   // txtEmployeeTypeCode
   // 
   this.txtEmployeeTypeCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtEmployeeTypeCode.Location = new System.Drawing.Point(70, 25);
   this.txtEmployeeTypeCode.MaxLength = 20;
   this.txtEmployeeTypeCode.Name = "txtEmployeeTypeCode";
   this.txtEmployeeTypeCode.Size = new System.Drawing.Size(95, 21);
   this.txtEmployeeTypeCode.TabIndex = 17;
   this.txtEmployeeTypeCode.TabStop = false;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(12, 27);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(39, 15);
   this.label3.TabIndex = 18;
   this.label3.Text = "Code:";
   // 
   // txtType
   // 
   this.txtType.Location = new System.Drawing.Point(70, 55);
   this.txtType.MaxLength = 20;
   this.txtType.Name = "txtType";
   this.txtType.Size = new System.Drawing.Size(292, 21);
   this.txtType.TabIndex = 0;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(12, 87);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(48, 15);
   this.label2.TabIndex = 16;
   this.label2.Text = "Details:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 58);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(36, 15);
   this.label1.TabIndex = 14;
   this.label1.Text = "Type:";
   // 
   // txtDetails
   // 
   this.txtDetails.Location = new System.Drawing.Point(70, 85);
   this.txtDetails.MaxLength = 50;
   this.txtDetails.Multiline = true;
   this.txtDetails.Name = "txtDetails";
   this.txtDetails.Size = new System.Drawing.Size(292, 86);
   this.txtDetails.TabIndex = 1;
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(303, 196);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 3;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(216, 196);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 2;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // frmEmployeeTypeEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(391, 242);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmEmployeeTypeEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit Employee Type";
   this.Load += new System.EventHandler(this.frmEmployeeTypeEdit_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtType;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtDetails;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.TextBox txtEmployeeTypeCode;
  private System.Windows.Forms.Label label3;
 }
}