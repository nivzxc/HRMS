namespace Ipanema.Forms
{
 partial class frmTimeCardAcmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeCardAcmList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.chkViewFILO = new System.Windows.Forms.CheckBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.cmsTimeCardList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgTimeCard = new System.Windows.Forms.DataGridView();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.tsButtons.SuspendLayout();
            this.cmsTimeCardList.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimeCard)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "MMM dd, yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(570, 38);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(101, 21);
            this.dtpTo.TabIndex = 2;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.Controls.Add(this.chkViewFILO);
            this.pnlHeader.Controls.Add(this.cmbEmployee);
            this.pnlHeader.Controls.Add(this.label15);
            this.pnlHeader.Controls.Add(this.tsButtons);
            this.pnlHeader.Controls.Add(this.label5);
            this.pnlHeader.Controls.Add(this.dtpTo);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.dtpFrom);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1079, 72);
            this.pnlHeader.TabIndex = 4;
            // 
            // chkViewFILO
            // 
            this.chkViewFILO.AutoSize = true;
            this.chkViewFILO.BackColor = System.Drawing.Color.Transparent;
            this.chkViewFILO.Location = new System.Drawing.Point(679, 40);
            this.chkViewFILO.Name = "chkViewFILO";
            this.chkViewFILO.Size = new System.Drawing.Size(166, 19);
            this.chkViewFILO.TabIndex = 109;
            this.chkViewFILO.Text = "View First In Last Out Only";
            this.chkViewFILO.UseVisualStyleBackColor = false;
            this.chkViewFILO.CheckedChanged += new System.EventHandler(this.chkViewFILO_CheckedChanged);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownHeight = 200;
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.IntegralHeight = false;
            this.cmbEmployee.Location = new System.Drawing.Point(83, 38);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(241, 23);
            this.cmbEmployee.TabIndex = 0;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 15);
            this.label15.TabIndex = 108;
            this.label15.Text = "Employee:";
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
            this.tsButtons.Size = new System.Drawing.Size(1079, 29);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(556, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(355, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inclusive Dates:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "MMM dd, yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(451, 38);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(101, 21);
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // cmsTimeCardList
            // 
            this.cmsTimeCardList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiAdd,
            this.tmiEdit,
            this.tmiDelete,
            this.tmiRefresh});
            this.cmsTimeCardList.Name = "cmsTimeCardList";
            this.cmsTimeCardList.Size = new System.Drawing.Size(114, 92);
            // 
            // tmiAdd
            // 
            this.tmiAdd.Image = ((System.Drawing.Image)(resources.GetObject("tmiAdd.Image")));
            this.tmiAdd.Name = "tmiAdd";
            this.tmiAdd.Size = new System.Drawing.Size(113, 22);
            this.tmiAdd.Text = "Add";
            // 
            // tmiEdit
            // 
            this.tmiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tmiEdit.Image")));
            this.tmiEdit.Name = "tmiEdit";
            this.tmiEdit.Size = new System.Drawing.Size(113, 22);
            this.tmiEdit.Text = "Edit";
            // 
            // tmiDelete
            // 
            this.tmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tmiDelete.Image")));
            this.tmiDelete.Name = "tmiDelete";
            this.tmiDelete.Size = new System.Drawing.Size(113, 22);
            this.tmiDelete.Text = "Delete";
            // 
            // tmiRefresh
            // 
            this.tmiRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tmiRefresh.Image")));
            this.tmiRefresh.Name = "tmiRefresh";
            this.tmiRefresh.Size = new System.Drawing.Size(113, 22);
            this.tmiRefresh.Text = "Refresh";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgTimeCard);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 72);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1079, 480);
            this.pnlBody.TabIndex = 6;
            // 
            // dgTimeCard
            // 
            this.dgTimeCard.AllowUserToAddRows = false;
            this.dgTimeCard.AllowUserToDeleteRows = false;
            this.dgTimeCard.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgTimeCard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTimeCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTimeCard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgTimeCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTimeCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername,
            this.colName,
            this.colDate,
            this.colTime,
            this.colEventType,
            this.colDoor});
            this.dgTimeCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgTimeCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTimeCard.Location = new System.Drawing.Point(0, 0);
            this.dgTimeCard.MultiSelect = false;
            this.dgTimeCard.Name = "dgTimeCard";
            this.dgTimeCard.ReadOnly = true;
            this.dgTimeCard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgTimeCard.RowHeadersWidth = 20;
            this.dgTimeCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTimeCard.Size = new System.Drawing.Size(1079, 480);
            this.dgTimeCard.TabIndex = 6;
            this.dgTimeCard.VirtualMode = true;
            this.dgTimeCard.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgTimeCard_DataBindingComplete);
            // 
            // colUsername
            // 
            this.colUsername.FillWeight = 200F;
            this.colUsername.Frozen = true;
            this.colUsername.HeaderText = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            this.colUsername.Visible = false;
            this.colUsername.Width = 150;
            // 
            // colName
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colName.HeaderText = "Employee Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 300;
            // 
            // colDate
            // 
            dataGridViewCellStyle3.Format = "MMM dd, yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 120;
            // 
            // colTime
            // 
            dataGridViewCellStyle4.Format = "hh:mm tt";
            dataGridViewCellStyle4.NullValue = null;
            this.colTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTime.HeaderText = "Time";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colEventType
            // 
            this.colEventType.HeaderText = "Action";
            this.colEventType.Name = "colEventType";
            this.colEventType.ReadOnly = true;
            // 
            // colDoor
            // 
            this.colDoor.HeaderText = "Door";
            this.colDoor.Name = "colDoor";
            this.colDoor.ReadOnly = true;
            this.colDoor.Width = 150;
            // 
            // frmTimeCardAcmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 552);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmTimeCardAcmList";
            this.Text = "Time Card Record (ACM)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimeCardAcmList_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tsButtons.ResumeLayout(false);
            this.tsButtons.PerformLayout();
            this.cmsTimeCardList.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTimeCard)).EndInit();
            this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.DateTimePicker dtpTo;
  private System.Windows.Forms.Panel pnlHeader;
  private System.Windows.Forms.ComboBox cmbEmployee;
  private System.Windows.Forms.Label label15;
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
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.DateTimePicker dtpFrom;
  private System.Windows.Forms.ContextMenuStrip cmsTimeCardList;
  private System.Windows.Forms.ToolStripMenuItem tmiAdd;
  private System.Windows.Forms.ToolStripMenuItem tmiEdit;
  private System.Windows.Forms.ToolStripMenuItem tmiDelete;
  private System.Windows.Forms.ToolStripMenuItem tmiRefresh;
  private System.Windows.Forms.Panel pnlBody;
  internal System.Windows.Forms.DataGridView dgTimeCard;
  private System.Windows.Forms.CheckBox chkViewFILO;
  private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
  private System.Windows.Forms.DataGridViewTextBoxColumn colName;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
  private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
  private System.Windows.Forms.DataGridViewTextBoxColumn colEventType;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDoor;
 }
}