namespace Ipanema.Forms
{
 partial class frmLeaveEntitlementList
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaveEntitlementList));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.pnlHeader = new System.Windows.Forms.Panel();
      this.txtLastName = new System.Windows.Forms.TextBox();
      this.cmbStatus = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cmbLeaveType = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tsButtons = new System.Windows.Forms.ToolStrip();
      this.tbtnProcess = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tbtnEdit = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.tbtnDelete = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.tbtnRefresh = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.tbtnActivate = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.tbtnDeactivate = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.tbtnClose = new System.Windows.Forms.ToolStripButton();
      this.pnlBody = new System.Windows.Forms.Panel();
      this.dgEntitlementList = new System.Windows.Forms.DataGridView();
      this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colLeaveTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEntitled = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cmsList = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
      this.tmsiEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
      this.pnlHeader.SuspendLayout();
      this.tsButtons.SuspendLayout();
      this.pnlBody.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgEntitlementList)).BeginInit();
      this.cmsList.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlHeader
      // 
      this.pnlHeader.BackColor = System.Drawing.Color.White;
      this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
      this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pnlHeader.Controls.Add(this.txtLastName);
      this.pnlHeader.Controls.Add(this.cmbStatus);
      this.pnlHeader.Controls.Add(this.label1);
      this.pnlHeader.Controls.Add(this.cmbLeaveType);
      this.pnlHeader.Controls.Add(this.label5);
      this.pnlHeader.Controls.Add(this.label2);
      this.pnlHeader.Controls.Add(this.tsButtons);
      this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pnlHeader.Location = new System.Drawing.Point(0, 0);
      this.pnlHeader.Name = "pnlHeader";
      this.pnlHeader.Size = new System.Drawing.Size(988, 76);
      this.pnlHeader.TabIndex = 1;
      // 
      // txtLastName
      // 
      this.txtLastName.Location = new System.Drawing.Point(81, 40);
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Size = new System.Drawing.Size(262, 21);
      this.txtLastName.TabIndex = 0;
      this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
      // 
      // cmbStatus
      // 
      this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbStatus.FormattingEnabled = true;
      this.cmbStatus.Location = new System.Drawing.Point(731, 39);
      this.cmbStatus.Name = "cmbStatus";
      this.cmbStatus.Size = new System.Drawing.Size(117, 23);
      this.cmbStatus.TabIndex = 3;
      this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(683, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 15);
      this.label1.TabIndex = 40;
      this.label1.Text = "Status:";
      // 
      // cmbLeaveType
      // 
      this.cmbLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbLeaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbLeaveType.FormattingEnabled = true;
      this.cmbLeaveType.Location = new System.Drawing.Point(432, 39);
      this.cmbLeaveType.Name = "cmbLeaveType";
      this.cmbLeaveType.Size = new System.Drawing.Size(243, 23);
      this.cmbLeaveType.TabIndex = 2;
      this.cmbLeaveType.SelectedIndexChanged += new System.EventHandler(this.cmbLeaveType_SelectedIndexChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.Color.Transparent;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(359, 44);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(72, 15);
      this.label5.TabIndex = 37;
      this.label5.Text = "Leave Type:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(65, 15);
      this.label2.TabIndex = 36;
      this.label2.Text = "Employee:";
      // 
      // tsButtons
      // 
      this.tsButtons.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tsButtons.ImageScalingSize = new System.Drawing.Size(22, 22);
      this.tsButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnProcess,
            this.toolStripSeparator7,
            this.tbtnAdd,
            this.toolStripSeparator1,
            this.tbtnEdit,
            this.toolStripSeparator2,
            this.tbtnDelete,
            this.toolStripSeparator4,
            this.tbtnRefresh,
            this.toolStripSeparator3,
            this.tbtnActivate,
            this.toolStripSeparator5,
            this.tbtnDeactivate,
            this.toolStripSeparator6,
            this.tbtnClose});
      this.tsButtons.Location = new System.Drawing.Point(0, 0);
      this.tsButtons.Name = "tsButtons";
      this.tsButtons.Size = new System.Drawing.Size(988, 29);
      this.tsButtons.TabIndex = 21;
      this.tsButtons.Text = "OB ToolBar";
      // 
      // tbtnProcess
      // 
      this.tbtnProcess.Image = ((System.Drawing.Image)(resources.GetObject("tbtnProcess.Image")));
      this.tbtnProcess.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtnProcess.Name = "tbtnProcess";
      this.tbtnProcess.Size = new System.Drawing.Size(78, 26);
      this.tbtnProcess.Text = " Process";
      this.tbtnProcess.Click += new System.EventHandler(this.tbtnProcess_Click);
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new System.Drawing.Size(6, 29);
      // 
      // tbtnAdd
      // 
      this.tbtnAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAdd.Image")));
      this.tbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtnAdd.Name = "tbtnAdd";
      this.tbtnAdd.Size = new System.Drawing.Size(59, 26);
      this.tbtnAdd.Text = " Add";
      this.tbtnAdd.ToolTipText = "Add New OB Application";
      this.tbtnAdd.Click += new System.EventHandler(this.tbtnAdd_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
      // 
      // tbtnEdit
      // 
      this.tbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tbtnEdit.Image")));
      this.tbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtnEdit.Name = "tbtnEdit";
      this.tbtnEdit.Size = new System.Drawing.Size(58, 26);
      this.tbtnEdit.Text = " Edit";
      this.tbtnEdit.ToolTipText = "Modify";
      this.tbtnEdit.Click += new System.EventHandler(this.tbtnEdit_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
      // 
      // tbtnDelete
      // 
      this.tbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDelete.Image")));
      this.tbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtnDelete.Name = "tbtnDelete";
      this.tbtnDelete.Size = new System.Drawing.Size(69, 26);
      this.tbtnDelete.Text = "Delete";
      this.tbtnDelete.ToolTipText = "Delete selected record";
      this.tbtnDelete.Click += new System.EventHandler(this.tbtnDelete_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
      // 
      // tbtnRefresh
      // 
      this.tbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tbtnRefresh.Image")));
      this.tbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtnRefresh.Name = "tbtnRefresh";
      this.tbtnRefresh.Size = new System.Drawing.Size(74, 26);
      this.tbtnRefresh.Text = "Refresh";
      this.tbtnRefresh.ToolTipText = "Refresh record list";
      this.tbtnRefresh.Click += new System.EventHandler(this.tbtnRefresh_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
      // 
      // tbtnActivate
      // 
      this.tbtnActivate.Image = ((System.Drawing.Image)(resources.GetObject("tbtnActivate.Image")));
      this.tbtnActivate.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtnActivate.Name = "tbtnActivate";
      this.tbtnActivate.Size = new System.Drawing.Size(78, 26);
      this.tbtnActivate.Text = "Activate";
      this.tbtnActivate.Click += new System.EventHandler(this.tbtnActivate_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
      // 
      // tbtnDeactivate
      // 
      this.tbtnDeactivate.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDeactivate.Image")));
      this.tbtnDeactivate.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtnDeactivate.Name = "tbtnDeactivate";
      this.tbtnDeactivate.Size = new System.Drawing.Size(91, 26);
      this.tbtnDeactivate.Text = "Deactivate";
      this.tbtnDeactivate.Click += new System.EventHandler(this.tbtnDeactivate_Click);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(6, 29);
      // 
      // tbtnClose
      // 
      this.tbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tbtnClose.Image")));
      this.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtnClose.Name = "tbtnClose";
      this.tbtnClose.Size = new System.Drawing.Size(65, 26);
      this.tbtnClose.Text = "Close ";
      this.tbtnClose.ToolTipText = "Close window";
      this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
      // 
      // pnlBody
      // 
      this.pnlBody.Controls.Add(this.dgEntitlementList);
      this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlBody.Location = new System.Drawing.Point(0, 76);
      this.pnlBody.Name = "pnlBody";
      this.pnlBody.Size = new System.Drawing.Size(988, 455);
      this.pnlBody.TabIndex = 3;
      // 
      // dgEntitlementList
      // 
      this.dgEntitlementList.AllowUserToAddRows = false;
      this.dgEntitlementList.AllowUserToDeleteRows = false;
      this.dgEntitlementList.AllowUserToOrderColumns = true;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
      this.dgEntitlementList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgEntitlementList.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgEntitlementList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dgEntitlementList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgEntitlementList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername,
            this.colLeaveTypeCode,
            this.colEmployeeName,
            this.colLeaveType,
            this.colEntitled,
            this.colUsed,
            this.colBalance,
            this.colStatus});
      this.dgEntitlementList.Cursor = System.Windows.Forms.Cursors.Default;
      this.dgEntitlementList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgEntitlementList.Location = new System.Drawing.Point(0, 0);
      this.dgEntitlementList.MultiSelect = false;
      this.dgEntitlementList.Name = "dgEntitlementList";
      this.dgEntitlementList.ReadOnly = true;
      this.dgEntitlementList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dgEntitlementList.RowHeadersWidth = 20;
      this.dgEntitlementList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgEntitlementList.Size = new System.Drawing.Size(988, 455);
      this.dgEntitlementList.TabIndex = 7;
      this.dgEntitlementList.VirtualMode = true;
      this.dgEntitlementList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntitlementList_CellContentClick);
      this.dgEntitlementList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntitlementList_CellDoubleClick);
      // 
      // colUsername
      // 
      this.colUsername.HeaderText = "Username";
      this.colUsername.Name = "colUsername";
      this.colUsername.ReadOnly = true;
      this.colUsername.Visible = false;
      // 
      // colLeaveTypeCode
      // 
      this.colLeaveTypeCode.HeaderText = "LTC";
      this.colLeaveTypeCode.Name = "colLeaveTypeCode";
      this.colLeaveTypeCode.ReadOnly = true;
      this.colLeaveTypeCode.Visible = false;
      // 
      // colEmployeeName
      // 
      dataGridViewCellStyle2.Format = "N2";
      dataGridViewCellStyle2.NullValue = null;
      this.colEmployeeName.DefaultCellStyle = dataGridViewCellStyle2;
      this.colEmployeeName.HeaderText = "Employee";
      this.colEmployeeName.Name = "colEmployeeName";
      this.colEmployeeName.ReadOnly = true;
      this.colEmployeeName.Width = 250;
      // 
      // colLeaveType
      // 
      dataGridViewCellStyle3.Format = "N2";
      dataGridViewCellStyle3.NullValue = null;
      this.colLeaveType.DefaultCellStyle = dataGridViewCellStyle3;
      this.colLeaveType.HeaderText = "Leave Type";
      this.colLeaveType.Name = "colLeaveType";
      this.colLeaveType.ReadOnly = true;
      this.colLeaveType.Width = 200;
      // 
      // colEntitled
      // 
      dataGridViewCellStyle4.Format = "N1";
      dataGridViewCellStyle4.NullValue = null;
      this.colEntitled.DefaultCellStyle = dataGridViewCellStyle4;
      this.colEntitled.HeaderText = "Entitled";
      this.colEntitled.Name = "colEntitled";
      this.colEntitled.ReadOnly = true;
      this.colEntitled.Width = 80;
      // 
      // colUsed
      // 
      dataGridViewCellStyle5.Format = "N1";
      dataGridViewCellStyle5.NullValue = "0";
      this.colUsed.DefaultCellStyle = dataGridViewCellStyle5;
      this.colUsed.HeaderText = "Used";
      this.colUsed.Name = "colUsed";
      this.colUsed.ReadOnly = true;
      this.colUsed.Width = 80;
      // 
      // colBalance
      // 
      dataGridViewCellStyle6.Format = "N1";
      dataGridViewCellStyle6.NullValue = "0";
      this.colBalance.DefaultCellStyle = dataGridViewCellStyle6;
      this.colBalance.HeaderText = "Balance";
      this.colBalance.Name = "colBalance";
      this.colBalance.ReadOnly = true;
      this.colBalance.Width = 80;
      // 
      // colStatus
      // 
      this.colStatus.HeaderText = "Status";
      this.colStatus.Name = "colStatus";
      this.colStatus.ReadOnly = true;
      this.colStatus.Width = 80;
      // 
      // cmsList
      // 
      this.cmsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tmsiEdit,
            this.tsmiDelete,
            this.tsmiRefresh,
            this.toolStripMenuItem1,
            this.tsmiSelectAll});
      this.cmsList.Name = "cmsList";
      this.cmsList.Size = new System.Drawing.Size(150, 120);
      // 
      // tsmiAdd
      // 
      this.tsmiAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAdd.Image")));
      this.tsmiAdd.Name = "tsmiAdd";
      this.tsmiAdd.Size = new System.Drawing.Size(149, 22);
      this.tsmiAdd.Text = "Add Record";
      this.tsmiAdd.Click += new System.EventHandler(this.tbtnAdd_Click);
      // 
      // tmsiEdit
      // 
      this.tmsiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tmsiEdit.Image")));
      this.tmsiEdit.Name = "tmsiEdit";
      this.tmsiEdit.Size = new System.Drawing.Size(149, 22);
      this.tmsiEdit.Text = "Edit Selected";
      this.tmsiEdit.Click += new System.EventHandler(this.tbtnEdit_Click);
      // 
      // tsmiDelete
      // 
      this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
      this.tsmiDelete.Name = "tsmiDelete";
      this.tsmiDelete.Size = new System.Drawing.Size(149, 22);
      this.tsmiDelete.Text = "Delete Selected";
      this.tsmiDelete.Click += new System.EventHandler(this.tbtnDelete_Click);
      // 
      // tsmiRefresh
      // 
      this.tsmiRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRefresh.Image")));
      this.tsmiRefresh.Name = "tsmiRefresh";
      this.tsmiRefresh.Size = new System.Drawing.Size(149, 22);
      this.tsmiRefresh.Text = "Refresh";
      this.tsmiRefresh.Click += new System.EventHandler(this.tbtnRefresh_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
      // 
      // tsmiSelectAll
      // 
      this.tsmiSelectAll.Name = "tsmiSelectAll";
      this.tsmiSelectAll.Size = new System.Drawing.Size(149, 22);
      this.tsmiSelectAll.Text = "Select All";
      // 
      // frmLeaveEntitlementList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(988, 531);
      this.Controls.Add(this.pnlBody);
      this.Controls.Add(this.pnlHeader);
      this.Name = "frmLeaveEntitlementList";
      this.Text = "Leave Entitlement Management";
      this.Load += new System.EventHandler(this.frmLeaveEntitlementList_Load);
      this.pnlHeader.ResumeLayout(false);
      this.pnlHeader.PerformLayout();
      this.tsButtons.ResumeLayout(false);
      this.tsButtons.PerformLayout();
      this.pnlBody.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgEntitlementList)).EndInit();
      this.cmsList.ResumeLayout(false);
      this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel pnlHeader;
  private System.Windows.Forms.ToolStrip tsButtons;
  private System.Windows.Forms.ToolStripButton tbtnAdd;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
  private System.Windows.Forms.ToolStripButton tbtnEdit;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
  private System.Windows.Forms.ToolStripButton tbtnDelete;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
  private System.Windows.Forms.ToolStripButton tbtnRefresh;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
  private System.Windows.Forms.ToolStripButton tbtnClose;
  private System.Windows.Forms.Panel pnlBody;
  private System.Windows.Forms.ComboBox cmbLeaveType;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.ToolStripButton tbtnActivate;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
  private System.Windows.Forms.ToolStripButton tbtnDeactivate;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
  private System.Windows.Forms.ComboBox cmbStatus;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.ContextMenuStrip cmsList;
  private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
  private System.Windows.Forms.ToolStripMenuItem tmsiEdit;
  private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
  private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
  private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
  private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
  private System.Windows.Forms.ToolStripButton tbtnProcess;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
  internal System.Windows.Forms.DataGridView dgEntitlementList;
  private System.Windows.Forms.TextBox txtLastName;
  private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
  private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveTypeCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeName;
  private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveType;
  private System.Windows.Forms.DataGridViewTextBoxColumn colEntitled;
  private System.Windows.Forms.DataGridViewTextBoxColumn colUsed;
  private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
  private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
 }
}