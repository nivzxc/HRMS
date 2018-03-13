namespace Ipanema.Forms
{
 partial class frmClusterEdit
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClusterEdit));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtDateModified = new System.Windows.Forms.TextBox();
   this.label7 = new System.Windows.Forms.Label();
   this.txtModifiedBy = new System.Windows.Forms.TextBox();
   this.label6 = new System.Windows.Forms.Label();
   this.txtCreateDate = new System.Windows.Forms.TextBox();
   this.label5 = new System.Windows.Forms.Label();
   this.txtCreatedBy = new System.Windows.Forms.TextBox();
   this.label3 = new System.Windows.Forms.Label();
   this.txtDescription = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.chkEnabled = new System.Windows.Forms.CheckBox();
   this.txtClusterName = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.txtClusterCode = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
   this.groupBox1.SuspendLayout();
   this.tableLayoutPanel1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(356, 348);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 42;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(266, 348);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 41;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.tableLayoutPanel1);
   this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox1.Location = new System.Drawing.Point(8, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(426, 332);
   this.groupBox1.TabIndex = 43;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Cluster Details";
   // 
   // txtDateModified
   // 
   this.txtDateModified.BackColor = System.Drawing.Color.AliceBlue;
   this.txtDateModified.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDateModified.Location = new System.Drawing.Point(113, 263);
   this.txtDateModified.MaxLength = 50;
   this.txtDateModified.Multiline = true;
   this.txtDateModified.Name = "txtDateModified";
   this.txtDateModified.ReadOnly = true;
   this.txtDateModified.Size = new System.Drawing.Size(157, 21);
   this.txtDateModified.TabIndex = 48;
   this.txtDateModified.TabStop = false;
   // 
   // label7
   // 
   this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label7.AutoSize = true;
   this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label7.Location = new System.Drawing.Point(4, 268);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(87, 15);
   this.label7.TabIndex = 49;
   this.label7.Text = "Date Modified:";
   // 
   // txtModifiedBy
   // 
   this.txtModifiedBy.BackColor = System.Drawing.Color.AliceBlue;
   this.txtModifiedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtModifiedBy.Location = new System.Drawing.Point(113, 234);
   this.txtModifiedBy.MaxLength = 50;
   this.txtModifiedBy.Multiline = true;
   this.txtModifiedBy.Name = "txtModifiedBy";
   this.txtModifiedBy.ReadOnly = true;
   this.txtModifiedBy.Size = new System.Drawing.Size(276, 21);
   this.txtModifiedBy.TabIndex = 46;
   this.txtModifiedBy.TabStop = false;
   // 
   // label6
   // 
   this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label6.AutoSize = true;
   this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label6.Location = new System.Drawing.Point(4, 237);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(74, 15);
   this.label6.TabIndex = 47;
   this.label6.Text = "Modified By:";
   // 
   // txtCreateDate
   // 
   this.txtCreateDate.BackColor = System.Drawing.Color.AliceBlue;
   this.txtCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtCreateDate.Location = new System.Drawing.Point(113, 205);
   this.txtCreateDate.MaxLength = 50;
   this.txtCreateDate.Multiline = true;
   this.txtCreateDate.Name = "txtCreateDate";
   this.txtCreateDate.ReadOnly = true;
   this.txtCreateDate.Size = new System.Drawing.Size(157, 21);
   this.txtCreateDate.TabIndex = 44;
   this.txtCreateDate.TabStop = false;
   // 
   // label5
   // 
   this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label5.AutoSize = true;
   this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label5.Location = new System.Drawing.Point(4, 208);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(82, 15);
   this.label5.TabIndex = 45;
   this.label5.Text = "Date Created:";
   // 
   // txtCreatedBy
   // 
   this.txtCreatedBy.BackColor = System.Drawing.Color.AliceBlue;
   this.txtCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtCreatedBy.Location = new System.Drawing.Point(113, 176);
   this.txtCreatedBy.MaxLength = 50;
   this.txtCreatedBy.Multiline = true;
   this.txtCreatedBy.Name = "txtCreatedBy";
   this.txtCreatedBy.ReadOnly = true;
   this.txtCreatedBy.Size = new System.Drawing.Size(276, 21);
   this.txtCreatedBy.TabIndex = 42;
   this.txtCreatedBy.TabStop = false;
   // 
   // label3
   // 
   this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(4, 179);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(69, 15);
   this.label3.TabIndex = 43;
   this.label3.Text = "Created By:";
   // 
   // txtDescription
   // 
   this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDescription.Location = new System.Drawing.Point(113, 62);
   this.txtDescription.MaxLength = 0;
   this.txtDescription.Multiline = true;
   this.txtDescription.Name = "txtDescription";
   this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtDescription.Size = new System.Drawing.Size(276, 78);
   this.txtDescription.TabIndex = 1;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(4, 62);
   this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(72, 15);
   this.label1.TabIndex = 41;
   this.label1.Text = "Description:";
   // 
   // chkEnabled
   // 
   this.chkEnabled.AutoSize = true;
   this.chkEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.chkEnabled.Location = new System.Drawing.Point(113, 147);
   this.chkEnabled.Name = "chkEnabled";
   this.chkEnabled.Size = new System.Drawing.Size(72, 19);
   this.chkEnabled.TabIndex = 2;
   this.chkEnabled.Text = "Enabled";
   this.chkEnabled.UseVisualStyleBackColor = true;
   // 
   // txtClusterName
   // 
   this.txtClusterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtClusterName.Location = new System.Drawing.Point(113, 33);
   this.txtClusterName.MaxLength = 50;
   this.txtClusterName.Multiline = true;
   this.txtClusterName.Name = "txtClusterName";
   this.txtClusterName.Size = new System.Drawing.Size(276, 21);
   this.txtClusterName.TabIndex = 0;
   // 
   // label4
   // 
   this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label4.AutoSize = true;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(4, 36);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(85, 15);
   this.label4.TabIndex = 36;
   this.label4.Text = "Cluster Name:";
   // 
   // txtClusterCode
   // 
   this.txtClusterCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtClusterCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtClusterCode.Location = new System.Drawing.Point(113, 4);
   this.txtClusterCode.Name = "txtClusterCode";
   this.txtClusterCode.ReadOnly = true;
   this.txtClusterCode.Size = new System.Drawing.Size(59, 21);
   this.txtClusterCode.TabIndex = 1;
   this.txtClusterCode.TabStop = false;
   // 
   // label2
   // 
   this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(4, 7);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(39, 15);
   this.label2.TabIndex = 28;
   this.label2.Text = "Code:";
   // 
   // tableLayoutPanel1
   // 
   this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
   this.tableLayoutPanel1.ColumnCount = 2;
   this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
   this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
   this.tableLayoutPanel1.Controls.Add(this.txtDateModified, 1, 7);
   this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
   this.tableLayoutPanel1.Controls.Add(this.txtModifiedBy, 1, 6);
   this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
   this.tableLayoutPanel1.Controls.Add(this.txtCreateDate, 1, 5);
   this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
   this.tableLayoutPanel1.Controls.Add(this.txtCreatedBy, 1, 4);
   this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
   this.tableLayoutPanel1.Controls.Add(this.chkEnabled, 1, 3);
   this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 2);
   this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
   this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
   this.tableLayoutPanel1.Controls.Add(this.txtClusterName, 1, 1);
   this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
   this.tableLayoutPanel1.Controls.Add(this.txtClusterCode, 1, 0);
   this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 24);
   this.tableLayoutPanel1.Name = "tableLayoutPanel1";
   this.tableLayoutPanel1.RowCount = 8;
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
   this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 292);
   this.tableLayoutPanel1.TabIndex = 44;
   // 
   // frmClusterEdit
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(448, 398);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmClusterEdit";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Edit Employee Cluster";
   this.Load += new System.EventHandler(this.frmClusterEdit_Load);
   this.groupBox1.ResumeLayout(false);
   this.tableLayoutPanel1.ResumeLayout(false);
   this.tableLayoutPanel1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtDateModified;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.TextBox txtModifiedBy;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox txtCreateDate;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtCreatedBy;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtDescription;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.CheckBox chkEnabled;
  private System.Windows.Forms.TextBox txtClusterName;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtClusterCode;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

 }
}