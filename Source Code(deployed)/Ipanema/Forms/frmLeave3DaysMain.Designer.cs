namespace Ipanema.Forms
{
    partial class frmLeave3DaysMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeave3DaysMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsButtons = new System.Windows.Forms.ToolStrip();
            this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnClose = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgLeaveList = new System.Windows.Forms.DataGridView();
            this.LeaveCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLeaveList)).BeginInit();
            this.SuspendLayout();
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
            this.tbtnRefresh,
            this.toolStripSeparator3,
            this.tbtnClose});
            this.tsButtons.Location = new System.Drawing.Point(0, 0);
            this.tsButtons.Name = "tsButtons";
            this.tsButtons.Size = new System.Drawing.Size(694, 29);
            this.tsButtons.TabIndex = 22;
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
            this.tbtnClose.Size = new System.Drawing.Size(69, 26);
            this.tbtnClose.Text = " Close ";
            this.tbtnClose.ToolTipText = "Close window";
            this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgLeaveList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 462);
            this.panel2.TabIndex = 28;
            // 
            // dgLeaveList
            // 
            this.dgLeaveList.AllowUserToAddRows = false;
            this.dgLeaveList.AllowUserToDeleteRows = false;
            this.dgLeaveList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgLeaveList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLeaveList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLeaveList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgLeaveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLeaveList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeaveCode,
            this.Username,
            this.EmployeeName,
            this.Units,
            this.DateStart,
            this.DateEnd,
            this.Remarks,
            this.Enabled});
            this.dgLeaveList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgLeaveList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLeaveList.Location = new System.Drawing.Point(0, 0);
            this.dgLeaveList.MultiSelect = false;
            this.dgLeaveList.Name = "dgLeaveList";
            this.dgLeaveList.ReadOnly = true;
            this.dgLeaveList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgLeaveList.RowHeadersWidth = 20;
            this.dgLeaveList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLeaveList.Size = new System.Drawing.Size(694, 462);
            this.dgLeaveList.TabIndex = 24;
            this.dgLeaveList.VirtualMode = true;
            this.dgLeaveList.DoubleClick += new System.EventHandler(this.dgLeaveList_DoubleClick);
            // 
            // LeaveCode
            // 
            this.LeaveCode.DataPropertyName = "LeaveCode";
            this.LeaveCode.HeaderText = "Leave Code";
            this.LeaveCode.Name = "LeaveCode";
            this.LeaveCode.ReadOnly = true;
            this.LeaveCode.Visible = false;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Visible = false;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 250;
            // 
            // Units
            // 
            this.Units.DataPropertyName = "Units";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Units.DefaultCellStyle = dataGridViewCellStyle2;
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            this.Units.Width = 50;
            // 
            // DateStart
            // 
            this.DateStart.DataPropertyName = "DateStart";
            dataGridViewCellStyle3.Format = "MMM dd, yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.DateStart.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateStart.HeaderText = "Date Start";
            this.DateStart.Name = "DateStart";
            this.DateStart.ReadOnly = true;
            // 
            // DateEnd
            // 
            this.DateEnd.DataPropertyName = "DateEnd";
            dataGridViewCellStyle4.Format = "MMM dd, yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.DateEnd.DefaultCellStyle = dataGridViewCellStyle4;
            this.DateEnd.HeaderText = "Date End";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 200;
            // 
            // Enabled
            // 
            this.Enabled.DataPropertyName = "Enabled";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Enabled.DefaultCellStyle = dataGridViewCellStyle5;
            this.Enabled.HeaderText = "Enabled";
            this.Enabled.Name = "Enabled";
            this.Enabled.ReadOnly = true;
            this.Enabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Enabled.Width = 80;
            // 
            // frmLeave3DaysMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tsButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLeave3DaysMain";
            this.Text = "Leave File Master List";
            this.Load += new System.EventHandler(this.frmLeave3DaysMain_Load);
            this.tsButtons.ResumeLayout(false);
            this.tsButtons.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLeaveList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsButtons;
        private System.Windows.Forms.ToolStripButton tbtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtnClose;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.DataGridView dgLeaveList;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enabled;
    }
}