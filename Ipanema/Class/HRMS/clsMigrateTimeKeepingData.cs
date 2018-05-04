using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace HRMS
{
    class clsMigrateTimeKeepingData
    {
        public static int MigrateData_TimeIN(string strUserName, string focusDate, DateTime timeIN)
        {
            int Return_val = 0;
            bool CheckRecord = false;
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT TOP 1 focsdate,keyin FROM HR.TimeCard WHERE username='" + strUserName + "' AND focsdate ='" + focusDate + "' AND keyin is null ORDER BY focsdate,keyin DESC";
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                CheckRecord = dr.Read();
                dr.Close();
                if (CheckRecord)
                {
                    cmd.CommandText = "UPDATE HR.TimeCard SET keyin='" + timeIN.ToString("yyyy-MM-dd hh:mm:ss tt") + "' WHERE username='" + strUserName + "' AND focsdate='" + focusDate + "'";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO HR.TimeCard(username,focsdate,keyin,updateby,updateon) " +
                                                     "VALUES ('" + strUserName + "','" + focusDate + "','" + timeIN.ToString("yyyy-MM-dd hh:mm:ss tt") + "','" + strUserName + "','" + focusDate + "')";
                }
                Return_val=cmd.ExecuteNonQuery();
                dr.Close();
                cn.Close();
                return Return_val;
            }
        }
        public static int MigrateData_TimeOUT(string strUserName, string focusDate, DateTime timeOut)
        {
            int Return_val = 0;
            bool CheckRecord = false;
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT TOP 1 focsdate,keyout FROM HR.TimeCard WHERE username='" + strUserName + "' AND keyout is null ORDER BY focsdate,keyin DESC";
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                CheckRecord = dr.Read();
                dr.Close();
                if (CheckRecord)
                {
                    cmd.CommandText = "UPDATE HR.TimeCard SET keyout='" + timeOut.ToString("yyyy-MM-dd hh:mm:ss tt") + "' WHERE username='" + strUserName + "' AND focsdate='" + focusDate + "'";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO HR.TimeCard(username,focsdate,keyout,updateby,updateon) " +
                                                     "VALUES ('" + strUserName + "','" + focusDate + "','" + timeOut.ToString("yyyy-MM-dd hh:mm:ss tt") + "','" + strUserName + "','" + focusDate + "')";
                }
                Return_val = cmd.ExecuteNonQuery();
                dr.Close();
                cn.Close();
                return Return_val;
            }
        }
    }
}
