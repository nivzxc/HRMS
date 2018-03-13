namespace Ipanema.Forms
{
 partial class frmHolidayList
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHolidayList));
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
   this.pnlBody = new System.Windows.Forms.Panel();
   this.dgHolidayList = new System.Windows.Forms.DataGridView();
   this.colHolidayCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colDateApplied = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colShiftCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.pnlHeader.SuspendLayout();
   this.tsButtons.SuspendLayout();
   this.pnlBody.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgHolidayList)).BeginInit();
   this.SuspendLayout();
   // 
   // pnlHeader
   // 
   this.pnlHeader.Controls.Add(this.tsButtons);
   this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
   this.pnlHeader.Location = new System.Drawing.Point(0, 0);
   this.pnlHeader.Name = "pnlHeader";
   this.pnlHeader.Size = new System.Drawing.Size(995, 30);
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
   this.tsButtons.Size = new System.Drawing.Size(995, 29);
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
   this.pnlBody.Controls.Add(this.dgHolidayList);
   this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlBody.Location = new System.Drawing.Point(0, 30);
   this.pnlBody.Name = "pnlBody";
   this.pnlBody.Size = new System.Drawing.Size(995, 565);
   this.pnlBody.TabIndex = 2;
   // 
   // dgHolidayList
   // 
   this.dgHolidayList.AllowUserToAddRows = false;
   this.dgHolidayList.AllowUserToDeleteRows = false;
   this.dgHolidayList.AllowUserToOrderColumns = true;
   dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
   this.dgHolidayList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
   this.dgHolidayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgHolidayList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgHolidayList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgHolidayList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHolidayCode,
            this.colDateApplied,
            this.colShiftCode,
            this.colRemarks});
   this.dgHolidayList.Cursor = System.Windows.Forms.Cursors.Default;
   this.dgHolidayList.Dock = System.Windows.Forms.DockStyle.Fill;
   this.dgHolidayList.Location = new System.Drawing.Point(0, 0);
   this.dgHolidayList.MultiSelect = false;
   this.dgHolidayList.Name = "dgHolidayList";
   this.dgHolidayList.ReadOnly = true;
   this.dgHolidayList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgHolidayList.RowHeadersWidth = 20;
   this.dgHolidayList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   this.dgHolidayList.Size = new System.Drawing.Size(995, 565);
   this.dgHolidayList.TabIndex = 7;
   this.dgHolidayList.VirtualMode = true;
   this.dgHolidayList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHolidayList_CellDoubleClick);
   // 
   // colHolidayCode
   // 
   this.colHolidayCode.Frozen = true;
   this.colHolidayCode.HeaderText = "Holiday Code";
   this.colHolidayCode.Name = "colHolidayCode";
   this.colHolidayCode.ReadOnly = true;
   // 
   // colDateApplied
   // 
   dataGridViewCellStyle8.Format = "D";
   dataGridViewCellStyle8.NullValue = null;
   this.colDateApplied.DefaultCellStyle = dataGridViewCellStyle8;
   this.colDateApplied.HeaderText = "Date Applied";
   this.colDateApplied.Name = "colDateApplied";
   this.colDateApplied.ReadOnly = true;
   this.colDateApplied.Width = 200;
   // 
   // colShiftCode
   // 
   dataGridViewCellStyle9.Format = "N2";
   dataGridViewCellStyle9.NullValue = null;
   this.colShiftCode.DefaultCellStyle = dataGridViewCellStyle9;
   this.colShiftCode.HeaderText = "Shift Code";
   this.colShiftCode.Name = "colShiftCode";
   this.colShiftCode.ReadOnly = true;
   // 
   // colRemarks
   // 
   this.colRemarks.HeaderText = "Remarks";
   this.colRemarks.Name = "colRemarks";
   this.colRemarks.ReadOnly = true;
   this.colRemarks.Width = 300;
   // 
   // frmHolidayList
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(995, 595);
   this.Controls.Add(this.pnlBody);
   this.Controls.Add(this.pnlHeader);
   this.Name = "frmHolidayList";
   this.Text = "Holiday Master List";
   this.Deactivate += new System.EventHandler(this.frmHolidayList_Deactivate);
   this.Load += new System.EventHandler(this.frmHolidayList_Load);
   this.Activated += new System.EventHandler(this.frmHolidayList_Activated);
   this.pnlHeader.ResumeLayout(false);
   this.pnlHeader.PerformLayout();
   this.tsButtons.ResumeLayout(false);
   this.tsButtons.PerformLayout();
   this.pnlBody.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.dgHolidayList)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel pnlHeader;
  private System.Windows.Forms.Panel pnlBody;
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
  internal System.Windows.Forms.DataGridView dgHolidayList;
  private System.Windows.Forms.DataGridViewTextBoxColumn colHolidayCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDateApplied;
  private System.Windows.Forms.DataGridViewTextBoxColumn colShiftCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
 }
}