namespace Ipanema.Forms
{
 partial class frmLeaveDetails
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaveDetails));
   this.btnClose = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtApproverRemarks = new System.Windows.Forms.TextBox();
   this.label12 = new System.Windows.Forms.Label();
   this.txtDateProcessed = new System.Windows.Forms.TextBox();
   this.label11 = new System.Windows.Forms.Label();
   this.txtApprover = new System.Windows.Forms.TextBox();
   this.label10 = new System.Windows.Forms.Label();
   this.txtUnits = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.txtEnd = new System.Windows.Forms.TextBox();
   this.label9 = new System.Windows.Forms.Label();
   this.txtStart = new System.Windows.Forms.TextBox();
   this.label8 = new System.Windows.Forms.Label();
   this.txtFiled = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtStatus = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.txtLeaveType = new System.Windows.Forms.TextBox();
   this.label5 = new System.Windows.Forms.Label();
   this.txtRequestor = new System.Windows.Forms.TextBox();
   this.txtReason = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.txtLeaveCode = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(181, 403);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(79, 35);
   this.btnClose.TabIndex = 0;
   this.btnClose.Text = "Close ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtApproverRemarks);
   this.groupBox1.Controls.Add(this.label12);
   this.groupBox1.Controls.Add(this.txtDateProcessed);
   this.groupBox1.Controls.Add(this.label11);
   this.groupBox1.Controls.Add(this.txtApprover);
   this.groupBox1.Controls.Add(this.label10);
   this.groupBox1.Controls.Add(this.txtUnits);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.txtEnd);
   this.groupBox1.Controls.Add(this.label9);
   this.groupBox1.Controls.Add(this.txtStart);
   this.groupBox1.Controls.Add(this.label8);
   this.groupBox1.Controls.Add(this.txtFiled);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.txtStatus);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.txtLeaveType);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.txtRequestor);
   this.groupBox1.Controls.Add(this.txtReason);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.txtLeaveCode);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(13, 9);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(408, 383);
   this.groupBox1.TabIndex = 14;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Application For Leave Details";
   // 
   // txtApproverRemarks
   // 
   this.txtApproverRemarks.BackColor = System.Drawing.Color.AliceBlue;
   this.txtApproverRemarks.Location = new System.Drawing.Point(118, 329);
   this.txtApproverRemarks.MaxLength = 255;
   this.txtApproverRemarks.Multiline = true;
   this.txtApproverRemarks.Name = "txtApproverRemarks";
   this.txtApproverRemarks.ReadOnly = true;
   this.txtApproverRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtApproverRemarks.Size = new System.Drawing.Size(276, 41);
   this.txtApproverRemarks.TabIndex = 12;
   // 
   // label12
   // 
   this.label12.AutoSize = true;
   this.label12.Location = new System.Drawing.Point(14, 328);
   this.label12.Name = "label12";
   this.label12.Size = new System.Drawing.Size(60, 15);
   this.label12.TabIndex = 25;
   this.label12.Text = "Remarks:";
   // 
   // txtDateProcessed
   // 
   this.txtDateProcessed.BackColor = System.Drawing.Color.AliceBlue;
   this.txtDateProcessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDateProcessed.Location = new System.Drawing.Point(118, 298);
   this.txtDateProcessed.MaxLength = 6;
   this.txtDateProcessed.Name = "txtDateProcessed";
   this.txtDateProcessed.ReadOnly = true;
   this.txtDateProcessed.Size = new System.Drawing.Size(108, 20);
   this.txtDateProcessed.TabIndex = 11;
   // 
   // label11
   // 
   this.label11.AutoSize = true;
   this.label11.Location = new System.Drawing.Point(14, 301);
   this.label11.Name = "label11";
   this.label11.Size = new System.Drawing.Size(97, 15);
   this.label11.TabIndex = 22;
   this.label11.Text = "Date Processed:";
   // 
   // txtApprover
   // 
   this.txtApprover.BackColor = System.Drawing.Color.AliceBlue;
   this.txtApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtApprover.Location = new System.Drawing.Point(118, 265);
   this.txtApprover.MaxLength = 6;
   this.txtApprover.Name = "txtApprover";
   this.txtApprover.ReadOnly = true;
   this.txtApprover.Size = new System.Drawing.Size(277, 20);
   this.txtApprover.TabIndex = 10;
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Location = new System.Drawing.Point(14, 268);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(58, 15);
   this.label10.TabIndex = 20;
   this.label10.Text = "Approver:";
   // 
   // txtUnits
   // 
   this.txtUnits.BackColor = System.Drawing.Color.AliceBlue;
   this.txtUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtUnits.Location = new System.Drawing.Point(279, 120);
   this.txtUnits.MaxLength = 6;
   this.txtUnits.Name = "txtUnits";
   this.txtUnits.ReadOnly = true;
   this.txtUnits.Size = new System.Drawing.Size(69, 20);
   this.txtUnits.TabIndex = 6;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(234, 125);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(38, 15);
   this.label4.TabIndex = 18;
   this.label4.Text = "Units:";
   // 
   // txtEnd
   // 
   this.txtEnd.BackColor = System.Drawing.Color.AliceBlue;
   this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtEnd.Location = new System.Drawing.Point(118, 182);
   this.txtEnd.MaxLength = 6;
   this.txtEnd.Name = "txtEnd";
   this.txtEnd.ReadOnly = true;
   this.txtEnd.Size = new System.Drawing.Size(133, 20);
   this.txtEnd.TabIndex = 8;
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Location = new System.Drawing.Point(14, 186);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(61, 15);
   this.label9.TabIndex = 16;
   this.label9.Text = "Date End:";
   // 
   // txtStart
   // 
   this.txtStart.BackColor = System.Drawing.Color.AliceBlue;
   this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtStart.Location = new System.Drawing.Point(118, 150);
   this.txtStart.MaxLength = 6;
   this.txtStart.Name = "txtStart";
   this.txtStart.ReadOnly = true;
   this.txtStart.Size = new System.Drawing.Size(133, 20);
   this.txtStart.TabIndex = 7;
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Location = new System.Drawing.Point(14, 153);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(64, 15);
   this.label8.TabIndex = 14;
   this.label8.Text = "Date Start:";
   // 
   // txtFiled
   // 
   this.txtFiled.BackColor = System.Drawing.Color.AliceBlue;
   this.txtFiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtFiled.Location = new System.Drawing.Point(118, 120);
   this.txtFiled.MaxLength = 6;
   this.txtFiled.Name = "txtFiled";
   this.txtFiled.ReadOnly = true;
   this.txtFiled.Size = new System.Drawing.Size(108, 20);
   this.txtFiled.TabIndex = 5;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(14, 125);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(66, 15);
   this.label7.TabIndex = 12;
   this.label7.Text = "Date Filed:";
   // 
   // txtStatus
   // 
   this.txtStatus.BackColor = System.Drawing.Color.AliceBlue;
   this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtStatus.Location = new System.Drawing.Point(268, 27);
   this.txtStatus.MaxLength = 6;
   this.txtStatus.Name = "txtStatus";
   this.txtStatus.ReadOnly = true;
   this.txtStatus.Size = new System.Drawing.Size(125, 20);
   this.txtStatus.TabIndex = 2;
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(219, 31);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(44, 15);
   this.label6.TabIndex = 10;
   this.label6.Text = "Status:";
   // 
   // txtLeaveType
   // 
   this.txtLeaveType.BackColor = System.Drawing.Color.AliceBlue;
   this.txtLeaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtLeaveType.Location = new System.Drawing.Point(118, 88);
   this.txtLeaveType.MaxLength = 6;
   this.txtLeaveType.Name = "txtLeaveType";
   this.txtLeaveType.ReadOnly = true;
   this.txtLeaveType.Size = new System.Drawing.Size(277, 20);
   this.txtLeaveType.TabIndex = 4;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(14, 91);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(72, 15);
   this.label5.TabIndex = 8;
   this.label5.Text = "Leave Type:";
   // 
   // txtRequestor
   // 
   this.txtRequestor.BackColor = System.Drawing.Color.AliceBlue;
   this.txtRequestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtRequestor.Location = new System.Drawing.Point(118, 55);
   this.txtRequestor.MaxLength = 6;
   this.txtRequestor.Name = "txtRequestor";
   this.txtRequestor.ReadOnly = true;
   this.txtRequestor.Size = new System.Drawing.Size(264, 20);
   this.txtRequestor.TabIndex = 3;
   // 
   // txtReason
   // 
   this.txtReason.BackColor = System.Drawing.Color.AliceBlue;
   this.txtReason.Location = new System.Drawing.Point(118, 215);
   this.txtReason.MaxLength = 255;
   this.txtReason.Multiline = true;
   this.txtReason.Name = "txtReason";
   this.txtReason.ReadOnly = true;
   this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtReason.Size = new System.Drawing.Size(276, 41);
   this.txtReason.TabIndex = 9;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(14, 213);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(53, 15);
   this.label3.TabIndex = 4;
   this.label3.Text = "Reason:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(14, 60);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(67, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Requestor:";
   // 
   // txtLeaveCode
   // 
   this.txtLeaveCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtLeaveCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtLeaveCode.Location = new System.Drawing.Point(118, 27);
   this.txtLeaveCode.MaxLength = 6;
   this.txtLeaveCode.Name = "txtLeaveCode";
   this.txtLeaveCode.ReadOnly = true;
   this.txtLeaveCode.Size = new System.Drawing.Size(91, 20);
   this.txtLeaveCode.TabIndex = 1;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(14, 31);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(75, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Leave Code:";
   // 
   // frmLeaveDetails
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(434, 447);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmLeaveDetails";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Leave Details";
   this.Load += new System.EventHandler(this.frmLeaveDetails_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtApproverRemarks;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.TextBox txtDateProcessed;
  private System.Windows.Forms.Label label11;
  private System.Windows.Forms.TextBox txtApprover;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.TextBox txtUnits;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtEnd;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.TextBox txtStart;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.TextBox txtFiled;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtStatus;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtLeaveType;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtRequestor;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtLeaveCode;
  private System.Windows.Forms.Label label1;
 }
}