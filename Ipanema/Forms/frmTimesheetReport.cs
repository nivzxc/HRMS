﻿using System;
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
using MigraDoc.RtfRendering;
using PdfSharp.Pdf;



namespace Ipanema.Forms
{
    public partial class frmTimesheetReport : Form
    {
        public frmTimesheetReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                string dtFrom = dtpFrom.Value.ToString(  );
                string dtTo = dtpTo.Value.ToString();
                var empNum = new List<string>();
                var empName = new List<string>();
                var workhr = new List<string>();
                var totalabs = new List<string>();
                var totallate_hr = new List<string>();
                var totallate_min = new List<string>();
                var totalut_hr = new List<string>();
                var totalut_min = new List<string>();
                var render_date = new List<string>();




                foreach (ListViewItem items in listView1.Items)
                {
                    empNum.Add(items.SubItems[0].Text);
                    empName.Add(items.SubItems[1].Text);
                    totalabs.Add(items.SubItems[2].Text);
                    totallate_hr.Add(items.SubItems[3].Text);
                    totallate_min.Add(items.SubItems[4].Text);
                    totalut_hr.Add(items.SubItems[5].Text);
                    totalut_min.Add(items.SubItems[6].Text);
                    render_date.Add(items.SubItems[7].Text);
                }

                PDFReport report = new PDFReport();

                Document document = report.Late_absence_summary(dtFrom, dtTo, empNum, empName, totalabs, totallate_hr, totallate_min, totalut_hr, totalut_min, render_date);
                PdfDocumentRenderer pdfrender = new PdfDocumentRenderer();
                pdfrender.Document = document;
                pdfrender.RenderDocument();

                const string filename = "Late_and_Absences_SUMMARY.pdf";
                pdfrender.PdfDocument.Save(filename);
                Process.Start(filename);
            }
            else { MessageBox.Show("You have no report to print","Unable to Print",MessageBoxButtons.OK,MessageBoxIcon.Error); }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            DataTable tblTimesheet = clsTimesheet.TimesheetReport(dtpFrom.Value,dtpTo.Value);
            listView1.Items.Clear();
            DataTable tblCluster = clsCluster.GetDdlDs();

            foreach (DataRow cluster_row in tblCluster.Rows) {
                ListViewItem branchName = new ListViewItem(cluster_row["ptext"].ToString());
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
                listView1.Items.Add(branchName);

                foreach (DataRow rows in tblTimesheet.Rows)
                {
                    if (cluster_row["pvalue"].ToString() == rows["CLUSTER"].ToString())
                    {
                        var late_in_mins = float.Parse(rows["TOTAL_LATE"].ToString()) - Math.Truncate(float.Parse(rows["TOTAL_LATE"].ToString()));
                        late_in_mins = late_in_mins * 60;
                        var late_mins = decimal.Truncate(decimal.Parse(late_in_mins.ToString()));
                        var late_in_hrs = decimal.Truncate(decimal.Parse(rows["TOTAL_LATE"].ToString()));

                        var undertime_in_mins = float.Parse(rows["TOTAL_UNDERTIME"].ToString()) - Math.Truncate(float.Parse(rows["TOTAL_UNDERTIME"].ToString()));
                        undertime_in_mins = undertime_in_mins * 60;
                        var ut_mins = decimal.Truncate(decimal.Parse(undertime_in_mins.ToString()));
                        var undertime_in_hrs = decimal.Truncate(decimal.Parse(rows["TOTAL_UNDERTIME"].ToString()));

                        ListViewItem item = new ListViewItem(rows["EMPLOYEE_NUM"].ToString());
                        item.SubItems.Add(rows["EMPLOYEE_NAME"].ToString());
                        item.SubItems.Add(rows["TOTAL_ABSENT"].ToString());
                        item.SubItems.Add(late_in_hrs.ToString()); // late in hrs
                        item.SubItems.Add(late_mins.ToString()); // late in mins
                        item.SubItems.Add(undertime_in_hrs.ToString()); // undertime in hrs
                        item.SubItems.Add(ut_mins.ToString()); // undertime in mins
                        item.SubItems.Add(clsTimesheet.getDates(rows["EMPLOYEE_USER"].ToString(), dtpFrom.Value, dtpTo.Value));
                        listView1.Items.Add(item);

                    }
                }


            }

        }

        private void frmTimesheetReport_Load(object sender, EventArgs e)
        {   
            this.WindowState = FormWindowState.Maximized;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }
    }
}
