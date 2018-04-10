using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HRMS;
using System.Diagnostics;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;

namespace Ipanema.Forms
{
    public partial class frmOvertimeSummaryReport : Form
    {
        public frmOvertimeSummaryReport()
        {
            InitializeComponent();
        }

        private void frmOvertimeSummaryReport_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }

        private void tbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            data_bind();
        }
        public void data_bind()
        {
            DataTable TblOvertime = clsTimesheet.OvertimeReport(dtpFrom.Value, dtpTo.Value);
            listView1.Items.Clear();

            DataTable tblCluster = clsCluster.GetDdlDs();

            foreach (DataRow Cluster_rows in tblCluster.Rows)
            {                
                ListViewItem branchName = new ListViewItem(Cluster_rows["ptext"].ToString());
                branchName.Font = new System.Drawing.Font(branchName.Font, FontStyle.Bold);
                branchName.BackColor = System.Drawing.Color.WhiteSmoke;
                branchName.ForeColor = System.Drawing.Color.Black;
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");                
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                branchName.SubItems.Add("");
                listView1.Items.Add(branchName);
                    
                foreach (DataRow rows in TblOvertime.Rows)
                {
                    if (Cluster_rows["pvalue"].ToString() == rows["CLUSTER"].ToString()) {
                        ListViewItem item = new ListViewItem(rows["EMP_NO"].ToString());
                        item.SubItems.Add(rows["last_name"].ToString());
                        item.SubItems.Add(rows["first_name"].ToString());
                        
                        //REGULAR OT//
                        //1st 8 hrs (AM)
                        item.SubItems.Add("0");
                        // after 8 hrs (PM)
                        item.SubItems.Add(clsDateTime.convert_min(rows["REG_OT"].ToString()).ToString());
                        // other OT Payment
                        item.SubItems.Add("0");
                        // w/ Night Diff.
                        item.SubItems.Add(clsDateTime.convert_min(rows["REG_ND"].ToString()).ToString());

                        //REGULAR REST DAY
                        //1st 8 hrs (AM)
                        item.SubItems.Add("0");
                        //after 8 hrs (PM)
                        item.SubItems.Add(clsDateTime.convert_min(rows["RESTD_OT"].ToString()).ToString());
                        //1st 8th w/ ND
                        item.SubItems.Add("0");
                        //after 8 hrs 
                        item.SubItems.Add("0");
                        // after 8 hrs w/ ND
                        item.SubItems.Add(clsDateTime.convert_min(rows["RESTD_ND"].ToString()).ToString());

                        //SPECIAL NON-WORKING HOLIDAY
                        //1st 8 hrs
                        item.SubItems.Add("0");
                        //after 8 hrs
                        item.SubItems.Add(clsDateTime.convert_min(rows["SPECIAL_NONW_OT"].ToString()).ToString());
                        //after 8 hrs w/ ND
                        item.SubItems.Add(clsDateTime.convert_min(rows["SPECIAL_NONW_ND"].ToString()).ToString());

                        //REGULAY HOLIDAY
                        //1st 8 hrs
                        item.SubItems.Add("0");
                        //after 8 hrs
                        item.SubItems.Add(clsDateTime.convert_min(rows["REG_HOLIDAY_OT"].ToString()).ToString());
                        //after 8 hrs w/ ND
                        item.SubItems.Add(clsDateTime.convert_min(rows["REG_HOLIDAY_ND"].ToString()).ToString());

                        listView1.Items.Add(item);
                    }                  
                }
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {           

            if (listView1.Items.Count > 0)
            {
                var empnum = new List<string>();
                var fname = new List<string>();
                var lname = new List<string>();
                var list1 = new List<string>();
                var list2 = new List<string>();
                var list3 = new List<string>();
                var list4 = new List<string>();
                var list5 = new List<string>();
                var list6 = new List<string>();
                var list7 = new List<string>();
                var list8 = new List<string>();
                var list9 = new List<string>();
                var list10 = new List<string>();
                var list11 = new List<string>();
                var list12 = new List<string>();
                var list13 = new List<string>();
                var list14 = new List<string>();
                var list15 = new List<string>();

                foreach (ListViewItem lvItems in listView1.Items)
                {
                    empnum.Add(lvItems.SubItems[0].Text);
                    lname.Add(lvItems.SubItems[1].Text);
                    fname.Add(lvItems.SubItems[2].Text);
                    list1.Add(lvItems.SubItems[3].Text); 
                    list2.Add(lvItems.SubItems[4].Text);
                    list3.Add(lvItems.SubItems[5].Text);
                    list4.Add(lvItems.SubItems[6].Text);
                    list5.Add(lvItems.SubItems[7].Text);
                    list6.Add(lvItems.SubItems[8].Text);
                    list7.Add(lvItems.SubItems[9].Text);
                    list8.Add(lvItems.SubItems[10].Text);
                    list9.Add(lvItems.SubItems[11].Text);
                    list10.Add(lvItems.SubItems[12].Text);
                    list11.Add(lvItems.SubItems[13].Text);
                    list12.Add(lvItems.SubItems[14].Text);
                    list13.Add(lvItems.SubItems[15].Text);
                    list14.Add(lvItems.SubItems[16].Text);
                    list15.Add(lvItems.SubItems[17].Text);
                }
                PDFReport report = new PDFReport();
                Document doc = report.Overtime_summary(dtpFrom.Value, dtpTo.Value, empnum, fname, lname, list1, list2, list3, list4, list5,list6,list7,list8,list9,list10,list11,list12,list13,list14,list15);
                PdfDocumentRenderer pdfRender = new PdfDocumentRenderer();
                pdfRender.Document = doc;
                pdfRender.RenderDocument();

                const string filename = "Overtime_SUMMARY.pdf";
                pdfRender.PdfDocument.Save(filename);
                Process.Start(filename);
            }


        }
    }
}
