namespace Ipanema.Forms
{
 partial class frmDepartmentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmentList));
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgDepartmentList = new System.Windows.Forms.DataGridView();
            this.colDepartmentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tmiSetActive = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiSetInactive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tmiCloseWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.ttApprovers = new System.Windows.Forms.ToolTip(this.components);
            this.tsButtons = new System.Windows.Forms.ToolStrip();
            this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnActive = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnInActive = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnClose = new System.Windows.Forms.ToolStripButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartmentList)).BeginInit();
            this.cmsList.SuspendLayout();
            this.tsButtons.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgDepartmentList);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 30);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(892, 520);
            this.pnlBody.TabIndex = 2;
            // 
            // dgDepartmentList
            // 
            this.dgDepartmentList.AllowUserToAddRows = false;
            this.dgDepartmentList.AllowUserToDeleteRows = false;
            this.dgDepartmentList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgDepartmentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDepartmentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDepartmentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgDepartmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDepartmentCode,
            this.colDepartment,
            this.colGroup,
            this.colDivision,
            this.colStatus});
            this.dgDepartmentList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgDepartmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDepartmentList.Location = new System.Drawing.Point(0, 0);
            this.dgDepartmentList.MultiSelect = false;
            this.dgDepartmentList.Name = "dgDepartmentList";
            this.dgDepartmentList.ReadOnly = true;
            this.dgDepartmentList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgDepartmentList.RowHeadersWidth = 20;
            this.dgDepartmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDepartmentList.Size = new System.Drawing.Size(892, 520);
            this.dgDepartmentList.TabIndex = 7;
            this.dgDepartmentList.VirtualMode = true;
            this.dgDepartmentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDepartmentList_CellDoubleClick);
            this.dgDepartmentList.SelectionChanged += new System.EventHandler(this.dgDepartmentList_SelectionChanged);
            this.dgDepartmentList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgDepartmentList_KeyDown);
       
            // 
            // colDepartmentCode
            // 
            this.colDepartmentCode.Frozen = true;
            this.colDepartmentCode.HeaderText = "Code";
            this.colDepartmentCode.Name = "colDepartmentCode";
            this.colDepartmentCode.ReadOnly = true;
            this.colDepartmentCode.Width = 60;
            // 
            // colDepartment
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colDepartment.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDepartment.HeaderText = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.ReadOnly = true;
            this.colDepartment.Width = 300;
            // 
            // colGroup
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colGroup.DefaultCellStyle = dataGridViewCellStyle3;
            this.colGroup.HeaderText = "Group";
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;
            this.colGroup.Width = 300;
            // 
            // colDivision
            // 
            this.colDivision.HeaderText = "Division";
            this.colDivision.Name = "colDivision";
            this.colDivision.ReadOnly = true;
            this.colDivision.Width = 250;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Enabled";
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
            this.toolStripSeparator7,
            this.tmiSetActive,
            this.tmiSetInactive,
            this.toolStripSeparator8,
            this.tmiCloseWindow});
            this.cmsList.Name = "cmsList";
            this.cmsList.Size = new System.Drawing.Size(155, 170);
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
            this.tmsiEdit.Click += new System.EventHandler(this.tbtnModify_Click);
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(151, 6);
            // 
            // tmiSetActive
            // 
            this.tmiSetActive.Image = ((System.Drawing.Image)(resources.GetObject("tmiSetActive.Image")));
            this.tmiSetActive.Name = "tmiSetActive";
            this.tmiSetActive.Size = new System.Drawing.Size(154, 22);
            this.tmiSetActive.Text = "Set Active";
            this.tmiSetActive.Click += new System.EventHandler(this.tbtnActive_Click);
            // 
            // tmiSetInactive
            // 
            this.tmiSetInactive.Image = ((System.Drawing.Image)(resources.GetObject("tmiSetInactive.Image")));
            this.tmiSetInactive.Name = "tmiSetInactive";
            this.tmiSetInactive.Size = new System.Drawing.Size(154, 22);
            this.tmiSetInactive.Text = "Set Inactive";
            this.tmiSetInactive.Click += new System.EventHandler(this.tbtnInActive_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(151, 6);
            // 
            // tmiCloseWindow
            // 
            this.tmiCloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("tmiCloseWindow.Image")));
            this.tmiCloseWindow.Name = "tmiCloseWindow";
            this.tmiCloseWindow.Size = new System.Drawing.Size(154, 22);
            this.tmiCloseWindow.Text = "Close Window";
            this.tmiCloseWindow.Click += new System.EventHandler(this.tbtnClose_Click);
            // 
            // ttApprovers
            // 
            this.ttApprovers.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttApprovers.ToolTipTitle = "Approvers:";
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
            this.tbtnActive,
            this.toolStripSeparator6,
            this.tbtnInActive,
            this.toolStripSeparator5,
            this.tbtnClose});
            this.tsButtons.Location = new System.Drawing.Point(0, 0);
            this.tsButtons.Name = "tsButtons";
            this.tsButtons.Size = new System.Drawing.Size(892, 29);
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
            // tbtnActive
            // 
            this.tbtnActive.Image = ((System.Drawing.Image)(resources.GetObject("tbtnActive.Image")));
            this.tbtnActive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnActive.Name = "tbtnActive";
            this.tbtnActive.Size = new System.Drawing.Size(71, 26);
            this.tbtnActive.Text = " Active";
            this.tbtnActive.Click += new System.EventHandler(this.tbtnActive_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 29);
            // 
            // tbtnInActive
            // 
            this.tbtnInActive.Image = ((System.Drawing.Image)(resources.GetObject("tbtnInActive.Image")));
            this.tbtnInActive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnInActive.Name = "tbtnInActive";
            this.tbtnInActive.Size = new System.Drawing.Size(82, 26);
            this.tbtnInActive.Text = " InActive";
            this.tbtnInActive.Click += new System.EventHandler(this.tbtnInActive_Click);
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
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Controls.Add(this.tsButtons);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(892, 30);
            this.pnlHeader.TabIndex = 0;
            // 
            // frmDepartmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 550);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmDepartmentList";
            this.Text = "Department Master List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmDepartmentList_Activated);
            this.Deactivate += new System.EventHandler(this.frmDepartmentList_Deactivate);
            this.Load += new System.EventHandler(this.frmDepartmentList_Load);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartmentList)).EndInit();
            this.cmsList.ResumeLayout(false);
            this.tsButtons.ResumeLayout(false);
            this.tsButtons.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel pnlBody;
  private System.Windows.Forms.ContextMenuStrip cmsList;
  private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
  private System.Windows.Forms.ToolStripMenuItem tmsiEdit;
  private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
  private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
  private System.Windows.Forms.ToolStripMenuItem tmiSetActive;
  private System.Windows.Forms.ToolStripMenuItem tmiSetInactive;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
  private System.Windows.Forms.ToolStripMenuItem tmiCloseWindow;
  private System.Windows.Forms.ToolTip ttApprovers;
  internal System.Windows.Forms.DataGridView dgDepartmentList;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
  private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDivision;
  private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
  private System.Windows.Forms.ToolStrip tsButtons;
  private System.Windows.Forms.ToolStripButton tbtnAdd;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
  private System.Windows.Forms.ToolStripButton tbtnEdit;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
  private System.Windows.Forms.ToolStripButton tbtnDelete;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
  private System.Windows.Forms.ToolStripButton tbtnRefresh;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
  private System.Windows.Forms.ToolStripButton tbtnActive;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
  private System.Windows.Forms.ToolStripButton tbtnInActive;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
  private System.Windows.Forms.ToolStripButton tbtnClose;
  private System.Windows.Forms.Panel pnlHeader;
 }
}