namespace Ipanema.Forms
{
 partial class frmResignationReasonAdd
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResignationReasonAdd));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.chkEnabled = new System.Windows.Forms.CheckBox();
   this.txtCode = new System.Windows.Forms.TextBox();
   this.label5 = new System.Windows.Forms.Label();
   this.txtReason = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.groupBox1.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(381, 126);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(81, 38);
   this.btnClose.TabIndex = 3;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(293, 126);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(81, 38);
   this.btnSave.TabIndex = 2;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.chkEnabled);
   this.groupBox1.Controls.Add(this.txtCode);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.txtReason);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Location = new System.Drawing.Point(12, 6);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(448, 109);
   this.groupBox1.TabIndex = 0;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Resignation Reason Details";
   // 
   // chkEnabled
   // 
   this.chkEnabled.AutoSize = true;
   this.chkEnabled.Location = new System.Drawing.Point(66, 79);
   this.chkEnabled.Name = "chkEnabled";
   this.chkEnabled.Size = new System.Drawing.Size(72, 19);
   this.chkEnabled.TabIndex = 1;
   this.chkEnabled.Text = "Enabled";
   this.chkEnabled.UseVisualStyleBackColor = true;
   // 
   // txtCode
   // 
   this.txtCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtCode.Location = new System.Drawing.Point(66, 26);
   this.txtCode.MaxLength = 8;
   this.txtCode.Name = "txtCode";
   this.txtCode.ReadOnly = true;
   this.txtCode.Size = new System.Drawing.Size(56, 20);
   this.txtCode.TabIndex = 0;
   this.txtCode.TabStop = false;
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Location = new System.Drawing.Point(9, 27);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(39, 15);
   this.label5.TabIndex = 9;
   this.label5.Text = "Code:";
   // 
   // txtReason
   // 
   this.txtReason.AcceptsReturn = true;
   this.txtReason.Location = new System.Drawing.Point(66, 53);
   this.txtReason.MaxLength = 50;
   this.txtReason.Name = "txtReason";
   this.txtReason.Size = new System.Drawing.Size(368, 21);
   this.txtReason.TabIndex = 0;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(9, 57);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(53, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Reason:";
   // 
   // frmResignationReasonAdd
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(471, 177);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.groupBox1);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmResignationReasonAdd";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Resignation Reason Add";
   this.Load += new System.EventHandler(this.frmResignationReasonAdd_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.CheckBox chkEnabled;
  private System.Windows.Forms.TextBox txtCode;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.TextBox txtReason;
  private System.Windows.Forms.Label label1;
 }
}