namespace Ipanema.Forms
{
    partial class frmTimesheetReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimesheetReport));
            this.tsButtons = new System.Windows.Forms.ToolStrip();
            this.tbtnProcess = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteTimesheet = new System.Windows.Forms.ToolStripButton();
            this.tbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tbtnClose = new System.Windows.Forms.ToolStripButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsButtons.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsButtons
            // 
            this.tsButtons.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButtons.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnProcess,
            this.toolStripSeparator6,
            this.tbtnExportExcel,
            this.btnDeleteTimesheet,
            this.tbtnRefresh,
            this.tbtnClose,
            this.toolStripSeparator7});
            this.tsButtons.Location = new System.Drawing.Point(0, 0);
            this.tsButtons.Name = "tsButtons";
            this.tsButtons.Size = new System.Drawing.Size(1028, 29);
            this.tsButtons.TabIndex = 21;
            this.tsButtons.Text = "OB ToolBar";
            // 
            // tbtnProcess
            // 
            this.tbtnProcess.Image = ((System.Drawing.Image)(resources.GetObject("tbtnProcess.Image")));
            this.tbtnProcess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnProcess.Name = "tbtnProcess";
            this.tbtnProcess.Size = new System.Drawing.Size(74, 26);
            this.tbtnProcess.Text = "Process";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 29);
            // 
            // tbtnExportExcel
            // 
            this.tbtnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("tbtnExportExcel.Image")));
            this.tbtnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExportExcel.Name = "tbtnExportExcel";
            this.tbtnExportExcel.Size = new System.Drawing.Size(117, 26);
            this.tbtnExportExcel.Text = "Export to Excel";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 29);
            // 
            // btnDeleteTimesheet
            // 
            this.btnDeleteTimesheet.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTimesheet.Image")));
            this.btnDeleteTimesheet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTimesheet.Name = "btnDeleteTimesheet";
            this.btnDeleteTimesheet.Size = new System.Drawing.Size(69, 26);
            this.btnDeleteTimesheet.Text = "Delete";
            // 
            // tbtnRefresh
            // 
            this.tbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tbtnRefresh.Image")));
            this.tbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnRefresh.Name = "tbtnRefresh";
            this.tbtnRefresh.Size = new System.Drawing.Size(74, 26);
            this.tbtnRefresh.Text = "Refresh";
            // 
            // tbtnClose
            // 
            this.tbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tbtnClose.Image")));
            this.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnClose.Name = "tbtnClose";
            this.tbtnClose.Size = new System.Drawing.Size(61, 26);
            this.tbtnClose.Text = "Close";
            this.tbtnClose.ToolTipText = "Close window";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Controls.Add(this.groupBox2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 29);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1028, 71);
            this.pnlHeader.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dtpTo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpFrom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 49);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "MMM dd, yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(212, 19);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(99, 21);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.Value = new System.DateTime(2015, 11, 5, 23, 59, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "MMM dd, yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(90, 19);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(99, 21);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.Value = new System.DateTime(2015, 11, 5, 0, 1, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "to";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(0, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 96);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employee No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Employee Name";
            this.Column2.MinimumWidth = 7;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // frmTimesheetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 639);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.tsButtons);
            this.Name = "frmTimesheetReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timesheet Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsButtons.ResumeLayout(false);
            this.tsButtons.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsButtons;
        private System.Windows.Forms.ToolStripButton tbtnProcess;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tbtnExportExcel;
        private System.Windows.Forms.ToolStripButton btnDeleteTimesheet;
        private System.Windows.Forms.ToolStripButton tbtnRefresh;
        private System.Windows.Forms.ToolStripButton tbtnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}