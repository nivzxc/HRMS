namespace Ipanema.Forms
{
 partial class frmEmployeeScheduleInsert
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeScheduleInsert));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtEmployeeName = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.btnSearch = new System.Windows.Forms.Button();
   this.label5 = new System.Windows.Forms.Label();
   this.txtRemarks = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.txtReason = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.dtpTo = new System.Windows.Forms.DateTimePicker();
   this.dtpFrom = new System.Windows.Forms.DateTimePicker();
   this.label1 = new System.Windows.Forms.Label();
   this.cmbSchedule = new System.Windows.Forms.ComboBox();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(335, 247);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(70, 31);
   this.btnClose.TabIndex = 10;
   this.btnClose.Text = "Close";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(258, 247);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(70, 31);
   this.btnSave.TabIndex = 9;
   this.btnSave.Text = "Save ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtEmployeeName);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.btnSearch);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.txtRemarks);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.txtReason);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.dtpTo);
   this.groupBox1.Controls.Add(this.dtpFrom);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Controls.Add(this.cmbSchedule);
   this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox1.Location = new System.Drawing.Point(9, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(395, 231);
   this.groupBox1.TabIndex = 8;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Schedule Details";
   // 
   // txtEmployeeName
   // 
   this.txtEmployeeName.BackColor = System.Drawing.Color.Ivory;
   this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtEmployeeName.Location = new System.Drawing.Point(115, 24);
   this.txtEmployeeName.Name = "txtEmployeeName";
   this.txtEmployeeName.ReadOnly = true;
   this.txtEmployeeName.Size = new System.Drawing.Size(269, 21);
   this.txtEmployeeName.TabIndex = 29;
   this.txtEmployeeName.TabStop = false;
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label6.Location = new System.Drawing.Point(9, 27);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(102, 15);
   this.label6.TabIndex = 30;
   this.label6.Text = "Employee Name:";
   // 
   // btnSearch
   // 
   this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
   this.btnSearch.Location = new System.Drawing.Point(314, 49);
   this.btnSearch.Name = "btnSearch";
   this.btnSearch.Size = new System.Drawing.Size(25, 25);
   this.btnSearch.TabIndex = 1;
   this.btnSearch.UseVisualStyleBackColor = true;
   this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(9, 165);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(60, 15);
   this.label5.TabIndex = 9;
   this.label5.Text = "Remarks:";
   // 
   // txtRemarks
   // 
   this.txtRemarks.Location = new System.Drawing.Point(115, 167);
   this.txtRemarks.Multiline = true;
   this.txtRemarks.Name = "txtRemarks";
   this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtRemarks.Size = new System.Drawing.Size(267, 56);
   this.txtRemarks.TabIndex = 5;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(9, 104);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(53, 15);
   this.label4.TabIndex = 7;
   this.label4.Text = "Reason:";
   // 
   // txtReason
   // 
   this.txtReason.Location = new System.Drawing.Point(115, 105);
   this.txtReason.Multiline = true;
   this.txtReason.Name = "txtReason";
   this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtReason.Size = new System.Drawing.Size(269, 56);
   this.txtReason.TabIndex = 4;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(219, 81);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(24, 15);
   this.label3.TabIndex = 5;
   this.label3.Text = "To:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(9, 81);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(87, 15);
   this.label2.TabIndex = 4;
   this.label2.Text = "Effective From:";
   // 
   // dtpTo
   // 
   this.dtpTo.CustomFormat = "MMM dd, yyyy";
   this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpTo.Location = new System.Drawing.Point(244, 78);
   this.dtpTo.Name = "dtpTo";
   this.dtpTo.Size = new System.Drawing.Size(100, 21);
   this.dtpTo.TabIndex = 3;
   // 
   // dtpFrom
   // 
   this.dtpFrom.CustomFormat = "MMM dd, yyyy";
   this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFrom.Location = new System.Drawing.Point(115, 78);
   this.dtpFrom.Name = "dtpFrom";
   this.dtpFrom.Size = new System.Drawing.Size(100, 21);
   this.dtpFrom.TabIndex = 2;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(9, 53);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(99, 15);
   this.label1.TabIndex = 1;
   this.label1.Text = "Select Schedule:";
   // 
   // cmbSchedule
   // 
   this.cmbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbSchedule.FormattingEnabled = true;
   this.cmbSchedule.Location = new System.Drawing.Point(115, 50);
   this.cmbSchedule.Name = "cmbSchedule";
   this.cmbSchedule.Size = new System.Drawing.Size(194, 23);
   this.cmbSchedule.TabIndex = 0;
   // 
   // frmEmployeeScheduleInsert
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(412, 286);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmEmployeeScheduleInsert";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add New Schedule";
   this.Load += new System.EventHandler(this.frmEmployeeScheduleInsert_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.Button btnSearch;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtRemarks;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.DateTimePicker dtpTo;
  private System.Windows.Forms.DateTimePicker dtpFrom;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.ComboBox cmbSchedule;
  private System.Windows.Forms.TextBox txtEmployeeName;
  private System.Windows.Forms.Label label6;
 }
}