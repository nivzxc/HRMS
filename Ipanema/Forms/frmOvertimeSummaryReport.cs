using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
