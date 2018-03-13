namespace Ipanema.Forms
{
 partial class frmTimeCardList
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeCardList));
   this.pnlHeader = new System.Windows.Forms.Panel();
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
   this.dtpTo = new System.Windows.Forms.DateTimePicker();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.label3 = new System.Windows.Forms.Label();
   this.dtpFrom = new System.Windows.Forms.DateTimePicker();
   this.pnlBody = new System.Windows.Forms.Panel();
   this.lvwTimeCard = new System.Windows.Forms.ListView();
   this.chUsername = new System.Windows.Forms.ColumnHeader();
   this.chFocusDate = new System.Windows.Forms.ColumnHeader();
   this.chKeyIn = new System.Windows.Forms.ColumnHeader();
   this.chKeyOut = new System.Windows.Forms.ColumnHeader();
   this.chUpdateBy = new System.Windows.Forms.ColumnHeader();
   this.cmsTimeCardList = new System.Windows.Forms.ContextMenuStrip(this.components);
   this.tmiAdd = new System.Windows.Forms.ToolStripMenuItem();
   this.tmiEdit = new System.Windows.Forms.ToolStripMenuItem();
   this.tmiDelete = new System.Windows.Forms.ToolStripMenuItem();
   this.tmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
   this.pnlHeader.SuspendLayout();
   this.tsButtons.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
   this.pnlBody.SuspendLayout();
   this.cmsTimeCardList.SuspendLayout();
   this.SuspendLayout();
   // 
   // pnlHeader
   // 
   this.pnlHeader.BackColor = System.Drawing.Color.White;
   this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
   this.pnlHeader.Controls.Add(this.cmbEmployee);
   this.pnlHeader.Controls.Add(this.label15);
   this.pnlHeader.Controls.Add(this.tsButtons);
   this.pnlHeader.Controls.Add(this.label5);
   this.pnlHeader.Controls.Add(this.dtpTo);
   this.pnlHeader.Controls.Add(this.pictureBox1);
   this.pnlHeader.Controls.Add(this.label3);
   this.pnlHeader.Controls.Add(this.dtpFrom);
   this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
   this.pnlHeader.Location = new System.Drawing.Point(0, 0);
   this.pnlHeader.Name = "pnlHeader";
   this.pnlHeader.Size = new System.Drawing.Size(931, 68);
   this.pnlHeader.TabIndex = 0;
   // 
   // cmbEmployee
   // 
   this.cmbEmployee.DropDownHeight = 200;
   this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbEmployee.FormattingEnabled = true;
   this.cmbEmployee.IntegralHeight = false;
   this.cmbEmployee.Location = new System.Drawing.Point(110, 37);
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
   this.label15.Location = new System.Drawing.Point(40, 41);
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
   this.tsButtons.Size = new System.Drawing.Size(931, 29);
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
   this.tbtnAdd.Click += new System.EventHandler(this.tmiAdd_Click);
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
   this.tbtnEdit.Click += new System.EventHandler(this.tmiEdit_Click);
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
   this.tbtnDelete.Click += new System.EventHandler(this.tmiDelete_Click);
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
   this.tbtnRefresh.Click += new System.EventHandler(this.tmiRefresh_Click);
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
   this.label5.Location = new System.Drawing.Point(582, 42);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(11, 15);
   this.label5.TabIndex = 10;
   this.label5.Text = "-";
   // 
   // dtpTo
   // 
   this.dtpTo.CustomFormat = "MMM dd, yyyy";
   this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpTo.Location = new System.Drawing.Point(596, 39);
   this.dtpTo.Name = "dtpTo";
   this.dtpTo.Size = new System.Drawing.Size(101, 21);
   this.dtpTo.TabIndex = 2;
   this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
   // 
   // pictureBox1
   // 
   this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
   this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(8, 37);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(22, 22);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
   this.pictureBox1.TabIndex = 8;
   this.pictureBox1.TabStop = false;
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.BackColor = System.Drawing.Color.Transparent;
   this.label3.Location = new System.Drawing.Point(382, 41);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(92, 15);
   this.label3.TabIndex = 6;
   this.label3.Text = "Inclusive Dates:";
   // 
   // dtpFrom
   // 
   this.dtpFrom.CustomFormat = "MMM dd, yyyy";
   this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpFrom.Location = new System.Drawing.Point(477, 39);
   this.dtpFrom.Name = "dtpFrom";
   this.dtpFrom.Size = new System.Drawing.Size(101, 21);
   this.dtpFrom.TabIndex = 1;
   this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
   // 
   // pnlBody
   // 
   this.pnlBody.Controls.Add(this.lvwTimeCard);
   this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlBody.Location = new System.Drawing.Point(0, 68);
   this.pnlBody.Name = "pnlBody";
   this.pnlBody.Size = new System.Drawing.Size(931, 464);
   this.pnlBody.TabIndex = 1;
   // 
   // lvwTimeCard
   // 
   this.lvwTimeCard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUsername,
            this.chFocusDate,
            this.chKeyIn,
            this.chKeyOut,
            this.chUpdateBy});
   this.lvwTimeCard.ContextMenuStrip = this.cmsTimeCardList;
   this.lvwTimeCard.Dock = System.Windows.Forms.DockStyle.Fill;
   this.lvwTimeCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lvwTimeCard.FullRowSelect = true;
   this.lvwTimeCard.GridLines = true;
   this.lvwTimeCard.HideSelection = false;
   this.lvwTimeCard.Location = new System.Drawing.Point(0, 0);
   this.lvwTimeCard.MultiSelect = false;
   this.lvwTimeCard.Name = "lvwTimeCard";
   this.lvwTimeCard.Size = new System.Drawing.Size(931, 464);
   this.lvwTimeCard.TabIndex = 3;
   this.lvwTimeCard.TabStop = false;
   this.lvwTimeCard.UseCompatibleStateImageBehavior = false;
   this.lvwTimeCard.View = System.Windows.Forms.View.Details;
   this.lvwTimeCard.DoubleClick += new System.EventHandler(this.lvwTimeCard_DoubleClick);
   this.lvwTimeCard.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwTimeCard_ColumnClick);
   this.lvwTimeCard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvwTimeCard_KeyUp);
   // 
   // chUsername
   // 
   this.chUsername.Text = "Employee";
   this.chUsername.Width = 250;
   // 
   // chFocusDate
   // 
   this.chFocusDate.Text = "Focus Date";
   this.chFocusDate.Width = 120;
   // 
   // chKeyIn
   // 
   this.chKeyIn.Text = "Key In";
   this.chKeyIn.Width = 70;
   // 
   // chKeyOut
   // 
   this.chKeyOut.Text = "Key Out";
   this.chKeyOut.Width = 170;
   // 
   // chUpdateBy
   // 
   this.chUpdateBy.Text = "Update By";
   this.chUpdateBy.Width = 150;
   // 
   // cmsTimeCardList
   // 
   this.cmsTimeCardList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiAdd,
            this.tmiEdit,
            this.tmiDelete,
            this.tmiRefresh});
   this.cmsTimeCardList.Name = "cmsTimeCardList";
   this.cmsTimeCardList.Size = new System.Drawing.Size(124, 92);
   // 
   // tmiAdd
   // 
   this.tmiAdd.Image = ((System.Drawing.Image)(resources.GetObject("tmiAdd.Image")));
   this.tmiAdd.Name = "tmiAdd";
   this.tmiAdd.Size = new System.Drawing.Size(123, 22);
   this.tmiAdd.Text = "Add";
   this.tmiAdd.Click += new System.EventHandler(this.tmiAdd_Click);
   // 
   // tmiEdit
   // 
   this.tmiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tmiEdit.Image")));
   this.tmiEdit.Name = "tmiEdit";
   this.tmiEdit.Size = new System.Drawing.Size(123, 22);
   this.tmiEdit.Text = "Edit";
   this.tmiEdit.Click += new System.EventHandler(this.tmiEdit_Click);
   // 
   // tmiDelete
   // 
   this.tmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tmiDelete.Image")));
   this.tmiDelete.Name = "tmiDelete";
   this.tmiDelete.Size = new System.Drawing.Size(123, 22);
   this.tmiDelete.Text = "Delete";
   this.tmiDelete.Click += new System.EventHandler(this.tmiDelete_Click);
   // 
   // tmiRefresh
   // 
   this.tmiRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tmiRefresh.Image")));
   this.tmiRefresh.Name = "tmiRefresh";
   this.tmiRefresh.Size = new System.Drawing.Size(123, 22);
   this.tmiRefresh.Text = "Refresh";
   this.tmiRefresh.Click += new System.EventHandler(this.tmiRefresh_Click);
   // 
   // frmTimeCardList
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(931, 532);
   this.Controls.Add(this.pnlBody);
   this.Controls.Add(this.pnlHeader);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.Name = "frmTimeCardList";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Time Card Masterlist";
   this.Load += new System.EventHandler(this.frmTimeCardList_Load);
   this.pnlHeader.ResumeLayout(false);
   this.pnlHeader.PerformLayout();
   this.tsButtons.ResumeLayout(false);
   this.tsButtons.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
   this.pnlBody.ResumeLayout(false);
   this.cmsTimeCardList.ResumeLayout(false);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel pnlHeader;
  private System.Windows.Forms.Panel pnlBody;
  private System.Windows.Forms.ListView lvwTimeCard;
  private System.Windows.Forms.DateTimePicker dtpFrom;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.PictureBox pictureBox1;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.DateTimePicker dtpTo;
  private System.Windows.Forms.ColumnHeader chUsername;
  private System.Windows.Forms.ColumnHeader chFocusDate;
  private System.Windows.Forms.ColumnHeader chKeyIn;
  private System.Windows.Forms.ColumnHeader chKeyOut;
  private System.Windows.Forms.ContextMenuStrip cmsTimeCardList;
  private System.Windows.Forms.ToolStripMenuItem tmiAdd;
  private System.Windows.Forms.ToolStripMenuItem tmiEdit;
  private System.Windows.Forms.ToolStripMenuItem tmiDelete;
  private System.Windows.Forms.ToolStripMenuItem tmiRefresh;
  private System.Windows.Forms.ColumnHeader chUpdateBy;
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
  private System.Windows.Forms.ComboBox cmbEmployee;
  private System.Windows.Forms.Label label15;
 }
}