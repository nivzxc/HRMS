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
 public partial class frmEmployeeDetails : Form
 {
    
  private string _strUsername;
  private frmEmployeeList _frmEmployeeList;
  private frmTimesheetProcess _frmTimesheetProcess;
  private FormCallers _FormCaller;

  private mdiIpanema _frmMDICaller;
  public mdiIpanema FormMDICaller { get { return _frmMDICaller; } set { _frmMDICaller = value; } }

  public frmEmployeeDetails() { InitializeComponent(); }

  public string Username { set { _strUsername = value; } }
  public FormCallers FormCaller { set { _FormCaller = value; } }
  public frmEmployeeList FormEmployeeList { set { _frmEmployeeList = value; } get { return _frmEmployeeList; } }
  public frmTimesheetProcess FormTimesheetProcess { set { _frmTimesheetProcess = value; } get { return _frmTimesheetProcess; } }

  
  ///////////////////////////
  ///////// Methods /////////
  ///////////////////////////
  
  private void LoadDetails()
  {
   txtUsername.Text = _strUsername;
   using (Employee employee = new Employee())
   {
    employee.Username = _strUsername;
    employee.Fill();
    //////// General Tab ////////
    picEmployee.Image = employee.Image;
    txtEmpNum.Text = employee.EmployeeNumber;
    cmbTitle.SelectedValue = (employee.Title == "" ? "NA" : employee.Title);
    txtFirstName.Text = employee.FirstName;
    txtLastName.Text = employee.LastName;
    txtMiddleName.Text = employee.MiddleName;
    txtMiddleInitial.Text = employee.MiddleInitial;
    cmbSuffix.SelectedValue = (employee.Suffix == "" ? "NA" : employee.Suffix);
    cmbCompany.SelectedValue = employee.CompanyCode;
    txtRemarks.Text = employee.Remarks;
    txtUpdatedBy.Text = employee.UpdatedBy;
    txtUpdatedOn.Text = employee.UpdatedOn.ToString("MMMM dd, yyyy hh:mm tt");
    chkEnabled.Checked = (employee.Status == "1");
    chkBillable.Checked = (employee.IsBillable == "1");

    //////// Personal Tab ////////
    txtNickName.Text = employee.NickName;
    cmbGender.SelectedValue = employee.Gender;
    cmbCivilStatus.SelectedValue = employee.CivilStatus;
    dtpBirthDate.Value = employee.BirthDate;
    txtAge.Text = Employee.ComputeAge(employee.BirthDate).ToString();
    txtBirthPlace.Text = employee.BirthPlace;
    txtLanguage.Text = employee.Language;
    txtCitizenship.Text = employee.Citizenship;
    txtHobbies.Text = employee.Hobbies;
    txtHeight.Text = employee.Height;
    txtWeight.Text = employee.Weight;
    txtBloodType.Text = employee.BloodType;
    txtFatherName.Text = employee.FatherName;
    dtpFatherBDate.Value = employee.FatherBirthDate;
    txtFatherAge.Text = Employee.ComputeAge(employee.FatherBirthDate).ToString();
    txtMotherName.Text = employee.MotherName;
    dtpMotherBDate.Value = employee.MotherBirthDate;
    txtMotherAge.Text = Employee.ComputeAge(employee.MotherBirthDate).ToString();
    txtSpouseName.Text = employee.SpouseName;
    dtpSpouseBDate.Value = employee.SpouseBirthDate;
    txtSpouseAge.Text = (employee.SpouseBirthDate == clsDateTime.SystemMinDate ? "" : Employee.ComputeAge(employee.SpouseBirthDate).ToString());

    //////// Personal Tab ////////
    txtPermanentAddress.Text = employee.PermanentAddress;
    txtPermanentCity.Text = employee.PermanentCity;
    txtPermanentPhone.Text = employee.PermanentPhoneNumber;
    txtCurrentAddress.Text = employee.CurrentAddress;
    txtCurrentCity.Text = employee.CurrentCity;
    txtCurrentPhone.Text = employee.CurrentPhoneNumber;
    txtPrimaryMobile.Text = employee.PrimaryMobileNumber;
    txtAlternativeMobile.Text = employee.AlternativeMobileNumber;
    txtEmailOfficial.Text = employee.EmailOfficial;
    txtEmailPersonal.Text = employee.EmailPersonal;
    txtDirectLine.Text = employee.DirectNumber;
    txtLocal.Text = employee.LocalNumber;
    txtFax.Text = employee.FaxNumber;
    txtEmerName.Text = employee.EmergencyPerson;
    txtEmerRelation.Text = employee.EmergencyRelation;
    txtEmerAddress.Text = employee.EmergencyAddress;
    txtEmerPhone.Text = employee.EmergencyPhoneNumber;
    txtEmerCell.Text = employee.EmergencyCellNumber;

    //////// Schedule Tab ////////
    txtDefaultSched.Text = employee.ScheduleCode;
    LoadCurrentSchedule();

    //////// ID Nos ////////
    txtSSS.Text = employee.SssID;
    txtPhilHealth.Text = employee.PhilHealthID;
    txtTaxID.Text = employee.TaxID;
    txtHDMF.Text = employee.HdmfID;
    txtBankAccount.Text = employee.BankAccount;
    txtHMO.Text = employee.HmoID;

    //////// Employment ////////
    cmbDivision.SelectedValue = employee.DivisionCode;
    cmbGroup.SelectedValue = employee.GroupCode;
    cmbDepartment.SelectedValue = employee.DepartmentCode;
    cmbRC.SelectedValue = employee.RcCode;
    txtPosition.Text = employee.Position;
    cmbJGCode.SelectedValue = employee.JGCode;
    txtAssignment.Text = employee.Assignment;
    cmbEmployeeType.SelectedValue = employee.EmploymentTypeCode;
    cmbEmploymentStatus.SelectedValue = employee.EmploymentStatusCode;
    dtpDateStart.Checked = (employee.DateStart == clsDateTime.SystemMinDate ? false : true);
    dtpDateStart.Value = employee.DateStart;
    dtpDateReg.Checked = (employee.DateRegular == clsDateTime.SystemMinDate ? false : true);
    dtpDateReg.Value = employee.DateRegular;
    try { cmbRecruitmentSource.SelectedValue = employee.RecruitmentSourceCode; } catch { }
    txtRecruitmentRemarks.Text = employee.RecruitmentSourceRemarks;
    dtpDateEnd.Checked = (employee.DateEnd == clsDateTime.SystemMinDate ? false : true);
    dtpDateEnd.Value = employee.DateEnd;
    chkResignationDesired.Checked = (employee.IsResignDesired == "1");
    try { cmbResignationReason.SelectedValue = employee.ResignCode; } catch { }
    txtRemarks.Text = employee.ResignRemarks;

    //////// Skills and Qualifications ////////
    txtSkillPrimary.Text = employee.SkillPrimary;
    txtSkillSecondary.Text = employee.SkillSecondary;

    this.Text = "Employee Details (" + employee.EmployeeNumber + ") " + employee.LastName + ", " + employee.FirstName;
   }
  }

  ////////////////////////////
  ///////// Schedule /////////
  ////////////////////////////

  public void SetDefaultSchedule(string pScheduleCode)
  {
   txtDefaultSched.Text = pScheduleCode;
  }

  public void LoadCurrentSchedule()
  {
   txtCScheduleCode.Text = Employee.GetScheduleCurrent(_strUsername, DateTime.Now);
   LoadCurrentScheduleDetails(txtCScheduleCode.Text);
   LoadScheduleHistory();
  }

  public void LoadScheduleHistory()
  {
   DataTable tblHistory = clsEmployeeSchedule.GetDataTable(_strUsername);
   lvScheduleHistory.Items.Clear();
   foreach (DataRow drw in tblHistory.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Tag = drw["empschd"].ToString();
    lvi.Text = clsValidator.CheckDate(drw["effcfrom"].ToString()).ToString("MMM dd, yyyy");
    lvi.SubItems.Add(clsValidator.CheckDate(drw["effcto"].ToString()).ToString("MMM dd, yyyy"));
    lvi.SubItems.Add(drw["preason"].ToString());
    lvi.SubItems.Add(drw["premarks"].ToString());
    lvScheduleHistory.Items.Add(lvi);
   }
  }

  private void LoadCurrentScheduleDetails(string pScheduleCode)
  {
   using (clsSchedule schedule = new clsSchedule(pScheduleCode))
   {
    schedule.Fill();
    txtMonShift.Text = schedule.MondayShift;
    txtTueShift.Text = schedule.TuesdayShift;
    txtWedShift.Text = schedule.WednesdayShift;
    txtThuShift.Text = schedule.ThursdayShift;
    txtFriShift.Text = schedule.FridayShift;
    txtSatShift.Text = schedule.SaturdayShift;
    txtSunShift.Text = schedule.SundayShift;
   }
   Color clr = new Color();
   clsShift shift;

   #region " Monday "
   shift = new clsShift();
   shift.ShiftCode = txtMonShift.Text;
   shift.Fill();
   txtMonBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtMonBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtMonIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtMonHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtMonOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtMonLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtMonUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtMonShift.BackColor = clr;
   txtMonIn.BackColor = clr;
   txtMonHalf.BackColor = clr;
   txtMonOut.BackColor = clr;
   txtMonBS.BackColor = clr;
   txtMonBE.BackColor = clr;
   txtMonLate.BackColor = clr;
   txtMonUT.BackColor = clr;
   #endregion
   #region " Tuesday "
   shift = new clsShift();
   shift.ShiftCode = txtTueShift.Text;
   shift.Fill();
   txtTueBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtTueBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtTueIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtTueHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtTueOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtTueLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtTueUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtTueShift.BackColor = clr;
   txtTueIn.BackColor = clr;
   txtTueHalf.BackColor = clr;
   txtTueOut.BackColor = clr;
   txtTueBS.BackColor = clr;
   txtTueBE.BackColor = clr;
   txtTueLate.BackColor = clr;
   txtTueUT.BackColor = clr;
   #endregion
   #region " Wednesday "
   shift = new clsShift();
   shift.ShiftCode = txtWedShift.Text;
   shift.Fill();
   txtWedBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtWedBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtWedIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtWedHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtWedOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtWedLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtWedUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtWedShift.BackColor = clr;
   txtWedIn.BackColor = clr;
   txtWedHalf.BackColor = clr;
   txtWedOut.BackColor = clr;
   txtWedBS.BackColor = clr;
   txtWedBE.BackColor = clr;
   txtWedLate.BackColor = clr;
   txtWedUT.BackColor = clr;
   #endregion
   #region " Thursday "
   shift = new clsShift();
   shift.ShiftCode = txtThuShift.Text;
   shift.Fill();
   txtThuBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtThuBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtThuIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtThuHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtThuOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtThuLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtThuUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtThuShift.BackColor = clr;
   txtThuIn.BackColor = clr;
   txtThuHalf.BackColor = clr;
   txtThuOut.BackColor = clr;
   txtThuBS.BackColor = clr;
   txtThuBE.BackColor = clr;
   txtThuLate.BackColor = clr;
   txtThuUT.BackColor = clr;
   #endregion
   #region " Friday "
   shift = new clsShift();
   shift.ShiftCode = txtFriShift.Text;
   shift.Fill();
   txtFriBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtFriBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtFriIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtFriHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtFriOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtFriLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtFriUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtFriShift.BackColor = clr;
   txtFriIn.BackColor = clr;
   txtFriHalf.BackColor = clr;
   txtFriOut.BackColor = clr;
   txtFriBS.BackColor = clr;
   txtFriBE.BackColor = clr;
   txtFriLate.BackColor = clr;
   txtFriUT.BackColor = clr;
   #endregion
   #region " Saturday "
   shift = new clsShift();
   shift.ShiftCode = txtSatShift.Text;
   shift.Fill();
   txtSatBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtSatBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtSatIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtSatHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtSatOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtSatLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtSatUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtSatShift.BackColor = clr;
   txtSatIn.BackColor = clr;
   txtSatHalf.BackColor = clr;
   txtSatOut.BackColor = clr;
   txtSatBS.BackColor = clr;
   txtSatBE.BackColor = clr;
   txtSatLate.BackColor = clr;
   txtSatUT.BackColor = clr;
   #endregion
   #region " Sunday "
   shift = new clsShift();
   shift.ShiftCode = txtSunShift.Text;
   shift.Fill();
   txtSunBS.Text = shift.BreakTimeStart.ToString("hh:mm tt");
   txtSunBE.Text = shift.BreakTimeEnd.ToString("hh:mm tt");
   if (shift.ShiftModeCode == "W")
   {
    txtSunIn.Text = shift.TimeStart.ToString("hh:mm tt");
    txtSunHalf.Text = shift.TimeHalf.ToString("hh:mm tt");
    txtSunOut.Text = shift.TimeEnd.ToString("hh:mm tt");
    txtSunLate.Text = shift.LateTime.ToString("hh:mm tt");
    txtSunUT.Text = shift.UnderTime.ToString("hh:mm tt");
   }
   clr = (shift.ShiftModeCode == "W" ? Color.Honeydew : Color.MistyRose);
   txtSunShift.BackColor = clr;
   txtSunIn.BackColor = clr;
   txtSunHalf.BackColor = clr;
   txtSunOut.BackColor = clr;
   txtSunBS.BackColor = clr;
   txtSunBE.BackColor = clr;
   txtSunLate.BackColor = clr;
   txtSunUT.BackColor = clr;
   #endregion
  }

  public void BindEmployeeTitle()
  {
   cmbTitle.DataSource = clsEmployeeTitle.GetDdlSource();
   cmbTitle.DisplayMember = "ptext";
   cmbTitle.ValueMember = "pvalue";
  }

  public void BindEmployeeType()
  {
   cmbEmployeeType.DataSource = clsEmployeeType.DSLEmployeeType();
   cmbEmployeeType.DisplayMember = "ptext";
   cmbEmployeeType.ValueMember = "pvalue";
  }

  public void BindEmployeeSuffix()
  {
   cmbSuffix.DataSource = clsEmployeeSuffix.GetDdlSource();
   cmbSuffix.DisplayMember = "ptext";
   cmbSuffix.ValueMember = "pvalue";
  }

  public void BindCompanyList()
  {
   cmbCompany.DataSource = clsCompany.GetDSL();
   cmbCompany.DisplayMember = "ptext";
   cmbCompany.ValueMember = "pvalue";
  }

  public void LoadDependentsList()
  {
   lvDependents.Items.Clear();
   DataTable tblDependents = clsEmployeeDependent.GetDataTable(_strUsername);
   foreach (DataRow drow in tblDependents.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drow["pname"].ToString();
    lvi.Tag = drow["dpndcode"].ToString();
    lvi.SubItems.Add(DateTime.Parse(drow["brthdate"].ToString()).ToString("MMMM dd, yyyy"));
    lvi.SubItems.Add(Employee.ComputeAge(Convert.ToDateTime(drow["brthdate"].ToString())).ToString());
    lvi.SubItems.Add(drow["relation"].ToString());
    lvDependents.Items.Add(lvi);
   }

   if (lvDependents.Items.Count > 0)
    lvDependents.Items[0].Selected = true;
  }

  public void LoadChildrenList()
  {
   lvwChildren.Items.Clear();
   DataTable tblChildren = clsEmployeeChildren.GetDataTable(_strUsername);
   foreach (DataRow drow in tblChildren.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drow["pname"].ToString();
    lvi.Tag = drow["chldcode"].ToString();
    lvi.SubItems.Add(clsValidator.CheckDate(drow["brthdate"].ToString()).ToString("MMMM dd, yyyy"));
    lvi.SubItems.Add(Employee.ComputeAge(clsValidator.CheckDate(drow["brthdate"].ToString())).ToString());
    lvwChildren.Items.Add(lvi);
   }

   if (lvwChildren.Items.Count > 0)
    lvwChildren.Items[0].Selected = true;
  }

  private void BindGender()
  {
   cmbGender.DataSource = Employee.DSLGender();
   cmbGender.ValueMember = "pvalue";
   cmbGender.DisplayMember = "ptext";
  }

  private void BindCivilStatus()
  {
   cmbCivilStatus.DataSource = Employee.DSLCivilStatus();
   cmbCivilStatus.ValueMember = "pvalue";
   cmbCivilStatus.DisplayMember = "ptext";
  }

  public void BindEmploymentHistoryList()
  {
   dgEmploymentHistoryList.AutoGenerateColumns = false;
   dgEmploymentHistoryList.DataSource = clsEmployeeEmploymentHistory.DSGFormEmployeeDetailsList(_strUsername);
   dgEmploymentHistoryList.Columns[0].DataPropertyName = "EmhsCode";
   dgEmploymentHistoryList.Columns[1].DataPropertyName = "InclusiveDates";
   dgEmploymentHistoryList.Columns[2].DataPropertyName = "Company";
   dgEmploymentHistoryList.Columns[3].DataPropertyName = "Position";
   dgEmploymentHistoryList.Columns[4].DataPropertyName = "AppointmentStatus";
  }

  //////////////////////////////
  ///////// Employment /////////
  //////////////////////////////

  private void BindJobGradeList()
  {
   cmbJGCode.DataSource = JobGrade.DSLJGCode();
   cmbJGCode.DisplayMember = "ptext";
   cmbJGCode.ValueMember = "pvalue";
  }

  private void BindDivisionList()
  {
   cmbDivision.DataSource = Division.GetDSL();
   cmbDivision.DisplayMember = "ptext";
   cmbDivision.ValueMember = "pvalue";
  }

  private void BindGroupList()
  {
   cmbGroup.DataSource = Group.GetDSL();
   cmbGroup.DisplayMember = "ptext";
   cmbGroup.ValueMember = "pvalue";
  }

  private void BindDepartmentList()
  {
   cmbDepartment.DataSource = Department.GetDSL();
   cmbDepartment.DisplayMember = "ptext";
   cmbDepartment.ValueMember = "pvalue";
  }

  private void BindRcList()
  {
   cmbRC.DataSource = clsRC.GetDdlDs();
   cmbRC.DisplayMember = "ptext";
   cmbRC.ValueMember = "pvalue";
  }

  public void BindEmploymentStatus()
  {
   cmbEmploymentStatus.DataSource = clsEmploymentStatus.DSLEmploymentStatus();
   cmbEmploymentStatus.ValueMember = "pvalue";
   cmbEmploymentStatus.DisplayMember = "ptext";
  }

  public void BindRecruitmentSource()
  {
   cmbRecruitmentSource.DataSource = clsRecruitmentSource.DSLRecruitmentSource();
   cmbRecruitmentSource.ValueMember = "pvalue";
   cmbRecruitmentSource.DisplayMember = "ptext";
  }

  public void BindResignationReason()
  {
   cmbResignationReason.DataSource = clsResignationReason.DSLResignationReason();
   cmbResignationReason.ValueMember = "pvalue";
   cmbResignationReason.DisplayMember = "ptext";
  }

  /////////////////////////////////////
  ///////// Employee Movement /////////
  /////////////////////////////////////

  public void BindMovementList()
  {
   dgMovementList.AutoGenerateColumns = false;
   dgMovementList.DataSource = clsEmployeeMovement.DSGFormEmployeeDetails(_strUsername);
   dgMovementList.Columns[0].DataPropertyName = "MovementCode";
   dgMovementList.Columns[1].DataPropertyName = "DateFrom";
   dgMovementList.Columns[2].DataPropertyName = "DateTo";
   dgMovementList.Columns[3].DataPropertyName = "Department";
   dgMovementList.Columns[4].DataPropertyName = "JGCode";
   dgMovementList.Columns[5].DataPropertyName = "Position";
  }

  /////////////////////////////////////////////////////
  ///////// Education Background and Training /////////
  /////////////////////////////////////////////////////

  public void LoadEducationList()
  {
   lvwEducation.Items.Clear();
   DataTable tblEducation = clsEmployeeEducation.GetDataTable(_strUsername);
   foreach (DataRow drow in tblEducation.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = EducationLevel.GetDetails(drow["educlvl"].ToString());
    lvi.Tag = drow["educcode"].ToString();
    lvi.SubItems.Add((drow["complete"].ToString() == "1" ? "Yes" : "No"));
    lvi.SubItems.Add(drow["course"].ToString());
    lvi.SubItems.Add(drow["schlname"].ToString());
    lvi.SubItems.Add(drow["incldate"].ToString());
    lvi.SubItems.Add(drow["recogntn"].ToString());
    lvwEducation.Items.Add(lvi);
   }

   if (lvwEducation.Items.Count > 0)
    lvwEducation.Items[0].Selected = true;
  }

  public void LoadTrainingList()
  {
   lvwTraining.Items.Clear();
   DataTable tblTraining = clsEmployeeTraining.GetDataTable(_strUsername);
   foreach (DataRow drow in tblTraining.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = clsValidator.CheckDate(drow["traidate"].ToString()).ToString("MMMM dd, yyyy");
    lvi.Tag = drow["traicode"].ToString();
    lvi.SubItems.Add(drow["training"].ToString());
    lvi.SubItems.Add(drow["details"].ToString());
    lvi.SubItems.Add(drow["sponsor"].ToString());
    lvwTraining.Items.Add(lvi);
   }

   if (lvwTraining.Items.Count > 0)
    lvwTraining.Items[0].Selected = true;
  }

  ///////////////////////////////////////////////////
  ///////// Qualifications and Affiliations /////////
  ///////////////////////////////////////////////////

  public void LoadQualificationList()
  {
   lvwQualification.Items.Clear();
   DataTable tblQualification = clsEmployeeQualification.GetDataTable(_strUsername);
   foreach (DataRow drow in tblQualification.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drow["incldate"].ToString();
    lvi.Tag = drow["qualcode"].ToString();
    lvi.SubItems.Add(drow["qualfctn"].ToString());
    lvwQualification.Items.Add(lvi);
   }

   if (lvwQualification.Items.Count > 0)
    lvwQualification.Items[0].Selected = true;
  }

  public void LoadAffiliationList()
  {
   lvwAffiliation.Items.Clear();
   DataTable tblAffiliation = clsEmployeeAffiliation.GetDataTable(_strUsername);
   foreach (DataRow drow in tblAffiliation.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drow["organztn"].ToString();
    lvi.Tag = drow["afficode"].ToString();
    lvi.SubItems.Add(drow["position"].ToString());
    lvi.SubItems.Add(drow["incldate"].ToString());
    lvwAffiliation.Items.Add(lvi);
   }

   if (lvwAffiliation.Items.Count > 0)
    lvwAffiliation.Items[0].Selected = true;
  }

  /////////////////////////////////////////////
  ///////// Research and Achievements /////////
  /////////////////////////////////////////////

  public void LoadAchievementList()
  {
   lvwAchievement.Items.Clear();
   DataTable tblAchievement = clsEmployeeAchievement.GetDataTable(_strUsername);
   foreach (DataRow drow in tblAchievement.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drow["achivmnt"].ToString();
    lvi.Tag = drow["achvcode"].ToString();
    lvi.SubItems.Add(drow["achvdate"].ToString());
    lvi.SubItems.Add(drow["details"].ToString());
    lvwAchievement.Items.Add(lvi);
   }
   if (lvwAchievement.Items.Count > 0)
    lvwAchievement.Items[0].Selected = true;
  }

  public void LoadResearchList()
  {
   lvwResearch.Items.Clear();
   DataTable tblResearch = clsEmployeeResearch.GetDataTable(_strUsername);
   foreach (DataRow drow in tblResearch.Rows)
   {
    ListViewItem lvi = new ListViewItem();
    lvi.Text = drow["title"].ToString();
    lvi.Tag = drow["resecode"].ToString();
    lvi.SubItems.Add(drow["datecomp"].ToString());
    lvi.SubItems.Add(drow["remarks"].ToString());
    lvwResearch.Items.Add(lvi);
   }
   if (lvwResearch.Items.Count > 0)
    lvwResearch.Items[0].Selected = true;
  }

  /////////////////////////////////////
  ///////// Leave Entitlement /////////
  /////////////////////////////////////


  public void LoadLeaveTypes()
  {
   lvLeaveTypes.Items.Clear();
   DataTable tblLeaveType = LeaveApplicationTypes.GetActiveLeaveTypes(_strUsername);
   foreach (DataRow drw in tblLeaveType.Rows)
   {
    ListViewItem lvi = new ListViewItem();

    lvi.Text = drw["ltdesc"].ToString();
    lvi.Tag = drw["leavtype"].ToString();
    lvi.SubItems.Add(clsValidator.ToYesNo(drw["withpay"].ToString()));
    lvi.SubItems.Add(clsValidator.ToYesNo(drw["hasbal"].ToString()));
    lvi.SubItems.Add(drw["maxbal"].ToString());
    lvLeaveTypes.Items.Add(lvi);
   }
   if (lvLeaveTypes.Items.Count > 0)
    lvLeaveTypes.Items[0].Selected = true;
  }

  public void LoadLeaveEntitlement()
  {
   lvEntitlement.Items.Clear();
   DataTable tblEntitlement = LeaveApplicationBalance.GetDataTableEntitlement(_strUsername, "1");
   foreach (DataRow drw in tblEntitlement.Rows)
   {
    ListViewItem lvi = new ListViewItem();

    lvi.Text = LeaveApplicationTypes.GetDescription(drw["leavtype"].ToString());
    lvi.Tag = drw["leavtype"].ToString();
    lvi.SubItems.Add(drw["pbalance"].ToString());
    lvi.SubItems.Add(drw["entitle"].ToString());
    lvi.SubItems.Add(LeaveApplicationTypes.GetWithPay(drw["leavtype"].ToString()));
    lvEntitlement.Items.Add(lvi);
   }
   if (lvEntitlement.Items.Count > 0)
    lvEntitlement.Items[0].Selected = true;
  }

  //////////////////////////////////
  ///////// Helper Methods /////////
  //////////////////////////////////

  private string GetName()
  {
   return txtFirstName.Text + " " + txtLastName.Text;
  }

  private bool IsCorrectData()
  {
   string strErrorMessage = "";

   if (txtLastName.Text == "")
    strErrorMessage = "Last name is required.";

   if (txtFirstName.Text == "")
    strErrorMessage = "\nFirst name is required.";

   if (txtMiddleName.Text == "")
    strErrorMessage = "\nMiddle name is required.";

   if (txtPosition.Text == "")
    strErrorMessage = "\nPosition is required.";

   if (strErrorMessage != "")
    MessageBox.Show(clsMessageBox.MessageBoxValidationError + strErrorMessage, clsMessageBox.MessageBoxText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

   return strErrorMessage == "";
  }


  ///////////////////////////////
  ///////// Form Events /////////
  ///////////////////////////////

  private void frmEmployeeDetails_Load(object sender, EventArgs e)
  {
      frmLeaveBalanceEdit xmdi = new frmLeaveBalanceEdit();
      xmdi.FormMdiCaller = _frmMDICaller;

   BindEmployeeTitle();
   BindEmployeeType();
   BindEmployeeSuffix();
   BindCompanyList();
   BindDivisionList();
   //BindGroupList();
   //BindDepartmentList();
   BindRcList();
   LoadDependentsList();
   LoadChildrenList();
   BindJobGradeList();
   BindGender();
   BindCivilStatus();
   BindEmploymentStatus();

   ////// Employment //////
   BindEmploymentHistoryList();
   BindRecruitmentSource();
   BindResignationReason();

   ////// Movement /////////
   BindMovementList();

   ////// Education and Training //////
   LoadEducationList();
   LoadTrainingList();

   ////// Qualifications and Affiliations //////
   LoadQualificationList();
   LoadAffiliationList();

   ////// Research and Achievements //////
   LoadResearchList();
   LoadAchievementList();

   ////// Leave Entitlement //////
   LoadLeaveTypes();
   LoadLeaveEntitlement();
   ////// Schedule //////

   LoadDetails();
  }

  private void btnTitle_Click(object sender, EventArgs e)
  {
   frmEmployeeTitleNew pForm = new frmEmployeeTitleNew(this);
   pForm.FormCaller = FormCallers.EmployeeDetails;
   pForm.ShowDialog();
  }

  private void btnAddSuffix_Click(object sender, EventArgs e)
  {
   frmEmployeeSuffixNew pForm = new frmEmployeeSuffixNew(this);
   pForm.FormCaller = FormCallers.EmployeeDetails;
   pForm.ShowDialog();
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
   Close();
  }


  ///////// Personal Tab Events /////////  

  private void btnDependentsAdd_Click(object sender, EventArgs e)
  {
   frmEmployeeDependentAdd pForm = new frmEmployeeDependentAdd(this);
   pForm.Username = _strUsername;
   pForm.EmployeeName = GetName();
   pForm.ShowDialog();
  }

  private void btnDependentRefresh_Click(object sender, EventArgs e)
  {
   LoadDependentsList();
  }

  private void btnDependentsRemove_Click(object sender, EventArgs e)
  {
   if (lvDependents.SelectedItems.Count != 0)
   {    
    string strSelectedName = lvDependents.SelectedItems[0].Text;
    if (MessageBox.Show("Are you sure to delete " + strSelectedName + " from the dependent list?", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     using (clsEmployeeDependent dependent = new clsEmployeeDependent())
     {
      dependent.DependentCode = lvDependents.SelectedItems[0].Tag.ToString();
      dependent.Delete();
     }
     LoadDependentsList();
    }
   }
  }

  private void lvDependents_KeyUp(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Delete)
    btnDependentsRemove_Click(null, null);
  }

  private void btnDependentEdit_Click(object sender, EventArgs e)
  {
   if (lvDependents.SelectedItems.Count > 0)
   {
    frmEmployeeDependentEdit pForm = new frmEmployeeDependentEdit(this);
    pForm.FormCaller = FormCallers.EmployeeDetails;
    pForm.Username = txtUsername.Text;
    pForm.EmployeeName = GetName();
    pForm.DependentCode = lvDependents.SelectedItems[0].Tag.ToString();
    pForm.ShowDialog();
   }
  }

  private void btnChildrenAdd_Click(object sender, EventArgs e)
  {
   frmEmployeeChildrenAdd pForm = new frmEmployeeChildrenAdd(this);
   pForm.Username = _strUsername;
   pForm.EmployeeName = GetName();
   pForm.ShowDialog();
  }

  private void btnChildrenRefresh_Click(object sender, EventArgs e)
  {
   LoadChildrenList();
  }

  private void btnChildrenDelete_Click(object sender, EventArgs e)
  {
   if (lvwChildren.SelectedItems.Count != 0)
   {
    string strSelectedName = lvwChildren.SelectedItems[0].Text;
    if (MessageBox.Show("Are you sure to delete " + strSelectedName + " from the children list?", clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsEmployeeChildren children = new clsEmployeeChildren();
     children.ChildCode = lvwChildren.SelectedItems[0].Tag.ToString();
     children.Delete();

     LoadChildrenList();
    }
   }
  }

  private void lvwChildren_KeyUp(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Delete)
    btnChildrenDelete_Click(null, null);

  }

  private void btnChildrenEdit_Click(object sender, EventArgs e)
  {
   if (lvwChildren.SelectedItems.Count > 0)
   {
    frmEmployeeChildrenEdit pForm = new frmEmployeeChildrenEdit(this);
    pForm.ChildCode = lvwChildren.SelectedItems[0].Tag.ToString();
    pForm.EmployeeName = GetName();
    pForm.ShowDialog();
   }
  }

  private void btnPictureBrowse_Click(object sender, EventArgs e)
  {
            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileInfo file = new System.IO.FileInfo(ofdPicture.FileName);
                Bitmap img = new Bitmap(ofdPicture.FileName);

                if (img.Width <= 200 && img.Height <= 200)
                {
                    picEmployee.ImageLocation = ofdPicture.FileName;
                }
                else { MessageBox.Show("Picture size is not 2x2 ","Size Error!",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
            

  }

  private void btnPictureSave_Click(object sender, EventArgs e)
  {

            if (ofdPicture.FileName != "")
            {                
                Employee.SaveImage(txtUsername.Text, ofdPicture.FileName);
                MessageBox.Show("Image has been uploaded successfully", "UPLOAD SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("No Image to be uploaded", "IMAGE UPLOAD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
  
  }

  ///////// Employement Tab /////////

  private void dgEmploymentHistoryList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgEmploymentHistoryList.SelectedRows.Count > 0)
   {
    frmEmployeeEmploymentHistoryEdit pForm = new frmEmployeeEmploymentHistoryEdit();
    pForm.FormEmployeeDetails = this;
    pForm.EmploymentHistoryCode = dgEmploymentHistoryList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.EmployeeName = GetName();
    pForm.ShowDialog();
   }
  }

  private void tbtnEHAdd_Click(object sender, EventArgs e)
  {
   frmEmployeeEmploymentHistoryAdd pForm = new frmEmployeeEmploymentHistoryAdd(this);
   pForm.EmployeeName = GetName();
   pForm.Username = _strUsername;
   pForm.ShowDialog();
  }

  private void tbtnEHEdit_Click(object sender, EventArgs e)
  {
   if (dgEmploymentHistoryList.SelectedRows.Count > 0)
   {
    frmEmployeeEmploymentHistoryEdit pForm = new frmEmployeeEmploymentHistoryEdit();
    pForm.FormEmployeeDetails = this;
    pForm.EmploymentHistoryCode = dgEmploymentHistoryList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.EmployeeName = GetName();
    pForm.ShowDialog();
   }
  }

  private void tbtnEHDelete_Click(object sender, EventArgs e)
  {
   if (dgEmploymentHistoryList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsEmployeeEmploymentHistory eeh = new clsEmployeeEmploymentHistory();
     eeh.EmploymentHistoryCode = dgEmploymentHistoryList.SelectedRows[0].Cells[0].Value.ToString();
     eeh.Delete();
     BindEmploymentHistoryList();
    }
   }
  }

  private void tbtnEHRefresh_Click(object sender, EventArgs e)
  {
   BindEmploymentHistoryList();
  }

  ///////// Movement Tab Events /////////

  private void btnMoveRefresh_Click(object sender, EventArgs e)
  {
   BindMovementList();
  }

  private void tbtnMovementAdd_Click(object sender, EventArgs e)
  {
   frmEmployeeMovementAdd pForm = new frmEmployeeMovementAdd(this);
   pForm.Username = _strUsername;
   pForm.EmployeeName = GetName();
   pForm.ShowDialog();
  }

  private void tbtnMovementEdit_Click(object sender, EventArgs e)
  {
   if (dgMovementList.SelectedRows.Count > 0)
   {
    frmEmployeeMovementEdit pForm = new frmEmployeeMovementEdit(this);
    pForm.MovementCode = dgMovementList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.EmployeeName = GetName();
    pForm.ShowDialog();
   }
  }

  private void dgMovementList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
   if (dgMovementList.SelectedRows.Count > 0)
   {
    frmEmployeeMovementEdit pForm = new frmEmployeeMovementEdit(this);
    pForm.MovementCode = dgMovementList.SelectedRows[0].Cells[0].Value.ToString();
    pForm.EmployeeName = GetName();
    pForm.ShowDialog();
   }
  }

  private void tbtnMovementDelete_Click(object sender, EventArgs e)
  {
   if (dgMovementList.SelectedRows.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsEmployeeMovement em = new clsEmployeeMovement();
     em.MovementCode = dgMovementList.SelectedRows[0].Cells[0].Value.ToString();
     em.Delete();
     BindMovementList();
    }
   }
  }

  private void tbtnMovementRefresh_Click(object sender, EventArgs e)
  {
   BindMovementList();
  }

  /////////////////////////////////////////////////////
  ///////// Education and Trainings Tab Event /////////
  /////////////////////////////////////////////////////

  private void btnEduAdd_Click(object sender, EventArgs e)
  {
   frmEmployeeEducationAdd pForm = new frmEmployeeEducationAdd(this);
   pForm.Username = _strUsername;
   pForm.EmployeeName = GetName();
   pForm.ShowDialog();
  }

  private void btnEduEdit_Click(object sender, EventArgs e)
  {
   if (lvwEducation.SelectedItems.Count > 0)
   {
    frmEmployeeEducationEdit pForm = new frmEmployeeEducationEdit(this);
    pForm.EducationCode = lvwEducation.SelectedItems[0].Tag.ToString();
    pForm.EmployeeName = GetName();
    pForm.ShowDialog();
   }
  }

  private void btnEduDelete_Click(object sender, EventArgs e)
  {
   if (lvwEducation.SelectedItems.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsEmployeeEducation ed = new clsEmployeeEducation(lvwEducation.SelectedItems[0].Tag.ToString());
     ed.Delete();

     LoadEducationList();
    }
   }
  }

  private void lvwEducation_KeyUp(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Delete)
    btnEduDelete_Click(null, null);
  }

  private void btnEduRefresh_Click(object sender, EventArgs e)
  {
   LoadEducationList();
  }

  private void btnTrainAdd_Click(object sender, EventArgs e)
  {
   frmEmployeeTrainingAdd pForm = new frmEmployeeTrainingAdd(this);
   pForm.Username = _strUsername;
   pForm.EmployeeName = GetName();
   pForm.ShowDialog();
  }

  private void btnTrainEdit_Click(object sender, EventArgs e)
  {
   if (lvwTraining.SelectedItems.Count > 0)
   {
    frmEmployeeTrainingEdit pForm = new frmEmployeeTrainingEdit(this);
    pForm.TrainingCode = lvwTraining.SelectedItems[0].Tag.ToString();
    pForm.EmployeeName = GetName();
    pForm.ShowDialog();
   }
  }

  private void btnTrainDelete_Click(object sender, EventArgs e)
  {
   if (lvwTraining.SelectedItems.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsEmployeeTraining et = new clsEmployeeTraining(lvwTraining.SelectedItems[0].Tag.ToString());
     et.Delete();
     LoadTrainingList();
    }
   }
  }

  private void lvwTraining_KeyUp(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Delete)
    btnTrainDelete_Click(null, null);
  }

  private void btnTrainRefresh_Click(object sender, EventArgs e)
  {
   LoadTrainingList();
  }

  ///////// Qualification and Affiliation Tab Event /////////

  private void btnQualAdd_Click(object sender, EventArgs e)
  {
   frmEmployeeQualificationAdd pForm = new frmEmployeeQualificationAdd(this);
   pForm.Username = _strUsername;
   pForm.EmployeeName = GetName();
   pForm.ShowDialog();
  }

  private void btnQualDelete_Click(object sender, EventArgs e)
  {
   if (lvwQualification.SelectedItems.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsEmployeeQualification eq = new clsEmployeeQualification(lvwQualification.SelectedItems[0].Tag.ToString());
     eq.Delete();

     LoadQualificationList();
    }
   }
  }

  private void btnQualRefresh_Click(object sender, EventArgs e)
  {
   LoadQualificationList();
  }

  private void btnQualEdit_Click(object sender, EventArgs e)
  {
   if (lvwQualification.SelectedItems.Count > 0)
   {
    frmEmployeeQualificationEdit pForm = new frmEmployeeQualificationEdit(this);
    pForm.QualificationCode = lvwQualification.SelectedItems[0].Tag.ToString();
    pForm.EmployeeName = GetName();
    pForm.ShowDialog();
   }
  }

  private void lvwQualification_KeyUp(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Delete)
   {
    if (lvwQualification.SelectedItems.Count > 0)
    {
     if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
     {
      clsEmployeeQualification eq = new clsEmployeeQualification(lvwQualification.SelectedItems[0].Tag.ToString());
      eq.Delete();

      LoadQualificationList();
     }
    }
   }
  }

  private void btnAffAdd_Click(object sender, EventArgs e)
  {
   frmEmployeeAffiliationAdd pForm = new frmEmployeeAffiliationAdd(this);
   pForm.Username = _strUsername;
   pForm.EmployeeName = GetName();
   pForm.ShowDialog();
  }

  private void btnAffEdit_Click(object sender, EventArgs e)
  {
   if (lvwAffiliation.SelectedItems.Count > 0)
   {
    frmEmployeeAffiliationEdit pForm = new frmEmployeeAffiliationEdit(this);
    pForm.AffiliationCode = lvwAffiliation.SelectedItems[0].Tag.ToString();
    pForm.EmployeeName = GetName();
    pForm.ShowDialog();
   }
  }

  private void lvwAffiliation_KeyUp(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Delete)
    btnAffDelete_Click(null, null);
  }

  private void btnAffDelete_Click(object sender, EventArgs e)
  {
   if (lvwAffiliation.SelectedItems.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsEmployeeAffiliation ef = new clsEmployeeAffiliation();
     ef.AffiliationCode = lvwAffiliation.SelectedItems[0].Tag.ToString();
     ef.Delete();
     LoadAffiliationList();
    }
   }
  }

  private void btnAffRefresh_Click(object sender, EventArgs e)
  {
   LoadAffiliationList();
  }

  ///////// Achievement Tab Event /////////

  private void btnAchieveAdd_Click(object sender, EventArgs e)
  {
   frmEmployeeAchievementAdd pForm = new frmEmployeeAchievementAdd(this);
   pForm.Username = _strUsername;
   pForm.EmployeeName = GetName();
   pForm.ShowDialog();
  }

  private void btnAchieveEdit_Click(object sender, EventArgs e)
  {
   if (lvwAchievement.SelectedItems.Count > 0)
   {
    frmEmployeeAchievementEdit pForm = new frmEmployeeAchievementEdit(this);
    pForm.AchievementCode = lvwAchievement.SelectedItems[0].Tag.ToString();
    pForm.EmployeeName = GetName();
    pForm.ShowDialog();
   }
  }

  private void btnAchieveDelete_Click(object sender, EventArgs e)
  {
   if (lvwAchievement.SelectedItems.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsEmployeeAchievement ea = new clsEmployeeAchievement(lvwAchievement.SelectedItems[0].Tag.ToString());
     ea.Delete();
     LoadAchievementList();
    }
   }
  }

  private void lvwAchievement_KeyUp(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Delete)
    btnAchieveDelete_Click(null, null);
   else if (e.KeyCode == Keys.Enter)
    btnAchieveEdit_Click(null, null);
  }

  private void btnAchieveRefresh_Click(object sender, EventArgs e)
  {
   LoadAchievementList();
  }

  private void btnResearchAdd_Click(object sender, EventArgs e)
  {
   frmEmployeeResearchAdd pForm = new frmEmployeeResearchAdd(this);
   pForm.Username = _strUsername;
   pForm.EmployeeName = GetName();
   pForm.ShowDialog();
  }

  private void btnResearchEdit_Click(object sender, EventArgs e)
  {
   if (lvwResearch.SelectedItems.Count > 0)
   {
    frmEmployeeResearchEdit pForm = new frmEmployeeResearchEdit(this);
    pForm.ResearchCode = lvwResearch.SelectedItems[0].Tag.ToString();
    pForm.EmployeeName = GetName();
    pForm.ShowDialog();
   }
  }

  private void btnResearchDelete_Click(object sender, EventArgs e)
  {
   if (lvwResearch.SelectedItems.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsEmployeeResearch er = new clsEmployeeResearch();
     er.ResearchCode = lvwResearch.SelectedItems[0].Tag.ToString();
     er.Delete();
     LoadResearchList();
    }
   }
  }

  private void lvwResearch_KeyUp(object sender, KeyEventArgs e)
  {
   if (e.KeyCode == Keys.Delete)
    btnResearchDelete_Click(null, null);
   else if (e.KeyCode == Keys.Enter)
    btnResearchEdit_Click(null, null);
  }

  private void btnResearchRefresh_Click(object sender, EventArgs e)
  {
   LoadResearchList();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {   
   if (IsCorrectData())
   {
    using (Employee employee = new Employee())
    {
     employee.Username = _strUsername;
     employee.Fill();
     employee.LastName = txtLastName.Text;
     employee.FirstName = txtFirstName.Text;
     employee.MiddleName = txtMiddleName.Text;
     employee.MiddleInitial = txtMiddleInitial.Text;
     employee.NickName = txtNickName.Text;
     employee.BirthDate = dtpBirthDate.Value;
     employee.Gender = cmbGender.SelectedValue.ToString();
     employee.EmploymentTypeCode = cmbEmployeeType.SelectedValue.ToString();
     employee.EmploymentStatusCode = cmbEmploymentStatus.SelectedValue.ToString();
     try { employee.Title = cmbTitle.SelectedValue.ToString(); }
     catch { employee.Title = ""; }
     try { employee.Suffix = cmbSuffix.SelectedValue.ToString(); }
     catch { employee.Suffix = ""; }
     employee.CompanyCode = cmbCompany.SelectedValue.ToString();
     employee.Position = txtPosition.Text;
     employee.Remarks = txtRemarks.Text;
     employee.EmergencyPerson = txtEmerName.Text;
     employee.EmergencyRelation = txtEmerRelation.Text;
     employee.EmergencyAddress = txtEmerAddress.Text;
     employee.EmergencyPhoneNumber = txtEmerPhone.Text;
     employee.EmergencyCellNumber = txtEmerCell.Text;
     employee.BirthPlace = txtBirthPlace.Text;
     employee.Citizenship = txtCitizenship.Text;
     employee.Height = txtHeight.Text;
     employee.Weight = txtWeight.Text;
     employee.BloodType = txtBloodType.Text;
     employee.Hobbies = txtHobbies.Text;
     employee.Language = txtLanguage.Text;
     employee.CivilStatus = cmbCivilStatus.SelectedValue.ToString();
     employee.FatherName = txtFatherName.Text;
     employee.FatherBirthDate = dtpFatherBDate.Value;
     employee.MotherName = txtMotherName.Text;
     employee.MotherBirthDate = dtpMotherBDate.Value;
     employee.SpouseName = txtSpouseName.Text;
     employee.SpouseBirthDate = dtpSpouseBDate.Value;
     employee.PermanentAddress = txtPermanentAddress.Text;
     employee.PermanentCity = txtPermanentCity.Text;
     employee.PermanentPhoneNumber = txtPermanentPhone.Text;
     employee.CurrentAddress = txtCurrentAddress.Text;
     employee.CurrentCity = txtCurrentCity.Text;
     employee.CurrentPhoneNumber = txtCurrentPhone.Text;
     employee.PrimaryMobileNumber = txtPrimaryMobile.Text;
     employee.AlternativeMobileNumber = txtAlternativeMobile.Text;
     employee.DirectNumber = txtDirectLine.Text;
     employee.LocalNumber = txtLocal.Text;
     employee.FaxNumber = txtFax.Text;
     employee.EmailOfficial = txtEmailOfficial.Text;
     employee.EmailPersonal = txtEmailPersonal.Text;
     employee.ScheduleCode = txtDefaultSched.Text;
     employee.SssID = txtSSS.Text;
     employee.PhilHealthID = txtPhilHealth.Text;
     employee.TaxID = txtTaxID.Text;
     employee.HdmfID = txtHDMF.Text;
     employee.HmoID = txtHMO.Text;
     employee.BankAccount = txtBankAccount.Text;
     employee.DivisionCode = cmbDivision.SelectedValue.ToString();
     employee.GroupCode = cmbGroup.SelectedValue.ToString();
     employee.DepartmentCode = cmbDepartment.SelectedValue.ToString();
     employee.RcCode = cmbRC.SelectedValue.ToString();
     employee.JGCode = cmbJGCode.SelectedValue.ToString();
     employee.Assignment = txtAssignment.Text;
     employee.DateStart = dtpDateStart.Value.Date;
     employee.DateRegular = dtpDateReg.Value.Date;
     employee.DateEnd = dtpDateEnd.Value;
     employee.SkillPrimary = txtSkillPrimary.Text;
     employee.SkillSecondary = txtSkillSecondary.Text;
     employee.UpdatedBy = HRMSCore.Username;
     employee.UpdatedOn = DateTime.Now;
     employee.Status = (chkEnabled.Checked ? "1" : "0");
     employee.IsBillable = (chkBillable.Checked ? "1" : "0");
     try { employee.ResignCode = cmbResignationReason.SelectedValue.ToString(); }
     catch { employee.ResignCode = ""; }
     employee.ResignRemarks = txtResignationRemarks.Text;
     employee.IsResignDesired = (chkResignationDesired.Checked ? "1" : "0");
     try { employee.RecruitmentSourceCode = cmbRecruitmentSource.SelectedValue.ToString(); }
     catch { employee.RecruitmentSourceCode = ""; }
     employee.RecruitmentSourceRemarks = txtRecruitmentRemarks.Text;
     employee.Update();
     MessageBox.Show("Employee details has been updated successfully","Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    this.Close();
   }   
  }

  private void btnAddType_Click(object sender, EventArgs e)
  {
   frmEmployeeTypeNew pForm = new frmEmployeeTypeNew(this);
   pForm.FormCaller = FormCallers.EmployeeDetails;
   pForm.ShowDialog();
  }


  private void btnSchedAdd_Click(object sender, EventArgs e)
  {
   frmEmployeeScheduleInsert pForm = new frmEmployeeScheduleInsert();
   pForm.FormCaller = FormCallers.EmployeeDetails;
   pForm.FormEmployeeDetails = this;
   pForm.Username = _strUsername;
   pForm.DefaultScheduleCode = txtDefaultSched.Text;
   pForm.ShowDialog();
  }

  private void btnSchedDelete_Click(object sender, EventArgs e)
  {
   if (lvScheduleHistory.SelectedItems.Count > 0)
   {
    if (MessageBox.Show(clsMessageBox.MessageBoxDeleteAsk, clsMessageBox.MessageBoxText, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
     clsEmployeeSchedule es = new clsEmployeeSchedule();
     es.EmployeeScheduleCode = lvScheduleHistory.SelectedItems[0].Tag.ToString();
     if (es.Delete() > 0)
      LoadCurrentSchedule();
    }
   }
  }

  private void btnSchedRefresh_Click(object sender, EventArgs e)
  {
   LoadScheduleHistory();
  }

  private void btnSchedEdit_Click(object sender, EventArgs e)
  {
   if (lvScheduleHistory.SelectedItems.Count > 0)
   {
    frmEmployeeScheduleUpdate pForm = new frmEmployeeScheduleUpdate();
    pForm.EmployeeScheduleCode = lvScheduleHistory.SelectedItems[0].Tag.ToString();
    pForm.FormEmployeeDetails = this;
    pForm.DefaultScheduleCode = txtDefaultSched.Text;
    pForm.ShowDialog();
   }
  }

  private void btnDefaultSchedDetails_Click(object sender, EventArgs e)
  {
   frmScheduleDetails pForm = new frmScheduleDetails();
   pForm.FormEmployeeDetails = this;
   pForm.Username = _strUsername;
   pForm.ScheduleCode = txtDefaultSched.Text;
   pForm.ShowDialog();
  }

  private void btnLeaveInclude_Click(object sender, EventArgs e)
  {
   if (lvLeaveTypes.SelectedItems.Count > 0)
   {
    string strLeaveTypeCode = lvLeaveTypes.SelectedItems[0].Tag.ToString();
    if (LeaveApplicationTypes.GetHasBalance(strLeaveTypeCode) == "1")
    {
     frmLeaveBalanceNew pForm = new frmLeaveBalanceNew();
     pForm.LeaveTypeCode = strLeaveTypeCode;
     pForm.Username = _strUsername;
     pForm.FormCaller = FormCallers.EmployeeDetails;
     pForm.FormEmployeeDetails = this;
     pForm.ShowDialog();
    }
    else
    {
     using (LeaveApplicationBalance lb = new LeaveApplicationBalance())
     {
      lb.Username = _strUsername;
      lb.LeaveTypeCode = strLeaveTypeCode;
      lb.Balance = 0;
      lb.Entitlement = 0;
      lb.Status = "1";
      lb.Insert();
     }
     LoadLeaveEntitlement();
     LoadLeaveTypes();
    }
   }
   _frmMDICaller.DSGZeroEL();
   _frmMDICaller.DSGZeroVL();
   _frmMDICaller.DSGZeroSL();
  }

  private void btnLeaveExclude_Click(object sender, EventArgs e)
  {
   if (lvEntitlement.SelectedItems.Count > 0)
   {
    LeaveApplicationBalance lb = new LeaveApplicationBalance();
    lb.Username = _strUsername;
    lb.LeaveTypeCode = lvEntitlement.SelectedItems[0].Tag.ToString();
    lb.Delete();

    LoadLeaveEntitlement();
    LoadLeaveTypes();
   }
   _frmMDICaller.DSGZeroEL();
   _frmMDICaller.DSGZeroVL();
   _frmMDICaller.DSGZeroSL();
  }

  private void btnEntitlementEdit_Click(object sender, EventArgs e)
  {
   if (lvEntitlement.SelectedItems.Count > 0)
   {
    frmLeaveBalanceEdit pForm = new frmLeaveBalanceEdit();
    pForm.Username = _strUsername;
    pForm.LeaveTypeCode = lvEntitlement.SelectedItems[0].Tag.ToString();
    pForm.FormCaller = FormCallers.EmployeeDetails;
    pForm.FormEmployeeDetails = this;
    pForm.FormMdiCaller = _frmMDICaller;
    pForm.Show();
   }
  }

  private void btnResignationReasonAdd_Click(object sender, EventArgs e)
  {
   frmResignationReasonAdd pForm = new frmResignationReasonAdd();
   pForm.FormCaller = FormCallers.EmployeeDetails;
   pForm.FormEmployeeDetails = this;
   pForm.Show();
  }

  private void btnRecruitmentSourceAdd_Click(object sender, EventArgs e)
  {
   frmRecruitmentSourceAdd pForm = new frmRecruitmentSourceAdd();
   pForm.FormCaller = FormCallers.EmployeeDetails;
   pForm.FormEmployeeDetails = this;
   pForm.Show();
  }

  private void txtMiddleName_TextChanged(object sender, EventArgs e)
  {

  }     

  private void lvLeaveTypes_Click(object sender, EventArgs e)
  {         

  }

        private void lvLeaveTypes_DoubleClick(object sender, EventArgs e)
        {
            if (lvLeaveTypes.SelectedItems.Count > 0) {
                MessageBox.Show(lvLeaveTypes.SelectedItems[0].Tag.ToString());  
            }
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDivision.Text != "")
            {
                cmbGroup.DataSource = Group.GetGroup(cmbDivision.SelectedValue.ToString());
                cmbGroup.DisplayMember = "ptext";
                cmbGroup.ValueMember = "pvalue";
                this.ActiveControl = cmbGroup;
            }
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedValue.ToString() != "")
            {
                cmbDepartment.DataSource = Department.GetDepartment(cmbGroup.SelectedValue.ToString());
                cmbDepartment.DisplayMember = "ptext";
                cmbDepartment.ValueMember = "pvalue";
                this.ActiveControl = cmbDepartment;
            }
        }
    }
}