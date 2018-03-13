namespace Ipanema.Forms
{
    partial class frmLeaveSettingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaveSettingList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsButton = new System.Windows.Forms.ToolStrip();
            this.tbtnLeaveSetting = new System.Windows.Forms.ToolStripButton();
            this.tbtnClose = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgLeaveList = new System.Windows.Forms.DataGridView();
            this.leavname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLeaveList)).BeginInit();
            this.SuspendLayout();
            // 
            // tsButton
            // 
            this.tsButton.BackColor = System.Drawing.SystemColors.Control;
            this.tsButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsButton.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnLeaveSetting,
            this.tbtnClose});
            this.tsButton.Location = new System.Drawing.Point(0, 0);
            this.tsButton.Name = "tsButton";
            this.tsButton.Size = new System.Drawing.Size(439, 29);
            this.tsButton.TabIndex = 1;
            this.tsButton.Text = "Leave Setting Toolbar";
            // 
            // tbtnLeaveSetting
            // 
            this.tbtnLeaveSetting.Image = ((System.Drawing.Image)(resources.GetObject("tbtnLeaveSetting.Image")));
            this.tbtnLeaveSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnLeaveSetting.Name = "tbtnLeaveSetting";
            this.tbtnLeaveSetting.Size = new System.Drawing.Size(58, 26);
            this.tbtnLeaveSetting.Text = " Edit";
            this.tbtnLeaveSetting.ToolTipText = "Modify";
            this.tbtnLeaveSetting.Click += new System.EventHandler(this.tbtnLeaveSetting_Click);
            // 
            // tbtnClose
            // 
            this.tbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tbtnClose.Image")));
            this.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnClose.Name = "tbtnClose";
            this.tbtnClose.Size = new System.Drawing.Size(65, 26);
            this.tbtnClose.Text = " Close";
            this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(350, 167);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLeaveList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgLeaveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLeaveList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leavname,
            this.ltdesc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLeaveList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgLeaveList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgLeaveList.Location = new System.Drawing.Point(0, 29);
            this.dgLeaveList.MultiSelect = false;
            this.dgLeaveList.Name = "dgLeaveList";
            this.dgLeaveList.ReadOnly = true;
            this.dgLeaveList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgLeaveList.RowHeadersWidth = 20;
            this.dgLeaveList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgLeaveList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLeaveList.Size = new System.Drawing.Size(439, 132);
            this.dgLeaveList.TabIndex = 3;
            this.dgLeaveList.VirtualMode = true;
            this.dgLeaveList.DoubleClick += new System.EventHandler(this.dgLeaveList_DoubleClick);
            // 
            // leavname
            // 
            this.leavname.HeaderText = "Leave Name";
            this.leavname.Name = "leavname";
            this.leavname.ReadOnly = true;
            this.leavname.Width = 130;
            // 
            // ltdesc
            // 
            this.ltdesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ltdesc.HeaderText = "Leave with pay";
            this.ltdesc.Name = "ltdesc";
            this.ltdesc.ReadOnly = true;
            this.ltdesc.Width = 230;
            // 
            // frmLeaveSettingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::Ipanema.Properties.Resources.panelheader;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 207);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgLeaveList);
            this.Controls.Add(this.tsButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLeaveSettingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification Leave Balance Setting";
            this.Load += new System.EventHandler(this.frmLeaveSettingList_Load);
            this.tsButton.ResumeLayout(false);
            this.tsButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLeaveList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsButton;
        private System.Windows.Forms.ToolStripButton tbtnLeaveSetting;
        private System.Windows.Forms.ToolStripButton tbtnClose;
        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.DataGridView dgLeaveList;
        private System.Windows.Forms.DataGridViewTextBoxColumn leavname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltdesc;
    }
}