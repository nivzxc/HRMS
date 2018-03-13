namespace Ipanema.Forms
{
 partial class frmUndertimeView
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUndertimeView));
   this.btnClose = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtApproverRemarks = new System.Windows.Forms.TextBox();
   this.label12 = new System.Windows.Forms.Label();
   this.txtDateProcessed = new System.Windows.Forms.TextBox();
   this.label11 = new System.Windows.Forms.Label();
   this.txtApprover = new System.Windows.Forms.TextBox();
   this.label10 = new System.Windows.Forms.Label();
   this.txtApplied = new System.Windows.Forms.TextBox();
   this.label8 = new System.Windows.Forms.Label();
   this.txtFiled = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtStatus = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.txtRequestor = new System.Windows.Forms.TextBox();
   this.txtReason = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.txtUndertimeCode = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(294, 290);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(68, 30);
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
   this.groupBox1.Controls.Add(this.txtApplied);
   this.groupBox1.Controls.Add(this.label8);
   this.groupBox1.Controls.Add(this.txtFiled);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.txtStatus);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.txtRequestor);
   this.groupBox1.Controls.Add(this.txtReason);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.txtUndertimeCode);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(11, 8);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(350, 274);
   this.groupBox1.TabIndex = 14;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Application For Undertime Details";
   // 
   // txtApproverRemarks
   // 
   this.txtApproverRemarks.BackColor = System.Drawing.Color.Ivory;
   this.txtApproverRemarks.Location = new System.Drawing.Point(101, 227);
   this.txtApproverRemarks.MaxLength = 255;
   this.txtApproverRemarks.Multiline = true;
   this.txtApproverRemarks.Name = "txtApproverRemarks";
   this.txtApproverRemarks.ReadOnly = true;
   this.txtApproverRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtApproverRemarks.Size = new System.Drawing.Size(237, 36);
   this.txtApproverRemarks.TabIndex = 11;
   // 
   // label12
   // 
   this.label12.AutoSize = true;
   this.label12.Location = new System.Drawing.Point(12, 227);
   this.label12.Name = "label12";
   this.label12.Size = new System.Drawing.Size(52, 13);
   this.label12.TabIndex = 25;
   this.label12.Text = "Remarks:";
   // 
   // txtDateProcessed
   // 
   this.txtDateProcessed.BackColor = System.Drawing.Color.Ivory;
   this.txtDateProcessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDateProcessed.Location = new System.Drawing.Point(101, 200);
   this.txtDateProcessed.MaxLength = 6;
   this.txtDateProcessed.Name = "txtDateProcessed";
   this.txtDateProcessed.ReadOnly = true;
   this.txtDateProcessed.Size = new System.Drawing.Size(190, 20);
   this.txtDateProcessed.TabIndex = 10;
   // 
   // label11
   // 
   this.label11.AutoSize = true;
   this.label11.Location = new System.Drawing.Point(12, 203);
   this.label11.Name = "label11";
   this.label11.Size = new System.Drawing.Size(86, 13);
   this.label11.TabIndex = 22;
   this.label11.Text = "Date Processed:";
   // 
   // txtApprover
   // 
   this.txtApprover.BackColor = System.Drawing.Color.Ivory;
   this.txtApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtApprover.Location = new System.Drawing.Point(101, 172);
   this.txtApprover.MaxLength = 6;
   this.txtApprover.Name = "txtApprover";
   this.txtApprover.ReadOnly = true;
   this.txtApprover.Size = new System.Drawing.Size(238, 20);
   this.txtApprover.TabIndex = 9;
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Location = new System.Drawing.Point(12, 174);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(53, 13);
   this.label10.TabIndex = 20;
   this.label10.Text = "Approver:";
   // 
   // txtApplied
   // 
   this.txtApplied.BackColor = System.Drawing.Color.Ivory;
   this.txtApplied.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtApplied.Location = new System.Drawing.Point(101, 101);
   this.txtApplied.MaxLength = 6;
   this.txtApplied.Name = "txtApplied";
   this.txtApplied.ReadOnly = true;
   this.txtApplied.Size = new System.Drawing.Size(164, 20);
   this.txtApplied.TabIndex = 6;
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Location = new System.Drawing.Point(12, 104);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(71, 13);
   this.label8.TabIndex = 14;
   this.label8.Text = "Date Applied:";
   // 
   // txtFiled
   // 
   this.txtFiled.BackColor = System.Drawing.Color.Ivory;
   this.txtFiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtFiled.Location = new System.Drawing.Point(101, 75);
   this.txtFiled.MaxLength = 6;
   this.txtFiled.Name = "txtFiled";
   this.txtFiled.ReadOnly = true;
   this.txtFiled.Size = new System.Drawing.Size(93, 20);
   this.txtFiled.TabIndex = 4;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(12, 79);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(58, 13);
   this.label7.TabIndex = 12;
   this.label7.Text = "Date Filed:";
   // 
   // txtStatus
   // 
   this.txtStatus.BackColor = System.Drawing.Color.Ivory;
   this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtStatus.Location = new System.Drawing.Point(230, 23);
   this.txtStatus.MaxLength = 6;
   this.txtStatus.Name = "txtStatus";
   this.txtStatus.ReadOnly = true;
   this.txtStatus.Size = new System.Drawing.Size(108, 20);
   this.txtStatus.TabIndex = 1;
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(188, 27);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(40, 13);
   this.label6.TabIndex = 10;
   this.label6.Text = "Status:";
   // 
   // txtRequestor
   // 
   this.txtRequestor.BackColor = System.Drawing.Color.Ivory;
   this.txtRequestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtRequestor.Location = new System.Drawing.Point(101, 48);
   this.txtRequestor.MaxLength = 6;
   this.txtRequestor.Name = "txtRequestor";
   this.txtRequestor.ReadOnly = true;
   this.txtRequestor.Size = new System.Drawing.Size(227, 20);
   this.txtRequestor.TabIndex = 2;
   // 
   // txtReason
   // 
   this.txtReason.BackColor = System.Drawing.Color.Ivory;
   this.txtReason.Location = new System.Drawing.Point(101, 128);
   this.txtReason.MaxLength = 255;
   this.txtReason.Multiline = true;
   this.txtReason.Name = "txtReason";
   this.txtReason.ReadOnly = true;
   this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtReason.Size = new System.Drawing.Size(237, 36);
   this.txtReason.TabIndex = 8;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(12, 128);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(47, 13);
   this.label3.TabIndex = 4;
   this.label3.Text = "Reason:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(12, 52);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(59, 13);
   this.label2.TabIndex = 2;
   this.label2.Text = "Requestor:";
   // 
   // txtUndertimeCode
   // 
   this.txtUndertimeCode.BackColor = System.Drawing.Color.Ivory;
   this.txtUndertimeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtUndertimeCode.Location = new System.Drawing.Point(101, 23);
   this.txtUndertimeCode.MaxLength = 6;
   this.txtUndertimeCode.Name = "txtUndertimeCode";
   this.txtUndertimeCode.ReadOnly = true;
   this.txtUndertimeCode.Size = new System.Drawing.Size(79, 20);
   this.txtUndertimeCode.TabIndex = 1;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 27);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(53, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "UT Code:";
   // 
   // frmUndertimeView
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(372, 327);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.groupBox1);
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmUndertimeView";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Undertime Details";
   this.Load += new System.EventHandler(this.frmUndertimeView_Load);
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
  private System.Windows.Forms.TextBox txtApplied;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.TextBox txtFiled;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtStatus;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtRequestor;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtUndertimeCode;
  private System.Windows.Forms.Label label1;
 }
}