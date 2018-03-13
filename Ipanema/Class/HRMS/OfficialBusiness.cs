using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace HRMS
{
 public class OfficialBusiness : IDisposable
 {
  public enum OBStatus { Canceled, ForApproval, Approved, Disapproved, Void }

  private string _strOBCode;
  private string _strUsername;
  private DateTime _dteDateFile;
  private string _strReason;
  private string _strOBType;
  private string _strDepartmentCode;
  private string _strRAName;
  private DateTime _dteRADate;
  private string _strRARemarks;
  private string _strRAStatus;
  private string _strHAName;
  private DateTime _dteHADate;
  private string _strHARemarks;
  private string _strHAStatus;
  private string _strStatus;

  public OfficialBusiness() { }
  public OfficialBusiness(string pOBCode) { _strOBCode = pOBCode; }

  public string OBCode { get { return _strOBCode; } set { _strOBCode = value; } }
  public string UserName { get { return _strUsername; } set { _strUsername = value; } }
  public DateTime DateFile { get { return _dteDateFile; } set { _dteDateFile = value; } }
  public string Reason { get { return _strReason; } set { _strReason = value; } }
  public string OBType { get { return _strOBType; } set { _strOBType = value; } }
  public string DepartmentCode { get { return _strDepartmentCode; } set { _strDepartmentCode = value; } }
  public string RAName { get { return _strRAName; } set { _strRAName = value; } }
  public DateTime RADate { get { return _dteRADate; } set { _dteRADate = value; } }
  public string RARemarks { get { return _strRARemarks; } set { _strRARemarks = value; } }
  public string RAStatus { get { return _strRAStatus; } set { _strRAStatus = value; } }
  public string HAName { get { return _strHAName; } set { _strHAName = value; } }
  public DateTime HADate { get { return _dteHADate; } set { _dteHADate = value; } }
  public string HARemarks { get { return _strHARemarks; } set { _strHARemarks = value; } }
  public string HAStatus { get { return _strHAStatus; } set { _strHAStatus = value; } }
  public string Status { get { return _strStatus; } set { _strStatus = value; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.OB WHERE obcode=@obcode";
    cmd.Parameters.Add(new SqlParameter("@obcode", _strOBCode));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strOBCode = dr["obcode"].ToString();
     _strUsername = dr["username"].ToString();
     _dteDateFile = clsValidator.CheckDate(dr["datefile"].ToString());
     _strReason = dr["reason"].ToString();
     _strOBType = dr["obtype"].ToString();
     _strDepartmentCode = dr["deptcode"].ToString();
     _strRAName = dr["apprname"].ToString();
     _dteRADate = clsValidator.CheckDate(dr["apprdate"].ToString());
     _strRARemarks = dr["apprrem"].ToString();
     _strRAStatus = dr["apprstat"].ToString();
     _strHAName = dr["apphname"].ToString();
     _dteHADate = clsValidator.CheckDate(dr["apphdate"].ToString());
     _strHARemarks = dr["apphrem"].ToString();
     _strHAStatus = dr["apphstat"].ToString();
     _strStatus = dr["obstat"].ToString();
    }
    dr.Close();
   }
  }

  public int InsertAdmin()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    //ADDED JAN 19, 2018 by: Calvin
    string insertOB_query = "INSERT INTO HR.OB (obcode,"+
                                             "username,"+
                                             "datefile,"+
                                             "reason,"+
                                             "obtype,"+
                                             "deptcode,"+
                                             "apprname,"+
                                             "apprdate,"+
                                             "apprrem,"+
                                             "apprstat,"+
                                             "apphname,"+
                                             "apphdate,"+
                                             "apphrem,"+
                                             "apphstat,"+
                                             "obstat) "+
                                    "VALUES (@obcode,"+
                                            "@username,"+
                                            "@datefile,"+
                                            "@reason,"+
                                            "@obtype,"+
                                            "@deptcode,"+
                                            "@apprname,"+
                                            "@apprdate,"+
                                            "@apprrem,"+
                                            "@apprstat,"+
                                            "@apphname,"+
                                            "@apphdate,"+
                                            "@apphrem,"+
                                            "@apphstat,"+
                                            "@obstat)";      
                
                SqlCommand cmd = new SqlCommand(insertOB_query,cn);
                cmd.Parameters.Add(new SqlParameter("@obcode",_strOBCode));
                cmd.Parameters.Add(new SqlParameter("@username",_strUsername));
                cmd.Parameters.Add(new SqlParameter("@datefile",_dteDateFile));
                cmd.Parameters.Add(new SqlParameter("@reason",_strReason));
                cmd.Parameters.Add(new SqlParameter("@obtype",_strOBType));
                cmd.Parameters.Add(new SqlParameter("@deptcode",_strDepartmentCode));

                if (_strOBType == "0"){
                    cmd.Parameters.Add(new SqlParameter("@apprname", DBNull.Value));
                    cmd.Parameters.Add(new SqlParameter("@apprdate", DBNull.Value));
                    cmd.Parameters.Add(new SqlParameter("@apprrem", DBNull.Value));
                    cmd.Parameters.Add(new SqlParameter("@apprstat", DBNull.Value));
                }
                else{
                    cmd.Parameters.Add(new SqlParameter("@apprname", _strRAName));
                    cmd.Parameters.Add(new SqlParameter("@apprdate", _dteRADate));
                    cmd.Parameters.Add(new SqlParameter("@apprrem", _strRARemarks));
                    cmd.Parameters.Add(new SqlParameter("@apprstat", _strRAStatus));
                }
                cmd.Parameters.Add(new SqlParameter("@apphname",_strHAName));
                cmd.Parameters.Add(new SqlParameter("@apphdate",_dteHADate));
                cmd.Parameters.Add(new SqlParameter("@apphrem",_strHARemarks));
                cmd.Parameters.Add(new SqlParameter("@apphstat",_strHAStatus));
                cmd.Parameters.Add(new SqlParameter("@obstat",_strStatus));
                cn.Open();
                intReturn = cmd.ExecuteNonQuery();

                /* EDIT: JAN 19, 2018 by:Calvin
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "spOBInsertAdmin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@datefile", SqlDbType.DateTime);
                cmd.Parameters.Add("@reason", SqlDbType.VarChar, 255);
                cmd.Parameters.Add("@obtype", SqlDbType.Char, 1);
                cmd.Parameters.Add("@deptcode", SqlDbType.Char, 3);
                cmd.Parameters.Add("@apprname", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@apprdate", SqlDbType.DateTime);
                cmd.Parameters.Add("@apprrem", SqlDbType.VarChar, 255);
                cmd.Parameters.Add("@apprstat", SqlDbType.Char, 1);
                cmd.Parameters.Add("@apphname", SqlDbType.VarChar, 30);
                cmd.Parameters.Add("@apphdate", SqlDbType.DateTime);
                cmd.Parameters.Add("@apphrem", SqlDbType.VarChar, 255);
                cmd.Parameters.Add("@apphstat", SqlDbType.Char, 1);
                cmd.Parameters.Add("@obstat", SqlDbType.Char, 1);
                cmd.Parameters.Add("@obcode", SqlDbType.Char, 9);

                cmd.Parameters["@username"].Value = _strUsername;
                cmd.Parameters["@datefile"].Value = _dteDateFile;
                cmd.Parameters["@reason"].Value = _strReason;
                cmd.Parameters["@obtype"].Value = _strOBType;
                cmd.Parameters["@deptcode"].Value = _strDepartmentCode;
                if (_strOBType == "0")
                {
                 cmd.Parameters["@apprname"].Value = DBNull.Value;
                 cmd.Parameters["@apprdate"].Value = DBNull.Value;
                 cmd.Parameters["@apprrem"].Value = DBNull.Value;
                 cmd.Parameters["@apprstat"].Value = DBNull.Value;
                }
                else
                {
                 cmd.Parameters["@apprname"].Value = _strRAName;
                 cmd.Parameters["@apprdate"].Value = _dteRADate;
                 cmd.Parameters["@apprrem"].Value = _strRARemarks;
                 cmd.Parameters["@apprstat"].Value = _strRAStatus;
                }
                cmd.Parameters["@apphname"].Value = _strHAName;
                cmd.Parameters["@apphdate"].Value = _dteHADate;
                cmd.Parameters["@apphrem"].Value = _strHARemarks;
                cmd.Parameters["@apphstat"].Value = _strHAStatus;
                cmd.Parameters["@obstat"].Value = _strStatus;
                cmd.Parameters["@obcode"].Direction = ParameterDirection.Output;
                cn.Open();
                intReturn = cmd.ExecuteNonQuery();
                _strOBCode = cmd.Parameters["@obcode"].Value.ToString();
                */
            }
   return intReturn;
  }

  public int UpdateAdmin()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.OB SET datefile=@datefile, reason=@reason, apprdate=@apprdate, apprrem=@apprrem, apprstat=@apprstat, apphdate=@apphdate, apphrem=@apphrem, apphstat=@apphstat, obstat=@obstat  WHERE obcode=@obcode";
    cmd.Parameters.Add("@datefile", SqlDbType.DateTime);
    cmd.Parameters.Add("@reason", SqlDbType.VarChar, 255);
    cmd.Parameters.Add("@apprdate", SqlDbType.DateTime);
    cmd.Parameters.Add("@apprrem", SqlDbType.VarChar, 255);
    cmd.Parameters.Add("@apprstat", SqlDbType.Char, 1);
    cmd.Parameters.Add("@apphdate", SqlDbType.DateTime);
    cmd.Parameters.Add("@apphrem", SqlDbType.VarChar, 255);
    cmd.Parameters.Add("@apphstat", SqlDbType.Char, 1);
    cmd.Parameters.Add("@obstat", SqlDbType.Char, 1);
    cmd.Parameters.Add("@obcode", SqlDbType.Char, 9);
    cmd.Parameters["@datefile"].Value = _dteDateFile;
    cmd.Parameters["@reason"].Value = _strReason;
    if (_strOBType == "0")
    {
     cmd.Parameters["@apprdate"].Value = DBNull.Value;
     cmd.Parameters["@apprrem"].Value = DBNull.Value;
     cmd.Parameters["@apprstat"].Value = DBNull.Value;
    }
    else
    {
     cmd.Parameters["@apprdate"].Value = _dteRADate;
     cmd.Parameters["@apprrem"].Value = _strRARemarks;
     cmd.Parameters["@apprstat"].Value = _strRAStatus;
    }
    cmd.Parameters["@apphdate"].Value = _dteHADate;
    cmd.Parameters["@apphrem"].Value = _strHARemarks;
    cmd.Parameters["@apphstat"].Value = _strHAStatus;
    cmd.Parameters["@obstat"].Value = _strStatus;
    cmd.Parameters["@obcode"].Value = _strOBCode;
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int DeleteAdmin()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "DELETE FROM HR.OB WHERE obcode=@obcode";
    cmd.Parameters.Add("@obcode", SqlDbType.Char, 9);
    cmd.Parameters["@obcode"].Value = _strOBCode;
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable GetDSGApplications(DateTime pFocusDate, string pUsername, string pFilter)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    if (pFilter == "ALL")
     cmd.CommandText = "SELECT obcode FROM HR.OB WHERE username='" + pUsername + "' AND obcode IN (SELECT obcode FROM HR.OBDetails WHERE '" + pFocusDate + "' BETWEEN CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,keyin))) AND CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,keyout))))";
    else
     cmd.CommandText = "SELECT obcode FROM HR.OB WHERE username='" + pUsername + "' AND obstat='A' AND obcode IN (SELECT obcode FROM HR.OBDetails WHERE '" + pFocusDate + "' BETWEEN CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,keyin))) AND CONVERT(DATETIME, FLOOR(CONVERT(FLOAT,keyout))))";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDSGOBMainForm(string pRequestor, string pReason, DateTime pDateStart, DateTime pDateEnd, string pOBType, string pOBStatus)
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("OBCode");
   tblReturn.Columns.Add("StatusCode");
   tblReturn.Columns.Add("StatusDesc");
   tblReturn.Columns.Add("Requestor");
   tblReturn.Columns.Add("OBTypeDesc");
   tblReturn.Columns.Add("DateFile");
   tblReturn.Columns.Add("DateStart");
   tblReturn.Columns.Add("DateEnd");
   tblReturn.Columns.Add("RenderedTo");
   tblReturn.Columns.Add("Reason");
   tblReturn.Columns.Add("RApprover");
   tblReturn.Columns.Add("HApprover");

   string strWhere = "";

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    
    if (pOBStatus != "ALL")
    {
     strWhere = strWhere + "AND obstat=@obstat ";
     cmd.Parameters.Add(new SqlParameter("@obstat", pOBStatus));
    }

    if (pOBType != "ALL")
    {
     strWhere = strWhere + "AND obtype=@obtype ";
     cmd.Parameters.Add(new SqlParameter("@obtype", pOBType));
    }

    cmd.CommandText = "SELECT obcode, obstat, (SELECT lastname + ', ' + firname + ' ' + midintl + '. ' FROM HR.Employees WHERE username=HR.OB.username) AS Requestor, obtype, datefile, (SELECT deptname FROM HR.Department WHERE deptcode=HR.OB.deptcode) AS DepartmentName, reason, (SELECT lastname + ', ' + firname + ' ' + midintl + '. ' FROM HR.Employees WHERE username=HR.OB.apprname) AS RApproverName, (SELECT lastname + ', ' + firname + ' ' + midintl + '. ' FROM HR.Employees WHERE username=HR.OB.apphname) AS HApproverName, (SELECT TOP 1 keyin FROM HR.OBDetails WHERE obcode=HR.OB.obcode ORDER BY keyin) AS OBStart, (SELECT TOP 1 keyout FROM HR.OBDetails WHERE obcode=HR.OB.obcode ORDER BY keyout DESC) AS OBEnd FROM HR.OB WHERE username IN (SELECT username FROM HR.Employees WHERE (lastname LIKE @SearchName + '%') OR (firname LIKE @SearchName + '%')) AND reason LIKE '%' + @reason + '%' AND obcode IN (SELECT obcode FROM HR.OBDetails WHERE (keyin BETWEEN @OBStart AND @OBEnd) OR (keyout BETWEEN @OBStart AND @OBEnd)) " + strWhere + "ORDER BY obcode DESC";
    cmd.Parameters.Add(new SqlParameter("@SearchName", pRequestor));
    cmd.Parameters.Add(new SqlParameter("@reason", pReason));
    cmd.Parameters.Add(new SqlParameter("@OBStart", pDateStart));
    cmd.Parameters.Add(new SqlParameter("@OBEnd", pDateEnd));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     DataRow drwN = tblReturn.NewRow();
     drwN["OBCode"] = dr["obcode"].ToString();
     drwN["StatusCode"] = dr["obstat"].ToString();
     drwN["StatusDesc"] = OfficialBusiness.ToOBStatusDesc(dr["obstat"].ToString());
     drwN["Requestor"] = dr["Requestor"].ToString();
     drwN["OBTypeDesc"] = OfficialBusiness.ToOBTypeDesc(dr["obtype"].ToString());
     drwN["DateFile"] = clsValidator.CheckDate(dr["datefile"].ToString());
     drwN["DateStart"] = clsValidator.CheckDate(dr["OBStart"].ToString());
     drwN["DateEnd"] = clsValidator.CheckDate(dr["OBEnd"].ToString());
     drwN["RenderedTo"] = dr["DepartmentName"].ToString();
     drwN["Reason"] = dr["reason"].ToString();
     drwN["RApprover"] = dr["RApproverName"].ToString();
     drwN["HApprover"] = dr["HApproverName"].ToString();
     tblReturn.Rows.Add(drwN);
    }
    dr.Close();
   }
   return tblReturn;
  }

  public static string GetOBTypeDesc(string pOBType)
  {
   return (pOBType == "0" ? "Rendered within the department" : "Rendered to other department");
  }

  public static DataTable DdlDsApproveFilter()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");

   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "A";
   drw["ptext"] = "Approved";
   tblReturn.Rows.Add(drw);

   return tblReturn;
  }

  public static string GetRequestor(string pOBCode)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username FROM HR.OB WHERE obcode='" + pOBCode + "'";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static DataTable DdlDsOBType()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");

   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "0";
   drw["ptext"] = "Rendered within department";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "1";
   drw["ptext"] = "Rendered to other department";
   tblReturn.Rows.Add(drw);

   return tblReturn;
  }

  public static DataTable DdlDsOBTypeAll()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");

   DataRow  drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "0";
   drw["ptext"] = "Rendered within department";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "1";
   drw["ptext"] = "Rendered to other department";
   tblReturn.Rows.Add(drw);

   return tblReturn;
  }

  public static DataTable DdlDsStatusAll()
  {
   DataTable tblReturn = new DataTable();

   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drwS = tblReturn.NewRow();
   drwS["pvalue"] = "ALL";
   drwS["ptext"] = "All";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "A";
   drwS["ptext"] = "Approved";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "C";
   drwS["ptext"] = "Cancelled";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "D";
   drwS["ptext"] = "Disapproved";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "F";
   drwS["ptext"] = "For Approval";
   tblReturn.Rows.Add(drwS);

   return tblReturn;
  }

  public static DataTable DdlDsStatus()
  {
   DataTable tblReturn = new DataTable();

   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drwS = tblReturn.NewRow();
   drwS["pvalue"] = "A";
   drwS["ptext"] = "Approved";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "C";
   drwS["ptext"] = "Cancelled";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "D";
   drwS["ptext"] = "Disapproved";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "F";
   drwS["ptext"] = "For Approval";
   tblReturn.Rows.Add(drwS);

   return tblReturn;
  }

  public static Color GetLVBGColor(string pStatus)
  {
   Color clrReturn = Color.White;

   switch (pStatus)
   {
    case "F":
     clrReturn = Color.AliceBlue;
     break;
    case "D":
     clrReturn = Color.MistyRose;
     break;
    case "A":
     clrReturn = Color.Honeydew;
     break;
    case "C":
     clrReturn = Color.PeachPuff;
     break;
   }

   return clrReturn;
  }

  public static string ToOBStatusDesc(string pOBStatusCode)
  {
   switch (pOBStatusCode)
   {
    case "C":
     return "Cancelled";
    case "F":
     return "For Approval";
    case "A":
     return "Approved";
    case "D":
     return "Disapproved";
    default:
     return "Cancelled";
   }
  }

  public static string ToOBTypeDesc(string pOBTypeCode)
  {
   if(pOBTypeCode == "0")
    return "Rendered within department";
   else
    return "Rendered to other department";
  }

  public static DataTable DdlDsStatusApprover()
  {
   DataTable tblReturn = new DataTable();

   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drwS = tblReturn.NewRow();
   drwS["pvalue"] = "A";
   drwS["ptext"] = "Approved";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "D";
   drwS["ptext"] = "Disapproved";
   tblReturn.Rows.Add(drwS);

   drwS = tblReturn.NewRow();
   drwS["pvalue"] = "F";
   drwS["ptext"] = "For Approval";
   tblReturn.Rows.Add(drwS);

   return tblReturn;
  }

  public static DateTime GetOBStart(string pOBCode)
  {
   DateTime dteReturn = DateTime.Now;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 keyin FROM HR.OBDetails WHERE obcode='" + pOBCode + "' ORDER BY keyin";
    cn.Open();
    try { dteReturn = clsValidator.CheckDate(cmd.ExecuteScalar().ToString()); }
    catch { }
   }
   return dteReturn;
  }

  public static DateTime GetOBEnd(string pOBCode)
  {
   DateTime dteReturn = DateTime.Now;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT TOP 1 keyout FROM HR.OBDetails WHERE obcode='" + pOBCode + "' ORDER BY keyout DESC";
    cn.Open();
    try { dteReturn = clsValidator.CheckDate(cmd.ExecuteScalar().ToString()); }
    catch { }
   }
   return dteReturn;
  }

 }
}