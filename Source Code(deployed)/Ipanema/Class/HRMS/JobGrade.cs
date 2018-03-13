using System;
using System.Data;
using System.Data.SqlClient;

namespace HRMS
{
 public class JobGrade : IDisposable
 {

  private string _strJGCode;
  private string _strJGDescription;
  private int _intJGOrder;
  private string _strDeductLate;
  private string _strDeductUnderTime;
  private string _strPayOverTime;
  private int _intPlantillaCountHQ;
  private int _intPlantillaCountBillable;
  private string _strCreateBy;
  private DateTime _dteCreateOn;
  private string _strModifyBy;
  private DateTime _dteModifyOn;

  public JobGrade() { }

  public string JGCode { get { return _strJGCode; } set { _strJGCode = value; } }
  public string JGDescription { get { return _strJGDescription; } set { _strJGDescription = value; } }
  public int JGOrder { get { return _intJGOrder; } set { _intJGOrder = value; } }
  public string DeductLate { get { return _strDeductLate; } set { _strDeductLate = value; } }
  public string DeductUnderTime { get { return _strDeductUnderTime; } set { _strDeductUnderTime = value; } }
  public string PayOverTime { get { return _strPayOverTime; } set { _strPayOverTime = value; } }
  public int PlantillaCountHQ { get { return _intPlantillaCountHQ; } set { _intPlantillaCountHQ = value; } }
  public int PlantillaCountBillable { get { return _intPlantillaCountBillable; } set { _intPlantillaCountBillable = value; } }
  public string CreateBy { get { return _strCreateBy; } }
  public DateTime CreateOn { get { return _dteCreateOn; } }
  public string ModifyBy { get { return _strModifyBy; } }
  public DateTime ModifyOn { get { return _dteModifyOn; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.JobGrade WHERE jgcode='" + _strJGCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _strJGCode = dr["jgcode"].ToString();
     _strJGDescription = dr["jgdesc"].ToString();
     _intJGOrder = clsValidator.CheckInteger(dr["jgorder"].ToString());
     _strDeductLate = dr["dedulate"].ToString();
     _strDeductUnderTime = dr["deduut"].ToString();
     _strPayOverTime = dr["payot"].ToString();
     _intPlantillaCountHQ = clsValidator.CheckInteger(dr["plntcnth"].ToString());
     _intPlantillaCountBillable = clsValidator.CheckInteger(dr["plntcntb"].ToString());
     _strCreateBy = dr["createby"].ToString();
     _dteCreateOn = clsValidator.CheckDate(dr["createon"].ToString());
     _strModifyBy = dr["modifyby"].ToString();
     _dteModifyOn = clsValidator.CheckDate(dr["modifyon"].ToString());
    }
    dr.Close();
   }
  }

  public int Insert()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "INSERT INTO HR.JobGrade VALUES(@jgcode,@jgdesc,@jgorder,@dedulate,@deduut,@payot,@plntcnth,@plntcntb,@createby,@createon,@modifyby,@modifyon)";
    cmd.Parameters.Add(new SqlParameter("@jgcode", _strJGCode));
    cmd.Parameters.Add(new SqlParameter("@jgdesc", _strJGDescription));
    cmd.Parameters.Add(new SqlParameter("@jgorder", _intJGOrder));
    cmd.Parameters.Add(new SqlParameter("@dedulate", _strDeductLate));
    cmd.Parameters.Add(new SqlParameter("@deduut", _strDeductUnderTime));
    cmd.Parameters.Add(new SqlParameter("@payot", _strPayOverTime));
    cmd.Parameters.Add(new SqlParameter("@plntcnth", _intPlantillaCountHQ));
    cmd.Parameters.Add(new SqlParameter("@plntcntb", _intPlantillaCountBillable));
    cmd.Parameters.Add(new SqlParameter("@createby", HRMSCore.Username));
    cmd.Parameters.Add(new SqlParameter("@createon", DateTime.Now));
    cmd.Parameters.Add(new SqlParameter("@modifyby", HRMSCore.Username));
    cmd.Parameters.Add(new SqlParameter("@modifyon", DateTime.Now));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int Update()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.JobGrade SET jgdesc=@jgdesc, jgorder=@jgorder, dedulate=@dedulate, deduut=@deduut, payot=@payot, plntcnth=@plntcnth, plntcntb=@plntcntb, modifyby=@modifyby, modifyon=@modifyon WHERE jgcode=@jgcode";
    cmd.Parameters.Add(new SqlParameter("@jgcode", _strJGCode));
    cmd.Parameters.Add(new SqlParameter("@jgdesc", _strJGDescription));
    cmd.Parameters.Add(new SqlParameter("@jgorder", _intJGOrder));
    cmd.Parameters.Add(new SqlParameter("@dedulate", _strDeductLate));
    cmd.Parameters.Add(new SqlParameter("@deduut", _strDeductUnderTime));
    cmd.Parameters.Add(new SqlParameter("@payot", _strPayOverTime));
    cmd.Parameters.Add(new SqlParameter("@plntcnth", _intPlantillaCountHQ));
    cmd.Parameters.Add(new SqlParameter("@plntcntb", _intPlantillaCountBillable));
    cmd.Parameters.Add(new SqlParameter("@modifyby", HRMSCore.Username));
    cmd.Parameters.Add(new SqlParameter("@modifyon", DateTime.Now));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int Delete()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "DELETE FROM HR.JobGrade WHERE jgcode='" + _strJGCode + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static DataTable DSLJGCode()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT jgcode AS pvalue, jgcode AS ptext FROM HR.JobGrade ORDER BY jgorder";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSLJGCodeAll()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("pvalue");
   tblReturn.Columns.Add("ptext");
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT jgcode FROM HR.JobGrade ORDER BY jgorder";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     drw = tblReturn.NewRow();
     drw["pvalue"] = dr["jgcode"].ToString();
     drw["ptext"] = dr["jgcode"].ToString();
     tblReturn.Rows.Add(drw);
    }
    dr.Close();
   }
   return tblReturn;
  }

  public static DataTable DSJobGrade()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.JobGrade ORDER BY jgorder";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static bool IsCodeExist(string pJGCode)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT jgcode FROM HR.JobGrade WHERE jgcode='" + pJGCode + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
   return blnReturn;
  }

 }

}