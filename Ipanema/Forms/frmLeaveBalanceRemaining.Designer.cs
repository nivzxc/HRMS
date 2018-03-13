namespace Ipanema.Forms
{
 partial class frmLeaveBalanceRemaining
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
   this.lvBalance = new System.Windows.Forms.ListView();
   this.chLeave = new System.Windows.Forms.ColumnHeader();
   this.chEntitlement = new System.Windows.Forms.ColumnHeader();
   this.chBalance = new System.Windows.Forms.ColumnHeader();
   this.btnClose = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // lvBalance
   // 
   this.lvBalance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLeave,
            this.chEntitlement,
            this.chBalance});
   this.lvBalance.Dock = System.Windows.Forms.DockStyle.Fill;
   this.lvBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lvBalance.FullRowSelect = true;
   this.lvBalance.GridLines = true;
   this.lvBalance.HideSelection = false;
   this.lvBalance.Location = new System.Drawing.Point(0, 0);
   this.lvBalance.MultiSelect = false;
   this.lvBalance.Name = "lvBalance";
   this.lvBalance.Size = new System.Drawing.Size(364, 215);
   this.lvBalance.TabIndex = 1;
   this.lvBalance.UseCompatibleStateImageBehavior = false;
   this.lvBalance.View = System.Windows.Forms.View.Details;
   // 
   // chLeave
   // 
   this.chLeave.Text = "Leave Type";
   this.chLeave.Width = 200;
   // 
   // chEntitlement
   // 
   this.chEntitlement.Text = "Entitlement";
   this.chEntitlement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   this.chEntitlement.Width = 80;
   // 
   // chBalance
   // 
   this.chBalance.Text = "Balance";
   this.chBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   this.chBalance.Width = 80;
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Location = new System.Drawing.Point(336, 190);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(24, 20);
   this.btnClose.TabIndex = 2;
   this.btnClose.Text = "X";
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Visible = false;
   // 
   // frmLeaveBalanceRemaining
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(364, 215);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.lvBalance);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmLeaveBalanceRemaining";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Leave Balance Remaining";
   this.Load += new System.EventHandler(this.frmLeaveBalanceRemaining_Load);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.ListView lvBalance;
  private System.Windows.Forms.ColumnHeader chLeave;
  private System.Windows.Forms.ColumnHeader chEntitlement;
  private System.Windows.Forms.ColumnHeader chBalance;
  private System.Windows.Forms.Button btnClose;
 }
}