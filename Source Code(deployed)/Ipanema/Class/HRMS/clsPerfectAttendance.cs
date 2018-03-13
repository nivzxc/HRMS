using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
    public class clsPerfectAttendance : IDisposable
    {

        public void Dispose() { GC.SuppressFinalize(this); }

        public static DataTable DSTPerfectAttendance()
        {
            DataTable tblReturn = new DataTable();
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT username AS username,pimage as pimage, lastname AS lastname,firname AS firstname,midname AS middlename,nickname AS nickname,division AS division FROM HR.Employees INNER JOIN HR.Division ON HR.Employees.divicode = HR.Division.divicode WHERE HR.Employees.username IN (SELECT username FROM HR.EmployeeCluster WHERE cluscode='002') AND HR.Employees.username NOT IN (SELECT username FROM HR.Leave3Days WHERE HR.Leave3Days.enabled = '1') AND HR.Employees.username NOT IN (SELECT username FROM HR.Offense WHERE HR.Offense.enabled = '1') ORDER BY username";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tblReturn);
            }
            return tblReturn;
        }

        public static DataTable DSTTimeSheet(string pUsername,DateTime pDateStart, DateTime pDateEnd)
        {
            DataTable tblReturn = new DataTable();
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT username AS username, (SELECT lastname FROM HR.Employees WHERE HR.Employees.username = HR.TimeSheet.username) AS lastname,(SELECT firname FROM HR.Employees WHERE HR.Employees.username = HR.TimeSheet.username) AS firstname,(SELECT midname FROM HR.Employees WHERE HR.Employees.username = HR.TimeSheet.username) AS middlename,  timein AS timestart, timeout AS timeend, shftin AS shiftin, shftout AS shiftout, pstatus AS pstatus, obunit AS obunit, ttalunit AS ttalunit, workunit AS workunit, (SELECT tworkhrs FROM HR.Shift WHERE HR.Shift.shftcode = HR.Timesheet.shftcode) AS tworkhrs FROM HR.Timesheet WHERE username='" + pUsername + "' AND (focsdate BETWEEN '" + pDateStart + "' AND '" + pDateEnd + "') AND CONVERT(varchar(11),focsdate,1) NOT IN (SELECT CONVERT(varchar(11),dateapp,1) FROM HR.CDL)";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tblReturn);
            }
            return tblReturn;
        }

        public static int CountAbsentTotal(string pUsername, DateTime pDateStart, DateTime pDateEnd)
        {
            int intReturn = 0;
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM HR.Timesheet WHERE username='" + pUsername + "' AND (focsdate BETWEEN '" + pDateStart + "' AND '" + pDateEnd + "') AND absunit > 0";
                cn.Open();
                try { intReturn = clsValidator.CheckInteger(cmd.ExecuteScalar().ToString()); }
                catch { }
            }
            return intReturn;
        }


        public static int CountLeaveWithPayTotal(string pUsername, DateTime pDateStart, DateTime pDateEnd)
        {
            int intReturn = 0;
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM HR.Timesheet WHERE username='" + pUsername + "' AND (focsdate BETWEEN '" + pDateStart + "' AND '" + pDateEnd + "') AND lwithpay > 0 AND CONVERT(varchar(11),focsdate,1) NOT IN (SELECT CONVERT(varchar(11),dateapp,1) FROM HR.CDL)";
                cn.Open();
                try { intReturn = clsValidator.CheckInteger(cmd.ExecuteScalar().ToString()); }
                catch { }
            }
            return intReturn;
        }

        public static int CountCDLTotal(string pUsername, DateTime pDateStart, DateTime pDateEnd)
        {
            int intReturn = 0;
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM HR.CDL WHERE (dateapp BETWEEN '" + pDateStart + "' AND '" + pDateEnd + "')";
                cn.Open();
                try { intReturn = clsValidator.CheckInteger(cmd.ExecuteScalar().ToString()); }
                catch { }
            }
            return intReturn;
        }

        public static int CountLeaveWithoutPayTotal(string pUsername, DateTime pDateStart, DateTime pDateEnd)
        {
            int intReturn = 0;
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM HR.Timesheet WHERE username='" + pUsername + "' AND (focsdate BETWEEN '" + pDateStart + "' AND '" + pDateEnd + "') AND lwoutpay > 0 AND CONVERT(varchar(11),focsdate,1) NOT IN (SELECT CONVERT(varchar(11),dateapp,1) FROM HR.CDL)";
                cn.Open();
                try { intReturn = clsValidator.CheckInteger(cmd.ExecuteScalar().ToString()); }
                catch { }
            }
            return intReturn;
        }

        public static int CountLateTotal(string pUsername, DateTime pDateStart, DateTime pDateEnd)
        {
            int intReturn = 0;
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM HR.Timesheet WHERE username='" + pUsername + "' AND (focsdate BETWEEN '" + pDateStart + "' AND '" + pDateEnd + "') AND lateunit > 0";
                cn.Open();
                try { intReturn = clsValidator.CheckInteger(cmd.ExecuteScalar().ToString()); }
                catch { }
            }
            return intReturn;
        }

        public static int CountUndertimeTotal(string pUsername, DateTime pDateStart, DateTime pDateEnd)
        {
            int intReturn = 0;
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM HR.Timesheet WHERE username='" + pUsername + "' AND (focsdate BETWEEN '" + pDateStart + "' AND '" + pDateEnd + "') AND undrunit > 0";
                cn.Open();
                try { intReturn = clsValidator.CheckInteger(cmd.ExecuteScalar().ToString()); }
                catch { }
            }
            return intReturn;
        }

        /// /////////////////////////////////////////////////////////////////////////////////////////////

   



    }
}
