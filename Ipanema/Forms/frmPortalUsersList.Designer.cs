namespace Ipanema.Forms
{
 partial class frmPortalUsersList
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPortalUsersList));
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
   this.pnlHeader = new System.Windows.Forms.Panel();
   this.cmbStatus = new System.Windows.Forms.ComboBox();
   this.label1 = new System.Windows.Forms.Label();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
   this.dgPortalUsersList = new System.Windows.Forms.DataGridView();
   this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colEmployeeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.pnlHeader.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
   this.tsButtons.SuspendLayout();
   this.pnlBody.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgPortalUsersList)).BeginInit();
   this.SuspendLayout();
   // 
   // pnlHeader
   // 
   this.pnlHeader.BackColor = System.Drawing.Color.White;
   this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
   this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
   this.pnlHeader.Controls.Add(this.cmbStatus);
   this.pnlHeader.Controls.Add(this.label1);
   this.pnlHeader.Controls.Add(this.pictureBox1);
   this.pnlHeader.Controls.Add(this.tsButtons);
   this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
   this.pnlHeader.Location = new System.Drawing.Point(0, 0);
   this.pnlHeader.Name = "pnlHeader";
   this.pnlHeader.Size = new System.Drawing.Size(813, 70);
   this.pnlHeader.TabIndex = 1;
   // 
   // cmbStatus
   // 
   this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbStatus.FormattingEnabled = true;
   this.cmbStatus.Location = new System.Drawing.Point(84, 38);
   this.cmbStatus.Name = "cmbStatus";
   this.cmbStatus.Size = new System.Drawing.Size(122, 21);
   this.cmbStatus.TabIndex = 41;
   this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.BackColor = System.Drawing.Color.Transparent;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(41, 43);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(40, 13);
   this.label1.TabIndex = 43;
   this.label1.Text = "Status:";
   // 
   // pictureBox1
   // 
   this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
   this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(10, 37);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(24, 22);
   this.pictureBox1.TabIndex = 42;
   this.pictureBox1.TabStop = false;
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
   this.tsButtons.Size = new System.Drawing.Size(813, 29);
   this.tsButtons.TabIndex = 22;
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
   // pnlBody
   // 
   this.pnlBody.Controls.Add(this.dgPortalUsersList);
   this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlBody.Location = new System.Drawing.Point(0, 70);
   this.pnlBody.Name = "pnlBody";
   this.pnlBody.Size = new System.Drawing.Size(813, 425);
   this.pnlBody.TabIndex = 3;
   // 
   // dgPortalUsersList
   // 
   this.dgPortalUsersList.AllowUserToAddRows = false;
   this.dgPortalUsersList.AllowUserToDeleteRows = false;
   this.dgPortalUsersList.AllowUserToOrderColumns = true;
   dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
   this.dgPortalUsersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
   this.dgPortalUsersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgPortalUsersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgPortalUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgPortalUsersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername,
            this.colEmployeeName,
            this.colEmployeeTitle,
            this.colStatus});
   this.dgPortalUsersList.Cursor = System.Windows.Forms.Cursors.Default;
   this.dgPortalUsersList.Dock = System.Windows.Forms.DockStyle.Fill;
   this.dgPortalUsersList.Location = new System.Drawing.Point(0, 0);
   this.dgPortalUsersList.MultiSelect = false;
   this.dgPortalUsersList.Name = "dgPortalUsersList";
   this.dgPortalUsersList.ReadOnly = true;
   this.dgPortalUsersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgPortalUsersList.RowHeadersWidth = 20;
   this.dgPortalUsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   this.dgPortalUsersList.Size = new System.Drawing.Size(813, 425);
   this.dgPortalUsersList.TabIndex = 8;
   this.dgPortalUsersList.VirtualMode = true;
   this.dgPortalUsersList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPortalUsersList_CellDoubleClick);
   // 
   // colUsername
   // 
   this.colUsername.Frozen = true;
   this.colUsername.HeaderText = "Username";
   this.colUsername.Name = "colUsername";
   this.colUsername.ReadOnly = true;
   this.colUsername.Width = 150;
   // 
   // colEmployeeName
   // 
   dataGridViewCellStyle8.Format = "N2";
   dataGridViewCellStyle8.NullValue = null;
   this.colEmployeeName.DefaultCellStyle = dataGridViewCellStyle8;
   this.colEmployeeName.HeaderText = "Employee Name";
   this.colEmployeeName.Name = "colEmployeeName";
   this.colEmployeeName.ReadOnly = true;
   this.colEmployeeName.Width = 250;
   // 
   // colEmployeeTitle
   // 
   dataGridViewCellStyle9.Format = "N2";
   dataGridViewCellStyle9.NullValue = null;
   this.colEmployeeTitle.DefaultCellStyle = dataGridViewCellStyle9;
   this.colEmployeeTitle.HeaderText = "Employee Title";
   this.colEmployeeTitle.Name = "colEmployeeTitle";
   this.colEmployeeTitle.ReadOnly = true;
   this.colEmployeeTitle.Width = 250;
   // 
   // colStatus
   // 
   this.colStatus.HeaderText = "Status";
   this.colStatus.Name = "colStatus";
   this.colStatus.ReadOnly = true;
   // 
   // frmPortalUsersList
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(813, 495);
   this.Controls.Add(this.pnlBody);
   this.Controls.Add(this.pnlHeader);
   this.Name = "frmPortalUsersList";
   this.Text = "Portal Users List";
   this.Deactivate += new System.EventHandler(this.frmPortalUsersList_Deactivate);
   this.Load += new System.EventHandler(this.frmPortalUsersList_Load);
   this.Activated += new System.EventHandler(this.frmPortalUsersList_Activated);
   this.pnlHeader.ResumeLayout(false);
   this.pnlHeader.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
   this.tsButtons.ResumeLayout(false);
   this.tsButtons.PerformLayout();
   this.pnlBody.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.dgPortalUsersList)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel pnlHeader;
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
  private System.Windows.Forms.Panel pnlBody;
  private System.Windows.Forms.ComboBox cmbStatus;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.PictureBox pictureBox1;
  internal System.Windows.Forms.DataGridView dgPortalUsersList;
  private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
  private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeName;
  private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeTitle;
  private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
 }
}