﻿namespace Ipanema.Forms
{
 partial class frmLeaveTypeList
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaveTypeList));
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
      this.dgLeaveTypeList = new System.Windows.Forms.DataGridView();
      this.colLeaveTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colLeaveTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colWithPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMaxBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colHasBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnlHeader.SuspendLayout();
      this.tsButtons.SuspendLayout();
      this.pnlBody.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgLeaveTypeList)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlHeader
      // 
      this.pnlHeader.Controls.Add(this.tsButtons);
      this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlHeader.Location = new System.Drawing.Point(0, 0);
      this.pnlHeader.Name = "pnlHeader";
      this.pnlHeader.Size = new System.Drawing.Size(981, 30);
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
      this.tsButtons.Size = new System.Drawing.Size(981, 29);
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
      this.pnlBody.Controls.Add(this.dgLeaveTypeList);
      this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlBody.Location = new System.Drawing.Point(0, 30);
      this.pnlBody.Name = "pnlBody";
      this.pnlBody.Size = new System.Drawing.Size(981, 529);
      this.pnlBody.TabIndex = 1;
      // 
      // dgLeaveTypeList
      // 
      this.dgLeaveTypeList.AllowUserToAddRows = false;
      this.dgLeaveTypeList.AllowUserToDeleteRows = false;
      this.dgLeaveTypeList.AllowUserToOrderColumns = true;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
      this.dgLeaveTypeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgLeaveTypeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgLeaveTypeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dgLeaveTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgLeaveTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLeaveTypeCode,
            this.colLeaveTypeName,
            this.colWithPay,
            this.colMaxBalance,
            this.colHasBalance,
            this.colStatus});
      this.dgLeaveTypeList.Cursor = System.Windows.Forms.Cursors.Default;
      this.dgLeaveTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgLeaveTypeList.Location = new System.Drawing.Point(0, 0);
      this.dgLeaveTypeList.MultiSelect = false;
      this.dgLeaveTypeList.Name = "dgLeaveTypeList";
      this.dgLeaveTypeList.ReadOnly = true;
      this.dgLeaveTypeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dgLeaveTypeList.RowHeadersWidth = 20;
      this.dgLeaveTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgLeaveTypeList.Size = new System.Drawing.Size(981, 529);
      this.dgLeaveTypeList.TabIndex = 6;
      this.dgLeaveTypeList.VirtualMode = true;
      this.dgLeaveTypeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLeaveTypeList_CellContentClick);
      this.dgLeaveTypeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLeaveTypeList_CellDoubleClick);
      // 
      // colLeaveTypeCode
      // 
      this.colLeaveTypeCode.Frozen = true;
      this.colLeaveTypeCode.HeaderText = "Code";
      this.colLeaveTypeCode.Name = "colLeaveTypeCode";
      this.colLeaveTypeCode.ReadOnly = true;
      this.colLeaveTypeCode.Width = 60;
      // 
      // colLeaveTypeName
      // 
      dataGridViewCellStyle2.Format = "N2";
      dataGridViewCellStyle2.NullValue = null;
      this.colLeaveTypeName.DefaultCellStyle = dataGridViewCellStyle2;
      this.colLeaveTypeName.HeaderText = "Leave Type";
      this.colLeaveTypeName.Name = "colLeaveTypeName";
      this.colLeaveTypeName.ReadOnly = true;
      this.colLeaveTypeName.Width = 300;
      // 
      // colWithPay
      // 
      dataGridViewCellStyle3.Format = "N2";
      dataGridViewCellStyle3.NullValue = null;
      this.colWithPay.DefaultCellStyle = dataGridViewCellStyle3;
      this.colWithPay.HeaderText = "WithPay";
      this.colWithPay.Name = "colWithPay";
      this.colWithPay.ReadOnly = true;
      this.colWithPay.Width = 80;
      // 
      // colMaxBalance
      // 
      this.colMaxBalance.HeaderText = "Max Bal";
      this.colMaxBalance.Name = "colMaxBalance";
      this.colMaxBalance.ReadOnly = true;
      this.colMaxBalance.Width = 80;
      // 
      // colHasBalance
      // 
      this.colHasBalance.HeaderText = "Has Bal";
      this.colHasBalance.Name = "colHasBalance";
      this.colHasBalance.ReadOnly = true;
      this.colHasBalance.Width = 80;
      // 
      // colStatus
      // 
      this.colStatus.HeaderText = "Enabled";
      this.colStatus.Name = "colStatus";
      this.colStatus.ReadOnly = true;
      this.colStatus.Width = 80;
      // 
      // frmLeaveTypeList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(981, 559);
      this.Controls.Add(this.pnlBody);
      this.Controls.Add(this.pnlHeader);
      this.Name = "frmLeaveTypeList";
      this.Text = "Leave Types List";
      this.Activated += new System.EventHandler(this.frmLeaveTypeList_Activated);
      this.Deactivate += new System.EventHandler(this.frmLeaveTypeList_Deactivate);
      this.Load += new System.EventHandler(this.frmLeaveTypeList_Load);
      this.pnlHeader.ResumeLayout(false);
      this.pnlHeader.PerformLayout();
      this.tsButtons.ResumeLayout(false);
      this.tsButtons.PerformLayout();
      this.pnlBody.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgLeaveTypeList)).EndInit();
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
  internal System.Windows.Forms.DataGridView dgLeaveTypeList;
  private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveTypeCode;
  private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveTypeName;
  private System.Windows.Forms.DataGridViewTextBoxColumn colWithPay;
  private System.Windows.Forms.DataGridViewTextBoxColumn colMaxBalance;
  private System.Windows.Forms.DataGridViewTextBoxColumn colHasBalance;
  private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
 }
}