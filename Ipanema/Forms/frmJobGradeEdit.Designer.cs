namespace Ipanema.Forms
{
 partial class frmJobGradeEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobGradeEdit));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtModifyOn = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.txtModifyBy = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtPlantillaCountHQ = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.txtCreateOn = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.txtCreateBy = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.chkPayOvertime = new System.Windows.Forms.CheckBox();
   this.chkDeductUndertime = new System.Windows.Forms.CheckBox();
   this.chkDeductLate = new System.Windows.Forms.CheckBox();
   this.txtLevel = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.txtDescription = new System.Windows.Forms.TextBox();
   this.label13 = new System.Windows.Forms.Label();
   this.txtJGCode = new System.Windows.Forms.TextBox();
   this.label5 = new System.Windows.Forms.Label();
   this.txtPlantillaCountBillable = new System.Windows.Forms.TextBox();
   this.label8 = new System.Windows.Forms.Label();
   this.label9 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(309, 332);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(79, 38);
   this.btnClose.TabIndex = 8;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(223, 332);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 7;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.label9);
   this.groupBox1.Controls.Add(this.label8);
   this.groupBox1.Controls.Add(this.txtPlantillaCountBillable);
   this.groupBox1.Controls.Add(this.txtModifyOn);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.txtModifyBy);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.txtPlantillaCountHQ);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.txtCreateOn);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.txtCreateBy);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Controls.Add(this.chkPayOvertime);
   this.groupBox1.Controls.Add(this.chkDeductUndertime);
   this.groupBox1.Controls.Add(this.chkDeductLate);
   this.groupBox1.Controls.Add(this.txtLevel);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.txtDescription);
   this.groupBox1.Controls.Add(this.label13);
   this.groupBox1.Controls.Add(this.txtJGCode);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Location = new System.Drawing.Point(11, 8);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(375, 316);
   this.groupBox1.TabIndex = 6;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Shift Details";
   // 
   // txtModifyOn
   // 
   this.txtModifyOn.BackColor = System.Drawing.Color.AliceBlue;
   this.txtModifyOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtModifyOn.Location = new System.Drawing.Point(106, 285);
   this.txtModifyOn.MaxLength = 8;
   this.txtModifyOn.Name = "txtModifyOn";
   this.txtModifyOn.ReadOnly = true;
   this.txtModifyOn.Size = new System.Drawing.Size(245, 20);
   this.txtModifyOn.TabIndex = 32;
   this.txtModifyOn.TabStop = false;
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Location = new System.Drawing.Point(9, 286);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(87, 15);
   this.label6.TabIndex = 33;
   this.label6.Text = "Date Modified:";
   // 
   // txtModifyBy
   // 
   this.txtModifyBy.BackColor = System.Drawing.Color.AliceBlue;
   this.txtModifyBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtModifyBy.Location = new System.Drawing.Point(106, 259);
   this.txtModifyBy.MaxLength = 8;
   this.txtModifyBy.Name = "txtModifyBy";
   this.txtModifyBy.ReadOnly = true;
   this.txtModifyBy.Size = new System.Drawing.Size(220, 20);
   this.txtModifyBy.TabIndex = 30;
   this.txtModifyBy.TabStop = false;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Location = new System.Drawing.Point(9, 262);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(74, 15);
   this.label7.TabIndex = 31;
   this.label7.Text = "Modified By:";
   // 
   // txtPlantillaCountHQ
   // 
   this.txtPlantillaCountHQ.BackColor = System.Drawing.Color.White;
   this.txtPlantillaCountHQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtPlantillaCountHQ.Location = new System.Drawing.Point(106, 163);
   this.txtPlantillaCountHQ.MaxLength = 8;
   this.txtPlantillaCountHQ.Name = "txtPlantillaCountHQ";
   this.txtPlantillaCountHQ.Size = new System.Drawing.Size(76, 20);
   this.txtPlantillaCountHQ.TabIndex = 6;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(9, 165);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(89, 15);
   this.label4.TabIndex = 29;
   this.label4.Text = "Plantilla Count:";
   // 
   // txtCreateOn
   // 
   this.txtCreateOn.BackColor = System.Drawing.Color.AliceBlue;
   this.txtCreateOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtCreateOn.Location = new System.Drawing.Point(106, 233);
   this.txtCreateOn.MaxLength = 8;
   this.txtCreateOn.Name = "txtCreateOn";
   this.txtCreateOn.ReadOnly = true;
   this.txtCreateOn.Size = new System.Drawing.Size(245, 20);
   this.txtCreateOn.TabIndex = 26;
   this.txtCreateOn.TabStop = false;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(9, 235);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(82, 15);
   this.label3.TabIndex = 27;
   this.label3.Text = "Date Created:";
   // 
   // txtCreateBy
   // 
   this.txtCreateBy.BackColor = System.Drawing.Color.AliceBlue;
   this.txtCreateBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtCreateBy.Location = new System.Drawing.Point(106, 207);
   this.txtCreateBy.MaxLength = 8;
   this.txtCreateBy.Name = "txtCreateBy";
   this.txtCreateBy.ReadOnly = true;
   this.txtCreateBy.Size = new System.Drawing.Size(220, 20);
   this.txtCreateBy.TabIndex = 24;
   this.txtCreateBy.TabStop = false;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(9, 210);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(69, 15);
   this.label1.TabIndex = 25;
   this.label1.Text = "Created By:";
   // 
   // chkPayOvertime
   // 
   this.chkPayOvertime.AutoSize = true;
   this.chkPayOvertime.Location = new System.Drawing.Point(106, 138);
   this.chkPayOvertime.Name = "chkPayOvertime";
   this.chkPayOvertime.Size = new System.Drawing.Size(98, 19);
   this.chkPayOvertime.TabIndex = 5;
   this.chkPayOvertime.Text = "Pay Overtime";
   this.chkPayOvertime.UseVisualStyleBackColor = true;
   // 
   // chkDeductUndertime
   // 
   this.chkDeductUndertime.AutoSize = true;
   this.chkDeductUndertime.Location = new System.Drawing.Point(106, 118);
   this.chkDeductUndertime.Name = "chkDeductUndertime";
   this.chkDeductUndertime.Size = new System.Drawing.Size(126, 19);
   this.chkDeductUndertime.TabIndex = 4;
   this.chkDeductUndertime.Text = "Deduct Undertime";
   this.chkDeductUndertime.UseVisualStyleBackColor = true;
   // 
   // chkDeductLate
   // 
   this.chkDeductLate.AutoSize = true;
   this.chkDeductLate.Location = new System.Drawing.Point(106, 97);
   this.chkDeductLate.Name = "chkDeductLate";
   this.chkDeductLate.Size = new System.Drawing.Size(92, 19);
   this.chkDeductLate.TabIndex = 3;
   this.chkDeductLate.Text = "Deduct Late";
   this.chkDeductLate.UseVisualStyleBackColor = true;
   // 
   // txtLevel
   // 
   this.txtLevel.BackColor = System.Drawing.Color.White;
   this.txtLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtLevel.Location = new System.Drawing.Point(106, 72);
   this.txtLevel.MaxLength = 8;
   this.txtLevel.Name = "txtLevel";
   this.txtLevel.Size = new System.Drawing.Size(101, 20);
   this.txtLevel.TabIndex = 2;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(9, 74);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(39, 15);
   this.label2.TabIndex = 23;
   this.label2.Text = "Level:";
   // 
   // txtDescription
   // 
   this.txtDescription.BackColor = System.Drawing.Color.White;
   this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDescription.Location = new System.Drawing.Point(106, 46);
   this.txtDescription.MaxLength = 8;
   this.txtDescription.Name = "txtDescription";
   this.txtDescription.Size = new System.Drawing.Size(258, 20);
   this.txtDescription.TabIndex = 1;
   // 
   // label13
   // 
   this.label13.AutoSize = true;
   this.label13.Location = new System.Drawing.Point(9, 50);
   this.label13.Name = "label13";
   this.label13.Size = new System.Drawing.Size(72, 15);
   this.label13.TabIndex = 21;
   this.label13.Text = "Description:";
   // 
   // txtJGCode
   // 
   this.txtJGCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtJGCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtJGCode.Location = new System.Drawing.Point(106, 20);
   this.txtJGCode.MaxLength = 8;
   this.txtJGCode.Name = "txtJGCode";
   this.txtJGCode.ReadOnly = true;
   this.txtJGCode.Size = new System.Drawing.Size(101, 20);
   this.txtJGCode.TabIndex = 0;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(9, 25);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(57, 15);
   this.label5.TabIndex = 9;
   this.label5.Text = "JG Code:";
   // 
   // txtPlantillaCountBillable
   // 
   this.txtPlantillaCountBillable.BackColor = System.Drawing.Color.White;
   this.txtPlantillaCountBillable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtPlantillaCountBillable.Location = new System.Drawing.Point(190, 163);
   this.txtPlantillaCountBillable.MaxLength = 8;
   this.txtPlantillaCountBillable.Name = "txtPlantillaCountBillable";
   this.txtPlantillaCountBillable.Size = new System.Drawing.Size(76, 20);
   this.txtPlantillaCountBillable.TabIndex = 7;
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Location = new System.Drawing.Point(104, 184);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(25, 15);
   this.label8.TabIndex = 35;
   this.label8.Text = "HQ";
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Location = new System.Drawing.Point(190, 184);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(48, 15);
   this.label9.TabIndex = 36;
   this.label9.Text = "Billable";
   // 
   // frmJobGradeEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(399, 379);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmJobGradeEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit Job Grade";
   this.Load += new System.EventHandler(this.frmJobGradeEdit_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.CheckBox chkPayOvertime;
  private System.Windows.Forms.CheckBox chkDeductUndertime;
  private System.Windows.Forms.CheckBox chkDeductLate;
  private System.Windows.Forms.TextBox txtLevel;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtDescription;
  private System.Windows.Forms.Label label13;
  private System.Windows.Forms.TextBox txtJGCode;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtCreateOn;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtCreateBy;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtModifyOn;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtModifyBy;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtPlantillaCountHQ;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.TextBox txtPlantillaCountBillable;
 }
}