namespace Ipanema.Forms
{
 partial class frmDepartmentEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmentEdit));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartmentCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabDepartment = new System.Windows.Forms.TabControl();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.tpApprovers = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lvApprovers = new System.Windows.Forms.ListView();
            this.chApproverID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chApprover = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLeave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUndertime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOvertime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabDepartment.SuspendLayout();
            this.tpDetails.SuspendLayout();
            this.tpApprovers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(376, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 39);
            this.btnClose.TabIndex = 39;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(287, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 39);
            this.btnSave.TabIndex = 38;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(188, 14);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(57, 19);
            this.chkActive.TabIndex = 40;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(90, 95);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(240, 23);
            this.cmbGroup.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Group:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(90, 39);
            this.txtDepartment.MaxLength = 50;
            this.txtDepartment.Multiline = true;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(228, 21);
            this.txtDepartment.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Department:";
            // 
            // cmbDivision
            // 
            this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(90, 66);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(240, 23);
            this.cmbDivision.TabIndex = 1;
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Division:";
            // 
            // txtDepartmentCode
            // 
            this.txtDepartmentCode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDepartmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentCode.Location = new System.Drawing.Point(90, 12);
            this.txtDepartmentCode.Name = "txtDepartmentCode";
            this.txtDepartmentCode.ReadOnly = true;
            this.txtDepartmentCode.Size = new System.Drawing.Size(88, 21);
            this.txtDepartmentCode.TabIndex = 1;
            this.txtDepartmentCode.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Code:";
            // 
            // tabDepartment
            // 
            this.tabDepartment.Controls.Add(this.tpDetails);
            this.tabDepartment.Controls.Add(this.tpApprovers);
            this.tabDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDepartment.Location = new System.Drawing.Point(9, 8);
            this.tabDepartment.Name = "tabDepartment";
            this.tabDepartment.SelectedIndex = 0;
            this.tabDepartment.Size = new System.Drawing.Size(455, 384);
            this.tabDepartment.TabIndex = 41;
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.chkActive);
            this.tpDetails.Controls.Add(this.cmbGroup);
            this.tpDetails.Controls.Add(this.txtDepartmentCode);
            this.tpDetails.Controls.Add(this.label1);
            this.tpDetails.Controls.Add(this.label2);
            this.tpDetails.Controls.Add(this.txtDepartment);
            this.tpDetails.Controls.Add(this.label3);
            this.tpDetails.Controls.Add(this.label4);
            this.tpDetails.Controls.Add(this.cmbDivision);
            this.tpDetails.Location = new System.Drawing.Point(4, 24);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(447, 356);
            this.tpDetails.TabIndex = 0;
            this.tpDetails.Text = "Department Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // tpApprovers
            // 
            this.tpApprovers.Controls.Add(this.btnDelete);
            this.tpApprovers.Controls.Add(this.btnEdit);
            this.tpApprovers.Controls.Add(this.btnAdd);
            this.tpApprovers.Controls.Add(this.label5);
            this.tpApprovers.Controls.Add(this.lvApprovers);
            this.tpApprovers.Location = new System.Drawing.Point(4, 24);
            this.tpApprovers.Name = "tpApprovers";
            this.tpApprovers.Padding = new System.Windows.Forms.Padding(3);
            this.tpApprovers.Size = new System.Drawing.Size(447, 356);
            this.tpApprovers.TabIndex = 1;
            this.tpApprovers.Text = " Approvers ";
            this.tpApprovers.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(370, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 27);
            this.btnDelete.TabIndex = 82;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(304, 320);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 27);
            this.btnEdit.TabIndex = 81;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(238, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 27);
            this.btnAdd.TabIndex = 80;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 15);
            this.label5.TabIndex = 79;
            this.label5.Text = "List of Department Approvers";
            // 
            // lvApprovers
            // 
            this.lvApprovers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chApproverID,
            this.chApprover,
            this.chLeave,
            this.chUndertime,
            this.chOvertime,
            this.chOB});
            this.lvApprovers.FullRowSelect = true;
            this.lvApprovers.GridLines = true;
            this.lvApprovers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvApprovers.HideSelection = false;
            this.lvApprovers.Location = new System.Drawing.Point(3, 28);
            this.lvApprovers.MultiSelect = false;
            this.lvApprovers.Name = "lvApprovers";
            this.lvApprovers.Size = new System.Drawing.Size(440, 280);
            this.lvApprovers.TabIndex = 78;
            this.lvApprovers.UseCompatibleStateImageBehavior = false;
            this.lvApprovers.View = System.Windows.Forms.View.Details;
            this.lvApprovers.DoubleClick += new System.EventHandler(this.lvApprovers_DoubleClick);
            // 
            // chApproverID
            // 
            this.chApproverID.Text = "ID";
            this.chApproverID.Width = 45;
            // 
            // chApprover
            // 
            this.chApprover.Text = "Approver";
            this.chApprover.Width = 190;
            // 
            // chLeave
            // 
            this.chLeave.Text = "L";
            this.chLeave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chLeave.Width = 50;
            // 
            // chUndertime
            // 
            this.chUndertime.Text = "U";
            this.chUndertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chUndertime.Width = 50;
            // 
            // chOvertime
            // 
            this.chOvertime.Text = "OT";
            this.chOvertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOvertime.Width = 50;
            // 
            // chOB
            // 
            this.chOB.Text = "OB";
            this.chOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOB.Width = 50;
            // 
            // frmDepartmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(473, 444);
            this.Controls.Add(this.tabDepartment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDepartmentEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Department Details";
            this.Load += new System.EventHandler(this.frmDepartmentEdit_Load);
            this.tabDepartment.ResumeLayout(false);
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.tpApprovers.ResumeLayout(false);
            this.tpApprovers.PerformLayout();
            this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.ComboBox cmbGroup;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtDepartment;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.ComboBox cmbDivision;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtDepartmentCode;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.CheckBox chkActive;
  private System.Windows.Forms.TabControl tabDepartment;
  private System.Windows.Forms.TabPage tpDetails;
  private System.Windows.Forms.TabPage tpApprovers;
  private System.Windows.Forms.ListView lvApprovers;
  private System.Windows.Forms.ColumnHeader chApprover;
  private System.Windows.Forms.ColumnHeader chLeave;
  private System.Windows.Forms.Button btnDelete;
  private System.Windows.Forms.Button btnEdit;
  private System.Windows.Forms.Button btnAdd;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.ColumnHeader chUndertime;
  private System.Windows.Forms.ColumnHeader chOvertime;
  private System.Windows.Forms.ColumnHeader chOB;
        private System.Windows.Forms.ColumnHeader chApproverID;
    }
}