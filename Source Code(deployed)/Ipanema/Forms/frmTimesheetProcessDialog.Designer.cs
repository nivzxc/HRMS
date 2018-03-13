namespace Ipanema.Forms
{
 partial class frmTimesheetProcessDialog
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimesheetProcessDialog));
   this.lblProcessRemarks = new System.Windows.Forms.Label();
   this.prgTimeSheet = new System.Windows.Forms.ProgressBar();
   this.lblProcessEmployee = new System.Windows.Forms.Label();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.btnCancel = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
   this.SuspendLayout();
   // 
   // lblProcessRemarks
   // 
   this.lblProcessRemarks.AutoSize = true;
   this.lblProcessRemarks.Location = new System.Drawing.Point(59, 70);
   this.lblProcessRemarks.Name = "lblProcessRemarks";
   this.lblProcessRemarks.Size = new System.Drawing.Size(108, 15);
   this.lblProcessRemarks.TabIndex = 15;
   this.lblProcessRemarks.Text = "Processing 1 out 9";
   // 
   // prgTimeSheet
   // 
   this.prgTimeSheet.Location = new System.Drawing.Point(60, 38);
   this.prgTimeSheet.Name = "prgTimeSheet";
   this.prgTimeSheet.Size = new System.Drawing.Size(348, 28);
   this.prgTimeSheet.TabIndex = 13;
   // 
   // lblProcessEmployee
   // 
   this.lblProcessEmployee.AutoSize = true;
   this.lblProcessEmployee.Location = new System.Drawing.Point(59, 16);
   this.lblProcessEmployee.Name = "lblProcessEmployee";
   this.lblProcessEmployee.Size = new System.Drawing.Size(133, 15);
   this.lblProcessEmployee.TabIndex = 16;
   this.lblProcessEmployee.Text = "Processing Mily Opena";
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(10, 16);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(32, 32);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
   this.pictureBox1.TabIndex = 17;
   this.pictureBox1.TabStop = false;
   // 
   // btnCancel
   // 
   this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
   this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnCancel.Location = new System.Drawing.Point(332, 76);
   this.btnCancel.Name = "btnCancel";
   this.btnCancel.Size = new System.Drawing.Size(77, 30);
   this.btnCancel.TabIndex = 18;
   this.btnCancel.Text = "Cancel";
   this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnCancel.UseVisualStyleBackColor = true;
   this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
   // 
   // frmTimesheetProcessDialog
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.ClientSize = new System.Drawing.Size(423, 119);
   this.Controls.Add(this.btnCancel);
   this.Controls.Add(this.pictureBox1);
   this.Controls.Add(this.lblProcessEmployee);
   this.Controls.Add(this.lblProcessRemarks);
   this.Controls.Add(this.prgTimeSheet);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmTimesheetProcessDialog";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Processing Timesheet...";
   this.Load += new System.EventHandler(this.frmTimesheetProcessDialog_Load);
   this.Shown += new System.EventHandler(this.frmTimesheetProcessDialog_Shown);
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label lblProcessRemarks;
  private System.Windows.Forms.ProgressBar prgTimeSheet;
  private System.Windows.Forms.Label lblProcessEmployee;
  private System.Windows.Forms.PictureBox pictureBox1;
  private System.Windows.Forms.Button btnCancel;
 }
}