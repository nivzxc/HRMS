namespace Ipanema.Forms
{
 partial class frmUndertimeApplications
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUndertimeApplications));
   this.btnClose = new System.Windows.Forms.Button();
   this.groupBox2 = new System.Windows.Forms.GroupBox();
   this.lblStatus = new System.Windows.Forms.Label();
   this.lblRemarks = new System.Windows.Forms.Label();
   this.lblDate = new System.Windows.Forms.Label();
   this.lblApprover = new System.Windows.Forms.Label();
   this.lblApplication = new System.Windows.Forms.Label();
   this.lblDateFile = new System.Windows.Forms.Label();
   this.lblRequestor = new System.Windows.Forms.Label();
   this.lblReason = new System.Windows.Forms.Label();
   this.lblUTCode = new System.Windows.Forms.Label();
   this.label12 = new System.Windows.Forms.Label();
   this.label11 = new System.Windows.Forms.Label();
   this.label10 = new System.Windows.Forms.Label();
   this.label9 = new System.Windows.Forms.Label();
   this.label7 = new System.Windows.Forms.Label();
   this.label6 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.cmbFilter = new System.Windows.Forms.ComboBox();
   this.lvwUndertime = new System.Windows.Forms.ListView();
   this.chOTCode = new System.Windows.Forms.ColumnHeader();
   this.groupBox2.SuspendLayout();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(402, 324);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(72, 30);
   this.btnClose.TabIndex = 19;
   this.btnClose.Text = "Close ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // groupBox2
   // 
   this.groupBox2.Controls.Add(this.lblStatus);
   this.groupBox2.Controls.Add(this.lblRemarks);
   this.groupBox2.Controls.Add(this.lblDate);
   this.groupBox2.Controls.Add(this.lblApprover);
   this.groupBox2.Controls.Add(this.lblApplication);
   this.groupBox2.Controls.Add(this.lblDateFile);
   this.groupBox2.Controls.Add(this.lblRequestor);
   this.groupBox2.Controls.Add(this.lblReason);
   this.groupBox2.Controls.Add(this.lblUTCode);
   this.groupBox2.Controls.Add(this.label12);
   this.groupBox2.Controls.Add(this.label11);
   this.groupBox2.Controls.Add(this.label10);
   this.groupBox2.Controls.Add(this.label9);
   this.groupBox2.Controls.Add(this.label7);
   this.groupBox2.Controls.Add(this.label6);
   this.groupBox2.Controls.Add(this.label3);
   this.groupBox2.Controls.Add(this.label2);
   this.groupBox2.Controls.Add(this.label1);
   this.groupBox2.Location = new System.Drawing.Point(148, 7);
   this.groupBox2.Name = "groupBox2";
   this.groupBox2.Size = new System.Drawing.Size(326, 307);
   this.groupBox2.TabIndex = 18;
   this.groupBox2.TabStop = false;
   this.groupBox2.Text = "Application For OB Details";
   // 
   // lblStatus
   // 
   this.lblStatus.BackColor = System.Drawing.Color.Ivory;
   this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblStatus.Location = new System.Drawing.Point(214, 25);
   this.lblStatus.Name = "lblStatus";
   this.lblStatus.Size = new System.Drawing.Size(94, 20);
   this.lblStatus.TabIndex = 41;
   // 
   // lblRemarks
   // 
   this.lblRemarks.BackColor = System.Drawing.Color.Ivory;
   this.lblRemarks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRemarks.Location = new System.Drawing.Point(88, 250);
   this.lblRemarks.Name = "lblRemarks";
   this.lblRemarks.Size = new System.Drawing.Size(220, 48);
   this.lblRemarks.TabIndex = 40;
   // 
   // lblDate
   // 
   this.lblDate.BackColor = System.Drawing.Color.Ivory;
   this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblDate.Location = new System.Drawing.Point(88, 223);
   this.lblDate.Name = "lblDate";
   this.lblDate.Size = new System.Drawing.Size(94, 20);
   this.lblDate.TabIndex = 39;
   // 
   // lblApprover
   // 
   this.lblApprover.BackColor = System.Drawing.Color.Ivory;
   this.lblApprover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblApprover.Location = new System.Drawing.Point(88, 197);
   this.lblApprover.Name = "lblApprover";
   this.lblApprover.Size = new System.Drawing.Size(220, 20);
   this.lblApprover.TabIndex = 38;
   // 
   // lblApplication
   // 
   this.lblApplication.BackColor = System.Drawing.Color.Ivory;
   this.lblApplication.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblApplication.Location = new System.Drawing.Point(88, 107);
   this.lblApplication.Name = "lblApplication";
   this.lblApplication.Size = new System.Drawing.Size(166, 20);
   this.lblApplication.TabIndex = 37;
   // 
   // lblDateFile
   // 
   this.lblDateFile.BackColor = System.Drawing.Color.Ivory;
   this.lblDateFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblDateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblDateFile.Location = new System.Drawing.Point(88, 80);
   this.lblDateFile.Name = "lblDateFile";
   this.lblDateFile.Size = new System.Drawing.Size(94, 20);
   this.lblDateFile.TabIndex = 34;
   // 
   // lblRequestor
   // 
   this.lblRequestor.BackColor = System.Drawing.Color.Ivory;
   this.lblRequestor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblRequestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRequestor.Location = new System.Drawing.Point(88, 52);
   this.lblRequestor.Name = "lblRequestor";
   this.lblRequestor.Size = new System.Drawing.Size(220, 20);
   this.lblRequestor.TabIndex = 32;
   // 
   // lblReason
   // 
   this.lblReason.BackColor = System.Drawing.Color.Ivory;
   this.lblReason.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblReason.Location = new System.Drawing.Point(88, 135);
   this.lblReason.Name = "lblReason";
   this.lblReason.Size = new System.Drawing.Size(220, 55);
   this.lblReason.TabIndex = 30;
   // 
   // lblUTCode
   // 
   this.lblUTCode.BackColor = System.Drawing.Color.Ivory;
   this.lblUTCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblUTCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblUTCode.Location = new System.Drawing.Point(88, 25);
   this.lblUTCode.Name = "lblUTCode";
   this.lblUTCode.Size = new System.Drawing.Size(67, 20);
   this.lblUTCode.TabIndex = 29;
   // 
   // label12
   // 
   this.label12.AutoSize = true;
   this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label12.Location = new System.Drawing.Point(11, 247);
   this.label12.Name = "label12";
   this.label12.Size = new System.Drawing.Size(60, 15);
   this.label12.TabIndex = 25;
   this.label12.Text = "Remarks:";
   // 
   // label11
   // 
   this.label11.AutoSize = true;
   this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label11.Location = new System.Drawing.Point(11, 225);
   this.label11.Name = "label11";
   this.label11.Size = new System.Drawing.Size(36, 15);
   this.label11.TabIndex = 22;
   this.label11.Text = "Date:";
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label10.Location = new System.Drawing.Point(11, 196);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(58, 15);
   this.label10.TabIndex = 20;
   this.label10.Text = "Approver:";
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label9.Location = new System.Drawing.Point(11, 110);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(70, 15);
   this.label9.TabIndex = 16;
   this.label9.Text = "Application:";
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label7.Location = new System.Drawing.Point(11, 82);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(66, 15);
   this.label7.TabIndex = 12;
   this.label7.Text = "Date Filed:";
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label6.Location = new System.Drawing.Point(165, 28);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(44, 15);
   this.label6.TabIndex = 10;
   this.label6.Text = "Status:";
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(11, 134);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(53, 15);
   this.label3.TabIndex = 4;
   this.label3.Text = "Reason:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(11, 53);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(67, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Requestor:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(11, 28);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(58, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "UT Code:";
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.cmbFilter);
   this.groupBox1.Controls.Add(this.lvwUndertime);
   this.groupBox1.Location = new System.Drawing.Point(10, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(126, 307);
   this.groupBox1.TabIndex = 17;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Applications";
   // 
   // cmbFilter
   // 
   this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbFilter.FormattingEnabled = true;
   this.cmbFilter.Location = new System.Drawing.Point(10, 26);
   this.cmbFilter.Name = "cmbFilter";
   this.cmbFilter.Size = new System.Drawing.Size(104, 23);
   this.cmbFilter.TabIndex = 53;
   this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
   // 
   // lvwUndertime
   // 
   this.lvwUndertime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOTCode});
   this.lvwUndertime.FullRowSelect = true;
   this.lvwUndertime.GridLines = true;
   this.lvwUndertime.Location = new System.Drawing.Point(10, 56);
   this.lvwUndertime.Name = "lvwUndertime";
   this.lvwUndertime.Size = new System.Drawing.Size(104, 234);
   this.lvwUndertime.TabIndex = 1;
   this.lvwUndertime.UseCompatibleStateImageBehavior = false;
   this.lvwUndertime.View = System.Windows.Forms.View.Details;
   this.lvwUndertime.SelectedIndexChanged += new System.EventHandler(this.lvwUndertime_SelectedIndexChanged);
   // 
   // chOTCode
   // 
   this.chOTCode.Text = "Undertime";
   this.chOTCode.Width = 99;
   // 
   // frmUndertimeApplications
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(484, 361);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.groupBox2);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmUndertimeApplications";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Undertime Applications";
   this.Load += new System.EventHandler(this.frmUndertimeApplications_Load);
   this.groupBox2.ResumeLayout(false);
   this.groupBox2.PerformLayout();
   this.groupBox1.ResumeLayout(false);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.GroupBox groupBox2;
  private System.Windows.Forms.Label lblStatus;
  private System.Windows.Forms.Label lblRemarks;
  private System.Windows.Forms.Label lblDate;
  private System.Windows.Forms.Label lblApprover;
  private System.Windows.Forms.Label lblApplication;
  private System.Windows.Forms.Label lblDateFile;
  private System.Windows.Forms.Label lblRequestor;
  private System.Windows.Forms.Label lblReason;
  private System.Windows.Forms.Label lblUTCode;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.Label label11;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.ComboBox cmbFilter;
  private System.Windows.Forms.ListView lvwUndertime;
  private System.Windows.Forms.ColumnHeader chOTCode;
 }
}