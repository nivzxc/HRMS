namespace Ipanema.Forms
{
 partial class frmClusterList
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClusterList));
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
   this.pnlHeader = new System.Windows.Forms.Panel();
   this.tsButtons = new System.Windows.Forms.ToolStrip();
   this.btnMembers = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnEdit = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnDelete = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnRefresh = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnEnable = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnDisable = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnClose = new System.Windows.Forms.ToolStripButton();
   this.pnlBody = new System.Windows.Forms.Panel();
   this.dgClusterList = new System.Windows.Forms.DataGridView();
   this.colClusterCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colClusterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colEnabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.pnlHeader.SuspendLayout();
   this.tsButtons.SuspendLayout();
   this.pnlBody.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgClusterList)).BeginInit();
   this.SuspendLayout();
   // 
   // pnlHeader
   // 
   this.pnlHeader.Controls.Add(this.tsButtons);
   this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
   this.pnlHeader.Location = new System.Drawing.Point(0, 0);
   this.pnlHeader.Name = "pnlHeader";
   this.pnlHeader.Size = new System.Drawing.Size(787, 30);
   this.pnlHeader.TabIndex = 0;
   // 
   // tsButtons
   // 
   this.tsButtons.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.tsButtons.ImageScalingSize = new System.Drawing.Size(22, 22);
   this.tsButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMembers,
            this.toolStripSeparator7,
            this.tbtnAdd,
            this.toolStripSeparator1,
            this.tbtnEdit,
            this.toolStripSeparator2,
            this.tbtnDelete,
            this.toolStripSeparator4,
            this.tbtnRefresh,
            this.toolStripSeparator3,
            this.tbtnEnable,
            this.toolStripSeparator6,
            this.tbtnDisable,
            this.toolStripSeparator5,
            this.tbtnClose});
   this.tsButtons.Location = new System.Drawing.Point(0, 0);
   this.tsButtons.Name = "tsButtons";
   this.tsButtons.Size = new System.Drawing.Size(787, 29);
   this.tsButtons.TabIndex = 21;
   this.tsButtons.Text = "OB ToolBar";
   // 
   // btnMembers
   // 
   this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
   this.btnMembers.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.btnMembers.Name = "btnMembers";
   this.btnMembers.Size = new System.Drawing.Size(82, 26);
   this.btnMembers.Text = "Members";
   this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
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
   this.tbtnEdit.Size = new System.Drawing.Size(72, 26);
   this.tbtnEdit.Text = " Modify";
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
   // tbtnEnable
   // 
   this.tbtnEnable.Image = ((System.Drawing.Image)(resources.GetObject("tbtnEnable.Image")));
   this.tbtnEnable.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnEnable.Name = "tbtnEnable";
   this.tbtnEnable.Size = new System.Drawing.Size(69, 26);
   this.tbtnEnable.Text = "Enable";
   this.tbtnEnable.Click += new System.EventHandler(this.tbtnEnable_Click);
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
   this.pnlBody.Controls.Add(this.dgClusterList);
   this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlBody.Location = new System.Drawing.Point(0, 30);
   this.pnlBody.Name = "pnlBody";
   this.pnlBody.Size = new System.Drawing.Size(787, 474);
   this.pnlBody.TabIndex = 2;
   // 
   // dgClusterList
   // 
   this.dgClusterList.AllowUserToAddRows = false;
   this.dgClusterList.AllowUserToDeleteRows = false;
   this.dgClusterList.AllowUserToOrderColumns = true;
   dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
   this.dgClusterList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
   this.dgClusterList.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgClusterList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgClusterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgClusterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClusterCode,
            this.colClusterName,
            this.colEnabled});
   this.dgClusterList.Cursor = System.Windows.Forms.Cursors.Default;
   this.dgClusterList.Dock = System.Windows.Forms.DockStyle.Fill;
   this.dgClusterList.Location = new System.Drawing.Point(0, 0);
   this.dgClusterList.MultiSelect = false;
   this.dgClusterList.Name = "dgClusterList";
   this.dgClusterList.ReadOnly = true;
   this.dgClusterList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgClusterList.RowHeadersWidth = 20;
   this.dgClusterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   this.dgClusterList.Size = new System.Drawing.Size(787, 474);
   this.dgClusterList.TabIndex = 5;
   this.dgClusterList.VirtualMode = true;
   this.dgClusterList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClusterList_CellDoubleClick);
   // 
   // colClusterCode
   // 
   this.colClusterCode.Frozen = true;
   this.colClusterCode.HeaderText = "Code";
   this.colClusterCode.Name = "colClusterCode";
   this.colClusterCode.ReadOnly = true;
   this.colClusterCode.Width = 60;
   // 
   // colClusterName
   // 
   dataGridViewCellStyle8.Format = "N2";
   dataGridViewCellStyle8.NullValue = null;
   this.colClusterName.DefaultCellStyle = dataGridViewCellStyle8;
   this.colClusterName.HeaderText = "Cluster";
   this.colClusterName.Name = "colClusterName";
   this.colClusterName.ReadOnly = true;
   this.colClusterName.Width = 300;
   // 
   // colEnabled
   // 
   dataGridViewCellStyle9.Format = "N2";
   dataGridViewCellStyle9.NullValue = null;
   this.colEnabled.DefaultCellStyle = dataGridViewCellStyle9;
   this.colEnabled.HeaderText = "Enabled";
   this.colEnabled.Name = "colEnabled";
   this.colEnabled.ReadOnly = true;
   this.colEnabled.Width = 80;
   // 
   // frmClusterList
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(787, 504);
   this.Controls.Add(this.pnlBody);
   this.Controls.Add(this.pnlHeader);
   this.Name = "frmClusterList";
   this.Text = "Employee Cluster List";
   this.Deactivate += new System.EventHandler(this.frmClusterList_Deactivate);
   this.Load += new System.EventHandler(this.frmClusterList_Load);
   this.Activated += new System.EventHandler(this.frmClusterList_Activated);
   this.pnlHeader.ResumeLayout(false);
   this.pnlHeader.PerformLayout();
   this.tsButtons.ResumeLayout(false);
   this.tsButtons.PerformLayout();
   this.pnlBody.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.dgClusterList)).EndInit();
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
  private System.Windows.Forms.ToolStripButton tbtnEnable;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
  private System.Windows.Forms.ToolStripButton tbtnDisable;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
  private System.Windows.Forms.ToolStripButton tbtnClose;
  internal System.Windows.Forms.DataGridView dgClusterList;
  private System.Windows.Forms.DataGridViewTextBoxColumn colClusterCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colClusterName;
  private System.Windows.Forms.DataGridViewTextBoxColumn colEnabled;
  private System.Windows.Forms.ToolStripButton btnMembers;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
 }
}