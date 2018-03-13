namespace Ipanema.Forms
{
 partial class frmHolidayNew
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHolidayNew));
   this.label2 = new System.Windows.Forms.Label();
   this.txtHolidayCode = new System.Windows.Forms.TextBox();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.btnShiftDetails = new System.Windows.Forms.Button();
   this.btnShiftAdd = new System.Windows.Forms.Button();
   this.cmbShift = new System.Windows.Forms.ComboBox();
   this.dteDateApplied = new System.Windows.Forms.DateTimePicker();
   this.label4 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.txtRemarks = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(13, 26);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(83, 15);
   this.label2.TabIndex = 28;
   this.label2.Text = "Holiday Code:";
   // 
   // txtHolidayCode
   // 
   this.txtHolidayCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtHolidayCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtHolidayCode.Location = new System.Drawing.Point(101, 25);
   this.txtHolidayCode.Name = "txtHolidayCode";
   this.txtHolidayCode.ReadOnly = true;
   this.txtHolidayCode.Size = new System.Drawing.Size(114, 21);
   this.txtHolidayCode.TabIndex = 1;
   this.txtHolidayCode.TabStop = false;
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.btnShiftDetails);
   this.groupBox1.Controls.Add(this.btnShiftAdd);
   this.groupBox1.Controls.Add(this.cmbShift);
   this.groupBox1.Controls.Add(this.dteDateApplied);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.txtRemarks);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Controls.Add(this.txtHolidayCode);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox1.Location = new System.Drawing.Point(12, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(335, 139);
   this.groupBox1.TabIndex = 34;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Holiday Details";
   // 
   // btnShiftDetails
   // 
   this.btnShiftDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnShiftDetails.Image")));
   this.btnShiftDetails.Location = new System.Drawing.Point(236, 78);
   this.btnShiftDetails.Name = "btnShiftDetails";
   this.btnShiftDetails.Size = new System.Drawing.Size(26, 25);
   this.btnShiftDetails.TabIndex = 34;
   this.btnShiftDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnShiftDetails.UseVisualStyleBackColor = true;
   this.btnShiftDetails.Click += new System.EventHandler(this.btnShiftDetails_Click);
   // 
   // btnShiftAdd
   // 
   this.btnShiftAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnShiftAdd.Image")));
   this.btnShiftAdd.Location = new System.Drawing.Point(207, 78);
   this.btnShiftAdd.Name = "btnShiftAdd";
   this.btnShiftAdd.Size = new System.Drawing.Size(26, 25);
   this.btnShiftAdd.TabIndex = 4;
   this.btnShiftAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnShiftAdd.UseVisualStyleBackColor = true;
   this.btnShiftAdd.Click += new System.EventHandler(this.btnShiftAdd_Click);
   // 
   // cmbShift
   // 
   this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbShift.FormattingEnabled = true;
   this.cmbShift.Location = new System.Drawing.Point(101, 79);
   this.cmbShift.Name = "cmbShift";
   this.cmbShift.Size = new System.Drawing.Size(102, 23);
   this.cmbShift.TabIndex = 3;
   // 
   // dteDateApplied
   // 
   this.dteDateApplied.CustomFormat = "ddd MMM dd, yyyy";
   this.dteDateApplied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dteDateApplied.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dteDateApplied.Location = new System.Drawing.Point(101, 52);
   this.dteDateApplied.Name = "dteDateApplied";
   this.dteDateApplied.Size = new System.Drawing.Size(131, 21);
   this.dteDateApplied.TabIndex = 2;
   this.dteDateApplied.ValueChanged += new System.EventHandler(this.dteDateApplied_ValueChanged);
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(13, 54);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(80, 15);
   this.label4.TabIndex = 33;
   this.label4.Text = "Date Applied:";
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(13, 82);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(34, 15);
   this.label3.TabIndex = 32;
   this.label3.Text = "Shift:";
   // 
   // txtRemarks
   // 
   this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtRemarks.Location = new System.Drawing.Point(101, 108);
   this.txtRemarks.MaxLength = 50;
   this.txtRemarks.Multiline = true;
   this.txtRemarks.Name = "txtRemarks";
   this.txtRemarks.Size = new System.Drawing.Size(227, 21);
   this.txtRemarks.TabIndex = 5;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(13, 110);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(72, 15);
   this.label1.TabIndex = 30;
   this.label1.Text = "Description:";
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(267, 155);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(81, 38);
   this.btnClose.TabIndex = 7;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(179, 155);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(81, 38);
   this.btnSave.TabIndex = 6;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // frmHolidayNew
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(358, 205);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmHolidayNew";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Add New Holiday";
   this.Load += new System.EventHandler(this.frmHolidayNew_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtHolidayCode;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.ComboBox cmbShift;
  private System.Windows.Forms.DateTimePicker dteDateApplied;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtRemarks;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Button btnShiftAdd;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.Button btnShiftDetails;
 }
}