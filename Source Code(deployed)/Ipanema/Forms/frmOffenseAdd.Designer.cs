namespace Ipanema.Forms
{
 partial class frmOffenseAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOffenseAdd));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
   this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
   this.label5 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.cmbClass = new System.Windows.Forms.ComboBox();
   this.label1 = new System.Windows.Forms.Label();
   this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
   this.label4 = new System.Windows.Forms.Label();
   this.txtDetails = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(382, 198);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(76, 38);
   this.btnClose.TabIndex = 6;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(300, 198);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(76, 38);
   this.btnSave.TabIndex = 5;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.dtpDateEnd);
   this.groupBox1.Controls.Add(this.dtpDateStart);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.cmbClass);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Controls.Add(this.cmbEmployeeName);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.txtDetails);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Location = new System.Drawing.Point(10, 10);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(446, 178);
   this.groupBox1.TabIndex = 9;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Employee Offense Details";
   // 
   // dtpDateEnd
   // 
   this.dtpDateEnd.CustomFormat = "MMM dd, yyyy";
   this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpDateEnd.Location = new System.Drawing.Point(124, 83);
   this.dtpDateEnd.Name = "dtpDateEnd";
   this.dtpDateEnd.Size = new System.Drawing.Size(114, 21);
   this.dtpDateEnd.TabIndex = 2;
   // 
   // dtpDateStart
   // 
   this.dtpDateStart.CustomFormat = "MMM dd, yyyy";
   this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpDateStart.Location = new System.Drawing.Point(124, 54);
   this.dtpDateStart.Name = "dtpDateStart";
   this.dtpDateStart.Size = new System.Drawing.Size(114, 21);
   this.dtpDateStart.TabIndex = 1;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(16, 85);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(61, 15);
   this.label5.TabIndex = 10;
   this.label5.Text = "Date End:";
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(16, 58);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(64, 15);
   this.label3.TabIndex = 9;
   this.label3.Text = "Date Start:";
   // 
   // cmbClass
   // 
   this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbClass.FormattingEnabled = true;
   this.cmbClass.Location = new System.Drawing.Point(124, 142);
   this.cmbClass.Name = "cmbClass";
   this.cmbClass.Size = new System.Drawing.Size(82, 23);
   this.cmbClass.TabIndex = 4;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(16, 146);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(91, 15);
   this.label1.TabIndex = 8;
   this.label1.Text = "Class Category:";
   // 
   // cmbEmployeeName
   // 
   this.cmbEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbEmployeeName.FormattingEnabled = true;
   this.cmbEmployeeName.Location = new System.Drawing.Point(124, 22);
   this.cmbEmployeeName.Name = "cmbEmployeeName";
   this.cmbEmployeeName.Size = new System.Drawing.Size(306, 23);
   this.cmbEmployeeName.TabIndex = 0;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(16, 26);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(102, 15);
   this.label4.TabIndex = 6;
   this.label4.Text = "Employee Name:";
   // 
   // txtDetails
   // 
   this.txtDetails.Location = new System.Drawing.Point(124, 112);
   this.txtDetails.MaxLength = 100;
   this.txtDetails.Name = "txtDetails";
   this.txtDetails.Size = new System.Drawing.Size(306, 21);
   this.txtDetails.TabIndex = 3;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(16, 114);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(48, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Details:";
   // 
   // frmOffenseAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.ClientSize = new System.Drawing.Size(468, 249);
   this.Controls.Add(this.groupBox1);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmOffenseAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add New Employee Offense";
   this.Load += new System.EventHandler(this.frmOffenseAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.DateTimePicker dtpDateEnd;
  private System.Windows.Forms.DateTimePicker dtpDateStart;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.ComboBox cmbClass;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.ComboBox cmbEmployeeName;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtDetails;
  private System.Windows.Forms.Label label2;

 }
}