namespace Ipanema.Forms
{
 partial class frmScheduleList
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleList));
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
   this.tbtnClose = new System.Windows.Forms.ToolStripButton();
   this.pnlBody = new System.Windows.Forms.Panel();
   this.dgScheduleList = new System.Windows.Forms.DataGridView();
   this.colScheduleCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colSaturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colSunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.ttRemarks = new System.Windows.Forms.ToolTip(this.components);
   this.pnlHeader.SuspendLayout();
   this.tsButtons.SuspendLayout();
   this.pnlBody.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgScheduleList)).BeginInit();
   this.SuspendLayout();
   // 
   // pnlHeader
   // 
   this.pnlHeader.Controls.Add(this.tsButtons);
   this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
   this.pnlHeader.Location = new System.Drawing.Point(0, 0);
   this.pnlHeader.Name = "pnlHeader";
   this.pnlHeader.Size = new System.Drawing.Size(1015, 30);
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
   this.tsButtons.Size = new System.Drawing.Size(1015, 29);
   this.tsButtons.TabIndex = 22;
   this.tsButtons.Text = "OB ToolBar";
   // 
   // tbtnAdd
   // 
   this.tbtnAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.tbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAdd.Image")));
   this.tbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnAdd.Name = "tbtnAdd";
   this.tbtnAdd.Size = new System.Drawing.Size(88, 26);
   this.tbtnAdd.Text = " Add New";
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
   this.pnlBody.Controls.Add(this.dgScheduleList);
   this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlBody.Location = new System.Drawing.Point(0, 30);
   this.pnlBody.Name = "pnlBody";
   this.pnlBody.Size = new System.Drawing.Size(1015, 425);
   this.pnlBody.TabIndex = 3;
   // 
   // dgScheduleList
   // 
   this.dgScheduleList.AllowUserToAddRows = false;
   this.dgScheduleList.AllowUserToDeleteRows = false;
   this.dgScheduleList.AllowUserToOrderColumns = true;
   dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
   this.dgScheduleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
   this.dgScheduleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgScheduleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgScheduleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgScheduleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colScheduleCode,
            this.colMonday,
            this.colTuesday,
            this.colWednesday,
            this.colThursday,
            this.colFriday,
            this.colSaturday,
            this.colSunday});
   this.dgScheduleList.Cursor = System.Windows.Forms.Cursors.Default;
   this.dgScheduleList.Dock = System.Windows.Forms.DockStyle.Fill;
   this.dgScheduleList.Location = new System.Drawing.Point(0, 0);
   this.dgScheduleList.MultiSelect = false;
   this.dgScheduleList.Name = "dgScheduleList";
   this.dgScheduleList.ReadOnly = true;
   this.dgScheduleList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgScheduleList.RowHeadersWidth = 20;
   this.dgScheduleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   this.dgScheduleList.Size = new System.Drawing.Size(1015, 425);
   this.dgScheduleList.TabIndex = 7;
   this.dgScheduleList.VirtualMode = true;
   this.dgScheduleList.DoubleClick += new System.EventHandler(this.dgScheduleList_DoubleClick);
   // 
   // colScheduleCode
   // 
   this.colScheduleCode.Frozen = true;
   this.colScheduleCode.HeaderText = "Code";
   this.colScheduleCode.Name = "colScheduleCode";
   this.colScheduleCode.ReadOnly = true;
   this.colScheduleCode.Width = 60;
   // 
   // colMonday
   // 
   dataGridViewCellStyle2.Format = "N2";
   dataGridViewCellStyle2.NullValue = null;
   this.colMonday.DefaultCellStyle = dataGridViewCellStyle2;
   this.colMonday.HeaderText = "Monday";
   this.colMonday.Name = "colMonday";
   this.colMonday.ReadOnly = true;
   this.colMonday.Width = 120;
   // 
   // colTuesday
   // 
   dataGridViewCellStyle3.Format = "N2";
   dataGridViewCellStyle3.NullValue = null;
   this.colTuesday.DefaultCellStyle = dataGridViewCellStyle3;
   this.colTuesday.HeaderText = "Tuesday";
   this.colTuesday.Name = "colTuesday";
   this.colTuesday.ReadOnly = true;
   this.colTuesday.Width = 120;
   // 
   // colWednesday
   // 
   this.colWednesday.HeaderText = "Wednesday";
   this.colWednesday.Name = "colWednesday";
   this.colWednesday.ReadOnly = true;
   this.colWednesday.Width = 120;
   // 
   // colThursday
   // 
   this.colThursday.HeaderText = "Thursday";
   this.colThursday.Name = "colThursday";
   this.colThursday.ReadOnly = true;
   this.colThursday.Width = 120;
   // 
   // colFriday
   // 
   this.colFriday.HeaderText = "Friday";
   this.colFriday.Name = "colFriday";
   this.colFriday.ReadOnly = true;
   this.colFriday.Width = 120;
   // 
   // colSaturday
   // 
   this.colSaturday.HeaderText = "Saturday";
   this.colSaturday.Name = "colSaturday";
   this.colSaturday.ReadOnly = true;
   this.colSaturday.Width = 120;
   // 
   // colSunday
   // 
   this.colSunday.HeaderText = "Sunday";
   this.colSunday.Name = "colSunday";
   this.colSunday.ReadOnly = true;
   this.colSunday.Width = 120;
   // 
   // ttRemarks
   // 
   this.ttRemarks.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
   this.ttRemarks.ToolTipTitle = "Remarks";
   // 
   // frmScheduleList
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(1015, 455);
   this.Controls.Add(this.pnlBody);
   this.Controls.Add(this.pnlHeader);
   this.Name = "frmScheduleList";
   this.Text = "Schedule Master List";
   this.Deactivate += new System.EventHandler(this.frmScheduleList_Deactivate);
   this.Load += new System.EventHandler(this.frmScheduleList_Load);
   this.Activated += new System.EventHandler(this.frmScheduleList_Activated);
   this.pnlHeader.ResumeLayout(false);
   this.pnlHeader.PerformLayout();
   this.tsButtons.ResumeLayout(false);
   this.tsButtons.PerformLayout();
   this.pnlBody.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.dgScheduleList)).EndInit();
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
  private System.Windows.Forms.ToolTip ttRemarks;
  internal System.Windows.Forms.DataGridView dgScheduleList;
  private System.Windows.Forms.DataGridViewTextBoxColumn colScheduleCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colMonday;
  private System.Windows.Forms.DataGridViewTextBoxColumn colTuesday;
  private System.Windows.Forms.DataGridViewTextBoxColumn colWednesday;
  private System.Windows.Forms.DataGridViewTextBoxColumn colThursday;
  private System.Windows.Forms.DataGridViewTextBoxColumn colFriday;
  private System.Windows.Forms.DataGridViewTextBoxColumn colSaturday;
  private System.Windows.Forms.DataGridViewTextBoxColumn colSunday;
 }
}