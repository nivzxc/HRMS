namespace Ipanema.Forms
{
 partial class frmCDLEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCDLEdit));
   this.tabShiftBatch = new System.Windows.Forms.TabControl();
   this.tbpDetails = new System.Windows.Forms.TabPage();
   this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
   this.dtpDateApplied = new System.Windows.Forms.DateTimePicker();
   this.label7 = new System.Windows.Forms.Label();
   this.label8 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label6 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.txtReason = new System.Windows.Forms.TextBox();
   this.tblAffectedEmployees = new System.Windows.Forms.TabPage();
   this.label3 = new System.Windows.Forms.Label();
   this.cmbLeaveType = new System.Windows.Forms.ComboBox();
   this.lvExcluded = new System.Windows.Forms.ListView();
   this.colEmpNameE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.colBalanceE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.btnExcludeAll = new System.Windows.Forms.Button();
   this.btnIncludeAll = new System.Windows.Forms.Button();
   this.btnExclude = new System.Windows.Forms.Button();
   this.btnInclude = new System.Windows.Forms.Button();
   this.lvIncluded = new System.Windows.Forms.ListView();
   this.colEmpNameI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.lblCDLCode = new System.Windows.Forms.Label();
   this.lblCreatedBy = new System.Windows.Forms.Label();
   this.lblDateCreated = new System.Windows.Forms.Label();
   this.lblModifiedBy = new System.Windows.Forms.Label();
   this.lblDateModified = new System.Windows.Forms.Label();
   this.tabShiftBatch.SuspendLayout();
   this.tbpDetails.SuspendLayout();
   this.tableLayoutPanel1.SuspendLayout();
   this.tblAffectedEmployees.SuspendLayout();
   this.SuspendLayout();
   // 
   // tabShiftBatch
   // 
   this.tabShiftBatch.Controls.Add(this.tbpDetails);
   this.tabShiftBatch.Controls.Add(this.tblAffectedEmployees);
   this.tabShiftBatch.Location = new System.Drawing.Point(7, 7);
   this.tabShiftBatch.Name = "tabShiftBatch";
   this.tabShiftBatch.SelectedIndex = 0;
   this.tabShiftBatch.Size = new System.Drawing.Size(611, 457);
   this.tabShiftBatch.TabIndex = 50;
   // 
   // tbpDetails
   // 
   this.tbpDetails.BackColor = System.Drawing.SystemColors.Window;
   this.tbpDetails.Controls.Add(this.tableLayoutPanel1);
   this.tbpDetails.Location = new System.Drawing.Point(4, 24);
   this.tbpDetails.Name = "tbpDetails";
   this.tbpDetails.Padding = new System.Windows.Forms.Padding(3);
   this.tbpDetails.Size = new System.Drawing.Size(603, 429);
   this.tbpDetails.TabIndex = 0;
   this.tbpDetails.Text = "Details";
   // 
   // tableLayoutPanel1
   // 
   this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
   this.tableLayoutPanel1.ColumnCount = 2;
   this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.71067F));
   this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.28933F));
   this.tableLayoutPanel1.Controls.Add(this.lblDateModified, 1, 6);
   this.tableLayoutPanel1.Controls.Add(this.lblModifiedBy, 1, 5);
   this.tableLayoutPanel1.Controls.Add(this.lblDateCreated, 1, 4);
   this.tableLayoutPanel1.Controls.Add(this.lblCreatedBy, 1, 3);
   this.tableLayoutPanel1.Controls.Add(this.lblCDLCode, 1, 0);
   this.tableLayoutPanel1.Controls.Add(this.dtpDateApplied, 1, 1);
   this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
   this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
   this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
   this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
   this.tableLayoutPanel1.Controls.Add(this.txtReason, 1, 2);
   this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
   this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
   this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
   this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 11);
   this.tableLayoutPanel1.Name = "tableLayoutPanel1";
   this.tableLayoutPanel1.RowCount = 7;
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
   this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 192);
   this.tableLayoutPanel1.TabIndex = 57;
   // 
   // dtpDateApplied
   // 
   this.dtpDateApplied.CustomFormat = "MMM dd, yyyy";
   this.dtpDateApplied.Enabled = false;
   this.dtpDateApplied.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpDateApplied.Location = new System.Drawing.Point(111, 31);
   this.dtpDateApplied.Name = "dtpDateApplied";
   this.dtpDateApplied.Size = new System.Drawing.Size(115, 21);
   this.dtpDateApplied.TabIndex = 56;
   this.dtpDateApplied.TabStop = false;
   // 
   // label7
   // 
   this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label7.AutoSize = true;
   this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label7.Location = new System.Drawing.Point(4, 169);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(87, 15);
   this.label7.TabIndex = 54;
   this.label7.Text = "Date Modified:";
   // 
   // label8
   // 
   this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label8.AutoSize = true;
   this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label8.Location = new System.Drawing.Point(4, 141);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(74, 15);
   this.label8.TabIndex = 52;
   this.label8.Text = "Modified By:";
   // 
   // label2
   // 
   this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(4, 6);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(66, 15);
   this.label2.TabIndex = 28;
   this.label2.Text = "CDL Code:";
   // 
   // label6
   // 
   this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label6.AutoSize = true;
   this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label6.Location = new System.Drawing.Point(4, 114);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(82, 15);
   this.label6.TabIndex = 50;
   this.label6.Text = "Date Created:";
   // 
   // label4
   // 
   this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label4.AutoSize = true;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(4, 33);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(99, 15);
   this.label4.TabIndex = 36;
   this.label4.Text = "Application Date:";
   // 
   // label1
   // 
   this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(4, 60);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(53, 15);
   this.label1.TabIndex = 41;
   this.label1.Text = "Reason:";
   // 
   // label5
   // 
   this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label5.AutoSize = true;
   this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label5.Location = new System.Drawing.Point(4, 87);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(69, 15);
   this.label5.TabIndex = 48;
   this.label5.Text = "Created By:";
   // 
   // txtReason
   // 
   this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtReason.Location = new System.Drawing.Point(111, 58);
   this.txtReason.MaxLength = 50;
   this.txtReason.Name = "txtReason";
   this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtReason.Size = new System.Drawing.Size(357, 21);
   this.txtReason.TabIndex = 2;
   // 
   // tblAffectedEmployees
   // 
   this.tblAffectedEmployees.BackColor = System.Drawing.SystemColors.Window;
   this.tblAffectedEmployees.Controls.Add(this.label3);
   this.tblAffectedEmployees.Controls.Add(this.cmbLeaveType);
   this.tblAffectedEmployees.Controls.Add(this.lvExcluded);
   this.tblAffectedEmployees.Controls.Add(this.btnExcludeAll);
   this.tblAffectedEmployees.Controls.Add(this.btnIncludeAll);
   this.tblAffectedEmployees.Controls.Add(this.btnExclude);
   this.tblAffectedEmployees.Controls.Add(this.btnInclude);
   this.tblAffectedEmployees.Controls.Add(this.lvIncluded);
   this.tblAffectedEmployees.Location = new System.Drawing.Point(4, 24);
   this.tblAffectedEmployees.Name = "tblAffectedEmployees";
   this.tblAffectedEmployees.Padding = new System.Windows.Forms.Padding(3);
   this.tblAffectedEmployees.Size = new System.Drawing.Size(603, 429);
   this.tblAffectedEmployees.TabIndex = 1;
   this.tblAffectedEmployees.Text = "Affected Employees";
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(291, 17);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(66, 15);
   this.label3.TabIndex = 51;
   this.label3.Text = "Deduct To:";
   // 
   // cmbLeaveType
   // 
   this.cmbLeaveType.DisplayMember = "ptext";
   this.cmbLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbLeaveType.FormattingEnabled = true;
   this.cmbLeaveType.Location = new System.Drawing.Point(359, 12);
   this.cmbLeaveType.Name = "cmbLeaveType";
   this.cmbLeaveType.Size = new System.Drawing.Size(232, 23);
   this.cmbLeaveType.TabIndex = 50;
   this.cmbLeaveType.ValueMember = "pvalue";
   this.cmbLeaveType.SelectedIndexChanged += new System.EventHandler(this.cmbLeaveType_SelectedIndexChanged);
   // 
   // lvExcluded
   // 
   this.lvExcluded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmpNameE,
            this.colBalanceE});
   this.lvExcluded.FullRowSelect = true;
   this.lvExcluded.GridLines = true;
   this.lvExcluded.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
   this.lvExcluded.HideSelection = false;
   this.lvExcluded.Location = new System.Drawing.Point(293, 42);
   this.lvExcluded.Name = "lvExcluded";
   this.lvExcluded.Size = new System.Drawing.Size(298, 375);
   this.lvExcluded.TabIndex = 49;
   this.lvExcluded.UseCompatibleStateImageBehavior = false;
   this.lvExcluded.View = System.Windows.Forms.View.Details;
   // 
   // colEmpNameE
   // 
   this.colEmpNameE.Text = "Excluded List";
   this.colEmpNameE.Width = 216;
   // 
   // colBalanceE
   // 
   this.colBalanceE.Text = "Balance";
   // 
   // btnExcludeAll
   // 
   this.btnExcludeAll.Image = ((System.Drawing.Image)(resources.GetObject("btnExcludeAll.Image")));
   this.btnExcludeAll.Location = new System.Drawing.Point(256, 227);
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
   this.btnIncludeAll.Location = new System.Drawing.Point(256, 193);
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
   this.btnExclude.Location = new System.Drawing.Point(256, 159);
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
   this.btnInclude.Location = new System.Drawing.Point(256, 125);
   this.btnInclude.Name = "btnInclude";
   this.btnInclude.Size = new System.Drawing.Size(28, 27);
   this.btnInclude.TabIndex = 45;
   this.btnInclude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnInclude.UseVisualStyleBackColor = true;
   this.btnInclude.Click += new System.EventHandler(this.btnInclude_Click);
   // 
   // lvIncluded
   // 
   this.lvIncluded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmpNameI});
   this.lvIncluded.FullRowSelect = true;
   this.lvIncluded.GridLines = true;
   this.lvIncluded.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
   this.lvIncluded.HideSelection = false;
   this.lvIncluded.Location = new System.Drawing.Point(10, 42);
   this.lvIncluded.Name = "lvIncluded";
   this.lvIncluded.Size = new System.Drawing.Size(238, 375);
   this.lvIncluded.TabIndex = 0;
   this.lvIncluded.UseCompatibleStateImageBehavior = false;
   this.lvIncluded.View = System.Windows.Forms.View.Details;
   // 
   // colEmpNameI
   // 
   this.colEmpNameI.Text = "Included List";
   this.colEmpNameI.Width = 216;
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(537, 470);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 49;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(451, 470);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 48;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // lblCDLCode
   // 
   this.lblCDLCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.lblCDLCode.AutoSize = true;
   this.lblCDLCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblCDLCode.Location = new System.Drawing.Point(111, 6);
   this.lblCDLCode.Name = "lblCDLCode";
   this.lblCDLCode.Size = new System.Drawing.Size(69, 15);
   this.lblCDLCode.TabIndex = 37;
   this.lblCDLCode.Text = "[CDL Code]";
   // 
   // lblCreatedBy
   // 
   this.lblCreatedBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.lblCreatedBy.AutoSize = true;
   this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblCreatedBy.Location = new System.Drawing.Point(111, 87);
   this.lblCreatedBy.Name = "lblCreatedBy";
   this.lblCreatedBy.Size = new System.Drawing.Size(72, 15);
   this.lblCreatedBy.TabIndex = 57;
   this.lblCreatedBy.Text = "[Created By]";
   // 
   // lblDateCreated
   // 
   this.lblDateCreated.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.lblDateCreated.AutoSize = true;
   this.lblDateCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblDateCreated.Location = new System.Drawing.Point(111, 114);
   this.lblDateCreated.Name = "lblDateCreated";
   this.lblDateCreated.Size = new System.Drawing.Size(85, 15);
   this.lblDateCreated.TabIndex = 58;
   this.lblDateCreated.Text = "[Date Created]";
   // 
   // lblModifiedBy
   // 
   this.lblModifiedBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.lblModifiedBy.AutoSize = true;
   this.lblModifiedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblModifiedBy.Location = new System.Drawing.Point(111, 141);
   this.lblModifiedBy.Name = "lblModifiedBy";
   this.lblModifiedBy.Size = new System.Drawing.Size(77, 15);
   this.lblModifiedBy.TabIndex = 59;
   this.lblModifiedBy.Text = "[Modified By]";
   // 
   // lblDateModified
   // 
   this.lblDateModified.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.lblDateModified.AutoSize = true;
   this.lblDateModified.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblDateModified.Location = new System.Drawing.Point(111, 169);
   this.lblDateModified.Name = "lblDateModified";
   this.lblDateModified.Size = new System.Drawing.Size(90, 15);
   this.lblDateModified.TabIndex = 60;
   this.lblDateModified.Text = "[Date Modified]";
   // 
   // frmCDLEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
   this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
   this.ClientSize = new System.Drawing.Size(627, 517);
   this.Controls.Add(this.tabShiftBatch);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.DoubleBuffered = true;
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmCDLEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "CDL Details";
   this.Load += new System.EventHandler(this.frmCDLEdit_Load);
   this.tabShiftBatch.ResumeLayout(false);
   this.tbpDetails.ResumeLayout(false);
   this.tableLayoutPanel1.ResumeLayout(false);
   this.tableLayoutPanel1.PerformLayout();
   this.tblAffectedEmployees.ResumeLayout(false);
   this.tblAffectedEmployees.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.TabControl tabShiftBatch;
  private System.Windows.Forms.TabPage tbpDetails;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.TabPage tblAffectedEmployees;
  private System.Windows.Forms.Button btnExcludeAll;
  private System.Windows.Forms.Button btnIncludeAll;
  private System.Windows.Forms.Button btnExclude;
  private System.Windows.Forms.Button btnInclude;
  private System.Windows.Forms.ListView lvIncluded;
  private System.Windows.Forms.ColumnHeader colEmpNameI;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.ListView lvExcluded;
  private System.Windows.Forms.ColumnHeader colEmpNameE;
  private System.Windows.Forms.ColumnHeader colBalanceE;
  private System.Windows.Forms.ComboBox cmbLeaveType;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.DateTimePicker dtpDateApplied;
  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  private System.Windows.Forms.Label lblCDLCode;
  private System.Windows.Forms.Label lblDateModified;
  private System.Windows.Forms.Label lblModifiedBy;
  private System.Windows.Forms.Label lblDateCreated;
  private System.Windows.Forms.Label lblCreatedBy;
 }
}