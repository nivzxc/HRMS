namespace Ipanema.Forms
{
 partial class frmHolidayEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHolidayEdit));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtDateApplied = new System.Windows.Forms.TextBox();
   this.txtCreatedOn = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtCreatedBy = new System.Windows.Forms.TextBox();
   this.label8 = new System.Windows.Forms.Label();
   this.txtUpdateOn = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.txtUpdateBy = new System.Windows.Forms.TextBox();
   this.label5 = new System.Windows.Forms.Label();
   this.cmbShift = new System.Windows.Forms.ComboBox();
   this.label4 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.txtDescription = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.txtHolidayCode = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(346, 269);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(79, 38);
   this.btnClose.TabIndex = 8;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(257, 269);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(79, 38);
   this.btnSave.TabIndex = 7;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtDateApplied);
   this.groupBox1.Controls.Add(this.txtCreatedOn);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.txtCreatedBy);
   this.groupBox1.Controls.Add(this.label8);
   this.groupBox1.Controls.Add(this.txtUpdateOn);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.txtUpdateBy);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.cmbShift);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.txtDescription);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Controls.Add(this.txtHolidayCode);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox1.Location = new System.Drawing.Point(10, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(414, 254);
   this.groupBox1.TabIndex = 37;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Holiday Details";
   // 
   // txtDateApplied
   // 
   this.txtDateApplied.BackColor = System.Drawing.Color.AliceBlue;
   this.txtDateApplied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDateApplied.Location = new System.Drawing.Point(102, 52);
   this.txtDateApplied.Name = "txtDateApplied";
   this.txtDateApplied.ReadOnly = true;
   this.txtDateApplied.Size = new System.Drawing.Size(214, 21);
   this.txtDateApplied.TabIndex = 43;
   this.txtDateApplied.TabStop = false;
   // 
   // txtCreatedOn
   // 
   this.txtCreatedOn.BackColor = System.Drawing.Color.AliceBlue;
   this.txtCreatedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtCreatedOn.Location = new System.Drawing.Point(102, 166);
   this.txtCreatedOn.Name = "txtCreatedOn";
   this.txtCreatedOn.ReadOnly = true;
   this.txtCreatedOn.Size = new System.Drawing.Size(259, 21);
   this.txtCreatedOn.TabIndex = 41;
   this.txtCreatedOn.TabStop = false;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label7.Location = new System.Drawing.Point(15, 169);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(72, 15);
   this.label7.TabIndex = 42;
   this.label7.Text = "Created On:";
   // 
   // txtCreatedBy
   // 
   this.txtCreatedBy.BackColor = System.Drawing.Color.AliceBlue;
   this.txtCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtCreatedBy.Location = new System.Drawing.Point(102, 139);
   this.txtCreatedBy.Name = "txtCreatedBy";
   this.txtCreatedBy.ReadOnly = true;
   this.txtCreatedBy.Size = new System.Drawing.Size(229, 21);
   this.txtCreatedBy.TabIndex = 39;
   this.txtCreatedBy.TabStop = false;
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label8.Location = new System.Drawing.Point(15, 141);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(69, 15);
   this.label8.TabIndex = 40;
   this.label8.Text = "Created By:";
   // 
   // txtUpdateOn
   // 
   this.txtUpdateOn.BackColor = System.Drawing.Color.AliceBlue;
   this.txtUpdateOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtUpdateOn.Location = new System.Drawing.Point(102, 221);
   this.txtUpdateOn.Name = "txtUpdateOn";
   this.txtUpdateOn.ReadOnly = true;
   this.txtUpdateOn.Size = new System.Drawing.Size(259, 21);
   this.txtUpdateOn.TabIndex = 37;
   this.txtUpdateOn.TabStop = false;
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label6.Location = new System.Drawing.Point(15, 222);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(77, 15);
   this.label6.TabIndex = 38;
   this.label6.Text = "Modified On:";
   // 
   // txtUpdateBy
   // 
   this.txtUpdateBy.BackColor = System.Drawing.Color.AliceBlue;
   this.txtUpdateBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtUpdateBy.Location = new System.Drawing.Point(102, 194);
   this.txtUpdateBy.Name = "txtUpdateBy";
   this.txtUpdateBy.ReadOnly = true;
   this.txtUpdateBy.Size = new System.Drawing.Size(229, 21);
   this.txtUpdateBy.TabIndex = 35;
   this.txtUpdateBy.TabStop = false;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label5.Location = new System.Drawing.Point(15, 196);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(74, 15);
   this.label5.TabIndex = 36;
   this.label5.Text = "Modified By:";
   // 
   // cmbShift
   // 
   this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbShift.FormattingEnabled = true;
   this.cmbShift.Location = new System.Drawing.Point(102, 80);
   this.cmbShift.Name = "cmbShift";
   this.cmbShift.Size = new System.Drawing.Size(118, 23);
   this.cmbShift.TabIndex = 3;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(15, 55);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(80, 15);
   this.label4.TabIndex = 33;
   this.label4.Text = "Date Applied:";
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(15, 83);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(34, 15);
   this.label3.TabIndex = 32;
   this.label3.Text = "Shift:";
   // 
   // txtDescription
   // 
   this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDescription.Location = new System.Drawing.Point(102, 111);
   this.txtDescription.MaxLength = 30;
   this.txtDescription.Name = "txtDescription";
   this.txtDescription.Size = new System.Drawing.Size(301, 21);
   this.txtDescription.TabIndex = 6;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(15, 114);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(72, 15);
   this.label1.TabIndex = 30;
   this.label1.Text = "Description:";
   // 
   // txtHolidayCode
   // 
   this.txtHolidayCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtHolidayCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtHolidayCode.Location = new System.Drawing.Point(102, 26);
   this.txtHolidayCode.Name = "txtHolidayCode";
   this.txtHolidayCode.ReadOnly = true;
   this.txtHolidayCode.Size = new System.Drawing.Size(132, 21);
   this.txtHolidayCode.TabIndex = 1;
   this.txtHolidayCode.TabStop = false;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(15, 27);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(83, 15);
   this.label2.TabIndex = 28;
   this.label2.Text = "Holiday Code:";
   // 
   // frmHolidayEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(436, 315);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmHolidayEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit Holiday";
   this.Load += new System.EventHandler(this.frmHolidayEdit_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtDescription;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtHolidayCode;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.ComboBox cmbShift;
  private System.Windows.Forms.TextBox txtUpdateOn;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtUpdateBy;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtCreatedOn;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtCreatedBy;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.TextBox txtDateApplied;
 }
}