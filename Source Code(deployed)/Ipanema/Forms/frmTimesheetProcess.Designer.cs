namespace Ipanema.Forms
{
 partial class frmTimesheetProcess
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimesheetProcess));
   this.dtpStart = new System.Windows.Forms.DateTimePicker();
   this.dtpEnd = new System.Windows.Forms.DateTimePicker();
   this.label1 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.btnResetPeriod = new System.Windows.Forms.Button();
   this.btnClose = new System.Windows.Forms.Button();
   this.btnProcess = new System.Windows.Forms.Button();
   this.lvEmployee = new System.Windows.Forms.ListView();
   this.chEmpNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.chDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.chJobGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.cmsTimesheet = new System.Windows.Forms.ContextMenuStrip(this.components);
   this.tsmiViewProfile = new System.Windows.Forms.ToolStripMenuItem();
   this.tsmiTimesheet = new System.Windows.Forms.ToolStripMenuItem();
   this.groupBox3 = new System.Windows.Forms.GroupBox();
   this.txtLastName = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.cmbCluster = new System.Windows.Forms.ComboBox();
   this.pnlFooter = new System.Windows.Forms.Panel();
   this.lnkUnSelectAll = new System.Windows.Forms.LinkLabel();
   this.lnkSelectAll = new System.Windows.Forms.LinkLabel();
   this.lblRecordsFound = new System.Windows.Forms.Label();
   this.cmsTimesheet.SuspendLayout();
   this.groupBox3.SuspendLayout();
   this.pnlFooter.SuspendLayout();
   this.SuspendLayout();
   // 
   // dtpStart
   // 
   this.dtpStart.CustomFormat = "MMM dd, yyyy";
   this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpStart.Location = new System.Drawing.Point(140, 25);
   this.dtpStart.Name = "dtpStart";
   this.dtpStart.Size = new System.Drawing.Size(105, 21);
   this.dtpStart.TabIndex = 0;
   // 
   // dtpEnd
   // 
   this.dtpEnd.CustomFormat = "MMM dd, yyyy";
   this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
   this.dtpEnd.Location = new System.Drawing.Point(274, 25);
   this.dtpEnd.Name = "dtpEnd";
   this.dtpEnd.Size = new System.Drawing.Size(105, 21);
   this.dtpEnd.TabIndex = 1;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(13, 28);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(80, 15);
   this.label1.TabIndex = 2;
   this.label1.Text = "Date Bracket:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(249, 28);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(21, 15);
   this.label2.TabIndex = 3;
   this.label2.Text = "To";
   // 
   // btnResetPeriod
   // 
   this.btnResetPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnResetPeriod.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPeriod.Image")));
   this.btnResetPeriod.Location = new System.Drawing.Point(387, 22);
   this.btnResetPeriod.Name = "btnResetPeriod";
   this.btnResetPeriod.Size = new System.Drawing.Size(26, 26);
   this.btnResetPeriod.TabIndex = 2;
   this.btnResetPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnResetPeriod.UseVisualStyleBackColor = true;
   this.btnResetPeriod.Click += new System.EventHandler(this.btnResetPeriod_Click);
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(717, 535);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 39);
   this.btnClose.TabIndex = 8;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnProcess
   // 
   this.btnProcess.Image = ((System.Drawing.Image)(resources.GetObject("btnProcess.Image")));
   this.btnProcess.Location = new System.Drawing.Point(603, 535);
   this.btnProcess.Name = "btnProcess";
   this.btnProcess.Size = new System.Drawing.Size(104, 39);
   this.btnProcess.TabIndex = 7;
   this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnProcess.UseVisualStyleBackColor = true;
   this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
   // 
   // lvEmployee
   // 
   this.lvEmployee.CheckBoxes = true;
   this.lvEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmpNum,
            this.chName,
            this.chStatus,
            this.chDepartment,
            this.chJobGrade});
   this.lvEmployee.ContextMenuStrip = this.cmsTimesheet;
   this.lvEmployee.FullRowSelect = true;
   this.lvEmployee.GridLines = true;
   this.lvEmployee.Location = new System.Drawing.Point(14, 115);
   this.lvEmployee.MultiSelect = false;
   this.lvEmployee.Name = "lvEmployee";
   this.lvEmployee.Size = new System.Drawing.Size(754, 363);
   this.lvEmployee.TabIndex = 0;
   this.lvEmployee.UseCompatibleStateImageBehavior = false;
   this.lvEmployee.View = System.Windows.Forms.View.Details;
   this.lvEmployee.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvEmployee_ColumnClick);
   // 
   // chEmpNum
   // 
   this.chEmpNum.Text = "Number";
   this.chEmpNum.Width = 65;
   // 
   // chName
   // 
   this.chName.Text = "Name";
   this.chName.Width = 230;
   // 
   // chStatus
   // 
   this.chStatus.Text = "Status";
   this.chStatus.Width = 102;
   // 
   // chDepartment
   // 
   this.chDepartment.Text = "Department";
   this.chDepartment.Width = 275;
   // 
   // chJobGrade
   // 
   this.chJobGrade.Text = "JG";
   // 
   // cmsTimesheet
   // 
   this.cmsTimesheet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewProfile,
            this.tsmiTimesheet});
   this.cmsTimesheet.Name = "cmsTimesheet";
   this.cmsTimesheet.Size = new System.Drawing.Size(160, 48);
   // 
   // tsmiViewProfile
   // 
   this.tsmiViewProfile.Image = ((System.Drawing.Image)(resources.GetObject("tsmiViewProfile.Image")));
   this.tsmiViewProfile.Name = "tsmiViewProfile";
   this.tsmiViewProfile.Size = new System.Drawing.Size(159, 22);
   this.tsmiViewProfile.Text = "View Profile";
   this.tsmiViewProfile.Click += new System.EventHandler(this.btnEmpProfile_Click);
   // 
   // tsmiTimesheet
   // 
   this.tsmiTimesheet.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTimesheet.Image")));
   this.tsmiTimesheet.Name = "tsmiTimesheet";
   this.tsmiTimesheet.Size = new System.Drawing.Size(159, 22);
   this.tsmiTimesheet.Text = "View Timesheet";
   this.tsmiTimesheet.Click += new System.EventHandler(this.btnViewTimesheet_Click);
   // 
   // groupBox3
   // 
   this.groupBox3.Controls.Add(this.txtLastName);
   this.groupBox3.Controls.Add(this.label3);
   this.groupBox3.Controls.Add(this.label2);
   this.groupBox3.Controls.Add(this.btnResetPeriod);
   this.groupBox3.Controls.Add(this.dtpEnd);
   this.groupBox3.Controls.Add(this.label1);
   this.groupBox3.Controls.Add(this.label4);
   this.groupBox3.Controls.Add(this.dtpStart);
   this.groupBox3.Controls.Add(this.cmbCluster);
   this.groupBox3.Controls.Add(this.lvEmployee);
   this.groupBox3.Controls.Add(this.pnlFooter);
   this.groupBox3.Location = new System.Drawing.Point(11, 7);
   this.groupBox3.Name = "groupBox3";
   this.groupBox3.Size = new System.Drawing.Size(784, 516);
   this.groupBox3.TabIndex = 13;
   this.groupBox3.TabStop = false;
   this.groupBox3.Text = "Employee List";
   // 
   // txtLastName
   // 
   this.txtLastName.Location = new System.Drawing.Point(140, 83);
   this.txtLastName.Name = "txtLastName";
   this.txtLastName.Size = new System.Drawing.Size(198, 21);
   this.txtLastName.TabIndex = 4;
   this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Location = new System.Drawing.Point(14, 86);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(112, 15);
   this.label3.TabIndex = 11;
   this.label3.Text = "Last Name Search:";
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(13, 57);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(106, 15);
   this.label4.TabIndex = 8;
   this.label4.Text = "Employee Cluster:";
   // 
   // cmbCluster
   // 
   this.cmbCluster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbCluster.FormattingEnabled = true;
   this.cmbCluster.Location = new System.Drawing.Point(140, 53);
   this.cmbCluster.Name = "cmbCluster";
   this.cmbCluster.Size = new System.Drawing.Size(419, 23);
   this.cmbCluster.TabIndex = 3;
   this.cmbCluster.SelectedIndexChanged += new System.EventHandler(this.cmbCluster_SelectedIndexChanged);
   // 
   // pnlFooter
   // 
   this.pnlFooter.BackColor = System.Drawing.Color.AliceBlue;
   this.pnlFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFooter.BackgroundImage")));
   this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
   this.pnlFooter.Controls.Add(this.lnkUnSelectAll);
   this.pnlFooter.Controls.Add(this.lnkSelectAll);
   this.pnlFooter.Controls.Add(this.lblRecordsFound);
   this.pnlFooter.Location = new System.Drawing.Point(14, 477);
   this.pnlFooter.Name = "pnlFooter";
   this.pnlFooter.Size = new System.Drawing.Size(754, 26);
   this.pnlFooter.TabIndex = 10;
   // 
   // lnkUnSelectAll
   // 
   this.lnkUnSelectAll.AutoSize = true;
   this.lnkUnSelectAll.BackColor = System.Drawing.Color.Transparent;
   this.lnkUnSelectAll.Location = new System.Drawing.Point(676, 4);
   this.lnkUnSelectAll.Name = "lnkUnSelectAll";
   this.lnkUnSelectAll.Size = new System.Drawing.Size(71, 15);
   this.lnkUnSelectAll.TabIndex = 6;
   this.lnkUnSelectAll.TabStop = true;
   this.lnkUnSelectAll.Text = "Unselect All";
   this.lnkUnSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUnSelectAll_LinkClicked);
   // 
   // lnkSelectAll
   // 
   this.lnkSelectAll.AutoSize = true;
   this.lnkSelectAll.BackColor = System.Drawing.Color.Transparent;
   this.lnkSelectAll.Location = new System.Drawing.Point(615, 4);
   this.lnkSelectAll.Name = "lnkSelectAll";
   this.lnkSelectAll.Size = new System.Drawing.Size(57, 15);
   this.lnkSelectAll.TabIndex = 5;
   this.lnkSelectAll.TabStop = true;
   this.lnkSelectAll.Text = "Select All";
   this.lnkSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
   // 
   // lblRecordsFound
   // 
   this.lblRecordsFound.AutoSize = true;
   this.lblRecordsFound.BackColor = System.Drawing.Color.Transparent;
   this.lblRecordsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lblRecordsFound.Location = new System.Drawing.Point(5, 4);
   this.lblRecordsFound.Name = "lblRecordsFound";
   this.lblRecordsFound.Size = new System.Drawing.Size(92, 15);
   this.lblRecordsFound.TabIndex = 0;
   this.lblRecordsFound.Text = "0 records found";
   // 
   // frmTimesheetProcess
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(807, 586);
   this.Controls.Add(this.groupBox3);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnProcess);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmTimesheetProcess";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Timesheet Processing";
   this.Load += new System.EventHandler(this.frmTimesheetProcess_Load);
   this.cmsTimesheet.ResumeLayout(false);
   this.groupBox3.ResumeLayout(false);
   this.groupBox3.PerformLayout();
   this.pnlFooter.ResumeLayout(false);
   this.pnlFooter.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.DateTimePicker dtpStart;
  private System.Windows.Forms.DateTimePicker dtpEnd;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnProcess;
  private System.Windows.Forms.ListView lvEmployee;
  private System.Windows.Forms.ColumnHeader chEmpNum;
  private System.Windows.Forms.ColumnHeader chName;
  private System.Windows.Forms.GroupBox groupBox3;
  private System.Windows.Forms.Button btnResetPeriod;
  private System.Windows.Forms.ContextMenuStrip cmsTimesheet;
  private System.Windows.Forms.ToolStripMenuItem tsmiViewProfile;
  private System.Windows.Forms.ColumnHeader chStatus;
  private System.Windows.Forms.ColumnHeader chDepartment;
  private System.Windows.Forms.ToolStripMenuItem tsmiTimesheet;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.ComboBox cmbCluster;
  private System.Windows.Forms.ColumnHeader chJobGrade;
  private System.Windows.Forms.Panel pnlFooter;
  private System.Windows.Forms.LinkLabel lnkUnSelectAll;
  private System.Windows.Forms.LinkLabel lnkSelectAll;
  private System.Windows.Forms.Label lblRecordsFound;
  private System.Windows.Forms.TextBox txtLastName;
  private System.Windows.Forms.Label label3;
 }
}