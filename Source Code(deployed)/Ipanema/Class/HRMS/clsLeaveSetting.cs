using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
    class clsLeaveSetting : IDisposable
    {
        private string _strLeaveName;
        private string _strLeaveCode;

        public string LeaveName { get { return _strLeaveName; } set { _strLeaveName = value; } }
        public string LeaveCode { get { return _strLeaveCode; } set { _strLeaveCode = value; } }

        public void Fill()
        {
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT * FROM HR.LeaveSetting WHERE leavname=@leavname";
                cmd.Parameters.Add(new SqlParameter("@leavname", _strLeaveName));
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    _strLeaveName = dr["leavname"].ToString();
                    _strLeaveCode = dr["leavtype"].ToString();
                }
                dr.Close();
            }
        }

        public int Update()
        {
            int intReturn = 0;
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE HR.LeaveSetting set leavname=@leavname, leavtype=@leavtype WHERE leavname=@leavname";
                cmd.Parameters.Add(new SqlParameter("@leavname", _strLeaveName));
                cmd.Parameters.Add(new SqlParameter("@leavtype", _strLeaveCode));
                cn.Open();
                intReturn = cmd.ExecuteNonQuery();
            }
            return intReturn;
        }

        public void Dispose() { GC.SuppressFinalize(this); }

        public static DataTable GetDSGMainForm()
        {
            DataTable tblReturn = new DataTable();
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT HR.LeaveSetting.leavname, HR.LeaveTypes.ltdesc FROM HR.LeaveSetting, HR.LeaveTypes WHERE HR.LeaveSetting.leavtype = HR.LeaveTypes.leavtype";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tblReturn);
            }
            return tblReturn;
        }
    }
}
