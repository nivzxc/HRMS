namespace Ipanema.Forms
{
 partial class frmLeaveEntitlementProcess
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeaveEntitlementProcess));
   this.pnlFooter = new System.Windows.Forms.Panel();
   this.lnkUnSelectAll = new System.Windows.Forms.LinkLabel();
   this.lnkSelectAll = new System.Windows.Forms.LinkLabel();
   this.lblRecordsFound = new System.Windows.Forms.Label();
   this.lvEmployee = new System.Windows.Forms.ListView();
   this.chEmployee = new System.Windows.Forms.ColumnHeader();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.btnClose = new System.Windows.Forms.Button();
   this.btnProcess = new System.Windows.Forms.Button();
   this.cmbLeaveType = new System.Windows.Forms.ComboBox();
   this.label1 = new System.Windows.Forms.Label();
   this.txtMaxBalance = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.pnlFooter.SuspendLayout();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // pnlFooter
   // 
   this.pnlFooter.BackColor = System.Drawing.Color.AliceBlue;
   this.pnlFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFooter.BackgroundImage")));
   this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
   this.pnlFooter.Controls.Add(this.lnkUnSelectAll);
   this.pnlFooter.Controls.Add(this.lnkSelectAll);
   this.pnlFooter.Controls.Add(this.lblRecordsFound);
   this.pnlFooter.Location = new System.Drawing.Point(15, 448);
   this.pnlFooter.Name = "pnlFooter";
   this.pnlFooter.Size = new System.Drawing.Size(400, 26);
   this.pnlFooter.TabIndex = 2;
   // 
   // lnkUnSelectAll
   // 
   this.lnkUnSelectAll.AutoSize = true;
   this.lnkUnSelectAll.BackColor = System.Drawing.Color.Transparent;
   this.lnkUnSelectAll.Location = new System.Drawing.Point(325, 4);
   this.lnkUnSelectAll.Name = "lnkUnSelectAll";
   this.lnkUnSelectAll.Size = new System.Drawing.Size(71, 15);
   this.lnkUnSelectAll.TabIndex = 2;
   this.lnkUnSelectAll.TabStop = true;
   this.lnkUnSelectAll.Text = "Unselect All";
   this.lnkUnSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUnSelectAll_LinkClicked);
   // 
   // lnkSelectAll
   // 
   this.lnkSelectAll.AutoSize = true;
   this.lnkSelectAll.BackColor = System.Drawing.Color.Transparent;
   this.lnkSelectAll.Location = new System.Drawing.Point(264, 4);
   this.lnkSelectAll.Name = "lnkSelectAll";
   this.lnkSelectAll.Size = new System.Drawing.Size(57, 15);
   this.lnkSelectAll.TabIndex = 1;
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
   this.lblRecordsFound.Size = new System.Drawing.Size(118, 15);
   this.lblRecordsFound.TabIndex = 0;
   this.lblRecordsFound.Text = "0 total records found";
   // 
   // lvEmployee
   // 
   this.lvEmployee.CheckBoxes = true;
   this.lvEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmployee});
   this.lvEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lvEmployee.FullRowSelect = true;
   this.lvEmployee.GridLines = true;
   this.lvEmployee.HideSelection = false;
   this.lvEmployee.Location = new System.Drawing.Point(15, 85);
   this.lvEmployee.MultiSelect = false;
   this.lvEmployee.Name = "lvEmployee";
   this.lvEmployee.Size = new System.Drawing.Size(400, 364);
   this.lvEmployee.TabIndex = 3;
   this.lvEmployee.UseCompatibleStateImageBehavior = false;
   this.lvEmployee.View = System.Windows.Forms.View.Details;
   // 
   // chEmployee
   // 
   this.chEmployee.Text = "Employee";
   this.chEmployee.Width = 379;
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.txtMaxBalance);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Controls.Add(this.cmbLeaveType);
   this.groupBox1.Controls.Add(this.lvEmployee);
   this.groupBox1.Controls.Add(this.pnlFooter);
   this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox1.Location = new System.Drawing.Point(11, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(430, 485);
   this.groupBox1.TabIndex = 4;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Leave Processing Details";
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(362, 500);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 4;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnProcess
   // 
   this.btnProcess.Image = ((System.Drawing.Image)(resources.GetObject("btnProcess.Image")));
   this.btnProcess.Location = new System.Drawing.Point(252, 500);
   this.btnProcess.Name = "btnProcess";
   this.btnProcess.Size = new System.Drawing.Size(102, 38);
   this.btnProcess.TabIndex = 3;
   this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnProcess.UseVisualStyleBackColor = true;
   this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
   // 
   // cmbLeaveType
   // 
   this.cmbLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbLeaveType.FormattingEnabled = true;
   this.cmbLeaveType.Location = new System.Drawing.Point(101, 27);
   this.cmbLeaveType.Name = "cmbLeaveType";
   this.cmbLeaveType.Size = new System.Drawing.Size(314, 23);
   this.cmbLeaveType.TabIndex = 0;
   this.cmbLeaveType.SelectedIndexChanged += new System.EventHandler(this.cmbLeaveType_SelectedIndexChanged);
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.BackColor = System.Drawing.Color.Transparent;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(15, 31);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(72, 15);
   this.label1.TabIndex = 5;
   this.label1.Text = "Leave Type:";
   // 
   // txtMaxBalance
   // 
   this.txtMaxBalance.BackColor = System.Drawing.Color.AliceBlue;
   this.txtMaxBalance.Location = new System.Drawing.Point(101, 56);
   this.txtMaxBalance.Name = "txtMaxBalance";
   this.txtMaxBalance.ReadOnly = true;
   this.txtMaxBalance.Size = new System.Drawing.Size(100, 21);
   this.txtMaxBalance.TabIndex = 6;
   this.txtMaxBalance.TabStop = false;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.BackColor = System.Drawing.Color.Transparent;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(17, 58);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(82, 15);
   this.label2.TabIndex = 7;
   this.label2.Text = "Max Balance:";
   // 
   // frmLeaveEntitlementProcess
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(454, 546);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnProcess);
   this.Controls.Add(this.groupBox1);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmLeaveEntitlementProcess";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Leave Entitlement Processing";
   this.Load += new System.EventHandler(this.frmLeaveEntitlementProcess_Load);
   this.pnlFooter.ResumeLayout(false);
   this.pnlFooter.PerformLayout();
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.ListView lvEmployee;
  private System.Windows.Forms.ColumnHeader chEmployee;
  private System.Windows.Forms.Panel pnlFooter;
  private System.Windows.Forms.Label lblRecordsFound;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.LinkLabel lnkUnSelectAll;
  private System.Windows.Forms.LinkLabel lnkSelectAll;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnProcess;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtMaxBalance;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.ComboBox cmbLeaveType;
 }
}