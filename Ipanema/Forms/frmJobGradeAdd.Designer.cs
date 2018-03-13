namespace Ipanema.Forms
{
 partial class frmJobGradeAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobGradeAdd));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtPlantillaCountHQ = new System.Windows.Forms.TextBox();
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
   this.label3 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(347, 227);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 8;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(259, 227);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(79, 38);
   this.btnSave.TabIndex = 7;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.txtPlantillaCountBillable);
   this.groupBox1.Controls.Add(this.txtPlantillaCountHQ);
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
   this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox1.Location = new System.Drawing.Point(10, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(416, 211);
   this.groupBox1.TabIndex = 18;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Shift Details";
   // 
   // txtPlantillaCountHQ
   // 
   this.txtPlantillaCountHQ.BackColor = System.Drawing.Color.White;
   this.txtPlantillaCountHQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtPlantillaCountHQ.Location = new System.Drawing.Point(106, 166);
   this.txtPlantillaCountHQ.MaxLength = 2;
   this.txtPlantillaCountHQ.Name = "txtPlantillaCountHQ";
   this.txtPlantillaCountHQ.Size = new System.Drawing.Size(101, 21);
   this.txtPlantillaCountHQ.TabIndex = 6;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(9, 169);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(89, 15);
   this.label1.TabIndex = 25;
   this.label1.Text = "Plantilla Count:";
   // 
   // chkPayOvertime
   // 
   this.chkPayOvertime.AutoSize = true;
   this.chkPayOvertime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.chkPayOvertime.Location = new System.Drawing.Point(106, 141);
   this.chkPayOvertime.Name = "chkPayOvertime";
   this.chkPayOvertime.Size = new System.Drawing.Size(98, 19);
   this.chkPayOvertime.TabIndex = 5;
   this.chkPayOvertime.Text = "Pay Overtime";
   this.chkPayOvertime.UseVisualStyleBackColor = true;
   // 
   // chkDeductUndertime
   // 
   this.chkDeductUndertime.AutoSize = true;
   this.chkDeductUndertime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.chkDeductUndertime.Location = new System.Drawing.Point(106, 119);
   this.chkDeductUndertime.Name = "chkDeductUndertime";
   this.chkDeductUndertime.Size = new System.Drawing.Size(126, 19);
   this.chkDeductUndertime.TabIndex = 4;
   this.chkDeductUndertime.Text = "Deduct Undertime";
   this.chkDeductUndertime.UseVisualStyleBackColor = true;
   // 
   // chkDeductLate
   // 
   this.chkDeductLate.AutoSize = true;
   this.chkDeductLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
   this.txtLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtLevel.Location = new System.Drawing.Point(106, 72);
   this.txtLevel.MaxLength = 2;
   this.txtLevel.Name = "txtLevel";
   this.txtLevel.Size = new System.Drawing.Size(101, 21);
   this.txtLevel.TabIndex = 2;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(9, 75);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(39, 15);
   this.label2.TabIndex = 23;
   this.label2.Text = "Level:";
   // 
   // txtDescription
   // 
   this.txtDescription.BackColor = System.Drawing.Color.White;
   this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDescription.Location = new System.Drawing.Point(106, 46);
   this.txtDescription.MaxLength = 50;
   this.txtDescription.Name = "txtDescription";
   this.txtDescription.Size = new System.Drawing.Size(298, 21);
   this.txtDescription.TabIndex = 1;
   // 
   // label13
   // 
   this.label13.AutoSize = true;
   this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label13.Location = new System.Drawing.Point(9, 49);
   this.label13.Name = "label13";
   this.label13.Size = new System.Drawing.Size(72, 15);
   this.label13.TabIndex = 21;
   this.label13.Text = "Description:";
   // 
   // txtJGCode
   // 
   this.txtJGCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtJGCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtJGCode.Location = new System.Drawing.Point(106, 20);
   this.txtJGCode.MaxLength = 3;
   this.txtJGCode.Name = "txtJGCode";
   this.txtJGCode.Size = new System.Drawing.Size(101, 21);
   this.txtJGCode.TabIndex = 0;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label5.Location = new System.Drawing.Point(9, 22);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(57, 15);
   this.label5.TabIndex = 9;
   this.label5.Text = "JG Code:";
   // 
   // txtPlantillaCountBillable
   // 
   this.txtPlantillaCountBillable.BackColor = System.Drawing.Color.White;
   this.txtPlantillaCountBillable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtPlantillaCountBillable.Location = new System.Drawing.Point(217, 166);
   this.txtPlantillaCountBillable.MaxLength = 2;
   this.txtPlantillaCountBillable.Name = "txtPlantillaCountBillable";
   this.txtPlantillaCountBillable.Size = new System.Drawing.Size(101, 21);
   this.txtPlantillaCountBillable.TabIndex = 26;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(105, 187);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(25, 15);
   this.label3.TabIndex = 27;
   this.label3.Text = "HQ";
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(216, 187);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(48, 15);
   this.label4.TabIndex = 28;
   this.label4.Text = "Billable";
   // 
   // frmJobGradeAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(437, 274);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmJobGradeAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add New Job Grade";
   this.Load += new System.EventHandler(this.frmJobGradeAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.Label label13;
  private System.Windows.Forms.TextBox txtJGCode;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.CheckBox chkPayOvertime;
  private System.Windows.Forms.CheckBox chkDeductUndertime;
  private System.Windows.Forms.CheckBox chkDeductLate;
  private System.Windows.Forms.TextBox txtLevel;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtDescription;
  private System.Windows.Forms.TextBox txtPlantillaCountHQ;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtPlantillaCountBillable;
 }
}