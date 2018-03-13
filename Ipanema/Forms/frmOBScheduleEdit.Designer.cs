namespace Ipanema.Forms
{
 partial class frmOBScheduleEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOBScheduleEdit));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtUpdateOn = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.txtUpdateBy = new System.Windows.Forms.TextBox();
   this.label5 = new System.Windows.Forms.Label();
   this.txtOBCode = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.dtpInDate = new System.Windows.Forms.DateTimePicker();
   this.label4 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.dtpOutTime = new System.Windows.Forms.DateTimePicker();
   this.dtpFocusDate = new System.Windows.Forms.DateTimePicker();
   this.dtpOutDate = new System.Windows.Forms.DateTimePicker();
   this.label3 = new System.Windows.Forms.Label();
   this.dtpInTime = new System.Windows.Forms.DateTimePicker();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(272, 213);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 22;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(186, 213);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 21;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtUpdateOn);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.txtUpdateBy);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.txtOBCode);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Controls.Add(this.dtpInDate);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.dtpOutTime);
   this.groupBox1.Controls.Add(this.dtpFocusDate);
   this.groupBox1.Controls.Add(this.dtpOutDate);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.dtpInTime);
   this.groupBox1.Location = new System.Drawing.Point(11, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(339, 198);
   this.groupBox1.TabIndex = 23;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "OB Schedule Details";
   // 
   // txtUpdateOn
   // 
   this.txtUpdateOn.BackColor = System.Drawing.Color.AliceBlue;
   this.txtUpdateOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtUpdateOn.Location = new System.Drawing.Point(87, 167);
   this.txtUpdateOn.MaxLength = 6;
   this.txtUpdateOn.Name = "txtUpdateOn";
   this.txtUpdateOn.ReadOnly = true;
   this.txtUpdateOn.Size = new System.Drawing.Size(239, 21);
   this.txtUpdateOn.TabIndex = 73;
   this.txtUpdateOn.TabStop = false;
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label6.Location = new System.Drawing.Point(12, 169);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(69, 15);
   this.label6.TabIndex = 72;
   this.label6.Text = "Update On:";
   // 
   // txtUpdateBy
   // 
   this.txtUpdateBy.BackColor = System.Drawing.Color.AliceBlue;
   this.txtUpdateBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtUpdateBy.Location = new System.Drawing.Point(87, 140);
   this.txtUpdateBy.MaxLength = 6;
   this.txtUpdateBy.Name = "txtUpdateBy";
   this.txtUpdateBy.ReadOnly = true;
   this.txtUpdateBy.Size = new System.Drawing.Size(239, 21);
   this.txtUpdateBy.TabIndex = 71;
   this.txtUpdateBy.TabStop = false;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label5.Location = new System.Drawing.Point(12, 142);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(66, 15);
   this.label5.TabIndex = 70;
   this.label5.Text = "Update By:";
   // 
   // txtOBCode
   // 
   this.txtOBCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtOBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtOBCode.Location = new System.Drawing.Point(87, 27);
   this.txtOBCode.MaxLength = 6;
   this.txtOBCode.Name = "txtOBCode";
   this.txtOBCode.ReadOnly = true;
   this.txtOBCode.Size = new System.Drawing.Size(101, 21);
   this.txtOBCode.TabIndex = 69;
   this.txtOBCode.TabStop = false;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(12, 29);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(59, 15);
   this.label1.TabIndex = 68;
   this.label1.Text = "OB Code:";
   // 
   // dtpInDate
   // 
   this.dtpInDate.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpInDate.Enabled = false;
   this.dtpInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpInDate.Location = new System.Drawing.Point(87, 82);
   this.dtpInDate.Name = "dtpInDate";
   this.dtpInDate.Size = new System.Drawing.Size(131, 21);
   this.dtpInDate.TabIndex = 1;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(12, 112);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(60, 15);
   this.label4.TabIndex = 19;
   this.label4.Text = "Time Out:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(12, 57);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(72, 15);
   this.label2.TabIndex = 14;
   this.label2.Text = "Focus Date:";
   // 
   // dtpOutTime
   // 
   this.dtpOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpOutTime.Location = new System.Drawing.Point(228, 110);
   this.dtpOutTime.Name = "dtpOutTime";
   this.dtpOutTime.ShowUpDown = true;
   this.dtpOutTime.Size = new System.Drawing.Size(99, 21);
   this.dtpOutTime.TabIndex = 4;
   // 
   // dtpFocusDate
   // 
   this.dtpFocusDate.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpFocusDate.Enabled = false;
   this.dtpFocusDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFocusDate.Location = new System.Drawing.Point(87, 54);
   this.dtpFocusDate.Name = "dtpFocusDate";
   this.dtpFocusDate.Size = new System.Drawing.Size(131, 21);
   this.dtpFocusDate.TabIndex = 0;
   // 
   // dtpOutDate
   // 
   this.dtpOutDate.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpOutDate.Enabled = false;
   this.dtpOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpOutDate.Location = new System.Drawing.Point(87, 110);
   this.dtpOutDate.Name = "dtpOutDate";
   this.dtpOutDate.Size = new System.Drawing.Size(131, 21);
   this.dtpOutDate.TabIndex = 3;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(12, 85);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(51, 15);
   this.label3.TabIndex = 18;
   this.label3.Text = "Time In:";
   // 
   // dtpInTime
   // 
   this.dtpInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpInTime.Location = new System.Drawing.Point(228, 82);
   this.dtpInTime.Name = "dtpInTime";
   this.dtpInTime.ShowUpDown = true;
   this.dtpInTime.Size = new System.Drawing.Size(99, 21);
   this.dtpInTime.TabIndex = 2;
   // 
   // frmOBScheduleEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(361, 260);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmOBScheduleEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit OB Schedule";
   this.Load += new System.EventHandler(this.frmOBScheduleEdit_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.DateTimePicker dtpInDate;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.DateTimePicker dtpOutTime;
  private System.Windows.Forms.DateTimePicker dtpFocusDate;
  private System.Windows.Forms.DateTimePicker dtpOutDate;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.DateTimePicker dtpInTime;
  private System.Windows.Forms.TextBox txtOBCode;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtUpdateOn;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtUpdateBy;
  private System.Windows.Forms.Label label5;
 }
}