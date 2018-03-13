namespace Ipanema.Forms
{
 partial class frmRCList
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRCList));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tbtnClose = new System.Windows.Forms.ToolStripButton();
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
      this.pnlBody = new System.Windows.Forms.Panel();
      this.dgRCList = new System.Windows.Forms.DataGridView();
      this.colRCCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colRCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colGPCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnlHeader.SuspendLayout();
      this.tsButtons.SuspendLayout();
      this.pnlBody.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgRCList)).BeginInit();
      this.SuspendLayout();
      // 
      // tbtnClose
      // 
      this.tbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tbtnClose.Image")));
      this.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtnClose.Name = "tbtnClose";
      this.tbtnClose.Size = new System.Drawing.Size(69, 26);
      this.tbtnClose.Text = " Close ";
      this.tbtnClose.ToolTipText = "Close window";
      this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
      // 
      // pnlHeader
      // 
      this.pnlHeader.Controls.Add(this.tsButtons);
      this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlHeader.Location = new System.Drawing.Point(0, 0);
      this.pnlHeader.Name = "pnlHeader";
      this.pnlHeader.Size = new System.Drawing.Size(948, 30);
      this.pnlHeader.TabIndex = 2;
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
      this.tsButtons.Size = new System.Drawing.Size(948, 29);
      this.tsButtons.TabIndex = 20;
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
      this.tbtnEdit.Size = new System.Drawing.Size(76, 26);
      this.tbtnEdit.Text = " Modify ";
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
      // pnlBody
      // 
      this.pnlBody.Controls.Add(this.dgRCList);
      this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlBody.Location = new System.Drawing.Point(0, 30);
      this.pnlBody.Name = "pnlBody";
      this.pnlBody.Size = new System.Drawing.Size(948, 533);
      this.pnlBody.TabIndex = 4;
      // 
      // dgRCList
      // 
      this.dgRCList.AllowUserToAddRows = false;
      this.dgRCList.AllowUserToDeleteRows = false;
      this.dgRCList.AllowUserToOrderColumns = true;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
      this.dgRCList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgRCList.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgRCList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dgRCList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgRCList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRCCode,
            this.colRCName,
            this.colDivision,
            this.colGPCode,
            this.colCompany,
            this.colStatus});
      this.dgRCList.Cursor = System.Windows.Forms.Cursors.Default;
      this.dgRCList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgRCList.Location = new System.Drawing.Point(0, 0);
      this.dgRCList.MultiSelect = false;
      this.dgRCList.Name = "dgRCList";
      this.dgRCList.ReadOnly = true;
      this.dgRCList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dgRCList.RowHeadersWidth = 20;
      this.dgRCList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgRCList.Size = new System.Drawing.Size(948, 533);
      this.dgRCList.TabIndex = 8;
      this.dgRCList.VirtualMode = true;
      this.dgRCList.DoubleClick += new System.EventHandler(this.dgRCList_DoubleClick);
      // 
      // colRCCode
      // 
      this.colRCCode.Frozen = true;
      this.colRCCode.HeaderText = "Code";
      this.colRCCode.Name = "colRCCode";
      this.colRCCode.ReadOnly = true;
      this.colRCCode.Width = 60;
      // 
      // colRCName
      // 
      dataGridViewCellStyle2.Format = "N2";
      dataGridViewCellStyle2.NullValue = null;
      this.colRCName.DefaultCellStyle = dataGridViewCellStyle2;
      this.colRCName.HeaderText = "RC Name";
      this.colRCName.Name = "colRCName";
      this.colRCName.ReadOnly = true;
      this.colRCName.Width = 300;
      // 
      // colDivision
      // 
      dataGridViewCellStyle3.Format = "N2";
      dataGridViewCellStyle3.NullValue = null;
      this.colDivision.DefaultCellStyle = dataGridViewCellStyle3;
      this.colDivision.HeaderText = "Division";
      this.colDivision.Name = "colDivision";
      this.colDivision.ReadOnly = true;
      this.colDivision.Width = 200;
      // 
      // colGPCode
      // 
      this.colGPCode.HeaderText = "GP Code";
      this.colGPCode.Name = "colGPCode";
      this.colGPCode.ReadOnly = true;
      // 
      // colCompany
      // 
      this.colCompany.HeaderText = "Company";
      this.colCompany.Name = "colCompany";
      this.colCompany.ReadOnly = true;
      this.colCompany.Width = 200;
      // 
      // colStatus
      // 
      this.colStatus.HeaderText = "Status";
      this.colStatus.Name = "colStatus";
      this.colStatus.ReadOnly = true;
      this.colStatus.Width = 80;
      // 
      // frmRCList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(948, 563);
      this.Controls.Add(this.pnlBody);
      this.Controls.Add(this.pnlHeader);
      this.Name = "frmRCList";
      this.Text = "Responsibility Center (RC) List";
      this.Load += new System.EventHandler(this.frmRCList_Load);
      this.pnlHeader.ResumeLayout(false);
      this.pnlHeader.PerformLayout();
      this.tsButtons.ResumeLayout(false);
      this.tsButtons.PerformLayout();
      this.pnlBody.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgRCList)).EndInit();
      this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.ToolStripButton tbtnClose;
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
  private System.Windows.Forms.Panel pnlBody;
  internal System.Windows.Forms.DataGridView dgRCList;
  private System.Windows.Forms.DataGridViewTextBoxColumn colRCCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colRCName;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDivision;
  private System.Windows.Forms.DataGridViewTextBoxColumn colGPCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
  private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
 }
}