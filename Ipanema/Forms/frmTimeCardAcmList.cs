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
 public partial class frmTimeCardAcmList : Form
 {
  public frmTimeCardAcmList() { InitializeComponent(); }
 
  public void LoadCurrentTimeSheetPeriod()
  {
   string strCurrentTimeSheetPeriod = clsTimeSheetPeriod.GetCurrentTimeSheetPeriod();
   using (clsTimeSheetPeriod tsp = new clsTimeSheetPeriod(strCurrentTimeSheetPeriod))
   {
    tsp.Fill();
    dtpFrom.Value = tsp.PeriodFrom;                                   
    dtpTo.Value = tsp.PeriodTo;
   }
  }

  public void BindHQDATA()
  {
            string clusdesc = "";
            dgTimeCard.AutoGenerateColumns = false;
            if (clsCluster.getBioMetricCluster(cmbBranches.SelectedValue.ToString()) == "CEBU BRANCH" || clsCluster.getBioMetricCluster(cmbBranches.SelectedValue.ToString()) == "MANILA BRANCH")
            {
               
                clusdesc = clsCluster.getBioMetricCluster(cmbBranches.SelectedValue.ToString());                            
                dgTimeCard.DataSource=clsTimeCardACM.BranchBIOMETRICS_DATA(clusdesc,dtpFrom.Value,dtpTo.Value);
                dgTimeCard.Columns[0].DataPropertyName = "username";
                dgTimeCard.Columns[1].DataPropertyName = "empnum";
                dgTimeCard.Columns[2].DataPropertyName = "pname";
                dgTimeCard.Columns[3].DataPropertyName = "tdate";
                dgTimeCard.Columns[4].DataPropertyName = "ttime";
                dgTimeCard.Columns[5].DataPropertyName = "action";
                dgTimeCard.Columns[6].DataPropertyName = "door";
        
            }          
            else
            {               
                clusdesc = clsCluster.getBioMetricCluster(cmbBranches.SelectedValue.ToString());
                dgTimeCard.DataSource = clsTimeCardACM.BiometricTimeCardList(dtpFrom.Value, dtpTo.Value, cmbEmployee.SelectedValue.ToString(), clusdesc);
                dgTimeCard.Columns[0].DataPropertyName = "username";
                dgTimeCard.Columns[1].DataPropertyName = "empnum";
                dgTimeCard.Columns[2].DataPropertyName = "pname";
                dgTimeCard.Columns[3].DataPropertyName = "tdate";
                dgTimeCard.Columns[4].DataPropertyName = "ttime";
                dgTimeCard.Columns[5].DataPropertyName = "action";
                dgTimeCard.Columns[6].DataPropertyName = "door";
            }
            if (chkViewFILO.Checked)
                 dgTimeCard.DataSource = clsTimeCardACM.DSGTimeCardListFILO(dtpFrom.Value, dtpTo.Value, cmbEmployee.SelectedValue.ToString()); 
            
           
  }



  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmTimeCardAcmList_Load(object sender, EventArgs e)
  {               
    cmbBranches.DataSource = clsCluster.GetDdlDs();
    cmbBranches.ValueMember = "pvalue";
    cmbBranches.DisplayMember = "ptext";
        
    LoadCurrentTimeSheetPeriod();
    //BindClusterGrid();
    chkViewFILO.Visible = false;
    this.WindowState = FormWindowState.Maximized;
  }

  private void tbtnClose_Click(object sender, EventArgs e)
  {
   this.Close();
  }

 
  private void dtpFrom_ValueChanged(object sender, EventArgs e)
  {
    
  }

  private void dtpTo_ValueChanged(object sender, EventArgs e)
  {
      //MessageBox.Show(cmbEmployee.SelectedValue.ToString() + " " + dtpFrom.Value.ToString("MM/dd/yyyy") + " " + dtpTo.Value.ToString("MM/dd/yyyy"));
  }

  private void tbtnAdd_Click(object sender, EventArgs e)
  {

  }

  private void tbtnEdit_Click(object sender, EventArgs e)
  {

  }

  private void tbtnDelete_Click(object sender, EventArgs e)
  {
   MessageBox.Show("Disabled");
  }

  private void tbtnRefresh_Click(object sender, EventArgs e)
  {
   try { BindHQDATA(); }
   catch { }
  }

  private void dgTimeCard_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
  {
   Color clrBG = Color.LightYellow;
   foreach (DataGridViewRow drw in dgTimeCard.Rows)
   {
    switch (drw.Cells[5].Value.ToString())
    {
     case "In":
      clrBG = Color.Honeydew;
      break;
     case "Out":
      clrBG = Color.AliceBlue;
      break;
     default:
      clrBG = Color.MistyRose;
      break;
    }
    drw.DefaultCellStyle.BackColor = clrBG;
   }
  }

  private void chkViewFILO_CheckedChanged(object sender, EventArgs e)
  {
            BindHQDATA();
  }

  private void tsButtons_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
  {

  }

  private void button1_Click(object sender, EventArgs e)
  {
      try { BindHQDATA(); }
      catch { MessageBox.Show("Please check your server connection","Unable to load data", MessageBoxButtons.OK,MessageBoxIcon.Error); }
            
  }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }
        private void cmbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {            
                cmbEmployee.DataSource = Employee.ClusterEmployee(cmbBranches.SelectedValue.ToString());
                cmbEmployee.ValueMember = "pvalue";
                cmbEmployee.DisplayMember = "ptext";
        }
        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedValue.ToString() == "ALL")
            {
                try { BindHQDATA(); }
                catch { }
                chkViewFILO.Visible = false;
            }
            else if (cmbBranches.SelectedValue.ToString()== "CEBU BRANCH" || cmbBranches.SelectedValue.ToString()== "MANILA BRANCH")
            {
                chkViewFILO.Visible = false;
            }
            else {
                try { BindHQDATA(); }
                catch { }
                chkViewFILO.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgTimeCard.Rows.Count > 0)
            {
                string user_name = "";
                string date_Time = "";
                DateTime date_Time_in;
                DateTime date_Time_out;
                string focus_date = "";
                int data_counter = 0;
                for (int x = 0; x < dgTimeCard.Rows.Count; x++)
                {
                    user_name = Employee.GetUsername(dgTimeCard.Rows[x].Cells[1].Value.ToString(), EmployeeWhereParameter.EmployeeNumber);
                    focus_date = Convert.ToDateTime(dgTimeCard.Rows[x].Cells[3].Value).ToString("yyyy-MM-dd 00:00:00");
                    date_Time_in = Convert.ToDateTime(dgTimeCard.Rows[x].Cells[4].Value);
                    date_Time_out = Convert.ToDateTime(dgTimeCard.Rows[x].Cells[4].Value);


                    if (dgTimeCard.Rows[x].Cells[5].Value.ToString() == "In")
                    {
                        data_counter += clsMigrateTimeKeepingData.MigrateData_TimeIN(user_name, focus_date, date_Time_in);
                        //MessageBox.Show("DATE: " + focus_date + "\nTIME IN: " + date_Time_in);   
                    }
                    else if (dgTimeCard.Rows[x].Cells[5].Value.ToString() == "Out")
                    {
                        data_counter += clsMigrateTimeKeepingData.MigrateData_TimeOUT(user_name, focus_date, date_Time_out);
                        //MessageBox.Show("DATE: " + focus_date + "\nTIME OUT: " + date_Time_out);
                    }
                    else
                    {
                        //date_Time = Convert.ToDateTime(dgTimeCard.Rows[x].Cells[4].Value).ToString("yyyy-MM-dd hh:mm:ss tt");
                        //clsMigrateTimeKeepingData.MigrateData(user_name, focus_date, date_Time, date_Time_out);
                    }

                }
                MessageBox.Show(data_counter + " Data has been migrated to SQL DATABASE ", "SQL DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("No Data found", "Migration Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}