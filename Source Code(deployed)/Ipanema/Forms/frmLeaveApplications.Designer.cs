namespace Ipanema.Forms
{
 partial class frmLeaveApplications
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaveApplications));
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.cmbFilter = new System.Windows.Forms.ComboBox();
   this.lvwLeave = new System.Windows.Forms.ListView();
   this.chLeaveCode = new System.Windows.Forms.ColumnHeader();
   this.groupBox2 = new System.Windows.Forms.GroupBox();
   this.lblStatus = new System.Windows.Forms.Label();
   this.lblRemarks = new System.Windows.Forms.Label();
   this.lblDate = new System.Windows.Forms.Label();
   this.lblApprover = new System.Windows.Forms.Label();
   this.lblDateEnd = new System.Windows.Forms.Label();
   this.lblDateStart = new System.Windows.Forms.Label();
   this.lblUnit = new System.Windows.Forms.Label();
   this.lblDateFile = new System.Windows.Forms.Label();
   this.lblLeaveType = new System.Windows.Forms.Label();
   this.lblRequestor = new System.Windows.Forms.Label();
   this.lblReason = new System.Windows.Forms.Label();
   this.lblLeaveCode = new System.Windows.Forms.Label();
   this.label12 = new System.Windows.Forms.Label();
   this.label11 = new System.Windows.Forms.Label();
   this.label10 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.label9 = new System.Windows.Forms.Label();
   this.label8 = new System.Windows.Forms.Label();
   this.label7 = new System.Windows.Forms.Label();
   this.label6 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.btnClose = new System.Windows.Forms.Button();
   this.groupBox1.SuspendLayout();
   this.groupBox2.SuspendLayout();
   this.SuspendLayout();
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.cmbFilter);
   this.groupBox1.Controls.Add(this.lvwLeave);
   this.groupBox1.Location = new System.Drawing.Point(10, 5);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(126, 360);
   this.groupBox1.TabIndex = 0;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Leave Applications";
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
   // lvwLeave
   // 
   this.lvwLeave.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLeaveCode});
   this.lvwLeave.FullRowSelect = true;
   this.lvwLeave.GridLines = true;
   this.lvwLeave.Location = new System.Drawing.Point(10, 56);
   this.lvwLeave.Name = "lvwLeave";
   this.lvwLeave.Size = new System.Drawing.Size(104, 294);
   this.lvwLeave.TabIndex = 1;
   this.lvwLeave.UseCompatibleStateImageBehavior = false;
   this.lvwLeave.View = System.Windows.Forms.View.Details;
   this.lvwLeave.SelectedIndexChanged += new System.EventHandler(this.lvwLeave_SelectedIndexChanged);
   // 
   // chLeaveCode
   // 
   this.chLeaveCode.Text = "Leave Code";
   this.chLeaveCode.Width = 99;
   // 
   // groupBox2
   // 
   this.groupBox2.Controls.Add(this.lblStatus);
   this.groupBox2.Controls.Add(this.lblRemarks);
   this.groupBox2.Controls.Add(this.lblDate);
   this.groupBox2.Controls.Add(this.lblApprover);
   this.groupBox2.Controls.Add(this.lblDateEnd);
   this.groupBox2.Controls.Add(this.lblDateStart);
   this.groupBox2.Controls.Add(this.lblUnit);
   this.groupBox2.Controls.Add(this.lblDateFile);
   this.groupBox2.Controls.Add(this.lblLeaveType);
   this.groupBox2.Controls.Add(this.lblRequestor);
   this.groupBox2.Controls.Add(this.lblReason);
   this.groupBox2.Controls.Add(this.lblLeaveCode);
   this.groupBox2.Controls.Add(this.label12);
   this.groupBox2.Controls.Add(this.label11);
   this.groupBox2.Controls.Add(this.label10);
   this.groupBox2.Controls.Add(this.label4);
   this.groupBox2.Controls.Add(this.label9);
   this.groupBox2.Controls.Add(this.label8);
   this.groupBox2.Controls.Add(this.label7);
   this.groupBox2.Controls.Add(this.label6);
   this.groupBox2.Controls.Add(this.label5);
   this.groupBox2.Controls.Add(this.label3);
   this.groupBox2.Controls.Add(this.label2);
   this.groupBox2.Controls.Add(this.label1);
   this.groupBox2.Location = new System.Drawing.Point(148, 5);
   this.groupBox2.Name = "groupBox2";
   this.groupBox2.Size = new System.Drawing.Size(326, 360);
   this.groupBox2.TabIndex = 15;
   this.groupBox2.TabStop = false;
   this.groupBox2.Text = "Application For Leave Details";
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
   this.lblRemarks.Location = new System.Drawing.Point(88, 302);
   this.lblRemarks.Name = "lblRemarks";
   this.lblRemarks.Size = new System.Drawing.Size(220, 48);
   this.lblRemarks.TabIndex = 40;
   // 
   // lblDate
   // 
   this.lblDate.BackColor = System.Drawing.Color.Ivory;
   this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblDate.Location = new System.Drawing.Point(88, 275);
   this.lblDate.Name = "lblDate";
   this.lblDate.Size = new System.Drawing.Size(94, 20);
   this.lblDate.TabIndex = 39;
   // 
   // lblApprover
   // 
   this.lblApprover.BackColor = System.Drawing.Color.Ivory;
   this.lblApprover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblApprover.Location = new System.Drawing.Point(88, 249);
   this.lblApprover.Name = "lblApprover";
   this.lblApprover.Size = new System.Drawing.Size(220, 20);
   this.lblApprover.TabIndex = 38;
   // 
   // lblDateEnd
   // 
   this.lblDateEnd.BackColor = System.Drawing.Color.Ivory;
   this.lblDateEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblDateEnd.Location = new System.Drawing.Point(88, 159);
   this.lblDateEnd.Name = "lblDateEnd";
   this.lblDateEnd.Size = new System.Drawing.Size(166, 20);
   this.lblDateEnd.TabIndex = 37;
   // 
   // lblDateStart
   // 
   this.lblDateStart.BackColor = System.Drawing.Color.Ivory;
   this.lblDateStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblDateStart.Location = new System.Drawing.Point(88, 133);
   this.lblDateStart.Name = "lblDateStart";
   this.lblDateStart.Size = new System.Drawing.Size(166, 20);
   this.lblDateStart.TabIndex = 36;
   // 
   // lblUnit
   // 
   this.lblUnit.BackColor = System.Drawing.Color.Ivory;
   this.lblUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblUnit.Location = new System.Drawing.Point(241, 105);
   this.lblUnit.Name = "lblUnit";
   this.lblUnit.Size = new System.Drawing.Size(41, 20);
   this.lblUnit.TabIndex = 35;
   // 
   // lblDateFile
   // 
   this.lblDateFile.BackColor = System.Drawing.Color.Ivory;
   this.lblDateFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblDateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblDateFile.Location = new System.Drawing.Point(88, 105);
   this.lblDateFile.Name = "lblDateFile";
   this.lblDateFile.Size = new System.Drawing.Size(94, 20);
   this.lblDateFile.TabIndex = 34;
   // 
   // lblLeaveType
   // 
   this.lblLeaveType.BackColor = System.Drawing.Color.Ivory;
   this.lblLeaveType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblLeaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblLeaveType.Location = new System.Drawing.Point(88, 78);
   this.lblLeaveType.Name = "lblLeaveType";
   this.lblLeaveType.Size = new System.Drawing.Size(220, 20);
   this.lblLeaveType.TabIndex = 33;
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
   this.lblReason.Location = new System.Drawing.Point(88, 187);
   this.lblReason.Name = "lblReason";
   this.lblReason.Size = new System.Drawing.Size(220, 55);
   this.lblReason.TabIndex = 30;
   // 
   // lblLeaveCode
   // 
   this.lblLeaveCode.BackColor = System.Drawing.Color.Ivory;
   this.lblLeaveCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblLeaveCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblLeaveCode.Location = new System.Drawing.Point(88, 25);
   this.lblLeaveCode.Name = "lblLeaveCode";
   this.lblLeaveCode.Size = new System.Drawing.Size(67, 20);
   this.lblLeaveCode.TabIndex = 29;
   // 
   // label12
   // 
   this.label12.AutoSize = true;
   this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label12.Location = new System.Drawing.Point(11, 299);
   this.label12.Name = "label12";
   this.label12.Size = new System.Drawing.Size(60, 15);
   this.label12.TabIndex = 25;
   this.label12.Text = "Remarks:";
   // 
   // label11
   // 
   this.label11.AutoSize = true;
   this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label11.Location = new System.Drawing.Point(11, 277);
   this.label11.Name = "label11";
   this.label11.Size = new System.Drawing.Size(36, 15);
   this.label11.TabIndex = 22;
   this.label11.Text = "Date:";
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label10.Location = new System.Drawing.Point(11, 248);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(58, 15);
   this.label10.TabIndex = 20;
   this.label10.Text = "Approver:";
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(200, 107);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(38, 15);
   this.label4.TabIndex = 18;
   this.label4.Text = "Units:";
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label9.Location = new System.Drawing.Point(11, 162);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(61, 15);
   this.label9.TabIndex = 16;
   this.label9.Text = "Date End:";
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label8.Location = new System.Drawing.Point(11, 134);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(64, 15);
   this.label8.TabIndex = 14;
   this.label8.Text = "Date Start:";
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label7.Location = new System.Drawing.Point(11, 107);
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
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label5.Location = new System.Drawing.Point(11, 80);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(72, 15);
   this.label5.TabIndex = 8;
   this.label5.Text = "Leave Type:";
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(11, 186);
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
   this.label1.Size = new System.Drawing.Size(75, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Leave Code:";
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(404, 374);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(72, 30);
   this.btnClose.TabIndex = 16;
   this.btnClose.Text = "Close ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // frmLeaveApplications
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(487, 412);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.groupBox2);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmLeaveApplications";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Leave Applications";
   this.Load += new System.EventHandler(this.frmLeaveApplications_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox2.ResumeLayout(false);
   this.groupBox2.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.ListView lvwLeave;
  private System.Windows.Forms.ColumnHeader chLeaveCode;
  private System.Windows.Forms.GroupBox groupBox2;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.Label label11;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Label lblRemarks;
  private System.Windows.Forms.Label lblDate;
  private System.Windows.Forms.Label lblApprover;
  private System.Windows.Forms.Label lblDateEnd;
  private System.Windows.Forms.Label lblDateStart;
  private System.Windows.Forms.Label lblUnit;
  private System.Windows.Forms.Label lblDateFile;
  private System.Windows.Forms.Label lblLeaveType;
  private System.Windows.Forms.Label lblRequestor;
  private System.Windows.Forms.Label lblReason;
  private System.Windows.Forms.Label lblLeaveCode;
  private System.Windows.Forms.Label lblStatus;
  private System.Windows.Forms.ComboBox cmbFilter;
 }
}