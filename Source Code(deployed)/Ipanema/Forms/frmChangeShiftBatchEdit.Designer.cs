namespace Ipanema.Forms
{
 partial class frmChangeShiftBatchEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeShiftBatchEdit));
   this.label3 = new System.Windows.Forms.Label();
   this.cmbShiftCode = new System.Windows.Forms.ComboBox();
   this.txtReason = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.txtChangeShiftBatchCode = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.btnSave = new System.Windows.Forms.Button();
   this.btnClose = new System.Windows.Forms.Button();
   this.txtApplicationDate = new System.Windows.Forms.TextBox();
   this.txtCreatedBy = new System.Windows.Forms.TextBox();
   this.label5 = new System.Windows.Forms.Label();
   this.txtCreatedDate = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.txtModifiedDate = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtModifiedBy = new System.Windows.Forms.TextBox();
   this.label8 = new System.Windows.Forms.Label();
   this.tabShiftBatch = new System.Windows.Forms.TabControl();
   this.tbpDetails = new System.Windows.Forms.TabPage();
   this.tblAffectedEmployees = new System.Windows.Forms.TabPage();
   this.btnExcludeAll = new System.Windows.Forms.Button();
   this.btnIncludeAll = new System.Windows.Forms.Button();
   this.btnExclude = new System.Windows.Forms.Button();
   this.btnInclude = new System.Windows.Forms.Button();
   this.lvExcluded = new System.Windows.Forms.ListView();
   this.colEmpListE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.lvIncluded = new System.Windows.Forms.ListView();
   this.colEmpNameI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
   this.tabShiftBatch.SuspendLayout();
   this.tbpDetails.SuspendLayout();
   this.tblAffectedEmployees.SuspendLayout();
   this.tableLayoutPanel1.SuspendLayout();
   this.SuspendLayout();
   // 
   // label3
   // 
   this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(4, 68);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(66, 15);
   this.label3.TabIndex = 46;
   this.label3.Text = "Shift Code:";
   // 
   // cmbShiftCode
   // 
   this.cmbShiftCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.cmbShiftCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbShiftCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbShiftCode.FormattingEnabled = true;
   this.cmbShiftCode.Location = new System.Drawing.Point(113, 64);
   this.cmbShiftCode.Name = "cmbShiftCode";
   this.cmbShiftCode.Size = new System.Drawing.Size(116, 23);
   this.cmbShiftCode.TabIndex = 1;
   // 
   // txtReason
   // 
   this.txtReason.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtReason.Location = new System.Drawing.Point(113, 95);
   this.txtReason.MaxLength = 50;
   this.txtReason.Name = "txtReason";
   this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtReason.Size = new System.Drawing.Size(327, 21);
   this.txtReason.TabIndex = 2;
   // 
   // label1
   // 
   this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(4, 98);
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
   this.label4.Location = new System.Drawing.Point(4, 38);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(99, 15);
   this.label4.TabIndex = 36;
   this.label4.Text = "Application Date:";
   // 
   // txtChangeShiftBatchCode
   // 
   this.txtChangeShiftBatchCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.txtChangeShiftBatchCode.BackColor = System.Drawing.Color.Ivory;
   this.txtChangeShiftBatchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtChangeShiftBatchCode.Location = new System.Drawing.Point(113, 5);
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
   this.label2.Location = new System.Drawing.Point(4, 8);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(39, 15);
   this.label2.TabIndex = 28;
   this.label2.Text = "Code:";
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(337, 442);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(70, 30);
   this.btnSave.TabIndex = 44;
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
   this.btnClose.Location = new System.Drawing.Point(413, 442);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(70, 30);
   this.btnClose.TabIndex = 45;
   this.btnClose.Text = "Close";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // txtApplicationDate
   // 
   this.txtApplicationDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.txtApplicationDate.BackColor = System.Drawing.Color.Ivory;
   this.txtApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtApplicationDate.Location = new System.Drawing.Point(113, 35);
   this.txtApplicationDate.Name = "txtApplicationDate";
   this.txtApplicationDate.ReadOnly = true;
   this.txtApplicationDate.Size = new System.Drawing.Size(206, 21);
   this.txtApplicationDate.TabIndex = 47;
   this.txtApplicationDate.TabStop = false;
   // 
   // txtCreatedBy
   // 
   this.txtCreatedBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.txtCreatedBy.BackColor = System.Drawing.Color.Ivory;
   this.txtCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtCreatedBy.Location = new System.Drawing.Point(113, 125);
   this.txtCreatedBy.Name = "txtCreatedBy";
   this.txtCreatedBy.ReadOnly = true;
   this.txtCreatedBy.Size = new System.Drawing.Size(206, 21);
   this.txtCreatedBy.TabIndex = 49;
   this.txtCreatedBy.TabStop = false;
   // 
   // label5
   // 
   this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label5.AutoSize = true;
   this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label5.Location = new System.Drawing.Point(4, 128);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(69, 15);
   this.label5.TabIndex = 48;
   this.label5.Text = "Created By:";
   // 
   // txtCreatedDate
   // 
   this.txtCreatedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.txtCreatedDate.BackColor = System.Drawing.Color.Ivory;
   this.txtCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtCreatedDate.Location = new System.Drawing.Point(113, 155);
   this.txtCreatedDate.Name = "txtCreatedDate";
   this.txtCreatedDate.ReadOnly = true;
   this.txtCreatedDate.Size = new System.Drawing.Size(206, 21);
   this.txtCreatedDate.TabIndex = 51;
   this.txtCreatedDate.TabStop = false;
   // 
   // label6
   // 
   this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label6.AutoSize = true;
   this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label6.Location = new System.Drawing.Point(4, 158);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(82, 15);
   this.label6.TabIndex = 50;
   this.label6.Text = "Date Created:";
   // 
   // txtModifiedDate
   // 
   this.txtModifiedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.txtModifiedDate.BackColor = System.Drawing.Color.Ivory;
   this.txtModifiedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtModifiedDate.Location = new System.Drawing.Point(113, 216);
   this.txtModifiedDate.Name = "txtModifiedDate";
   this.txtModifiedDate.ReadOnly = true;
   this.txtModifiedDate.Size = new System.Drawing.Size(206, 21);
   this.txtModifiedDate.TabIndex = 55;
   this.txtModifiedDate.TabStop = false;
   // 
   // label7
   // 
   this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label7.AutoSize = true;
   this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label7.Location = new System.Drawing.Point(4, 219);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(87, 15);
   this.label7.TabIndex = 54;
   this.label7.Text = "Date Modified:";
   // 
   // txtModifiedBy
   // 
   this.txtModifiedBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.txtModifiedBy.BackColor = System.Drawing.Color.Ivory;
   this.txtModifiedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtModifiedBy.Location = new System.Drawing.Point(113, 185);
   this.txtModifiedBy.Name = "txtModifiedBy";
   this.txtModifiedBy.ReadOnly = true;
   this.txtModifiedBy.Size = new System.Drawing.Size(206, 21);
   this.txtModifiedBy.TabIndex = 53;
   this.txtModifiedBy.TabStop = false;
   // 
   // label8
   // 
   this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label8.AutoSize = true;
   this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label8.Location = new System.Drawing.Point(4, 188);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(74, 15);
   this.label8.TabIndex = 52;
   this.label8.Text = "Modified By:";
   // 
   // tabShiftBatch
   // 
   this.tabShiftBatch.Controls.Add(this.tbpDetails);
   this.tabShiftBatch.Controls.Add(this.tblAffectedEmployees);
   this.tabShiftBatch.Location = new System.Drawing.Point(8, 6);
   this.tabShiftBatch.Name = "tabShiftBatch";
   this.tabShiftBatch.SelectedIndex = 0;
   this.tabShiftBatch.Size = new System.Drawing.Size(478, 428);
   this.tabShiftBatch.TabIndex = 47;
   // 
   // tbpDetails
   // 
   this.tbpDetails.BackColor = System.Drawing.SystemColors.Window;
   this.tbpDetails.Controls.Add(this.tableLayoutPanel1);
   this.tbpDetails.Location = new System.Drawing.Point(4, 24);
   this.tbpDetails.Name = "tbpDetails";
   this.tbpDetails.Padding = new System.Windows.Forms.Padding(3);
   this.tbpDetails.Size = new System.Drawing.Size(470, 400);
   this.tbpDetails.TabIndex = 0;
   this.tbpDetails.Text = "Details";
   // 
   // tblAffectedEmployees
   // 
   this.tblAffectedEmployees.BackColor = System.Drawing.SystemColors.Window;
   this.tblAffectedEmployees.Controls.Add(this.btnExcludeAll);
   this.tblAffectedEmployees.Controls.Add(this.btnIncludeAll);
   this.tblAffectedEmployees.Controls.Add(this.btnExclude);
   this.tblAffectedEmployees.Controls.Add(this.btnInclude);
   this.tblAffectedEmployees.Controls.Add(this.lvExcluded);
   this.tblAffectedEmployees.Controls.Add(this.lvIncluded);
   this.tblAffectedEmployees.Location = new System.Drawing.Point(4, 24);
   this.tblAffectedEmployees.Name = "tblAffectedEmployees";
   this.tblAffectedEmployees.Padding = new System.Windows.Forms.Padding(3);
   this.tblAffectedEmployees.Size = new System.Drawing.Size(470, 400);
   this.tblAffectedEmployees.TabIndex = 1;
   this.tblAffectedEmployees.Text = "Affected Employees";
   // 
   // btnExcludeAll
   // 
   this.btnExcludeAll.Image = ((System.Drawing.Image)(resources.GetObject("btnExcludeAll.Image")));
   this.btnExcludeAll.Location = new System.Drawing.Point(219, 188);
   this.btnExcludeAll.Name = "btnExcludeAll";
   this.btnExcludeAll.Size = new System.Drawing.Size(28, 27);
   this.btnExcludeAll.TabIndex = 48;
   this.btnExcludeAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnExcludeAll.UseVisualStyleBackColor = true;
   this.btnExcludeAll.Click += new System.EventHandler(this.btnExcludeAll_Click);
   // 
   // btnIncludeAll
   // 
   this.btnIncludeAll.Image = ((System.Drawing.Image)(resources.GetObject("btnIncludeAll.Image")));
   this.btnIncludeAll.Location = new System.Drawing.Point(219, 154);
   this.btnIncludeAll.Name = "btnIncludeAll";
   this.btnIncludeAll.Size = new System.Drawing.Size(28, 27);
   this.btnIncludeAll.TabIndex = 47;
   this.btnIncludeAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnIncludeAll.UseVisualStyleBackColor = true;
   this.btnIncludeAll.Click += new System.EventHandler(this.btnIncludeAll_Click);
   // 
   // btnExclude
   // 
   this.btnExclude.Image = ((System.Drawing.Image)(resources.GetObject("btnExclude.Image")));
   this.btnExclude.Location = new System.Drawing.Point(219, 120);
   this.btnExclude.Name = "btnExclude";
   this.btnExclude.Size = new System.Drawing.Size(28, 27);
   this.btnExclude.TabIndex = 46;
   this.btnExclude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnExclude.UseVisualStyleBackColor = true;
   this.btnExclude.Click += new System.EventHandler(this.btnExclude_Click);
   // 
   // btnInclude
   // 
   this.btnInclude.Image = ((System.Drawing.Image)(resources.GetObject("btnInclude.Image")));
   this.btnInclude.Location = new System.Drawing.Point(219, 86);
   this.btnInclude.Name = "btnInclude";
   this.btnInclude.Size = new System.Drawing.Size(28, 27);
   this.btnInclude.TabIndex = 45;
   this.btnInclude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnInclude.UseVisualStyleBackColor = true;
   this.btnInclude.Click += new System.EventHandler(this.btnInclude_Click);
   // 
   // lvExcluded
   // 
   this.lvExcluded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmpListE});
   this.lvExcluded.FullRowSelect = true;
   this.lvExcluded.GridLines = true;
   this.lvExcluded.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
   this.lvExcluded.HideSelection = false;
   this.lvExcluded.Location = new System.Drawing.Point(253, 12);
   this.lvExcluded.Name = "lvExcluded";
   this.lvExcluded.Size = new System.Drawing.Size(204, 377);
   this.lvExcluded.TabIndex = 1;
   this.lvExcluded.UseCompatibleStateImageBehavior = false;
   this.lvExcluded.View = System.Windows.Forms.View.Details;
   // 
   // colEmpListE
   // 
   this.colEmpListE.Text = "Excluded List";
   this.colEmpListE.Width = 182;
   // 
   // lvIncluded
   // 
   this.lvIncluded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmpNameI});
   this.lvIncluded.FullRowSelect = true;
   this.lvIncluded.GridLines = true;
   this.lvIncluded.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
   this.lvIncluded.HideSelection = false;
   this.lvIncluded.Location = new System.Drawing.Point(10, 12);
   this.lvIncluded.Name = "lvIncluded";
   this.lvIncluded.Size = new System.Drawing.Size(204, 377);
   this.lvIncluded.TabIndex = 0;
   this.lvIncluded.UseCompatibleStateImageBehavior = false;
   this.lvIncluded.View = System.Windows.Forms.View.Details;
   // 
   // colEmpNameI
   // 
   this.colEmpNameI.Text = "Included List";
   this.colEmpNameI.Width = 182;
   // 
   // tableLayoutPanel1
   // 
   this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
   this.tableLayoutPanel1.ColumnCount = 2;
   this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
   this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
   this.tableLayoutPanel1.Controls.Add(this.txtModifiedDate, 1, 7);
   this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
   this.tableLayoutPanel1.Controls.Add(this.txtModifiedBy, 1, 6);
   this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
   this.tableLayoutPanel1.Controls.Add(this.txtCreatedDate, 1, 5);
   this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
   this.tableLayoutPanel1.Controls.Add(this.txtCreatedBy, 1, 4);
   this.tableLayoutPanel1.Controls.Add(this.txtChangeShiftBatchCode, 1, 0);
   this.tableLayoutPanel1.Controls.Add(this.txtReason, 1, 3);
   this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
   this.tableLayoutPanel1.Controls.Add(this.cmbShiftCode, 1, 2);
   this.tableLayoutPanel1.Controls.Add(this.txtApplicationDate, 1, 1);
   this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
   this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
   this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
   this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
   this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 10);
   this.tableLayoutPanel1.Name = "tableLayoutPanel1";
   this.tableLayoutPanel1.RowCount = 8;
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
   this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 244);
   this.tableLayoutPanel1.TabIndex = 56;
   // 
   // frmChangeShiftBatchEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
   this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(494, 481);
   this.Controls.Add(this.tabShiftBatch);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.DoubleBuffered = true;
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmChangeShiftBatchEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Change Shift Batch Edit";
   this.Load += new System.EventHandler(this.frmChangeShiftBatchEdit_Load);
   this.tabShiftBatch.ResumeLayout(false);
   this.tbpDetails.ResumeLayout(false);
   this.tblAffectedEmployees.ResumeLayout(false);
   this.tableLayoutPanel1.ResumeLayout(false);
   this.tableLayoutPanel1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.ComboBox cmbShiftCode;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtChangeShiftBatchCode;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.TextBox txtApplicationDate;
  private System.Windows.Forms.TextBox txtModifiedDate;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtModifiedBy;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.TextBox txtCreatedDate;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtCreatedBy;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TabControl tabShiftBatch;
  private System.Windows.Forms.TabPage tbpDetails;
  private System.Windows.Forms.TabPage tblAffectedEmployees;
  private System.Windows.Forms.ListView lvIncluded;
  private System.Windows.Forms.ColumnHeader colEmpNameI;
  private System.Windows.Forms.ListView lvExcluded;
  private System.Windows.Forms.ColumnHeader colEmpListE;
  private System.Windows.Forms.Button btnInclude;
  private System.Windows.Forms.Button btnExcludeAll;
  private System.Windows.Forms.Button btnIncludeAll;
  private System.Windows.Forms.Button btnExclude;
  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
 }
}