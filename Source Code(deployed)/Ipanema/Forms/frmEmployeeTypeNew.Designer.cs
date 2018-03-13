namespace Ipanema.Forms
{
 partial class frmEmployeeTypeNew
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeTypeNew));
   this.txtDetails = new System.Windows.Forms.TextBox();
   this.label1 = new System.Windows.Forms.Label();
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.label2 = new System.Windows.Forms.Label();
   this.txtType = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // txtDetails
   // 
   this.txtDetails.Location = new System.Drawing.Point(60, 42);
   this.txtDetails.MaxLength = 50;
   this.txtDetails.Multiline = true;
   this.txtDetails.Name = "txtDetails";
   this.txtDetails.Size = new System.Drawing.Size(251, 75);
   this.txtDetails.TabIndex = 1;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(10, 16);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(36, 15);
   this.label1.TabIndex = 1;
   this.label1.Text = "Type:";
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(235, 125);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(78, 38);
   this.btnClose.TabIndex = 3;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(145, 125);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(79, 38);
   this.btnSave.TabIndex = 2;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(10, 44);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(48, 15);
   this.label2.TabIndex = 12;
   this.label2.Text = "Details:";
   // 
   // txtType
   // 
   this.txtType.Location = new System.Drawing.Point(60, 13);
   this.txtType.MaxLength = 20;
   this.txtType.Name = "txtType";
   this.txtType.Size = new System.Drawing.Size(251, 21);
   this.txtType.TabIndex = 0;
   // 
   // frmEmployeeTypeNew
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(324, 171);
   this.Controls.Add(this.txtType);
   this.Controls.Add(this.label2);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.txtDetails);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmEmployeeTypeNew";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Add New Employee Type";
   this.Load += new System.EventHandler(this.frmEmployeeTypeNew_Load);
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.TextBox txtDetails;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.TextBox txtType;
 }
}