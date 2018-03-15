using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace HRMS
{
 public enum EmployeeAccountType { All, Active, NonActive }
 public enum EmployeeNameFormat { FirstLast, LastFirst }
 public enum EmployeeWhereParameter { Username, EmployeeNumber, Lastname }

 public class Employee : IDisposable
 {
  public Employee() { }

  private string _strUsername;
  private Image _imgImage;
  private string _strEmployeeNumber;
  private string _strLastName;
  private string _strFirstName;
  private string _strMiddleName;
  private string _strMiddleInitial;
  private string _strNickName;
  private DateTime _dteBirthDate;
  private string _strGender;
  private string _strEmploymentTypeCode;
  private string _strEmploymentStatusCode;
  private string _strTitle;
  private string _strSuffix;
  private string _strCompanyCode;
  private string _strPosition;
  private string _strRemarks;
  private string _strEmergencyPerson;
  private string _strEmergencyRelation;
  private string _strEmergencyAddress;
  private string _strEmergencyPhoneNumber;
  private string _strEmergencyCellNumber;
  private string _strBirthPlace;
  private string _strCitizenship;
  private string _strHeight;
  private string _strWeight;
  private string _strBloodType;
  private string _strHobbies;
  private string _strLanguage;
  private string _strCivilStatus;
  private string _strFatherName;
  private DateTime _dteFatherBirthDate;
  private string _strMotherName;
  private DateTime _dteMotherBirthDate;
  private string _strSpouseName;
  private DateTime _dteSpouseBirthDate;
  private string _strPermanentAddress;
  private string _strPermanentCity;
  private string _strPermanentPhoneNumber;
  private string _strCurrentAddress;
  private string _strCurrentCity;
  private string _strCurrentPhoneNumber;
  private string _strPrimaryMobileNumber;
  private string _strAlternativeMobileNumber;
  private string _strDirectNumber;
  private string _strLocalNumber;
  private string _strFaxNumber;
  private string _strEmailOfficial;
  private string _strEmailPersonal;
  private string _strScheduleCode;
  private string _strSssID;
  private string _strPhilHealthID;
  private string _strTaxID;
  private string _strHdmfID;
  private string _strHmoID;
  private string _strBankAccount;
  private string _strDivisionCode;
  private string _strGroupCode;
  private string _strDepartmentCode;
  private string _strRcCode;
  private string _strJGCode;
  private string _strAssignment;
  private DateTime _dteDateStart;
  private DateTime _dteDateRegular;
  private DateTime _dteDateEnd;
  private string _strUpdatedBy;
  private DateTime _dteUpdatedOn;
  private string _strSkillPrimary;
  private string _strSkillSecondary;
  private string _strStatus;
  private string _strIsBillable;
  private string _strResignCode;
  private string _strResignRemarks;
  private string _strIsResignDesired;
  private string _strRecruitmentSourceCode;
  private string _strRecruitmentSourceRemarks;

  public string Username { get { return _strUsername; } set { _strUsername = value; } }
  public Image Image { get { return _imgImage; } set { _imgImage = value; } }
  public string EmployeeNumber { get { return _strEmployeeNumber; } set { _strEmployeeNumber = value; } }
  public string LastName { get { return _strLastName; } set { _strLastName = value; } }
  public string FirstName { get { return _strFirstName; } set { _strFirstName = value; } }
  public string MiddleName { get { return _strMiddleName; } set { _strMiddleName = value; } }
  public string MiddleInitial { get { return _strMiddleInitial; } set { _strMiddleInitial = value; } }
  public string NickName { get { return _strNickName; } set { _strNickName = value; } }
  public DateTime BirthDate { get { return _dteBirthDate; } set { _dteBirthDate = value; } }
  public string Gender { get { return _strGender; } set { _strGender = value; } }
  public string EmploymentTypeCode { get { return _strEmploymentTypeCode; } set { _strEmploymentTypeCode = value; } }
  public string EmploymentStatusCode { get { return _strEmploymentStatusCode; } set { _strEmploymentStatusCode = value; } }
  public string Title { get { return _strTitle; } set { _strTitle = value; } }
  public string Suffix { get { return _strSuffix; } set { _strSuffix = value; } }
  public string CompanyCode { get { return _strCompanyCode; } set { _strCompanyCode = value; } }
  public string Position { get { return _strPosition; } set { _strPosition = value; } }
  public string Remarks { get { return _strRemarks; } set { _strRemarks = value; } }
  public string EmergencyPerson { get { return _strEmergencyPerson; } set { _strEmergencyPerson = value; } }
  public string EmergencyRelation { get { return _strEmergencyRelation; } set { _strEmergencyRelation = value; } }
  public string EmergencyAddress { get { return _strEmergencyAddress; } set { _strEmergencyAddress = value; } }
  public string EmergencyPhoneNumber { get { return _strEmergencyPhoneNumber; } set { _strEmergencyPhoneNumber = value; } }
  public string EmergencyCellNumber { get { return _strEmergencyCellNumber; } set { _strEmergencyCellNumber = value; } }
  public string BirthPlace { get { return _strBirthPlace; } set { _strBirthPlace = value; } }
  public string Citizenship { get { return _strCitizenship; } set { _strCitizenship = value; } }
  public string Height { get { return _strHeight; } set { _strHeight = value; } }
  public string Weight { get { return _strWeight; } set { _strWeight = value; } }
  public string BloodType { get { return _strBloodType; } set { _strBloodType = value; } }
  public string Hobbies { get { return _strHobbies; } set { _strHobbies = value; } }
  public string Language { get { return _strLanguage; } set { _strLanguage = value; } }
  public string CivilStatus { get { return _strCivilStatus; } set { _strCivilStatus = value; } }
  public string FatherName { get { return _strFatherName; } set { _strFatherName = value; } }
  public DateTime FatherBirthDate { get { return _dteFatherBirthDate; } set { _dteFatherBirthDate = value; } }
  public string MotherName { get { return _strMotherName; } set { _strMotherName = value; } }
  public DateTime MotherBirthDate { get { return _dteMotherBirthDate; } set { _dteMotherBirthDate = value; } }
  public string SpouseName { get { return _strSpouseName; } set { _strSpouseName = value; } }
  public DateTime SpouseBirthDate { get { return _dteSpouseBirthDate; } set { _dteSpouseBirthDate = value; } }
  public string PermanentAddress { get { return _strPermanentAddress; } set { _strPermanentAddress = value; } }
  public string PermanentCity { get { return _strPermanentCity; } set { _strPermanentCity = value; } }
  public string PermanentPhoneNumber { get { return _strPermanentPhoneNumber; } set { _strPermanentPhoneNumber = value; } }
  public string CurrentAddress { get { return _strCurrentAddress; } set { _strCurrentAddress = value; } }
  public string CurrentCity { get { return _strCurrentCity; } set { _strCurrentCity = value; } }
  public string CurrentPhoneNumber { get { return _strCurrentPhoneNumber; } set { _strCurrentPhoneNumber = value; } }
  public string PrimaryMobileNumber { get { return _strPrimaryMobileNumber; } set { _strPrimaryMobileNumber = value; } }
  public string AlternativeMobileNumber { get { return _strAlternativeMobileNumber; } set { _strAlternativeMobileNumber = value; } }
  public string DirectNumber { get { return _strDirectNumber; } set { _strDirectNumber = value; } }
  public string LocalNumber { get { return _strLocalNumber; } set { _strLocalNumber = value; } }
  public string FaxNumber { get { return _strFaxNumber; } set { _strFaxNumber = value; } }
  public string EmailOfficial { get { return _strEmailOfficial; } set { _strEmailOfficial = value; } }
  public string EmailPersonal { get { return _strEmailPersonal; } set { _strEmailPersonal = value; } }
  public string ScheduleCode { get { return _strScheduleCode; } set { _strScheduleCode = value; } }
  public string SssID { get { return _strSssID; } set { _strSssID = value; } }
  public string PhilHealthID { get { return _strPhilHealthID; } set { _strPhilHealthID = value; } }
  public string TaxID { get { return _strTaxID; } set { _strTaxID = value; } }
  public string HdmfID { get { return _strHdmfID; } set { _strHdmfID = value; } }
  public string HmoID { get { return _strHmoID; } set { _strHmoID = value; } }
  public string BankAccount { get { return _strBankAccount; } set { _strBankAccount = value; } }
  public string DivisionCode { get { return _strDivisionCode; } set { _strDivisionCode = value; } }
  public string GroupCode { get { return _strGroupCode; } set { _strGroupCode = value; } }
  public string DepartmentCode { get { return _strDepartmentCode; } set { _strDepartmentCode = value; } }
  public string RcCode { get { return _strRcCode; } set { _strRcCode = value; } }
  public string JGCode { get { return _strJGCode; } set { _strJGCode = value; } }
  public string Assignment { get { return _strAssignment; } set { _strAssignment = value; } }
  public DateTime DateStart { get { return _dteDateStart; } set { _dteDateStart = value; } }
  public DateTime DateRegular { get { return _dteDateRegular; } set { _dteDateRegular = value; } }
  public DateTime DateEnd { get { return _dteDateEnd; } set { _dteDateEnd = value; } }
  public string UpdatedBy { get { return _strUpdatedBy; } set { _strUpdatedBy = value; } }
  public DateTime UpdatedOn { get { return _dteUpdatedOn; } set { _dteUpdatedOn = value; } }
  public string SkillPrimary { get { return _strSkillPrimary; } set { _strSkillPrimary = value; } }
  public string SkillSecondary { get { return _strSkillSecondary; } set { _strSkillSecondary = value; } }
  public string Status { get { return _strStatus; } set { _strStatus = value; } }
  public string IsBillable { get { return _strIsBillable; } set { _strIsBillable = value; } }
  public string ResignCode { get { return _strResignCode; } set { _strResignCode = value; } }
  public string ResignRemarks { get { return _strResignRemarks; } set { _strResignRemarks = value; } }
  public string IsResignDesired { get { return _strIsResignDesired; } set { _strIsResignDesired = value; } }
  public string RecruitmentSourceCode { get { return _strRecruitmentSourceCode; } set { _strRecruitmentSourceCode = value; } }
  public string RecruitmentSourceRemarks { get { return _strRecruitmentSourceRemarks; } set { _strRecruitmentSourceRemarks = value; } }

  public void Fill()
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM HR.Employees WHERE username=@username";
    cmd.Parameters.Add(new SqlParameter("@username", _strUsername));
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    if (dr.Read())
    {
     _imgImage = clsImage.GetImage(dr["pimage"]);
     _strEmployeeNumber = dr["empnum"].ToString();
     _strLastName = dr["lastname"].ToString();
     _strFirstName = dr["firname"].ToString();
     _strMiddleName = dr["midname"].ToString();
     _strMiddleInitial = dr["midintl"].ToString();
     _strNickName = dr["nickname"].ToString();
     _dteBirthDate = clsValidator.CheckDate(dr["brthdate"].ToString());
     _strGender = dr["gender"].ToString();
     _strEmploymentTypeCode = dr["etypcode"].ToString();
     _strEmploymentStatusCode = dr["esttcode"].ToString();
     _strTitle = dr["title"].ToString();
     _strSuffix = dr["suffix"].ToString();
     _strCompanyCode = dr["comcode"].ToString();
     _strPosition = dr["position"].ToString();
     _strRemarks = dr["remarks"].ToString();
     _strEmergencyPerson = dr["emername"].ToString();
     _strEmergencyRelation = dr["emerrltn"].ToString();
     _strEmergencyAddress = dr["emeraddr"].ToString();
     _strEmergencyPhoneNumber = dr["emerphon"].ToString();
     _strEmergencyCellNumber = dr["emercell"].ToString();
     _strBirthPlace = dr["brthplac"].ToString();
     _strCitizenship = dr["citizen"].ToString();
     _strHeight = dr["height"].ToString();
     _strWeight = dr["weigth"].ToString();
     _strBloodType = dr["bloodtyp"].ToString();
     _strHobbies = dr["hobbies"].ToString();
     _strLanguage = dr["langspok"].ToString();
     _strCivilStatus = dr["cstatus"].ToString();
     _strFatherName = dr["fthrname"].ToString();
     _dteFatherBirthDate = clsValidator.CheckDate(dr["fthrdbrt"].ToString());
     _strMotherName = dr["mthrname"].ToString();
     _dteMotherBirthDate = clsValidator.CheckDate(dr["mthrdbrt"].ToString());
     _strSpouseName = dr["spsename"].ToString();
     _dteSpouseBirthDate = clsValidator.CheckDate(dr["spsedbrt"].ToString());
     _strPermanentAddress = dr["permaddr"].ToString();
     _strPermanentCity = dr["permcity"].ToString();
     _strPermanentPhoneNumber = dr["permphon"].ToString();
     _strCurrentAddress = dr["curraddr"].ToString();
     _strCurrentCity = dr["currcity"].ToString();
     _strCurrentPhoneNumber = dr["currphon"].ToString();
     _strPrimaryMobileNumber = dr["primmobl"].ToString();
     _strAlternativeMobileNumber = dr["altrmobl"].ToString();
     _strDirectNumber = dr["drctnmbr"].ToString();
     _strLocalNumber = dr["lcalnmbr"].ToString();
     _strFaxNumber = dr["faxnmbr"].ToString();
     _strEmailOfficial = dr["emailofc"].ToString();
     _strEmailPersonal = dr["emailper"].ToString();
     _strScheduleCode = dr["schdcode"].ToString();
     _strSssID = dr["sssid"].ToString();
     _strPhilHealthID = dr["philid"].ToString();
     _strTaxID = dr["taxid"].ToString();
     _strHdmfID = dr["hdmfid"].ToString();
     _strHmoID = dr["hmoid"].ToString();
     _strBankAccount = dr["bankacct"].ToString();
     _strDivisionCode = dr["divicode"].ToString();
     _strGroupCode = dr["grpcode"].ToString();
     _strDepartmentCode = dr["deptcode"].ToString();
     _strRcCode = dr["rccode"].ToString();
     _strJGCode = dr["jgcode"].ToString();
     _strAssignment = dr["assgnmnt"].ToString();
     _dteDateStart = clsValidator.CheckDate(dr["datestrt"].ToString());
     _dteDateRegular = clsValidator.CheckDate(dr["datereg"].ToString());
     _dteDateEnd = clsValidator.CheckDate(dr["dateend"].ToString());
     _strUpdatedBy = dr["updateby"].ToString();
     _dteUpdatedOn = clsValidator.CheckDate(dr["updateon"].ToString());
     _strSkillPrimary = dr["skillpri"].ToString();
     _strSkillSecondary = dr["skillsec"].ToString();
     _strStatus = dr["pstatus"].ToString();
     _strIsBillable = dr["billable"].ToString();
     _strResignCode = dr["rsgncode"].ToString();
     _strResignRemarks = dr["rsgnrmks"].ToString();
     _strIsResignDesired = dr["rsgndsrd"].ToString();
     _strRecruitmentSourceCode = dr["rsrccode"].ToString();
     _strRecruitmentSourceRemarks = dr["rsrcrmks"].ToString();
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
    cmd.CommandText = "UPDATE HR.Employees SET lastname=@lastname, firname=@firname, midname=@midname, midintl=@midintl, nickname=@nickname, brthdate=@brthdate, gender=@gender, etypcode=@etypcode, esttcode=@esttcode, title=@title, suffix=@suffix, comcode=@comcode, position=@position, remarks=@remarks, emername=@emername, emerrltn=@emerrltn, emeraddr=@emeraddr, emerphon=@emerphon, emercell=@emercell, brthplac=@brthplac, citizen=@citizen, height=@height, weigth=@weigth, bloodtyp=@bloodtyp, hobbies=@hobbies, langspok=@langspok, cstatus=@cstatus, fthrname=@fthrname, fthrdbrt=@fthrdbrt, mthrname=@mthrname, mthrdbrt=@mthrdbrt, spsename=@spsename, spsedbrt=@spsedbrt, permaddr=@permaddr, permcity=@permcity, permphon=@permphon, curraddr=@curraddr, currcity=@currcity, currphon=@currphon, primmobl=@primmobl, altrmobl=@altrmobl, drctnmbr=@drctnmbr, lcalnmbr=@lcalnmbr, faxnmbr=@faxnmbr, emailofc=@emailofc, emailper=@emailper, schdcode=@schdcode, sssid=@sssid, philid=@philid, taxid=@taxid, hdmfid=@hdmfid, hmoid=@hmoid, bankacct=@bankacct, divicode=@divicode, grpcode=@grpcode, deptcode=@deptcode, rccode=@rccode, jgcode=@jgcode, assgnmnt=@assgnmnt, datestrt=@datestrt, datereg=@datereg, dateend=@dateend, skillpri=@skillpri, skillsec=@skillsec, updateby=@updateby, updateon=@updateon, pstatus=@pstatus, billable=@billable, rsgncode=@rsgncode, rsgnrmks=@rsgnrmks, rsgndsrd=@rsgndsrd, rsrccode=@rsrccode, rsrcrmks=@rsrcrmks WHERE username=@username";
    cmd.Parameters.Add(new SqlParameter("@username", _strUsername));
    cmd.Parameters.Add(new SqlParameter("@lastname", _strLastName));
    cmd.Parameters.Add(new SqlParameter("@firname", _strFirstName));
    cmd.Parameters.Add(new SqlParameter("@midname", _strMiddleName));
    cmd.Parameters.Add(new SqlParameter("@midintl", _strMiddleInitial));
    cmd.Parameters.Add(new SqlParameter("@nickname", _strNickName));
    cmd.Parameters.Add(new SqlParameter("@brthdate", _dteBirthDate));
    cmd.Parameters.Add(new SqlParameter("@gender", _strGender));
    cmd.Parameters.Add(new SqlParameter("@etypcode", _strEmploymentTypeCode));
    cmd.Parameters.Add(new SqlParameter("@esttcode", _strEmploymentStatusCode));
    cmd.Parameters.Add(new SqlParameter("@title", _strTitle));
    cmd.Parameters.Add(new SqlParameter("@suffix", _strSuffix));
    cmd.Parameters.Add(new SqlParameter("@comcode", _strCompanyCode));
    cmd.Parameters.Add(new SqlParameter("@position", _strPosition));
    cmd.Parameters.Add(new SqlParameter("@remarks", _strRemarks));
    cmd.Parameters.Add(new SqlParameter("@emername", _strEmergencyPerson));
    cmd.Parameters.Add(new SqlParameter("@emerrltn", _strEmergencyRelation));
    cmd.Parameters.Add(new SqlParameter("@emeraddr", _strEmergencyAddress));
    cmd.Parameters.Add(new SqlParameter("@emerphon", _strEmergencyPhoneNumber));
    cmd.Parameters.Add(new SqlParameter("@emercell", _strEmergencyCellNumber));
    cmd.Parameters.Add(new SqlParameter("@brthplac", _strBirthPlace));
    cmd.Parameters.Add(new SqlParameter("@citizen", _strCitizenship));
    cmd.Parameters.Add(new SqlParameter("@height", _strHeight));
    cmd.Parameters.Add(new SqlParameter("@weigth", _strWeight));
    cmd.Parameters.Add(new SqlParameter("@bloodtyp", _strBloodType));
    cmd.Parameters.Add(new SqlParameter("@hobbies", _strHobbies));
    cmd.Parameters.Add(new SqlParameter("@langspok", _strLanguage));
    cmd.Parameters.Add(new SqlParameter("@cstatus", _strCivilStatus));
    cmd.Parameters.Add(new SqlParameter("@fthrname", _strFatherName));
    cmd.Parameters.Add(new SqlParameter("@fthrdbrt", _dteFatherBirthDate));
    cmd.Parameters.Add(new SqlParameter("@mthrname", _strMotherName));
    cmd.Parameters.Add(new SqlParameter("@mthrdbrt", _dteMotherBirthDate));
    cmd.Parameters.Add(new SqlParameter("@spsename", _strSpouseName));
    cmd.Parameters.Add(new SqlParameter("@spsedbrt", _dteSpouseBirthDate));
    cmd.Parameters.Add(new SqlParameter("@permaddr", _strPermanentAddress));
    cmd.Parameters.Add(new SqlParameter("@permcity", _strPermanentCity));
    cmd.Parameters.Add(new SqlParameter("@permphon", _strPermanentPhoneNumber));
    cmd.Parameters.Add(new SqlParameter("@curraddr", _strCurrentAddress));
    cmd.Parameters.Add(new SqlParameter("@currcity", _strCurrentCity));
    cmd.Parameters.Add(new SqlParameter("@currphon", _strCurrentPhoneNumber));
    cmd.Parameters.Add(new SqlParameter("@primmobl", _strPrimaryMobileNumber));
    cmd.Parameters.Add(new SqlParameter("@altrmobl", _strAlternativeMobileNumber));
    cmd.Parameters.Add(new SqlParameter("@drctnmbr", _strDirectNumber));
    cmd.Parameters.Add(new SqlParameter("@lcalnmbr", _strLocalNumber));
    cmd.Parameters.Add(new SqlParameter("@faxnmbr", _strFaxNumber));
    cmd.Parameters.Add(new SqlParameter("@emailofc", _strEmailOfficial));
    cmd.Parameters.Add(new SqlParameter("@emailper", _strEmailPersonal));
    cmd.Parameters.Add(new SqlParameter("@schdcode", _strScheduleCode));
    cmd.Parameters.Add(new SqlParameter("@sssid", _strSssID));
    cmd.Parameters.Add(new SqlParameter("@philid", _strPhilHealthID));
    cmd.Parameters.Add(new SqlParameter("@taxid", _strTaxID));
    cmd.Parameters.Add(new SqlParameter("@hdmfid", _strHdmfID));
    cmd.Parameters.Add(new SqlParameter("@hmoid", _strHmoID));
    cmd.Parameters.Add(new SqlParameter("@bankacct", _strBankAccount));
    cmd.Parameters.Add(new SqlParameter("@divicode", _strDivisionCode));
    cmd.Parameters.Add(new SqlParameter("@grpcode", _strGroupCode));
    cmd.Parameters.Add(new SqlParameter("@deptcode", _strDepartmentCode));
    cmd.Parameters.Add(new SqlParameter("@rccode", _strRcCode));
    cmd.Parameters.Add(new SqlParameter("@jgcode", _strJGCode));
    cmd.Parameters.Add(new SqlParameter("@assgnmnt", _strAssignment));
    cmd.Parameters.Add(new SqlParameter("@datestrt", _dteDateStart));
    cmd.Parameters.Add(new SqlParameter("@datereg", _dteDateRegular));
    cmd.Parameters.Add(new SqlParameter("@dateend", _dteDateEnd));
    cmd.Parameters.Add(new SqlParameter("@updateby", _strUpdatedBy));
    cmd.Parameters.Add(new SqlParameter("@updateon", _dteUpdatedOn));
    cmd.Parameters.Add(new SqlParameter("@skillpri", _strSkillPrimary));
    cmd.Parameters.Add(new SqlParameter("@skillsec", _strSkillSecondary));
    cmd.Parameters.Add(new SqlParameter("@pstatus", _strStatus));
    cmd.Parameters.Add(new SqlParameter("@billable", _strIsBillable));
    cmd.Parameters.Add(new SqlParameter("@rsgncode", _strResignCode));
    cmd.Parameters.Add(new SqlParameter("@rsgnrmks", _strResignRemarks));
    cmd.Parameters.Add(new SqlParameter("@rsgndsrd", _strIsResignDesired));
    cmd.Parameters.Add(new SqlParameter("@rsrccode", _strRecruitmentSourceCode));
    cmd.Parameters.Add(new SqlParameter("@rsrcrmks", _strRecruitmentSourceRemarks));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public int Insert()
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand(); 
    cmd.CommandText = "INSERT INTO HR.Employees(username,empnum,lastname,firname,midname,midintl,nickname,brthdate,gender,etypcode,esttcode,comcode,position,cstatus,emailofc,schdcode,divicode,grpcode,deptcode,rccode,jgcode,assgnmnt,datestrt,datereg,updateby,updateon,pstatus,billable,rsrccode,rsrcrmks)"+
                                       " VALUES(@username,@empnum,@lastname,@firname,@midname,@midintl,@nickname,@brthdate,@gender,@etypcode,@esttcode,@comcode,@position,@cstatus,@emailofc,@schdcode,@divicode,@grpcode,@deptcode,@rccode,@jgcode,@assgnmnt,@datestrt,@datereg,@updateby,@updateon,@pstatus,@billable,@rsrccode,@rsrcrmks)";
    cmd.Parameters.Add(new SqlParameter("@username", _strUsername));
    cmd.Parameters.Add(new SqlParameter("@empnum", _strEmployeeNumber));
    cmd.Parameters.Add(new SqlParameter("@lastname", _strLastName));
    cmd.Parameters.Add(new SqlParameter("@firname", _strFirstName));
    cmd.Parameters.Add(new SqlParameter("@midname", _strMiddleName));
    cmd.Parameters.Add(new SqlParameter("@midintl", _strMiddleInitial));
    cmd.Parameters.Add(new SqlParameter("@nickname", _strNickName));
    cmd.Parameters.Add(new SqlParameter("@brthdate", _dteBirthDate));
    cmd.Parameters.Add(new SqlParameter("@gender", _strGender));
    cmd.Parameters.Add(new SqlParameter("@etypcode", _strEmploymentTypeCode));
    cmd.Parameters.Add(new SqlParameter("@esttcode", _strEmploymentStatusCode));
    cmd.Parameters.Add(new SqlParameter("@comcode", _strCompanyCode));
    cmd.Parameters.Add(new SqlParameter("@position", _strPosition));
    cmd.Parameters.Add(new SqlParameter("@cstatus", _strCivilStatus));
    cmd.Parameters.Add(new SqlParameter("@emailofc", _strEmailOfficial));
    cmd.Parameters.Add(new SqlParameter("@schdcode", _strScheduleCode));
    cmd.Parameters.Add(new SqlParameter("@divicode", _strDivisionCode));
    cmd.Parameters.Add(new SqlParameter("@grpcode", _strGroupCode));
    cmd.Parameters.Add(new SqlParameter("@deptcode", _strDepartmentCode));
    cmd.Parameters.Add(new SqlParameter("@rccode", _strRcCode));
    cmd.Parameters.Add(new SqlParameter("@jgcode", _strJGCode));
    cmd.Parameters.Add(new SqlParameter("@assgnmnt", _strAssignment));
    cmd.Parameters.Add(new SqlParameter("@datestrt", _dteDateStart));
    cmd.Parameters.Add(new SqlParameter("@datereg", _dteDateRegular));    
    cmd.Parameters.Add(new SqlParameter("@updateby", _strUpdatedBy));
    cmd.Parameters.Add(new SqlParameter("@updateon", _dteUpdatedOn));
    cmd.Parameters.Add(new SqlParameter("@pstatus", _strStatus));
    cmd.Parameters.Add(new SqlParameter("@billable", _strIsBillable));
    cmd.Parameters.Add(new SqlParameter("@rsrccode", _strRecruitmentSourceCode));
    cmd.Parameters.Add(new SqlParameter("@rsrcrmks", _strRecruitmentSourceRemarks));
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

  public void Dispose() { GC.SuppressFinalize(this); }

  //////////////////////////////////
  ///////// Static Members /////////
  //////////////////////////////////

  public static int ComputeAge(DateTime pBirthDate)
  {
   return Convert.ToInt32((DateTime.Now - pBirthDate).Days / 365.5);
  }

  public static DataTable DSGEmployeeList(string strWhere)
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add("EmployeeNumber");
   tblReturn.Columns.Add("Username");
   tblReturn.Columns.Add("Lastname");
   tblReturn.Columns.Add("Firstname");
   tblReturn.Columns.Add("JGCode");
   tblReturn.Columns.Add("EmployeeType");
   tblReturn.Columns.Add("EmploymentStatus");
   tblReturn.Columns.Add("Division");
   tblReturn.Columns.Add("Group");
   tblReturn.Columns.Add("Department");

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT empnum, username, firname, lastname, jgcode, (SELECT etypname FROM HR.EmployeeType WHERE etypcode=HR.Employees.etypcode) AS EmployeeType, (SELECT empstat FROM HR.EmploymentStatus WHERE esttcode=HR.Employees.esttcode) AS EmploymentStatus, (SELECT division FROM HR.Division WHERE divicode=HR.Employees.divicode) AS DivisionName, (SELECT grpname FROM HR.Groups WHERE grpcode=HR.Employees.grpcode) AS GroupName, (SELECT deptname FROM HR.Department WHERE deptcode=HR.Employees.deptcode) AS DepartmentName FROM HR.Employees " + strWhere + "ORDER BY lastname";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     DataRow drwN = tblReturn.NewRow();
     drwN["EmployeeNumber"] = dr["empnum"].ToString();
     drwN["Username"] = dr["username"].ToString();
     drwN["Firstname"] = dr["firname"].ToString();
     drwN["Lastname"] = dr["lastname"].ToString();
     drwN["JGCode"] = dr["jgcode"].ToString();
     drwN["EmployeeType"] = dr["EmployeeType"].ToString();
     drwN["EmploymentStatus"] = dr["EmploymentStatus"].ToString();
     drwN["Division"] = dr["DivisionName"].ToString();
     drwN["Group"] = dr["GroupName"].ToString();
     drwN["Department"] = dr["DepartmentName"].ToString();
     tblReturn.Rows.Add(drwN);
    }
    dr.Close();
   }
   return tblReturn;
  }

  public static DataTable DSGEmployeeScheduleList(EmployeeAccountType pEAT)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    if (pEAT == EmployeeAccountType.All)
     cmd.CommandText = "SELECT username,empnum,lastname + ', ' + firname AS pname,schdcode FROM HR.Employees ORDER BY lastname";
    else if (pEAT == EmployeeAccountType.Active)
     cmd.CommandText = "SELECT username,empnum,lastname + ', ' + firname AS pname,schdcode FROM HR.Employees WHERE pstatus='1' ORDER BY lastname";
    else if (pEAT == EmployeeAccountType.NonActive)
     cmd.CommandText = "SELECT username,empnum,lastname + ', ' + firname AS pname,schdcode FROM HR.Employees WHERE pstatus='0' ORDER BY lastname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSLFormTimesheetEmployeeSelector(string pLastName)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username,lastname,firname FROM HR.Employees WHERE lastname LIKE '" + pLastName + "%' ORDER BY lastname,firname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable GetDSGTimesheetProcess(string pClusterCode, string pLastName)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT lastname + ' ' + firname AS pname, empnum, username, (SELECT empstat FROM HR.EmploymentStatus WHERE esttcode=HR.Employees.esttcode) AS pEmploymentStatus, (SELECT deptname FROM HR.Department WHERE deptcode=HR.Employees.deptcode) AS pDepartmentName, jgcode FROM HR.Employees WHERE username IN (SELECT username FROM HR.EmployeeCluster WHERE cluscode=@cluscode) AND lastname LIKE @lastname + '%' ORDER BY lastname";
    cmd.Parameters.Add(new SqlParameter("@cluscode", pClusterCode));
    cmd.Parameters.Add(new SqlParameter("@lastname", pLastName));
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSLActive()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username AS pvalue, lastname + ', ' + firname AS ptext FROM HR.Employees WHERE pstatus='1' ORDER BY lastname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSLActiveAll()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "-- ALL --";
   tblReturn.Rows.Add(drw);

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username AS pvalue, lastname + ', ' + firname AS ptext FROM HR.Employees WHERE pstatus='1' ORDER BY lastname";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     drw = tblReturn.NewRow();
     drw["pvalue"] = dr["pvalue"].ToString();
     drw["ptext"] = dr["ptext"].ToString();
     tblReturn.Rows.Add(drw);
    }
    dr.Close();
   }

   return tblReturn;
  }

  public static DataTable DSLAll()
  {
   DataTable tblReturn = new DataTable();

   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username, lastname + ', ' + firname AS pname FROM HR.Employees ORDER BY lastname";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    while (dr.Read())
    {
     drw = tblReturn.NewRow();
     drw["pvalue"] = dr["username"].ToString();
     drw["ptext"] = dr["pname"].ToString();
     tblReturn.Rows.Add(drw);
    }
    dr.Close();
   }

   return tblReturn;
  }

  public static DataTable DSLCivilStatus()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "S";
   drw["ptext"] = "Single";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "M";
   drw["ptext"] = "Married";
   tblReturn.Rows.Add(drw);

   return tblReturn;
  }

  public static DataTable DSLEmployeeList(string pLastName)
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username AS pvalue, lastname + ', ' + firname AS ptext FROM HR.Employees WHERE lastname LIKE '" + pLastName + "%' ORDER BY lastname,firname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSLGender()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "M";
   drw["ptext"] = "Male";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "F";
   drw["ptext"] = "Female";
   tblReturn.Rows.Add(drw);

   return tblReturn;
  }

  public static DataTable DSLGenderAll()
  {
   DataTable tblReturn = new DataTable();
   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "M";
   drw["ptext"] = "Male";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "F";
   drw["ptext"] = "Female";
   tblReturn.Rows.Add(drw);

   return tblReturn;
  }

  public static DataTable DSLProcessTimesheet()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username AS pvalue, lastname + ', ' + firname AS ptext FROM HR.Employees WHERE pstatus='1' ORDER BY lastname";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static DataTable DSLStatusAll()
  {
   DataTable tblReturn = new DataTable();

   tblReturn.Columns.Add(new DataColumn("pvalue"));
   tblReturn.Columns.Add(new DataColumn("ptext"));
   DataRow drw = tblReturn.NewRow();
   drw["pvalue"] = "ALL";
   drw["ptext"] = "All";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "0";
   drw["ptext"] = "Disabled";
   tblReturn.Rows.Add(drw);

   drw = tblReturn.NewRow();
   drw["pvalue"] = "1";
   drw["ptext"] = "Active";
   tblReturn.Rows.Add(drw);
   return tblReturn;
  }

  public static DataTable DSLUsername()
  {
   DataTable tblReturn = new DataTable();
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username AS pvalue, username AS ptext FROM HR.Employees ORDER BY username";
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    da.Fill(tblReturn);
   }
   return tblReturn;
  }

  public static void EnableAccount(string pUsername)
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Employees SET pstatus='1' WHERE username='" + pUsername + "'";
    cn.Open();
    cmd.ExecuteNonQuery();
   }
  }

  public static void DisableAccount(string pUsername)
  {
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Employees SET pstatus='0' WHERE username='" + pUsername + "'";
    cn.Open();
    cmd.ExecuteNonQuery();
   }
  }

  public static string GenerateEmployeeNumber()
  {
   string strReturn = "";
   bool blnIsRecordExist = true;
   Random rnd = new Random();
   DataTable tblEmployeeNumberArchive = new DataTable();
   DataTable tblEmployeeNumberCurrent = new DataTable();

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
                //SqlCommand cmd = cn.CreateCommand();
                //cmd.CommandText = "SELECT empnum FROM HR.Employees";
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //da.Fill(tblEmployeeNumberCurrent);

                //cmd.CommandText = "SELECT empnum FROM HR.EmployeeNumber";
                //da.SelectCommand = cmd;
                //da.Fill(tblEmployeeNumberArchive);

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT pvalue+1 as EMPLOYEE_ID FROM Speedo.Keys WHERE pkey = 'empcode'";
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    strReturn = dr["EMPLOYEE_ID"].ToString();
                }
                dr.Close();
                cn.Close();
   }

       //while (blnIsRecordExist)
       //{
       //     blnIsRecordExist = false;
       //     strReturn = rnd.Next(99999).ToString("00000");
       //     foreach (DataRow drw in tblEmployeeNumberCurrent.Rows)
       //     {
       //      if (drw["empnum"].ToString() == strReturn)
       //      {
       //       blnIsRecordExist = true;
       //       break;
       //      }
       //     }
       //     foreach (DataRow drw in tblEmployeeNumberArchive.Rows)
       //     {
       //      if (drw["empnum"].ToString() == strReturn)
       //      {
       //       blnIsRecordExist = true;
       //       break;
       //      }
       //     }
       //}
       //if (blnIsRecordExist)
       // strReturn = "";

       return strReturn;
  }

  public static string GetDepartmentCode(string pUsername)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT deptcode FROM HR.Employees WHERE username='" + pUsername + "'";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static string GetDivisionCode(string pUsername)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT divicode FROM HR.Employees WHERE username='" + pUsername + "'";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static string GetEmployeeNumber(string pUsername)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT empnum FROM HR.Employees WHERE username='" + pUsername + "'";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static string GetName(string pUsername)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT firname + ' ' + midintl + '. ' + lastname FROM HR.Employees WHERE username='" + pUsername + "'";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static string GetName(string pUsername, EmployeeNameFormat pNameFormat)
  {

       string strReturn = "";
       string strNameFormat = "";

       if (pNameFormat == EmployeeNameFormat.FirstLast)
        strNameFormat = "firname + ' ' + midintl + '. ' + lastname";
       else if (pNameFormat == EmployeeNameFormat.LastFirst)
        strNameFormat = "lastname + ', ' + firname + ' ' + midintl + '.'";

       using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
       {
        SqlCommand cmd = cn.CreateCommand();
        cmd.CommandText = "SELECT " + strNameFormat + " FROM HR.Employees WHERE username=@username";
        cmd.Parameters.Add(new SqlParameter("@username", pUsername));
        cn.Open();
        try { strReturn = cmd.ExecuteScalar().ToString(); }
        catch { }
       }
       return strReturn;

  }

  public static string GetName(string pKey, EmployeeWhereParameter pWhere)
  {
   string strReturn = "";
   string strWhere = "";

   if (pWhere == EmployeeWhereParameter.Username)
    strWhere = "username";
   else if (pWhere == EmployeeWhereParameter.EmployeeNumber)
    strWhere = "empnum";

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT firname + ' ' + midintl + '. ' + lastname FROM HR.Employees WHERE " + strWhere + "='" + pKey + "'";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static string GetName(string pKey, EmployeeNameFormat pNameFormat, EmployeeWhereParameter pWhere)
  {
   string strReturn = "";
   string strNameFormat = "";
   string strWhere = "";

   if (pNameFormat == EmployeeNameFormat.FirstLast)
    strNameFormat = "firname + ' ' + midintl + '. ' + lastname";
   else if (pNameFormat == EmployeeNameFormat.LastFirst)
    strNameFormat = "lastname + ', ' + firname + ' ' + midintl + '.'";

   if (pWhere == EmployeeWhereParameter.Username)
    strNameFormat = "username";
   else if (pWhere == EmployeeWhereParameter.EmployeeNumber)
    strNameFormat = "empnum";

   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT " + strNameFormat + " FROM HR.Employees WHERE " + strWhere + "='" + pKey + "'";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static string GetRCCode(string pUsername)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT rccode FROM HR.Employees WHERE username='" + pUsername + "'";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static string GetRCName(string pUsername)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT rcname FROM HR.Rc WHERE rccode IN (SELECT rccode FROM HR.Employees WHERE username='" + pUsername + "')";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static string GetScheduleCurrent(string pUsername, DateTime pFocusDate)
  {
   string strReturn = clsEmployeeSchedule.GetScheduleCode(pUsername, pFocusDate);
   if (strReturn == "")
    strReturn = GetScheduleDefault(pUsername);
   return strReturn;
  }

  public static string GetScheduleDefault(string pUsername)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT schdcode FROM HR.Employees WHERE username='" + pUsername + "'";
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static string GetUsername(string pSearchKey, EmployeeWhereParameter pWPT)
  {
   string strReturn = "";
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    switch (pWPT)
    {
     case EmployeeWhereParameter.EmployeeNumber:
      cmd.CommandText = "SELECT username FROM HR.Employees WHERE empnum='" + pSearchKey + "'";
      break;
     case EmployeeWhereParameter.Lastname:
      cmd.CommandText = "SELECT TOP 1 username FROM HR.Employees WHERE lastname LIKE '" + pSearchKey + "%' ORDER BY lastname";
      break;
    }
    cn.Open();
    try { strReturn = cmd.ExecuteScalar().ToString(); }
    catch { }
   }
   return strReturn;
  }

  public static bool IsEmployeeExist(string pUsername)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username FROM HR.Employees WHERE username='" + pUsername + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
   return blnReturn;
  }

  public static bool IsEmployeeExistByNumber(string pEmployeeNumber)
  {
   bool blnReturn = false;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT username FROM HR.Employees WHERE empnum='" + pEmployeeNumber + "'";
    cn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    blnReturn = dr.Read();
    dr.Close();
   }
   return blnReturn;
  }

  public static int SaveImage(string pUsername, string pFilename)
  {
   int intReturn = 0;

   byte[] bytImage = clsImage.ReadFile(pFilename);
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Employees SET pimage=@pimage WHERE username='" + pUsername + "'";
    cmd.Parameters.Add("@pimage", SqlDbType.Image);
    cmd.Parameters["@pimage"].Value = (object)bytImage;
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   
   }

   return intReturn;
  }

  public static int UpdateDefaultSchedule(string pUsername, string pScheduleCode)
  {
   int intReturn = 0;
   using (SqlConnection cn = new SqlConnection(HRMSCore.HrmsConnectionString))
   {
    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "UPDATE HR.Employees SET schdcode='" + pScheduleCode + "' WHERE username='" + pUsername + "'";
    cn.Open();
    intReturn = cmd.ExecuteNonQuery();
   }
   return intReturn;
  }

 }
}