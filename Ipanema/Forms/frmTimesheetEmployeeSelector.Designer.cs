namespace Ipanema.Forms
{
 partial class frmTimesheetEmployeeSelector
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimesheetEmployeeSelector));
   this.lvwEmployee = new System.Windows.Forms.ListView();
   this.colName = new System.Windows.Forms.ColumnHeader();
   this.btnClose = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // lvwEmployee
   // 
   this.lvwEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName});
   this.lvwEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
   this.lvwEmployee.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
   this.lvwEmployee.Location = new System.Drawing.Point(0, 0);
   this.lvwEmployee.Name = "lvwEmployee";
   this.lvwEmployee.Size = new System.Drawing.Size(291, 187);
   this.lvwEmployee.TabIndex = 0;
   this.lvwEmployee.UseCompatibleStateImageBehavior = false;
   this.lvwEmployee.View = System.Windows.Forms.View.Details;
   this.lvwEmployee.DoubleClick += new System.EventHandler(this.lvwEmployee_DoubleClick);
   this.lvwEmployee.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvwEmployee_KeyUp);
   // 
   // colName
   // 
   this.colName.Width = 250;
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Location = new System.Drawing.Point(282, 224);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(28, 27);
   this.btnClose.TabIndex = 1;
   this.btnClose.Text = "x";
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // frmTimesheetEmployeeSelector
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(291, 187);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.lvwEmployee);
   this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
   this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmTimesheetEmployeeSelector";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = " Employee Selector";
   this.Load += new System.EventHandler(this.frmTimesheetEmployeeSelector_Load);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.ListView lvwEmployee;
  private System.Windows.Forms.ColumnHeader colName;
  private System.Windows.Forms.Button btnClose;
 }
}