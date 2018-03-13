namespace Ipanema.Forms
{
    partial class frmPerfectAttendance
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfectAttendance));
         Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
         Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
         Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
         this.bsPAOB = new System.Windows.Forms.BindingSource(this.components);
         this.dsPerfectAttendanceOBDetails = new Ipanema.dsPerfectAttendanceOBDetails();
         this.bsPADetails = new System.Windows.Forms.BindingSource(this.components);
         this.dsPerfectAttendanceDetails = new Ipanema.dsPerfectAttendanceDetails();
         this.bsPA = new System.Windows.Forms.BindingSource(this.components);
         this.dsPerfectAttendance = new Ipanema.dsPerfectAttendance();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.tbtnClose = new System.Windows.Forms.ToolStripButton();
         this.panel2 = new System.Windows.Forms.Panel();
         this.panel9 = new System.Windows.Forms.Panel();
         this.pnlOB = new System.Windows.Forms.Panel();
         this.panel18 = new System.Windows.Forms.Panel();
         this.rptPAOB = new Microsoft.Reporting.WinForms.ReportViewer();
         this.panel19 = new System.Windows.Forms.Panel();
         this.label8 = new System.Windows.Forms.Label();
         this.pnlDetail = new System.Windows.Forms.Panel();
         this.panel8 = new System.Windows.Forms.Panel();
         this.rptPADetails = new Microsoft.Reporting.WinForms.ReportViewer();
         this.panel12 = new System.Windows.Forms.Panel();
         this.label6 = new System.Windows.Forms.Label();
         this.pnlSummary = new System.Windows.Forms.Panel();
         this.panel14 = new System.Windows.Forms.Panel();
         this.rptPerfectAttendance = new Microsoft.Reporting.WinForms.ReportViewer();
         this.panel13 = new System.Windows.Forms.Panel();
         this.label7 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel16 = new System.Windows.Forms.Panel();
         this.prog1 = new System.Windows.Forms.ProgressBar();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.panel3 = new System.Windows.Forms.Panel();
         this.label1 = new System.Windows.Forms.Label();
         this.btnSearch = new System.Windows.Forms.Button();
         this.panel4 = new System.Windows.Forms.Panel();
         this.label3 = new System.Windows.Forms.Label();
         this.panel5 = new System.Windows.Forms.Panel();
         this.DateStart = new System.Windows.Forms.DateTimePicker();
         this.panel6 = new System.Windows.Forms.Panel();
         this.label2 = new System.Windows.Forms.Label();
         this.panel7 = new System.Windows.Forms.Panel();
         this.DateEnd = new System.Windows.Forms.DateTimePicker();
         this.panel11 = new System.Windows.Forms.Panel();
         this.label4 = new System.Windows.Forms.Label();
         this.panel10 = new System.Windows.Forms.Panel();
         this.label5 = new System.Windows.Forms.Label();
         this.txtinterval = new System.Windows.Forms.TextBox();
         this.panel17 = new System.Windows.Forms.Panel();
         this.rdPAOB = new System.Windows.Forms.RadioButton();
         this.rdDetail = new System.Windows.Forms.RadioButton();
         this.rdSummary = new System.Windows.Forms.RadioButton();
         ((System.ComponentModel.ISupportInitialize)(this.bsPAOB)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dsPerfectAttendanceOBDetails)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bsPADetails)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dsPerfectAttendanceDetails)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bsPA)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dsPerfectAttendance)).BeginInit();
         this.toolStrip1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.panel9.SuspendLayout();
         this.pnlOB.SuspendLayout();
         this.panel18.SuspendLayout();
         this.panel19.SuspendLayout();
         this.pnlDetail.SuspendLayout();
         this.panel8.SuspendLayout();
         this.panel12.SuspendLayout();
         this.pnlSummary.SuspendLayout();
         this.panel14.SuspendLayout();
         this.panel13.SuspendLayout();
         this.panel1.SuspendLayout();
         this.panel16.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         this.panel3.SuspendLayout();
         this.panel4.SuspendLayout();
         this.panel5.SuspendLayout();
         this.panel6.SuspendLayout();
         this.panel7.SuspendLayout();
         this.panel11.SuspendLayout();
         this.panel10.SuspendLayout();
         this.panel17.SuspendLayout();
         this.SuspendLayout();
         // 
         // bsPAOB
         // 
         this.bsPAOB.DataMember = "OBDetails";
         this.bsPAOB.DataSource = this.dsPerfectAttendanceOBDetails;
         // 
         // dsPerfectAttendanceOBDetails
         // 
         this.dsPerfectAttendanceOBDetails.DataSetName = "dsPerfectAttendanceOBDetails";
         this.dsPerfectAttendanceOBDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // bsPADetails
         // 
         this.bsPADetails.DataMember = "PerfectAttendanceDetails";
         this.bsPADetails.DataSource = this.dsPerfectAttendanceDetails;
         // 
         // dsPerfectAttendanceDetails
         // 
         this.dsPerfectAttendanceDetails.DataSetName = "dsPerfectAttendanceDetails";
         this.dsPerfectAttendanceDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // bsPA
         // 
         this.bsPA.DataMember = "UserName";
         this.bsPA.DataSource = this.dsPerfectAttendance;
         // 
         // dsPerfectAttendance
         // 
         this.dsPerfectAttendance.DataSetName = "dsPerfectAttendance";
         this.dsPerfectAttendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // toolStrip1
         // 
         this.toolStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnClose});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(846, 29);
         this.toolStrip1.TabIndex = 0;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // tbtnClose
         // 
         this.tbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tbtnClose.Image")));
         this.tbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.tbtnClose.Name = "tbtnClose";
         this.tbtnClose.Size = new System.Drawing.Size(109, 26);
         this.tbtnClose.Text = "Close Window";
         this.tbtnClose.ToolTipText = "Close window";
         this.tbtnClose.Click += new System.EventHandler(this.tbtnClose_Click);
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.panel9);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel2.Location = new System.Drawing.Point(0, 207);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(846, 292);
         this.panel2.TabIndex = 2;
         // 
         // panel9
         // 
         this.panel9.Controls.Add(this.pnlOB);
         this.panel9.Controls.Add(this.pnlDetail);
         this.panel9.Controls.Add(this.pnlSummary);
         this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel9.Location = new System.Drawing.Point(0, 0);
         this.panel9.Margin = new System.Windows.Forms.Padding(0);
         this.panel9.Name = "panel9";
         this.panel9.Size = new System.Drawing.Size(846, 292);
         this.panel9.TabIndex = 1;
         // 
         // pnlOB
         // 
         this.pnlOB.Controls.Add(this.panel18);
         this.pnlOB.Controls.Add(this.panel19);
         this.pnlOB.Location = new System.Drawing.Point(172, 162);
         this.pnlOB.Margin = new System.Windows.Forms.Padding(0);
         this.pnlOB.Name = "pnlOB";
         this.pnlOB.Size = new System.Drawing.Size(478, 129);
         this.pnlOB.TabIndex = 3;
         // 
         // panel18
         // 
         this.panel18.Controls.Add(this.rptPAOB);
         this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel18.Location = new System.Drawing.Point(0, 28);
         this.panel18.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
         this.panel18.Name = "panel18";
         this.panel18.Size = new System.Drawing.Size(478, 101);
         this.panel18.TabIndex = 2;
         // 
         // rptPAOB
         // 
         this.rptPAOB.Dock = System.Windows.Forms.DockStyle.Fill;
         this.rptPAOB.DocumentMapWidth = 91;
         reportDataSource1.Name = "dsPAOB";
         reportDataSource1.Value = this.bsPAOB;
         this.rptPAOB.LocalReport.DataSources.Add(reportDataSource1);
         this.rptPAOB.LocalReport.ReportEmbeddedResource = "Ipanema.Reports.rptPAOB.rdlc";
         this.rptPAOB.Location = new System.Drawing.Point(0, 0);
         this.rptPAOB.Name = "rptPAOB";
         this.rptPAOB.Size = new System.Drawing.Size(478, 101);
         this.rptPAOB.TabIndex = 1;
         // 
         // panel19
         // 
         this.panel19.BackColor = System.Drawing.Color.LightSteelBlue;
         this.panel19.Controls.Add(this.label8);
         this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel19.Location = new System.Drawing.Point(0, 0);
         this.panel19.Margin = new System.Windows.Forms.Padding(0);
         this.panel19.Name = "panel19";
         this.panel19.Size = new System.Drawing.Size(478, 28);
         this.panel19.TabIndex = 2;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.Location = new System.Drawing.Point(4, 5);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(181, 15);
         this.label8.TabIndex = 0;
         this.label8.Text = "Employee Official Business";
         // 
         // pnlDetail
         // 
         this.pnlDetail.Controls.Add(this.panel8);
         this.pnlDetail.Controls.Add(this.panel12);
         this.pnlDetail.Location = new System.Drawing.Point(469, 30);
         this.pnlDetail.Margin = new System.Windows.Forms.Padding(0);
         this.pnlDetail.Name = "pnlDetail";
         this.pnlDetail.Size = new System.Drawing.Size(335, 117);
         this.pnlDetail.TabIndex = 2;
         // 
         // panel8
         // 
         this.panel8.Controls.Add(this.rptPADetails);
         this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel8.Location = new System.Drawing.Point(0, 28);
         this.panel8.Margin = new System.Windows.Forms.Padding(0);
         this.panel8.Name = "panel8";
         this.panel8.Size = new System.Drawing.Size(335, 89);
         this.panel8.TabIndex = 1;
         // 
         // rptPADetails
         // 
         this.rptPADetails.Dock = System.Windows.Forms.DockStyle.Fill;
         reportDataSource2.Name = "dsPerfectAttendanceDetails";
         reportDataSource2.Value = this.bsPADetails;
         this.rptPADetails.LocalReport.DataSources.Add(reportDataSource2);
         this.rptPADetails.LocalReport.ReportEmbeddedResource = "Ipanema.Reports.rptPerfectAttendanceDetails.rdlc";
         this.rptPADetails.Location = new System.Drawing.Point(0, 0);
         this.rptPADetails.Name = "rptPADetails";
         this.rptPADetails.Size = new System.Drawing.Size(335, 89);
         this.rptPADetails.TabIndex = 4;
         // 
         // panel12
         // 
         this.panel12.BackColor = System.Drawing.Color.LightSteelBlue;
         this.panel12.Controls.Add(this.label6);
         this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel12.Location = new System.Drawing.Point(0, 0);
         this.panel12.Margin = new System.Windows.Forms.Padding(0);
         this.panel12.Name = "panel12";
         this.panel12.Size = new System.Drawing.Size(335, 28);
         this.panel12.TabIndex = 0;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(3, 5);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(273, 15);
         this.label6.TabIndex = 0;
         this.label6.Text = "Employee Perfect Attendance with Details";
         // 
         // pnlSummary
         // 
         this.pnlSummary.Controls.Add(this.panel14);
         this.pnlSummary.Controls.Add(this.panel13);
         this.pnlSummary.Location = new System.Drawing.Point(13, 18);
         this.pnlSummary.Margin = new System.Windows.Forms.Padding(0);
         this.pnlSummary.Name = "pnlSummary";
         this.pnlSummary.Size = new System.Drawing.Size(395, 129);
         this.pnlSummary.TabIndex = 0;
         // 
         // panel14
         // 
         this.panel14.Controls.Add(this.rptPerfectAttendance);
         this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel14.Location = new System.Drawing.Point(0, 28);
         this.panel14.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
         this.panel14.Name = "panel14";
         this.panel14.Size = new System.Drawing.Size(395, 101);
         this.panel14.TabIndex = 2;
         // 
         // rptPerfectAttendance
         // 
         this.rptPerfectAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
         this.rptPerfectAttendance.DocumentMapWidth = 91;
         reportDataSource3.Name = "dsPerfectAttendance";
         reportDataSource3.Value = this.bsPA;
         this.rptPerfectAttendance.LocalReport.DataSources.Add(reportDataSource3);
         this.rptPerfectAttendance.LocalReport.EnableExternalImages = true;
         this.rptPerfectAttendance.LocalReport.ReportEmbeddedResource = "Ipanema.Reports.rptPerfectAttendance.rdlc";
         this.rptPerfectAttendance.Location = new System.Drawing.Point(0, 0);
         this.rptPerfectAttendance.Name = "rptPerfectAttendance";
         this.rptPerfectAttendance.Size = new System.Drawing.Size(395, 101);
         this.rptPerfectAttendance.TabIndex = 1;
         // 
         // panel13
         // 
         this.panel13.BackColor = System.Drawing.Color.LightSteelBlue;
         this.panel13.Controls.Add(this.label7);
         this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel13.Location = new System.Drawing.Point(0, 0);
         this.panel13.Margin = new System.Windows.Forms.Padding(0);
         this.panel13.Name = "panel13";
         this.panel13.Size = new System.Drawing.Size(395, 28);
         this.panel13.TabIndex = 2;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(4, 5);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(194, 15);
         this.label7.TabIndex = 0;
         this.label7.Text = "Employee Perfect Attendance";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.AliceBlue;
         this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
         this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.panel1.Controls.Add(this.panel16);
         this.panel1.Controls.Add(this.tableLayoutPanel1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 29);
         this.panel1.Margin = new System.Windows.Forms.Padding(0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(846, 178);
         this.panel1.TabIndex = 1;
         // 
         // panel16
         // 
         this.panel16.BackColor = System.Drawing.Color.Transparent;
         this.panel16.Controls.Add(this.prog1);
         this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel16.Location = new System.Drawing.Point(0, 164);
         this.panel16.Name = "panel16";
         this.panel16.Size = new System.Drawing.Size(846, 14);
         this.panel16.TabIndex = 39;
         // 
         // prog1
         // 
         this.prog1.BackColor = System.Drawing.Color.AliceBlue;
         this.prog1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.prog1.Location = new System.Drawing.Point(0, 0);
         this.prog1.Name = "prog1";
         this.prog1.Size = new System.Drawing.Size(846, 14);
         this.prog1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
         this.prog1.TabIndex = 38;
         this.prog1.Visible = false;
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
         this.tableLayoutPanel1.ColumnCount = 4;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69642F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.97487F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.93772F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.391F));
         this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 1);
         this.tableLayoutPanel1.Controls.Add(this.panel7, 3, 1);
         this.tableLayoutPanel1.Controls.Add(this.panel11, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.panel10, 1, 2);
         this.tableLayoutPanel1.Controls.Add(this.panel17, 0, 3);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 20);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 4;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 128);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // panel3
         // 
         this.tableLayoutPanel1.SetColumnSpan(this.panel3, 4);
         this.panel3.Controls.Add(this.label1);
         this.panel3.Controls.Add(this.btnSearch);
         this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel3.Location = new System.Drawing.Point(1, 1);
         this.panel3.Margin = new System.Windows.Forms.Padding(0);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(420, 30);
         this.panel3.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(4, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(52, 15);
         this.label1.TabIndex = 1;
         this.label1.Text = "Search";
         // 
         // btnSearch
         // 
         this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
         this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btnSearch.Location = new System.Drawing.Point(341, 1);
         this.btnSearch.Name = "btnSearch";
         this.btnSearch.Size = new System.Drawing.Size(78, 28);
         this.btnSearch.TabIndex = 37;
         this.btnSearch.Text = "Search";
         this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btnSearch.UseVisualStyleBackColor = true;
         this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
         // 
         // panel4
         // 
         this.panel4.Controls.Add(this.label3);
         this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel4.Location = new System.Drawing.Point(1, 32);
         this.panel4.Margin = new System.Windows.Forms.Padding(0);
         this.panel4.Name = "panel4";
         this.panel4.Size = new System.Drawing.Size(86, 30);
         this.panel4.TabIndex = 1;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(4, 7);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(64, 15);
         this.label3.TabIndex = 0;
         this.label3.Text = "Start Date:";
         // 
         // panel5
         // 
         this.panel5.Controls.Add(this.DateStart);
         this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel5.Location = new System.Drawing.Point(88, 32);
         this.panel5.Margin = new System.Windows.Forms.Padding(0);
         this.panel5.Name = "panel5";
         this.panel5.Size = new System.Drawing.Size(124, 30);
         this.panel5.TabIndex = 2;
         // 
         // DateStart
         // 
         this.DateStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.DateStart.CustomFormat = "MMM dd, yyyy";
         this.DateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.DateStart.Location = new System.Drawing.Point(5, 5);
         this.DateStart.Name = "DateStart";
         this.DateStart.Size = new System.Drawing.Size(114, 21);
         this.DateStart.TabIndex = 3;
         this.DateStart.Value = new System.DateTime(2011, 4, 12, 0, 0, 0, 0);
         // 
         // panel6
         // 
         this.panel6.Controls.Add(this.label2);
         this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel6.Location = new System.Drawing.Point(213, 32);
         this.panel6.Margin = new System.Windows.Forms.Padding(0);
         this.panel6.Name = "panel6";
         this.panel6.Size = new System.Drawing.Size(74, 30);
         this.panel6.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(4, 7);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(61, 15);
         this.label2.TabIndex = 0;
         this.label2.Text = "End Date:";
         // 
         // panel7
         // 
         this.panel7.Controls.Add(this.DateEnd);
         this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel7.Location = new System.Drawing.Point(288, 32);
         this.panel7.Margin = new System.Windows.Forms.Padding(0);
         this.panel7.Name = "panel7";
         this.panel7.Size = new System.Drawing.Size(133, 30);
         this.panel7.TabIndex = 4;
         // 
         // DateEnd
         // 
         this.DateEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.DateEnd.CustomFormat = "MMM dd, yyyy";
         this.DateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.DateEnd.Location = new System.Drawing.Point(5, 5);
         this.DateEnd.Name = "DateEnd";
         this.DateEnd.Size = new System.Drawing.Size(114, 21);
         this.DateEnd.TabIndex = 3;
         this.DateEnd.Value = new System.DateTime(2011, 4, 12, 0, 0, 0, 0);
         // 
         // panel11
         // 
         this.panel11.Controls.Add(this.label4);
         this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel11.Location = new System.Drawing.Point(1, 63);
         this.panel11.Margin = new System.Windows.Forms.Padding(0);
         this.panel11.Name = "panel11";
         this.panel11.Size = new System.Drawing.Size(86, 30);
         this.panel11.TabIndex = 8;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(4, 8);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(80, 15);
         this.label4.TabIndex = 0;
         this.label4.Text = "Time Interval:";
         // 
         // panel10
         // 
         this.tableLayoutPanel1.SetColumnSpan(this.panel10, 3);
         this.panel10.Controls.Add(this.label5);
         this.panel10.Controls.Add(this.txtinterval);
         this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel10.Location = new System.Drawing.Point(88, 63);
         this.panel10.Margin = new System.Windows.Forms.Padding(0);
         this.panel10.Name = "panel10";
         this.panel10.Size = new System.Drawing.Size(333, 30);
         this.panel10.TabIndex = 7;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(46, 8);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(183, 15);
         this.label5.TabIndex = 1;
         this.label5.Text = "minute(s) before the official hour";
         // 
         // txtinterval
         // 
         this.txtinterval.Location = new System.Drawing.Point(5, 5);
         this.txtinterval.MaxLength = 4;
         this.txtinterval.Name = "txtinterval";
         this.txtinterval.Size = new System.Drawing.Size(38, 21);
         this.txtinterval.TabIndex = 0;
         this.txtinterval.Text = "30";
         this.txtinterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinterval_KeyPress);
         // 
         // panel17
         // 
         this.tableLayoutPanel1.SetColumnSpan(this.panel17, 4);
         this.panel17.Controls.Add(this.rdPAOB);
         this.panel17.Controls.Add(this.rdDetail);
         this.panel17.Controls.Add(this.rdSummary);
         this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel17.Location = new System.Drawing.Point(1, 94);
         this.panel17.Margin = new System.Windows.Forms.Padding(0);
         this.panel17.Name = "panel17";
         this.panel17.Size = new System.Drawing.Size(420, 33);
         this.panel17.TabIndex = 9;
         // 
         // rdPAOB
         // 
         this.rdPAOB.AutoSize = true;
         this.rdPAOB.Location = new System.Drawing.Point(249, 6);
         this.rdPAOB.Name = "rdPAOB";
         this.rdPAOB.Size = new System.Drawing.Size(100, 19);
         this.rdPAOB.TabIndex = 4;
         this.rdPAOB.TabStop = true;
         this.rdPAOB.Text = "Employee OB";
         this.rdPAOB.UseVisualStyleBackColor = true;
         this.rdPAOB.CheckedChanged += new System.EventHandler(this.rdPAOB_CheckedChanged);
         // 
         // rdDetail
         // 
         this.rdDetail.AutoSize = true;
         this.rdDetail.Location = new System.Drawing.Point(182, 6);
         this.rdDetail.Name = "rdDetail";
         this.rdDetail.Size = new System.Drawing.Size(57, 19);
         this.rdDetail.TabIndex = 3;
         this.rdDetail.TabStop = true;
         this.rdDetail.Text = "Detail";
         this.rdDetail.UseVisualStyleBackColor = true;
         this.rdDetail.CheckedChanged += new System.EventHandler(this.rdDetail_CheckedChanged);
         // 
         // rdSummary
         // 
         this.rdSummary.AutoSize = true;
         this.rdSummary.Location = new System.Drawing.Point(92, 6);
         this.rdSummary.Name = "rdSummary";
         this.rdSummary.Size = new System.Drawing.Size(78, 19);
         this.rdSummary.TabIndex = 2;
         this.rdSummary.TabStop = true;
         this.rdSummary.Text = "Summary";
         this.rdSummary.UseVisualStyleBackColor = true;
         this.rdSummary.CheckedChanged += new System.EventHandler(this.rdSummary_CheckedChanged);
         // 
         // frmPerfectAttendance
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(846, 499);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.toolStrip1);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "frmPerfectAttendance";
         this.Text = "Perfect Attendance";
         this.Load += new System.EventHandler(this.frmPerfectAttendance_Load);
         ((System.ComponentModel.ISupportInitialize)(this.bsPAOB)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dsPerfectAttendanceOBDetails)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bsPADetails)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dsPerfectAttendanceDetails)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bsPA)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dsPerfectAttendance)).EndInit();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel9.ResumeLayout(false);
         this.pnlOB.ResumeLayout(false);
         this.panel18.ResumeLayout(false);
         this.panel19.ResumeLayout(false);
         this.panel19.PerformLayout();
         this.pnlDetail.ResumeLayout(false);
         this.panel8.ResumeLayout(false);
         this.panel12.ResumeLayout(false);
         this.panel12.PerformLayout();
         this.pnlSummary.ResumeLayout(false);
         this.panel14.ResumeLayout(false);
         this.panel13.ResumeLayout(false);
         this.panel13.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel16.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         this.panel4.ResumeLayout(false);
         this.panel4.PerformLayout();
         this.panel5.ResumeLayout(false);
         this.panel6.ResumeLayout(false);
         this.panel6.PerformLayout();
         this.panel7.ResumeLayout(false);
         this.panel11.ResumeLayout(false);
         this.panel11.PerformLayout();
         this.panel10.ResumeLayout(false);
         this.panel10.PerformLayout();
         this.panel17.ResumeLayout(false);
         this.panel17.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.ProgressBar prog1;
        private System.Windows.Forms.TextBox txtinterval;
        private System.Windows.Forms.ToolStripButton tbtnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bsPADetails;
        private dsPerfectAttendanceDetails dsPerfectAttendanceDetails;
        private System.Windows.Forms.BindingSource bsPA;
        private dsPerfectAttendance dsPerfectAttendance;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel14;
        private Microsoft.Reporting.WinForms.ReportViewer rptPerfectAttendance;
        private Microsoft.Reporting.WinForms.ReportViewer rptPADetails;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.RadioButton rdSummary;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdDetail;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.BindingSource bsPAOB;
        private dsPerfectAttendanceOBDetails dsPerfectAttendanceOBDetails;
        private System.Windows.Forms.Panel pnlOB;
        private System.Windows.Forms.Panel panel18;
        private Microsoft.Reporting.WinForms.ReportViewer rptPAOB;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdPAOB;
    }
}