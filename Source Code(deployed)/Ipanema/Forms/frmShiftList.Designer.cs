namespace Ipanema.Forms
{
 partial class frmShiftList
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShiftList));
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
   this.pnlTop = new System.Windows.Forms.Panel();
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
   this.dgShiftList = new System.Windows.Forms.DataGridView();
   this.ttRemarks = new System.Windows.Forms.ToolTip(this.components);
   this.colShiftCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colShiftMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colTotalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colTimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colTimeHalf = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colTimeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colBreakStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colBreakEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.pnlTop.SuspendLayout();
   this.tsButtons.SuspendLayout();
   this.pnlBody.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgShiftList)).BeginInit();
   this.SuspendLayout();
   // 
   // pnlTop
   // 
   this.pnlTop.BackColor = System.Drawing.Color.White;
   this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
   this.pnlTop.Controls.Add(this.tsButtons);
   this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
   this.pnlTop.Location = new System.Drawing.Point(0, 0);
   this.pnlTop.Name = "pnlTop";
   this.pnlTop.Size = new System.Drawing.Size(907, 30);
   this.pnlTop.TabIndex = 1;
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
   this.tsButtons.Size = new System.Drawing.Size(907, 29);
   this.tsButtons.TabIndex = 21;
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
   this.tbtnEdit.Size = new System.Drawing.Size(68, 26);
   this.tbtnEdit.Text = "Modify";
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
   this.tbtnRefresh.Click += new System.EventHandler(this.tbtnDelete_Click);
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
   this.pnlBody.Controls.Add(this.dgShiftList);
   this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlBody.Location = new System.Drawing.Point(0, 30);
   this.pnlBody.Name = "pnlBody";
   this.pnlBody.Size = new System.Drawing.Size(907, 476);
   this.pnlBody.TabIndex = 3;
   // 
   // dgShiftList
   // 
   this.dgShiftList.AllowUserToAddRows = false;
   this.dgShiftList.AllowUserToDeleteRows = false;
   this.dgShiftList.AllowUserToOrderColumns = true;
   dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
   this.dgShiftList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
   this.dgShiftList.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgShiftList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgShiftList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgShiftList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShiftCode,
            this.colShiftMode,
            this.colTotalHours,
            this.colTimeStart,
            this.colTimeHalf,
            this.colTimeEnd,
            this.colBreakStart,
            this.colBreakEnd});
   this.dgShiftList.Cursor = System.Windows.Forms.Cursors.Default;
   dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
   dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
   dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
   dataGridViewCellStyle10.NullValue = null;
   dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
   dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
   dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
   this.dgShiftList.DefaultCellStyle = dataGridViewCellStyle10;
   this.dgShiftList.Dock = System.Windows.Forms.DockStyle.Fill;
   this.dgShiftList.Location = new System.Drawing.Point(0, 0);
   this.dgShiftList.MultiSelect = false;
   this.dgShiftList.Name = "dgShiftList";
   this.dgShiftList.ReadOnly = true;
   this.dgShiftList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgShiftList.RowHeadersWidth = 20;
   this.dgShiftList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   this.dgShiftList.Size = new System.Drawing.Size(907, 476);
   this.dgShiftList.TabIndex = 7;
   this.dgShiftList.VirtualMode = true;
   this.dgShiftList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShiftList_CellDoubleClick);
   // 
   // ttRemarks
   // 
   this.ttRemarks.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
   this.ttRemarks.ToolTipTitle = "Remarks";
   // 
   // colShiftCode
   // 
   dataGridViewCellStyle2.NullValue = null;
   this.colShiftCode.DefaultCellStyle = dataGridViewCellStyle2;
   this.colShiftCode.Frozen = true;
   this.colShiftCode.HeaderText = "Code";
   this.colShiftCode.Name = "colShiftCode";
   this.colShiftCode.ReadOnly = true;
   // 
   // colShiftMode
   // 
   dataGridViewCellStyle3.Format = "N2";
   dataGridViewCellStyle3.NullValue = null;
   this.colShiftMode.DefaultCellStyle = dataGridViewCellStyle3;
   this.colShiftMode.HeaderText = "Shift Mode";
   this.colShiftMode.Name = "colShiftMode";
   this.colShiftMode.ReadOnly = true;
   this.colShiftMode.Width = 150;
   // 
   // colTotalHours
   // 
   dataGridViewCellStyle4.Format = "N2";
   dataGridViewCellStyle4.NullValue = null;
   this.colTotalHours.DefaultCellStyle = dataGridViewCellStyle4;
   this.colTotalHours.HeaderText = "Total Hours";
   this.colTotalHours.Name = "colTotalHours";
   this.colTotalHours.ReadOnly = true;
   // 
   // colTimeStart
   // 
   dataGridViewCellStyle5.Format = "hh:mm tt";
   dataGridViewCellStyle5.NullValue = null;
   this.colTimeStart.DefaultCellStyle = dataGridViewCellStyle5;
   this.colTimeStart.HeaderText = "Time Start";
   this.colTimeStart.Name = "colTimeStart";
   this.colTimeStart.ReadOnly = true;
   // 
   // colTimeHalf
   // 
   dataGridViewCellStyle6.Format = "hh:mm tt";
   dataGridViewCellStyle6.NullValue = null;
   this.colTimeHalf.DefaultCellStyle = dataGridViewCellStyle6;
   this.colTimeHalf.HeaderText = "Time Half";
   this.colTimeHalf.Name = "colTimeHalf";
   this.colTimeHalf.ReadOnly = true;
   // 
   // colTimeEnd
   // 
   dataGridViewCellStyle7.Format = "hh:mm tt";
   dataGridViewCellStyle7.NullValue = null;
   this.colTimeEnd.DefaultCellStyle = dataGridViewCellStyle7;
   this.colTimeEnd.HeaderText = "Time End";
   this.colTimeEnd.Name = "colTimeEnd";
   this.colTimeEnd.ReadOnly = true;
   // 
   // colBreakStart
   // 
   dataGridViewCellStyle8.Format = "hh:mm tt";
   dataGridViewCellStyle8.NullValue = null;
   this.colBreakStart.DefaultCellStyle = dataGridViewCellStyle8;
   this.colBreakStart.HeaderText = "Break Start";
   this.colBreakStart.Name = "colBreakStart";
   this.colBreakStart.ReadOnly = true;
   // 
   // colBreakEnd
   // 
   dataGridViewCellStyle9.Format = "hh:mm tt";
   dataGridViewCellStyle9.NullValue = null;
   this.colBreakEnd.DefaultCellStyle = dataGridViewCellStyle9;
   this.colBreakEnd.HeaderText = "Break End";
   this.colBreakEnd.Name = "colBreakEnd";
   this.colBreakEnd.ReadOnly = true;
   // 
   // frmShiftList
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(907, 506);
   this.Controls.Add(this.pnlBody);
   this.Controls.Add(this.pnlTop);
   this.Name = "frmShiftList";
   this.Text = "Shift Master List";
   this.Deactivate += new System.EventHandler(this.frmShiftList_Deactivate);
   this.Load += new System.EventHandler(this.frmShiftList_Load);
   this.Activated += new System.EventHandler(this.frmShiftList_Activated);
   this.pnlTop.ResumeLayout(false);
   this.pnlTop.PerformLayout();
   this.tsButtons.ResumeLayout(false);
   this.tsButtons.PerformLayout();
   this.pnlBody.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.dgShiftList)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel pnlTop;
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
  private System.Windows.Forms.ToolTip ttRemarks;
  internal System.Windows.Forms.DataGridView dgShiftList;
  private System.Windows.Forms.DataGridViewTextBoxColumn colShiftCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colShiftMode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colTotalHours;
  private System.Windows.Forms.DataGridViewTextBoxColumn colTimeStart;
  private System.Windows.Forms.DataGridViewTextBoxColumn colTimeHalf;
  private System.Windows.Forms.DataGridViewTextBoxColumn colTimeEnd;
  private System.Windows.Forms.DataGridViewTextBoxColumn colBreakStart;
  private System.Windows.Forms.DataGridViewTextBoxColumn colBreakEnd;
 }
}