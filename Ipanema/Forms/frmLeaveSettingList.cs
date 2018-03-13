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
    public partial class frmLeaveSettingList : Form
    {
        private mdiIpanema _frmMdiCaller;

        public mdiIpanema FormMDICaller { get { return _frmMdiCaller; } set { _frmMdiCaller = value; } }

        public frmLeaveSettingList()
        {
            InitializeComponent();
        }

        public void LoadLeaveSetting()
        {
            dgLeaveList.AutoGenerateColumns = false;
            dgLeaveList.DataSource = clsLeaveSetting.GetDSGMainForm();
            dgLeaveList.Columns[0].DataPropertyName = "leavname";
            dgLeaveList.Columns[1].DataPropertyName = "ltdesc";
        }

        private void frmLeaveSettingList_Load(object sender, EventArgs e)
        {
            LoadLeaveSetting();
        }

        private void tbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtnLeaveSetting_Click(object sender, EventArgs e)
        {
            if (dgLeaveList.Rows.Count > 0)
            {
                frmLeaveSettingEdit xform = new frmLeaveSettingEdit();
                xform.FormLeaveSettingList = this;
                xform.LeaveName = dgLeaveList.SelectedRows[0].Cells[0].Value.ToString();
                xform.FormMDICaller = _frmMdiCaller;
                xform.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgLeaveList_DoubleClick(object sender, EventArgs e)
        {
            tbtnLeaveSetting_Click(null, null);
        }



        

       
    }
}
