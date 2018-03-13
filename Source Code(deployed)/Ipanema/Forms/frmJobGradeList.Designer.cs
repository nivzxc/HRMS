namespace Ipanema.Forms
{
 partial class frmJobGradeList
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobGradeList));
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
   this.dgJobGrade = new System.Windows.Forms.DataGridView();
   this.colJobGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colDeductLate = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colDeductUndertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colPayOvertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colPlantillaHQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colPlantillaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.pnlHeader.SuspendLayout();
   this.tsButtons.SuspendLayout();
   this.pnlBody.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgJobGrade)).BeginInit();
   this.SuspendLayout();
   // 
   // pnlHeader
   // 
   this.pnlHeader.Controls.Add(this.tsButtons);
   this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
   this.pnlHeader.Location = new System.Drawing.Point(0, 0);
   this.pnlHeader.Name = "pnlHeader";
   this.pnlHeader.Size = new System.Drawing.Size(833, 30);
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
   this.tsButtons.Size = new System.Drawing.Size(833, 29);
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
   this.pnlBody.Controls.Add(this.dgJobGrade);
   this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlBody.Location = new System.Drawing.Point(0, 30);
   this.pnlBody.Name = "pnlBody";
   this.pnlBody.Size = new System.Drawing.Size(833, 466);
   this.pnlBody.TabIndex = 2;
   // 
   // dgJobGrade
   // 
   this.dgJobGrade.AllowUserToAddRows = false;
   this.dgJobGrade.AllowUserToDeleteRows = false;
   this.dgJobGrade.AllowUserToOrderColumns = true;
   dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
   this.dgJobGrade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
   this.dgJobGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgJobGrade.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
   dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
   dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
   dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
   dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
   dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
   this.dgJobGrade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
   this.dgJobGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgJobGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJobGrade,
            this.colDescription,
            this.colOrder,
            this.colDeductLate,
            this.colDeductUndertime,
            this.colPayOvertime,
            this.colPlantillaHQ,
            this.colPlantillaB});
   this.dgJobGrade.Cursor = System.Windows.Forms.Cursors.Default;
   this.dgJobGrade.Dock = System.Windows.Forms.DockStyle.Fill;
   this.dgJobGrade.Location = new System.Drawing.Point(0, 0);
   this.dgJobGrade.MultiSelect = false;
   this.dgJobGrade.Name = "dgJobGrade";
   this.dgJobGrade.ReadOnly = true;
   this.dgJobGrade.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
   dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
   dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
   dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
   dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
   dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
   this.dgJobGrade.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
   this.dgJobGrade.RowHeadersWidth = 20;
   this.dgJobGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   this.dgJobGrade.Size = new System.Drawing.Size(833, 466);
   this.dgJobGrade.TabIndex = 7;
   this.dgJobGrade.VirtualMode = true;
   this.dgJobGrade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgJobGrade_CellDoubleClick);
   // 
   // colJobGrade
   // 
   this.colJobGrade.FillWeight = 200F;
   this.colJobGrade.Frozen = true;
   this.colJobGrade.HeaderText = "Job Grade";
   this.colJobGrade.Name = "colJobGrade";
   this.colJobGrade.ReadOnly = true;
   this.colJobGrade.Width = 90;
   // 
   // colDescription
   // 
   dataGridViewCellStyle3.Format = "N2";
   dataGridViewCellStyle3.NullValue = null;
   this.colDescription.DefaultCellStyle = dataGridViewCellStyle3;
   this.colDescription.HeaderText = "Description";
   this.colDescription.Name = "colDescription";
   this.colDescription.ReadOnly = true;
   this.colDescription.Width = 200;
   // 
   // colOrder
   // 
   dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
   dataGridViewCellStyle4.Format = "N0";
   dataGridViewCellStyle4.NullValue = null;
   this.colOrder.DefaultCellStyle = dataGridViewCellStyle4;
   this.colOrder.HeaderText = "Order";
   this.colOrder.Name = "colOrder";
   this.colOrder.ReadOnly = true;
   this.colOrder.Width = 50;
   // 
   // colDeductLate
   // 
   this.colDeductLate.HeaderText = "D Late";
   this.colDeductLate.Name = "colDeductLate";
   this.colDeductLate.ReadOnly = true;
   this.colDeductLate.Width = 80;
   // 
   // colDeductUndertime
   // 
   this.colDeductUndertime.HeaderText = "D Under";
   this.colDeductUndertime.Name = "colDeductUndertime";
   this.colDeductUndertime.ReadOnly = true;
   this.colDeductUndertime.Width = 80;
   // 
   // colPayOvertime
   // 
   this.colPayOvertime.HeaderText = "Pay OT";
   this.colPayOvertime.Name = "colPayOvertime";
   this.colPayOvertime.ReadOnly = true;
   this.colPayOvertime.Width = 80;
   // 
   // colPlantillaHQ
   // 
   this.colPlantillaHQ.HeaderText = "Plantilla H";
   this.colPlantillaHQ.Name = "colPlantillaHQ";
   this.colPlantillaHQ.ReadOnly = true;
   // 
   // colPlantillaB
   // 
   this.colPlantillaB.HeaderText = "Plantilla B";
   this.colPlantillaB.Name = "colPlantillaB";
   this.colPlantillaB.ReadOnly = true;
   // 
   // frmJobGradeList
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(833, 496);
   this.Controls.Add(this.pnlBody);
   this.Controls.Add(this.pnlHeader);
   this.Name = "frmJobGradeList";
   this.Text = "Job Grade List";
   this.Load += new System.EventHandler(this.frmJobGradeList_Load);
   this.pnlHeader.ResumeLayout(false);
   this.pnlHeader.PerformLayout();
   this.tsButtons.ResumeLayout(false);
   this.tsButtons.PerformLayout();
   this.pnlBody.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.dgJobGrade)).EndInit();
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
  internal System.Windows.Forms.DataGridView dgJobGrade;
  private System.Windows.Forms.DataGridViewTextBoxColumn colJobGrade;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
  private System.Windows.Forms.DataGridViewTextBoxColumn colOrder;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDeductLate;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDeductUndertime;
  private System.Windows.Forms.DataGridViewTextBoxColumn colPayOvertime;
  private System.Windows.Forms.DataGridViewTextBoxColumn colPlantillaHQ;
  private System.Windows.Forms.DataGridViewTextBoxColumn colPlantillaB;
 }
}