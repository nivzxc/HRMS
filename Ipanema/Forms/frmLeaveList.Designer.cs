namespace Ipanema.Forms
{
 partial class frmLeaveList
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaveList));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.pnlHeader = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label8 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtReason = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtRequestor = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.dtpTo = new System.Windows.Forms.DateTimePicker();
      this.cmbLeaveType = new System.Windows.Forms.ComboBox();
      this.dtpFrom = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.cmbStatus = new System.Windows.Forms.ComboBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.tsButtons = new System.Windows.Forms.ToolStrip();
      this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tbtnEdit = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.tbtnDelete = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.tbtnRefresh = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.tbtnExportExcel = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.tbtnClose = new System.Windows.Forms.ToolStripButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.dgLeaveList = new System.Windows.Forms.DataGridView();
      this.colLeaveCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colRequestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDateFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colApprover = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.coLReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colStatusCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cmsList = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
      this.tmsiEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
      this.ttLeaveReason = new System.Windows.Forms.ToolTip(this.components);
      this.sfdExportExcel = new System.Windows.Forms.SaveFileDialog();
      this.pnlHeader.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tsButtons.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgLeaveList)).BeginInit();
      this.cmsList.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlHeader
      // 
      this.pnlHeader.BackColor = System.Drawing.Color.White;
      this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
      this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pnlHeader.Controls.Add(this.tableLayoutPanel1);
      this.pnlHeader.Controls.Add(this.btnSearch);
      this.pnlHeader.Controls.Add(this.label1);
      this.pnlHeader.Controls.Add(this.tsButtons);
      this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pnlHeader.Location = new System.Drawing.Point(0, 0);
      this.pnlHeader.Name = "pnlHeader";
      this.pnlHeader.Size = new System.Drawing.Size(1028, 160);
      this.pnlHeader.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
      this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
      this.tableLayoutPanel1.Controls.Add(this.label8, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtReason, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.txtRequestor, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.dtpTo, 3, 1);
      this.tableLayoutPanel1.Controls.Add(this.cmbLeaveType, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.dtpFrom, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.cmbStatus, 3, 2);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 56);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 92);
      this.tableLayoutPanel1.TabIndex = 37;
      // 
      // label8
      // 
      this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label8.AutoSize = true;
      this.label8.BackColor = System.Drawing.Color.Transparent;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(331, 38);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(60, 15);
      this.label8.TabIndex = 38;
      this.label8.Text = "Leave To:";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(4, 8);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 15);
      this.label2.TabIndex = 5;
      this.label2.Text = "Requestor:";
      // 
      // txtReason
      // 
      this.txtReason.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.txtReason.Location = new System.Drawing.Point(88, 35);
      this.txtReason.Name = "txtReason";
      this.txtReason.Size = new System.Drawing.Size(230, 21);
      this.txtReason.TabIndex = 1;
      // 
      // label7
      // 
      this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label7.AutoSize = true;
      this.label7.BackColor = System.Drawing.Color.Transparent;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(4, 38);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(53, 15);
      this.label7.TabIndex = 35;
      this.label7.Text = "Reason:";
      // 
      // txtRequestor
      // 
      this.txtRequestor.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.txtRequestor.Location = new System.Drawing.Point(88, 5);
      this.txtRequestor.Name = "txtRequestor";
      this.txtRequestor.Size = new System.Drawing.Size(230, 21);
      this.txtRequestor.TabIndex = 0;
      // 
      // label5
      // 
      this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.Color.Transparent;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(4, 68);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(72, 15);
      this.label5.TabIndex = 12;
      this.label5.Text = "Leave Type:";
      // 
      // dtpTo
      // 
      this.dtpTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.dtpTo.CustomFormat = "MMM dd, yyyy";
      this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpTo.Location = new System.Drawing.Point(416, 35);
      this.dtpTo.Name = "dtpTo";
      this.dtpTo.Size = new System.Drawing.Size(114, 21);
      this.dtpTo.TabIndex = 3;
      // 
      // cmbLeaveType
      // 
      this.cmbLeaveType.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.cmbLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbLeaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbLeaveType.FormattingEnabled = true;
      this.cmbLeaveType.Location = new System.Drawing.Point(88, 64);
      this.cmbLeaveType.Name = "cmbLeaveType";
      this.cmbLeaveType.Size = new System.Drawing.Size(200, 23);
      this.cmbLeaveType.TabIndex = 4;
      // 
      // dtpFrom
      // 
      this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.dtpFrom.CustomFormat = "MMM dd, yyyy";
      this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpFrom.Location = new System.Drawing.Point(416, 5);
      this.dtpFrom.Name = "dtpFrom";
      this.dtpFrom.Size = new System.Drawing.Size(114, 21);
      this.dtpFrom.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(331, 8);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(75, 15);
      this.label3.TabIndex = 7;
      this.label3.Text = "Leave From:";
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label6.AutoSize = true;
      this.label6.BackColor = System.Drawing.Color.Transparent;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(331, 68);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(44, 15);
      this.label6.TabIndex = 17;
      this.label6.Text = "Status:";
      // 
      // cmbStatus
      // 
      this.cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbStatus.FormattingEnabled = true;
      this.cmbStatus.Location = new System.Drawing.Point(416, 64);
      this.cmbStatus.Name = "cmbStatus";
      this.cmbStatus.Size = new System.Drawing.Size(95, 23);
      this.cmbStatus.TabIndex = 5;
      // 
      // btnSearch
      // 
      this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
      this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSearch.Location = new System.Drawing.Point(564, 56);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(78, 32);
      this.btnSearch.TabIndex = 36;
      this.btnSearch.Text = "Search";
      this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(10, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 15);
      this.label1.TabIndex = 21;
      this.label1.Text = "Search";
      // 
      // tsButtons
      // 
      this.tsButtons.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tsButtons.ImageScalingSize = new System.Drawing.Size(22, 22);
      this.tsButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnAdd,
            this.toolStripSeparator1,
            this.tbtnEdit,
            this.toolStripSeparator2,
            this.tbtnDelete,
            this.toolStripSeparator4,
            this.tbtnRefresh,
            this.toolStripSeparator3,
            this.tbtnExportExcel,
            this.toolStripSeparator5,
            this.tbtnClose});
      this.tsButtons.Location = new System.Drawing.Point(0, 0);
      this.tsButtons.Name = "tsButtons";
      this.tsButtons.Size = new System.Drawing.Size(1028, 29);
      this.tsButtons.TabIndex = 20;
      this.tsButtons.Text = "OB ToolBar";
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
      // tbtnExportExcel
      // 
      this.tbtnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("tbtnExportExcel.Image")));
      this.tbtnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtnExportExcel.Name = "tbtnExportExcel";
      this.tbtnExportExcel.Size = new System.Drawing.Size(117, 26);
      this.tbtnExportExcel.Text = "Export to Excel";
      this.tbtnExportExcel.Click += new System.EventHandler(this.tbtnExportExcel_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
      // 
      // tbtnClose
      // 
      this.tbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tbtnClose.Image")));
      this.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtnClose.Name = "tbtnClose";
      this.tbtnClose.Size = new System.Drawing.Size(110, 26);
      this.tbtnClose.Text = "Close Window";
      this.tbtnClose.ToolTipText = "Close window";
      this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.dgLeaveList);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 160);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1028, 440);
      this.panel1.TabIndex = 3;
      // 
      // dgLeaveList
      // 
      this.dgLeaveList.AllowUserToAddRows = false;
      this.dgLeaveList.AllowUserToDeleteRows = false;
      this.dgLeaveList.AllowUserToOrderColumns = true;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
      this.dgLeaveList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgLeaveList.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgLeaveList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgLeaveList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dgLeaveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgLeaveList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLeaveCode,
            this.colStatus,
            this.colRequestor,
            this.colLeaveType,
            this.colDateFile,
            this.colDateStart,
            this.colDateEnd,
            this.colUnit,
            this.colApprover,
            this.coLReason,
            this.colStatusCode});
      this.dgLeaveList.Cursor = System.Windows.Forms.Cursors.Default;
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle7.NullValue = null;
      dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgLeaveList.DefaultCellStyle = dataGridViewCellStyle7;
      this.dgLeaveList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgLeaveList.Location = new System.Drawing.Point(0, 0);
      this.dgLeaveList.MultiSelect = false;
      this.dgLeaveList.Name = "dgLeaveList";
      this.dgLeaveList.ReadOnly = true;
      this.dgLeaveList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dgLeaveList.RowHeadersWidth = 20;
      this.dgLeaveList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgLeaveList.Size = new System.Drawing.Size(1028, 440);
      this.dgLeaveList.TabIndex = 8;
      this.dgLeaveList.VirtualMode = true;
      this.dgLeaveList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLeaveList_CellDoubleClick);
      this.dgLeaveList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgLeaveList_DataBindingComplete);
      // 
      // colLeaveCode
      // 
      this.colLeaveCode.Frozen = true;
      this.colLeaveCode.HeaderText = "Leave Code";
      this.colLeaveCode.Name = "colLeaveCode";
      this.colLeaveCode.ReadOnly = true;
      // 
      // colStatus
      // 
      this.colStatus.Frozen = true;
      this.colStatus.HeaderText = "Status";
      this.colStatus.Name = "colStatus";
      this.colStatus.ReadOnly = true;
      this.colStatus.Width = 80;
      // 
      // colRequestor
      // 
      dataGridViewCellStyle3.Format = "N2";
      dataGridViewCellStyle3.NullValue = null;
      this.colRequestor.DefaultCellStyle = dataGridViewCellStyle3;
      this.colRequestor.Frozen = true;
      this.colRequestor.HeaderText = "Requestor";
      this.colRequestor.Name = "colRequestor";
      this.colRequestor.ReadOnly = true;
      this.colRequestor.Width = 190;
      // 
      // colLeaveType
      // 
      this.colLeaveType.HeaderText = "Leave Type";
      this.colLeaveType.Name = "colLeaveType";
      this.colLeaveType.ReadOnly = true;
      this.colLeaveType.Width = 180;
      // 
      // colDateFile
      // 
      dataGridViewCellStyle4.Format = "MMM dd, yyyy hh:mm tt";
      dataGridViewCellStyle4.NullValue = "-";
      this.colDateFile.DefaultCellStyle = dataGridViewCellStyle4;
      this.colDateFile.HeaderText = "Date File";
      this.colDateFile.Name = "colDateFile";
      this.colDateFile.ReadOnly = true;
      this.colDateFile.Width = 140;
      // 
      // colDateStart
      // 
      dataGridViewCellStyle5.Format = "MMM dd, yyyy hh:mm tt";
      dataGridViewCellStyle5.NullValue = null;
      this.colDateStart.DefaultCellStyle = dataGridViewCellStyle5;
      this.colDateStart.HeaderText = "Date Start";
      this.colDateStart.Name = "colDateStart";
      this.colDateStart.ReadOnly = true;
      this.colDateStart.Width = 140;
      // 
      // colDateEnd
      // 
      dataGridViewCellStyle6.Format = "MMM dd, yyyy hh:mm tt";
      dataGridViewCellStyle6.NullValue = null;
      this.colDateEnd.DefaultCellStyle = dataGridViewCellStyle6;
      this.colDateEnd.HeaderText = "Date End";
      this.colDateEnd.Name = "colDateEnd";
      this.colDateEnd.ReadOnly = true;
      this.colDateEnd.Width = 140;
      // 
      // colUnit
      // 
      this.colUnit.HeaderText = "Unit";
      this.colUnit.Name = "colUnit";
      this.colUnit.ReadOnly = true;
      this.colUnit.Width = 40;
      // 
      // colApprover
      // 
      this.colApprover.HeaderText = "Approver";
      this.colApprover.Name = "colApprover";
      this.colApprover.ReadOnly = true;
      this.colApprover.Width = 190;
      // 
      // coLReason
      // 
      this.coLReason.HeaderText = "Reason";
      this.coLReason.Name = "coLReason";
      this.coLReason.ReadOnly = true;
      this.coLReason.Width = 200;
      // 
      // colStatusCode
      // 
      this.colStatusCode.HeaderText = "Status Code";
      this.colStatusCode.Name = "colStatusCode";
      this.colStatusCode.ReadOnly = true;
      // 
      // cmsList
      // 
      this.cmsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tmsiEdit,
            this.tsmiDelete,
            this.tsmiRefresh});
      this.cmsList.Name = "cmsList";
      this.cmsList.Size = new System.Drawing.Size(155, 92);
      // 
      // tsmiAdd
      // 
      this.tsmiAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAdd.Image")));
      this.tsmiAdd.Name = "tsmiAdd";
      this.tsmiAdd.Size = new System.Drawing.Size(154, 22);
      this.tsmiAdd.Text = "Add Record";
      this.tsmiAdd.Click += new System.EventHandler(this.tbtnAdd_Click);
      // 
      // tmsiEdit
      // 
      this.tmsiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tmsiEdit.Image")));
      this.tmsiEdit.Name = "tmsiEdit";
      this.tmsiEdit.Size = new System.Drawing.Size(154, 22);
      this.tmsiEdit.Text = "Edit Selected";
      this.tmsiEdit.Click += new System.EventHandler(this.tbtnEdit_Click);
      // 
      // tsmiDelete
      // 
      this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
      this.tsmiDelete.Name = "tsmiDelete";
      this.tsmiDelete.Size = new System.Drawing.Size(154, 22);
      this.tsmiDelete.Text = "Delete Selected";
      this.tsmiDelete.Click += new System.EventHandler(this.tbtnDelete_Click);
      // 
      // tsmiRefresh
      // 
      this.tsmiRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRefresh.Image")));
      this.tsmiRefresh.Name = "tsmiRefresh";
      this.tsmiRefresh.Size = new System.Drawing.Size(154, 22);
      this.tsmiRefresh.Text = "Refresh";
      this.tsmiRefresh.Click += new System.EventHandler(this.tbtnRefresh_Click);
      // 
      // ttLeaveReason
      // 
      this.ttLeaveReason.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.ttLeaveReason.ToolTipTitle = "Reason";
      // 
      // sfdExportExcel
      // 
      this.sfdExportExcel.Filter = "Excel Files | *.xls";
      this.sfdExportExcel.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdExportExcel_FileOk);
      // 
      // frmLeaveList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1028, 600);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.pnlHeader);
      this.Name = "frmLeaveList";
      this.Text = "Leave Master List";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Activated += new System.EventHandler(this.frmLeaveList_Activated);
      this.Deactivate += new System.EventHandler(this.frmLeaveList_Deactivate);
      this.Load += new System.EventHandler(this.frmLeaveList_Load);
      this.pnlHeader.ResumeLayout(false);
      this.pnlHeader.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tsButtons.ResumeLayout(false);
      this.tsButtons.PerformLayout();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgLeaveList)).EndInit();
      this.cmsList.ResumeLayout(false);
      this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel pnlHeader;
  private System.Windows.Forms.Panel panel1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.DateTimePicker dtpTo;
  private System.Windows.Forms.DateTimePicker dtpFrom;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.ComboBox cmbLeaveType;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.ComboBox cmbStatus;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.ContextMenuStrip cmsList;
  private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
  private System.Windows.Forms.ToolStripMenuItem tmsiEdit;
  private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
  private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
  private System.Windows.Forms.ToolTip ttLeaveReason;
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
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtRequestor;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.Label label7;
  internal System.Windows.Forms.DataGridView dgLeaveList;
  private System.Windows.Forms.ToolStripButton tbtnExportExcel;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
  private System.Windows.Forms.SaveFileDialog sfdExportExcel;
  private System.Windows.Forms.Button btnSearch;
  private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
  private System.Windows.Forms.DataGridViewTextBoxColumn colRequestor;
  private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveType;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDateFile;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDateStart;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDateEnd;
  private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
  private System.Windows.Forms.DataGridViewTextBoxColumn colApprover;
  private System.Windows.Forms.DataGridViewTextBoxColumn coLReason;
  private System.Windows.Forms.DataGridViewTextBoxColumn colStatusCode;
  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  private System.Windows.Forms.Label label8;
 }
}