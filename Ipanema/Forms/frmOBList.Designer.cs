namespace Ipanema.Forms
{
 partial class frmOBList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOBList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRequestor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOBType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tsButtons = new System.Windows.Forms.ToolStrip();
            this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnClose = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgOBList = new System.Windows.Forms.DataGridView();
            this.colOBCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatusCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOBType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenderedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coLReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRApprover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeadApprover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ttReason = new System.Windows.Forms.ToolTip(this.components);
            this.iml16 = new System.Windows.Forms.ImageList(this.components);
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tsButtons.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOBList)).BeginInit();
            this.cmsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSearch.BackgroundImage")));
            this.pnlSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSearch.Controls.Add(this.txtReason);
            this.pnlSearch.Controls.Add(this.label7);
            this.pnlSearch.Controls.Add(this.txtRequestor);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.pictureBox2);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Controls.Add(this.dtpFrom);
            this.pnlSearch.Controls.Add(this.cmbStatus);
            this.pnlSearch.Controls.Add(this.label6);
            this.pnlSearch.Controls.Add(this.cmbOBType);
            this.pnlSearch.Controls.Add(this.label5);
            this.pnlSearch.Controls.Add(this.dtpTo);
            this.pnlSearch.Controls.Add(this.label4);
            this.pnlSearch.Controls.Add(this.label3);
            this.pnlSearch.Controls.Add(this.tsButtons);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1354, 118);
            this.pnlSearch.TabIndex = 0;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(160, 82);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(230, 21);
            this.txtReason.TabIndex = 1;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Reason:";
            // 
            // txtRequestor
            // 
            this.txtRequestor.Location = new System.Drawing.Point(160, 55);
            this.txtRequestor.Name = "txtRequestor";
            this.txtRequestor.Size = new System.Drawing.Size(230, 21);
            this.txtRequestor.TabIndex = 0;
            this.txtRequestor.TextChanged += new System.EventHandler(this.txtRequestor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Requestor:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 64);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Search";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "MMM dd, yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(463, 56);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(92, 20);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(726, 82);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(116, 21);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(684, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Status:";
            // 
            // cmbOBType
            // 
            this.cmbOBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOBType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOBType.FormattingEnabled = true;
            this.cmbOBType.Location = new System.Drawing.Point(464, 82);
            this.cmbOBType.Name = "cmbOBType";
            this.cmbOBType.Size = new System.Drawing.Size(208, 21);
            this.cmbOBType.TabIndex = 4;
            this.cmbOBType.SelectedIndexChanged += new System.EventHandler(this.cmbOBType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "OB Type:";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "MMM dd, yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(578, 56);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(92, 20);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(556, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "OB From:";
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
            this.tbtnClose});
            this.tsButtons.Location = new System.Drawing.Point(0, 0);
            this.tsButtons.Name = "tsButtons";
            this.tsButtons.Size = new System.Drawing.Size(1354, 29);
            this.tsButtons.TabIndex = 19;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.dgOBList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1354, 445);
            this.panel3.TabIndex = 2;
            // 
            // dgOBList
            // 
            this.dgOBList.AllowUserToAddRows = false;
            this.dgOBList.AllowUserToDeleteRows = false;
            this.dgOBList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgOBList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOBList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOBList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgOBList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOBList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOBCode,
            this.colStatusCode,
            this.colStatus,
            this.colRequestor,
            this.colOBType,
            this.colDateFile,
            this.colDateStart,
            this.colDateEnd,
            this.colRenderedTo,
            this.coLReason,
            this.colRApprover,
            this.colHeadApprover});
            this.dgOBList.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOBList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgOBList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOBList.Location = new System.Drawing.Point(0, 0);
            this.dgOBList.MultiSelect = false;
            this.dgOBList.Name = "dgOBList";
            this.dgOBList.ReadOnly = true;
            this.dgOBList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgOBList.RowHeadersWidth = 20;
            this.dgOBList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOBList.Size = new System.Drawing.Size(1354, 445);
            this.dgOBList.TabIndex = 9;
            this.dgOBList.TabStop = false;
            this.dgOBList.VirtualMode = true;
            this.dgOBList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOBList_CellContentClick);
            this.dgOBList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOBList_CellDoubleClick);
            this.dgOBList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgOBList_DataBindingComplete);
            // 
            // colOBCode
            // 
            this.colOBCode.Frozen = true;
            this.colOBCode.HeaderText = "OB Code";
            this.colOBCode.Name = "colOBCode";
            this.colOBCode.ReadOnly = true;
            this.colOBCode.Width = 90;
            // 
            // colStatusCode
            // 
            this.colStatusCode.Frozen = true;
            this.colStatusCode.HeaderText = "Status Code";
            this.colStatusCode.Name = "colStatusCode";
            this.colStatusCode.ReadOnly = true;
            this.colStatusCode.Visible = false;
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
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colRequestor.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRequestor.Frozen = true;
            this.colRequestor.HeaderText = "Requestor";
            this.colRequestor.Name = "colRequestor";
            this.colRequestor.ReadOnly = true;
            this.colRequestor.Width = 190;
            // 
            // colOBType
            // 
            this.colOBType.HeaderText = "Type";
            this.colOBType.Name = "colOBType";
            this.colOBType.ReadOnly = true;
            this.colOBType.Width = 180;
            // 
            // colDateFile
            // 
            dataGridViewCellStyle3.Format = "MMM dd, yyyy hh:mm tt";
            dataGridViewCellStyle3.NullValue = "-";
            this.colDateFile.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDateFile.HeaderText = "Date File";
            this.colDateFile.Name = "colDateFile";
            this.colDateFile.ReadOnly = true;
            this.colDateFile.Width = 140;
            // 
            // colDateStart
            // 
            dataGridViewCellStyle4.Format = "MMM dd, yyyy hh:mm tt";
            dataGridViewCellStyle4.NullValue = null;
            this.colDateStart.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDateStart.HeaderText = "Date Start";
            this.colDateStart.Name = "colDateStart";
            this.colDateStart.ReadOnly = true;
            this.colDateStart.Width = 140;
            // 
            // colDateEnd
            // 
            dataGridViewCellStyle5.Format = "MMM dd, yyyy hh:mm tt";
            dataGridViewCellStyle5.NullValue = null;
            this.colDateEnd.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDateEnd.HeaderText = "Date End";
            this.colDateEnd.Name = "colDateEnd";
            this.colDateEnd.ReadOnly = true;
            this.colDateEnd.Width = 140;
            // 
            // colRenderedTo
            // 
            this.colRenderedTo.HeaderText = "Rendered To";
            this.colRenderedTo.Name = "colRenderedTo";
            this.colRenderedTo.ReadOnly = true;
            this.colRenderedTo.Width = 200;
            // 
            // coLReason
            // 
            this.coLReason.HeaderText = "Reason";
            this.coLReason.Name = "coLReason";
            this.coLReason.ReadOnly = true;
            this.coLReason.Width = 200;
            // 
            // colRApprover
            // 
            this.colRApprover.HeaderText = "Request Approver";
            this.colRApprover.Name = "colRApprover";
            this.colRApprover.ReadOnly = true;
            this.colRApprover.Width = 150;
            // 
            // colHeadApprover
            // 
            this.colHeadApprover.HeaderText = "Head Approver";
            this.colHeadApprover.Name = "colHeadApprover";
            this.colHeadApprover.ReadOnly = true;
            this.colHeadApprover.Width = 150;
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
            // ttReason
            // 
            this.ttReason.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttReason.ToolTipTitle = "Reason:";
            // 
            // iml16
            // 
            this.iml16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iml16.ImageStream")));
            this.iml16.TransparentColor = System.Drawing.Color.Transparent;
            this.iml16.Images.SetKeyName(0, "personal16.png");
            // 
            // frmOBList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 563);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlSearch);
            this.Name = "frmOBList";
            this.Text = "Official Business Master List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmOBList_Activated);
            this.Deactivate += new System.EventHandler(this.frmOBList_Deactivate);
            this.Load += new System.EventHandler(this.frmOBList_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tsButtons.ResumeLayout(false);
            this.tsButtons.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOBList)).EndInit();
            this.cmsList.ResumeLayout(false);
            this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel pnlSearch;
  private System.Windows.Forms.Panel panel3;
  private System.Windows.Forms.ComboBox cmbStatus;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.ComboBox cmbOBType;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.DateTimePicker dtpTo;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.DateTimePicker dtpFrom;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.ToolStrip tsButtons;
  private System.Windows.Forms.ToolStripButton tbtnEdit;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
  private System.Windows.Forms.ToolStripButton tbtnRefresh;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
  private System.Windows.Forms.ToolStripButton tbtnClose;
  private System.Windows.Forms.ToolStripButton tbtnAdd;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
  private System.Windows.Forms.ToolStripButton tbtnDelete;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
  private System.Windows.Forms.ContextMenuStrip cmsList;
  private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
  private System.Windows.Forms.ToolStripMenuItem tmsiEdit;
  private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
  private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
  private System.Windows.Forms.ToolTip ttReason;
  private System.Windows.Forms.ImageList iml16;
  private System.Windows.Forms.PictureBox pictureBox2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtRequestor;
  private System.Windows.Forms.Label label2;
  internal System.Windows.Forms.DataGridView dgOBList;
  private System.Windows.Forms.DataGridViewTextBoxColumn colOBCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colStatusCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
  private System.Windows.Forms.DataGridViewTextBoxColumn colRequestor;
  private System.Windows.Forms.DataGridViewTextBoxColumn colOBType;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDateFile;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDateStart;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDateEnd;
  private System.Windows.Forms.DataGridViewTextBoxColumn colRenderedTo;
  private System.Windows.Forms.DataGridViewTextBoxColumn coLReason;
  private System.Windows.Forms.DataGridViewTextBoxColumn colRApprover;
  private System.Windows.Forms.DataGridViewTextBoxColumn colHeadApprover;
 }
}