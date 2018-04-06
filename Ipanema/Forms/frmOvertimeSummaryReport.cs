using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HRMS;

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
                branchName.Font = new Font(branchName.Font, FontStyle.Bold);
                branchName.BackColor = Color.WhiteSmoke;
                branchName.ForeColor = Color.Black;
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
                        item.SubItems.Add(Math.Round(Convert.ToDouble(rows["REG_OT"].ToString()), 2).ToString());
                        // other OT Payment
                        item.SubItems.Add("0");
                        // w/ Night Diff.
                        item.SubItems.Add(Math.Round(Convert.ToDouble(rows["REG_ND"].ToString()), 2).ToString());

                        //REGULAR REST DAY
                        //1st 8 hrs (AM)
                        item.SubItems.Add("0");
                        //after 8 hrs (PM)
                        item.SubItems.Add(Math.Round(Convert.ToDouble(rows["RESTD_OT"].ToString()), 2).ToString());
                        //1st 8th w/ ND
                        item.SubItems.Add("0");
                        //after 8 hrs 
                        item.SubItems.Add("0");
                        // after 8 hrs w/ ND
                        item.SubItems.Add(Math.Round(Convert.ToDouble(rows["RESTD_ND"].ToString()), 2).ToString());

                        //SPECIAL NON-WORKING HOLIDAY
                        //1st 8 hrs
                        item.SubItems.Add("0");
                        //after 8 hrs
                        item.SubItems.Add(Math.Round(Convert.ToDouble(rows["SPECIAL_NONW_OT"].ToString()), 2).ToString());
                        //after 8 hrs w/ ND
                        item.SubItems.Add(Math.Round(Convert.ToDouble(rows["SPECIAL_NONW_ND"].ToString()), 2).ToString());

                        //REGULAY HOLIDAY
                        //1st 8 hrs
                        item.SubItems.Add("0");
                        //after 8 hrs
                        item.SubItems.Add(Math.Round(Convert.ToDouble(rows["REG_HOLIDAY_OT"].ToString()), 2).ToString());
                        //after 8 hrs w/ ND
                        item.SubItems.Add(Math.Round(Convert.ToDouble(rows["REG_HOLIDAY_ND"].ToString()), 2).ToString());

                        listView1.Items.Add(item);
                    }                  
                }
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
