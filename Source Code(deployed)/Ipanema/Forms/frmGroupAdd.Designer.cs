namespace Ipanema.Forms
{
 partial class frmGroupAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGroupAdd));
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.cmbDivision = new System.Windows.Forms.ComboBox();
   this.label4 = new System.Windows.Forms.Label();
   this.txtGroupName = new System.Windows.Forms.TextBox();
   this.label2 = new System.Windows.Forms.Label();
   this.txtGroupCode = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.cmbDivision);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.txtGroupName);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.txtGroupCode);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(12, 7);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(416, 112);
   this.groupBox1.TabIndex = 1;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Group Details";
   // 
   // cmbDivision
   // 
   this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbDivision.FormattingEnabled = true;
   this.cmbDivision.Location = new System.Drawing.Point(103, 76);
   this.cmbDivision.Name = "cmbDivision";
   this.cmbDivision.Size = new System.Drawing.Size(273, 23);
   this.cmbDivision.TabIndex = 3;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(12, 80);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(53, 15);
   this.label4.TabIndex = 6;
   this.label4.Text = "Division:";
   // 
   // txtGroupName
   // 
   this.txtGroupName.Location = new System.Drawing.Point(103, 48);
   this.txtGroupName.MaxLength = 50;
   this.txtGroupName.Name = "txtGroupName";
   this.txtGroupName.Size = new System.Drawing.Size(301, 21);
   this.txtGroupName.TabIndex = 0;
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(12, 51);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(81, 15);
   this.label2.TabIndex = 2;
   this.label2.Text = "Group Name:";
   // 
   // txtGroupCode
   // 
   this.txtGroupCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtGroupCode.Location = new System.Drawing.Point(103, 19);
   this.txtGroupCode.MaxLength = 6;
   this.txtGroupCode.Name = "txtGroupCode";
   this.txtGroupCode.ReadOnly = true;
   this.txtGroupCode.Size = new System.Drawing.Size(87, 21);
   this.txtGroupCode.TabIndex = 0;
   this.txtGroupCode.TabStop = false;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 23);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(76, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Group Code:";
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(355, 128);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(76, 38);
   this.btnClose.TabIndex = 5;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(273, 128);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(76, 38);
   this.btnSave.TabIndex = 4;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // frmGroupAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(440, 176);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmGroupAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Add New Group";
   this.Load += new System.EventHandler(this.frmGroupAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.ComboBox cmbDivision;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtGroupName;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtGroupCode;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
 }
}