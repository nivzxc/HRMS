namespace Ipanema.Forms
{
 partial class frmEmployeeTitleNew
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeTitleNew));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.label1 = new System.Windows.Forms.Label();
   this.txtTitle = new System.Windows.Forms.TextBox();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnClose.Location = new System.Drawing.Point(168, 37);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(75, 30);
   this.btnClose.TabIndex = 2;
   this.btnClose.Text = "Close  ";
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSave.Location = new System.Drawing.Point(88, 37);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(75, 30);
   this.btnSave.TabIndex = 1;
   this.btnSave.Text = "Save   ";
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(7, 13);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(30, 13);
   this.label1.TabIndex = 13;
   this.label1.Text = "Title:";
   // 
   // txtTitle
   // 
   this.txtTitle.Location = new System.Drawing.Point(42, 11);
   this.txtTitle.MaxLength = 20;
   this.txtTitle.Name = "txtTitle";
   this.txtTitle.Size = new System.Drawing.Size(201, 20);
   this.txtTitle.TabIndex = 0;
   this.txtTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTitle_KeyDown);
   // 
   // frmEmployeeTitleNew
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(253, 77);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.txtTitle);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmEmployeeTitleNew";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Add New Employee Title";
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtTitle;
 }
}