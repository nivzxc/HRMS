namespace Ipanema.Forms
{
 partial class frmScheduleModify
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleModify));
   this.btnClose = new System.Windows.Forms.Button();
   this.btnSave = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.txtScheduleCode = new System.Windows.Forms.TextBox();
   this.label10 = new System.Windows.Forms.Label();
   this.txtRemarks = new System.Windows.Forms.TextBox();
   this.label9 = new System.Windows.Forms.Label();
   this.txtTotalHours = new System.Windows.Forms.TextBox();
   this.btnViewSun = new System.Windows.Forms.Button();
   this.label8 = new System.Windows.Forms.Label();
   this.btnViewFri = new System.Windows.Forms.Button();
   this.btnViewThu = new System.Windows.Forms.Button();
   this.btnViewSat = new System.Windows.Forms.Button();
   this.btnViewWed = new System.Windows.Forms.Button();
   this.btnViewTue = new System.Windows.Forms.Button();
   this.btnViewMon = new System.Windows.Forms.Button();
   this.cmbShiftSun = new System.Windows.Forms.ComboBox();
   this.cmbShiftSat = new System.Windows.Forms.ComboBox();
   this.cmbShiftFri = new System.Windows.Forms.ComboBox();
   this.cmbShiftThu = new System.Windows.Forms.ComboBox();
   this.cmbShiftTue = new System.Windows.Forms.ComboBox();
   this.cmbShiftMon = new System.Windows.Forms.ComboBox();
   this.cmbShiftWed = new System.Windows.Forms.ComboBox();
   this.btnSearchSun = new System.Windows.Forms.Button();
   this.btnSearchFri = new System.Windows.Forms.Button();
   this.btnSearchThu = new System.Windows.Forms.Button();
   this.btnSearchSat = new System.Windows.Forms.Button();
   this.btnSearchWed = new System.Windows.Forms.Button();
   this.btnSearchTue = new System.Windows.Forms.Button();
   this.btnSearchMon = new System.Windows.Forms.Button();
   this.label7 = new System.Windows.Forms.Label();
   this.label6 = new System.Windows.Forms.Label();
   this.label5 = new System.Windows.Forms.Label();
   this.label4 = new System.Windows.Forms.Label();
   this.label3 = new System.Windows.Forms.Label();
   this.label2 = new System.Windows.Forms.Label();
   this.label1 = new System.Windows.Forms.Label();
   this.tabSchedule = new System.Windows.Forms.TabControl();
   this.tbpDetails = new System.Windows.Forms.TabPage();
   this.tbpDefault = new System.Windows.Forms.TabPage();
   this.groupBox2 = new System.Windows.Forms.GroupBox();
   this.tbpSpecial = new System.Windows.Forms.TabPage();
   this.groupBox3 = new System.Windows.Forms.GroupBox();
   this.lvDefault = new System.Windows.Forms.ListView();
   this.colEmployee = new System.Windows.Forms.ColumnHeader();
   this.colDepartment = new System.Windows.Forms.ColumnHeader();
   this.lvSpecial = new System.Windows.Forms.ListView();
   this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
   this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
   this.groupBox1.SuspendLayout();
   this.tabSchedule.SuspendLayout();
   this.tbpDetails.SuspendLayout();
   this.tbpDefault.SuspendLayout();
   this.groupBox2.SuspendLayout();
   this.tbpSpecial.SuspendLayout();
   this.groupBox3.SuspendLayout();
   this.SuspendLayout();
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(580, 414);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 25;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnSave
   // 
   this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
   this.btnSave.Location = new System.Drawing.Point(494, 414);
   this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(80, 38);
   this.btnSave.TabIndex = 24;
   this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSave.UseVisualStyleBackColor = true;
   this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.txtScheduleCode);
   this.groupBox1.Controls.Add(this.label10);
   this.groupBox1.Controls.Add(this.txtRemarks);
   this.groupBox1.Controls.Add(this.label9);
   this.groupBox1.Controls.Add(this.txtTotalHours);
   this.groupBox1.Controls.Add(this.btnViewSun);
   this.groupBox1.Controls.Add(this.label8);
   this.groupBox1.Controls.Add(this.btnViewFri);
   this.groupBox1.Controls.Add(this.btnViewThu);
   this.groupBox1.Controls.Add(this.btnViewSat);
   this.groupBox1.Controls.Add(this.btnViewWed);
   this.groupBox1.Controls.Add(this.btnViewTue);
   this.groupBox1.Controls.Add(this.btnViewMon);
   this.groupBox1.Controls.Add(this.cmbShiftSun);
   this.groupBox1.Controls.Add(this.cmbShiftSat);
   this.groupBox1.Controls.Add(this.cmbShiftFri);
   this.groupBox1.Controls.Add(this.cmbShiftThu);
   this.groupBox1.Controls.Add(this.cmbShiftTue);
   this.groupBox1.Controls.Add(this.cmbShiftMon);
   this.groupBox1.Controls.Add(this.cmbShiftWed);
   this.groupBox1.Controls.Add(this.btnSearchSun);
   this.groupBox1.Controls.Add(this.btnSearchFri);
   this.groupBox1.Controls.Add(this.btnSearchThu);
   this.groupBox1.Controls.Add(this.btnSearchSat);
   this.groupBox1.Controls.Add(this.btnSearchWed);
   this.groupBox1.Controls.Add(this.btnSearchTue);
   this.groupBox1.Controls.Add(this.btnSearchMon);
   this.groupBox1.Controls.Add(this.label7);
   this.groupBox1.Controls.Add(this.label6);
   this.groupBox1.Controls.Add(this.label5);
   this.groupBox1.Controls.Add(this.label4);
   this.groupBox1.Controls.Add(this.label3);
   this.groupBox1.Controls.Add(this.label2);
   this.groupBox1.Controls.Add(this.label1);
   this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox1.Location = new System.Drawing.Point(9, 3);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(623, 361);
   this.groupBox1.TabIndex = 23;
   this.groupBox1.TabStop = false;
   // 
   // txtScheduleCode
   // 
   this.txtScheduleCode.BackColor = System.Drawing.Color.AliceBlue;
   this.txtScheduleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtScheduleCode.Location = new System.Drawing.Point(112, 22);
   this.txtScheduleCode.Name = "txtScheduleCode";
   this.txtScheduleCode.ReadOnly = true;
   this.txtScheduleCode.Size = new System.Drawing.Size(43, 21);
   this.txtScheduleCode.TabIndex = 0;
   // 
   // label10
   // 
   this.label10.AutoSize = true;
   this.label10.Location = new System.Drawing.Point(12, 25);
   this.label10.Name = "label10";
   this.label10.Size = new System.Drawing.Size(94, 15);
   this.label10.TabIndex = 27;
   this.label10.Text = "Schedule Code:";
   // 
   // txtRemarks
   // 
   this.txtRemarks.BackColor = System.Drawing.Color.White;
   this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtRemarks.Location = new System.Drawing.Point(112, 253);
   this.txtRemarks.Multiline = true;
   this.txtRemarks.Name = "txtRemarks";
   this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.txtRemarks.Size = new System.Drawing.Size(496, 67);
   this.txtRemarks.TabIndex = 22;
   // 
   // label9
   // 
   this.label9.AutoSize = true;
   this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label9.Location = new System.Drawing.Point(12, 253);
   this.label9.Name = "label9";
   this.label9.Size = new System.Drawing.Size(60, 15);
   this.label9.TabIndex = 25;
   this.label9.Text = "Remarks:";
   // 
   // txtTotalHours
   // 
   this.txtTotalHours.BackColor = System.Drawing.Color.AliceBlue;
   this.txtTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtTotalHours.Location = new System.Drawing.Point(112, 329);
   this.txtTotalHours.Name = "txtTotalHours";
   this.txtTotalHours.ReadOnly = true;
   this.txtTotalHours.Size = new System.Drawing.Size(75, 21);
   this.txtTotalHours.TabIndex = 23;
   // 
   // btnViewSun
   // 
   this.btnViewSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnViewSun.Image = ((System.Drawing.Image)(resources.GetObject("btnViewSun.Image")));
   this.btnViewSun.Location = new System.Drawing.Point(282, 222);
   this.btnViewSun.Name = "btnViewSun";
   this.btnViewSun.Size = new System.Drawing.Size(25, 24);
   this.btnViewSun.TabIndex = 20;
   this.btnViewSun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnViewSun.UseVisualStyleBackColor = true;
   this.btnViewSun.Click += new System.EventHandler(this.btnViewSun_Click);
   // 
   // label8
   // 
   this.label8.AutoSize = true;
   this.label8.Location = new System.Drawing.Point(12, 332);
   this.label8.Name = "label8";
   this.label8.Size = new System.Drawing.Size(89, 15);
   this.label8.TabIndex = 23;
   this.label8.Text = "Working hours:";
   // 
   // btnViewFri
   // 
   this.btnViewFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnViewFri.Image = ((System.Drawing.Image)(resources.GetObject("btnViewFri.Image")));
   this.btnViewFri.Location = new System.Drawing.Point(282, 165);
   this.btnViewFri.Name = "btnViewFri";
   this.btnViewFri.Size = new System.Drawing.Size(25, 24);
   this.btnViewFri.TabIndex = 14;
   this.btnViewFri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnViewFri.UseVisualStyleBackColor = true;
   this.btnViewFri.Click += new System.EventHandler(this.btnViewFri_Click);
   // 
   // btnViewThu
   // 
   this.btnViewThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnViewThu.Image = ((System.Drawing.Image)(resources.GetObject("btnViewThu.Image")));
   this.btnViewThu.Location = new System.Drawing.Point(282, 136);
   this.btnViewThu.Name = "btnViewThu";
   this.btnViewThu.Size = new System.Drawing.Size(25, 24);
   this.btnViewThu.TabIndex = 11;
   this.btnViewThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnViewThu.UseVisualStyleBackColor = true;
   this.btnViewThu.Click += new System.EventHandler(this.btnViewThu_Click);
   // 
   // btnViewSat
   // 
   this.btnViewSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnViewSat.Image = ((System.Drawing.Image)(resources.GetObject("btnViewSat.Image")));
   this.btnViewSat.Location = new System.Drawing.Point(282, 194);
   this.btnViewSat.Name = "btnViewSat";
   this.btnViewSat.Size = new System.Drawing.Size(25, 24);
   this.btnViewSat.TabIndex = 17;
   this.btnViewSat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnViewSat.UseVisualStyleBackColor = true;
   this.btnViewSat.Click += new System.EventHandler(this.btnViewSat_Click);
   // 
   // btnViewWed
   // 
   this.btnViewWed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnViewWed.Image = ((System.Drawing.Image)(resources.GetObject("btnViewWed.Image")));
   this.btnViewWed.Location = new System.Drawing.Point(282, 107);
   this.btnViewWed.Name = "btnViewWed";
   this.btnViewWed.Size = new System.Drawing.Size(25, 24);
   this.btnViewWed.TabIndex = 8;
   this.btnViewWed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnViewWed.UseVisualStyleBackColor = true;
   this.btnViewWed.Click += new System.EventHandler(this.btnViewWed_Click);
   // 
   // btnViewTue
   // 
   this.btnViewTue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnViewTue.Image = ((System.Drawing.Image)(resources.GetObject("btnViewTue.Image")));
   this.btnViewTue.Location = new System.Drawing.Point(282, 78);
   this.btnViewTue.Name = "btnViewTue";
   this.btnViewTue.Size = new System.Drawing.Size(25, 24);
   this.btnViewTue.TabIndex = 5;
   this.btnViewTue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnViewTue.UseVisualStyleBackColor = true;
   this.btnViewTue.Click += new System.EventHandler(this.btnViewTue_Click);
   // 
   // btnViewMon
   // 
   this.btnViewMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnViewMon.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMon.Image")));
   this.btnViewMon.Location = new System.Drawing.Point(282, 49);
   this.btnViewMon.Name = "btnViewMon";
   this.btnViewMon.Size = new System.Drawing.Size(25, 24);
   this.btnViewMon.TabIndex = 2;
   this.btnViewMon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnViewMon.UseVisualStyleBackColor = true;
   this.btnViewMon.Click += new System.EventHandler(this.btnViewMon_Click);
   // 
   // cmbShiftSun
   // 
   this.cmbShiftSun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbShiftSun.FormattingEnabled = true;
   this.cmbShiftSun.Location = new System.Drawing.Point(112, 223);
   this.cmbShiftSun.Name = "cmbShiftSun";
   this.cmbShiftSun.Size = new System.Drawing.Size(165, 23);
   this.cmbShiftSun.TabIndex = 19;
   this.cmbShiftSun.SelectedIndexChanged += new System.EventHandler(this.cmbShiftSun_SelectedIndexChanged);
   // 
   // cmbShiftSat
   // 
   this.cmbShiftSat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbShiftSat.FormattingEnabled = true;
   this.cmbShiftSat.Location = new System.Drawing.Point(112, 195);
   this.cmbShiftSat.Name = "cmbShiftSat";
   this.cmbShiftSat.Size = new System.Drawing.Size(165, 23);
   this.cmbShiftSat.TabIndex = 16;
   this.cmbShiftSat.SelectedIndexChanged += new System.EventHandler(this.cmbShiftSat_SelectedIndexChanged);
   // 
   // cmbShiftFri
   // 
   this.cmbShiftFri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbShiftFri.FormattingEnabled = true;
   this.cmbShiftFri.Location = new System.Drawing.Point(112, 166);
   this.cmbShiftFri.Name = "cmbShiftFri";
   this.cmbShiftFri.Size = new System.Drawing.Size(165, 23);
   this.cmbShiftFri.TabIndex = 13;
   this.cmbShiftFri.SelectedIndexChanged += new System.EventHandler(this.cmbShiftFri_SelectedIndexChanged);
   // 
   // cmbShiftThu
   // 
   this.cmbShiftThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbShiftThu.FormattingEnabled = true;
   this.cmbShiftThu.Location = new System.Drawing.Point(112, 137);
   this.cmbShiftThu.Name = "cmbShiftThu";
   this.cmbShiftThu.Size = new System.Drawing.Size(165, 23);
   this.cmbShiftThu.TabIndex = 10;
   this.cmbShiftThu.SelectedIndexChanged += new System.EventHandler(this.cmbShiftThu_SelectedIndexChanged);
   // 
   // cmbShiftTue
   // 
   this.cmbShiftTue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbShiftTue.FormattingEnabled = true;
   this.cmbShiftTue.Location = new System.Drawing.Point(112, 79);
   this.cmbShiftTue.Name = "cmbShiftTue";
   this.cmbShiftTue.Size = new System.Drawing.Size(165, 23);
   this.cmbShiftTue.TabIndex = 4;
   this.cmbShiftTue.SelectedIndexChanged += new System.EventHandler(this.cmbShiftTue_SelectedIndexChanged);
   // 
   // cmbShiftMon
   // 
   this.cmbShiftMon.BackColor = System.Drawing.Color.White;
   this.cmbShiftMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbShiftMon.FormattingEnabled = true;
   this.cmbShiftMon.Location = new System.Drawing.Point(112, 50);
   this.cmbShiftMon.Name = "cmbShiftMon";
   this.cmbShiftMon.Size = new System.Drawing.Size(165, 23);
   this.cmbShiftMon.TabIndex = 1;
   this.cmbShiftMon.SelectedIndexChanged += new System.EventHandler(this.cmbShiftMon_SelectedIndexChanged);
   // 
   // cmbShiftWed
   // 
   this.cmbShiftWed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbShiftWed.FormattingEnabled = true;
   this.cmbShiftWed.Location = new System.Drawing.Point(112, 108);
   this.cmbShiftWed.Name = "cmbShiftWed";
   this.cmbShiftWed.Size = new System.Drawing.Size(165, 23);
   this.cmbShiftWed.TabIndex = 7;
   this.cmbShiftWed.SelectedIndexChanged += new System.EventHandler(this.cmbShiftWed_SelectedIndexChanged);
   // 
   // btnSearchSun
   // 
   this.btnSearchSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSearchSun.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchSun.Image")));
   this.btnSearchSun.Location = new System.Drawing.Point(308, 222);
   this.btnSearchSun.Name = "btnSearchSun";
   this.btnSearchSun.Size = new System.Drawing.Size(25, 24);
   this.btnSearchSun.TabIndex = 21;
   this.btnSearchSun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSearchSun.UseVisualStyleBackColor = true;
   // 
   // btnSearchFri
   // 
   this.btnSearchFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSearchFri.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFri.Image")));
   this.btnSearchFri.Location = new System.Drawing.Point(308, 165);
   this.btnSearchFri.Name = "btnSearchFri";
   this.btnSearchFri.Size = new System.Drawing.Size(25, 24);
   this.btnSearchFri.TabIndex = 15;
   this.btnSearchFri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSearchFri.UseVisualStyleBackColor = true;
   // 
   // btnSearchThu
   // 
   this.btnSearchThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSearchThu.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchThu.Image")));
   this.btnSearchThu.Location = new System.Drawing.Point(308, 136);
   this.btnSearchThu.Name = "btnSearchThu";
   this.btnSearchThu.Size = new System.Drawing.Size(25, 24);
   this.btnSearchThu.TabIndex = 12;
   this.btnSearchThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSearchThu.UseVisualStyleBackColor = true;
   // 
   // btnSearchSat
   // 
   this.btnSearchSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSearchSat.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchSat.Image")));
   this.btnSearchSat.Location = new System.Drawing.Point(308, 194);
   this.btnSearchSat.Name = "btnSearchSat";
   this.btnSearchSat.Size = new System.Drawing.Size(25, 24);
   this.btnSearchSat.TabIndex = 18;
   this.btnSearchSat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSearchSat.UseVisualStyleBackColor = true;
   // 
   // btnSearchWed
   // 
   this.btnSearchWed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSearchWed.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchWed.Image")));
   this.btnSearchWed.Location = new System.Drawing.Point(308, 107);
   this.btnSearchWed.Name = "btnSearchWed";
   this.btnSearchWed.Size = new System.Drawing.Size(25, 24);
   this.btnSearchWed.TabIndex = 9;
   this.btnSearchWed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSearchWed.UseVisualStyleBackColor = true;
   // 
   // btnSearchTue
   // 
   this.btnSearchTue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSearchTue.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTue.Image")));
   this.btnSearchTue.Location = new System.Drawing.Point(308, 78);
   this.btnSearchTue.Name = "btnSearchTue";
   this.btnSearchTue.Size = new System.Drawing.Size(25, 24);
   this.btnSearchTue.TabIndex = 6;
   this.btnSearchTue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSearchTue.UseVisualStyleBackColor = true;
   // 
   // btnSearchMon
   // 
   this.btnSearchMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSearchMon.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMon.Image")));
   this.btnSearchMon.Location = new System.Drawing.Point(308, 49);
   this.btnSearchMon.Name = "btnSearchMon";
   this.btnSearchMon.Size = new System.Drawing.Size(25, 24);
   this.btnSearchMon.TabIndex = 3;
   this.btnSearchMon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSearchMon.UseVisualStyleBackColor = true;
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label7.Location = new System.Drawing.Point(12, 227);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(51, 15);
   this.label7.TabIndex = 6;
   this.label7.Text = "Sunday:";
   // 
   // label6
   // 
   this.label6.AutoSize = true;
   this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label6.Location = new System.Drawing.Point(12, 199);
   this.label6.Name = "label6";
   this.label6.Size = new System.Drawing.Size(58, 15);
   this.label6.TabIndex = 5;
   this.label6.Text = "Saturday:";
   // 
   // label5
   // 
   this.label5.AutoSize = true;
   this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label5.Location = new System.Drawing.Point(12, 170);
   this.label5.Name = "label5";
   this.label5.Size = new System.Drawing.Size(43, 15);
   this.label5.TabIndex = 4;
   this.label5.Text = "Friday:";
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label4.Location = new System.Drawing.Point(12, 141);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(60, 15);
   this.label4.TabIndex = 3;
   this.label4.Text = "Thursday:";
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(12, 83);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(56, 15);
   this.label3.TabIndex = 2;
   this.label3.Text = "Tuesday:";
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(12, 112);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(74, 15);
   this.label2.TabIndex = 1;
   this.label2.Text = "Wednesday:";
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(12, 53);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(54, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Monday:";
   // 
   // tabSchedule
   // 
   this.tabSchedule.Controls.Add(this.tbpDetails);
   this.tabSchedule.Controls.Add(this.tbpDefault);
   this.tabSchedule.Controls.Add(this.tbpSpecial);
   this.tabSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.tabSchedule.Location = new System.Drawing.Point(10, 8);
   this.tabSchedule.Name = "tabSchedule";
   this.tabSchedule.SelectedIndex = 0;
   this.tabSchedule.Size = new System.Drawing.Size(651, 402);
   this.tabSchedule.TabIndex = 26;
   // 
   // tbpDetails
   // 
   this.tbpDetails.BackColor = System.Drawing.SystemColors.Window;
   this.tbpDetails.Controls.Add(this.groupBox1);
   this.tbpDetails.Location = new System.Drawing.Point(4, 24);
   this.tbpDetails.Name = "tbpDetails";
   this.tbpDetails.Padding = new System.Windows.Forms.Padding(3);
   this.tbpDetails.Size = new System.Drawing.Size(643, 374);
   this.tbpDetails.TabIndex = 0;
   this.tbpDetails.Text = "Schedule Details";
   this.tbpDetails.UseVisualStyleBackColor = true;
   // 
   // tbpDefault
   // 
   this.tbpDefault.Controls.Add(this.groupBox2);
   this.tbpDefault.Location = new System.Drawing.Point(4, 24);
   this.tbpDefault.Name = "tbpDefault";
   this.tbpDefault.Padding = new System.Windows.Forms.Padding(3);
   this.tbpDefault.Size = new System.Drawing.Size(643, 374);
   this.tbpDefault.TabIndex = 1;
   this.tbpDefault.Text = "Default";
   this.tbpDefault.UseVisualStyleBackColor = true;
   // 
   // groupBox2
   // 
   this.groupBox2.Controls.Add(this.lvDefault);
   this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox2.Location = new System.Drawing.Point(9, 3);
   this.groupBox2.Name = "groupBox2";
   this.groupBox2.Size = new System.Drawing.Size(623, 361);
   this.groupBox2.TabIndex = 24;
   this.groupBox2.TabStop = false;
   // 
   // tbpSpecial
   // 
   this.tbpSpecial.Controls.Add(this.groupBox3);
   this.tbpSpecial.Location = new System.Drawing.Point(4, 24);
   this.tbpSpecial.Name = "tbpSpecial";
   this.tbpSpecial.Size = new System.Drawing.Size(643, 374);
   this.tbpSpecial.TabIndex = 2;
   this.tbpSpecial.Text = "Special";
   this.tbpSpecial.UseVisualStyleBackColor = true;
   // 
   // groupBox3
   // 
   this.groupBox3.Controls.Add(this.lvSpecial);
   this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.groupBox3.Location = new System.Drawing.Point(9, 3);
   this.groupBox3.Name = "groupBox3";
   this.groupBox3.Size = new System.Drawing.Size(623, 361);
   this.groupBox3.TabIndex = 25;
   this.groupBox3.TabStop = false;
   // 
   // lvDefault
   // 
   this.lvDefault.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmployee,
            this.colDepartment});
   this.lvDefault.FullRowSelect = true;
   this.lvDefault.GridLines = true;
   this.lvDefault.Location = new System.Drawing.Point(11, 20);
   this.lvDefault.Name = "lvDefault";
   this.lvDefault.Size = new System.Drawing.Size(602, 328);
   this.lvDefault.TabIndex = 0;
   this.lvDefault.UseCompatibleStateImageBehavior = false;
   this.lvDefault.View = System.Windows.Forms.View.Details;
   // 
   // colEmployee
   // 
   this.colEmployee.Text = "Employee Name";
   this.colEmployee.Width = 280;
   // 
   // colDepartment
   // 
   this.colDepartment.Text = "Department";
   this.colDepartment.Width = 300;
   // 
   // lvSpecial
   // 
   this.lvSpecial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
   this.lvSpecial.FullRowSelect = true;
   this.lvSpecial.GridLines = true;
   this.lvSpecial.Location = new System.Drawing.Point(11, 20);
   this.lvSpecial.Name = "lvSpecial";
   this.lvSpecial.Size = new System.Drawing.Size(602, 328);
   this.lvSpecial.TabIndex = 1;
   this.lvSpecial.UseCompatibleStateImageBehavior = false;
   this.lvSpecial.View = System.Windows.Forms.View.Details;
   // 
   // columnHeader1
   // 
   this.columnHeader1.Text = "Employee Name";
   this.columnHeader1.Width = 280;
   // 
   // columnHeader2
   // 
   this.columnHeader2.Text = "Department";
   this.columnHeader2.Width = 300;
   // 
   // frmScheduleModify
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.AliceBlue;
   this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
   this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(670, 461);
   this.Controls.Add(this.tabSchedule);
   this.Controls.Add(this.btnClose);
   this.Controls.Add(this.btnSave);
   this.DoubleBuffered = true;
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmScheduleModify";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Schedule Details";
   this.Load += new System.EventHandler(this.frmScheduleModify_Load);
   this.groupBox1.ResumeLayout(false);
   this.groupBox1.PerformLayout();
   this.tabSchedule.ResumeLayout(false);
   this.tbpDetails.ResumeLayout(false);
   this.tbpDefault.ResumeLayout(false);
   this.groupBox2.ResumeLayout(false);
   this.tbpSpecial.ResumeLayout(false);
   this.groupBox3.ResumeLayout(false);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.Button btnSave;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.TextBox txtScheduleCode;
  private System.Windows.Forms.Label label10;
  private System.Windows.Forms.TextBox txtRemarks;
  private System.Windows.Forms.Label label9;
  private System.Windows.Forms.TextBox txtTotalHours;
  private System.Windows.Forms.Button btnViewSun;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.Button btnViewFri;
  private System.Windows.Forms.Button btnViewThu;
  private System.Windows.Forms.Button btnViewSat;
  private System.Windows.Forms.Button btnViewWed;
  private System.Windows.Forms.Button btnViewTue;
  private System.Windows.Forms.Button btnViewMon;
  private System.Windows.Forms.ComboBox cmbShiftSun;
  private System.Windows.Forms.ComboBox cmbShiftSat;
  private System.Windows.Forms.ComboBox cmbShiftFri;
  private System.Windows.Forms.ComboBox cmbShiftThu;
  private System.Windows.Forms.ComboBox cmbShiftTue;
  private System.Windows.Forms.ComboBox cmbShiftMon;
  private System.Windows.Forms.ComboBox cmbShiftWed;
  private System.Windows.Forms.Button btnSearchSun;
  private System.Windows.Forms.Button btnSearchFri;
  private System.Windows.Forms.Button btnSearchThu;
  private System.Windows.Forms.Button btnSearchSat;
  private System.Windows.Forms.Button btnSearchWed;
  private System.Windows.Forms.Button btnSearchTue;
  private System.Windows.Forms.Button btnSearchMon;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TabControl tabSchedule;
  private System.Windows.Forms.TabPage tbpDetails;
  private System.Windows.Forms.TabPage tbpDefault;
  private System.Windows.Forms.TabPage tbpSpecial;
  private System.Windows.Forms.GroupBox groupBox2;
  private System.Windows.Forms.GroupBox groupBox3;
  private System.Windows.Forms.ListView lvDefault;
  private System.Windows.Forms.ColumnHeader colEmployee;
  private System.Windows.Forms.ColumnHeader colDepartment;
  private System.Windows.Forms.ListView lvSpecial;
  private System.Windows.Forms.ColumnHeader columnHeader1;
  private System.Windows.Forms.ColumnHeader columnHeader2;
 }
}