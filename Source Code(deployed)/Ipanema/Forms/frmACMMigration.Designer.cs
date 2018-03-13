namespace Ipanema.Forms
{
 partial class frmACMMigration
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmACMMigration));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnProcess = new System.Windows.Forms.Button();
   this.pbAcm = new System.Windows.Forms.ProgressBar();
   this.pictureBox1 = new System.Windows.Forms.PictureBox();
   this.label1 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.dtpStart = new System.Windows.Forms.DateTimePicker();
   this.dtpEnd = new System.Windows.Forms.DateTimePicker();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(332, 92);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 6;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnProcess
   // 
   this.btnProcess.Image = ((System.Drawing.Image)(resources.GetObject("btnProcess.Image")));
   this.btnProcess.Location = new System.Drawing.Point(222, 91);
   this.btnProcess.Name = "btnProcess";
   this.btnProcess.Size = new System.Drawing.Size(104, 39);
   this.btnProcess.TabIndex = 8;
   this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnProcess.UseVisualStyleBackColor = true;
   this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
   // 
   // pbAcm
   // 
   this.pbAcm.Location = new System.Drawing.Point(55, 58);
   this.pbAcm.Name = "pbAcm";
   this.pbAcm.Size = new System.Drawing.Size(357, 23);
   this.pbAcm.TabIndex = 9;
   // 
   // pictureBox1
   // 
   this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
   this.pictureBox1.Location = new System.Drawing.Point(10, 20);
   this.pictureBox1.Name = "pictureBox1";
   this.pictureBox1.Size = new System.Drawing.Size(32, 32);
   this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
   this.pictureBox1.TabIndex = 18;
   this.pictureBox1.TabStop = false;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(52, 30);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(61, 15);
   this.label1.TabIndex = 20;
   this.label1.Text = "Date Start";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Location = new System.Drawing.Point(241, 30);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(58, 15);
   this.label2.TabIndex = 21;
   this.label2.Text = "Date End";
   // 
   // dtpStart
   // 
   this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
   this.dtpStart.Location = new System.Drawing.Point(119, 25);
   this.dtpStart.Name = "dtpStart";
   this.dtpStart.Size = new System.Drawing.Size(103, 21);
   this.dtpStart.TabIndex = 22;
   // 
   // dtpEnd
   // 
   this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
   this.dtpEnd.Location = new System.Drawing.Point(308, 25);
   this.dtpEnd.Name = "dtpEnd";
   this.dtpEnd.Size = new System.Drawing.Size(103, 21);
   this.dtpEnd.TabIndex = 23;
   // 
   // frmACMMigration
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.ClientSize = new System.Drawing.Size(423, 140);
   this.Controls.Add(this.dtpEnd);
   this.Controls.Add(this.dtpStart);
   this.Controls.Add(this.label2);
   this.Controls.Add(this.label1);
   this.Controls.Add(this.pictureBox1);
   this.Controls.Add(this.pbAcm);
   this.Controls.Add(this.btnProcess);
   this.Controls.Add(this.btnClose);
   this.DoubleBuffered = true;
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmACMMigration";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "ACM Migration";
   this.Load += new System.EventHandler(this.frmACMMigration_Load);
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnProcess;
  private System.Windows.Forms.ProgressBar pbAcm;
  private System.Windows.Forms.PictureBox pictureBox1;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.DateTimePicker dtpStart;
  private System.Windows.Forms.DateTimePicker dtpEnd;
 }
}