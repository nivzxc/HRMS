namespace Ipanema.Forms
{
 partial class frmLeaveTypeEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaveTypeEdit));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.chkStatus = new System.Windows.Forms.CheckBox();
   this.txtMaxBalance = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.chkHasBalance = new System.Windows.Forms.CheckBox();
   this.chkWithPay = new System.Windows.Forms.CheckBox();
   this.txtCode = new System.Windows.Forms.TextBox();
   this.label5 = new System.Windows.Forms.Label();
   this.txtLeaveType = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(311, 166);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(79, 38);
   this.btnClose.TabIndex = 6;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(225, 166);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(79, 38);
   this.btnSave.TabIndex = 5;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.chkStatus);
   this.groupBox1.Controls.Add(this.txtMaxBalance);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.chkHasBalance);
   this.groupBox1.Controls.Add(this.chkWithPay);
   this.groupBox1.Controls.Add(this.txtCode);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.txtLeaveType);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(10, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(379, 150);
   this.groupBox1.TabIndex = 21;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Leave Type Details";
   // 
   // chkStatus
   // 
   this.chkStatus.AutoSize = true;
   this.chkStatus.Location = new System.Drawing.Point(151, 27);
   this.chkStatus.Name = "chkStatus";
   this.chkStatus.Size = new System.Drawing.Size(57, 19);
   this.chkStatus.TabIndex = 4;
   this.chkStatus.Text = "Active";
   this.chkStatus.UseVisualStyleBackColor = true;
   // 
   // txtMaxBalance
   // 
   this.txtMaxBalance.Enabled = false;
   this.txtMaxBalance.Location = new System.Drawing.Point(187, 121);
   this.txtMaxBalance.MaxLength = 50;
   this.txtMaxBalance.Name = "txtMaxBalance";
   this.txtMaxBalance.Size = new System.Drawing.Size(79, 21);
   this.txtMaxBalance.TabIndex = 3;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(100, 123);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(82, 15);
   this.label2.TabIndex = 13;
   this.label2.Text = "Max Balance:";
   // 
   // chkHasBalance
   // 
   this.chkHasBalance.AutoSize = true;
   this.chkHasBalance.Location = new System.Drawing.Point(84, 100);
   this.chkHasBalance.Name = "chkHasBalance";
   this.chkHasBalance.Size = new System.Drawing.Size(103, 19);
   this.chkHasBalance.TabIndex = 2;
   this.chkHasBalance.Text = "Has Balance?";
   this.chkHasBalance.UseVisualStyleBackColor = true;
   this.chkHasBalance.CheckedChanged += new System.EventHandler(this.chkHasBalance_CheckedChanged);
   // 
   // chkWithPay
   // 
   this.chkWithPay.AutoSize = true;
   this.chkWithPay.Location = new System.Drawing.Point(84, 79);
   this.chkWithPay.Name = "chkWithPay";
   this.chkWithPay.Size = new System.Drawing.Size(80, 19);
   this.chkWithPay.TabIndex = 1;
   this.chkWithPay.Text = "With Pay?";
   this.chkWithPay.UseVisualStyleBackColor = true;
   // 
   // txtCode
   // 
   this.txtCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtCode.Location = new System.Drawing.Point(84, 26);
   this.txtCode.MaxLength = 8;
   this.txtCode.Name = "txtCode";
   this.txtCode.ReadOnly = true;
   this.txtCode.Size = new System.Drawing.Size(56, 20);
   this.txtCode.TabIndex = 0;
   this.txtCode.TabStop = false;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(9, 27);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(39, 15);
   this.label5.TabIndex = 9;
   this.label5.Text = "Code:";
   // 
   // txtLeaveType
   // 
   this.txtLeaveType.Location = new System.Drawing.Point(84, 53);
   this.txtLeaveType.MaxLength = 50;
   this.txtLeaveType.Name = "txtLeaveType";
   this.txtLeaveType.Size = new System.Drawing.Size(284, 21);
   this.txtLeaveType.TabIndex = 0;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(9, 57);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(72, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Leave Type:";
   // 
   // frmLeaveTypeEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(399, 214);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmLeaveTypeEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit Leave Type";
   this.Load += new System.EventHandler(this.frmLeaveTypeEdit_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtMaxBalance;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.CheckBox chkHasBalance;
  private System.Windows.Forms.CheckBox chkWithPay;
  private System.Windows.Forms.TextBox txtCode;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtLeaveType;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.CheckBox chkStatus;
 }
}