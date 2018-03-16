namespace Ipanema.Forms
{
 partial class frmClusterMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClusterMembers));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLTotal = new System.Windows.Forms.Label();
            this.lblIncludedTotal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnIncludeAll = new System.Windows.Forms.Button();
            this.btnExcludeAll = new System.Windows.Forms.Button();
            this.btnInclude = new System.Windows.Forms.Button();
            this.btnExclude = new System.Windows.Forms.Button();
            this.lvLEmployee = new System.Windows.Forms.ListView();
            this.chLEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLJGC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvIEmployee = new System.Windows.Forms.ListView();
            this.chIEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIEJGCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIEType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(857, 36);
            this.pnlHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Edit Cluster Members";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFooter.BackgroundImage")));
            this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFooter.Controls.Add(this.pictureBox2);
            this.pnlFooter.Controls.Add(this.pictureBox1);
            this.pnlFooter.Controls.Add(this.lblLTotal);
            this.pnlFooter.Controls.Add(this.lblIncludedTotal);
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 466);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(857, 62);
            this.pnlFooter.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(461, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // lblLTotal
            // 
            this.lblLTotal.AutoSize = true;
            this.lblLTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblLTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLTotal.Location = new System.Drawing.Point(479, 4);
            this.lblLTotal.Name = "lblLTotal";
            this.lblLTotal.Size = new System.Drawing.Size(96, 15);
            this.lblLTotal.TabIndex = 52;
            this.lblLTotal.Text = "Total Records";
            // 
            // lblIncludedTotal
            // 
            this.lblIncludedTotal.AutoSize = true;
            this.lblIncludedTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblIncludedTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncludedTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIncludedTotal.Location = new System.Drawing.Point(23, 4);
            this.lblIncludedTotal.Name = "lblIncludedTotal";
            this.lblIncludedTotal.Size = new System.Drawing.Size(96, 15);
            this.lblIncludedTotal.TabIndex = 51;
            this.lblIncludedTotal.Text = "Total Records";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(766, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 38);
            this.btnClose.TabIndex = 50;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.btnIncludeAll);
            this.pnlBody.Controls.Add(this.btnExcludeAll);
            this.pnlBody.Controls.Add(this.btnInclude);
            this.pnlBody.Controls.Add(this.btnExclude);
            this.pnlBody.Controls.Add(this.lvLEmployee);
            this.pnlBody.Controls.Add(this.lvIEmployee);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 36);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(857, 430);
            this.pnlBody.TabIndex = 2;
            // 
            // btnIncludeAll
            // 
            this.btnIncludeAll.Image = ((System.Drawing.Image)(resources.GetObject("btnIncludeAll.Image")));
            this.btnIncludeAll.Location = new System.Drawing.Point(411, 211);
            this.btnIncludeAll.Name = "btnIncludeAll";
            this.btnIncludeAll.Size = new System.Drawing.Size(35, 35);
            this.btnIncludeAll.TabIndex = 9;
            this.btnIncludeAll.UseVisualStyleBackColor = true;
            this.btnIncludeAll.Click += new System.EventHandler(this.btnIncludeAll_Click);
            // 
            // btnExcludeAll
            // 
            this.btnExcludeAll.Image = ((System.Drawing.Image)(resources.GetObject("btnExcludeAll.Image")));
            this.btnExcludeAll.Location = new System.Drawing.Point(411, 255);
            this.btnExcludeAll.Name = "btnExcludeAll";
            this.btnExcludeAll.Size = new System.Drawing.Size(35, 35);
            this.btnExcludeAll.TabIndex = 8;
            this.btnExcludeAll.UseVisualStyleBackColor = true;
            this.btnExcludeAll.Click += new System.EventHandler(this.btnExcludeAll_Click);
            // 
            // btnInclude
            // 
            this.btnInclude.Image = ((System.Drawing.Image)(resources.GetObject("btnInclude.Image")));
            this.btnInclude.Location = new System.Drawing.Point(411, 113);
            this.btnInclude.Name = "btnInclude";
            this.btnInclude.Size = new System.Drawing.Size(35, 35);
            this.btnInclude.TabIndex = 7;
            this.btnInclude.UseVisualStyleBackColor = true;
            this.btnInclude.Click += new System.EventHandler(this.btnInclude_Click);
            // 
            // btnExclude
            // 
            this.btnExclude.Image = ((System.Drawing.Image)(resources.GetObject("btnExclude.Image")));
            this.btnExclude.Location = new System.Drawing.Point(411, 156);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(35, 35);
            this.btnExclude.TabIndex = 6;
            this.btnExclude.UseVisualStyleBackColor = true;
            this.btnExclude.Click += new System.EventHandler(this.btnExclude_Click);
            // 
            // lvLEmployee
            // 
            this.lvLEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLEmployee,
            this.colLJGC,
            this.colLType});
            this.lvLEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvLEmployee.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvLEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLEmployee.FullRowSelect = true;
            this.lvLEmployee.GridLines = true;
            this.lvLEmployee.HideSelection = false;
            this.lvLEmployee.Location = new System.Drawing.Point(457, 0);
            this.lvLEmployee.MultiSelect = false;
            this.lvLEmployee.Name = "lvLEmployee";
            this.lvLEmployee.Size = new System.Drawing.Size(400, 430);
            this.lvLEmployee.TabIndex = 5;
            this.lvLEmployee.UseCompatibleStateImageBehavior = false;
            this.lvLEmployee.View = System.Windows.Forms.View.Details;
            this.lvLEmployee.DoubleClick += new System.EventHandler(this.btnInclude_Click);
            // 
            // chLEmployee
            // 
            this.chLEmployee.Text = "Not Included Employees";
            this.chLEmployee.Width = 210;
            // 
            // colLJGC
            // 
            this.colLJGC.Text = "JGC";
            // 
            // colLType
            // 
            this.colLType.Text = "Type";
            this.colLType.Width = 108;
            // 
            // lvIEmployee
            // 
            this.lvIEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIEmployee,
            this.colIEJGCode,
            this.colIEType});
            this.lvIEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvIEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvIEmployee.FullRowSelect = true;
            this.lvIEmployee.GridLines = true;
            this.lvIEmployee.HideSelection = false;
            this.lvIEmployee.Location = new System.Drawing.Point(0, 0);
            this.lvIEmployee.MultiSelect = false;
            this.lvIEmployee.Name = "lvIEmployee";
            this.lvIEmployee.Size = new System.Drawing.Size(400, 430);
            this.lvIEmployee.TabIndex = 4;
            this.lvIEmployee.UseCompatibleStateImageBehavior = false;
            this.lvIEmployee.View = System.Windows.Forms.View.Details;
            this.lvIEmployee.DoubleClick += new System.EventHandler(this.btnExclude_Click);
            // 
            // chIEmployee
            // 
            this.chIEmployee.Text = "Included Employees";
            this.chIEmployee.Width = 210;
            // 
            // colIEJGCode
            // 
            this.colIEJGCode.Text = "JGC";
            // 
            // colIEType
            // 
            this.colIEType.Text = "Type";
            this.colIEType.Width = 108;
            // 
            // frmClusterMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(857, 528);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClusterMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Cluster Members";
            this.Load += new System.EventHandler(this.frmClusterMembers_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel pnlHeader;
  private System.Windows.Forms.Panel pnlFooter;
  private System.Windows.Forms.Panel pnlBody;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.ListView lvLEmployee;
  private System.Windows.Forms.ColumnHeader chLEmployee;
  private System.Windows.Forms.ListView lvIEmployee;
  private System.Windows.Forms.ColumnHeader chIEmployee;
  private System.Windows.Forms.Button btnInclude;
  private System.Windows.Forms.Button btnExclude;
  private System.Windows.Forms.Button btnIncludeAll;
  private System.Windows.Forms.Button btnExcludeAll;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.ColumnHeader colIEJGCode;
  private System.Windows.Forms.ColumnHeader colIEType;
  private System.Windows.Forms.ColumnHeader colLJGC;
  private System.Windows.Forms.ColumnHeader colLType;
  private System.Windows.Forms.Label lblLTotal;
  private System.Windows.Forms.Label lblIncludedTotal;
  private System.Windows.Forms.PictureBox pictureBox1;
  private System.Windows.Forms.PictureBox pictureBox2;
 }
}