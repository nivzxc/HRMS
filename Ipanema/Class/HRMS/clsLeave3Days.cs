using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
    public class clsLeave3Days : IDisposable
    {
        private string _strLeaveCode;
        private string _strUsername;
        private double _dblUnit;
        private DateTime _dtStart;
        private DateTime _dtEnd;
        private string _strRemarks;
        private string _strEnabled;
        private string _strCreateby;
        private DateTime _dtCreateOn;
        private string _strModifyby;
        private DateTime _dtModifyOn;

        public string LeaveCode { get { return _strLeaveCode; } set { _strLeaveCode = value; } }
        public string Username { get { return _strUsername; } set { _strUsername = value; } } 
        public double Unit { get { return  _dblUnit; } set { _dblUnit = value; } }
        public DateTime DateStart { get { return _dtStart; } set { _dtStart = value; } }
        public DateTime DateEnd { get { return _dtEnd; } set { _dtEnd = value; } }
        public string Remarks { get { return _strRemarks ; } set { _strRemarks = value; } }
        public string Enabled { get { return _strEnabled; } set { _strEnabled = value; } }
        public string Createby { get { return _strCreateby; } set { _strCreateby = value; } }
        public DateTime CreateOn { get { return _dtCreateOn; } set { _dtCreateOn = value; } }
        public string ModifyBy { get { return _strModifyby ; } set { _strModifyby = value ; } }
        public DateTime ModifyOn { get { return _dtModifyOn; } set { _dtModifyOn = value; } }

        public void Fill()
        {
            using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT * FROM HR.Leave3Days WHERE leavcode=@leavcode";
                cmd.Parameters.Add(new SqlParameter("@leavcode", _strLeaveCode));
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    _strLeaveCode = dr["leavcode"].ToString();
                    _strUsername = dr["username"].ToString();
                    _dblUnit = clsValidator.CheckDouble(dr["units"].ToString());
                    _dtStart = clsValidator.CheckDate(dr["datestrt"].ToString());
                    _dtEnd = clsValidator.CheckDate(dr["dateend"].ToString());
                    _strRemarks = dr["remarks"].ToString();
                    _strEnabled = dr["enabled"].ToString();
                    _strCreateby = dr["createby"].ToString();
                    _dtCreateOn = clsValidator.CheckDate(dr["createon"].ToString());
                    _strModifyby = dr["modifyby"].ToString();
                    _dtModifyOn = clsValidator.CheckDate(dr["modifyon"].ToString());
                }
                dr.Close();
            }
        }

        public int Insert()
        {
            int intReturn = 0;
            SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString);
            cn.Open();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand cmd = cn.CreateCommand();
            cmd.Transaction = tran;
            try
            {

                cmd.CommandText = "SELECT RIGHT('000000000' + CAST(pvalue AS VARCHAR(9)),9) FROM Speedo.Keys WHERE pkey='leavocde'";
                _strLeaveCode = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "INSERT INTO HR.Leave3Days (leavcode,username,units,datestrt,dateend,remarks,enabled,createby,createon,modifyby,modifyon) VALUES(@leavcode,@username,@units,@datestart,@dateend,@remarks,@enabled,@createby,@createon,@modifyby,@modifyon)";
                cmd.Parameters.Add(new SqlParameter("@leavcode", _strLeaveCode));
                cmd.Parameters.Add(new SqlParameter("@username", _strUsername));
                cmd.Parameters.Add(new SqlParameter("@units", _dblUnit));
                cmd.Parameters.Add(new SqlParameter("@datestart", _dtStart));
                cmd.Parameters.Add(new SqlParameter("@dateend", _dtEnd));
                cmd.Parameters.Add(new SqlParameter("@remarks", _strRemarks));
                cmd.Parameters.Add(new SqlParameter("@enabled", _strEnabled));
                cmd.Parameters.Add(new SqlParameter("@createby", HRMSCore.Username));
                cmd.Parameters.Add(new SqlParameter("@createon", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("@modifyby", HRMSCore.Username));
                cmd.Parameters.Add(new SqlParameter("@modifyon", DateTime.Now));
                intReturn = cmd.ExecuteNonQuery();

                if (intReturn > 0)
                {
                    cmd.CommandText = "UPDATE Speedo.Keys SET pvalue=pvalue+1 WHERE pkey='leavocde'";
                    cmd.ExecuteNonQuery();
                }
                tran.Commit();
            }
            catch
            {
                tran.Rollback();
            }
            finally
            {
                cn.Close();
            }
            return intReturn;
        }

        public int Update()
        {
            int intReturn = 0;
            using (SqlConnection  cn = new SqlConnection(HRMSCore.HrmsConnectionString))
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE HR.Leave3Days SET units=@units, datestrt=@datestart, dateend=@dateend,remarks=@remarks,enabled =@enabled, modifyby=@modifyby, modifyon=@modifyon WHERE leavcode=@leavcode";
                cmd.Parameters.Add(new SqlParameter("@leavcode",_strLeaveCode));
                cmd.Parameters.Add(new SqlParameter("@units", _dblUnit));
                cmd.Parameters.Add(new SqlParameter("@datestart",_dtStart));
                cmd.Parameters.Add(new SqlParameter("@dateend",_dtEnd));
                cmd.Parameters.Add(new SqlParameter("@remarks",_strRemarks));
                cmd.Parameters.Add(new SqlParameter("@enabled",_strEnabled));
                cmd.Parameters.Add(new SqlParameter("@modifyby", HRMSCore.Username));
                cmd.Parameters.Add(new SqlParameter("@modifyon", DateTime.Now));
                cn.Open();
                intReturn =  cmd.ExecuteNonQuery();
            }
            return intReturn;
        }

    public void Dispose() { GC.SuppressFinalize(this); }
        //////////////////////////////
        /////form event /////////////
        /////////////////////////////

    public static DataTable GetDSGMainForm()
    {
        DataTable tblReturn = new DataTable();
        using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
        {
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT leavcode AS LeaveCode, username AS Username, (SELECT lastname + ', ' + firname + ' ' + midname FROM HR.Employees WHERE HR.Employees.username = HR.Leave3Days.username) AS EmployeeName, units AS Units, datestrt AS DateStart, dateend AS DateEnd, remarks AS Remarks, (CASE enabled WHEN '1' THEN 'Yes' WHEN '0' THEN 'No' END) AS Enabled, createby AS CreateBy, createon AS CreateOn, modifyby AS ModifyBy, modifyon AS ModifyOn FROM HR.Leave3Days ORDER BY Enabled DESC";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tblReturn);
        }
        return tblReturn;
    }

    public static DataTable GetDSGMainFormNotification()
    {
        DataTable tblReturn = new DataTable();
        using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
        {
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT leavcode AS leavecode, username AS usernameleave, (SELECT lastname FROM HR.Employees WHERE HR.Employees.username = HR.Leave3Days.username) AS lastnameleave, (SELECT firname FROM HR.Employees WHERE HR.Employees.username = HR.Leave3Days.username) AS firstnameleave FROM HR.Leave3Days WHERE CONVERT(varchar(11),HR.Leave3Days.dateend,1)  <= @dateend AND enabled = '1'";
            cmd.Parameters.Add(new SqlParameter("@dateend", DateTime.Now));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tblReturn);
        }
        return tblReturn;
    }

    }
}

