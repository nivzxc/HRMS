namespace Ipanema.Forms
{
 partial class frmOvertimeList
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOvertimeList));
   this.pnlHeader = new System.Windows.Forms.Panel();
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
   this.pnlFilter = new System.Windows.Forms.Panel();
   this.cmbStatus = new System.Windows.Forms.ComboBox();
   this.label6 = new System.Windows.Forms.Label();
   this.cmbChargeType = new System.Windows.Forms.ComboBox();
   this.label5 = new System.Windows.Forms.Label();
   this.dtpTo = new System.Windows.Forms.DateTimePicker();
   this.label4 = new System.Windows.Forms.Label();
   this.dtpFrom = new System.Windows.Forms.DateTimePicker();
   this.label3 = new System.Windows.Forms.Label();
   this.cmbRequestor = new System.Windows.Forms.ComboBox();
   this.label2 = new System.Windows.Forms.Label();
   this.pnlBottom = new System.Windows.Forms.Panel();
   this.pnlBody = new System.Windows.Forms.Panel();
   this.lvOvertimeList = new System.Windows.Forms.ListView();
   this.chOvertimeCode = new System.Windows.Forms.ColumnHeader();
   this.chRequestor = new System.Windows.Forms.ColumnHeader();
   this.chChargeType = new System.Windows.Forms.ColumnHeader();
   this.chChargeTo = new System.Windows.Forms.ColumnHeader();
   this.chDateFile = new System.Windows.Forms.ColumnHeader();
   this.chDateStart = new System.Windows.Forms.ColumnHeader();
   this.chDateEnd = new System.Windows.Forms.ColumnHeader();
   this.chStatus = new System.Windows.Forms.ColumnHeader();
   this.cmsList = new System.Windows.Forms.ContextMenuStrip(this.components);
   this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
   this.tmsiEdit = new System.Windows.Forms.ToolStripMenuItem();
   this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
   this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
   this.ttReason = new System.Windows.Forms.ToolTip(this.components);
   this.pnlHeader.SuspendLayout();
   this.tsButtons.SuspendLayout();
   this.pnlFilter.SuspendLayout();
   this.pnlBody.SuspendLayout();
   this.cmsList.SuspendLayout();
   this.SuspendLayout();
   // 
   // pnlHeader
   // 
   this.pnlHeader.Controls.Add(this.tsButtons);
   this.pnlHeader.Controls.Add(this.pnlFilter);
   this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
   this.pnlHeader.Location = new System.Drawing.Point(0, 0);
   this.pnlHeader.Name = "pnlHeader";
   this.pnlHeader.Size = new System.Drawing.Size(1187, 68);
   this.pnlHeader.TabIndex = 0;
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
   this.tsButtons.Size = new System.Drawing.Size(1187, 29);
   this.tsButtons.TabIndex = 45;
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
   // pnlFilter
   // 
   this.pnlFilter.BackColor = System.Drawing.Color.White;
   this.pnlFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFilter.BackgroundImage")));
   this.pnlFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
   this.pnlFilter.Controls.Add(this.cmbStatus);
   this.pnlFilter.Controls.Add(this.label6);
   this.pnlFilter.Controls.Add(this.cmbChargeType);
   this.pnlFilter.Controls.Add(this.label5);
   this.pnlFilter.Controls.Add(this.dtpTo);
   this.pnlFilter.Controls.Add(this.label4);
   this.pnlFilter.Controls.Add(this.dtpFrom);
   this.pnlFilter.Controls.Add(this.label3);
   this.pnlFilter.Controls.Add(this.cmbRequestor);
   this.pnlFilter.Controls.Add(this.label2);
   this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.pnlFilter.Location = new System.Drawing.Point(0, 0);
   this.pnlFilter.Name = "pnlFilter";
   this.pnlFilter.Size = new System.Drawing.Size(1187, 68);
   this.pnlFilter.TabIndex = 21;
   // 
   // cmbStatus
   // 
   this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbStatus.FormattingEnabled = true;
   this.cmbStatus.Location = new System.Drawing.Point(968, 37);
   this.cmbStatus.Name = "cmbStatus";
   this.cmbStatus.Size = new System.Drawing.Size(110, 23);
   this.cmbStatus.TabIndex = 43;
   this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.BackColor = System.Drawing.Color.Transparent;
   this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label6.Location = new System.Drawing.Point(925, 41);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(44, 15);
   this.label6.TabIndex = 42;
   this.label6.Text = "Status:";
   // 
   // cmbChargeType
   // 
   this.cmbChargeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbChargeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbChargeType.FormattingEnabled = true;
   this.cmbChargeType.Location = new System.Drawing.Point(399, 37);
   this.cmbChargeType.Name = "cmbChargeType";
   this.cmbChargeType.Size = new System.Drawing.Size(223, 23);
   this.cmbChargeType.TabIndex = 41;
   this.cmbChargeType.SelectedIndexChanged += new System.EventHandler(this.cmbChargeType_SelectedIndexChanged);
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.BackColor = System.Drawing.Color.Transparent;
   this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label5.Location = new System.Drawing.Point(316, 41);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(79, 15);
   this.label5.TabIndex = 40;
   this.label5.Text = "Charge Type:";
   // 
   // dtpTo
   // 
   this.dtpTo.CustomFormat = "MMM dd, yyyy";
   this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpTo.Location = new System.Drawing.Point(815, 37);
   this.dtpTo.Name = "dtpTo";
   this.dtpTo.Size = new System.Drawing.Size(102, 21);
   this.dtpTo.TabIndex = 38;
   this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.BackColor = System.Drawing.Color.Transparent;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(792, 41);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(21, 15);
   this.label4.TabIndex = 37;
   this.label4.Text = "To";
   // 
   // dtpFrom
   // 
   this.dtpFrom.CustomFormat = "MMM dd, yyyy";
   this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFrom.Location = new System.Drawing.Point(688, 37);
   this.dtpFrom.Name = "dtpFrom";
   this.dtpFrom.Size = new System.Drawing.Size(101, 21);
   this.dtpFrom.TabIndex = 36;
   this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.BackColor = System.Drawing.Color.Transparent;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(626, 41);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(58, 15);
   this.label3.TabIndex = 35;
   this.label3.Text = "OT From:";
   // 
   // cmbRequestor
   // 
   this.cmbRequestor.DropDownHeight = 250;
   this.cmbRequestor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbRequestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbRequestor.FormattingEnabled = true;
   this.cmbRequestor.IntegralHeight = false;
   this.cmbRequestor.ItemHeight = 15;
   this.cmbRequestor.Location = new System.Drawing.Point(81, 37);
   this.cmbRequestor.Name = "cmbRequestor";
   this.cmbRequestor.Size = new System.Drawing.Size(227, 23);
   this.cmbRequestor.TabIndex = 34;
   this.cmbRequestor.SelectedIndexChanged += new System.EventHandler(this.cmbRequestor_SelectedIndexChanged);
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.BackColor = System.Drawing.Color.Transparent;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(11, 41);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(67, 15);
   this.label2.TabIndex = 33;
   this.label2.Text = "Requestor:";
   // 
   // pnlBottom
   // 
   this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
   this.pnlBottom.Location = new System.Drawing.Point(0, 521);
   this.pnlBottom.Name = "pnlBottom";
   this.pnlBottom.Size = new System.Drawing.Size(1187, 32);
   this.pnlBottom.TabIndex = 1;
   // 
   // pnlBody
   // 
   this.pnlBody.Controls.Add(this.lvOvertimeList);
   this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlBody.Location = new System.Drawing.Point(0, 68);
   this.pnlBody.Name = "pnlBody";
   this.pnlBody.Size = new System.Drawing.Size(1187, 453);
   this.pnlBody.TabIndex = 2;
   // 
   // lvOvertimeList
   // 
   this.lvOvertimeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOvertimeCode,
            this.chRequestor,
            this.chChargeType,
            this.chChargeTo,
            this.chDateFile,
            this.chDateStart,
            this.chDateEnd,
            this.chStatus});
   this.lvOvertimeList.ContextMenuStrip = this.cmsList;
   this.lvOvertimeList.Dock = System.Windows.Forms.DockStyle.Fill;
   this.lvOvertimeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lvOvertimeList.FullRowSelect = true;
   this.lvOvertimeList.GridLines = true;
   this.lvOvertimeList.HideSelection = false;
   this.lvOvertimeList.Location = new System.Drawing.Point(0, 0);
   this.lvOvertimeList.MultiSelect = false;
   this.lvOvertimeList.Name = "lvOvertimeList";
   this.lvOvertimeList.Size = new System.Drawing.Size(1187, 453);
   this.lvOvertimeList.TabIndex = 3;
   this.lvOvertimeList.UseCompatibleStateImageBehavior = false;
   this.lvOvertimeList.View = System.Windows.Forms.View.Details;
   this.lvOvertimeList.DoubleClick += new System.EventHandler(this.tbtnEdit_Click);
   this.lvOvertimeList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvOvertimeList_ColumnClick);
   this.lvOvertimeList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvOvertimeList_MouseMove);
   // 
   // chOvertimeCode
   // 
   this.chOvertimeCode.Text = "OT Code";
   this.chOvertimeCode.Width = 80;
   // 
   // chRequestor
   // 
   this.chRequestor.Text = "Requestor";
   this.chRequestor.Width = 150;
   // 
   // chChargeType
   // 
   this.chChargeType.Text = "Charge Type";
   this.chChargeType.Width = 170;
   // 
   // chChargeTo
   // 
   this.chChargeTo.Text = "Charge To";
   this.chChargeTo.Width = 250;
   // 
   // chDateFile
   // 
   this.chDateFile.Text = "Date Filed";
   this.chDateFile.Width = 90;
   // 
   // chDateStart
   // 
   this.chDateStart.Text = "Date Start";
   this.chDateStart.Width = 150;
   // 
   // chDateEnd
   // 
   this.chDateEnd.Text = "Date End";
   this.chDateEnd.Width = 150;
   // 
   // chStatus
   // 
   this.chStatus.Text = "Status";
   this.chStatus.Width = 80;
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
   // frmOvertimeList
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(1187, 553);
   this.Controls.Add(this.pnlBody);
   this.Controls.Add(this.pnlBottom);
   this.Controls.Add(this.pnlHeader);
   this.Name = "frmOvertimeList";
   this.Text = "List of Overtime Applications";
   this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
   this.Load += new System.EventHandler(this.frmOvertimeList_Load);
   this.pnlHeader.ResumeLayout(false);
   this.pnlHeader.PerformLayout();
   this.tsButtons.ResumeLayout(false);
   this.tsButtons.PerformLayout();
   this.pnlFilter.ResumeLayout(false);
   this.pnlFilter.PerformLayout();
   this.pnlBody.ResumeLayout(false);
   this.cmsList.ResumeLayout(false);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel pnlHeader;
  private System.Windows.Forms.Panel pnlBottom;
  private System.Windows.Forms.Panel pnlBody;
  private System.Windows.Forms.Panel pnlFilter;
  private System.Windows.Forms.ComboBox cmbStatus;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.ComboBox cmbChargeType;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.DateTimePicker dtpTo;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.DateTimePicker dtpFrom;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.ComboBox cmbRequestor;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.ListView lvOvertimeList;
  private System.Windows.Forms.ColumnHeader chOvertimeCode;
  private System.Windows.Forms.ColumnHeader chChargeType;
  private System.Windows.Forms.ColumnHeader chRequestor;
  private System.Windows.Forms.ColumnHeader chDateFile;
  private System.Windows.Forms.ColumnHeader chDateStart;
  private System.Windows.Forms.ColumnHeader chDateEnd;
  private System.Windows.Forms.ColumnHeader chStatus;
  private System.Windows.Forms.ColumnHeader chChargeTo;
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
  private System.Windows.Forms.ToolTip ttReason;
  private System.Windows.Forms.ContextMenuStrip cmsList;
  private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
  private System.Windows.Forms.ToolStripMenuItem tmsiEdit;
  private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
  private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
 }
}