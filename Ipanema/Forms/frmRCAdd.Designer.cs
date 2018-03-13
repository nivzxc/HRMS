namespace Ipanema.Forms
{
 partial class frmRCAdd
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRCAdd));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cmbCompany = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtGPCode = new System.Windows.Forms.TextBox();
      this.txtRCCode = new System.Windows.Forms.TextBox();
      this.chkActive = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtRCName = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.cmbDivision = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.cmbCompany);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.txtGPCode);
      this.groupBox1.Controls.Add(this.txtRCCode);
      this.groupBox1.Controls.Add(this.chkActive);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.txtRCName);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.cmbDivision);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(12, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(417, 181);
      this.groupBox1.TabIndex = 38;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Department Details";
      // 
      // cmbCompany
      // 
      this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbCompany.FormattingEnabled = true;
      this.cmbCompany.Location = new System.Drawing.Point(104, 144);
      this.cmbCompany.Name = "cmbCompany";
      this.cmbCompany.Size = new System.Drawing.Size(300, 23);
      this.cmbCompany.TabIndex = 5;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(13, 148);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(62, 15);
      this.label5.TabIndex = 43;
      this.label5.Text = "Company:";
      // 
      // txtGPCode
      // 
      this.txtGPCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtGPCode.Location = new System.Drawing.Point(105, 115);
      this.txtGPCode.MaxLength = 15;
      this.txtGPCode.Multiline = true;
      this.txtGPCode.Name = "txtGPCode";
      this.txtGPCode.Size = new System.Drawing.Size(213, 21);
      this.txtGPCode.TabIndex = 4;
      // 
      // txtRCCode
      // 
      this.txtRCCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtRCCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRCCode.Location = new System.Drawing.Point(104, 28);
      this.txtRCCode.MaxLength = 3;
      this.txtRCCode.Multiline = true;
      this.txtRCCode.Name = "txtRCCode";
      this.txtRCCode.Size = new System.Drawing.Size(46, 21);
      this.txtRCCode.TabIndex = 0;
      // 
      // chkActive
      // 
      this.chkActive.AutoSize = true;
      this.chkActive.Location = new System.Drawing.Point(156, 30);
      this.chkActive.Name = "chkActive";
      this.chkActive.Size = new System.Drawing.Size(57, 19);
      this.chkActive.TabIndex = 1;
      this.chkActive.Text = "Active";
      this.chkActive.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(13, 117);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 15);
      this.label1.TabIndex = 38;
      this.label1.Text = "GP Code:";
      // 
      // txtRCName
      // 
      this.txtRCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRCName.Location = new System.Drawing.Point(104, 56);
      this.txtRCName.MaxLength = 100;
      this.txtRCName.Multiline = true;
      this.txtRCName.Name = "txtRCName";
      this.txtRCName.Size = new System.Drawing.Size(300, 21);
      this.txtRCName.TabIndex = 2;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(13, 59);
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
      this.cmbDivision.Location = new System.Drawing.Point(104, 84);
      this.cmbDivision.Name = "cmbDivision";
      this.cmbDivision.Size = new System.Drawing.Size(300, 23);
      this.cmbDivision.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(13, 87);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 15);
      this.label3.TabIndex = 32;
      this.label3.Text = "Division:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(13, 31);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 15);
      this.label2.TabIndex = 28;
      this.label2.Text = "Code:";
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
      this.btnClose.Location = new System.Drawing.Point(349, 197);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(80, 38);
      this.btnClose.TabIndex = 7;
      this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnSave
      // 
      this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
      this.btnSave.Location = new System.Drawing.Point(259, 197);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(82, 38);
      this.btnSave.TabIndex = 6;
      this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // frmRCAdd
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.AliceBlue;
      this.CancelButton = this.btnClose;
      this.ClientSize = new System.Drawing.Size(439, 246);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmRCAdd";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Add New RC";
      this.Load += new System.EventHandler(this.frmRCAdd_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.CheckBox chkActive;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtRCName;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.ComboBox cmbDivision;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtRCCode;
  private System.Windows.Forms.ComboBox cmbCompany;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtGPCode;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;

 }
}