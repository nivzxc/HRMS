namespace Ipanema.Forms
{
 partial class frmLeaveBalanceEdit
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaveBalanceEdit));
      this.btnClose = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtEntitlement = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.chkStatus = new System.Windows.Forms.CheckBox();
      this.txtBalance = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtMaxBalance = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtHasBalance = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtWithPay = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtLeaveType = new System.Windows.Forms.TextBox();
      this.txtLeaveTypeCode = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtEmployee = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
      this.btnClose.Location = new System.Drawing.Point(286, 182);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(80, 38);
      this.btnClose.TabIndex = 4;
      this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnSave
      // 
      this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
      this.btnSave.Location = new System.Drawing.Point(197, 182);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(80, 38);
      this.btnSave.TabIndex = 3;
      this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtEntitlement);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.chkStatus);
      this.groupBox1.Controls.Add(this.txtBalance);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.txtMaxBalance);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.txtHasBalance);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.txtWithPay);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txtLeaveType);
      this.groupBox1.Controls.Add(this.txtLeaveTypeCode);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtEmployee);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(13, 7);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(351, 166);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Leave Entitlement Details";
      // 
      // txtEntitlement
      // 
      this.txtEntitlement.BackColor = System.Drawing.Color.White;
      this.txtEntitlement.Location = new System.Drawing.Point(225, 134);
      this.txtEntitlement.MaxLength = 50;
      this.txtEntitlement.Name = "txtEntitlement";
      this.txtEntitlement.Size = new System.Drawing.Size(42, 21);
      this.txtEntitlement.TabIndex = 2;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(152, 137);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(72, 15);
      this.label7.TabIndex = 18;
      this.label7.Text = "Entitlement:";
      // 
      // chkStatus
      // 
      this.chkStatus.AutoSize = true;
      this.chkStatus.Location = new System.Drawing.Point(175, 110);
      this.chkStatus.Name = "chkStatus";
      this.chkStatus.Size = new System.Drawing.Size(65, 17);
      this.chkStatus.TabIndex = 0;
      this.chkStatus.Text = "Enabled";
      this.chkStatus.UseVisualStyleBackColor = true;
      // 
      // txtBalance
      // 
      this.txtBalance.BackColor = System.Drawing.Color.White;
      this.txtBalance.Location = new System.Drawing.Point(99, 134);
      this.txtBalance.MaxLength = 50;
      this.txtBalance.Name = "txtBalance";
      this.txtBalance.Size = new System.Drawing.Size(35, 21);
      this.txtBalance.TabIndex = 1;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(13, 137);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(55, 15);
      this.label6.TabIndex = 15;
      this.label6.Text = "Balance:";
      // 
      // txtMaxBalance
      // 
      this.txtMaxBalance.BackColor = System.Drawing.Color.AliceBlue;
      this.txtMaxBalance.Location = new System.Drawing.Point(99, 107);
      this.txtMaxBalance.MaxLength = 50;
      this.txtMaxBalance.Name = "txtMaxBalance";
      this.txtMaxBalance.ReadOnly = true;
      this.txtMaxBalance.Size = new System.Drawing.Size(60, 21);
      this.txtMaxBalance.TabIndex = 8;
      this.txtMaxBalance.TabStop = false;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(13, 110);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(82, 15);
      this.label5.TabIndex = 13;
      this.label5.Text = "Max Balance:";
      // 
      // txtHasBalance
      // 
      this.txtHasBalance.BackColor = System.Drawing.Color.AliceBlue;
      this.txtHasBalance.Location = new System.Drawing.Point(240, 80);
      this.txtHasBalance.MaxLength = 50;
      this.txtHasBalance.Name = "txtHasBalance";
      this.txtHasBalance.ReadOnly = true;
      this.txtHasBalance.Size = new System.Drawing.Size(35, 21);
      this.txtHasBalance.TabIndex = 7;
      this.txtHasBalance.TabStop = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(150, 82);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(80, 15);
      this.label4.TabIndex = 11;
      this.label4.Text = "Has Balance:";
      // 
      // txtWithPay
      // 
      this.txtWithPay.BackColor = System.Drawing.Color.AliceBlue;
      this.txtWithPay.Location = new System.Drawing.Point(99, 80);
      this.txtWithPay.MaxLength = 50;
      this.txtWithPay.Name = "txtWithPay";
      this.txtWithPay.ReadOnly = true;
      this.txtWithPay.Size = new System.Drawing.Size(35, 21);
      this.txtWithPay.TabIndex = 6;
      this.txtWithPay.TabStop = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 82);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(57, 15);
      this.label3.TabIndex = 9;
      this.label3.Text = "With Pay:";
      // 
      // txtLeaveType
      // 
      this.txtLeaveType.BackColor = System.Drawing.Color.AliceBlue;
      this.txtLeaveType.Location = new System.Drawing.Point(143, 53);
      this.txtLeaveType.MaxLength = 50;
      this.txtLeaveType.Name = "txtLeaveType";
      this.txtLeaveType.ReadOnly = true;
      this.txtLeaveType.Size = new System.Drawing.Size(197, 21);
      this.txtLeaveType.TabIndex = 5;
      this.txtLeaveType.TabStop = false;
      // 
      // txtLeaveTypeCode
      // 
      this.txtLeaveTypeCode.BackColor = System.Drawing.Color.AliceBlue;
      this.txtLeaveTypeCode.Location = new System.Drawing.Point(99, 53);
      this.txtLeaveTypeCode.MaxLength = 50;
      this.txtLeaveTypeCode.Name = "txtLeaveTypeCode";
      this.txtLeaveTypeCode.ReadOnly = true;
      this.txtLeaveTypeCode.Size = new System.Drawing.Size(35, 21);
      this.txtLeaveTypeCode.TabIndex = 4;
      this.txtLeaveTypeCode.TabStop = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 56);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 15);
      this.label2.TabIndex = 2;
      this.label2.Text = "Leave Type:";
      // 
      // txtEmployee
      // 
      this.txtEmployee.BackColor = System.Drawing.Color.AliceBlue;
      this.txtEmployee.Location = new System.Drawing.Point(99, 26);
      this.txtEmployee.MaxLength = 6;
      this.txtEmployee.Name = "txtEmployee";
      this.txtEmployee.ReadOnly = true;
      this.txtEmployee.Size = new System.Drawing.Size(240, 21);
      this.txtEmployee.TabIndex = 3;
      this.txtEmployee.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Employee:";
      // 
      // frmLeaveBalanceEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.AliceBlue;
      this.CancelButton = this.btnClose;
      this.ClientSize = new System.Drawing.Size(376, 230);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmLeaveBalanceEdit";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Edit Leave Balance";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLeaveBalanceEdit_FormClosing);
      this.Load += new System.EventHandler(this.frmLeaveBalanceEdit_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtBalance;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtMaxBalance;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtHasBalance;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtWithPay;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtLeaveType;
  private System.Windows.Forms.TextBox txtLeaveTypeCode;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtEmployee;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.CheckBox chkStatus;
  private System.Windows.Forms.TextBox txtEntitlement;
  private System.Windows.Forms.Label label7;
 }
}