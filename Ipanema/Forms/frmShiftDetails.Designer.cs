namespace Ipanema.Forms
{
 partial class frmShiftDetails
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShiftDetails));
   this.btnClose = new System.Windows.Forms.Button();
   this.label8 = new System.Windows.Forms.Label();
   this.label9 = new System.Windows.Forms.Label();
   this.label10 = new System.Windows.Forms.Label();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.lblWorking = new System.Windows.Forms.Label();
   this.label7 = new System.Windows.Forms.Label();
   this.lblUndertime = new System.Windows.Forms.Label();
   this.lblBreakEnd = new System.Windows.Forms.Label();
   this.lblLate = new System.Windows.Forms.Label();
   this.lblBreakStart = new System.Windows.Forms.Label();
   this.lblTimeEnd = new System.Windows.Forms.Label();
   this.lblRemarks = new System.Windows.Forms.Label();
   this.lblTimeHalf = new System.Windows.Forms.Label();
   this.lblTotalWorkingHours = new System.Windows.Forms.Label();
   this.label19 = new System.Windows.Forms.Label();
   this.label16 = new System.Windows.Forms.Label();
   this.lblTimeStart = new System.Windows.Forms.Label();
   this.lblShiftCode = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(391, 210);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(75, 30);
   this.btnClose.TabIndex = 11;
   this.btnClose.Text = "Close   ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label8.Location = new System.Drawing.Point(11, 108);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(31, 13);
   this.label8.TabIndex = 14;
   this.label8.Text = "Late:";
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label9.Location = new System.Drawing.Point(159, 79);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(67, 15);
   this.label9.TabIndex = 12;
   this.label9.Text = "Break End:";
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label10.Location = new System.Drawing.Point(11, 79);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(70, 15);
   this.label10.TabIndex = 10;
   this.label10.Text = "Break Start:";
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.lblWorking);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.lblUndertime);
   this.groupBox1.Controls.Add(this.lblBreakEnd);
   this.groupBox1.Controls.Add(this.lblLate);
   this.groupBox1.Controls.Add(this.lblBreakStart);
   this.groupBox1.Controls.Add(this.lblTimeEnd);
   this.groupBox1.Controls.Add(this.lblRemarks);
   this.groupBox1.Controls.Add(this.lblTimeHalf);
   this.groupBox1.Controls.Add(this.lblTotalWorkingHours);
   this.groupBox1.Controls.Add(this.label19);
   this.groupBox1.Controls.Add(this.label16);
   this.groupBox1.Controls.Add(this.lblTimeStart);
   this.groupBox1.Controls.Add(this.lblShiftCode);
   this.groupBox1.Controls.Add(this.label8);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.label9);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.label10);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox1.Location = new System.Drawing.Point(9, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(455, 196);
   this.groupBox1.TabIndex = 8;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Shift Details";
   // 
   // lblWorking
   // 
   this.lblWorking.BackColor = System.Drawing.Color.AliceBlue;
   this.lblWorking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblWorking.Location = new System.Drawing.Point(230, 26);
   this.lblWorking.Name = "lblWorking";
   this.lblWorking.Size = new System.Drawing.Size(65, 20);
   this.lblWorking.TabIndex = 34;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label7.Location = new System.Drawing.Point(159, 29);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(55, 15);
   this.label7.TabIndex = 33;
   this.label7.Text = "Working:";
   // 
   // lblUndertime
   // 
   this.lblUndertime.BackColor = System.Drawing.Color.AliceBlue;
   this.lblUndertime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblUndertime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblUndertime.Location = new System.Drawing.Point(230, 105);
   this.lblUndertime.Name = "lblUndertime";
   this.lblUndertime.Size = new System.Drawing.Size(65, 20);
   this.lblUndertime.TabIndex = 32;
   // 
   // lblBreakEnd
   // 
   this.lblBreakEnd.BackColor = System.Drawing.Color.AliceBlue;
   this.lblBreakEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblBreakEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblBreakEnd.Location = new System.Drawing.Point(230, 79);
   this.lblBreakEnd.Name = "lblBreakEnd";
   this.lblBreakEnd.Size = new System.Drawing.Size(65, 20);
   this.lblBreakEnd.TabIndex = 31;
   // 
   // lblLate
   // 
   this.lblLate.BackColor = System.Drawing.Color.AliceBlue;
   this.lblLate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblLate.Location = new System.Drawing.Point(83, 105);
   this.lblLate.Name = "lblLate";
   this.lblLate.Size = new System.Drawing.Size(65, 20);
   this.lblLate.TabIndex = 30;
   // 
   // lblBreakStart
   // 
   this.lblBreakStart.BackColor = System.Drawing.Color.AliceBlue;
   this.lblBreakStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblBreakStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblBreakStart.Location = new System.Drawing.Point(83, 79);
   this.lblBreakStart.Name = "lblBreakStart";
   this.lblBreakStart.Size = new System.Drawing.Size(65, 20);
   this.lblBreakStart.TabIndex = 29;
   // 
   // lblTimeEnd
   // 
   this.lblTimeEnd.BackColor = System.Drawing.Color.AliceBlue;
   this.lblTimeEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblTimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblTimeEnd.Location = new System.Drawing.Point(380, 52);
   this.lblTimeEnd.Name = "lblTimeEnd";
   this.lblTimeEnd.Size = new System.Drawing.Size(65, 20);
   this.lblTimeEnd.TabIndex = 29;
   // 
   // lblRemarks
   // 
   this.lblRemarks.BackColor = System.Drawing.Color.AliceBlue;
   this.lblRemarks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRemarks.Location = new System.Drawing.Point(83, 130);
   this.lblRemarks.Name = "lblRemarks";
   this.lblRemarks.Size = new System.Drawing.Size(321, 55);
   this.lblRemarks.TabIndex = 28;
   // 
   // lblTimeHalf
   // 
   this.lblTimeHalf.BackColor = System.Drawing.Color.AliceBlue;
   this.lblTimeHalf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblTimeHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblTimeHalf.Location = new System.Drawing.Point(230, 52);
   this.lblTimeHalf.Name = "lblTimeHalf";
   this.lblTimeHalf.Size = new System.Drawing.Size(65, 20);
   this.lblTimeHalf.TabIndex = 27;
   // 
   // lblTotalWorkingHours
   // 
   this.lblTotalWorkingHours.BackColor = System.Drawing.Color.AliceBlue;
   this.lblTotalWorkingHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblTotalWorkingHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblTotalWorkingHours.Location = new System.Drawing.Point(380, 26);
   this.lblTotalWorkingHours.Name = "lblTotalWorkingHours";
   this.lblTotalWorkingHours.Size = new System.Drawing.Size(50, 20);
   this.lblTotalWorkingHours.TabIndex = 26;
   // 
   // label19
   // 
   this.label19.AutoSize = true;
   this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label19.Location = new System.Drawing.Point(304, 25);
   this.label19.Name = "label19";
   this.label19.Size = new System.Drawing.Size(73, 15);
   this.label19.TabIndex = 25;
   this.label19.Text = "Total Hours:";
   // 
   // label16
   // 
   this.label16.AutoSize = true;
   this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label16.Location = new System.Drawing.Point(159, 105);
   this.label16.Name = "label16";
   this.label16.Size = new System.Drawing.Size(68, 15);
   this.label16.TabIndex = 21;
   this.label16.Text = "Undertime:";
   // 
   // lblTimeStart
   // 
   this.lblTimeStart.BackColor = System.Drawing.Color.AliceBlue;
   this.lblTimeStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblTimeStart.Location = new System.Drawing.Point(83, 52);
   this.lblTimeStart.Name = "lblTimeStart";
   this.lblTimeStart.Size = new System.Drawing.Size(65, 20);
   this.lblTimeStart.TabIndex = 16;
   // 
   // lblShiftCode
   // 
   this.lblShiftCode.BackColor = System.Drawing.Color.AliceBlue;
   this.lblShiftCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
   this.lblShiftCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblShiftCode.Location = new System.Drawing.Point(83, 26);
   this.lblShiftCode.Name = "lblShiftCode";
   this.lblShiftCode.Size = new System.Drawing.Size(67, 20);
   this.lblShiftCode.TabIndex = 15;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label5.Location = new System.Drawing.Point(11, 29);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(66, 15);
   this.label5.TabIndex = 9;
   this.label5.Text = "Shift Code:";
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(159, 55);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(63, 15);
   this.label4.TabIndex = 8;
   this.label4.Text = "Time Half:";
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(304, 55);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(63, 15);
   this.label3.TabIndex = 6;
   this.label3.Text = "Time End:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(11, 55);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(66, 15);
   this.label2.TabIndex = 4;
   this.label2.Text = "Time Start:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(11, 130);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(60, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Remarks:";
   // 
   // frmShiftDetails
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(473, 248);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.groupBox1);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmShiftDetails";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Shift Details";
   this.Load += new System.EventHandler(this.frmShiftDetails_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label lblTotalWorkingHours;
  private System.Windows.Forms.Label label19;
  private System.Windows.Forms.Label label16;
  private System.Windows.Forms.Label lblTimeStart;
  private System.Windows.Forms.Label lblShiftCode;
  private System.Windows.Forms.Label lblUndertime;
  private System.Windows.Forms.Label lblBreakEnd;
  private System.Windows.Forms.Label lblLate;
  private System.Windows.Forms.Label lblBreakStart;
  private System.Windows.Forms.Label lblTimeEnd;
  private System.Windows.Forms.Label lblRemarks;
  private System.Windows.Forms.Label lblTimeHalf;
  private System.Windows.Forms.Label lblWorking;
  private System.Windows.Forms.Label label7;
 }
}