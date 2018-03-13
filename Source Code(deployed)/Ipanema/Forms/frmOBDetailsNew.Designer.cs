namespace Ipanema.Forms
{
 partial class frmOBDetailsNew
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOBDetailsNew));
   this.label4 = new System.Windows.Forms.Label();
   this.dtpOutTime = new System.Windows.Forms.DateTimePicker();
   this.dtpOutDate = new System.Windows.Forms.DateTimePicker();
   this.dtpInTime = new System.Windows.Forms.DateTimePicker();
   this.label3 = new System.Windows.Forms.Label();
   this.dtpInDate = new System.Windows.Forms.DateTimePicker();
   this.dtpFocusDate = new System.Windows.Forms.DateTimePicker();
   this.label2 = new System.Windows.Forms.Label();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(12, 89);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(60, 15);
   this.label4.TabIndex = 19;
   this.label4.Text = "Time Out:";
   // 
   // dtpOutTime
   // 
   this.dtpOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpOutTime.Location = new System.Drawing.Point(229, 87);
   this.dtpOutTime.Name = "dtpOutTime";
   this.dtpOutTime.ShowUpDown = true;
   this.dtpOutTime.Size = new System.Drawing.Size(99, 21);
   this.dtpOutTime.TabIndex = 4;
   // 
   // dtpOutDate
   // 
   this.dtpOutDate.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpOutDate.Location = new System.Drawing.Point(87, 87);
   this.dtpOutDate.Name = "dtpOutDate";
   this.dtpOutDate.Size = new System.Drawing.Size(133, 21);
   this.dtpOutDate.TabIndex = 3;
   // 
   // dtpInTime
   // 
   this.dtpInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
   this.dtpInTime.Location = new System.Drawing.Point(229, 58);
   this.dtpInTime.Name = "dtpInTime";
   this.dtpInTime.ShowUpDown = true;
   this.dtpInTime.Size = new System.Drawing.Size(99, 21);
   this.dtpInTime.TabIndex = 2;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(12, 61);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(51, 15);
   this.label3.TabIndex = 18;
   this.label3.Text = "Time In:";
   // 
   // dtpInDate
   // 
   this.dtpInDate.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpInDate.Location = new System.Drawing.Point(87, 58);
   this.dtpInDate.Name = "dtpInDate";
   this.dtpInDate.Size = new System.Drawing.Size(133, 21);
   this.dtpInDate.TabIndex = 1;
   // 
   // dtpFocusDate
   // 
   this.dtpFocusDate.CustomFormat = "ddd MMM dd, yyyy";
   this.dtpFocusDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFocusDate.Location = new System.Drawing.Point(87, 29);
   this.dtpFocusDate.Name = "dtpFocusDate";
   this.dtpFocusDate.Size = new System.Drawing.Size(133, 21);
   this.dtpFocusDate.TabIndex = 0;
   this.dtpFocusDate.ValueChanged += new System.EventHandler(this.dtpFocusDate_ValueChanged);
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(12, 32);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(72, 15);
   this.label2.TabIndex = 14;
   this.label2.Text = "Focus Date:";
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.dtpInDate);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.dtpOutTime);
   this.groupBox1.Controls.Add(this.dtpFocusDate);
   this.groupBox1.Controls.Add(this.dtpOutDate);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.dtpInTime);
   this.groupBox1.Location = new System.Drawing.Point(9, 4);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(341, 120);
   this.groupBox1.TabIndex = 20;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "OB Schedule Details";
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(279, 131);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(73, 30);
   this.btnClose.TabIndex = 6;
   this.btnClose.Text = "Close ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(197, 131);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(73, 30);
   this.btnSave.TabIndex = 5;
   this.btnSave.Text = "Save  ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // frmOBDetailsNew
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(361, 169);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmOBDetailsNew";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add New OB Schedule";
   this.Load += new System.EventHandler(this.frmOBDetailsNew_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.DateTimePicker dtpOutTime;
  private System.Windows.Forms.DateTimePicker dtpOutDate;
  private System.Windows.Forms.DateTimePicker dtpInTime;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.DateTimePicker dtpInDate;
  private System.Windows.Forms.DateTimePicker dtpFocusDate;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
 }
}