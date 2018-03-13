namespace Ipanema.Forms
{
 partial class frmEmployeeList
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeList));
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Number:",
            ""}, -1);
   System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Username:",
            ""}, -1);
   System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Name:",
            ""}, -1);
   System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nick Name:",
            ""}, -1);
   System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Email:",
            ""}, -1);
   System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Birth Date:",
            ""}, -1);
   System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Position",
            ""}, -1);
   System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Status:",
            ""}, -1);
   System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Date Started:",
            ""}, -1);
   System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Date Regular:",
            ""}, -1);
   System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Modified By:",
            ""}, -1);
   System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Date:",
            ""}, -1);
   this.pnlHeader = new System.Windows.Forms.Panel();
   this.btnSearch = new System.Windows.Forms.Button();
   this.label2 = new System.Windows.Forms.Label();
   this.cmbGender = new System.Windows.Forms.ComboBox();
   this.cmbDepartment = new System.Windows.Forms.ComboBox();
   this.label27 = new System.Windows.Forms.Label();
   this.cmbGroup = new System.Windows.Forms.ComboBox();
   this.label25 = new System.Windows.Forms.Label();
   this.txtLastName = new System.Windows.Forms.TextBox();
   this.label15 = new System.Windows.Forms.Label();
   this.tsButtons = new System.Windows.Forms.ToolStrip();
   this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnEdit = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnDelete = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnRefresh = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnEnable = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnDisable = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnExportExcel = new System.Windows.Forms.ToolStripButton();
   this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
   this.tbtnClose = new System.Windows.Forms.ToolStripButton();
   this.cmbDivision = new System.Windows.Forms.ComboBox();
   this.label23 = new System.Windows.Forms.Label();
   this.label21 = new System.Windows.Forms.Label();
   this.cmbStatus = new System.Windows.Forms.ComboBox();
   this.label19 = new System.Windows.Forms.Label();
   this.cmbJobGrade = new System.Windows.Forms.ComboBox();
   this.cmbEmployeeType = new System.Windows.Forms.ComboBox();
   this.cmbEmployeeStatus = new System.Windows.Forms.ComboBox();
   this.label17 = new System.Windows.Forms.Label();
   this.label16 = new System.Windows.Forms.Label();
   this.label7 = new System.Windows.Forms.Label();
   this.pnlBody = new System.Windows.Forms.Panel();
   this.pnlList = new System.Windows.Forms.Panel();
   this.dgEmployeeList = new System.Windows.Forms.DataGridView();
   this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colEmployeeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colJobGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colEmployeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colEmploymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.pnlListHeader = new System.Windows.Forms.Panel();
   this.chkShowDetails = new System.Windows.Forms.CheckBox();
   this.pictureBox2 = new System.Windows.Forms.PictureBox();
   this.label12 = new System.Windows.Forms.Label();
   this.pnlEmployeeDetails = new System.Windows.Forms.Panel();
   this.lvEmployeeDetails = new System.Windows.Forms.ListView();
   this.colField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
   this.picEmployee = new System.Windows.Forms.PictureBox();
   this.label1 = new System.Windows.Forms.Label();
   this.sfdExportExcel = new System.Windows.Forms.SaveFileDialog();
   this.pnlHeader.SuspendLayout();
   this.tsButtons.SuspendLayout();
   this.pnlBody.SuspendLayout();
   this.pnlList.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeList)).BeginInit();
   this.pnlListHeader.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
   this.pnlEmployeeDetails.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
   this.SuspendLayout();
   // 
   // pnlHeader
   // 
   this.pnlHeader.BackColor = System.Drawing.Color.White;
   this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
   this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
   this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.pnlHeader.Controls.Add(this.btnSearch);
   this.pnlHeader.Controls.Add(this.label2);
   this.pnlHeader.Controls.Add(this.cmbGender);
   this.pnlHeader.Controls.Add(this.cmbDepartment);
   this.pnlHeader.Controls.Add(this.label27);
   this.pnlHeader.Controls.Add(this.cmbGroup);
   this.pnlHeader.Controls.Add(this.label25);
   this.pnlHeader.Controls.Add(this.txtLastName);
   this.pnlHeader.Controls.Add(this.label15);
   this.pnlHeader.Controls.Add(this.tsButtons);
   this.pnlHeader.Controls.Add(this.cmbDivision);
   this.pnlHeader.Controls.Add(this.label23);
   this.pnlHeader.Controls.Add(this.label21);
   this.pnlHeader.Controls.Add(this.cmbStatus);
   this.pnlHeader.Controls.Add(this.label19);
   this.pnlHeader.Controls.Add(this.cmbJobGrade);
   this.pnlHeader.Controls.Add(this.cmbEmployeeType);
   this.pnlHeader.Controls.Add(this.cmbEmployeeStatus);
   this.pnlHeader.Controls.Add(this.label17);
   this.pnlHeader.Controls.Add(this.label16);
   this.pnlHeader.Controls.Add(this.label7);
   this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
   this.pnlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.pnlHeader.Location = new System.Drawing.Point(0, 0);
   this.pnlHeader.Name = "pnlHeader";
   this.pnlHeader.Size = new System.Drawing.Size(1028, 136);
   this.pnlHeader.TabIndex = 0;
   // 
   // btnSearch
   // 
   this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
   this.btnSearch.Location = new System.Drawing.Point(882, 50);
   this.btnSearch.Name = "btnSearch";
   this.btnSearch.Size = new System.Drawing.Size(104, 38);
   this.btnSearch.TabIndex = 29;
   this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnSearch.UseVisualStyleBackColor = true;
   this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.BackColor = System.Drawing.Color.Transparent;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(16, 82);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(45, 13);
   this.label2.TabIndex = 28;
   this.label2.Text = "Gender:";
   // 
   // cmbGender
   // 
   this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbGender.FormattingEnabled = true;
   this.cmbGender.Location = new System.Drawing.Point(78, 78);
   this.cmbGender.Name = "cmbGender";
   this.cmbGender.Size = new System.Drawing.Size(86, 21);
   this.cmbGender.TabIndex = 1;
   // 
   // cmbDepartment
   // 
   this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbDepartment.FormattingEnabled = true;
   this.cmbDepartment.Location = new System.Drawing.Point(630, 105);
   this.cmbDepartment.Name = "cmbDepartment";
   this.cmbDepartment.Size = new System.Drawing.Size(229, 21);
   this.cmbDepartment.TabIndex = 8;
   // 
   // label27
   // 
   this.label27.AutoSize = true;
   this.label27.BackColor = System.Drawing.Color.Transparent;
   this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label27.Location = new System.Drawing.Point(558, 110);
   this.label27.Name = "label27";
   this.label27.Size = new System.Drawing.Size(65, 13);
   this.label27.TabIndex = 26;
   this.label27.Text = "Department:";
   // 
   // cmbGroup
   // 
   this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbGroup.FormattingEnabled = true;
   this.cmbGroup.Location = new System.Drawing.Point(630, 78);
   this.cmbGroup.Name = "cmbGroup";
   this.cmbGroup.Size = new System.Drawing.Size(229, 21);
   this.cmbGroup.TabIndex = 7;
   this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
   // 
   // label25
   // 
   this.label25.AutoSize = true;
   this.label25.BackColor = System.Drawing.Color.Transparent;
   this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label25.Location = new System.Drawing.Point(558, 83);
   this.label25.Name = "label25";
   this.label25.Size = new System.Drawing.Size(39, 13);
   this.label25.TabIndex = 24;
   this.label25.Text = "Group:";
   // 
   // txtLastName
   // 
   this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtLastName.Location = new System.Drawing.Point(78, 53);
   this.txtLastName.Name = "txtLastName";
   this.txtLastName.Size = new System.Drawing.Size(204, 20);
   this.txtLastName.TabIndex = 0;
   // 
   // label15
   // 
   this.label15.AutoSize = true;
   this.label15.BackColor = System.Drawing.Color.Transparent;
   this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label15.Location = new System.Drawing.Point(16, 56);
   this.label15.Name = "label15";
   this.label15.Size = new System.Drawing.Size(61, 13);
   this.label15.TabIndex = 22;
   this.label15.Text = "Last Name:";
   // 
   // tsButtons
   // 
   this.tsButtons.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.tsButtons.ImageScalingSize = new System.Drawing.Size(22, 22);
   this.tsButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnAdd,
            this.toolStripSeparator1,
            this.tbtnEdit,
            this.toolStripSeparator2,
            this.tbtnDelete,
            this.toolStripSeparator4,
            this.tbtnRefresh,
            this.toolStripSeparator3,
            this.tbtnEnable,
            this.toolStripSeparator5,
            this.tbtnDisable,
            this.toolStripSeparator6,
            this.tbtnExportExcel,
            this.toolStripSeparator7,
            this.tbtnClose});
   this.tsButtons.Location = new System.Drawing.Point(0, 0);
   this.tsButtons.Name = "tsButtons";
   this.tsButtons.Size = new System.Drawing.Size(1026, 29);
   this.tsButtons.TabIndex = 21;
   this.tsButtons.Text = "OB ToolBar";
   // 
   // tbtnAdd
   // 
   this.tbtnAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.tbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAdd.Image")));
   this.tbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnAdd.Name = "tbtnAdd";
   this.tbtnAdd.Size = new System.Drawing.Size(59, 26);
   this.tbtnAdd.Text = " Add";
   this.tbtnAdd.ToolTipText = "Add New OB Application";
   this.tbtnAdd.Click += new System.EventHandler(this.tbtnAdd_Click);
   // 
   // toolStripSeparator1
   // 
   this.toolStripSeparator1.Name = "toolStripSeparator1";
   this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
   // 
   // tbtnEdit
   // 
   this.tbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tbtnEdit.Image")));
   this.tbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnEdit.Name = "tbtnEdit";
   this.tbtnEdit.Size = new System.Drawing.Size(58, 26);
   this.tbtnEdit.Text = " Edit";
   this.tbtnEdit.ToolTipText = "Modify";
   this.tbtnEdit.Click += new System.EventHandler(this.tbtnModify_Click);
   // 
   // toolStripSeparator2
   // 
   this.toolStripSeparator2.Name = "toolStripSeparator2";
   this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
   // 
   // tbtnDelete
   // 
   this.tbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDelete.Image")));
   this.tbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnDelete.Name = "tbtnDelete";
   this.tbtnDelete.Size = new System.Drawing.Size(69, 26);
   this.tbtnDelete.Text = "Delete";
   this.tbtnDelete.ToolTipText = "Delete selected record";
   // 
   // toolStripSeparator4
   // 
   this.toolStripSeparator4.Name = "toolStripSeparator4";
   this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
   // 
   // tbtnRefresh
   // 
   this.tbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tbtnRefresh.Image")));
   this.tbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnRefresh.Name = "tbtnRefresh";
   this.tbtnRefresh.Size = new System.Drawing.Size(74, 26);
   this.tbtnRefresh.Text = "Refresh";
   this.tbtnRefresh.ToolTipText = "Refresh record list";
   this.tbtnRefresh.Click += new System.EventHandler(this.tbtnRefresh_Click);
   // 
   // toolStripSeparator3
   // 
   this.toolStripSeparator3.Name = "toolStripSeparator3";
   this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
   // 
   // tbtnEnable
   // 
   this.tbtnEnable.Image = ((System.Drawing.Image)(resources.GetObject("tbtnEnable.Image")));
   this.tbtnEnable.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnEnable.Name = "tbtnEnable";
   this.tbtnEnable.Size = new System.Drawing.Size(73, 26);
   this.tbtnEnable.Text = " Enable";
   this.tbtnEnable.Click += new System.EventHandler(this.tbtnEnable_Click);
   // 
   // toolStripSeparator5
   // 
   this.toolStripSeparator5.Name = "toolStripSeparator5";
   this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
   // 
   // tbtnDisable
   // 
   this.tbtnDisable.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDisable.Image")));
   this.tbtnDisable.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnDisable.Name = "tbtnDisable";
   this.tbtnDisable.Size = new System.Drawing.Size(74, 26);
   this.tbtnDisable.Text = " Disable";
   this.tbtnDisable.Click += new System.EventHandler(this.tbtnDisable_Click);
   // 
   // toolStripSeparator6
   // 
   this.toolStripSeparator6.Name = "toolStripSeparator6";
   this.toolStripSeparator6.Size = new System.Drawing.Size(6, 29);
   // 
   // tbtnExportExcel
   // 
   this.tbtnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("tbtnExportExcel.Image")));
   this.tbtnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnExportExcel.Name = "tbtnExportExcel";
   this.tbtnExportExcel.Size = new System.Drawing.Size(117, 26);
   this.tbtnExportExcel.Text = "Export to Excel";
   this.tbtnExportExcel.Click += new System.EventHandler(this.tbtnExportExcel_Click);
   // 
   // toolStripSeparator7
   // 
   this.toolStripSeparator7.Name = "toolStripSeparator7";
   this.toolStripSeparator7.Size = new System.Drawing.Size(6, 29);
   // 
   // tbtnClose
   // 
   this.tbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tbtnClose.Image")));
   this.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
   this.tbtnClose.Name = "tbtnClose";
   this.tbtnClose.Size = new System.Drawing.Size(110, 26);
   this.tbtnClose.Text = "Close Window";
   this.tbtnClose.ToolTipText = "Close window";
   this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
   // 
   // cmbDivision
   // 
   this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbDivision.FormattingEnabled = true;
   this.cmbDivision.Location = new System.Drawing.Point(630, 51);
   this.cmbDivision.Name = "cmbDivision";
   this.cmbDivision.Size = new System.Drawing.Size(229, 21);
   this.cmbDivision.TabIndex = 6;
   this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
   // 
   // label23
   // 
   this.label23.AutoSize = true;
   this.label23.BackColor = System.Drawing.Color.Transparent;
   this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label23.Location = new System.Drawing.Point(558, 56);
   this.label23.Name = "label23";
   this.label23.Size = new System.Drawing.Size(47, 13);
   this.label23.TabIndex = 13;
   this.label23.Text = "Division:";
   // 
   // label21
   // 
   this.label21.AutoSize = true;
   this.label21.BackColor = System.Drawing.Color.Transparent;
   this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label21.Location = new System.Drawing.Point(16, 108);
   this.label21.Name = "label21";
   this.label21.Size = new System.Drawing.Size(40, 13);
   this.label21.TabIndex = 12;
   this.label21.Text = "Status:";
   // 
   // cmbStatus
   // 
   this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbStatus.FormattingEnabled = true;
   this.cmbStatus.Location = new System.Drawing.Point(78, 104);
   this.cmbStatus.Name = "cmbStatus";
   this.cmbStatus.Size = new System.Drawing.Size(86, 21);
   this.cmbStatus.TabIndex = 2;
   // 
   // label19
   // 
   this.label19.AutoSize = true;
   this.label19.BackColor = System.Drawing.Color.Transparent;
   this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label19.Location = new System.Drawing.Point(302, 110);
   this.label19.Name = "label19";
   this.label19.Size = new System.Drawing.Size(59, 13);
   this.label19.TabIndex = 9;
   this.label19.Text = "Job Grade:";
   // 
   // cmbJobGrade
   // 
   this.cmbJobGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbJobGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbJobGrade.FormattingEnabled = true;
   this.cmbJobGrade.Location = new System.Drawing.Point(407, 105);
   this.cmbJobGrade.Name = "cmbJobGrade";
   this.cmbJobGrade.Size = new System.Drawing.Size(86, 21);
   this.cmbJobGrade.TabIndex = 5;
   // 
   // cmbEmployeeType
   // 
   this.cmbEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbEmployeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbEmployeeType.FormattingEnabled = true;
   this.cmbEmployeeType.Location = new System.Drawing.Point(407, 51);
   this.cmbEmployeeType.Name = "cmbEmployeeType";
   this.cmbEmployeeType.Size = new System.Drawing.Size(134, 21);
   this.cmbEmployeeType.TabIndex = 3;
   // 
   // cmbEmployeeStatus
   // 
   this.cmbEmployeeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cmbEmployeeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cmbEmployeeStatus.FormattingEnabled = true;
   this.cmbEmployeeStatus.Location = new System.Drawing.Point(407, 78);
   this.cmbEmployeeStatus.Name = "cmbEmployeeStatus";
   this.cmbEmployeeStatus.Size = new System.Drawing.Size(134, 21);
   this.cmbEmployeeStatus.TabIndex = 4;
   // 
   // label17
   // 
   this.label17.AutoSize = true;
   this.label17.BackColor = System.Drawing.Color.Transparent;
   this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label17.Location = new System.Drawing.Point(302, 82);
   this.label17.Name = "label17";
   this.label17.Size = new System.Drawing.Size(100, 13);
   this.label17.TabIndex = 5;
   this.label17.Text = "Employment Status:";
   // 
   // label16
   // 
   this.label16.AutoSize = true;
   this.label16.BackColor = System.Drawing.Color.Transparent;
   this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label16.Location = new System.Drawing.Point(302, 56);
   this.label16.Name = "label16";
   this.label16.Size = new System.Drawing.Size(83, 13);
   this.label16.TabIndex = 4;
   this.label16.Text = "Employee Type:";
   // 
   // label7
   // 
   this.label7.AutoSize = true;
   this.label7.BackColor = System.Drawing.Color.Transparent;
   this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label7.Location = new System.Drawing.Point(7, 34);
   this.label7.Name = "label7";
   this.label7.Size = new System.Drawing.Size(86, 13);
   this.label7.TabIndex = 3;
   this.label7.Text = "Filter Options:";
   // 
   // pnlBody
   // 
   this.pnlBody.Controls.Add(this.pnlList);
   this.pnlBody.Controls.Add(this.pnlEmployeeDetails);
   this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlBody.Location = new System.Drawing.Point(0, 136);
   this.pnlBody.Name = "pnlBody";
   this.pnlBody.Size = new System.Drawing.Size(1028, 337);
   this.pnlBody.TabIndex = 2;
   // 
   // pnlList
   // 
   this.pnlList.Controls.Add(this.dgEmployeeList);
   this.pnlList.Controls.Add(this.pnlListHeader);
   this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlList.Location = new System.Drawing.Point(320, 0);
   this.pnlList.Name = "pnlList";
   this.pnlList.Size = new System.Drawing.Size(708, 337);
   this.pnlList.TabIndex = 1;
   // 
   // dgEmployeeList
   // 
   this.dgEmployeeList.AllowUserToAddRows = false;
   this.dgEmployeeList.AllowUserToDeleteRows = false;
   this.dgEmployeeList.AllowUserToOrderColumns = true;
   dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
   this.dgEmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
   this.dgEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
   this.dgEmployeeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername,
            this.colEmployeeNumber,
            this.colLastName,
            this.colFirstName,
            this.colJobGrade,
            this.colEmployeeType,
            this.colEmploymentStatus,
            this.colDivision,
            this.colGroup,
            this.colDepartment});
   this.dgEmployeeList.Cursor = System.Windows.Forms.Cursors.Default;
   this.dgEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
   this.dgEmployeeList.Location = new System.Drawing.Point(0, 28);
   this.dgEmployeeList.MultiSelect = false;
   this.dgEmployeeList.Name = "dgEmployeeList";
   this.dgEmployeeList.ReadOnly = true;
   this.dgEmployeeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
   this.dgEmployeeList.RowHeadersWidth = 20;
   this.dgEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   this.dgEmployeeList.Size = new System.Drawing.Size(708, 309);
   this.dgEmployeeList.TabIndex = 9;
   this.dgEmployeeList.VirtualMode = true;
   this.dgEmployeeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployeeList_CellDoubleClick);
   this.dgEmployeeList.SelectionChanged += new System.EventHandler(this.dgEmployeeList_SelectionChanged);
   // 
   // colUsername
   // 
   this.colUsername.Frozen = true;
   this.colUsername.HeaderText = "Username";
   this.colUsername.Name = "colUsername";
   this.colUsername.ReadOnly = true;
   this.colUsername.Visible = false;
   // 
   // colEmployeeNumber
   // 
   this.colEmployeeNumber.Frozen = true;
   this.colEmployeeNumber.HeaderText = "Number";
   this.colEmployeeNumber.Name = "colEmployeeNumber";
   this.colEmployeeNumber.ReadOnly = true;
   this.colEmployeeNumber.Width = 60;
   // 
   // colLastName
   // 
   dataGridViewCellStyle2.Format = "N2";
   dataGridViewCellStyle2.NullValue = null;
   this.colLastName.DefaultCellStyle = dataGridViewCellStyle2;
   this.colLastName.Frozen = true;
   this.colLastName.HeaderText = "Last Name";
   this.colLastName.Name = "colLastName";
   this.colLastName.ReadOnly = true;
   this.colLastName.Width = 130;
   // 
   // colFirstName
   // 
   this.colFirstName.Frozen = true;
   this.colFirstName.HeaderText = "First Name";
   this.colFirstName.Name = "colFirstName";
   this.colFirstName.ReadOnly = true;
   this.colFirstName.Width = 130;
   // 
   // colJobGrade
   // 
   dataGridViewCellStyle3.Format = "N2";
   dataGridViewCellStyle3.NullValue = null;
   this.colJobGrade.DefaultCellStyle = dataGridViewCellStyle3;
   this.colJobGrade.HeaderText = "JG";
   this.colJobGrade.Name = "colJobGrade";
   this.colJobGrade.ReadOnly = true;
   this.colJobGrade.Width = 45;
   // 
   // colEmployeeType
   // 
   this.colEmployeeType.HeaderText = "Employee Type";
   this.colEmployeeType.Name = "colEmployeeType";
   this.colEmployeeType.ReadOnly = true;
   this.colEmployeeType.Width = 110;
   // 
   // colEmploymentStatus
   // 
   this.colEmploymentStatus.HeaderText = "Status";
   this.colEmploymentStatus.Name = "colEmploymentStatus";
   this.colEmploymentStatus.ReadOnly = true;
   // 
   // colDivision
   // 
   this.colDivision.HeaderText = "Division";
   this.colDivision.Name = "colDivision";
   this.colDivision.ReadOnly = true;
   this.colDivision.Width = 180;
   // 
   // colGroup
   // 
   this.colGroup.HeaderText = "Group";
   this.colGroup.Name = "colGroup";
   this.colGroup.ReadOnly = true;
   this.colGroup.Width = 200;
   // 
   // colDepartment
   // 
   this.colDepartment.HeaderText = "Department";
   this.colDepartment.Name = "colDepartment";
   this.colDepartment.ReadOnly = true;
   this.colDepartment.Width = 200;
   // 
   // pnlListHeader
   // 
   this.pnlListHeader.BackColor = System.Drawing.Color.AliceBlue;
   this.pnlListHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlListHeader.BackgroundImage")));
   this.pnlListHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
   this.pnlListHeader.Controls.Add(this.chkShowDetails);
   this.pnlListHeader.Controls.Add(this.pictureBox2);
   this.pnlListHeader.Controls.Add(this.label12);
   this.pnlListHeader.Dock = System.Windows.Forms.DockStyle.Top;
   this.pnlListHeader.Location = new System.Drawing.Point(0, 0);
   this.pnlListHeader.Name = "pnlListHeader";
   this.pnlListHeader.Size = new System.Drawing.Size(708, 28);
   this.pnlListHeader.TabIndex = 4;
   // 
   // chkShowDetails
   // 
   this.chkShowDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
   this.chkShowDetails.AutoSize = true;
   this.chkShowDetails.BackColor = System.Drawing.Color.Transparent;
   this.chkShowDetails.Checked = true;
   this.chkShowDetails.CheckState = System.Windows.Forms.CheckState.Checked;
   this.chkShowDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.chkShowDetails.Location = new System.Drawing.Point(572, 5);
   this.chkShowDetails.Name = "chkShowDetails";
   this.chkShowDetails.Size = new System.Drawing.Size(131, 19);
   this.chkShowDetails.TabIndex = 0;
   this.chkShowDetails.Text = "Show Basic Details";
   this.chkShowDetails.UseVisualStyleBackColor = false;
   this.chkShowDetails.CheckedChanged += new System.EventHandler(this.chkShowDetails_CheckedChanged);
   // 
   // pictureBox2
   // 
   this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
   this.pictureBox2.Location = new System.Drawing.Point(8, 5);
   this.pictureBox2.Name = "pictureBox2";
   this.pictureBox2.Size = new System.Drawing.Size(16, 16);
   this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
   this.pictureBox2.TabIndex = 3;
   this.pictureBox2.TabStop = false;
   // 
   // label12
   // 
   this.label12.AutoSize = true;
   this.label12.BackColor = System.Drawing.Color.Transparent;
   this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label12.Location = new System.Drawing.Point(28, 5);
   this.label12.Name = "label12";
   this.label12.Size = new System.Drawing.Size(113, 15);
   this.label12.TabIndex = 2;
   this.label12.Text = "List of Employee";
   // 
   // pnlEmployeeDetails
   // 
   this.pnlEmployeeDetails.BackColor = System.Drawing.Color.White;
   this.pnlEmployeeDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEmployeeDetails.BackgroundImage")));
   this.pnlEmployeeDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
   this.pnlEmployeeDetails.Controls.Add(this.lvEmployeeDetails);
   this.pnlEmployeeDetails.Controls.Add(this.picEmployee);
   this.pnlEmployeeDetails.Controls.Add(this.label1);
   this.pnlEmployeeDetails.Dock = System.Windows.Forms.DockStyle.Left;
   this.pnlEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.pnlEmployeeDetails.Location = new System.Drawing.Point(0, 0);
   this.pnlEmployeeDetails.Name = "pnlEmployeeDetails";
   this.pnlEmployeeDetails.Size = new System.Drawing.Size(320, 337);
   this.pnlEmployeeDetails.TabIndex = 0;
   // 
   // lvEmployeeDetails
   // 
   this.lvEmployeeDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colField,
            this.colValue});
   this.lvEmployeeDetails.GridLines = true;
   this.lvEmployeeDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
   this.lvEmployeeDetails.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
   this.lvEmployeeDetails.Location = new System.Drawing.Point(11, 339);
   this.lvEmployeeDetails.Name = "lvEmployeeDetails";
   this.lvEmployeeDetails.Size = new System.Drawing.Size(297, 233);
   this.lvEmployeeDetails.TabIndex = 47;
   this.lvEmployeeDetails.UseCompatibleStateImageBehavior = false;
   this.lvEmployeeDetails.View = System.Windows.Forms.View.Details;
   // 
   // colField
   // 
   this.colField.Text = "";
   this.colField.Width = 90;
   // 
   // colValue
   // 
   this.colValue.Text = "";
   this.colValue.Width = 200;
   // 
   // picEmployee
   // 
   this.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
   this.picEmployee.Image = ((System.Drawing.Image)(resources.GetObject("picEmployee.Image")));
   this.picEmployee.Location = new System.Drawing.Point(11, 34);
   this.picEmployee.Name = "picEmployee";
   this.picEmployee.Size = new System.Drawing.Size(295, 295);
   this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
   this.picEmployee.TabIndex = 19;
   this.picEmployee.TabStop = false;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.BackColor = System.Drawing.Color.Transparent;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(8, 10);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(131, 16);
   this.label1.TabIndex = 0;
   this.label1.Text = "Employee Details";
   // 
   // sfdExportExcel
   // 
   this.sfdExportExcel.Filter = "Excel files|*.xls";
   this.sfdExportExcel.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdExportExcel_FileOk);
   // 
   // frmEmployeeList
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(1028, 473);
   this.Controls.Add(this.pnlBody);
   this.Controls.Add(this.pnlHeader);
   this.Name = "frmEmployeeList";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Search";
   this.Activated += new System.EventHandler(this.frmEmployeeList_Activated);
   this.Deactivate += new System.EventHandler(this.frmEmployeeList_Deactivate);
   this.Load += new System.EventHandler(this.frmEmployeeList_Load);
   this.pnlHeader.ResumeLayout(false);
   this.pnlHeader.PerformLayout();
   this.tsButtons.ResumeLayout(false);
   this.tsButtons.PerformLayout();
   this.pnlBody.ResumeLayout(false);
   this.pnlList.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeList)).EndInit();
   this.pnlListHeader.ResumeLayout(false);
   this.pnlListHeader.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
   this.pnlEmployeeDetails.ResumeLayout(false);
   this.pnlEmployeeDetails.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Panel pnlHeader;
  private System.Windows.Forms.Panel pnlBody;
  private System.Windows.Forms.Panel pnlList;
  private System.Windows.Forms.Panel pnlEmployeeDetails;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.PictureBox picEmployee;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.Label label12;
  private System.Windows.Forms.Panel pnlListHeader;
  private System.Windows.Forms.PictureBox pictureBox2;
  private System.Windows.Forms.Label label19;
  private System.Windows.Forms.ComboBox cmbJobGrade;
  private System.Windows.Forms.ComboBox cmbEmployeeType;
  private System.Windows.Forms.ComboBox cmbEmployeeStatus;
  private System.Windows.Forms.Label label17;
  private System.Windows.Forms.Label label16;
  private System.Windows.Forms.ComboBox cmbDivision;
  private System.Windows.Forms.Label label23;
  private System.Windows.Forms.Label label21;
  private System.Windows.Forms.ComboBox cmbStatus;
  private System.Windows.Forms.ToolStrip tsButtons;
  private System.Windows.Forms.ToolStripButton tbtnAdd;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
  private System.Windows.Forms.ToolStripButton tbtnEdit;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
  private System.Windows.Forms.ToolStripButton tbtnDelete;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
  private System.Windows.Forms.ToolStripButton tbtnRefresh;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
  private System.Windows.Forms.ToolStripButton tbtnClose;
  private System.Windows.Forms.ToolStripButton tbtnEnable;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
  private System.Windows.Forms.ToolStripButton tbtnDisable;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
  private System.Windows.Forms.TextBox txtLastName;
  private System.Windows.Forms.Label label15;
  private System.Windows.Forms.ComboBox cmbDepartment;
  private System.Windows.Forms.Label label27;
  private System.Windows.Forms.ComboBox cmbGroup;
  private System.Windows.Forms.Label label25;
  private System.Windows.Forms.ListView lvEmployeeDetails;
  private System.Windows.Forms.ColumnHeader colField;
  private System.Windows.Forms.ColumnHeader colValue;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.ComboBox cmbGender;
  internal System.Windows.Forms.DataGridView dgEmployeeList;
  private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
  private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeNumber;
  private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
  private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
  private System.Windows.Forms.DataGridViewTextBoxColumn colJobGrade;
  private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeType;
  private System.Windows.Forms.DataGridViewTextBoxColumn colEmploymentStatus;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDivision;
  private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
  private System.Windows.Forms.CheckBox chkShowDetails;
  private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
  private System.Windows.Forms.ToolStripButton tbtnExportExcel;
  private System.Windows.Forms.SaveFileDialog sfdExportExcel;
  private System.Windows.Forms.Button btnSearch;
 }
}