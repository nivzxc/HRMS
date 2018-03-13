namespace Ipanema.Forms
{
 partial class frmClusterAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClusterAdd));
   this.txtClusterName = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.btnClose = new System.Windows.Forms.Button();
   this.txtClusterCode = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtDescription = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
   this.groupBox1.SuspendLayout();
   this.tableLayoutPanel1.SuspendLayout();
   this.SuspendLayout();
   // 
   // txtClusterName
   // 
   this.txtClusterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtClusterName.Location = new System.Drawing.Point(101, 35);
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
   this.label4.Location = new System.Drawing.Point(4, 39);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(85, 15);
   this.label4.TabIndex = 36;
   this.label4.Text = "Cluster Name:";
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(347, 214);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(79, 38);
   this.btnClose.TabIndex = 4;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
   this.btnClose.UseVisualStyleBackColor = true;
   // 
   // txtClusterCode
   // 
   this.txtClusterCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtClusterCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtClusterCode.Location = new System.Drawing.Point(101, 4);
   this.txtClusterCode.Name = "txtClusterCode";
   this.txtClusterCode.ReadOnly = true;
   this.txtClusterCode.Size = new System.Drawing.Size(88, 21);
   this.txtClusterCode.TabIndex = 1;
   this.txtClusterCode.TabStop = false;
   // 
   // label2
   // 
   this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(4, 8);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(39, 15);
   this.label2.TabIndex = 28;
   this.label2.Text = "Code:";
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(259, 214);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 3;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.tableLayoutPanel1);
   this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox1.Location = new System.Drawing.Point(11, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(413, 197);
   this.groupBox1.TabIndex = 40;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Cluster Details";
   // 
   // txtDescription
   // 
   this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtDescription.Location = new System.Drawing.Point(101, 66);
   this.txtDescription.MaxLength = 0;
   this.txtDescription.Multiline = true;
   this.txtDescription.Name = "txtDescription";
   this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtDescription.Size = new System.Drawing.Size(276, 88);
   this.txtDescription.TabIndex = 1;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(4, 66);
   this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(72, 15);
   this.label1.TabIndex = 41;
   this.label1.Text = "Description:";
   // 
   // tableLayoutPanel1
   // 
   this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
   this.tableLayoutPanel1.ColumnCount = 2;
   this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
   this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
   this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 2);
   this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
   this.tableLayoutPanel1.Controls.Add(this.txtClusterName, 1, 1);
   this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
   this.tableLayoutPanel1.Controls.Add(this.txtClusterCode, 1, 0);
   this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
   this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 25);
   this.tableLayoutPanel1.Name = "tableLayoutPanel1";
   this.tableLayoutPanel1.RowCount = 3;
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
   this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
   this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 158);
   this.tableLayoutPanel1.TabIndex = 41;
   // 
   // frmClusterAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(435, 265);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmClusterAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add New Employee Cluster";
   this.Load += new System.EventHandler(this.frmClusterAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.tableLayoutPanel1.ResumeLayout(false);
   this.tableLayoutPanel1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.TextBox txtClusterName;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.TextBox txtClusterCode;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtDescription;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

 }
}