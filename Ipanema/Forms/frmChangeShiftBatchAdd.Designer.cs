namespace Ipanema.Forms
{
 partial class frmChangeShiftBatchAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeShiftBatchAdd));
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.label3 = new System.Windows.Forms.Label();
   this.cmbShiftCode = new System.Windows.Forms.ComboBox();
   this.dtpApplicationDate = new System.Windows.Forms.DateTimePicker();
   this.txtReason = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.txtChangeShiftBatchCode = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.btnSave = new System.Windows.Forms.Button();
   this.btnClose = new System.Windows.Forms.Button();
   this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
   this.groupBox1.SuspendLayout();
   this.tableLayoutPanel1.SuspendLayout();
   this.SuspendLayout();
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.tableLayoutPanel1);
   this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox1.Location = new System.Drawing.Point(9, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(473, 169);
   this.groupBox1.TabIndex = 43;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Change Shift Batch Details";
   // 
   // label3
   // 
   this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(4, 73);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(66, 15);
   this.label3.TabIndex = 46;
   this.label3.Text = "Shift Code:";
   // 
   // cmbShiftCode
   // 
   this.cmbShiftCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.cmbShiftCode.DisplayMember = "ptext";
   this.cmbShiftCode.DropDownHeight = 200;
   this.cmbShiftCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbShiftCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbShiftCode.FormattingEnabled = true;
   this.cmbShiftCode.IntegralHeight = false;
   this.cmbShiftCode.Location = new System.Drawing.Point(112, 69);
   this.cmbShiftCode.Name = "cmbShiftCode";
   this.cmbShiftCode.Size = new System.Drawing.Size(116, 23);
   this.cmbShiftCode.TabIndex = 1;
   this.cmbShiftCode.ValueMember = "pvalue";
   // 
   // dtpApplicationDate
   // 
   this.dtpApplicationDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.dtpApplicationDate.CustomFormat = "MMM dd, yyyy";
   this.dtpApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpApplicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpApplicationDate.Location = new System.Drawing.Point(112, 38);
   this.dtpApplicationDate.Name = "dtpApplicationDate";
   this.dtpApplicationDate.Size = new System.Drawing.Size(114, 21);
   this.dtpApplicationDate.TabIndex = 0;
   this.dtpApplicationDate.ValueChanged += new System.EventHandler(this.dtpApplicationDate_ValueChanged);
   // 
   // txtReason
   // 
   this.txtReason.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtReason.Location = new System.Drawing.Point(112, 102);
   this.txtReason.MaxLength = 50;
   this.txtReason.Name = "txtReason";
   this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtReason.Size = new System.Drawing.Size(328, 21);
   this.txtReason.TabIndex = 2;
   // 
   // label1
   // 
   this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(4, 105);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(53, 15);
   this.label1.TabIndex = 41;
   this.label1.Text = "Reason:";
   // 
   // label4
   // 
   this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label4.AutoSize = true;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(4, 41);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(99, 15);
   this.label4.TabIndex = 36;
   this.label4.Text = "Application Date:";
   // 
   // txtChangeShiftBatchCode
   // 
   this.txtChangeShiftBatchCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.txtChangeShiftBatchCode.BackColor = System.Drawing.Color.Ivory;
   this.txtChangeShiftBatchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtChangeShiftBatchCode.Location = new System.Drawing.Point(112, 6);
   this.txtChangeShiftBatchCode.Name = "txtChangeShiftBatchCode";
   this.txtChangeShiftBatchCode.ReadOnly = true;
   this.txtChangeShiftBatchCode.Size = new System.Drawing.Size(108, 21);
   this.txtChangeShiftBatchCode.TabIndex = 1;
   this.txtChangeShiftBatchCode.TabStop = false;
   // 
   // label2
   // 
   this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(4, 9);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(39, 15);
   this.label2.TabIndex = 28;
   this.label2.Text = "Code:";
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(337, 184);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(70, 30);
   this.btnSave.TabIndex = 3;
   this.btnSave.Text = "Save ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(413, 184);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(70, 30);
   this.btnClose.TabIndex = 4;
   this.btnClose.Text = "Close";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // tableLayoutPanel1
   // 
   this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
   this.tableLayoutPanel1.ColumnCount = 2;
   this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
   this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
   this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
   this.tableLayoutPanel1.Controls.Add(this.txtReason, 1, 3);
   this.tableLayoutPanel1.Controls.Add(this.cmbShiftCode, 1, 2);
   this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
   this.tableLayoutPanel1.Controls.Add(this.dtpApplicationDate, 1, 1);
   this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
   this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
   this.tableLayoutPanel1.Controls.Add(this.txtChangeShiftBatchCode, 1, 0);
   this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 25);
   this.tableLayoutPanel1.Name = "tableLayoutPanel1";
   this.tableLayoutPanel1.RowCount = 4;
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
   this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 130);
   this.tableLayoutPanel1.TabIndex = 47;
   // 
   // frmChangeShiftBatchAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(493, 223);
   this.Controls.Add(this.groupBox1);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.btnClose);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmChangeShiftBatchAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add New Change Shift Batch";
   this.Load += new System.EventHandler(this.frmChangeShiftBatchAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.tableLayoutPanel1.ResumeLayout(false);
   this.tableLayoutPanel1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtChangeShiftBatchCode;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.ComboBox cmbShiftCode;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.DateTimePicker dtpApplicationDate;
  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
 }
}