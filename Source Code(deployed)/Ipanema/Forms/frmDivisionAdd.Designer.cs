﻿namespace Ipanema.Forms
{
 partial class frmDivisionAdd
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDivisionAdd));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtDivisionShortName = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.cmbDivisionHead = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtDescription = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtDivisionName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDivisionCode = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtDivisionShortName);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.cmbDivisionHead);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.txtDescription);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txtDivisionName);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtDivisionCode);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(13, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(423, 202);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Division Details";
      // 
      // txtDivisionShortName
      // 
      this.txtDivisionShortName.Location = new System.Drawing.Point(111, 74);
      this.txtDivisionShortName.MaxLength = 10;
      this.txtDivisionShortName.Name = "txtDivisionShortName";
      this.txtDivisionShortName.Size = new System.Drawing.Size(101, 21);
      this.txtDivisionShortName.TabIndex = 7;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(13, 77);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(76, 15);
      this.label5.TabIndex = 8;
      this.label5.Text = "Short Name:";
      // 
      // cmbDivisionHead
      // 
      this.cmbDivisionHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbDivisionHead.FormattingEnabled = true;
      this.cmbDivisionHead.Location = new System.Drawing.Point(111, 168);
      this.cmbDivisionHead.Name = "cmbDivisionHead";
      this.cmbDivisionHead.Size = new System.Drawing.Size(300, 23);
      this.cmbDivisionHead.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 173);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(86, 15);
      this.label4.TabIndex = 6;
      this.label4.Text = "Division Head:";
      // 
      // txtDescription
      // 
      this.txtDescription.Location = new System.Drawing.Point(111, 102);
      this.txtDescription.MaxLength = 255;
      this.txtDescription.Multiline = true;
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtDescription.Size = new System.Drawing.Size(300, 60);
      this.txtDescription.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 101);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(72, 15);
      this.label3.TabIndex = 4;
      this.label3.Text = "Description:";
      // 
      // txtDivisionName
      // 
      this.txtDivisionName.Location = new System.Drawing.Point(111, 47);
      this.txtDivisionName.MaxLength = 50;
      this.txtDivisionName.Name = "txtDivisionName";
      this.txtDivisionName.Size = new System.Drawing.Size(300, 21);
      this.txtDivisionName.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 50);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 15);
      this.label2.TabIndex = 2;
      this.label2.Text = "Division Name:";
      // 
      // txtDivisionCode
      // 
      this.txtDivisionCode.BackColor = System.Drawing.Color.White;
      this.txtDivisionCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDivisionCode.Location = new System.Drawing.Point(111, 20);
      this.txtDivisionCode.MaxLength = 6;
      this.txtDivisionCode.Name = "txtDivisionCode";
      this.txtDivisionCode.Size = new System.Drawing.Size(101, 21);
      this.txtDivisionCode.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(85, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Division Code:";
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
      this.btnClose.Location = new System.Drawing.Point(356, 217);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(80, 38);
      this.btnClose.TabIndex = 6;
      this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnSave
      // 
      this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
      this.btnSave.Location = new System.Drawing.Point(267, 217);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(80, 38);
      this.btnSave.TabIndex = 5;
      this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // frmDivisionAdd
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.AliceBlue;
      this.CancelButton = this.btnClose;
      this.ClientSize = new System.Drawing.Size(447, 264);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmDivisionAdd";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Add New Division";
      this.Load += new System.EventHandler(this.frmDivisionAdd_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.ComboBox cmbDivisionHead;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox txtDescription;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.TextBox txtDivisionName;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtDivisionCode;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.TextBox txtDivisionShortName;
  private System.Windows.Forms.Label label5;
 }
}