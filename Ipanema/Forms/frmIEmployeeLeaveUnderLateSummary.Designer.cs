namespace Ipanema.Forms
{
 partial class frmIEmployeeLeaveUnderLateSummary
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIEmployeeLeaveUnderLateSummary));
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
   this.panel2 = new System.Windows.Forms.Panel();
   this.btnResetPeriod = new System.Windows.Forms.Button();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.dtpTo = new System.Windows.Forms.DateTimePicker();
   this.label4 = new System.Windows.Forms.Label();
   this.dtpFrom = new System.Windows.Forms.DateTimePicker();
   this.label3 = new System.Windows.Forms.Label();
   this.panel3 = new System.Windows.Forms.Panel();
   this.panel1 = new System.Windows.Forms.Panel();
   this.dgInquiry = new System.Windows.Forms.DataGridView();
   this.colEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colLWithPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colLWoutPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colLate = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colUndertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.panel2.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
   this.panel1.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgInquiry)).BeginInit();
   this.SuspendLayout();
   // 
   // panel2
   // 
   this.panel2.BackColor = System.Drawing.Color.AliceBlue;
   this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
   this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
   this.panel2.Controls.Add(this.btnResetPeriod);
   this.panel2.Controls.Add(this.pictureBox1);
   this.panel2.Controls.Add(this.dtpTo);
   this.panel2.Controls.Add(this.label4);
   this.panel2.Controls.Add(this.dtpFrom);
   this.panel2.Controls.Add(this.label3);
   this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
   this.panel2.Location = new System.Drawing.Point(0, 0);
   this.panel2.Name = "panel2";
   this.panel2.Size = new System.Drawing.Size(760, 44);
   this.panel2.TabIndex = 1;
   // 
   // btnResetPeriod
   // 
   this.btnResetPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnResetPeriod.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPeriod.Image")));
   this.btnResetPeriod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnResetPeriod.Location = new System.Drawing.Point(371, 9);
   this.btnResetPeriod.Name = "btnResetPeriod";
   this.btnResetPeriod.Size = new System.Drawing.Size(100, 25);
   this.btnResetPeriod.TabIndex = 41;
   this.btnResetPeriod.Text = "Default Period";
   this.btnResetPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnResetPeriod.UseVisualStyleBackColor = true;
   // 
   // pictureBox1
   // 
   this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
   this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(8, 9);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(24, 22);
   this.pictureBox1.TabIndex = 40;
   this.pictureBox1.TabStop = false;
   // 
   // dtpTo
   // 
   this.dtpTo.CustomFormat = "MMM dd, yyyy";
   this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpTo.Location = new System.Drawing.Point(264, 10);
   this.dtpTo.Name = "dtpTo";
   this.dtpTo.Size = new System.Drawing.Size(100, 21);
   this.dtpTo.TabIndex = 36;
   this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.BackColor = System.Drawing.Color.Transparent;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(240, 14);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(21, 15);
   this.label4.TabIndex = 39;
   this.label4.Text = "To";
   // 
   // dtpFrom
   // 
   this.dtpFrom.CustomFormat = "MMM dd, yyyy";
   this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFrom.Location = new System.Drawing.Point(136, 10);
   this.dtpFrom.Name = "dtpFrom";
   this.dtpFrom.Size = new System.Drawing.Size(100, 21);
   this.dtpFrom.TabIndex = 35;
   this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.BackColor = System.Drawing.Color.Transparent;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(43, 14);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(92, 15);
   this.label3.TabIndex = 38;
   this.label3.Text = "Inclusive Dates:";
   // 
   // panel3
   // 
   this.panel3.BackColor = System.Drawing.Color.AliceBlue;
   this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
   this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
   this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
   this.panel3.Location = new System.Drawing.Point(0, 502);
   this.panel3.Name = "panel3";
   this.panel3.Size = new System.Drawing.Size(760, 28);
   this.panel3.TabIndex = 2;
   // 
   // panel1
   // 
   this.panel1.Controls.Add(this.dgInquiry);
   this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
   this.panel1.Location = new System.Drawing.Point(0, 44);
   this.panel1.Name = "panel1";
   this.panel1.Size = new System.Drawing.Size(760, 458);
   this.panel1.TabIndex = 3;
   // 
   // dgInquiry
   // 
   this.dgInquiry.AllowUserToAddRows = false;
   this.dgInquiry.AllowUserToDeleteRows = false;
   this.dgInquiry.AllowUserToOrderColumns = true;
   dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
   this.dgInquiry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
   this.dgInquiry.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgInquiry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgInquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgInquiry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployee,
            this.colLWithPay,
            this.colLWoutPay,
            this.colAbsent,
            this.colLate,
            this.colUndertime});
   this.dgInquiry.Cursor = System.Windows.Forms.Cursors.Default;
   this.dgInquiry.Dock = System.Windows.Forms.DockStyle.Fill;
   this.dgInquiry.Location = new System.Drawing.Point(0, 0);
   this.dgInquiry.MultiSelect = false;
   this.dgInquiry.Name = "dgInquiry";
   this.dgInquiry.ReadOnly = true;
   this.dgInquiry.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgInquiry.RowHeadersWidth = 20;
   this.dgInquiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   this.dgInquiry.Size = new System.Drawing.Size(760, 458);
   this.dgInquiry.TabIndex = 4;
   this.dgInquiry.VirtualMode = true;
   // 
   // colEmployee
   // 
   this.colEmployee.Frozen = true;
   this.colEmployee.HeaderText = "Employee";
   this.colEmployee.Name = "colEmployee";
   this.colEmployee.ReadOnly = true;
   this.colEmployee.Width = 220;
   // 
   // colLWithPay
   // 
   dataGridViewCellStyle2.Format = "N2";
   dataGridViewCellStyle2.NullValue = null;
   this.colLWithPay.DefaultCellStyle = dataGridViewCellStyle2;
   this.colLWithPay.HeaderText = "L With Pay";
   this.colLWithPay.Name = "colLWithPay";
   this.colLWithPay.ReadOnly = true;
   this.colLWithPay.Width = 90;
   // 
   // colLWoutPay
   // 
   dataGridViewCellStyle3.Format = "N2";
   dataGridViewCellStyle3.NullValue = null;
   this.colLWoutPay.DefaultCellStyle = dataGridViewCellStyle3;
   this.colLWoutPay.HeaderText = "L Wout Pay";
   this.colLWoutPay.Name = "colLWoutPay";
   this.colLWoutPay.ReadOnly = true;
   this.colLWoutPay.Width = 90;
   // 
   // colAbsent
   // 
   dataGridViewCellStyle4.Format = "N2";
   dataGridViewCellStyle4.NullValue = null;
   this.colAbsent.DefaultCellStyle = dataGridViewCellStyle4;
   this.colAbsent.HeaderText = "Absent";
   this.colAbsent.Name = "colAbsent";
   this.colAbsent.ReadOnly = true;
   this.colAbsent.Width = 90;
   // 
   // colLate
   // 
   dataGridViewCellStyle5.Format = "N2";
   dataGridViewCellStyle5.NullValue = null;
   this.colLate.DefaultCellStyle = dataGridViewCellStyle5;
   this.colLate.HeaderText = "Late";
   this.colLate.Name = "colLate";
   this.colLate.ReadOnly = true;
   this.colLate.Width = 90;
   // 
   // colUndertime
   // 
   dataGridViewCellStyle6.Format = "N2";
   dataGridViewCellStyle6.NullValue = null;
   this.colUndertime.DefaultCellStyle = dataGridViewCellStyle6;
   this.colUndertime.HeaderText = "Undertime";
   this.colUndertime.Name = "colUndertime";
   this.colUndertime.ReadOnly = true;
   this.colUndertime.Width = 90;
   // 
   // frmIEmployeeLeaveUnderLateSummary
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(760, 530);
   this.Controls.Add(this.panel1);
   this.Controls.Add(this.panel3);
   this.Controls.Add(this.panel2);
   this.Name = "frmIEmployeeLeaveUnderLateSummary";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Employee Leave, Absences, Late and Undertime Summary";
   this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
   this.Load += new System.EventHandler(this.frmIEmployeeLeaveUnderLateSummary_Load);
   this.panel2.ResumeLayout(false);
   this.panel2.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
   this.panel1.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.dgInquiry)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel panel2;
  private System.Windows.Forms.Panel panel3;
  private System.Windows.Forms.Panel panel1;
  private System.Windows.Forms.PictureBox pictureBox1;
  private System.Windows.Forms.DateTimePicker dtpTo;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.DateTimePicker dtpFrom;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Button btnResetPeriod;
  internal System.Windows.Forms.DataGridView dgInquiry;
  private System.Windows.Forms.DataGridViewTextBoxColumn colEmployee;
  private System.Windows.Forms.DataGridViewTextBoxColumn colLWithPay;
  private System.Windows.Forms.DataGridViewTextBoxColumn colLWoutPay;
  private System.Windows.Forms.DataGridViewTextBoxColumn colAbsent;
  private System.Windows.Forms.DataGridViewTextBoxColumn colLate;
  private System.Windows.Forms.DataGridViewTextBoxColumn colUndertime;
 }
}