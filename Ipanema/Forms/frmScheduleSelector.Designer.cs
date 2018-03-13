namespace Ipanema.Forms
{
 partial class frmScheduleSelector
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
   this.lvScheduleList = new System.Windows.Forms.ListView();
   this.chSchedCode = new System.Windows.Forms.ColumnHeader();
   this.chMonday = new System.Windows.Forms.ColumnHeader();
   this.chTuesday = new System.Windows.Forms.ColumnHeader();
   this.chWednesday = new System.Windows.Forms.ColumnHeader();
   this.chThursday = new System.Windows.Forms.ColumnHeader();
   this.chFriday = new System.Windows.Forms.ColumnHeader();
   this.chSaturday = new System.Windows.Forms.ColumnHeader();
   this.chSunday = new System.Windows.Forms.ColumnHeader();
   this.btnClose = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // lvScheduleList
   // 
   this.lvScheduleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSchedCode,
            this.chMonday,
            this.chTuesday,
            this.chWednesday,
            this.chThursday,
            this.chFriday,
            this.chSaturday,
            this.chSunday});
   this.lvScheduleList.Dock = System.Windows.Forms.DockStyle.Fill;
   this.lvScheduleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.lvScheduleList.FullRowSelect = true;
   this.lvScheduleList.GridLines = true;
   this.lvScheduleList.HideSelection = false;
   this.lvScheduleList.Location = new System.Drawing.Point(0, 0);
   this.lvScheduleList.MultiSelect = false;
   this.lvScheduleList.Name = "lvScheduleList";
   this.lvScheduleList.Size = new System.Drawing.Size(632, 311);
   this.lvScheduleList.TabIndex = 3;
   this.lvScheduleList.UseCompatibleStateImageBehavior = false;
   this.lvScheduleList.View = System.Windows.Forms.View.Details;
   this.lvScheduleList.DoubleClick += new System.EventHandler(this.lvScheduleList_DoubleClick);
   // 
   // chSchedCode
   // 
   this.chSchedCode.Text = "Code";
   this.chSchedCode.Width = 50;
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
   // btnClose
   // 
   this.btnClose.Location = new System.Drawing.Point(584, 286);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(44, 20);
   this.btnClose.TabIndex = 4;
   this.btnClose.Text = "Close";
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // frmScheduleSelector
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(632, 311);
   this.Controls.Add(this.lvScheduleList);
   this.Controls.Add(this.btnClose);
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmScheduleSelector";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Schedule Selector";
   this.Load += new System.EventHandler(this.frmScheduleSelector_Load);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.ListView lvScheduleList;
  private System.Windows.Forms.ColumnHeader chSchedCode;
  private System.Windows.Forms.ColumnHeader chMonday;
  private System.Windows.Forms.ColumnHeader chTuesday;
  private System.Windows.Forms.ColumnHeader chWednesday;
  private System.Windows.Forms.ColumnHeader chThursday;
  private System.Windows.Forms.ColumnHeader chFriday;
  private System.Windows.Forms.ColumnHeader chSaturday;
  private System.Windows.Forms.ColumnHeader chSunday;
  private System.Windows.Forms.Button btnClose;
 }
}