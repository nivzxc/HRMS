namespace Ipanema.Forms
{
 partial class frmOBApplications
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOBApplications));
   this.btnClose = new System.Windows.Forms.Button();
   this.groupBox2 = new System.Windows.Forms.GroupBox();
   this.lvOBDetails = new System.Windows.Forms.ListView();
   this.chFocusDate = new System.Windows.Forms.ColumnHeader();
   this.chTimeIn = new System.Windows.Forms.ColumnHeader();
   this.chTimeOut = new System.Windows.Forms.ColumnHeader();
   this.lblDepartment = new System.Windows.Forms.Label();
   this.label9 = new System.Windows.Forms.Label();
   this.lblHRemarks = new System.Windows.Forms.Label();
   this.lblHDate = new System.Windows.Forms.Label();
   this.lblHApprover = new System.Windows.Forms.Label();
   this.label16 = new System.Windows.Forms.Label();
   this.label18 = new System.Windows.Forms.Label();
   this.lblStatus = new System.Windows.Forms.Label();
   this.lblRRemarks = new System.Windows.Forms.Label();
   this.lblRDate = new System.Windows.Forms.Label();
   this.lblRApprover = new System.Windows.Forms.Label();
   this.lblDateFile = new System.Windows.Forms.Label();
   this.lblOBType = new System.Windows.Forms.Label();
   this.lblRequestor = new System.Windows.Forms.Label();
   this.lblReason = new System.Windows.Forms.Label();
   this.lblOBCode = new System.Windows.Forms.Label();
   this.label12 = new System.Windows.Forms.Label();
   this.label10 = new System.Windows.Forms.Label();
   this.label7 = new System.Windows.Forms.Label();
   this.label6 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.cmbFilter = new System.Windows.Forms.ComboBox();
   this.lvwOB = new System.Windows.Forms.ListView();
   this.chLeaveCode = new System.Windows.Forms.ColumnHeader();
   this.groupBox2.SuspendLayout();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(504, 480);
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
   this.groupBox2.Controls.Add(this.lvOBDetails);
   this.groupBox2.Controls.Add(this.lblDepartment);
   this.groupBox2.Controls.Add(this.label9);
   this.groupBox2.Controls.Add(this.lblHRemarks);
   this.groupBox2.Controls.Add(this.lblHDate);
   this.groupBox2.Controls.Add(this.lblHApprover);
   this.groupBox2.Controls.Add(this.label16);
   this.groupBox2.Controls.Add(this.label18);
   this.groupBox2.Controls.Add(this.lblStatus);
   this.groupBox2.Controls.Add(this.lblRRemarks);
   this.groupBox2.Controls.Add(this.lblRDate);
   this.groupBox2.Controls.Add(this.lblRApprover);
   this.groupBox2.Controls.Add(this.lblDateFile);
   this.groupBox2.Controls.Add(this.lblOBType);
   this.groupBox2.Controls.Add(this.lblRequestor);
   this.groupBox2.Controls.Add(this.lblReason);
   this.groupBox2.Controls.Add(this.lblOBCode);
   this.groupBox2.Controls.Add(this.label12);
   this.groupBox2.Controls.Add(this.label10);
   this.groupBox2.Controls.Add(this.label7);
   this.groupBox2.Controls.Add(this.label6);
   this.groupBox2.Controls.Add(this.label5);
   this.groupBox2.Controls.Add(this.label3);
   this.groupBox2.Controls.Add(this.label2);
   this.groupBox2.Controls.Add(this.label1);
   this.groupBox2.Location = new System.Drawing.Point(148, 6);
   this.groupBox2.Name = "groupBox2";
   this.groupBox2.Size = new System.Drawing.Size(426, 466);
   this.groupBox2.TabIndex = 18;
   this.groupBox2.TabStop = false;
   this.groupBox2.Text = "Application For OB Details";
   // 
   // lvOBDetails
   // 
   this.lvOBDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFocusDate,
            this.chTimeIn,
            this.chTimeOut});
   this.lvOBDetails.FullRowSelect = true;
   this.lvOBDetails.GridLines = true;
   this.lvOBDetails.Location = new System.Drawing.Point(13, 320);
   this.lvOBDetails.Name = "lvOBDetails";
   this.lvOBDetails.Size = new System.Drawing.Size(403, 136);
   this.lvOBDetails.TabIndex = 52;
   this.lvOBDetails.UseCompatibleStateImageBehavior = false;
   this.lvOBDetails.View = System.Windows.Forms.View.Details;
   // 
   // chFocusDate
   // 
   this.chFocusDate.Text = "Focus Date";
   this.chFocusDate.Width = 82;
   // 
   // chTimeIn
   // 
   this.chTimeIn.Text = "Time In";
   this.chTimeIn.Width = 150;
   // 
   // chTimeOut
   // 
   this.chTimeOut.Text = "Time Out";
   this.chTimeOut.Width = 150;
   // 
   // lblDepartment
   // 
   this.lblDepartment.BackColor = System.Drawing.Color.Ivory;
   this.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblDepartment.Location = new System.Drawing.Point(90, 104);
   this.lblDepartment.Name = "lblDepartment";
   this.lblDepartment.Size = new System.Drawing.Size(324, 20);
   this.lblDepartment.TabIndex = 51;
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label9.Location = new System.Drawing.Point(11, 106);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(75, 15);
   this.label9.TabIndex = 50;
   this.label9.Text = "Department:";
   // 
   // lblHRemarks
   // 
   this.lblHRemarks.BackColor = System.Drawing.Color.Ivory;
   this.lblHRemarks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblHRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblHRemarks.Location = new System.Drawing.Point(90, 290);
   this.lblHRemarks.Name = "lblHRemarks";
   this.lblHRemarks.Size = new System.Drawing.Size(324, 20);
   this.lblHRemarks.TabIndex = 47;
   // 
   // lblHDate
   // 
   this.lblHDate.BackColor = System.Drawing.Color.Ivory;
   this.lblHDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblHDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblHDate.Location = new System.Drawing.Point(317, 263);
   this.lblHDate.Name = "lblHDate";
   this.lblHDate.Size = new System.Drawing.Size(97, 20);
   this.lblHDate.TabIndex = 46;
   // 
   // lblHApprover
   // 
   this.lblHApprover.BackColor = System.Drawing.Color.Ivory;
   this.lblHApprover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblHApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblHApprover.Location = new System.Drawing.Point(90, 263);
   this.lblHApprover.Name = "lblHApprover";
   this.lblHApprover.Size = new System.Drawing.Size(220, 20);
   this.lblHApprover.TabIndex = 45;
   // 
   // label16
   // 
   this.label16.AutoSize = true;
   this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label16.Location = new System.Drawing.Point(11, 291);
   this.label16.Name = "label16";
   this.label16.Size = new System.Drawing.Size(72, 15);
   this.label16.TabIndex = 44;
   this.label16.Text = "H Remarks:";
   // 
   // label18
   // 
   this.label18.AutoSize = true;
   this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label18.Location = new System.Drawing.Point(11, 264);
   this.label18.Name = "label18";
   this.label18.Size = new System.Drawing.Size(70, 15);
   this.label18.TabIndex = 42;
   this.label18.Text = "H Approver:";
   // 
   // lblStatus
   // 
   this.lblStatus.BackColor = System.Drawing.Color.Ivory;
   this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblStatus.Location = new System.Drawing.Point(240, 25);
   this.lblStatus.Name = "lblStatus";
   this.lblStatus.Size = new System.Drawing.Size(94, 20);
   this.lblStatus.TabIndex = 41;
   // 
   // lblRRemarks
   // 
   this.lblRRemarks.BackColor = System.Drawing.Color.Ivory;
   this.lblRRemarks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblRRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRRemarks.Location = new System.Drawing.Point(90, 235);
   this.lblRRemarks.Name = "lblRRemarks";
   this.lblRRemarks.Size = new System.Drawing.Size(324, 20);
   this.lblRRemarks.TabIndex = 40;
   // 
   // lblRDate
   // 
   this.lblRDate.BackColor = System.Drawing.Color.Ivory;
   this.lblRDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblRDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRDate.Location = new System.Drawing.Point(317, 208);
   this.lblRDate.Name = "lblRDate";
   this.lblRDate.Size = new System.Drawing.Size(97, 20);
   this.lblRDate.TabIndex = 39;
   // 
   // lblRApprover
   // 
   this.lblRApprover.BackColor = System.Drawing.Color.Ivory;
   this.lblRApprover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblRApprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRApprover.Location = new System.Drawing.Point(90, 208);
   this.lblRApprover.Name = "lblRApprover";
   this.lblRApprover.Size = new System.Drawing.Size(220, 20);
   this.lblRApprover.TabIndex = 38;
   // 
   // lblDateFile
   // 
   this.lblDateFile.BackColor = System.Drawing.Color.Ivory;
   this.lblDateFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblDateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblDateFile.Location = new System.Drawing.Point(90, 133);
   this.lblDateFile.Name = "lblDateFile";
   this.lblDateFile.Size = new System.Drawing.Size(94, 20);
   this.lblDateFile.TabIndex = 34;
   // 
   // lblOBType
   // 
   this.lblOBType.BackColor = System.Drawing.Color.Ivory;
   this.lblOBType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblOBType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblOBType.Location = new System.Drawing.Point(90, 78);
   this.lblOBType.Name = "lblOBType";
   this.lblOBType.Size = new System.Drawing.Size(220, 20);
   this.lblOBType.TabIndex = 33;
   // 
   // lblRequestor
   // 
   this.lblRequestor.BackColor = System.Drawing.Color.Ivory;
   this.lblRequestor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblRequestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRequestor.Location = new System.Drawing.Point(90, 52);
   this.lblRequestor.Name = "lblRequestor";
   this.lblRequestor.Size = new System.Drawing.Size(250, 20);
   this.lblRequestor.TabIndex = 32;
   // 
   // lblReason
   // 
   this.lblReason.BackColor = System.Drawing.Color.Ivory;
   this.lblReason.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblReason.Location = new System.Drawing.Point(90, 159);
   this.lblReason.Name = "lblReason";
   this.lblReason.Size = new System.Drawing.Size(326, 41);
   this.lblReason.TabIndex = 30;
   // 
   // lblOBCode
   // 
   this.lblOBCode.BackColor = System.Drawing.Color.Ivory;
   this.lblOBCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblOBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblOBCode.Location = new System.Drawing.Point(90, 25);
   this.lblOBCode.Name = "lblOBCode";
   this.lblOBCode.Size = new System.Drawing.Size(88, 20);
   this.lblOBCode.TabIndex = 29;
   // 
   // label12
   // 
   this.label12.AutoSize = true;
   this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label12.Location = new System.Drawing.Point(11, 236);
   this.label12.Name = "label12";
   this.label12.Size = new System.Drawing.Size(72, 15);
   this.label12.TabIndex = 25;
   this.label12.Text = "R Remarks:";
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label10.Location = new System.Drawing.Point(11, 209);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(70, 15);
   this.label10.TabIndex = 20;
   this.label10.Text = "R Approver:";
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label7.Location = new System.Drawing.Point(11, 134);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(66, 15);
   this.label7.TabIndex = 12;
   this.label7.Text = "Date Filed:";
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label6.Location = new System.Drawing.Point(191, 28);
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
   this.label5.Size = new System.Drawing.Size(56, 15);
   this.label5.TabIndex = 8;
   this.label5.Text = "OB Type:";
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(11, 158);
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
   this.label1.Size = new System.Drawing.Size(59, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "OB Code:";
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.cmbFilter);
   this.groupBox1.Controls.Add(this.lvwOB);
   this.groupBox1.Location = new System.Drawing.Point(10, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(126, 466);
   this.groupBox1.TabIndex = 17;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "OB Applications";
   // 
   // cmbFilter
   // 
   this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbFilter.FormattingEnabled = true;
   this.cmbFilter.Location = new System.Drawing.Point(10, 24);
   this.cmbFilter.Name = "cmbFilter";
   this.cmbFilter.Size = new System.Drawing.Size(104, 23);
   this.cmbFilter.TabIndex = 53;
   this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
   // 
   // lvwOB
   // 
   this.lvwOB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLeaveCode});
   this.lvwOB.FullRowSelect = true;
   this.lvwOB.GridLines = true;
   this.lvwOB.Location = new System.Drawing.Point(10, 53);
   this.lvwOB.Name = "lvwOB";
   this.lvwOB.Size = new System.Drawing.Size(104, 395);
   this.lvwOB.TabIndex = 1;
   this.lvwOB.UseCompatibleStateImageBehavior = false;
   this.lvwOB.View = System.Windows.Forms.View.Details;
   this.lvwOB.SelectedIndexChanged += new System.EventHandler(this.lvwOB_SelectedIndexChanged);
   // 
   // chLeaveCode
   // 
   this.chLeaveCode.Text = "OB Code";
   this.chLeaveCode.Width = 99;
   // 
   // frmOBApplications
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(584, 517);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.groupBox2);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmOBApplications";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "OB Applications";
   this.Load += new System.EventHandler(this.frmOBApplications_Load);
   this.groupBox2.ResumeLayout(false);
   this.groupBox2.PerformLayout();
   this.groupBox1.ResumeLayout(false);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.GroupBox groupBox2;
  private System.Windows.Forms.Label lblStatus;
  private System.Windows.Forms.Label lblRRemarks;
  private System.Windows.Forms.Label lblRDate;
  private System.Windows.Forms.Label lblRApprover;
  private System.Windows.Forms.Label lblDateFile;
  private System.Windows.Forms.Label lblOBType;
  private System.Windows.Forms.Label lblRequestor;
  private System.Windows.Forms.Label lblReason;
  private System.Windows.Forms.Label lblOBCode;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.ListView lvwOB;
  private System.Windows.Forms.ColumnHeader chLeaveCode;
  private System.Windows.Forms.Label lblHRemarks;
  private System.Windows.Forms.Label lblHDate;
  private System.Windows.Forms.Label lblHApprover;
  private System.Windows.Forms.Label label16;
  private System.Windows.Forms.Label label18;
  private System.Windows.Forms.ListView lvOBDetails;
  private System.Windows.Forms.ColumnHeader chFocusDate;
  private System.Windows.Forms.Label lblDepartment;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.ColumnHeader chTimeIn;
  private System.Windows.Forms.ColumnHeader chTimeOut;
  private System.Windows.Forms.ComboBox cmbFilter;
 }
}