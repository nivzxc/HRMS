namespace Ipanema.Forms
{
 partial class frmTimeSheetPeriodList
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeSheetPeriodList));
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
   this.tbtnOpenP = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnCloseP = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnClose = new System.Windows.Forms.ToolStripButton();
   this.pnlBody = new System.Windows.Forms.Panel();
   this.pnlList = new System.Windows.Forms.Panel();
   this.dgTSPList = new System.Windows.Forms.DataGridView();
   this.colTSPCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colDateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colDateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colMaxBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colPostData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
   this.colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
   this.pnlHeader.SuspendLayout();
   this.tsButtons.SuspendLayout();
   this.pnlBody.SuspendLayout();
   this.pnlList.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgTSPList)).BeginInit();
   this.SuspendLayout();
   // 
   // pnlHeader
   // 
   this.pnlHeader.Controls.Add(this.tsButtons);
   this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
   this.pnlHeader.Location = new System.Drawing.Point(0, 0);
   this.pnlHeader.Name = "pnlHeader";
   this.pnlHeader.Size = new System.Drawing.Size(917, 30);
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
            this.tbtnOpenP,
            this.toolStripSeparator5,
            this.tbtnCloseP,
            this.toolStripSeparator6,
            this.tbtnClose});
   this.tsButtons.Location = new System.Drawing.Point(0, 0);
   this.tsButtons.Name = "tsButtons";
   this.tsButtons.Size = new System.Drawing.Size(917, 29);
   this.tsButtons.TabIndex = 23;
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
   this.tbtnEdit.Click += new System.EventHandler(this.tbtnModify_Click);
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
   // tbtnOpenP
   // 
   this.tbtnOpenP.Image = ((System.Drawing.Image)(resources.GetObject("tbtnOpenP.Image")));
   this.tbtnOpenP.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnOpenP.Name = "tbtnOpenP";
   this.tbtnOpenP.Size = new System.Drawing.Size(105, 26);
   this.tbtnOpenP.Text = " Open Period";
   this.tbtnOpenP.Click += new System.EventHandler(this.tbtnOpenP_Click);
   // 
   // toolStripSeparator5
   // 
   this.toolStripSeparator5.Name = "toolStripSeparator5";
   this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
   // 
   // tbtnCloseP
   // 
   this.tbtnCloseP.Image = ((System.Drawing.Image)(resources.GetObject("tbtnCloseP.Image")));
   this.tbtnCloseP.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnCloseP.Name = "tbtnCloseP";
   this.tbtnCloseP.Size = new System.Drawing.Size(103, 26);
   this.tbtnCloseP.Text = " Close Period";
   this.tbtnCloseP.Click += new System.EventHandler(this.tbtnCloseP_Click);
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
   this.tbtnClose.Size = new System.Drawing.Size(110, 26);
   this.tbtnClose.Text = "Close Window";
   this.tbtnClose.ToolTipText = "Close window";
   this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
   // 
   // pnlBody
   // 
   this.pnlBody.Controls.Add(this.pnlList);
   this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlBody.Location = new System.Drawing.Point(0, 30);
   this.pnlBody.Name = "pnlBody";
   this.pnlBody.Size = new System.Drawing.Size(917, 508);
   this.pnlBody.TabIndex = 1;
   // 
   // pnlList
   // 
   this.pnlList.Controls.Add(this.dgTSPList);
   this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlList.Location = new System.Drawing.Point(0, 0);
   this.pnlList.Name = "pnlList";
   this.pnlList.Size = new System.Drawing.Size(917, 508);
   this.pnlList.TabIndex = 1;
   // 
   // dgTSPList
   // 
   this.dgTSPList.AllowUserToAddRows = false;
   this.dgTSPList.AllowUserToDeleteRows = false;
   this.dgTSPList.AllowUserToOrderColumns = true;
   dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
   this.dgTSPList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
   this.dgTSPList.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgTSPList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgTSPList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgTSPList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTSPCode,
            this.colDateFrom,
            this.colDateTo,
            this.colDescription,
            this.colMaxBalance,
            this.colPostData,
            this.colStatus});
   this.dgTSPList.Cursor = System.Windows.Forms.Cursors.Default;
   this.dgTSPList.Dock = System.Windows.Forms.DockStyle.Fill;
   this.dgTSPList.Location = new System.Drawing.Point(0, 0);
   this.dgTSPList.MultiSelect = false;
   this.dgTSPList.Name = "dgTSPList";
   this.dgTSPList.ReadOnly = true;
   this.dgTSPList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgTSPList.RowHeadersWidth = 20;
   this.dgTSPList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   this.dgTSPList.Size = new System.Drawing.Size(917, 508);
   this.dgTSPList.TabIndex = 7;
   this.dgTSPList.VirtualMode = true;
   this.dgTSPList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTSPList_CellDoubleClick);
   // 
   // colTSPCode
   // 
   this.colTSPCode.Frozen = true;
   this.colTSPCode.HeaderText = "Code";
   this.colTSPCode.Name = "colTSPCode";
   this.colTSPCode.ReadOnly = true;
   // 
   // colDateFrom
   // 
   dataGridViewCellStyle2.Format = "MMM dd, yyyy";
   dataGridViewCellStyle2.NullValue = null;
   this.colDateFrom.DefaultCellStyle = dataGridViewCellStyle2;
   this.colDateFrom.FillWeight = 150F;
   this.colDateFrom.HeaderText = "Date From";
   this.colDateFrom.Name = "colDateFrom";
   this.colDateFrom.ReadOnly = true;
   this.colDateFrom.Width = 150;
   // 
   // colDateTo
   // 
   dataGridViewCellStyle3.Format = "MMM dd, yyyy";
   dataGridViewCellStyle3.NullValue = null;
   this.colDateTo.DefaultCellStyle = dataGridViewCellStyle3;
   this.colDateTo.HeaderText = "Date To";
   this.colDateTo.Name = "colDateTo";
   this.colDateTo.ReadOnly = true;
   this.colDateTo.Width = 150;
   // 
   // colDescription
   // 
   this.colDescription.HeaderText = "Description";
   this.colDescription.Name = "colDescription";
   this.colDescription.ReadOnly = true;
   this.colDescription.Width = 250;
   // 
   // colMaxBalance
   // 
   this.colMaxBalance.HeaderText = "Mode";
   this.colMaxBalance.Name = "colMaxBalance";
   this.colMaxBalance.ReadOnly = true;
   this.colMaxBalance.Width = 60;
   // 
   // colPostData
   // 
   this.colPostData.HeaderText = "Posted";
   this.colPostData.Name = "colPostData";
   this.colPostData.ReadOnly = true;
   this.colPostData.Resizable = System.Windows.Forms.DataGridViewTriState.True;
   this.colPostData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
   this.colPostData.Width = 70;
   // 
   // colStatus
   // 
   this.colStatus.HeaderText = "Open";
   this.colStatus.Name = "colStatus";
   this.colStatus.ReadOnly = true;
   this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
   this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
   this.colStatus.Width = 70;
   // 
   // frmTimeSheetPeriodList
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(917, 538);
   this.Controls.Add(this.pnlBody);
   this.Controls.Add(this.pnlHeader);
   this.Name = "frmTimeSheetPeriodList";
   this.Text = "Time Sheet Period Master List";
   this.Deactivate += new System.EventHandler(this.frmTimeSheetPeriodList_Deactivate);
   this.Load += new System.EventHandler(this.frmTimeSheetPeriodList_Load);
   this.Activated += new System.EventHandler(this.frmTimeSheetPeriodList_Activated);
   this.pnlHeader.ResumeLayout(false);
   this.pnlHeader.PerformLayout();
   this.tsButtons.ResumeLayout(false);
   this.tsButtons.PerformLayout();
   this.pnlBody.ResumeLayout(false);
   this.pnlList.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.dgTSPList)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel pnlHeader;
  private System.Windows.Forms.Panel pnlBody;
  private System.Windows.Forms.Panel pnlList;
  private System.Windows.Forms.ToolStrip tsButtons;
  private System.Windows.Forms.ToolStripButton tbtnAdd;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
  private System.Windows.Forms.ToolStripButton tbtnEdit;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
  private System.Windows.Forms.ToolStripButton tbtnDelete;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
  private System.Windows.Forms.ToolStripButton tbtnRefresh;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
  private System.Windows.Forms.ToolStripButton tbtnOpenP;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
  private System.Windows.Forms.ToolStripButton tbtnCloseP;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
  private System.Windows.Forms.ToolStripButton tbtnClose;
  internal System.Windows.Forms.DataGridView dgTSPList;
  private System.Windows.Forms.DataGridViewTextBoxColumn colTSPCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDateFrom;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDateTo;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
  private System.Windows.Forms.DataGridViewTextBoxColumn colMaxBalance;
  private System.Windows.Forms.DataGridViewCheckBoxColumn colPostData;
  private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
 }
}