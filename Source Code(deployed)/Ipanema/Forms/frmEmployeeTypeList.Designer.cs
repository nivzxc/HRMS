namespace Ipanema.Forms
{
 partial class frmEmployeeTypeList
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeTypeList));
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
   this.tbtnEnabled = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnDisable = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnClose = new System.Windows.Forms.ToolStripButton();
   this.pnlBody = new System.Windows.Forms.Panel();
   this.dgEmployeeTypeList = new System.Windows.Forms.DataGridView();
   this.colLeaveTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colEmployeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.pnlHeader.SuspendLayout();
   this.tsButtons.SuspendLayout();
   this.pnlBody.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeTypeList)).BeginInit();
   this.SuspendLayout();
   // 
   // pnlHeader
   // 
   this.pnlHeader.Controls.Add(this.tsButtons);
   this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
   this.pnlHeader.Location = new System.Drawing.Point(0, 0);
   this.pnlHeader.Name = "pnlHeader";
   this.pnlHeader.Size = new System.Drawing.Size(748, 30);
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
            this.tbtnEnabled,
            this.toolStripSeparator6,
            this.tbtnDisable,
            this.toolStripSeparator5,
            this.tbtnClose});
   this.tsButtons.Location = new System.Drawing.Point(0, 0);
   this.tsButtons.Name = "tsButtons";
   this.tsButtons.Size = new System.Drawing.Size(748, 29);
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
   this.tbtnEdit.Size = new System.Drawing.Size(72, 26);
   this.tbtnEdit.Text = " Modify";
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
   this.tbtnDelete.Size = new System.Drawing.Size(73, 26);
   this.tbtnDelete.Text = " Delete";
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
   this.tbtnRefresh.Size = new System.Drawing.Size(78, 26);
   this.tbtnRefresh.Text = " Refresh";
   this.tbtnRefresh.ToolTipText = "Refresh record list";
   this.tbtnRefresh.Click += new System.EventHandler(this.tbtnRefresh_Click);
   // 
   // toolStripSeparator3
   // 
   this.toolStripSeparator3.Name = "toolStripSeparator3";
   this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
   // 
   // tbtnEnabled
   // 
   this.tbtnEnabled.Image = ((System.Drawing.Image)(resources.GetObject("tbtnEnabled.Image")));
   this.tbtnEnabled.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnEnabled.Name = "tbtnEnabled";
   this.tbtnEnabled.Size = new System.Drawing.Size(69, 26);
   this.tbtnEnabled.Text = "Enable";
   this.tbtnEnabled.Click += new System.EventHandler(this.tbtnEnabled_Click);
   // 
   // toolStripSeparator6
   // 
   this.toolStripSeparator6.Name = "toolStripSeparator6";
   this.toolStripSeparator6.Size = new System.Drawing.Size(6, 29);
   // 
   // tbtnDisable
   // 
   this.tbtnDisable.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDisable.Image")));
   this.tbtnDisable.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnDisable.Name = "tbtnDisable";
   this.tbtnDisable.Size = new System.Drawing.Size(70, 26);
   this.tbtnDisable.Text = "Disable";
   this.tbtnDisable.Click += new System.EventHandler(this.tbtnDisable_Click);
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
   this.tbtnClose.Size = new System.Drawing.Size(114, 26);
   this.tbtnClose.Text = " Close Window";
   this.tbtnClose.ToolTipText = "Close window";
   this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
   // 
   // pnlBody
   // 
   this.pnlBody.Controls.Add(this.dgEmployeeTypeList);
   this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlBody.Location = new System.Drawing.Point(0, 30);
   this.pnlBody.Name = "pnlBody";
   this.pnlBody.Size = new System.Drawing.Size(748, 437);
   this.pnlBody.TabIndex = 2;
   // 
   // dgEmployeeTypeList
   // 
   this.dgEmployeeTypeList.AllowUserToAddRows = false;
   this.dgEmployeeTypeList.AllowUserToDeleteRows = false;
   this.dgEmployeeTypeList.AllowUserToOrderColumns = true;
   dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
   this.dgEmployeeTypeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
   this.dgEmployeeTypeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgEmployeeTypeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgEmployeeTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgEmployeeTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLeaveTypeCode,
            this.colEmployeeType,
            this.colDescription});
   this.dgEmployeeTypeList.Cursor = System.Windows.Forms.Cursors.Default;
   this.dgEmployeeTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
   this.dgEmployeeTypeList.Location = new System.Drawing.Point(0, 0);
   this.dgEmployeeTypeList.MultiSelect = false;
   this.dgEmployeeTypeList.Name = "dgEmployeeTypeList";
   this.dgEmployeeTypeList.ReadOnly = true;
   this.dgEmployeeTypeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgEmployeeTypeList.RowHeadersWidth = 20;
   this.dgEmployeeTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   this.dgEmployeeTypeList.Size = new System.Drawing.Size(748, 437);
   this.dgEmployeeTypeList.TabIndex = 7;
   this.dgEmployeeTypeList.VirtualMode = true;
   this.dgEmployeeTypeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployeeTypeList_CellDoubleClick);
   // 
   // colLeaveTypeCode
   // 
   this.colLeaveTypeCode.Frozen = true;
   this.colLeaveTypeCode.HeaderText = "Code";
   this.colLeaveTypeCode.Name = "colLeaveTypeCode";
   this.colLeaveTypeCode.ReadOnly = true;
   this.colLeaveTypeCode.Width = 60;
   // 
   // colEmployeeType
   // 
   dataGridViewCellStyle2.Format = "N2";
   dataGridViewCellStyle2.NullValue = null;
   this.colEmployeeType.DefaultCellStyle = dataGridViewCellStyle2;
   this.colEmployeeType.HeaderText = "Employee Type";
   this.colEmployeeType.Name = "colEmployeeType";
   this.colEmployeeType.ReadOnly = true;
   this.colEmployeeType.Width = 250;
   // 
   // colDescription
   // 
   dataGridViewCellStyle3.Format = "N2";
   dataGridViewCellStyle3.NullValue = null;
   this.colDescription.DefaultCellStyle = dataGridViewCellStyle3;
   this.colDescription.HeaderText = "Description";
   this.colDescription.Name = "colDescription";
   this.colDescription.ReadOnly = true;
   this.colDescription.Width = 300;
   // 
   // frmEmployeeTypeList
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(748, 467);
   this.Controls.Add(this.pnlBody);
   this.Controls.Add(this.pnlHeader);
   this.Name = "frmEmployeeTypeList";
   this.Text = "Employee Type Master List";
   this.Load += new System.EventHandler(this.frmEmployeeTypeList_Load);
   this.pnlHeader.ResumeLayout(false);
   this.pnlHeader.PerformLayout();
   this.tsButtons.ResumeLayout(false);
   this.tsButtons.PerformLayout();
   this.pnlBody.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeTypeList)).EndInit();
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
  private System.Windows.Forms.ToolStripButton tbtnEnabled;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
  private System.Windows.Forms.ToolStripButton tbtnDisable;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
  private System.Windows.Forms.ToolStripButton tbtnClose;
  internal System.Windows.Forms.DataGridView dgEmployeeTypeList;
  private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveTypeCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeType;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
 }
}