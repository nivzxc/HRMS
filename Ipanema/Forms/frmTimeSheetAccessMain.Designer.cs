namespace Ipanema.Forms
{
 partial class frmTimeSheetAccessMain
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
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeSheetAccessMain));
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
   System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
   this.txtSearch = new System.Windows.Forms.TextBox();
   this.btnSearch = new System.Windows.Forms.Button();
   this.cboSearch = new System.Windows.Forms.ComboBox();
   this.label1 = new System.Windows.Forms.Label();
   this.cboUsername = new System.Windows.Forms.ComboBox();
   this.label2 = new System.Windows.Forms.Label();
   this.cboDepartment = new System.Windows.Forms.ComboBox();
   this.label3 = new System.Windows.Forms.Label();
   this.pnlBody = new System.Windows.Forms.Panel();
   this.btnClose = new System.Windows.Forms.Button();
   this.btnUnmarkAllDepartment = new System.Windows.Forms.Button();
   this.btnUnmarkAllUsername = new System.Windows.Forms.Button();
   this.btnSelectAllUsername = new System.Windows.Forms.Button();
   this.btnCheckAllDepartment = new System.Windows.Forms.Button();
   this.btnMoveLeft = new System.Windows.Forms.Button();
   this.dgvDepartment = new System.Windows.Forms.DataGridView();
   this.btnMoveRight = new System.Windows.Forms.Button();
   this.dgvUsername = new System.Windows.Forms.DataGridView();
   this.colChkDepartment = new System.Windows.Forms.DataGridViewCheckBoxColumn();
   this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colDeptUserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
   this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.colUsernameCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.pnlBody.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.dgvUsername)).BeginInit();
   this.SuspendLayout();
   // 
   // txtSearch
   // 
   this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.txtSearch.Location = new System.Drawing.Point(191, 15);
   this.txtSearch.MaxLength = 50;
   this.txtSearch.Name = "txtSearch";
   this.txtSearch.Size = new System.Drawing.Size(176, 21);
   this.txtSearch.TabIndex = 6;
   this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
   // 
   // btnSearch
   // 
   this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
   this.btnSearch.Location = new System.Drawing.Point(373, 14);
   this.btnSearch.Name = "btnSearch";
   this.btnSearch.Size = new System.Drawing.Size(26, 26);
   this.btnSearch.TabIndex = 5;
   this.btnSearch.UseVisualStyleBackColor = true;
   this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
   // 
   // cboSearch
   // 
   this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cboSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cboSearch.FormattingEnabled = true;
   this.cboSearch.Location = new System.Drawing.Point(83, 14);
   this.cboSearch.Name = "cboSearch";
   this.cboSearch.Size = new System.Drawing.Size(96, 23);
   this.cboSearch.TabIndex = 1;
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.BackColor = System.Drawing.Color.Transparent;
   this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label1.Location = new System.Drawing.Point(13, 17);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(64, 15);
   this.label1.TabIndex = 0;
   this.label1.Text = "Search by:";
   // 
   // cboUsername
   // 
   this.cboUsername.DropDownHeight = 120;
   this.cboUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cboUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cboUsername.FormattingEnabled = true;
   this.cboUsername.IntegralHeight = false;
   this.cboUsername.Location = new System.Drawing.Point(83, 54);
   this.cboUsername.Name = "cboUsername";
   this.cboUsername.Size = new System.Drawing.Size(196, 23);
   this.cboUsername.TabIndex = 0;
   this.cboUsername.SelectedIndexChanged += new System.EventHandler(this.cboUsername_SelectedIndexChanged);
   // 
   // label2
   // 
   this.label2.AutoSize = true;
   this.label2.BackColor = System.Drawing.Color.Transparent;
   this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label2.Location = new System.Drawing.Point(13, 58);
   this.label2.Name = "label2";
   this.label2.Size = new System.Drawing.Size(65, 15);
   this.label2.TabIndex = 1;
   this.label2.Text = "Username";
   // 
   // cboDepartment
   // 
   this.cboDepartment.DropDownHeight = 200;
   this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.cboDepartment.FormattingEnabled = true;
   this.cboDepartment.IntegralHeight = false;
   this.cboDepartment.ItemHeight = 15;
   this.cboDepartment.Location = new System.Drawing.Point(428, 54);
   this.cboDepartment.Name = "cboDepartment";
   this.cboDepartment.Size = new System.Drawing.Size(196, 23);
   this.cboDepartment.TabIndex = 2;
   this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
   // 
   // label3
   // 
   this.label3.AutoSize = true;
   this.label3.BackColor = System.Drawing.Color.Transparent;
   this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.label3.Location = new System.Drawing.Point(356, 57);
   this.label3.Name = "label3";
   this.label3.Size = new System.Drawing.Size(72, 15);
   this.label3.TabIndex = 3;
   this.label3.Text = "Department";
   // 
   // pnlBody
   // 
   this.pnlBody.BackColor = System.Drawing.Color.AliceBlue;
   this.pnlBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBody.BackgroundImage")));
   this.pnlBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
   this.pnlBody.Controls.Add(this.btnClose);
   this.pnlBody.Controls.Add(this.txtSearch);
   this.pnlBody.Controls.Add(this.btnUnmarkAllDepartment);
   this.pnlBody.Controls.Add(this.btnSearch);
   this.pnlBody.Controls.Add(this.btnUnmarkAllUsername);
   this.pnlBody.Controls.Add(this.cboSearch);
   this.pnlBody.Controls.Add(this.btnSelectAllUsername);
   this.pnlBody.Controls.Add(this.label1);
   this.pnlBody.Controls.Add(this.btnCheckAllDepartment);
   this.pnlBody.Controls.Add(this.btnMoveLeft);
   this.pnlBody.Controls.Add(this.dgvDepartment);
   this.pnlBody.Controls.Add(this.btnMoveRight);
   this.pnlBody.Controls.Add(this.dgvUsername);
   this.pnlBody.Controls.Add(this.cboDepartment);
   this.pnlBody.Controls.Add(this.label3);
   this.pnlBody.Controls.Add(this.cboUsername);
   this.pnlBody.Controls.Add(this.label2);
   this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
   this.pnlBody.Location = new System.Drawing.Point(0, 0);
   this.pnlBody.Name = "pnlBody";
   this.pnlBody.Size = new System.Drawing.Size(640, 577);
   this.pnlBody.TabIndex = 1;
   // 
   // btnClose
   // 
   this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
   this.btnClose.Location = new System.Drawing.Point(546, 523);
   this.btnClose.Name = "btnClose";
   this.btnClose.Size = new System.Drawing.Size(80, 38);
   this.btnClose.TabIndex = 18;
   this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnClose.UseVisualStyleBackColor = true;
   this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
   // 
   // btnUnmarkAllDepartment
   // 
   this.btnUnmarkAllDepartment.BackColor = System.Drawing.SystemColors.Control;
   this.btnUnmarkAllDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
   this.btnUnmarkAllDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnUnmarkAllDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnUnmarkAllDepartment.Image")));
   this.btnUnmarkAllDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnUnmarkAllDepartment.Location = new System.Drawing.Point(528, 480);
   this.btnUnmarkAllDepartment.Name = "btnUnmarkAllDepartment";
   this.btnUnmarkAllDepartment.Size = new System.Drawing.Size(98, 30);
   this.btnUnmarkAllDepartment.TabIndex = 12;
   this.btnUnmarkAllDepartment.Text = "Uncheck All";
   this.btnUnmarkAllDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnUnmarkAllDepartment.UseVisualStyleBackColor = false;
   this.btnUnmarkAllDepartment.Click += new System.EventHandler(this.btnUnmarkAllDepartment_Click);
   // 
   // btnUnmarkAllUsername
   // 
   this.btnUnmarkAllUsername.BackColor = System.Drawing.SystemColors.Control;
   this.btnUnmarkAllUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnUnmarkAllUsername.Image = ((System.Drawing.Image)(resources.GetObject("btnUnmarkAllUsername.Image")));
   this.btnUnmarkAllUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnUnmarkAllUsername.Location = new System.Drawing.Point(181, 481);
   this.btnUnmarkAllUsername.Name = "btnUnmarkAllUsername";
   this.btnUnmarkAllUsername.Size = new System.Drawing.Size(98, 30);
   this.btnUnmarkAllUsername.TabIndex = 11;
   this.btnUnmarkAllUsername.Text = "Uncheck All";
   this.btnUnmarkAllUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   this.btnUnmarkAllUsername.UseVisualStyleBackColor = false;
   this.btnUnmarkAllUsername.Click += new System.EventHandler(this.btnUnmarkAllUsername_Click);
   // 
   // btnSelectAllUsername
   // 
   this.btnSelectAllUsername.BackColor = System.Drawing.SystemColors.Control;
   this.btnSelectAllUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnSelectAllUsername.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectAllUsername.Image")));
   this.btnSelectAllUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnSelectAllUsername.Location = new System.Drawing.Point(76, 482);
   this.btnSelectAllUsername.Name = "btnSelectAllUsername";
   this.btnSelectAllUsername.Size = new System.Drawing.Size(98, 30);
   this.btnSelectAllUsername.TabIndex = 10;
   this.btnSelectAllUsername.Text = "     Check All";
   this.btnSelectAllUsername.UseVisualStyleBackColor = false;
   this.btnSelectAllUsername.Click += new System.EventHandler(this.btnSelectAllUsername_Click);
   // 
   // btnCheckAllDepartment
   // 
   this.btnCheckAllDepartment.BackColor = System.Drawing.SystemColors.Control;
   this.btnCheckAllDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnCheckAllDepartment.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckAllDepartment.Image")));
   this.btnCheckAllDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
   this.btnCheckAllDepartment.Location = new System.Drawing.Point(421, 481);
   this.btnCheckAllDepartment.Name = "btnCheckAllDepartment";
   this.btnCheckAllDepartment.Size = new System.Drawing.Size(98, 30);
   this.btnCheckAllDepartment.TabIndex = 9;
   this.btnCheckAllDepartment.Text = "     Check All";
   this.btnCheckAllDepartment.UseVisualStyleBackColor = false;
   this.btnCheckAllDepartment.Click += new System.EventHandler(this.btnCheckAllDepartment_Click);
   // 
   // btnMoveLeft
   // 
   this.btnMoveLeft.BackColor = System.Drawing.Color.AliceBlue;
   this.btnMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnMoveLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveLeft.Image")));
   this.btnMoveLeft.Location = new System.Drawing.Point(301, 231);
   this.btnMoveLeft.Name = "btnMoveLeft";
   this.btnMoveLeft.Size = new System.Drawing.Size(38, 32);
   this.btnMoveLeft.TabIndex = 6;
   this.btnMoveLeft.UseVisualStyleBackColor = false;
   this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
   // 
   // dgvDepartment
   // 
   this.dgvDepartment.AllowUserToAddRows = false;
   this.dgvDepartment.AllowUserToDeleteRows = false;
   this.dgvDepartment.AllowUserToResizeColumns = false;
   this.dgvDepartment.AllowUserToResizeRows = false;
   dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
   this.dgvDepartment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
   this.dgvDepartment.BackgroundColor = System.Drawing.Color.White;
   this.dgvDepartment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
   this.dgvDepartment.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
   dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
   dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
   dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
   dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
   dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
   dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
   this.dgvDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
   this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgvDepartment.ColumnHeadersVisible = false;
   this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChkDepartment,
            this.colDepartment,
            this.colDeptUserCode});
   dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
   dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
   dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
   dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
   dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
   dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
   this.dgvDepartment.DefaultCellStyle = dataGridViewCellStyle3;
   this.dgvDepartment.Location = new System.Drawing.Point(361, 84);
   this.dgvDepartment.MultiSelect = false;
   this.dgvDepartment.Name = "dgvDepartment";
   this.dgvDepartment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
   dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
   dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
   dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
   dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
   dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
   dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
   this.dgvDepartment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
   this.dgvDepartment.RowHeadersVisible = false;
   this.dgvDepartment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
   this.dgvDepartment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.dgvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   this.dgvDepartment.Size = new System.Drawing.Size(265, 389);
   this.dgvDepartment.TabIndex = 5;
   // 
   // btnMoveRight
   // 
   this.btnMoveRight.BackColor = System.Drawing.Color.AliceBlue;
   this.btnMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   this.btnMoveRight.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveRight.Image")));
   this.btnMoveRight.Location = new System.Drawing.Point(301, 280);
   this.btnMoveRight.Name = "btnMoveRight";
   this.btnMoveRight.Size = new System.Drawing.Size(38, 32);
   this.btnMoveRight.TabIndex = 8;
   this.btnMoveRight.UseVisualStyleBackColor = false;
   this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
   // 
   // dgvUsername
   // 
   this.dgvUsername.AllowUserToAddRows = false;
   this.dgvUsername.AllowUserToDeleteRows = false;
   this.dgvUsername.AllowUserToResizeColumns = false;
   this.dgvUsername.AllowUserToResizeRows = false;
   dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
   this.dgvUsername.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
   this.dgvUsername.BackgroundColor = System.Drawing.Color.White;
   this.dgvUsername.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
   this.dgvUsername.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
   dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
   dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
   dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
   dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
   dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
   dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
   this.dgvUsername.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
   this.dgvUsername.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgvUsername.ColumnHeadersVisible = false;
   this.dgvUsername.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.colUsername,
            this.colUsernameCode});
   dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
   dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
   dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
   dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
   dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
   dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
   this.dgvUsername.DefaultCellStyle = dataGridViewCellStyle7;
   this.dgvUsername.Location = new System.Drawing.Point(14, 84);
   this.dgvUsername.MultiSelect = false;
   this.dgvUsername.Name = "dgvUsername";
   this.dgvUsername.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
   dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
   dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
   dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
   dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
   dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
   dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
   this.dgvUsername.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
   this.dgvUsername.RowHeadersVisible = false;
   this.dgvUsername.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
   this.dgvUsername.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
   this.dgvUsername.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   this.dgvUsername.Size = new System.Drawing.Size(265, 390);
   this.dgvUsername.TabIndex = 5;
   // 
   // colChkDepartment
   // 
   this.colChkDepartment.HeaderText = "";
   this.colChkDepartment.Name = "colChkDepartment";
   this.colChkDepartment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
   this.colChkDepartment.Width = 20;
   // 
   // colDepartment
   // 
   this.colDepartment.HeaderText = "";
   this.colDepartment.Name = "colDepartment";
   this.colDepartment.ReadOnly = true;
   this.colDepartment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
   this.colDepartment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
   this.colDepartment.Width = 250;
   // 
   // colDeptUserCode
   // 
   this.colDeptUserCode.HeaderText = "Username Code";
   this.colDeptUserCode.Name = "colDeptUserCode";
   this.colDeptUserCode.ReadOnly = true;
   this.colDeptUserCode.Visible = false;
   // 
   // colChk
   // 
   this.colChk.HeaderText = "";
   this.colChk.Name = "colChk";
   this.colChk.Resizable = System.Windows.Forms.DataGridViewTriState.False;
   this.colChk.Width = 20;
   // 
   // colUsername
   // 
   this.colUsername.HeaderText = "";
   this.colUsername.Name = "colUsername";
   this.colUsername.ReadOnly = true;
   this.colUsername.Resizable = System.Windows.Forms.DataGridViewTriState.False;
   this.colUsername.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
   this.colUsername.Width = 250;
   // 
   // colUsernameCode
   // 
   this.colUsernameCode.HeaderText = "Username Code";
   this.colUsernameCode.Name = "colUsernameCode";
   this.colUsernameCode.ReadOnly = true;
   this.colUsernameCode.Visible = false;
   // 
   // frmTimeSheetAccessMain
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.CancelButton = this.btnClose;
   this.ClientSize = new System.Drawing.Size(640, 577);
   this.Controls.Add(this.pnlBody);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "frmTimeSheetAccessMain";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Time Sheet Access Main";
   this.Load += new System.EventHandler(this.frmTimeSheetAccessMain_Load);
   this.pnlBody.ResumeLayout(false);
   this.pnlBody.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.dgvUsername)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.ComboBox cboSearch;
  private System.Windows.Forms.Button btnSearch;
  private System.Windows.Forms.TextBox txtSearch;
  private System.Windows.Forms.ComboBox cboUsername;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.ComboBox cboDepartment;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Panel pnlBody;
  private System.Windows.Forms.DataGridView dgvDepartment;
  private System.Windows.Forms.Button btnMoveRight;
  private System.Windows.Forms.Button btnMoveLeft;
  private System.Windows.Forms.DataGridView dgvUsername;
  private System.Windows.Forms.Button btnSelectAllUsername;
  private System.Windows.Forms.Button btnCheckAllDepartment;
  private System.Windows.Forms.Button btnUnmarkAllUsername;
  private System.Windows.Forms.Button btnUnmarkAllDepartment;
  private System.Windows.Forms.Button btnClose;
  private System.Windows.Forms.DataGridViewCheckBoxColumn colChkDepartment;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
  private System.Windows.Forms.DataGridViewTextBoxColumn colDeptUserCode;
  private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
  private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
  private System.Windows.Forms.DataGridViewTextBoxColumn colUsernameCode;
 }
}