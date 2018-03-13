namespace Ipanema.Forms
{
 partial class frmEmployeeScheduleList
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeScheduleList));
   this.pnlHeader = new System.Windows.Forms.Panel();
   this.tsScheduleManagement = new System.Windows.Forms.ToolStrip();
   this.tbtnModify = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnRefresh = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnClose = new System.Windows.Forms.ToolStripButton();
   this.pnlFooter = new System.Windows.Forms.Panel();
   this.lvScheduleManagement = new System.Windows.Forms.ListView();
   this.chNumber = new System.Windows.Forms.ColumnHeader();
   this.chName = new System.Windows.Forms.ColumnHeader();
   this.chCurrent = new System.Windows.Forms.ColumnHeader();
   this.chMonday = new System.Windows.Forms.ColumnHeader();
   this.chTuesday = new System.Windows.Forms.ColumnHeader();
   this.chWednesday = new System.Windows.Forms.ColumnHeader();
   this.chThursday = new System.Windows.Forms.ColumnHeader();
   this.chFriday = new System.Windows.Forms.ColumnHeader();
   this.chSaturday = new System.Windows.Forms.ColumnHeader();
   this.chSunday = new System.Windows.Forms.ColumnHeader();
   this.chDefault = new System.Windows.Forms.ColumnHeader();
   this.pnlBody = new System.Windows.Forms.Panel();
   this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
   this.pnlHeader.SuspendLayout();
   this.tsScheduleManagement.SuspendLayout();
   this.pnlBody.SuspendLayout();
   this.SuspendLayout();
   // 
   // pnlHeader
   // 
   this.pnlHeader.Controls.Add(this.tsScheduleManagement);
   this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
   this.pnlHeader.Location = new System.Drawing.Point(0, 0);
   this.pnlHeader.Name = "pnlHeader";
   this.pnlHeader.Size = new System.Drawing.Size(925, 40);
   this.pnlHeader.TabIndex = 0;
   // 
   // tsScheduleManagement
   // 
   this.tsScheduleManagement.ImageScalingSize = new System.Drawing.Size(32, 32);
   this.tsScheduleManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnAdd,
            this.toolStripSeparator2,
            this.tbtnModify,
            this.toolStripSeparator1,
            this.tbtnRefresh,
            this.toolStripSeparator3,
            this.tbtnClose});
   this.tsScheduleManagement.Location = new System.Drawing.Point(0, 0);
   this.tsScheduleManagement.Name = "tsScheduleManagement";
   this.tsScheduleManagement.Size = new System.Drawing.Size(925, 39);
   this.tsScheduleManagement.TabIndex = 5;
   this.tsScheduleManagement.Text = "toolStrip1";
   // 
   // tbtnModify
   // 
   this.tbtnModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
   this.tbtnModify.Image = ((System.Drawing.Image)(resources.GetObject("tbtnModify.Image")));
   this.tbtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnModify.Name = "tbtnModify";
   this.tbtnModify.Size = new System.Drawing.Size(36, 36);
   this.tbtnModify.ToolTipText = "Modify";
   this.tbtnModify.Click += new System.EventHandler(this.tbtnModify_Click);
   // 
   // toolStripSeparator2
   // 
   this.toolStripSeparator2.Name = "toolStripSeparator2";
   this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
   // 
   // tbtnRefresh
   // 
   this.tbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
   this.tbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tbtnRefresh.Image")));
   this.tbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnRefresh.Name = "tbtnRefresh";
   this.tbtnRefresh.Size = new System.Drawing.Size(36, 36);
   this.tbtnRefresh.ToolTipText = "Refresh";
   this.tbtnRefresh.Click += new System.EventHandler(this.tbtnRefresh_Click);
   // 
   // toolStripSeparator3
   // 
   this.toolStripSeparator3.Name = "toolStripSeparator3";
   this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
   // 
   // tbtnClose
   // 
   this.tbtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
   this.tbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tbtnClose.Image")));
   this.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnClose.Name = "tbtnClose";
   this.tbtnClose.Size = new System.Drawing.Size(36, 36);
   this.tbtnClose.ToolTipText = "Close";
   this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
   // 
   // pnlFooter
   // 
   this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
   this.pnlFooter.Location = new System.Drawing.Point(0, 488);
   this.pnlFooter.Name = "pnlFooter";
   this.pnlFooter.Size = new System.Drawing.Size(925, 26);
   this.pnlFooter.TabIndex = 2;
   // 
   // lvScheduleManagement
   // 
   this.lvScheduleManagement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNumber,
            this.chName,
            this.chCurrent,
            this.chMonday,
            this.chTuesday,
            this.chWednesday,
            this.chThursday,
            this.chFriday,
            this.chSaturday,
            this.chSunday,
            this.chDefault});
   this.lvScheduleManagement.Dock = System.Windows.Forms.DockStyle.Fill;
   this.lvScheduleManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lvScheduleManagement.FullRowSelect = true;
   this.lvScheduleManagement.GridLines = true;
   this.lvScheduleManagement.HideSelection = false;
   this.lvScheduleManagement.Location = new System.Drawing.Point(0, 0);
   this.lvScheduleManagement.MultiSelect = false;
   this.lvScheduleManagement.Name = "lvScheduleManagement";
   this.lvScheduleManagement.Size = new System.Drawing.Size(925, 448);
   this.lvScheduleManagement.TabIndex = 4;
   this.lvScheduleManagement.UseCompatibleStateImageBehavior = false;
   this.lvScheduleManagement.View = System.Windows.Forms.View.Details;
   // 
   // chNumber
   // 
   this.chNumber.Text = "Number";
   // 
   // chName
   // 
   this.chName.Text = "Employee Name";
   this.chName.Width = 248;
   // 
   // chCurrent
   // 
   this.chCurrent.Text = "Current";
   this.chCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   // 
   // chMonday
   // 
   this.chMonday.Text = "Monday";
   this.chMonday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   this.chMonday.Width = 80;
   // 
   // chTuesday
   // 
   this.chTuesday.Text = "Tuesday";
   this.chTuesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   this.chTuesday.Width = 80;
   // 
   // chWednesday
   // 
   this.chWednesday.Text = "Wednesday";
   this.chWednesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   this.chWednesday.Width = 80;
   // 
   // chThursday
   // 
   this.chThursday.Text = "Thursday";
   this.chThursday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   this.chThursday.Width = 80;
   // 
   // chFriday
   // 
   this.chFriday.Text = "Friday";
   this.chFriday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   this.chFriday.Width = 80;
   // 
   // chSaturday
   // 
   this.chSaturday.Text = "Saturday";
   this.chSaturday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   this.chSaturday.Width = 80;
   // 
   // chSunday
   // 
   this.chSunday.Text = "Sunday";
   this.chSunday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   this.chSunday.Width = 80;
   // 
   // chDefault
   // 
   this.chDefault.Text = "Default";
   this.chDefault.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
   // 
   // pnlBody
   // 
   this.pnlBody.Controls.Add(this.lvScheduleManagement);
   this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlBody.Location = new System.Drawing.Point(0, 40);
   this.pnlBody.Name = "pnlBody";
   this.pnlBody.Size = new System.Drawing.Size(925, 448);
   this.pnlBody.TabIndex = 3;
   // 
   // tbtnAdd
   // 
   this.tbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
   this.tbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAdd.Image")));
   this.tbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnAdd.Name = "tbtnAdd";
   this.tbtnAdd.Size = new System.Drawing.Size(36, 36);
   this.tbtnAdd.Text = "toolStripButton1";
   this.tbtnAdd.Click += new System.EventHandler(this.tbtnAdd_Click);
   // 
   // toolStripSeparator1
   // 
   this.toolStripSeparator1.Name = "toolStripSeparator1";
   this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
   // 
   // frmEmployeeScheduleList
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(925, 514);
   this.Controls.Add(this.pnlBody);
   this.Controls.Add(this.pnlFooter);
   this.Controls.Add(this.pnlHeader);
   this.Name = "frmEmployeeScheduleList";
   this.Text = "Employee Schedule Management";
   this.Load += new System.EventHandler(this.frmEmployeeScheduleList_Load);
   this.pnlHeader.ResumeLayout(false);
   this.pnlHeader.PerformLayout();
   this.tsScheduleManagement.ResumeLayout(false);
   this.tsScheduleManagement.PerformLayout();
   this.pnlBody.ResumeLayout(false);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel pnlHeader;
  private System.Windows.Forms.Panel pnlFooter;
  private System.Windows.Forms.ToolStrip tsScheduleManagement;
  private System.Windows.Forms.ToolStripButton tbtnModify;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
  private System.Windows.Forms.ToolStripButton tbtnRefresh;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
  private System.Windows.Forms.ToolStripButton tbtnClose;
  private System.Windows.Forms.ListView lvScheduleManagement;
  private System.Windows.Forms.ColumnHeader chNumber;
  private System.Windows.Forms.ColumnHeader chName;
  private System.Windows.Forms.ColumnHeader chCurrent;
  private System.Windows.Forms.ColumnHeader chDefault;
  private System.Windows.Forms.ColumnHeader chMonday;
  private System.Windows.Forms.ColumnHeader chTuesday;
  private System.Windows.Forms.ColumnHeader chWednesday;
  private System.Windows.Forms.ColumnHeader chThursday;
  private System.Windows.Forms.ColumnHeader chFriday;
  private System.Windows.Forms.ColumnHeader chSaturday;
  private System.Windows.Forms.ColumnHeader chSunday;
  private System.Windows.Forms.Panel pnlBody;
  private System.Windows.Forms.ToolStripButton tbtnAdd;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
 }
}