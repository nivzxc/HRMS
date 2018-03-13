namespace Ipanema.Forms
{
    partial class frmDepartmentApproverEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmentApproverEdit));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEmployee = new System.Windows.Forms.TextBox();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.tbApprvID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkOB = new System.Windows.Forms.CheckBox();
            this.chkOvertime = new System.Windows.Forms.CheckBox();
            this.chkUndertime = new System.Windows.Forms.CheckBox();
            this.chkLeave = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(355, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close  ";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(249, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save   ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEmployee);
            this.groupBox1.Controls.Add(this.tbDepartment);
            this.groupBox1.Controls.Add(this.tbApprvID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkOB);
            this.groupBox1.Controls.Add(this.chkOvertime);
            this.groupBox1.Controls.Add(this.chkUndertime);
            this.groupBox1.Controls.Add(this.chkLeave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 202);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Approver Details";
            // 
            // tbEmployee
            // 
            this.tbEmployee.Enabled = false;
            this.tbEmployee.Location = new System.Drawing.Point(92, 92);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.Size = new System.Drawing.Size(305, 21);
            this.tbEmployee.TabIndex = 9;
            // 
            // tbDepartment
            // 
            this.tbDepartment.Enabled = false;
            this.tbDepartment.Location = new System.Drawing.Point(92, 65);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(305, 21);
            this.tbDepartment.TabIndex = 8;
            // 
            // tbApprvID
            // 
            this.tbApprvID.Enabled = false;
            this.tbApprvID.Location = new System.Drawing.Point(92, 37);
            this.tbApprvID.Name = "tbApprvID";
            this.tbApprvID.Size = new System.Drawing.Size(131, 21);
            this.tbApprvID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Approver ID:";
            // 
            // chkOB
            // 
            this.chkOB.AutoSize = true;
            this.chkOB.Location = new System.Drawing.Point(250, 150);
            this.chkOB.Name = "chkOB";
            this.chkOB.Size = new System.Drawing.Size(115, 19);
            this.chkOB.TabIndex = 5;
            this.chkOB.Text = "Can Approve OB";
            this.chkOB.UseVisualStyleBackColor = true;
            // 
            // chkOvertime
            // 
            this.chkOvertime.AutoSize = true;
            this.chkOvertime.Location = new System.Drawing.Point(250, 121);
            this.chkOvertime.Name = "chkOvertime";
            this.chkOvertime.Size = new System.Drawing.Size(147, 19);
            this.chkOvertime.TabIndex = 4;
            this.chkOvertime.Text = "Can Approve Overtime";
            this.chkOvertime.UseVisualStyleBackColor = true;
            // 
            // chkUndertime
            // 
            this.chkUndertime.AutoSize = true;
            this.chkUndertime.Location = new System.Drawing.Point(92, 150);
            this.chkUndertime.Name = "chkUndertime";
            this.chkUndertime.Size = new System.Drawing.Size(156, 19);
            this.chkUndertime.TabIndex = 3;
            this.chkUndertime.Text = "Can Approve Undertime";
            this.chkUndertime.UseVisualStyleBackColor = true;
            // 
            // chkLeave
            // 
            this.chkLeave.AutoSize = true;
            this.chkLeave.Location = new System.Drawing.Point(92, 121);
            this.chkLeave.Name = "chkLeave";
            this.chkLeave.Size = new System.Drawing.Size(131, 19);
            this.chkLeave.TabIndex = 2;
            this.chkLeave.Text = "Can Approve Leave";
            this.chkLeave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee:";
            // 
            // frmDepartmentApproverEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(443, 258);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDepartmentApproverEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Department Approver";
            this.Load += new System.EventHandler(this.frmDepartmentApproverEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbApprvID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkOB;
        private System.Windows.Forms.CheckBox chkOvertime;
        private System.Windows.Forms.CheckBox chkUndertime;
        private System.Windows.Forms.CheckBox chkLeave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmployee;
        private System.Windows.Forms.TextBox tbDepartment;
    }
}