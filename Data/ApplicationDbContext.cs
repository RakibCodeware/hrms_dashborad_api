using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hrms_api.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acgroup> Acgroups { get; set; }

    public virtual DbSet<ActimeZone> ActimeZones { get; set; }

    public virtual DbSet<AttAbsentNotificationAdminList> AttAbsentNotificationAdminLists { get; set; }

    public virtual DbSet<AttAbsentNotificationLog> AttAbsentNotificationLogs { get; set; }

    public virtual DbSet<AttAbsentNotificationSetting> AttAbsentNotificationSettings { get; set; }

    public virtual DbSet<AttBreakTime> AttBreakTimes { get; set; }

    public virtual DbSet<AttBreakTimeSchedule> AttBreakTimeSchedules { get; set; }

    public virtual DbSet<AttBreakTimeWithShift> AttBreakTimeWithShifts { get; set; }

    public virtual DbSet<AttParam> AttParams { get; set; }

    public virtual DbSet<AttSpecialBreakTime> AttSpecialBreakTimes { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<AttendanceLateDeduction> AttendanceLateDeductions { get; set; }

    public virtual DbSet<AttendanceMonthlyLogoutTimeAndOtsetting> AttendanceMonthlyLogoutTimeAndOtsettings { get; set; }

    public virtual DbSet<AttendanceOverTimeCounter> AttendanceOverTimeCounters { get; set; }

    public virtual DbSet<AttendanceStatus> AttendanceStatuses { get; set; }

    public virtual DbSet<AttendanceTransferMedium> AttendanceTransferMedia { get; set; }

    public virtual DbSet<AttendanceWeekendInfo> AttendanceWeekendInfos { get; set; }

    public virtual DbSet<AttendanceWeekendInfo1> AttendanceWeekendInfo1s { get; set; }

    public virtual DbSet<Checkexact> Checkexacts { get; set; }

    public virtual DbSet<Checkinout> Checkinouts { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DeptUsedSch> DeptUsedSchs { get; set; }

    public virtual DbSet<EarnleaveBalanceDetailsLog> EarnleaveBalanceDetailsLogs { get; set; }

    public virtual DbSet<EarnleaveBalanceDetailsLog1> EarnleaveBalanceDetailsLog1s { get; set; }

    public virtual DbSet<EarnleaveMonthlyInfo> EarnleaveMonthlyInfos { get; set; }

    public virtual DbSet<EarnleaveMonthlyInfo1> EarnleaveMonthlyInfo1s { get; set; }

    public virtual DbSet<EarnleaveReserved> EarnleaveReserveds { get; set; }

    public virtual DbSet<EarnleaveReserved1> EarnleaveReserved1s { get; set; }

    public virtual DbSet<EarnleaveSetting> EarnleaveSettings { get; set; }

    public virtual DbSet<EarnleaveSetting1> EarnleaveSetting1s { get; set; }

    public virtual DbSet<FaceTemp> FaceTemps { get; set; }

    public virtual DbSet<HrdAdvanceStatus> HrdAdvanceStatuses { get; set; }

    public virtual DbSet<HrdAllownceSetting> HrdAllownceSettings { get; set; }

    public virtual DbSet<HrdAttendanceBonu> HrdAttendanceBonus { get; set; }

    public virtual DbSet<HrdBankInfo> HrdBankInfos { get; set; }

    public virtual DbSet<HrdBdtnote> HrdBdtnotes { get; set; }

    public virtual DbSet<HrdBranchType> HrdBranchTypes { get; set; }

    public virtual DbSet<HrdBusinessType> HrdBusinessTypes { get; set; }

    public virtual DbSet<HrdCompanyInfo> HrdCompanyInfos { get; set; }

    public virtual DbSet<HrdCompanyType> HrdCompanyTypes { get; set; }

    public virtual DbSet<HrdDepartment> HrdDepartments { get; set; }

    public virtual DbSet<HrdDesignation> HrdDesignations { get; set; }

    public virtual DbSet<HrdDistrict> HrdDistricts { get; set; }

    public virtual DbSet<HrdEmpStatus> HrdEmpStatuses { get; set; }

    public virtual DbSet<HrdEmployeeType> HrdEmployeeTypes { get; set; }

    public virtual DbSet<HrdFloor> HrdFloors { get; set; }

    public virtual DbSet<HrdGrade> HrdGrades { get; set; }

    public virtual DbSet<HrdGroup> HrdGroups { get; set; }

    public virtual DbSet<HrdManpowerStatus> HrdManpowerStatuses { get; set; }

    public virtual DbSet<HrdMonthNameBangla> HrdMonthNameBanglas { get; set; }

    public virtual DbSet<HrdOthersSetting> HrdOthersSettings { get; set; }

    public virtual DbSet<HrdPunishmentType> HrdPunishmentTypes { get; set; }

    public virtual DbSet<HrdQualification> HrdQualifications { get; set; }

    public virtual DbSet<HrdReligion> HrdReligions { get; set; }

    public virtual DbSet<HrdSheet> HrdSheets { get; set; }

    public virtual DbSet<HrdShift> HrdShifts { get; set; }

    public virtual DbSet<HrdShiftDateLog> HrdShiftDateLogs { get; set; }

    public virtual DbSet<HrdSignaturesOfSheet> HrdSignaturesOfSheets { get; set; }

    public virtual DbSet<HrdSpecialTimetable> HrdSpecialTimetables { get; set; }

    public virtual DbSet<HrdSpecialTimetableOld> HrdSpecialTimetableOlds { get; set; }

    public virtual DbSet<HrdSubDepartmentInfo> HrdSubDepartmentInfos { get; set; }

    public virtual DbSet<HrdWeekendSetting> HrdWeekendSettings { get; set; }

    public virtual DbSet<HrdthanaInfo> HrdthanaInfos { get; set; }

    public virtual DbSet<JobCardActual> JobCardActuals { get; set; }

    public virtual DbSet<LeaveApplyDate> LeaveApplyDates { get; set; }

    public virtual DbSet<LeaveApprovalLog> LeaveApprovalLogs { get; set; }

    public virtual DbSet<LeaveDeptWiseWeekend> LeaveDeptWiseWeekends { get; set; }

    public virtual DbSet<LeaveLastEarnLeaveDateLog> LeaveLastEarnLeaveDateLogs { get; set; }

    public virtual DbSet<LeaveLeaveApplication> LeaveLeaveApplications { get; set; }

    public virtual DbSet<LeaveLeaveApplicationDetail> LeaveLeaveApplicationDetails { get; set; }

    public virtual DbSet<LeaveLeaveApplicationLog> LeaveLeaveApplicationLogs { get; set; }

    public virtual DbSet<LeaveLeaveType> LeaveLeaveTypes { get; set; }

    public virtual DbSet<LeaveMaterintyVoucher> LeaveMaterintyVouchers { get; set; }

    public virtual DbSet<LeaveMaterintyVoucherDetail> LeaveMaterintyVoucherDetails { get; set; }

    public virtual DbSet<LeaveMaternityLeavePayment> LeaveMaternityLeavePayments { get; set; }

    public virtual DbSet<LeaveShortLeave> LeaveShortLeaves { get; set; }

    public virtual DbSet<LeaveSignatureOrder> LeaveSignatureOrders { get; set; }

    public virtual DbSet<LeaveWeekend> LeaveWeekends { get; set; }

    public virtual DbSet<LeaveYearlyEarnLeaveGeneration> LeaveYearlyEarnLeaveGenerations { get; set; }

    public virtual DbSet<Machine> Machines { get; set; }

    public virtual DbSet<MailChatInfo> MailChatInfos { get; set; }

    public virtual DbSet<MailComplainInfo> MailComplainInfos { get; set; }

    public virtual DbSet<MailComposeMailInfo> MailComposeMailInfos { get; set; }

    public virtual DbSet<ModulePageInfo> ModulePageInfos { get; set; }

    public virtual DbSet<MonthlyAttendance> MonthlyAttendances { get; set; }

    public virtual DbSet<MonthlyManpower> MonthlyManpowers { get; set; }

    public virtual DbSet<MonthlyOt> MonthlyOts { get; set; }

    public virtual DbSet<NumRun> NumRuns { get; set; }

    public virtual DbSet<NumRunDeil> NumRunDeils { get; set; }

    public virtual DbSet<PayrollAdvanceDetail> PayrollAdvanceDetails { get; set; }

    public virtual DbSet<PayrollAdvanceInfo> PayrollAdvanceInfos { get; set; }

    public virtual DbSet<PayrollAdvanceSetting> PayrollAdvanceSettings { get; set; }

    public virtual DbSet<PayrollAllowanceCalculationSetting> PayrollAllowanceCalculationSettings { get; set; }

    public virtual DbSet<PayrollBonusMonthSetup> PayrollBonusMonthSetups { get; set; }

    public virtual DbSet<PayrollBonusMonthSetup1> PayrollBonusMonthSetup1s { get; set; }

    public virtual DbSet<PayrollBonusSetup> PayrollBonusSetups { get; set; }

    public virtual DbSet<PayrollBonusSetup1> PayrollBonusSetup1s { get; set; }

    public virtual DbSet<PayrollEarnLeavePaymentSheet> PayrollEarnLeavePaymentSheets { get; set; }

    public virtual DbSet<PayrollEarnLeavePaymentSheet1> PayrollEarnLeavePaymentSheet1s { get; set; }

    public virtual DbSet<PayrollHolidayAllowanceGenerate> PayrollHolidayAllowanceGenerates { get; set; }

    public virtual DbSet<PayrollHolidayWeekendBill> PayrollHolidayWeekendBills { get; set; }

    public virtual DbSet<PayrollLoanDetail> PayrollLoanDetails { get; set; }

    public virtual DbSet<PayrollLoanInfo> PayrollLoanInfos { get; set; }

    public virtual DbSet<PayrollLoanMonthlySetup> PayrollLoanMonthlySetups { get; set; }

    public virtual DbSet<PayrollMonthlyNoteAmount> PayrollMonthlyNoteAmounts { get; set; }

    public virtual DbSet<PayrollMonthlySalarySheet> PayrollMonthlySalarySheets { get; set; }

    public virtual DbSet<PayrollMonthlySalarySheet1> PayrollMonthlySalarySheet1s { get; set; }

    public virtual DbSet<PayrollOfficeIsGarment> PayrollOfficeIsGarments { get; set; }

    public virtual DbSet<PayrollOthersPay> PayrollOthersPays { get; set; }

    public virtual DbSet<PayrollPunishment> PayrollPunishments { get; set; }

    public virtual DbSet<PayrollYearlyBonusSheet> PayrollYearlyBonusSheets { get; set; }

    public virtual DbSet<PayrollYearlyBonusSheet1> PayrollYearlyBonusSheet1s { get; set; }

    public virtual DbSet<PersonnelEmergencyContact> PersonnelEmergencyContacts { get; set; }

    public virtual DbSet<PersonnelEmpAddress> PersonnelEmpAddresses { get; set; }

    public virtual DbSet<PersonnelEmpCommonIncrement> PersonnelEmpCommonIncrements { get; set; }

    public virtual DbSet<PersonnelEmpCurrentStatus> PersonnelEmpCurrentStatuses { get; set; }

    public virtual DbSet<PersonnelEmpCurrentStatus1> PersonnelEmpCurrentStatus1s { get; set; }

    public virtual DbSet<PersonnelEmpCurrentStatusPromotionLog> PersonnelEmpCurrentStatusPromotionLogs { get; set; }

    public virtual DbSet<PersonnelEmpCurrentStatusSalaryIncrementLog> PersonnelEmpCurrentStatusSalaryIncrementLogs { get; set; }

    public virtual DbSet<PersonnelEmpEducation> PersonnelEmpEducations { get; set; }

    public virtual DbSet<PersonnelEmpExperience> PersonnelEmpExperiences { get; set; }

    public virtual DbSet<PersonnelEmpPersonnal> PersonnelEmpPersonnals { get; set; }

    public virtual DbSet<PersonnelEmpProximityChangeLog> PersonnelEmpProximityChangeLogs { get; set; }

    public virtual DbSet<PersonnelEmpPunismentInfo> PersonnelEmpPunismentInfos { get; set; }

    public virtual DbSet<PersonnelEmpRejoin> PersonnelEmpRejoins { get; set; }

    public virtual DbSet<PersonnelEmpSeparation> PersonnelEmpSeparations { get; set; }

    public virtual DbSet<PersonnelEmpSeparation1> PersonnelEmpSeparation1s { get; set; }

    public virtual DbSet<PersonnelEmployeeInfo> PersonnelEmployeeInfos { get; set; }

    public virtual DbSet<PersonnelSeparationActivation1Log> PersonnelSeparationActivation1Logs { get; set; }

    public virtual DbSet<PersonnelSeparationActivationLog> PersonnelSeparationActivationLogs { get; set; }

    public virtual DbSet<PersonnelWorkerCardNoSequence> PersonnelWorkerCardNoSequences { get; set; }

    public virtual DbSet<PfActivityLog> PfActivityLogs { get; set; }

    public virtual DbSet<PfCalculationDetail> PfCalculationDetails { get; set; }

    public virtual DbSet<PfCalculationSetting> PfCalculationSettings { get; set; }

    public virtual DbSet<PfCompanyInfo> PfCompanyInfos { get; set; }

    public virtual DbSet<PfCompanyRelation> PfCompanyRelations { get; set; }

    public virtual DbSet<PfExpense> PfExpenses { get; set; }

    public virtual DbSet<PfFdr> PfFdrs { get; set; }

    public virtual DbSet<PfFdrInterest> PfFdrInterests { get; set; }

    public virtual DbSet<PfInterestDistribution> PfInterestDistributions { get; set; }

    public virtual DbSet<PfInvestmentType> PfInvestmentTypes { get; set; }

    public virtual DbSet<PfPfrecord> PfPfrecords { get; set; }

    public virtual DbSet<PfProfit> PfProfits { get; set; }

    public virtual DbSet<PfProfitDistributionLog> PfProfitDistributionLogs { get; set; }

    public virtual DbSet<PfWithdraw> PfWithdraws { get; set; }

    public virtual DbSet<PfYearlyExpense> PfYearlyExpenses { get; set; }

    public virtual DbSet<SchClass> SchClasses { get; set; }

    public virtual DbSet<ShiftTransferDetailsMissingLog> ShiftTransferDetailsMissingLogs { get; set; }

    public virtual DbSet<ShiftTransferInfo> ShiftTransferInfos { get; set; }

    public virtual DbSet<ShiftTransferInfoDetail> ShiftTransferInfoDetails { get; set; }

    public virtual DbSet<TblAttendance> TblAttendances { get; set; }

    public virtual DbSet<TblAttendanceNotCountableLogRecord> TblAttendanceNotCountableLogRecords { get; set; }

    public virtual DbSet<TblAttendancePunchTemp> TblAttendancePunchTemps { get; set; }

    public virtual DbSet<TblAttendanceRecord> TblAttendanceRecords { get; set; }

    public virtual DbSet<TblAttendanceRecordPunchLog> TblAttendanceRecordPunchLogs { get; set; }

    public virtual DbSet<TblDailyAttendance> TblDailyAttendances { get; set; }

    public virtual DbSet<TblDepartmentWiseAttendance> TblDepartmentWiseAttendances { get; set; }

    public virtual DbSet<TblEmpWiseWeekendinfo> TblEmpWiseWeekendinfos { get; set; }

    public virtual DbSet<TblGeneralDay> TblGeneralDays { get; set; }

    public virtual DbSet<TblHolydayWeekentEmployeeWise> TblHolydayWeekentEmployeeWises { get; set; }

    public virtual DbSet<TblHolydayWeekentEmployeeWiseDetail> TblHolydayWeekentEmployeeWiseDetails { get; set; }

    public virtual DbSet<TblHolydayWork> TblHolydayWorks { get; set; }

    public virtual DbSet<TblHolydayWork1> TblHolydayWork1s { get; set; }

    public virtual DbSet<TblLeaveApproval> TblLeaveApprovals { get; set; }

    public virtual DbSet<TblLeaveAuthorityAccessControl> TblLeaveAuthorityAccessControls { get; set; }

    public virtual DbSet<TblLeaveConfig> TblLeaveConfigs { get; set; }

    public virtual DbSet<TblMonthSetup> TblMonthSetups { get; set; }

    public virtual DbSet<TblMonthSetup1> TblMonthSetup1s { get; set; }

    public virtual DbSet<TblOutDuty> TblOutDuties { get; set; }

    public virtual DbSet<TblOutDutyApprovalLog> TblOutDutyApprovalLogs { get; set; }

    public virtual DbSet<TblOutDutyAuthorityAccessControl> TblOutDutyAuthorityAccessControls { get; set; }

    public virtual DbSet<TblOutdutyDetail> TblOutdutyDetails { get; set; }

    public virtual DbSet<TblReportHeading> TblReportHeadings { get; set; }

    public virtual DbSet<TblStatusJoinClose> TblStatusJoinCloses { get; set; }

    public virtual DbSet<TblTarget> TblTargets { get; set; }

    public virtual DbSet<TempNewLeaveDateForAlter> TempNewLeaveDateForAlters { get; set; }

    public virtual DbSet<TempOldLeaveDateForAlter> TempOldLeaveDateForAlters { get; set; }

    public virtual DbSet<Template> Templates { get; set; }

    public virtual DbSet<TotalPresentForJobCard> TotalPresentForJobCards { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    public virtual DbSet<UserOfRun> UserOfRuns { get; set; }

    public virtual DbSet<UserPrivilege> UserPrivileges { get; set; }

    public virtual DbSet<Userinfo> Userinfos { get; set; }

    public virtual DbSet<UsersMachine> UsersMachines { get; set; }

    public virtual DbSet<VAllOffDay> VAllOffDays { get; set; }

    public virtual DbSet<VAttBreakTime> VAttBreakTimes { get; set; }

    public virtual DbSet<VAttendanceLateDeduction> VAttendanceLateDeductions { get; set; }

    public virtual DbSet<VAttendanceWeekendInfo> VAttendanceWeekendInfos { get; set; }

    public virtual DbSet<VCheckinout> VCheckinouts { get; set; }

    public virtual DbSet<VDailyAttendanceSummary> VDailyAttendanceSummaries { get; set; }

    public virtual DbSet<VDailyTiffinBillGenerate> VDailyTiffinBillGenerates { get; set; }

    public virtual DbSet<VEarnLeaveGenerateAccount> VEarnLeaveGenerateAccounts { get; set; }

    public virtual DbSet<VEarnleaveMonthlyInfo> VEarnleaveMonthlyInfos { get; set; }

    public virtual DbSet<VEarnleaveMonthlyInfo1> VEarnleaveMonthlyInfo1s { get; set; }

    public virtual DbSet<VEmpContactInfo> VEmpContactInfos { get; set; }

    public virtual DbSet<VEmpRejoinSheet> VEmpRejoinSheets { get; set; }

    public virtual DbSet<VEmployeeDetail> VEmployeeDetails { get; set; }

    public virtual DbSet<VEmployeeDetails1> VEmployeeDetails1s { get; set; }

    public virtual DbSet<VEmployeeExperience> VEmployeeExperiences { get; set; }

    public virtual DbSet<VEmployeeProfile> VEmployeeProfiles { get; set; }

    public virtual DbSet<VFirstInLastOut> VFirstInLastOuts { get; set; }

    public virtual DbSet<VForShiftChangeReport> VForShiftChangeReports { get; set; }

    public virtual DbSet<VHrdCompanyInfo> VHrdCompanyInfos { get; set; }

    public virtual DbSet<VHrdDepartment> VHrdDepartments { get; set; }

    public virtual DbSet<VHrdDesignation> VHrdDesignations { get; set; }

    public virtual DbSet<VHrdGroup> VHrdGroups { get; set; }

    public virtual DbSet<VHrdShift> VHrdShifts { get; set; }

    public virtual DbSet<VLeaveLeaveApplication> VLeaveLeaveApplications { get; set; }

    public virtual DbSet<VLeaveLeaveApplicationDetail> VLeaveLeaveApplicationDetails { get; set; }

    public virtual DbSet<VLeaveLeaveApplicationLog> VLeaveLeaveApplicationLogs { get; set; }

    public virtual DbSet<VLeaveMaterintyVoucher> VLeaveMaterintyVouchers { get; set; }

    public virtual DbSet<VLeaveMaterintyVoucherDetail> VLeaveMaterintyVoucherDetails { get; set; }

    public virtual DbSet<VLeaveShortLeave> VLeaveShortLeaves { get; set; }

    public virtual DbSet<VLeaveYearlyEarnLeaveGeneration> VLeaveYearlyEarnLeaveGenerations { get; set; }

    public virtual DbSet<VLineConfig> VLineConfigs { get; set; }

    public virtual DbSet<VMailChatInfo> VMailChatInfos { get; set; }

    public virtual DbSet<VMailComplainInfo> VMailComplainInfos { get; set; }

    public virtual DbSet<VMailComposeMailInfo> VMailComposeMailInfos { get; set; }

    public virtual DbSet<VManPowerStatus> VManPowerStatuses { get; set; }

    public virtual DbSet<VManpowerProcess> VManpowerProcesses { get; set; }

    public virtual DbSet<VMoanthlyAttendanceSheetReport> VMoanthlyAttendanceSheetReports { get; set; }

    public virtual DbSet<VMonthlyAttendance> VMonthlyAttendances { get; set; }

    public virtual DbSet<VMonthlyOt> VMonthlyOts { get; set; }

    public virtual DbSet<VMonthlySalaryFlowReport> VMonthlySalaryFlowReports { get; set; }

    public virtual DbSet<VMonthlySalarySheet> VMonthlySalarySheets { get; set; }

    public virtual DbSet<VMonthlySalarySheet1> VMonthlySalarySheet1s { get; set; }

    public virtual DbSet<VPayrollAdvanceInfo> VPayrollAdvanceInfos { get; set; }

    public virtual DbSet<VPayrollAdvanceSetting> VPayrollAdvanceSettings { get; set; }

    public virtual DbSet<VPayrollBonusMonthSetup> VPayrollBonusMonthSetups { get; set; }

    public virtual DbSet<VPayrollBonusMonthSetup1> VPayrollBonusMonthSetup1s { get; set; }

    public virtual DbSet<VPayrollBonusSetup> VPayrollBonusSetups { get; set; }

    public virtual DbSet<VPayrollBonusSetup1> VPayrollBonusSetup1s { get; set; }

    public virtual DbSet<VPayrollBonusSetupDistinctRecord> VPayrollBonusSetupDistinctRecords { get; set; }

    public virtual DbSet<VPayrollBonusSetupDistinctRecord1> VPayrollBonusSetupDistinctRecord1s { get; set; }

    public virtual DbSet<VPayrollEarnLeavePaymentSheet> VPayrollEarnLeavePaymentSheets { get; set; }

    public virtual DbSet<VPayrollEarnLeavePaymentSheet1> VPayrollEarnLeavePaymentSheet1s { get; set; }

    public virtual DbSet<VPayrollHolidayAllowanceGenerate> VPayrollHolidayAllowanceGenerates { get; set; }

    public virtual DbSet<VPayrollHolidayAllowanceGenerateDetail> VPayrollHolidayAllowanceGenerateDetails { get; set; }

    public virtual DbSet<VPayrollHolidayWeekendBill> VPayrollHolidayWeekendBills { get; set; }

    public virtual DbSet<VPayrollLoanInfo> VPayrollLoanInfos { get; set; }

    public virtual DbSet<VPayrollLoanInfoDetail> VPayrollLoanInfoDetails { get; set; }

    public virtual DbSet<VPayrollLoanSetting> VPayrollLoanSettings { get; set; }

    public virtual DbSet<VPayrollMonthlyNoteAmount> VPayrollMonthlyNoteAmounts { get; set; }

    public virtual DbSet<VPayrollOthersPay> VPayrollOthersPays { get; set; }

    public virtual DbSet<VPayrollPunishment> VPayrollPunishments { get; set; }

    public virtual DbSet<VPayrollYearlyBonusSheet> VPayrollYearlyBonusSheets { get; set; }

    public virtual DbSet<VPayrollYearlyBonusSheet1> VPayrollYearlyBonusSheet1s { get; set; }

    public virtual DbSet<VPersonnelEmpCurrentStatus> VPersonnelEmpCurrentStatuses { get; set; }

    public virtual DbSet<VPersonnelEmpCurrentStatus1> VPersonnelEmpCurrentStatus1s { get; set; }

    public virtual DbSet<VPersonnelEmpCurrentStatusPromotionLog> VPersonnelEmpCurrentStatusPromotionLogs { get; set; }

    public virtual DbSet<VPersonnelEmpCurrentStatusSalaryIncrementLog> VPersonnelEmpCurrentStatusSalaryIncrementLogs { get; set; }

    public virtual DbSet<VPersonnelEmpNewPosition> VPersonnelEmpNewPositions { get; set; }

    public virtual DbSet<VPersonnelEmpPunismentInfo> VPersonnelEmpPunismentInfos { get; set; }

    public virtual DbSet<VPersonnelEmpRejoin> VPersonnelEmpRejoins { get; set; }

    public virtual DbSet<VPersonnelEmpSeparation> VPersonnelEmpSeparations { get; set; }

    public virtual DbSet<VPersonnelEmpSeparation1> VPersonnelEmpSeparation1s { get; set; }

    public virtual DbSet<VPfBalanceSheet> VPfBalanceSheets { get; set; }

    public virtual DbSet<VPfCalculationSetting> VPfCalculationSettings { get; set; }

    public virtual DbSet<VPfMemberListAll> VPfMemberListAlls { get; set; }

    public virtual DbSet<VPfMonthlyProfit> VPfMonthlyProfits { get; set; }

    public virtual DbSet<VPromotionIncrement> VPromotionIncrements { get; set; }

    public virtual DbSet<VPromotionIncrement1> VPromotionIncrement1s { get; set; }

    public virtual DbSet<VSeparationSheet> VSeparationSheets { get; set; }

    public virtual DbSet<VSeparationSheet1> VSeparationSheet1s { get; set; }

    public virtual DbSet<VShiftTranferDetailsForFirstInLastOut> VShiftTranferDetailsForFirstInLastOuts { get; set; }

    public virtual DbSet<VShiftTransferInfoDepartmetnList> VShiftTransferInfoDepartmetnLists { get; set; }

    public virtual DbSet<VShiftTransferInfoDetail> VShiftTransferInfoDetails { get; set; }

    public virtual DbSet<VTblAttendanceRecord> VTblAttendanceRecords { get; set; }

    public virtual DbSet<VTblAttendanceRecord1> VTblAttendanceRecord1s { get; set; }

    public virtual DbSet<VTblAttendanceRecordPunchLog> VTblAttendanceRecordPunchLogs { get; set; }

    public virtual DbSet<VTblHolydayWeekentEmployeeWise> VTblHolydayWeekentEmployeeWises { get; set; }

    public virtual DbSet<VTblHolydayWork> VTblHolydayWorks { get; set; }

    public virtual DbSet<VTblHolydayWork1> VTblHolydayWork1s { get; set; }

    public virtual DbSet<VTblLeaveConfig> VTblLeaveConfigs { get; set; }

    public virtual DbSet<VTblOutDuty> VTblOutDuties { get; set; }

    public virtual DbSet<VTblOutdutyDetail> VTblOutdutyDetails { get; set; }

    public virtual DbSet<VTblWeekendInfoReport> VTblWeekendInfoReports { get; set; }

    public virtual DbSet<VThanaInfo> VThanaInfos { get; set; }

    public virtual DbSet<VUserAccount> VUserAccounts { get; set; }

    public virtual DbSet<VUserAccountForLeave> VUserAccountForLeaves { get; set; }

    public virtual DbSet<VUserPrivilegeList> VUserPrivilegeLists { get; set; }

    public virtual DbSet<VVDailyAttendanceSummary> VVDailyAttendanceSummaries { get; set; }

    public virtual DbSet<VVForDailyMovementReport> VVForDailyMovementReports { get; set; }

    public virtual DbSet<VVLeaveLeaveApplicationDetail> VVLeaveLeaveApplicationDetails { get; set; }

    public virtual DbSet<VVTblAttendanceRecord> VVTblAttendanceRecords { get; set; }

    public virtual DbSet<VVVLeaveLeaveApplicationDetailsForLeaveBalanceReport> VVVLeaveLeaveApplicationDetailsForLeaveBalanceReports { get; set; }

    public virtual DbSet<VVVLeaveLeaveApplicationDetailsForOfficialPurposeReport> VVVLeaveLeaveApplicationDetailsForOfficialPurposeReports { get; set; }

    public virtual DbSet<VVVLeaveYearlyStatus> VVVLeaveYearlyStatuses { get; set; }

    public virtual DbSet<VVVTblAttendanceRecord> VVVTblAttendanceRecords { get; set; }

    public virtual DbSet<VVatTaxIncomeTax> VVatTaxIncomeTaxes { get; set; }

    public virtual DbSet<VVatTaxRate> VVatTaxRates { get; set; }

    public virtual DbSet<VVatTaxRebatableRate> VVatTaxRebatableRates { get; set; }

    public virtual DbSet<VVatTaxYear> VVatTaxYears { get; set; }

    public virtual DbSet<VatTaxEmpInvestment> VatTaxEmpInvestments { get; set; }

    public virtual DbSet<VatTaxGenerateType> VatTaxGenerateTypes { get; set; }

    public virtual DbSet<VatTaxIncomeTax> VatTaxIncomeTaxes { get; set; }

    public virtual DbSet<VatTaxIncomeTaxDetailsLog> VatTaxIncomeTaxDetailsLogs { get; set; }

    public virtual DbSet<VatTaxMinimumTax> VatTaxMinimumTaxes { get; set; }

    public virtual DbSet<VatTaxRate> VatTaxRates { get; set; }

    public virtual DbSet<VatTaxRebatableRate> VatTaxRebatableRates { get; set; }

    public virtual DbSet<VatTaxRebateCalculation> VatTaxRebateCalculations { get; set; }

    public virtual DbSet<VatTaxTaxCalculation> VatTaxTaxCalculations { get; set; }

    public virtual DbSet<VatTaxTaxFreeAllowance> VatTaxTaxFreeAllowances { get; set; }

    public virtual DbSet<VatTaxYear> VatTaxYears { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=5.77.32.139; Initial catalog=cw_hrms_demo;User ID=cw_hrms_demo_admin;Password=@cw@hrms#2024; Trusted_Connection=True; TrustServerCertificate=True;Integrated Security=False;");

    //Data Source = CODEWARE; Initial catalog = RSSHRM; User ID = sa; Password=123; Trusted_Connection=True; TrustServerCertificate=True;Integrated Security = False;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acgroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACGroup");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.Holidayvaild).HasColumnName("holidayvaild");
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Verifystyle).HasColumnName("verifystyle");
        });

        modelBuilder.Entity<ActimeZone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACTimeZones");

            entity.Property(e => e.FriEnd).HasColumnType("datetime");
            entity.Property(e => e.FriStart).HasColumnType("datetime");
            entity.Property(e => e.MonEnd).HasColumnType("datetime");
            entity.Property(e => e.MonStart).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.SatEnd).HasColumnType("datetime");
            entity.Property(e => e.SatStart).HasColumnType("datetime");
            entity.Property(e => e.SunEnd).HasColumnType("datetime");
            entity.Property(e => e.SunStart).HasColumnType("datetime");
            entity.Property(e => e.ThursEnd).HasColumnType("datetime");
            entity.Property(e => e.ThursStart).HasColumnType("datetime");
            entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");
            entity.Property(e => e.TuesEnd).HasColumnType("datetime");
            entity.Property(e => e.TuesStart).HasColumnType("datetime");
            entity.Property(e => e.WedEnd).HasColumnType("datetime");
            entity.Property(e => e.WedStart).HasColumnType("datetime");
        });

        modelBuilder.Entity<AttAbsentNotificationAdminList>(entity =>
        {
            entity.HasKey(e => e.AdminId);

            entity.ToTable("AttAbsentNotificationAdminList");

            entity.Property(e => e.AdminId)
                .ValueGeneratedNever()
                .HasColumnName("AdminID");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<AttAbsentNotificationLog>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.AdminId, e.Date });

            entity.ToTable("AttAbsentNotification_Log");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.AdminId).HasColumnName("AdminID");
            entity.Property(e => e.Seen).HasColumnName("seen");
        });

        modelBuilder.Entity<AttAbsentNotificationSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AttAbsentNotificationSetting");

            entity.Property(e => e.StatusCount)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AttBreakTime>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AttBreakTime");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.BreakId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BreakID");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AttBreakTimeSchedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AttBreakTimeSchedule");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Note)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AttBreakTimeWithShift>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AttBreakTimeWithShift");

            entity.Property(e => e.BrkId).HasColumnName("BrkID");
            entity.Property(e => e.SftId).HasColumnName("SftID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.Brk).WithMany()
                .HasForeignKey(d => d.BrkId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AttBreakTimeWithShift_AttBreakTime");
        });

        modelBuilder.Entity<AttParam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AttParam");

            entity.Property(e => e.Paraname)
                .HasMaxLength(20)
                .HasColumnName("PARANAME");
            entity.Property(e => e.Paratype)
                .HasMaxLength(2)
                .HasColumnName("PARATYPE");
            entity.Property(e => e.Paravalue)
                .HasMaxLength(100)
                .HasColumnName("PARAVALUE");
        });

        modelBuilder.Entity<AttSpecialBreakTime>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("AttSpecialBreakTime");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DutyType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance");
        });

        modelBuilder.Entity<AttendanceLateDeduction>(entity =>
        {
            entity.HasKey(e => e.Ldid);

            entity.ToTable("Attendance_LateDeduction");

            entity.Property(e => e.Ldid).HasColumnName("LDId");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LeaveName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AttendanceMonthlyLogoutTimeAndOtsetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance_MonthlyLogoutTimeAndOTSetting");

            entity.Property(e => e.MonthName)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.NormallyOthour).HasColumnName("NormallyOTHour");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<AttendanceOverTimeCounter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance_OverTime_Counter");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<AttendanceStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance_Status");

            entity.Property(e => e.AttStatus)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.StateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AttendanceTransferMedium>(entity =>
        {
            entity.HasKey(e => e.Sl).HasName("PK_tblRecord");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AttendanceWeekendInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance_WeekendInfo");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.Reason)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
            entity.Property(e => e.Weekend)
                .HasMaxLength(18)
                .IsUnicode(false);

            entity.HasOne(d => d.Company).WithMany()
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Attendance_WeekendInfo_HRD_CompanyInfo");

            entity.HasOne(d => d.Month).WithMany()
                .HasForeignKey(d => d.MonthId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Attendance_WeekendInfo_tblMonthSetup");
        });

        modelBuilder.Entity<AttendanceWeekendInfo1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance_WeekendInfo1");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.Reason)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
            entity.Property(e => e.Weekend)
                .HasMaxLength(18)
                .IsUnicode(false);

            entity.HasOne(d => d.Company).WithMany()
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Attendance_WeekendInfo1_HRD_CompanyInfo");

            entity.HasOne(d => d.Month).WithMany()
                .HasForeignKey(d => d.MonthId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Attendance_WeekendInfo1_tblMonthSetup1");
        });

        modelBuilder.Entity<Checkexact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CHECKEXACT");

            entity.Property(e => e.Checktime)
                .HasColumnType("datetime")
                .HasColumnName("CHECKTIME");
            entity.Property(e => e.Checktype)
                .HasMaxLength(2)
                .HasColumnName("CHECKTYPE");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            entity.Property(e => e.Exactid).HasColumnName("EXACTID");
            entity.Property(e => e.Incount).HasColumnName("INCOUNT");
            entity.Property(e => e.Isadd).HasColumnName("ISADD");
            entity.Property(e => e.Iscount).HasColumnName("ISCOUNT");
            entity.Property(e => e.Isdelete).HasColumnName("ISDELETE");
            entity.Property(e => e.Ismodify).HasColumnName("ISMODIFY");
            entity.Property(e => e.Modifyby)
                .HasMaxLength(20)
                .HasDefaultValue("Temp-Supervisor")
                .HasColumnName("MODIFYBY");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Yuyin)
                .HasMaxLength(25)
                .HasColumnName("YUYIN");
        });

        modelBuilder.Entity<Checkinout>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CHECKINOUT");

            entity.Property(e => e.Checktime)
                .HasColumnType("datetime")
                .HasColumnName("CHECKTIME");
            entity.Property(e => e.Checktype)
                .HasMaxLength(1)
                .HasColumnName("CHECKTYPE");
            entity.Property(e => e.Memoinfo).HasMaxLength(30);
            entity.Property(e => e.Sensorid)
                .HasMaxLength(5)
                .HasColumnName("SENSORID");
            entity.Property(e => e.Sn)
                .HasMaxLength(20)
                .HasColumnName("sn");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Verifycode).HasColumnName("VERIFYCODE");
            entity.Property(e => e.WorkCode).HasMaxLength(24);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DEPARTMENTS");

            entity.Property(e => e.Att).HasColumnName("ATT");
            entity.Property(e => e.Deptid).HasColumnName("DEPTID");
            entity.Property(e => e.Deptname)
                .HasMaxLength(30)
                .HasColumnName("DEPTNAME");
            entity.Property(e => e.RegisterOt).HasColumnName("RegisterOT");
            entity.Property(e => e.Supdeptid).HasColumnName("SUPDEPTID");
        });

        modelBuilder.Entity<DeptUsedSch>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<EarnleaveBalanceDetailsLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Earnleave_BalanceDetailsLog");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.EntryDatetime).HasColumnType("datetime");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<EarnleaveBalanceDetailsLog1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Earnleave_BalanceDetailsLog1");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.EntryDatetime).HasColumnType("datetime");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<EarnleaveMonthlyInfo>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.Month });

            entity.ToTable("Earnleave_MonthlyInfo");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.EntryTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<EarnleaveMonthlyInfo1>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.Month });

            entity.ToTable("Earnleave_MonthlyInfo1");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.EntryTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<EarnleaveReserved>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Earnleave_Reserved");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.EntryDatetime).HasColumnType("datetime");
            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.Payment).WithMany()
                .HasForeignKey(d => d.PaymentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Earnleave_Reserved_Payroll_EarnLeavePaymentSheet");
        });

        modelBuilder.Entity<EarnleaveReserved1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Earnleave_Reserved1");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.EntryDatetime).HasColumnType("datetime");
            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.Payment).WithMany()
                .HasForeignKey(d => d.PaymentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Earnleave_Reserved1_Payroll_EarnLeavePaymentSheet1");
        });

        modelBuilder.Entity<EarnleaveSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Earnleave_Setting");

            entity.Property(e => e.ElstartDate).HasColumnName("ELStartDate");
            entity.Property(e => e.PaymentOn)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EarnleaveSetting1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Earnleave_Setting1");

            entity.Property(e => e.ElstartDate).HasColumnName("ELStartDate");
            entity.Property(e => e.PaymentOn)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FaceTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FaceTemp");

            entity.Property(e => e.Activetime).HasColumnName("ACTIVETIME");
            entity.Property(e => e.Faceid).HasColumnName("FACEID");
            entity.Property(e => e.Pin).HasColumnName("pin");
            entity.Property(e => e.Reserve).HasColumnName("RESERVE");
            entity.Property(e => e.Size).HasColumnName("SIZE");
            entity.Property(e => e.Template)
                .HasColumnType("image")
                .HasColumnName("TEMPLATE");
            entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Userno)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("USERNO");
            entity.Property(e => e.Valid).HasColumnName("VALID");
            entity.Property(e => e.Vfcount).HasColumnName("VFCOUNT");
        });

        modelBuilder.Entity<HrdAdvanceStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("HRD_AdvanceStatus");

            entity.Property(e => e.StatusId)
                .ValueGeneratedNever()
                .HasColumnName("StatusID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdAllownceSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_AllownceSetting");

            entity.Property(e => e.AllownceId).ValueGeneratedOnAdd();
            entity.Property(e => e.BasicAllowance).HasDefaultValue(0.0);
            entity.Property(e => e.ConvenceAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FoodAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.HouseRent).HasDefaultValue(0.0);
            entity.Property(e => e.MedicalAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.OthersAllowance).HasDefaultValue(0.0);
            entity.Property(e => e.Pfallowance)
                .HasDefaultValue(0.0)
                .HasColumnName("PFAllowance");
            entity.Property(e => e.StampDeduct).HasDefaultValue(0.0);
            entity.Property(e => e.TechnicalAllowance).HasDefaultValue(0.0);
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdAttendanceBonu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_AttendanceBonus");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.EmpTypeId).HasColumnName("EmpTypeID");
        });

        modelBuilder.Entity<HrdBankInfo>(entity =>
        {
            entity.HasKey(e => e.BankId);

            entity.ToTable("HRD_BankInfo");

            entity.Property(e => e.BankName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<HrdBdtnote>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_BDTNote");

            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<HrdBranchType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_BranchType");
        });

        modelBuilder.Entity<HrdBusinessType>(entity =>
        {
            entity.HasKey(e => e.Bid);

            entity.ToTable("HRD_BusinessType");

            entity.HasIndex(e => e.BtypeName, "businessTypeNameForUnique").IsUnique();

            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.BtypeName)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("BTypeName");
        });

        modelBuilder.Entity<HrdCompanyInfo>(entity =>
        {
            entity.HasKey(e => e.CompanyId);

            entity.ToTable("HRD_CompanyInfo");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.AttMachineName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Comments)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyLogo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DefaultCurrency)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.HeadOfficeId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsOdauthority).HasColumnName("IsODAuthority");
            entity.Property(e => e.ShortName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StartCardNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Telephone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Weekend)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdCompanyType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_CompanyType");

            entity.Property(e => e.ComType)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdDepartment>(entity =>
        {
            entity.HasKey(e => e.DptId);

            entity.ToTable("HRD_Department");

            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DptStatus).HasDefaultValue(true);
            entity.Property(e => e.IsHalfOt).HasColumnName("IsHalfOT");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<HrdDesignation>(entity =>
        {
            entity.HasKey(e => e.DsgId);

            entity.ToTable("HRD_Designation");

            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.DsgShortName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgStatus).HasDefaultValue(true);
            entity.Property(e => e.HouseRentPersent).HasColumnName("HouseRent_Persent");
            entity.Property(e => e.PfPersent).HasColumnName("PF_Persent");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.Dpt).WithMany(p => p.HrdDesignations)
                .HasForeignKey(d => d.DptId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HRD_Designation_HRD_Department");
        });

        modelBuilder.Entity<HrdDistrict>(entity =>
        {
            entity.HasKey(e => e.DstId);

            entity.ToTable("HRD_District");

            entity.HasIndex(e => e.DstName, "DistrictNameForUnique").IsUnique();

            entity.Property(e => e.Division)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DstBangla).HasMaxLength(50);
            entity.Property(e => e.DstName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdEmpStatus>(entity =>
        {
            entity.HasKey(e => e.EmpStatus);

            entity.ToTable("HRD_EmpStatus");

            entity.Property(e => e.EmpStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdEmployeeType>(entity =>
        {
            entity.HasKey(e => e.EmpTypeId);

            entity.ToTable("HRD_EmployeeType");

            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.EmpTypeBn).HasMaxLength(12);
        });

        modelBuilder.Entity<HrdFloor>(entity =>
        {
            entity.HasKey(e => e.Fid);

            entity.ToTable("HRD_Floor");

            entity.Property(e => e.Fid).HasColumnName("FId");
            entity.Property(e => e.Fname)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("FName");
            entity.Property(e => e.FnameBn)
                .HasMaxLength(60)
                .HasColumnName("FNameBn");
            entity.Property(e => e.Remarks)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdGrade>(entity =>
        {
            entity.HasKey(e => e.GrdName).HasName("PK_HRD_Grade_1");

            entity.ToTable("HRD_Grade");

            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrdId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrdNameBangla).HasMaxLength(50);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<HrdGroup>(entity =>
        {
            entity.HasKey(e => e.Gid);

            entity.ToTable("HRD_Group");

            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GnameBn)
                .HasMaxLength(200)
                .HasColumnName("GNameBn");
        });

        modelBuilder.Entity<HrdManpowerStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_ManpowerStatus");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdMonthNameBangla>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_MonthNameBangla");

            entity.Property(e => e.MonthId)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.MonthName).HasMaxLength(20);
        });

        modelBuilder.Entity<HrdOthersSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_OthersSetting");

            entity.Property(e => e.AcceptableMinuteasOt)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("AcceptableMinuteasOT");
            entity.Property(e => e.BreakBeforeStartOtasMin)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("BreakBeforeStartOTAsMin");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.MinOverTimeHour)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MinOverTimeMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MinWorkingHour)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MinWorkingMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.StaffHolidayTotalHour)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.StaffHolidayTotalMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.StaffNightBillHour)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.StaffNightBillMni)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.StaffTiffinHour)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.StaffTiffinMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.WorkerNightBillHour)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.WorkerNightBillMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.WorkerTiffinHour)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.WorkerTiffinMin)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdPunishmentType>(entity =>
        {
            entity.HasKey(e => e.PtId);

            entity.ToTable("HRD_PunishmentType");

            entity.Property(e => e.PtId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PtName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdQualification>(entity =>
        {
            entity.HasKey(e => e.Qid);

            entity.ToTable("HRD_Qualification");

            entity.Property(e => e.Qid).HasColumnName("QId");
            entity.Property(e => e.Qname)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("QName");
            entity.Property(e => e.QnameBn)
                .HasMaxLength(300)
                .HasColumnName("QNameBn");
        });

        modelBuilder.Entity<HrdReligion>(entity =>
        {
            entity.HasKey(e => e.Rname).HasName("PK_HRD_Religion_1");

            entity.ToTable("HRD_Religion");

            entity.Property(e => e.Rname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RName");
            entity.Property(e => e.Rid)
                .ValueGeneratedOnAdd()
                .HasColumnName("RId");
            entity.Property(e => e.RnameBn)
                .HasMaxLength(50)
                .HasColumnName("RNameBn");
        });

        modelBuilder.Entity<HrdSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_Sheets");

            entity.Property(e => e.Sheet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SheetTitle)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdShift>(entity =>
        {
            entity.HasKey(e => e.SftId);

            entity.ToTable("HRD_Shift");

            entity.Property(e => e.AcceptableTimeAsOt).HasColumnName("AcceptableTimeAsOT");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.SftEndTimeIndicator)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SftNameBangla).HasMaxLength(50);
            entity.Property(e => e.SftStartTimeIndicator)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdShiftDateLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_Shift_DateLog");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdSignaturesOfSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_SignaturesOfSheets");

            entity.Property(e => e.Sheet).HasMaxLength(100);
            entity.Property(e => e.Signature).HasMaxLength(100);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<HrdSpecialTimetable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_SpecialTimetable");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Purpose)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<HrdSpecialTimetableOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_SpecialTimetable_old");

            entity.Property(e => e.AcceptableTimeAsOt).HasColumnName("AcceptableTimeAsOT");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftEndTimeIndicator)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.SftStartTimeIndicator)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdSubDepartmentInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_SubDepartmentInfo");
        });

        modelBuilder.Entity<HrdWeekendSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HRD_WeekendSettings");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HrdthanaInfo>(entity =>
        {
            entity.HasKey(e => e.ThaId);

            entity.ToTable("HRDThanaInfo");

            entity.HasIndex(e => e.ThaName, "ThanaNameForUnique").IsUnique();

            entity.Property(e => e.ThaName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ThaNameBangla).HasMaxLength(50);

            entity.HasOne(d => d.Dst).WithMany(p => p.HrdthanaInfos)
                .HasForeignKey(d => d.DstId)
                .HasConstraintName("FK_HRDThanaInfo_HRDThanaInfo");
        });

        modelBuilder.Entity<JobCardActual>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("JobCardActual");

            entity.Property(e => e.Attdate)
                .HasColumnType("datetime")
                .HasColumnName("ATTDate");
            entity.Property(e => e.Attstatus)
                .HasMaxLength(15)
                .HasColumnName("ATTStatus");
            entity.Property(e => e.Dname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DName");
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InHour).HasMaxLength(2);
            entity.Property(e => e.InMin).HasMaxLength(2);
            entity.Property(e => e.InSec).HasMaxLength(2);
            entity.Property(e => e.LateBy).HasMaxLength(8);
            entity.Property(e => e.LnCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MonthName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OutHour).HasMaxLength(2);
            entity.Property(e => e.OutMin).HasMaxLength(2);
            entity.Property(e => e.OutSec).HasMaxLength(2);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.StateStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StayTime)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeaveApplyDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Leave_ApplyDate");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lacode).HasColumnName("LACode");
            entity.Property(e => e.LvAppId)
                .ValueGeneratedOnAdd()
                .HasColumnName("Lv_app_Id");
            entity.Property(e => e.LvDate).HasColumnName("Lv_date");
        });

        modelBuilder.Entity<LeaveApprovalLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Leave_ApprovalLog");

            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.Lacode).HasColumnName("LACode");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<LeaveDeptWiseWeekend>(entity =>
        {
            entity.HasKey(e => e.Wdid);

            entity.ToTable("Leave_DeptWiseWeekend");

            entity.Property(e => e.Wdid).HasColumnName("WDid");
        });

        modelBuilder.Entity<LeaveLastEarnLeaveDateLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Leave_LastEarnLeaveDateLog");

            entity.Property(e => e.EmpId)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeaveLeaveApplication>(entity =>
        {
            entity.HasKey(e => new { e.FromDate, e.EmpId }).HasName("PK_Leave_LeaveApplication_1");

            entity.ToTable("Leave_LeaveApplication");

            entity.HasIndex(e => e.Lacode, "IX_Leave_LeaveApplication").IsUnique();

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Lacode)
                .ValueGeneratedOnAdd()
                .HasColumnName("LACode");
            entity.Property(e => e.LeaveFormSlno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LeaveFormSLNo");
            entity.Property(e => e.LvAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LvContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.EmpType).WithMany(p => p.LeaveLeaveApplications)
                .HasForeignKey(d => d.EmpTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Leave_LeaveApplication_HRD_EmployeeType");

            entity.HasOne(d => d.Leave).WithMany(p => p.LeaveLeaveApplications)
                .HasForeignKey(d => d.LeaveId)
                .HasConstraintName("FK_Leave_LeaveApplication_tblLeaveConfig");
        });

        modelBuilder.Entity<LeaveLeaveApplicationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Leave_LeaveApplicationDetails");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lacode).HasColumnName("LACode");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.LacodeNavigation).WithMany()
                .HasPrincipalKey(p => p.Lacode)
                .HasForeignKey(d => d.Lacode)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Leave_LeaveApplicationDetails_Leave_LeaveApplication");
        });

        modelBuilder.Entity<LeaveLeaveApplicationLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Leave_LeaveApplication_Log");

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedRejected)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Lacode).HasColumnName("LACode");
            entity.Property(e => e.LeaveFormSlno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LeaveFormSLNo");
            entity.Property(e => e.LvAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LvContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeaveLeaveType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Leave_LeaveType");

            entity.Property(e => e.LeaveName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeaveNameId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("LeaveNameID");
            entity.Property(e => e.LeaveShortName)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeaveMaterintyVoucher>(entity =>
        {
            entity.HasKey(e => e.MlvoucherNo);

            entity.ToTable("Leave_MaterintyVoucher");

            entity.Property(e => e.MlvoucherNo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MLVoucherNo");
            entity.Property(e => e.EmpId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<LeaveMaterintyVoucherDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Leave_MaterintyVoucher_Details");

            entity.Property(e => e.MlvoucherNo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MLVoucherNo");
            entity.Property(e => e.MonthId)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.MlvoucherNoNavigation).WithMany()
                .HasForeignKey(d => d.MlvoucherNo)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Leave_MaterintyVoucher_Details_Leave_MaterintyVoucher");
        });

        modelBuilder.Entity<LeaveMaternityLeavePayment>(entity =>
        {
            entity.HasKey(e => e.MateId);

            entity.ToTable("Leave_MaternityLeavePayment");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentAmount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsedLeave)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeaveShortLeave>(entity =>
        {
            entity.HasKey(e => e.SrLvId);

            entity.ToTable("Leave_ShortLeave");

            entity.Property(e => e.SrLvId).HasColumnName("SrLvID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LeaveId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LeaveID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeaveSignatureOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Leave_SignatureOrder");

            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<LeaveWeekend>(entity =>
        {
            entity.HasKey(e => e.Wid);

            entity.ToTable("Leave_Weekend");

            entity.Property(e => e.Did).HasColumnName("DId");
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeaveYearlyEarnLeaveGeneration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Leave_YearlyEarnLeaveGeneration");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EldateForReport).HasColumnName("ELDateForReport");
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<Machine>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CommPassword).HasMaxLength(12);
            entity.Property(e => e.Fingercount).HasColumnName("fingercount");
            entity.Property(e => e.FirmwareVersion).HasMaxLength(20);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .HasColumnName("IP");
            entity.Property(e => e.IsAndroid).HasMaxLength(1);
            entity.Property(e => e.MachineAlias).HasMaxLength(20);
            entity.Property(e => e.Managercount).HasColumnName("managercount");
            entity.Property(e => e.PhotoStamp).HasMaxLength(20);
            entity.Property(e => e.ProductType).HasMaxLength(20);
            entity.Property(e => e.Pushver).HasColumnName("pushver");
            entity.Property(e => e.Sn)
                .HasMaxLength(20)
                .HasColumnName("sn");
            entity.Property(e => e.Uilanguage).HasColumnName("UILanguage");
            entity.Property(e => e.Usercount).HasColumnName("usercount");
        });

        modelBuilder.Entity<MailChatInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Mail_ChatInfo");

            entity.Property(e => e.Cdate).HasColumnName("CDate");
            entity.Property(e => e.Cid)
                .ValueGeneratedOnAdd()
                .HasColumnName("CId");
            entity.Property(e => e.Ctime).HasColumnName("CTime");
            entity.Property(e => e.Text).HasColumnType("text");
        });

        modelBuilder.Entity<MailComplainInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Mail_Complain_Info");

            entity.Property(e => e.Cdate).HasColumnName("CDate");
            entity.Property(e => e.ComId).ValueGeneratedOnAdd();
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ctime).HasColumnName("CTime");
            entity.Property(e => e.Details).HasMaxLength(2000);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModuleType)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MailComposeMailInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Mail_ComposeMail_Info");

            entity.Property(e => e.Cdate).HasColumnName("CDate");
            entity.Property(e => e.ComposeMailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ComposeMail_Id");
            entity.Property(e => e.Ctime).HasColumnName("CTime");
            entity.Property(e => e.Details).HasMaxLength(2000);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RxCompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TxCompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ModulePageInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ModulePageInfo");

            entity.Property(e => e.ModuleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModulePageName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.PageTitle)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MonthlyAttendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MonthlyAttendance");

            entity.Property(e => e.Ad).HasColumnName("AD");
            entity.Property(e => e.Cl).HasColumnName("CL");
            entity.Property(e => e.Day1)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day1");
            entity.Property(e => e.Day10)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day10");
            entity.Property(e => e.Day11)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day11");
            entity.Property(e => e.Day12)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day12");
            entity.Property(e => e.Day13)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day13");
            entity.Property(e => e.Day14)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day14");
            entity.Property(e => e.Day15)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day15");
            entity.Property(e => e.Day16)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day16");
            entity.Property(e => e.Day17)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day17");
            entity.Property(e => e.Day18)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day18");
            entity.Property(e => e.Day19)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day19");
            entity.Property(e => e.Day2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day2");
            entity.Property(e => e.Day20)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day20");
            entity.Property(e => e.Day21)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day21");
            entity.Property(e => e.Day22)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day22");
            entity.Property(e => e.Day23)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day23");
            entity.Property(e => e.Day24)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day24");
            entity.Property(e => e.Day25)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day25");
            entity.Property(e => e.Day26)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day26");
            entity.Property(e => e.Day27)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day27");
            entity.Property(e => e.Day28)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day28");
            entity.Property(e => e.Day29)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day29");
            entity.Property(e => e.Day3)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day3");
            entity.Property(e => e.Day30)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day30");
            entity.Property(e => e.Day31)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day31");
            entity.Property(e => e.Day4)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day4");
            entity.Property(e => e.Day5)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day5");
            entity.Property(e => e.Day6)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day6");
            entity.Property(e => e.Day7)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day7");
            entity.Property(e => e.Day8)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day8");
            entity.Property(e => e.Day9)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day9");
            entity.Property(e => e.El).HasColumnName("EL");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pd).HasColumnName("PD");
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<MonthlyManpower>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MonthlyManpower");

            entity.Property(e => e.MonthName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nfemale).HasColumnName("NFemale");
            entity.Property(e => e.Nmale).HasColumnName("NMale");
            entity.Property(e => e.Pfemale).HasColumnName("PFemale");
            entity.Property(e => e.Pmale).HasColumnName("PMale");
            entity.Property(e => e.PtotalManpower).HasColumnName("PTotalManpower");
            entity.Property(e => e.Rfemale).HasColumnName("RFemale");
            entity.Property(e => e.Rmale).HasColumnName("RMale");
            entity.Property(e => e.Sfemale).HasColumnName("SFemale");
            entity.Property(e => e.Smale).HasColumnName("SMale");
        });

        modelBuilder.Entity<MonthlyOt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MonthlyOT");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ot1).HasColumnName("OT1");
            entity.Property(e => e.Ot2).HasColumnName("OT2");
        });

        modelBuilder.Entity<NumRun>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NUM_RUN");

            entity.Property(e => e.Cyle).HasColumnName("CYLE");
            entity.Property(e => e.Enddate)
                .HasColumnType("datetime")
                .HasColumnName("ENDDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("NAME");
            entity.Property(e => e.NumRunid).HasColumnName("NUM_RUNID");
            entity.Property(e => e.Oldid).HasColumnName("OLDID");
            entity.Property(e => e.Startdate)
                .HasColumnType("datetime")
                .HasColumnName("STARTDATE");
            entity.Property(e => e.Units).HasColumnName("UNITS");
        });

        modelBuilder.Entity<NumRunDeil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NUM_RUN_DEIL");

            entity.Property(e => e.Edays).HasColumnName("EDAYS");
            entity.Property(e => e.Endtime)
                .HasColumnType("datetime")
                .HasColumnName("ENDTIME");
            entity.Property(e => e.NumRunid).HasColumnName("NUM_RUNID");
            entity.Property(e => e.Schclassid).HasColumnName("SCHCLASSID");
            entity.Property(e => e.Sdays).HasColumnName("SDAYS");
            entity.Property(e => e.Starttime)
                .HasColumnType("datetime")
                .HasColumnName("STARTTIME");
        });

        modelBuilder.Entity<PayrollAdvanceDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_AdvanceDetails");

            entity.Property(e => e.AdvanceId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InstallmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InstallmentMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Advance).WithMany()
                .HasForeignKey(d => d.AdvanceId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payroll_AdvanceDetails_Payroll_AdvanceInfo");
        });

        modelBuilder.Entity<PayrollAdvanceInfo>(entity =>
        {
            entity.HasKey(e => e.AdvanceId);

            entity.ToTable("Payroll_AdvanceInfo");

            entity.Property(e => e.AdvanceId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AdvanceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InstallmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.Company).WithMany(p => p.PayrollAdvanceInfos)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payroll_AdvanceInfo_HRD_CompanyInfo");
        });

        modelBuilder.Entity<PayrollAdvanceSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_AdvanceSetting");

            entity.Property(e => e.AdvanceId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InstallmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidMonth)
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.HasOne(d => d.Advance).WithMany()
                .HasForeignKey(d => d.AdvanceId)
                .HasConstraintName("FK_Payroll_AdvanceSetting_Payroll_AdvanceInfo");
        });

        modelBuilder.Entity<PayrollAllowanceCalculationSetting>(entity =>
        {
            entity.HasKey(e => e.AlCalId).HasName("PK_AllowanceCalculationSetting");

            entity.ToTable("Payroll_AllowanceCalculationSetting");

            entity.Property(e => e.BasicAllowance).HasDefaultValue((byte)0);
            entity.Property(e => e.CalculationType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayrollBonusMonthSetup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_BonusMonthSetup");

            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.BonusType)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.EquivalentMonth)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.GenerateOn)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.SetupedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.SlabType)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.BidNavigation).WithMany()
                .HasForeignKey(d => d.Bid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payroll_BonusMonthSetup_Payroll_BonusSetup");
        });

        modelBuilder.Entity<PayrollBonusMonthSetup1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_BonusMonthSetup1");

            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.BonusType)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.EquivalentMonth)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.GenerateOn)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.SetupedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.SlabType)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.BidNavigation).WithMany()
                .HasForeignKey(d => d.Bid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payroll_BonusMonthSetup1_Payroll_BonusSetup");
        });

        modelBuilder.Entity<PayrollBonusSetup>(entity =>
        {
            entity.HasKey(e => e.Bid);

            entity.ToTable("Payroll_BonusSetup");

            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.BonusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Rid).HasColumnName("RId");

            entity.HasOne(d => d.Company).WithMany(p => p.PayrollBonusSetups)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payroll_BonusSetup_HRD_CompanyInfo");
        });

        modelBuilder.Entity<PayrollBonusSetup1>(entity =>
        {
            entity.HasKey(e => e.Bid);

            entity.ToTable("Payroll_BonusSetup1");

            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.BonusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Rid).HasColumnName("RId");

            entity.HasOne(d => d.Company).WithMany(p => p.PayrollBonusSetup1s)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payroll_BonusSetup1_HRD_CompanyInfo");
        });

        modelBuilder.Entity<PayrollEarnLeavePaymentSheet>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Payroll_EarnLeavePaymentSheet");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GenerateTime).HasColumnType("datetime");
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayrollEarnLeavePaymentSheet1>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("Payroll_EarnLeavePaymentSheet1");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GenerateTime).HasColumnType("datetime");
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayrollHolidayAllowanceGenerate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_HolidayAllowanceGenerate");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hdate).HasColumnName("HDate");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<PayrollHolidayWeekendBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_HolidayWeekendBill");

            entity.Property(e => e.Did)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DId");
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.InHour)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.InMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LnId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.OutHour)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OutMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
            entity.Property(e => e.StayTime)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.TotalWorkHour)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TotalWorkMin)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayrollLoanDetail>(entity =>
        {
            entity.HasKey(e => e.LoanDetailsId);

            entity.ToTable("Payroll_LoanDetails");

            entity.Property(e => e.LoanDetailsId).HasColumnName("LoanDetailsID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedReason).HasMaxLength(500);
            entity.Property(e => e.LoanId).HasColumnName("LoanID");
            entity.Property(e => e.ParticularRemarks).HasMaxLength(500);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

            entity.HasOne(d => d.Loan).WithMany(p => p.PayrollLoanDetails)
                .HasForeignKey(d => d.LoanId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payroll_LoanDetails_Payroll_LoanInfo");
        });

        modelBuilder.Entity<PayrollLoanInfo>(entity =>
        {
            entity.HasKey(e => e.LoanId);

            entity.ToTable("Payroll_LoanInfo");

            entity.Property(e => e.LoanId).HasColumnName("LoanID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedReason).HasMaxLength(500);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ExemptionReason).HasMaxLength(500);
            entity.Property(e => e.StatusUpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<PayrollLoanMonthlySetup>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.Month });

            entity.ToTable("Payroll_LoanMonthlySetup");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.LoanId).HasColumnName("LoanID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<PayrollMonthlyNoteAmount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_MonthlyNoteAmount");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MonthName)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<PayrollMonthlySalarySheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_MonthlySalarySheet");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ExtraOtamount).HasColumnName("ExtraOTAmount");
            entity.Property(e => e.ExtraOthour).HasColumnName("ExtraOTHour");
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lwp).HasColumnName("LWP");
            entity.Property(e => e.NetPayableWithAllOtamt).HasColumnName("NetPayableWithAllOTAmt");
            entity.Property(e => e.OtamountForBuyer).HasColumnName("OTAmountForBuyer");
            entity.Property(e => e.OthourForBuyer).HasColumnName("OTHourForBuyer");
            entity.Property(e => e.Otrate).HasColumnName("OTRate");
            entity.Property(e => e.OverTime)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalOtamount).HasColumnName("TotalOTAmount");
            entity.Property(e => e.TotalOtherOverTime)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TotalOthour)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TotalOTHour");
            entity.Property(e => e.TotalOverTime)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayrollMonthlySalarySheet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_MonthlySalarySheet1");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ExtraOtamount).HasColumnName("ExtraOTAmount");
            entity.Property(e => e.ExtraOthour).HasColumnName("ExtraOTHour");
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lwp).HasColumnName("LWP");
            entity.Property(e => e.NetPayableWithAllOtamt).HasColumnName("NetPayableWithAllOTAmt");
            entity.Property(e => e.OtamountForBuyer).HasColumnName("OTAmountForBuyer");
            entity.Property(e => e.OthourForBuyer).HasColumnName("OTHourForBuyer");
            entity.Property(e => e.Otrate).HasColumnName("OTRate");
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sl).ValueGeneratedOnAdd();
            entity.Property(e => e.TotalOtamount).HasColumnName("TotalOTAmount");
            entity.Property(e => e.TotalOtherOverTime)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TotalOthour)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TotalOTHour");
            entity.Property(e => e.TotalOverTime)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PayrollOfficeIsGarment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_Office_IsGarments");
        });

        modelBuilder.Entity<PayrollOthersPay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_OthersPay");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Oppurpose)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OPpurpose");
            entity.Property(e => e.Opsn)
                .ValueGeneratedOnAdd()
                .HasColumnName("OPSN");
        });

        modelBuilder.Entity<PayrollPunishment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_Punishment");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MonthName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pamount).HasColumnName("PAmount");
            entity.Property(e => e.Pname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PName");
            entity.Property(e => e.Psn)
                .ValueGeneratedOnAdd()
                .HasColumnName("PSN");
        });

        modelBuilder.Entity<PayrollYearlyBonusSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_YearlyBonusSheet");

            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.BonusType)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EditStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GenerateOn)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.BidNavigation).WithMany()
                .HasForeignKey(d => d.Bid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payroll_YearlyBonusSheet_Payroll_BonusSetup");
        });

        modelBuilder.Entity<PayrollYearlyBonusSheet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Payroll_YearlyBonusSheet1");

            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.BonusType)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EditStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GenerateOn)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.BidNavigation).WithMany()
                .HasForeignKey(d => d.Bid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payroll_YearlyBonusSheet1_Payroll_BonusSetup");
        });

        modelBuilder.Entity<PersonnelEmergencyContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Personnel_EmergencyContact");

            entity.HasIndex(e => e.EmpId, "IX_Personnel_EmergencyContact").IsUnique();

            entity.Property(e => e.Age)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyPhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpRelation)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.JobDescription)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Emp).WithOne()
                .HasForeignKey<PersonnelEmergencyContact>(d => d.EmpId)
                .HasConstraintName("FK_Personnel_EmergencyContact_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<PersonnelEmpAddress>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("Personnel_EmpAddress");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PerPo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PerPO");
            entity.Property(e => e.PerPobangla)
                .HasMaxLength(50)
                .HasColumnName("PerPOBangla");
            entity.Property(e => e.PerPostBox)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PerVillage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PerVillageBangla).HasMaxLength(50);
            entity.Property(e => e.PrePo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PrePO");
            entity.Property(e => e.PrePobangla)
                .HasMaxLength(50)
                .HasColumnName("PrePOBangla");
            entity.Property(e => e.PrePostBox)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreVillage)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.PreVillageBangla).HasMaxLength(50);

            entity.HasOne(d => d.Emp).WithOne(p => p.PersonnelEmpAddress)
                .HasForeignKey<PersonnelEmpAddress>(d => d.EmpId)
                .HasConstraintName("FK_Personnel_EmpAddress_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<PersonnelEmpCommonIncrement>(entity =>
        {
            entity.HasKey(e => e.CommonIncId).HasName("PK_Personnel_CommonIncrement");

            entity.ToTable("Personnel_EmpCommonIncrement");

            entity.Property(e => e.AmountPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<PersonnelEmpCurrentStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Personnel_EmpCurrentStatus");

            entity.Property(e => e.AttendanceBonus).HasDefaultValue(0.0);
            entity.Property(e => e.BasicSalary).HasDefaultValue(0.0);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ConvenceAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.DormitoryRent).HasDefaultValue(0.0);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.DsgId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpAccountNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpDutyType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpPresentSalary).HasDefaultValue(0.0);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FoodAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.HolidayAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.HouseRent).HasDefaultValue(0.0);
            entity.Property(e => e.IncomeTax).HasDefaultValue(0.0);
            entity.Property(e => e.IncrementAmount).HasDefaultValue(0.0);
            entity.Property(e => e.IsActive).HasDefaultValue((short)1);
            entity.Property(e => e.IsSingleRateOt).HasColumnName("IsSingleRateOT");
            entity.Property(e => e.LunchAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.LunchCount).HasDefaultValue(false);
            entity.Property(e => e.MedicalAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.NightAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OthersAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.Pfamount)
                .HasDefaultValue(0.0)
                .HasColumnName("PFAmount");
            entity.Property(e => e.PreAttendanceBonus).HasDefaultValue(0.0);
            entity.Property(e => e.PreBasicSalary).HasDefaultValue(0.0);
            entity.Property(e => e.PreCompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PreConvenceAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreDptId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.PreDsgId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.PreEmpDutyType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.PreEmpSalary).HasDefaultValue(0.0);
            entity.Property(e => e.PreEmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.PreFoodAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreGid).HasColumnName("PreGId");
            entity.Property(e => e.PreGrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PreHolidayAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreHouseRent).HasDefaultValue(0.0);
            entity.Property(e => e.PreIncomeTax).HasDefaultValue(0.0);
            entity.Property(e => e.PreIncrementAmount).HasDefaultValue(0.0);
            entity.Property(e => e.PreLunchAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreMedicalAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreNightAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreOthersAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreSalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PreShiftTransferDate).HasColumnType("datetime");
            entity.Property(e => e.PreTechnicalAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreTiffinAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SalaryCount).HasDefaultValue(false);
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ShiftTransferDate).HasColumnType("datetime");
            entity.Property(e => e.Sn)
                .ValueGeneratedOnAdd()
                .HasColumnName("SN");
            entity.Property(e => e.TechnicalAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.TiffinAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.Tin)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.Emp).WithMany()
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Personnel_EmpCurrentStatus_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<PersonnelEmpCurrentStatus1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Personnel_EmpCurrentStatus1");

            entity.Property(e => e.AttendanceBonus).HasDefaultValue(0.0);
            entity.Property(e => e.BasicSalary).HasDefaultValue(0.0);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ConvenceAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.DormitoryRent).HasDefaultValue(0.0);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.DsgId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpAccountNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpDutyType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpPresentSalary).HasDefaultValue(0.0);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FoodAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.HolidayAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.HouseRent).HasDefaultValue(0.0);
            entity.Property(e => e.IncomeTax).HasDefaultValue(0.0);
            entity.Property(e => e.IncrementAmount).HasDefaultValue(0.0);
            entity.Property(e => e.IsActive).HasDefaultValue((short)1);
            entity.Property(e => e.IsSingleRateOt).HasColumnName("IsSingleRateOT");
            entity.Property(e => e.LunchAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.LunchCount).HasDefaultValue(false);
            entity.Property(e => e.MedicalAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.NightAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OthersAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.Pfamount)
                .HasDefaultValue(0.0)
                .HasColumnName("PFAmount");
            entity.Property(e => e.PreAttendanceBonus).HasDefaultValue(0.0);
            entity.Property(e => e.PreBasicSalary).HasDefaultValue(0.0);
            entity.Property(e => e.PreCompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PreConvenceAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreDptId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.PreDsgId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.PreEmpDutyType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.PreEmpSalary).HasDefaultValue(0.0);
            entity.Property(e => e.PreEmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.PreFoodAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreGid).HasColumnName("PreGId");
            entity.Property(e => e.PreGrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PreHolidayAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreHouseRent).HasDefaultValue(0.0);
            entity.Property(e => e.PreIncomeTax).HasDefaultValue(0.0);
            entity.Property(e => e.PreIncrementAmount).HasDefaultValue(0.0);
            entity.Property(e => e.PreLunchAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreMedicalAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreNightAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreOthersAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreSalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PreShiftTransferDate).HasColumnType("datetime");
            entity.Property(e => e.PreTechnicalAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.PreTiffinAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SalaryCount).HasDefaultValue(false);
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ShiftTransferDate).HasColumnType("datetime");
            entity.Property(e => e.Sn)
                .ValueGeneratedOnAdd()
                .HasColumnName("SN");
            entity.Property(e => e.TechnicalAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.TiffinAllownce).HasDefaultValue(0.0);
            entity.Property(e => e.Tin)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.Emp).WithMany()
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Personnel_EmpCurrentStatus1_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<PersonnelEmpCurrentStatusPromotionLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Personnel_EmpCurrentStatusPromotionLog");

            entity.Property(e => e.Did)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DId");
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FId");
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LnId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PersonnelEmpCurrentStatusSalaryIncrementLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Personnel_EmpCurrentStatusSalaryIncrementLog");

            entity.Property(e => e.Did)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DId");
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FId");
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LnId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PersonnelEmpEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Personnel_EmpEducation");

            entity.Property(e => e.Degree)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Institute)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Result)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Sn)
                .ValueGeneratedOnAdd()
                .HasColumnName("SN");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.HasOne(d => d.Emp).WithMany()
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Personnel_EmpEducation_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<PersonnelEmpExperience>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Personnel_EmpExperience");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Responsibility)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn)
                .ValueGeneratedOnAdd()
                .HasColumnName("SN");
            entity.Property(e => e.SpecialQualification)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.YearOfExp)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Emp).WithMany()
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Personnel_EmpExperience_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<PersonnelEmpPersonnal>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("Personnel_EmpPersonnal");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Age)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.FatherName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FatherNameBn).HasMaxLength(150);
            entity.Property(e => e.Height).HasMaxLength(50);
            entity.Property(e => e.LastEdQualification)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MaritialStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MotherName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MotherNameBn)
                .HasMaxLength(150)
                .HasColumnName("MotherNameBN");
            entity.Property(e => e.NationIdcardNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NationIDCardNo");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoOfExperience)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PlaceOfBirth)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Qid).HasColumnName("QId");
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.Weight)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Emp).WithOne(p => p.PersonnelEmpPersonnal)
                .HasForeignKey<PersonnelEmpPersonnal>(d => d.EmpId)
                .HasConstraintName("FK_Personnel_EmpPersonnal_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<PersonnelEmpProximityChangeLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Personnel_EmpProximityChange_Log");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<PersonnelEmpPunismentInfo>(entity =>
        {
            entity.HasKey(e => e.EmpPunismentId);

            entity.ToTable("Personnel_EmpPunismentInfo");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpPunismentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmpPunismentOrderRef).HasMaxLength(50);
            entity.Property(e => e.EmpRemarks).HasMaxLength(120);
            entity.Property(e => e.PtId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Pt).WithMany(p => p.PersonnelEmpPunismentInfos)
                .HasForeignKey(d => d.PtId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Personnel_EmpPunismentInfo_HRD_PunishmentType");
        });

        modelBuilder.Entity<PersonnelEmpRejoin>(entity =>
        {
            entity.HasKey(e => e.EmpRejoinId);

            entity.ToTable("Personnel_EmpRejoin");

            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PersonnelEmpSeparation>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.EffectiveDate }).HasName("PK_Personnel_EmpSeparation_1");

            entity.ToTable("Personnel_EmpSeparation");

            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpSeparationId).ValueGeneratedOnAdd();
            entity.Property(e => e.Remarks)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.SeparationType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PersonnelEmpSeparation1>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.EffectiveDate }).HasName("PK_Personnel_EmpSeparation_2");

            entity.ToTable("Personnel_EmpSeparation1");

            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpSeparationId).ValueGeneratedOnAdd();
            entity.Property(e => e.Remarks)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.SeparationType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PersonnelEmployeeInfo>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK_Personnel_EmployeeInfo1");

            entity.ToTable("Personnel_EmployeeInfo");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.BonusType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpAccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpPicture)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NickName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pfamount).HasColumnName("PFAmount");
            entity.Property(e => e.RealProximityNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SalaryCount)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.SignatureImage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WagesType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WeekendType)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PersonnelSeparationActivation1Log>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Personnel_SeparationActivation1_Log");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<PersonnelSeparationActivationLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Personnel_SeparationActivation_Log");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<PersonnelWorkerCardNoSequence>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Personnel_WorkerCardNoSequence");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PfActivityLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PF_Activity_log");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pfamount).HasColumnName("PFAmount");
            entity.Property(e => e.Pfdate).HasColumnName("PFDate");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<PfCalculationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PF_CalculationDetails");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmprContributionPer)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MonthName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PfcSn)
                .ValueGeneratedOnAdd()
                .HasColumnName("PFC_SN");
        });

        modelBuilder.Entity<PfCalculationSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PF_CalculationSetting");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PempEmprEndyear).HasColumnName("PEmpEmprEndyear");
            entity.Property(e => e.PempEmprIrstEndyear).HasColumnName("PEmpEmprIrstEndyear");
            entity.Property(e => e.PempEmprIrstStartyear).HasColumnName("PEmpEmprIrstStartyear");
            entity.Property(e => e.PempEmprStartyear).HasColumnName("PEmpEmprStartyear");
            entity.Property(e => e.PempPartEndyear).HasColumnName("PEmpPartEndyear");
            entity.Property(e => e.PempPartStartyear).HasColumnName("PEmpPartStartyear");
            entity.Property(e => e.PfstartYear).HasColumnName("PFStartYear");
        });

        modelBuilder.Entity<PfCompanyInfo>(entity =>
        {
            entity.HasKey(e => e.PfcompanyId).HasName("PK_PF_CompanyId");

            entity.ToTable("PF_CompanyInfo");

            entity.Property(e => e.PfcompanyId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("PFCompanyId");
            entity.Property(e => e.Pfaddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PFAddress");
            entity.Property(e => e.PfcompanyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PFCompanyName");
        });

        modelBuilder.Entity<PfCompanyRelation>(entity =>
        {
            entity.HasKey(e => new { e.PfcompanyId, e.ProductId, e.ProductDb }).HasName("PK_PF_CompanyInfo");

            entity.ToTable("PF_CompanyRelation");

            entity.Property(e => e.PfcompanyId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("PFCompanyId");
            entity.Property(e => e.ProductId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ProductDb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProductDB");
            entity.Property(e => e.ShortCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.Pfcompany).WithMany(p => p.PfCompanyRelations)
                .HasForeignKey(d => d.PfcompanyId)
                .HasConstraintName("FK_PF_CompanyRelation_PF_CompanyRelation");
        });

        modelBuilder.Entity<PfExpense>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.Month }).HasName("PK_Table_1");

            entity.ToTable("PF_Expense");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.Emp).WithMany(p => p.PfExpenses)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_Table_1_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<PfFdr>(entity =>
        {
            entity.HasKey(e => e.FdrId);

            entity.ToTable("PF_FDR");

            entity.HasIndex(e => e.FdrNo, "IX_PF_FDR").IsUnique();

            entity.Property(e => e.FdrId).HasColumnName("FdrID");
            entity.Property(e => e.Bank)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Branch)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.FdrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PfFdrInterest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PF_FDR_Interest");

            entity.Property(e => e.FdrId).HasColumnName("FdrID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");

            entity.HasOne(d => d.Fdr).WithMany()
                .HasForeignKey(d => d.FdrId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PF_FDR_Interest_PF_FDR");
        });

        modelBuilder.Entity<PfInterestDistribution>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PF_Interest_Distribution");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FdrId).HasColumnName("FdrID");
        });

        modelBuilder.Entity<PfInvestmentType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PF_InvestmentType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InvestmentType)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PfPfrecord>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.Month }).HasName("PK_PF_PFRecord_1");

            entity.ToTable("PF_PFRecord");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<PfProfit>(entity =>
        {
            entity.HasKey(e => new { e.FdrId, e.EmpId, e.Month }).HasName("PK_PF_Profit_1");

            entity.ToTable("PF_Profit");

            entity.Property(e => e.FdrId).HasColumnName("FdrID");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<PfProfitDistributionLog>(entity =>
        {
            entity.HasKey(e => new { e.FdrId, e.DistributionDate });

            entity.ToTable("PF_ProfitDistribution_log");

            entity.Property(e => e.FdrId).HasColumnName("FdrID");
            entity.Property(e => e.DistributionTime).HasColumnType("datetime");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<PfWithdraw>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("PF_Withdraw");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Emp).WithOne(p => p.PfWithdraw)
                .HasForeignKey<PfWithdraw>(d => d.EmpId)
                .HasConstraintName("FK_PF_Withdraw_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<PfYearlyExpense>(entity =>
        {
            entity.HasKey(e => new { e.CompanyId, e.Date });

            entity.ToTable("PF_YearlyExpense");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<SchClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SchClass");

            entity.Property(e => e.CheckInTime1).HasColumnType("datetime");
            entity.Property(e => e.CheckInTime2).HasColumnType("datetime");
            entity.Property(e => e.CheckOutTime1).HasColumnType("datetime");
            entity.Property(e => e.CheckOutTime2).HasColumnType("datetime");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.SchClassid).HasColumnName("schClassid");
            entity.Property(e => e.SchName)
                .HasMaxLength(20)
                .HasColumnName("schName");
            entity.Property(e => e.SensorId)
                .HasMaxLength(5)
                .HasColumnName("SensorID");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ShiftTransferDetailsMissingLog>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("ShiftTransferDetailsMissingLog");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.InsertTime).HasColumnType("datetime");
            entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            entity.Property(e => e.Stid).HasColumnName("STID");

            entity.HasOne(d => d.St).WithMany(p => p.ShiftTransferDetailsMissingLogs)
                .HasForeignKey(d => d.Stid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ShiftTransferDetailsMissingLog_ShiftTransferDetailsMissingLog");
        });

        modelBuilder.Entity<ShiftTransferInfo>(entity =>
        {
            entity.HasKey(e => e.Stid);

            entity.ToTable("ShiftTransferInfo");

            entity.Property(e => e.Stid).HasColumnName("STId");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.TfromDate).HasColumnName("TFromDate");
            entity.Property(e => e.TtoDate).HasColumnName("TToDate");
        });

        modelBuilder.Entity<ShiftTransferInfoDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CompanyId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Fid).HasColumnName("FId");
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.IsWeekend).HasDefaultValue(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Sdate).HasColumnName("SDate");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.Stid).HasColumnName("STId");

            entity.HasOne(d => d.St).WithMany()
                .HasForeignKey(d => d.Stid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ShiftTransferDetails_ShiftTransferInfo");
        });

        modelBuilder.Entity<TblAttendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblAttendance");

            entity.Property(e => e.ProximityNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PunchDate)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAttendanceNotCountableLogRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblAttendance_NotCountableLogRecord");

            entity.Property(e => e.AttDate)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Reason).IsUnicode(false);
        });

        modelBuilder.Entity<TblAttendancePunchTemp>(entity =>
        {
            entity.HasKey(e => new { e.CompanyId, e.CardNo, e.PunchTime, e.ProcessingId });

            entity.ToTable("tblAttendancePunch_temp");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PunchTime).HasColumnType("datetime");
            entity.Property(e => e.ProcessingId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProcessingID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<TblAttendanceRecord>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.Attdate }).HasName("PK_tblAttendanceRecord_1");

            entity.ToTable("tblAttendanceRecord");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Attdate)
                .HasColumnType("datetime")
                .HasColumnName("ATTDate");
            entity.Property(e => e.AttManual)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Attstatus)
                .HasMaxLength(15)
                .HasColumnName("ATTStatus");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DailyStartTimeAltCloseTime)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("DailyStartTimeALT_CloseTime");
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.InHour).HasMaxLength(2);
            entity.Property(e => e.InMin).HasMaxLength(2);
            entity.Property(e => e.InSec)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Odid).HasColumnName("ODID");
            entity.Property(e => e.OutDuty).HasDefaultValue(false);
            entity.Property(e => e.OutHour)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OutMin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OutSec)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OutStatus)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ReferenceID");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StateStatus).HasMaxLength(50);

            entity.HasOne(d => d.EmpType).WithMany(p => p.TblAttendanceRecords)
                .HasForeignKey(d => d.EmpTypeId)
                .HasConstraintName("FK_tblAttendanceRecord_HRD_EmployeeType");
        });

        modelBuilder.Entity<TblAttendanceRecordPunchLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblAttendanceRecordPunchLog");

            entity.Property(e => e.AttDate).HasColumnType("datetime");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PinHour)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PInHour");
            entity.Property(e => e.PinMin)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PInMin");
            entity.Property(e => e.PinSec)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PInSec");
            entity.Property(e => e.PoutHour)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("POutHour");
            entity.Property(e => e.PoutMin)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("POutMin");
            entity.Property(e => e.PoutSec)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("POutSec");
        });

        modelBuilder.Entity<TblDailyAttendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDailyAttendance");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDepartmentWiseAttendance>(entity =>
        {
            entity.HasKey(e => e.Dwatten).HasName("PK_tblDepartmentWiseAttendance_1");

            entity.ToTable("tblDepartmentWiseAttendance");

            entity.Property(e => e.Dwatten).HasColumnName("DWAtten");
            entity.Property(e => e.AttenStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DivisionId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblEmpWiseWeekendinfo>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.Date });

            entity.ToTable("tblEmpWiseWeekendinfo");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DptID");
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DsgID");
            entity.Property(e => e.Gid).HasColumnName("GID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblEmpWiseWeekendinfos)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_tblEmpWiseWeekendinfo_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<TblGeneralDay>(entity =>
        {
            entity.HasKey(e => new { e.GeneralDay, e.CompanyId, e.EmpTypeId });

            entity.ToTable("tblGeneralDays");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<TblHolydayWeekentEmployeeWise>(entity =>
        {
            entity.HasKey(e => e.Hwcode);

            entity.ToTable("tblHolydayWeekentEmployeeWise");

            entity.Property(e => e.Hwcode).HasColumnName("HWCode");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HwdayName)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("HWDayName");
            entity.Property(e => e.Hwtype)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("HWType");
            entity.Property(e => e.IsUsed).HasDefaultValue(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblHolydayWeekentEmployeeWiseDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblHolydayWeekentEmployeeWiseDetails");

            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Hwcode).HasColumnName("HWCode");
            entity.Property(e => e.Hwdate).HasColumnName("HWDate");
            entity.Property(e => e.IsUsed).HasDefaultValue(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.HwcodeNavigation).WithMany()
                .HasForeignKey(d => d.Hwcode)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_HWCodeWithtblHolydayWeekentEmployeeWise");
        });

        modelBuilder.Entity<TblHolydayWork>(entity =>
        {
            entity.HasKey(e => new { e.Hdate, e.CompanyId });

            entity.ToTable("tblHolydayWork");

            entity.Property(e => e.Hdate).HasColumnName("HDate");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hcode)
                .ValueGeneratedOnAdd()
                .HasColumnName("HCode");

            entity.HasOne(d => d.Company).WithMany(p => p.TblHolydayWorks)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_tblHolydayWork_HRD_CompanyInfo");
        });

        modelBuilder.Entity<TblHolydayWork1>(entity =>
        {
            entity.HasKey(e => new { e.Hdate, e.CompanyId });

            entity.ToTable("tblHolydayWork1");

            entity.Property(e => e.Hdate).HasColumnName("HDate");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hcode)
                .ValueGeneratedOnAdd()
                .HasColumnName("HCode");

            entity.HasOne(d => d.Company).WithMany(p => p.TblHolydayWork1s)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_tblHolydayWork1_tblHolydayWork1");
        });

        modelBuilder.Entity<TblLeaveApproval>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblLeaveApproval");

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.DptCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.Lacode)
                .HasMaxLength(8)
                .HasColumnName("LACode");
            entity.Property(e => e.LeaveApplied).HasMaxLength(3);
            entity.Property(e => e.LeaveName).HasMaxLength(30);
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.StateRemarks).HasMaxLength(150);
            entity.Property(e => e.StateStatus).HasMaxLength(50);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblLeaveAuthorityAccessControl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblLeaveAuthorityAccessControl");

            entity.Property(e => e.AuthorityId).HasColumnName("AuthorityID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.Emp).WithMany()
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblLeaveAuthorityAccessControl_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<TblLeaveConfig>(entity =>
        {
            entity.HasKey(e => e.LeaveId).HasName("PK_LeaveConfigs");

            entity.ToTable("tblLeaveConfig");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LeaveName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeaveNature)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortName).HasMaxLength(50);

            entity.HasOne(d => d.Company).WithMany(p => p.TblLeaveConfigs)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblLeaveConfig_HRD_CompanyInfo");
        });

        modelBuilder.Entity<TblMonthSetup>(entity =>
        {
            entity.HasKey(e => e.MonthId).HasName("PK_MonthSetup");

            entity.ToTable("tblMonthSetup");

            entity.HasIndex(e => e.MonthName, "IX_tblMonthSetup_ForeignKey");

            entity.HasIndex(e => new { e.MonthName, e.CompanyId }, "UniqueMonthName").IsUnique();

            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Did)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DId");
            entity.Property(e => e.MonthName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblMonthSetup1>(entity =>
        {
            entity.HasKey(e => e.MonthId);

            entity.ToTable("tblMonthSetup1");

            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Did)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DId");
            entity.Property(e => e.MonthName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblOutDuty>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("tblOutDuty");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.AppiedDate).HasColumnType("datetime");
            entity.Property(e => e.AssignedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AuthorizedDate).HasColumnType("datetime");
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Place)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblOutDutyApprovalLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblOutDuty_ApprovalLog");

            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.Odid).HasColumnName("ODID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Od).WithMany()
                .HasForeignKey(d => d.Odid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblOutDuty_ApprovalLog_tblOutDuty");
        });

        modelBuilder.Entity<TblOutDutyAuthorityAccessControl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblOutDutyAuthorityAccessControl");

            entity.Property(e => e.AuthorityId).HasColumnName("AuthorityID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.Emp).WithMany()
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblOutDutyAuthorityAccessControl_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<TblOutdutyDetail>(entity =>
        {
            entity.HasKey(e => e.Sl);

            entity.ToTable("tblOutdutyDetails");

            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.ClientName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InTime)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Odid).HasColumnName("ODID");
            entity.Property(e => e.OutTime)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Purpose)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Od).WithMany(p => p.TblOutdutyDetails)
                .HasForeignKey(d => d.Odid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblOutdutyDetails_tblOutdutyDetails");
        });

        modelBuilder.Entity<TblReportHeading>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblReportHeading");

            entity.Property(e => e.RptAddress).HasMaxLength(200);
            entity.Property(e => e.RptCode).HasMaxLength(8);
            entity.Property(e => e.RptEmail)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.RptFax).HasMaxLength(30);
            entity.Property(e => e.RptHeader).HasMaxLength(100);
            entity.Property(e => e.RptMessage).HasMaxLength(100);
            entity.Property(e => e.RptTel).HasMaxLength(30);
        });

        modelBuilder.Entity<TblStatusJoinClose>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblStatusJoin_Close");

            entity.Property(e => e.Status)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblTarget>(entity =>
        {
            entity.HasKey(e => e.Tid);

            entity.ToTable("tblTarget");

            entity.Property(e => e.Tid).HasColumnName("TId");
            entity.Property(e => e.Did)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DId");
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempNewLeaveDateForAlter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_NewLeaveDateForAlter");

            entity.Property(e => e.Status)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempOldLeaveDateForAlter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_OldLeaveDateForAlter");

            entity.Property(e => e.Status)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Template>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMPLATE");

            entity.Property(e => e.Bitmappicture)
                .HasColumnType("image")
                .HasColumnName("BITMAPPICTURE");
            entity.Property(e => e.Bitmappicture2)
                .HasColumnType("image")
                .HasColumnName("BITMAPPICTURE2");
            entity.Property(e => e.Bitmappicture3)
                .HasColumnType("image")
                .HasColumnName("BITMAPPICTURE3");
            entity.Property(e => e.Bitmappicture4)
                .HasColumnType("image")
                .HasColumnName("BITMAPPICTURE4");
            entity.Property(e => e.DivisionFp).HasColumnName("DivisionFP");
            entity.Property(e => e.Emachinenum)
                .HasMaxLength(3)
                .HasColumnName("EMACHINENUM");
            entity.Property(e => e.Fingerid).HasColumnName("FINGERID");
            entity.Property(e => e.Template1)
                .HasColumnType("image")
                .HasColumnName("TEMPLATE");
            entity.Property(e => e.Template11)
                .HasColumnType("image")
                .HasColumnName("TEMPLATE1");
            entity.Property(e => e.Template2)
                .HasColumnType("image")
                .HasColumnName("TEMPLATE2");
            entity.Property(e => e.Template3)
                .HasColumnType("image")
                .HasColumnName("TEMPLATE3");
            entity.Property(e => e.Template4)
                .HasColumnType("image")
                .HasColumnName("TEMPLATE4");
            entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Usetype).HasColumnName("USETYPE");
        });

        modelBuilder.Entity<TotalPresentForJobCard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TotalPresentForJobCard");

            entity.Property(e => e.Absent)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Apday)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("APday");
            entity.Property(e => e.Cl)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CL");
            entity.Property(e => e.El)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("EL");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Holiday)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Ml)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ML");
            entity.Property(e => e.Present)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Si)
                .ValueGeneratedOnAdd()
                .HasColumnName("SI");
            entity.Property(e => e.Sl)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SL");
            entity.Property(e => e.Weekend)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("UserAccount");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CoockieInfo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.IsLvAuthority).HasColumnName("isLvAuthority");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LoginDateTime).HasColumnType("datetime");
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserType)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserOfRun>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USER_OF_RUN");

            entity.Property(e => e.Enddate)
                .HasColumnType("datetime")
                .HasColumnName("ENDDATE");
            entity.Property(e => e.IsnotofRun).HasColumnName("ISNOTOF_RUN");
            entity.Property(e => e.NumOfRunId).HasColumnName("NUM_OF_RUN_ID");
            entity.Property(e => e.OrderRun).HasColumnName("ORDER_RUN");
            entity.Property(e => e.Startdate)
                .HasColumnType("datetime")
                .HasColumnName("STARTDATE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<UserPrivilege>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserPrivilege");

            entity.Property(e => e.ModulePageName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<Userinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USERINFO");

            entity.Property(e => e.Att).HasColumnName("ATT");
            entity.Property(e => e.Badgenumber).HasMaxLength(24);
            entity.Property(e => e.Birthday)
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDAY");
            entity.Property(e => e.CardNo).HasMaxLength(20);
            entity.Property(e => e.City)
                .HasMaxLength(2)
                .HasColumnName("CITY");
            entity.Property(e => e.Defaultdeptid).HasColumnName("DEFAULTDEPTID");
            entity.Property(e => e.Emprivilege).HasColumnName("EMPRIVILEGE");
            entity.Property(e => e.Fphone)
                .HasMaxLength(20)
                .HasColumnName("FPHONE");
            entity.Property(e => e.Gender).HasMaxLength(8);
            entity.Property(e => e.Hiredday)
                .HasColumnType("datetime")
                .HasColumnName("HIREDDAY");
            entity.Property(e => e.Holiday).HasColumnName("HOLIDAY");
            entity.Property(e => e.Inlate).HasColumnName("INLATE");
            entity.Property(e => e.Lunchduration).HasColumnName("LUNCHDURATION");
            entity.Property(e => e.Minzu)
                .HasMaxLength(8)
                .HasColumnName("MINZU");
            entity.Property(e => e.Mverifypass)
                .HasMaxLength(10)
                .HasColumnName("mverifypass");
            entity.Property(e => e.Name).HasMaxLength(40);
            entity.Property(e => e.Notes).HasColumnType("image");
            entity.Property(e => e.Ophone)
                .HasMaxLength(20)
                .HasColumnName("OPHONE");
            entity.Property(e => e.Outearly).HasColumnName("OUTEARLY");
            entity.Property(e => e.Overtime).HasColumnName("OVERTIME");
            entity.Property(e => e.Pager)
                .HasMaxLength(20)
                .HasColumnName("PAGER");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Photo)
                .HasColumnType("image")
                .HasColumnName("PHOTO");
            entity.Property(e => e.Privilege).HasColumnName("privilege");
            entity.Property(e => e.RegisterOt).HasColumnName("RegisterOT");
            entity.Property(e => e.Securityflags).HasColumnName("SECURITYFLAGS");
            entity.Property(e => e.Sep).HasColumnName("SEP");
            entity.Property(e => e.Ssn)
                .HasMaxLength(20)
                .HasColumnName("SSN");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .HasColumnName("STATE");
            entity.Property(e => e.Street)
                .HasMaxLength(80)
                .HasColumnName("street");
            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .HasColumnName("TITLE");
            entity.Property(e => e.UseAccGroupTz).HasColumnName("UseAccGroupTZ");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.ValidTimeBegin).HasColumnType("datetime");
            entity.Property(e => e.ValidTimeEnd).HasColumnType("datetime");
            entity.Property(e => e.Verificationmethod).HasColumnName("VERIFICATIONMETHOD");
            entity.Property(e => e.Zip)
                .HasMaxLength(12)
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<UsersMachine>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Deviceid).HasColumnName("DEVICEID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<VAllOffDay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AllOffDays");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VAttBreakTime>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AttBreakTime");

            entity.Property(e => e.BreakId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BreakID");
            entity.Property(e => e.Note)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VAttendanceLateDeduction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Attendance_LateDeduction");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ldid).HasColumnName("LDId");
            entity.Property(e => e.LeaveName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ShortName).HasMaxLength(50);
        });

        modelBuilder.Entity<VAttendanceWeekendInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Attendance_WeekendInfo");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.MonthName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reason)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Weekend)
                .HasMaxLength(18)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VCheckinout>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_CHECKINOUT");

            entity.Property(e => e.Badgenumber).HasMaxLength(24);
            entity.Property(e => e.Checktime)
                .HasColumnType("datetime")
                .HasColumnName("CHECKTIME");
            entity.Property(e => e.Checktype)
                .HasColumnType("text")
                .HasColumnName("CHECKTYPE");
            entity.Property(e => e.Memoinfo).HasColumnType("text");
            entity.Property(e => e.Sensorid)
                .HasColumnType("text")
                .HasColumnName("SENSORID");
            entity.Property(e => e.Sn)
                .HasColumnType("text")
                .HasColumnName("sn");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Verifycode).HasColumnName("VERIFYCODE");
            entity.Property(e => e.WorkCode).HasColumnType("text");
        });

        modelBuilder.Entity<VDailyAttendanceSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DailyAttendanceSummary");

            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
        });

        modelBuilder.Entity<VDailyTiffinBillGenerate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DailyTiffinBillGenerate");

            entity.Property(e => e.Attdate)
                .HasColumnType("datetime")
                .HasColumnName("ATTDate");
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.LogoutTime).HasColumnType("datetime");
            entity.Property(e => e.OutTime)
                .HasMaxLength(58)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VEarnLeaveGenerateAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_EarnLeaveGenerateAccount");

            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
        });

        modelBuilder.Entity<VEarnleaveMonthlyInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Earnleave_MonthlyInfo");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.NDec).HasColumnName("nDec");
            entity.Property(e => e.PApr).HasColumnName("pApr");
            entity.Property(e => e.PAug).HasColumnName("pAug");
            entity.Property(e => e.PDec).HasColumnName("pDec");
            entity.Property(e => e.PFeb).HasColumnName("pFeb");
            entity.Property(e => e.PJan).HasColumnName("pJan");
            entity.Property(e => e.PJul).HasColumnName("pJul");
            entity.Property(e => e.PJun).HasColumnName("pJun");
            entity.Property(e => e.PMar).HasColumnName("pMar");
            entity.Property(e => e.PMay).HasColumnName("pMay");
            entity.Property(e => e.PNov).HasColumnName("pNov");
            entity.Property(e => e.POct).HasColumnName("pOct");
            entity.Property(e => e.PSep).HasColumnName("pSep");
            entity.Property(e => e.PreJan).HasColumnName("preJan");
        });

        modelBuilder.Entity<VEarnleaveMonthlyInfo1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Earnleave_MonthlyInfo1");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.NDec).HasColumnName("nDec");
            entity.Property(e => e.PApr).HasColumnName("pApr");
            entity.Property(e => e.PAug).HasColumnName("pAug");
            entity.Property(e => e.PDec).HasColumnName("pDec");
            entity.Property(e => e.PFeb).HasColumnName("pFeb");
            entity.Property(e => e.PJan).HasColumnName("pJan");
            entity.Property(e => e.PJul).HasColumnName("pJul");
            entity.Property(e => e.PJun).HasColumnName("pJun");
            entity.Property(e => e.PMar).HasColumnName("pMar");
            entity.Property(e => e.PMay).HasColumnName("pMay");
            entity.Property(e => e.PNov).HasColumnName("pNov");
            entity.Property(e => e.POct).HasColumnName("pOct");
            entity.Property(e => e.PSep).HasColumnName("pSep");
            entity.Property(e => e.PreJan).HasColumnName("preJan");
        });

        modelBuilder.Entity<VEmpContactInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_EmpContactInfo");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EmergencyAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyPhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpRelation)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
        });

        modelBuilder.Entity<VEmpRejoinSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_EmpRejoinSheet");

            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
        });

        modelBuilder.Entity<VEmployeeDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_EmployeeDetails");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.Age)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.BonusType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyLogo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.DstBangla).HasMaxLength(50);
            entity.Property(e => e.DstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpAccountNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpDutyType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpPicture)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.FatherNameBn).HasMaxLength(150);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.HouseRentPersent).HasColumnName("HouseRent_Persent");
            entity.Property(e => e.IsSingleRateOt).HasColumnName("IsSingleRateOT");
            entity.Property(e => e.JoiningMonthYear)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.LastEdQualification)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NickName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoOfExperience)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PerPobangla)
                .HasMaxLength(50)
                .HasColumnName("PerPOBangla");
            entity.Property(e => e.PerVillageBangla).HasMaxLength(50);
            entity.Property(e => e.PfPersent).HasColumnName("PF_Persent");
            entity.Property(e => e.Pfamount).HasColumnName("PFAmount");
            entity.Property(e => e.PreEmpDutyType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.PreGrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.RealProximityNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Rname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RName");
            entity.Property(e => e.RnameBn)
                .HasMaxLength(50)
                .HasColumnName("RNameBn");
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SftNameBangla).HasMaxLength(50);
            entity.Property(e => e.ShiftTransferDate).HasColumnType("datetime");
            entity.Property(e => e.SignatureImage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.ThaNameBangla).HasMaxLength(50);
            entity.Property(e => e.Tin)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.WeekendType)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VEmployeeDetails1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_EmployeeDetails1");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.Age)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.BonusType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyLogo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.DstBangla).HasMaxLength(50);
            entity.Property(e => e.DstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpAccountNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpDutyType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpPicture)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.FatherNameBn).HasMaxLength(150);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.HouseRentPersent).HasColumnName("HouseRent_Persent");
            entity.Property(e => e.IsSingleRateOt).HasColumnName("IsSingleRateOT");
            entity.Property(e => e.JoiningMonthYear)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.LastEdQualification)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NickName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoOfExperience)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PerPobangla)
                .HasMaxLength(50)
                .HasColumnName("PerPOBangla");
            entity.Property(e => e.PerVillageBangla).HasMaxLength(50);
            entity.Property(e => e.PfPersent).HasColumnName("PF_Persent");
            entity.Property(e => e.Pfamount).HasColumnName("PFAmount");
            entity.Property(e => e.PreEmpDutyType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.PreGrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.RealProximityNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Rname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RName");
            entity.Property(e => e.RnameBn)
                .HasMaxLength(50)
                .HasColumnName("RNameBn");
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SftNameBangla).HasMaxLength(50);
            entity.Property(e => e.ShiftTransferDate).HasColumnType("datetime");
            entity.Property(e => e.SignatureImage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.ThaNameBangla).HasMaxLength(50);
            entity.Property(e => e.Tin)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VEmployeeExperience>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_EmployeeExperience");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.YearOfExp)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VEmployeeProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_EmployeeProfile");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.Age)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmergencyPhoneNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpAccountNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpPicture)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpRelation)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.EmpTypeBn).HasMaxLength(12);
            entity.Property(e => e.FamilyAge)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FatherName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FatherNameBn).HasMaxLength(150);
            entity.Property(e => e.Gender)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.GrdNameBangla).HasMaxLength(50);
            entity.Property(e => e.Height).HasMaxLength(50);
            entity.Property(e => e.JobDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MaritialStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MotherName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MotherNameBn)
                .HasMaxLength(150)
                .HasColumnName("MotherNameBN");
            entity.Property(e => e.NationIdcardNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NationIDCardNo");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PerDstBangla).HasMaxLength(50);
            entity.Property(e => e.PerDstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PerPo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PerPO");
            entity.Property(e => e.PerPobangla)
                .HasMaxLength(50)
                .HasColumnName("PerPOBangla");
            entity.Property(e => e.PerPostBox)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PerThNameBn).HasMaxLength(50);
            entity.Property(e => e.PerThaName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.PerVillage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PerVillageBangla).HasMaxLength(50);
            entity.Property(e => e.PermanentAd)
                .HasMaxLength(245)
                .IsUnicode(false);
            entity.Property(e => e.PreDstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrePo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PrePO");
            entity.Property(e => e.PrePostBox)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreThaName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.PreVillage)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.PresentAd)
                .HasMaxLength(265)
                .IsUnicode(false);
            entity.Property(e => e.RealProximityNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Rname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RName");
            entity.Property(e => e.RnameBn)
                .HasMaxLength(50)
                .HasColumnName("RNameBn");
            entity.Property(e => e.SalaryCount)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SignatureImage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.Telephone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WagesType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weight)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VFirstInLastOut>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FirstInLastOut");

            entity.Property(e => e.AttDate).HasMaxLength(4000);
            entity.Property(e => e.Badgenumber).HasMaxLength(24);
            entity.Property(e => e.Intime)
                .HasMaxLength(4000)
                .HasColumnName("INTIME");
            entity.Property(e => e.Outtime)
                .HasMaxLength(4000)
                .HasColumnName("OUTTIME");
        });

        modelBuilder.Entity<VForShiftChangeReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ForShiftChangeReport");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VHrdCompanyInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_HRD_companyInfo");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.AttMachineName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BtypeName)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("BTypeName");
            entity.Property(e => e.ComType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Comments)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyLogo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DefaultCurrency)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ShortName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StartCardNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Telephone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Weekend)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VHrdDepartment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_HRD_Department");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VHrdDesignation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_HRD_Designation");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.DsgShortName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VHrdGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_HRD_Group");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GnameBn)
                .HasMaxLength(200)
                .HasColumnName("GNameBn");
        });

        modelBuilder.Entity<VHrdShift>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_HRD_Shift");

            entity.Property(e => e.AcceptableTimeAsOt).HasColumnName("AcceptableTimeAsOT");
            entity.Property(e => e.ActiveStatus)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EndPunchCountTime12Fomat)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.EndTime12Fomat)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.FromDate).HasMaxLength(4000);
            entity.Property(e => e.Notes)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Otstatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("OTStatus");
            entity.Property(e => e.PunchCountTime12Fomat)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SftNameBangla).HasMaxLength(50);
            entity.Property(e => e.StartTime12Fromat)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.ToDate).HasMaxLength(4000);
        });

        modelBuilder.Entity<VLeaveLeaveApplication>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Leave_LeaveApplication");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AuthorizedBy).HasMaxLength(4000);
            entity.Property(e => e.AuthorizedByCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.CurrentProcessStatus)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.FromYear)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.Lacode).HasColumnName("LACode");
            entity.Property(e => e.LeaveFormSlno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LeaveFormSLNo");
            entity.Property(e => e.LeaveName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LvAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LvContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.StateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToYear)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VLeaveLeaveApplicationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Leave_LeaveApplicationDetails");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FromYear)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Lacode).HasColumnName("LACode");
            entity.Property(e => e.LeaveName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortName).HasMaxLength(50);
        });

        modelBuilder.Entity<VLeaveLeaveApplicationLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Leave_LeaveApplication_Log");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedRejected)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AuthorizedBy).HasMaxLength(4000);
            entity.Property(e => e.AuthorizedByCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.CurrentProcessStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.FromYear)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.Lacode).HasColumnName("LACode");
            entity.Property(e => e.LeaveFormSlno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LeaveFormSLNo");
            entity.Property(e => e.LeaveName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LvAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LvContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NickName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.StateStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToYear)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VLeaveMaterintyVoucher>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Leave_MaterintyVoucher");

            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.MlvoucherNo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MLVoucherNo");
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VLeaveMaterintyVoucherDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Leave_MaterintyVoucher_Details");

            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.MlvoucherNo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MLVoucherNo");
            entity.Property(e => e.MonthId)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VLeaveShortLeave>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Leave_ShortLeave");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Expr1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeaveId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LeaveID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SrLvId).HasColumnName("SrLvID");
        });

        modelBuilder.Entity<VLeaveYearlyEarnLeaveGeneration>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Leave_YearlyEarnLeaveGeneration");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EldateForReport).HasColumnName("ELDateForReport");
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.GenerateMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VLineConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_LineConfig");

            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VMailChatInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Mail_ChatInfo");

            entity.Property(e => e.Cdate).HasColumnName("CDate");
            entity.Property(e => e.CdateTime)
                .HasMaxLength(4000)
                .HasColumnName("CDateTime");
            entity.Property(e => e.Cid).HasColumnName("CId");
            entity.Property(e => e.Ctime).HasColumnName("CTime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Text).HasColumnType("text");
        });

        modelBuilder.Entity<VMailComplainInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Mail_Complain_Info");

            entity.Property(e => e.Cdate).HasColumnName("CDate");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ctime).HasColumnName("CTime");
            entity.Property(e => e.Details).HasMaxLength(2000);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModuleType)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.NickName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VMailComposeMailInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Mail_ComposeMail_Info");

            entity.Property(e => e.Cdate).HasColumnName("CDate");
            entity.Property(e => e.ComposeMailId).HasColumnName("ComposeMail_Id");
            entity.Property(e => e.Ctime).HasColumnName("CTime");
            entity.Property(e => e.Details).HasMaxLength(2000);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NickName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RxCompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TxCompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VManPowerStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ManPowerStatus");

            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
        });

        modelBuilder.Entity<VManpowerProcess>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ManpowerProcess");

            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VMoanthlyAttendanceSheetReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Moanthly_Attendance_Sheet_Report");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.Lv).HasColumnName("LV");
            entity.Property(e => e.MonthlyTotalOt).HasColumnName("MonthlyTotalOT");
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e._1).HasColumnName("1");
            entity.Property(e => e._10).HasColumnName("10");
            entity.Property(e => e._10Ot).HasColumnName("10_OT");
            entity.Property(e => e._11).HasColumnName("11");
            entity.Property(e => e._11Ot).HasColumnName("11_OT");
            entity.Property(e => e._12).HasColumnName("12");
            entity.Property(e => e._12Ot).HasColumnName("12_OT");
            entity.Property(e => e._13).HasColumnName("13");
            entity.Property(e => e._13Ot).HasColumnName("13_OT");
            entity.Property(e => e._14).HasColumnName("14");
            entity.Property(e => e._14Ot).HasColumnName("14_OT");
            entity.Property(e => e._15).HasColumnName("15");
            entity.Property(e => e._15Ot).HasColumnName("15_OT");
            entity.Property(e => e._16).HasColumnName("16");
            entity.Property(e => e._16Ot).HasColumnName("16_OT");
            entity.Property(e => e._17).HasColumnName("17");
            entity.Property(e => e._17Ot).HasColumnName("17_OT");
            entity.Property(e => e._18).HasColumnName("18");
            entity.Property(e => e._18Ot).HasColumnName("18_OT");
            entity.Property(e => e._19).HasColumnName("19");
            entity.Property(e => e._19Ot).HasColumnName("19_OT");
            entity.Property(e => e._1Ot).HasColumnName("1_OT");
            entity.Property(e => e._2).HasColumnName("2");
            entity.Property(e => e._20).HasColumnName("20");
            entity.Property(e => e._20Ot).HasColumnName("20_OT");
            entity.Property(e => e._21).HasColumnName("21");
            entity.Property(e => e._21Ot).HasColumnName("21_OT");
            entity.Property(e => e._22).HasColumnName("22");
            entity.Property(e => e._22Ot).HasColumnName("22_OT");
            entity.Property(e => e._23).HasColumnName("23");
            entity.Property(e => e._23Ot).HasColumnName("23_OT");
            entity.Property(e => e._24).HasColumnName("24");
            entity.Property(e => e._24Ot).HasColumnName("24_OT");
            entity.Property(e => e._25).HasColumnName("25");
            entity.Property(e => e._25Ot).HasColumnName("25_OT");
            entity.Property(e => e._26).HasColumnName("26");
            entity.Property(e => e._26Ot).HasColumnName("26_OT");
            entity.Property(e => e._27).HasColumnName("27");
            entity.Property(e => e._27Ot).HasColumnName("27_OT");
            entity.Property(e => e._28).HasColumnName("28");
            entity.Property(e => e._28Ot).HasColumnName("28_OT");
            entity.Property(e => e._29).HasColumnName("29");
            entity.Property(e => e._29Ot).HasColumnName("29_OT");
            entity.Property(e => e._2Ot).HasColumnName("2_OT");
            entity.Property(e => e._3).HasColumnName("3");
            entity.Property(e => e._30).HasColumnName("30");
            entity.Property(e => e._30Ot).HasColumnName("30_OT");
            entity.Property(e => e._31).HasColumnName("31");
            entity.Property(e => e._31Ot).HasColumnName("31_OT");
            entity.Property(e => e._3Ot).HasColumnName("3_OT");
            entity.Property(e => e._4).HasColumnName("4");
            entity.Property(e => e._4Ot).HasColumnName("4_OT");
            entity.Property(e => e._5).HasColumnName("5");
            entity.Property(e => e._5Ot).HasColumnName("5_OT");
            entity.Property(e => e._6).HasColumnName("6");
            entity.Property(e => e._6Ot).HasColumnName("6_OT");
            entity.Property(e => e._7).HasColumnName("7");
            entity.Property(e => e._7Ot).HasColumnName("7_OT");
            entity.Property(e => e._8).HasColumnName("8");
            entity.Property(e => e._8Ot).HasColumnName("8_OT");
            entity.Property(e => e._9).HasColumnName("9");
            entity.Property(e => e._9Ot).HasColumnName("9_OT");
        });

        modelBuilder.Entity<VMonthlyAttendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MonthlyAttendance");

            entity.Property(e => e.Ad).HasColumnName("AD");
            entity.Property(e => e.Cl).HasColumnName("CL");
            entity.Property(e => e.Day1)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day1");
            entity.Property(e => e.Day10)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day10");
            entity.Property(e => e.Day11)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day11");
            entity.Property(e => e.Day12)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day12");
            entity.Property(e => e.Day13)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day13");
            entity.Property(e => e.Day14)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day14");
            entity.Property(e => e.Day15)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day15");
            entity.Property(e => e.Day16)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day16");
            entity.Property(e => e.Day17)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day17");
            entity.Property(e => e.Day18)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day18");
            entity.Property(e => e.Day19)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day19");
            entity.Property(e => e.Day2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day2");
            entity.Property(e => e.Day20)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day20");
            entity.Property(e => e.Day21)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day21");
            entity.Property(e => e.Day22)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day22");
            entity.Property(e => e.Day23)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day23");
            entity.Property(e => e.Day24)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day24");
            entity.Property(e => e.Day25)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day25");
            entity.Property(e => e.Day26)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day26");
            entity.Property(e => e.Day27)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day27");
            entity.Property(e => e.Day28)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day28");
            entity.Property(e => e.Day29)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day29");
            entity.Property(e => e.Day3)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day3");
            entity.Property(e => e.Day30)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day30");
            entity.Property(e => e.Day31)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day31");
            entity.Property(e => e.Day4)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day4");
            entity.Property(e => e.Day5)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day5");
            entity.Property(e => e.Day6)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day6");
            entity.Property(e => e.Day7)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day7");
            entity.Property(e => e.Day8)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day8");
            entity.Property(e => e.Day9)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("day9");
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.El).HasColumnName("EL");
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pd).HasColumnName("PD");
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Sn).HasColumnName("SN");
        });

        modelBuilder.Entity<VMonthlyOt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MonthlyOT");

            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ot1).HasColumnName("OT1");
            entity.Property(e => e.Ot2).HasColumnName("OT2");
            entity.Property(e => e.Sn).HasColumnName("SN");
        });

        modelBuilder.Entity<VMonthlySalaryFlowReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Monthly_Salary_Flow_Report");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Month).HasMaxLength(4000);
            entity.Property(e => e.MonthName).HasMaxLength(4000);
            entity.Property(e => e.Year).HasMaxLength(4000);
        });

        modelBuilder.Entity<VMonthlySalarySheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MonthlySalarySheet");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.BankName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EmpAccountNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExtraOtamount).HasColumnName("ExtraOTAmount");
            entity.Property(e => e.ExtraOthour).HasColumnName("ExtraOTHour");
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrdNameBangla).HasMaxLength(50);
            entity.Property(e => e.NetPayableWithAllOtamt).HasColumnName("NetPayableWithAllOTAmt");
            entity.Property(e => e.OtamountForBuyer).HasColumnName("OTAmountForBuyer");
            entity.Property(e => e.OthourForBuyer).HasColumnName("OTHourForBuyer");
            entity.Property(e => e.Otrate).HasColumnName("OTRate");
            entity.Property(e => e.OverTime)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SalaryCount)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SeparationType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SeparationTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalOtamount).HasColumnName("TotalOTAmount");
            entity.Property(e => e.TotalOtherOverTime)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TotalOthour)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TotalOTHour");
            entity.Property(e => e.TotalOverTime)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VMonthlySalarySheet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MonthlySalarySheet1");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.BankName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EmpAccountNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExtraOtamount).HasColumnName("ExtraOTAmount");
            entity.Property(e => e.ExtraOthour).HasColumnName("ExtraOTHour");
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrdNameBangla).HasMaxLength(50);
            entity.Property(e => e.NetPayableWithAllOtamt).HasColumnName("NetPayableWithAllOTAmt");
            entity.Property(e => e.OtamountForBuyer).HasColumnName("OTAmountForBuyer");
            entity.Property(e => e.OthourForBuyer).HasColumnName("OTHourForBuyer");
            entity.Property(e => e.Otrate).HasColumnName("OTRate");
            entity.Property(e => e.SalaryCount)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalOtamount).HasColumnName("TotalOTAmount");
            entity.Property(e => e.TotalOtherOverTime)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TotalOthour)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TotalOTHour");
            entity.Property(e => e.TotalOverTime)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPayrollAdvanceInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_AdvanceInfo");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AdvanceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AdvanceId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.InstallmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VPayrollAdvanceSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_AdvanceSetting");

            entity.Property(e => e.AdvanceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AdvanceId)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InstallmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VPayrollBonusMonthSetup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_BonusMonthSetup");

            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.BonusType)
                .HasMaxLength(114)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Rname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RName");
            entity.Property(e => e.SetupedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VPayrollBonusMonthSetup1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_BonusMonthSetup1");

            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.BonusType)
                .HasMaxLength(114)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Rname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RName");
            entity.Property(e => e.SetupedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VPayrollBonusSetup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_BonusSetup");

            entity.Property(e => e.Bid)
                .ValueGeneratedOnAdd()
                .HasColumnName("BId");
            entity.Property(e => e.BonusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Year)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPayrollBonusSetup1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_BonusSetup1");

            entity.Property(e => e.Bid)
                .ValueGeneratedOnAdd()
                .HasColumnName("BId");
            entity.Property(e => e.BonusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Year)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPayrollBonusSetupDistinctRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_BonusSetup_DistinctRecord");

            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.BonusType)
                .HasMaxLength(122)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPayrollBonusSetupDistinctRecord1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_BonusSetup_DistinctRecord1");

            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.BonusType)
                .HasMaxLength(122)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPayrollEarnLeavePaymentSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_EarnLeavePaymentSheet");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.GenerateTime).HasColumnType("datetime");
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NDec).HasColumnName("nDec");
            entity.Property(e => e.PApr).HasColumnName("pApr");
            entity.Property(e => e.PAug).HasColumnName("pAug");
            entity.Property(e => e.PDec).HasColumnName("pDec");
            entity.Property(e => e.PFeb).HasColumnName("pFeb");
            entity.Property(e => e.PJan).HasColumnName("pJan");
            entity.Property(e => e.PJul).HasColumnName("pJul");
            entity.Property(e => e.PJun).HasColumnName("pJun");
            entity.Property(e => e.PMar).HasColumnName("pMar");
            entity.Property(e => e.PMay).HasColumnName("pMay");
            entity.Property(e => e.PNov).HasColumnName("pNov");
            entity.Property(e => e.POct).HasColumnName("pOct");
            entity.Property(e => e.PSep).HasColumnName("pSep");
            entity.Property(e => e.PreJan).HasColumnName("preJan");
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VPayrollEarnLeavePaymentSheet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_EarnLeavePaymentSheet1");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.GenerateTime).HasColumnType("datetime");
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NDec).HasColumnName("nDec");
            entity.Property(e => e.PApr).HasColumnName("pApr");
            entity.Property(e => e.PAug).HasColumnName("pAug");
            entity.Property(e => e.PDec).HasColumnName("pDec");
            entity.Property(e => e.PFeb).HasColumnName("pFeb");
            entity.Property(e => e.PJan).HasColumnName("pJan");
            entity.Property(e => e.PJul).HasColumnName("pJul");
            entity.Property(e => e.PJun).HasColumnName("pJun");
            entity.Property(e => e.PMar).HasColumnName("pMar");
            entity.Property(e => e.PMay).HasColumnName("pMay");
            entity.Property(e => e.PNov).HasColumnName("pNov");
            entity.Property(e => e.POct).HasColumnName("pOct");
            entity.Property(e => e.PSep).HasColumnName("pSep");
            entity.Property(e => e.PreJan).HasColumnName("preJan");
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VPayrollHolidayAllowanceGenerate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_HolidayAllowanceGenerate");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hdate)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("HDate");
            entity.Property(e => e.MonthYear)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
        });

        modelBuilder.Entity<VPayrollHolidayAllowanceGenerateDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_HolidayAllowanceGenerateDetails");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Hdate)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("HDate");
            entity.Property(e => e.MonthYear)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VPayrollHolidayWeekendBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_HolidayWeekendBill");

            entity.Property(e => e.Did)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DId");
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.ElapsedTime).HasColumnType("datetime");
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.InHour)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.InMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LnId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.LogIn)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.LogOut)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.OutHour)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OutMin)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.StayTime)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.TotalWorkHour)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TotalWorkMin)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPayrollLoanInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_LoanInfo");

            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.InstallmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LoanAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LoanId)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.StartMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPayrollLoanInfoDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_LoanInfoDetails");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.ExemptionReason).HasMaxLength(500);
            entity.Property(e => e.InstallmentMonth)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.LastInstallmentAt)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.LoanDetailsId).HasColumnName("LoanDetailsID");
            entity.Property(e => e.LoanId).HasColumnName("LoanID");
            entity.Property(e => e.ParticularRemarks).HasMaxLength(500);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        modelBuilder.Entity<VPayrollLoanSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_LoanSetting");

            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InstallmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LoanId)
                .HasMaxLength(35)
                .IsUnicode(false);
            entity.Property(e => e.PaidMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.StartMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPayrollMonthlyNoteAmount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_MonthlyNoteAmount");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MonthName)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VPayrollOthersPay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_OthersPay");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsActive)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Oppurpose)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OPpurpose");
            entity.Property(e => e.Opsn).HasColumnName("OPSN");
        });

        modelBuilder.Entity<VPayrollPunishment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_Punishment");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MonthName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pamount).HasColumnName("PAmount");
            entity.Property(e => e.Pname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PName");
            entity.Property(e => e.Psn).HasColumnName("PSN");
        });

        modelBuilder.Entity<VPayrollYearlyBonusSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_YearlyBonusSheet");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.BonusMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("bonusMonth");
            entity.Property(e => e.BonusType)
                .HasMaxLength(122)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.DsgShortName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.GenerateOn)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SalaryCount)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VPayrollYearlyBonusSheet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Payroll_YearlyBonusSheet1");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.BonusMonth)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("bonusMonth");
            entity.Property(e => e.BonusType)
                .HasMaxLength(122)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.DsgShortName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.GenerateOn)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SalaryCount)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VPersonnelEmpCurrentStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Personnel_EmpCurrentStatus");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.BankName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpAccountNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpAttCard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpDutyType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.GrdNameBangla).HasMaxLength(50);
            entity.Property(e => e.IsHalfOt).HasColumnName("IsHalfOT");
            entity.Property(e => e.IsSingleRateOt).HasColumnName("IsSingleRateOT");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NickName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pfamount).HasColumnName("PFAmount");
            entity.Property(e => e.PreCompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PreEmpDutyType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.RealProximityNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Rname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RName");
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SftNameBangla).HasMaxLength(50);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.Telephone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.WeekendType)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPersonnelEmpCurrentStatus1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Personnel_EmpCurrentStatus1");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.BankName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpAccountNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpAttCard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpDutyType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.GrdNameBangla).HasMaxLength(50);
            entity.Property(e => e.IsHalfOt).HasColumnName("IsHalfOT");
            entity.Property(e => e.IsSingleRateOt).HasColumnName("IsSingleRateOT");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NickName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pfamount).HasColumnName("PFAmount");
            entity.Property(e => e.PreCompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PreEmpDutyType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.RealProximityNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.Rname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RName");
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SftNameBangla).HasMaxLength(50);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.Telephone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPersonnelEmpCurrentStatusPromotionLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Personnel_EmpCurrentStatusPromotionLog");

            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrdNameBangla).HasMaxLength(50);
            entity.Property(e => e.Sn).HasColumnName("SN");
        });

        modelBuilder.Entity<VPersonnelEmpCurrentStatusSalaryIncrementLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Personnel_EmpCurrentStatusSalaryIncrementLog");

            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrdNameBangla).HasMaxLength(50);
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPersonnelEmpNewPosition>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Personnel_EmpNewPosition");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GrdName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastIncrementDate)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.NempPresentSalary).HasColumnName("NEmpPresentSalary");
            entity.Property(e => e.PreDptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreDsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreGrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PromotionEffectiveFrom)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SalaryCount)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPersonnelEmpPunismentInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Personnel_EmpPunismentInfo");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpPunismentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmpPunismentOrderRef).HasMaxLength(50);
            entity.Property(e => e.EmpRemarks).HasMaxLength(120);
            entity.Property(e => e.PtId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PtName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPersonnelEmpRejoin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Personnel_EmpRejoin");

            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPersonnelEmpSeparation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Personnel_EmpSeparation");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.YearMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPersonnelEmpSeparation1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Personnel_EmpSeparation1");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.YearMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPfBalanceSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PF_BalanceSheet");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPfCalculationSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PF_CalculationSetting");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PempEmprEndyear).HasColumnName("PEmpEmprEndyear");
            entity.Property(e => e.PempEmprIrstEndyear).HasColumnName("PEmpEmprIrstEndyear");
            entity.Property(e => e.PempEmprIrstStartyear).HasColumnName("PEmpEmprIrstStartyear");
            entity.Property(e => e.PempEmprStartyear).HasColumnName("PEmpEmprStartyear");
            entity.Property(e => e.PempPartEndyear).HasColumnName("PEmpPartEndyear");
            entity.Property(e => e.PempPartStartyear).HasColumnName("PEmpPartStartyear");
            entity.Property(e => e.PfstartYear).HasColumnName("PFStartYear");
        });

        modelBuilder.Entity<VPfMemberListAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PF_MemberListAll");

            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.MemberId)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.PfcompanyId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("PFCompanyId");
            entity.Property(e => e.ProductDb)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ProductDB");
            entity.Property(e => e.ProductId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ShortCode)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPfMonthlyProfit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PF_MonthlyProfit");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Month)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPromotionIncrement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Promotion_Increment");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PreCompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PreCompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PreDptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PreDptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreDsgId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PreDsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreEmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PreEmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PreGrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PreSalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPromotionIncrement1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Promotion_Increment1");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PreCompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PreCompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PreDptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PreDptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreDsgId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PreDsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreEmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PreEmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PreGrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PreSalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VSeparationSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SeparationSheet");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveDateMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Efmonth)
                .HasMaxLength(4000)
                .HasColumnName("EFMonth");
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.SeparationType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
        });

        modelBuilder.Entity<VSeparationSheet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_SeparationSheet1");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveDateMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Efmonth)
                .HasMaxLength(4000)
                .HasColumnName("EFMonth");
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.SeparationType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
        });

        modelBuilder.Entity<VShiftTranferDetailsForFirstInLastOut>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ShiftTranferDetailsForFirstInLastOut");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpAttCard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Expr1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fid).HasColumnName("FId");
            entity.Property(e => e.Sdate).HasColumnName("SDate");
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Stid).HasColumnName("STId");
        });

        modelBuilder.Entity<VShiftTransferInfoDepartmetnList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ShiftTransferInfo_DepartmetnList");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Stid).HasColumnName("STId");
            entity.Property(e => e.TfromDate).HasColumnName("TFromDate");
            entity.Property(e => e.TtoDate).HasColumnName("TToDate");
        });

        modelBuilder.Entity<VShiftTransferInfoDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_ShiftTransferInfoDetails");

            entity.Property(e => e.AcceptableTimeAsOt).HasColumnName("AcceptableTimeAsOT");
            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Day).HasMaxLength(30);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Fid).HasColumnName("FId");
            entity.Property(e => e.Fname)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("FName");
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.Notes)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Sdate).HasColumnName("SDate");
            entity.Property(e => e.SftEndTimeIndicator)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SftStartTimeIndicator)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Stid).HasColumnName("STId");
            entity.Property(e => e.TfromDate).HasColumnName("TFromDate");
            entity.Property(e => e.TtoDate).HasColumnName("TToDate");
        });

        modelBuilder.Entity<VTblAttendanceRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_tblAttendanceRecord");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.AttManual)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Attdate)
                .HasColumnType("datetime")
                .HasColumnName("ATTDate");
            entity.Property(e => e.Attstatus)
                .HasMaxLength(15)
                .HasColumnName("ATTStatus");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.DailyStartTimeAltCloseTime)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("DailyStartTimeALT_CloseTime");
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.InHour).HasMaxLength(2);
            entity.Property(e => e.InMin).HasMaxLength(2);
            entity.Property(e => e.InSec)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.InTime).HasMaxLength(8);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MonthId)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.MonthName)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Odid).HasColumnName("ODID");
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OutHour)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OutMin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OutSec)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OutTime)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.RealProximityNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ReferenceID");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Rname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RName");
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SftNameBangla).HasMaxLength(50);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.StateStatus).HasMaxLength(50);
            entity.Property(e => e.Telephone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VTblAttendanceRecord1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_tblAttendanceRecord1");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AddressBangla).HasMaxLength(300);
            entity.Property(e => e.AttManual)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AttStatus).HasMaxLength(15);
            entity.Property(e => e.Attdate)
                .HasColumnType("datetime")
                .HasColumnName("ATTDate");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyNameBangla).HasMaxLength(100);
            entity.Property(e => e.DailyStartTimeAltCloseTime)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("DailyStartTimeALT_CloseTime");
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptNameBn).HasMaxLength(50);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgNameBn).HasMaxLength(200);
            entity.Property(e => e.EffectiveMonth)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpNameBn).HasMaxLength(100);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.GrdName)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.InHour).HasMaxLength(2);
            entity.Property(e => e.InMin).HasMaxLength(2);
            entity.Property(e => e.InSec)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.InTime).HasMaxLength(8);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MonthId)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.MonthName)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.OrderRefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OutHour)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OutMin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OutSec)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.OutTime)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.RealProximityNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ReferenceID");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Rname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RName");
            entity.Property(e => e.SalaryType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SftNameBangla).HasMaxLength(50);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.StateStatus).HasMaxLength(50);
            entity.Property(e => e.Telephone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TypeOfChange)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VTblAttendanceRecordPunchLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_tblAttendanceRecordPunchLog");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AttManual)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Attdate)
                .HasColumnType("datetime")
                .HasColumnName("ATTDate");
            entity.Property(e => e.Attstatus)
                .HasMaxLength(15)
                .HasColumnName("ATTStatus");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.InHour).HasMaxLength(2);
            entity.Property(e => e.InMin).HasMaxLength(2);
            entity.Property(e => e.InSec)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OutHour)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OutMin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OutSec)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.PinHour)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PInHour");
            entity.Property(e => e.PinMin)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PInMin");
            entity.Property(e => e.PinSec)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PInSec");
            entity.Property(e => e.PoutHour)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("POutHour");
            entity.Property(e => e.PoutMin)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("POutMin");
            entity.Property(e => e.PoutSec)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("POutSec");
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VTblHolydayWeekentEmployeeWise>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_tblHolydayWeekentEmployeeWise");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Hwcode).HasColumnName("HWCode");
            entity.Property(e => e.HwdayName)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("HWDayName");
            entity.Property(e => e.Hwtype)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("HWType");
            entity.Property(e => e.Remarks)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VTblHolydayWork>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_tblHolydayWork");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hcode).HasColumnName("HCode");
            entity.Property(e => e.Hdate)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("HDate");
            entity.Property(e => e.MonthYear)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VTblHolydayWork1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_tblHolydayWork1");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hcode).HasColumnName("HCode");
            entity.Property(e => e.Hdate)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("HDate");
            entity.Property(e => e.MonthYear)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VTblLeaveConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_tblLeaveConfig");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LeaveName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeaveNature)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortName).HasMaxLength(50);
        });

        modelBuilder.Entity<VTblOutDuty>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_tblOutDuty");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AppiedDate).HasColumnType("datetime");
            entity.Property(e => e.AssignedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AuthorizedByEmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AuthorizedByName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AuthorizedDate).HasColumnType("datetime");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Place)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VTblOutdutyDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_tblOutdutyDetails");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AppiedDate).HasColumnType("datetime");
            entity.Property(e => e.AssignedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AuthorizedByEmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AuthorizedByName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AuthorizedDate).HasColumnType("datetime");
            entity.Property(e => e.ClientName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpProximityNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.InTime)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.OutTime)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Place)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Purpose)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VTblWeekendInfoReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_tblWeekendInfoReport");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DptID");
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DsgID");
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(59)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpType)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GID");
            entity.Property(e => e.Gname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.Weekends).HasMaxLength(4000);
        });

        modelBuilder.Entity<VThanaInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_thanaInfo");

            entity.Property(e => e.DstBangla).HasMaxLength(50);
            entity.Property(e => e.DstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ThaName)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ThaNameBangla).HasMaxLength(50);
        });

        modelBuilder.Entity<VUserAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_UserAccount");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CoockieInfo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsLvAuthority).HasColumnName("isLvAuthority");
            entity.Property(e => e.ShortName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserType)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VUserAccountForLeave>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_UserAccountForLeave");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CoockieInfo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.IsLvAuthority).HasColumnName("isLvAuthority");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LoginDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserType)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VUserPrivilegeList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_UserPrivilegeList");

            entity.Property(e => e.ModulePageName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PageTitle)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VVDailyAttendanceSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_v_DailyAttendanceSummary");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Attdate)
                .HasColumnType("datetime")
                .HasColumnName("ATTDate");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.Telephone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Wh).HasColumnName("WH");
        });

        modelBuilder.Entity<VVForDailyMovementReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_v_ForDailyMovementReport");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Badgenumber).HasMaxLength(24);
            entity.Property(e => e.Checktime)
                .HasColumnType("datetime")
                .HasColumnName("CHECKTIME");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VVLeaveLeaveApplicationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_v_Leave_LeaveApplicationDetails");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Al).HasColumnName("AL");
            entity.Property(e => e.Cl).HasColumnName("CL");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ml).HasColumnName("ML");
            entity.Property(e => e.Month)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.MonthYear)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Ol).HasColumnName("OL");
            entity.Property(e => e.Opl).HasColumnName("OPL");
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortName).HasMaxLength(50);
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Year)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VVTblAttendanceRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_v_tblAttendanceRecord");

            entity.Property(e => e.AttDate).HasMaxLength(4000);
            entity.Property(e => e.AttManual)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Attstatus)
                .HasMaxLength(15)
                .HasColumnName("ATTStatus");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasMaxLength(4000);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InTime).HasMaxLength(5);
            entity.Property(e => e.InTime12Format).HasMaxLength(56);
            entity.Property(e => e.OutTime)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OutTime12Format)
                .HasMaxLength(56)
                .IsUnicode(false);
            entity.Property(e => e.StateStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<VVVLeaveLeaveApplicationDetailsForLeaveBalanceReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_v_v_Leave_LeaveApplicationDetails_ForLeaveBalanceReport");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Al).HasColumnName("AL");
            entity.Property(e => e.BEl).HasColumnName("bEL");
            entity.Property(e => e.Cl).HasColumnName("CL");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Lwp).HasColumnName("LWP");
            entity.Property(e => e.Ml).HasColumnName("ML");
            entity.Property(e => e.Ol).HasColumnName("OL");
            entity.Property(e => e.Opl).HasColumnName("OPL");
            entity.Property(e => e.PEl).HasColumnName("pEL");
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<VVVLeaveLeaveApplicationDetailsForOfficialPurposeReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_v_v_Leave_LeaveApplicationDetails_ForOfficialPurposeReport");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MonthYear)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Opl).HasColumnName("OPL");
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Year)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VVVLeaveYearlyStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_v_v_Leave_Yearly_Status");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.AlRemaining).HasColumnName("AL_Remaining");
            entity.Property(e => e.AlSpend).HasColumnName("AL_Spend");
            entity.Property(e => e.AlTotal).HasColumnName("AL_Total");
            entity.Property(e => e.ClRemaining).HasColumnName("CL_Remaining");
            entity.Property(e => e.ClSpend).HasColumnName("CL_Spend");
            entity.Property(e => e.ClTotal).HasColumnName("CL_Total");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MlRemaining).HasColumnName("ML_Remaining");
            entity.Property(e => e.MlSpend).HasColumnName("ML_Spend");
            entity.Property(e => e.MlTotal).HasColumnName("ML_Total");
            entity.Property(e => e.OlRemaining).HasColumnName("OL_Remaining");
            entity.Property(e => e.OlSpend).HasColumnName("OL_Spend");
            entity.Property(e => e.OlTotal).HasColumnName("OL_Total");
            entity.Property(e => e.OplRemaining).HasColumnName("OPL_Remaining");
            entity.Property(e => e.OplSpend).HasColumnName("OPL_Spend");
            entity.Property(e => e.OplTotal).HasColumnName("OPL_Total");
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SftId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SlRemaining).HasColumnName("SL_Remaining");
            entity.Property(e => e.SlSpend).HasColumnName("SL_Spend");
            entity.Property(e => e.SlTotal).HasColumnName("SL_Total");
            entity.Property(e => e.Year)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VVVTblAttendanceRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_v_v_tblAttendanceRecord");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DptId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gid).HasColumnName("GId");
            entity.Property(e => e.Gname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GName");
            entity.Property(e => e.SftName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalOverTime)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e._10InH).HasColumnName("10_InH");
            entity.Property(e => e._10InM).HasColumnName("10_InM");
            entity.Property(e => e._10OutH).HasColumnName("10_OutH");
            entity.Property(e => e._10OutM).HasColumnName("10_OutM");
            entity.Property(e => e._10Sth).HasColumnName("10_STH");
            entity.Property(e => e._10Stm).HasColumnName("10_STM");
            entity.Property(e => e._11InH).HasColumnName("11_InH");
            entity.Property(e => e._11InM).HasColumnName("11_InM");
            entity.Property(e => e._11OutH).HasColumnName("11_OutH");
            entity.Property(e => e._11OutM).HasColumnName("11_OutM");
            entity.Property(e => e._11Sth).HasColumnName("11_STH");
            entity.Property(e => e._11Stm).HasColumnName("11_STM");
            entity.Property(e => e._12InH).HasColumnName("12_InH");
            entity.Property(e => e._12InM).HasColumnName("12_InM");
            entity.Property(e => e._12OutH).HasColumnName("12_OutH");
            entity.Property(e => e._12OutM).HasColumnName("12_OutM");
            entity.Property(e => e._12Sth).HasColumnName("12_STH");
            entity.Property(e => e._12Stm).HasColumnName("12_STM");
            entity.Property(e => e._13InH).HasColumnName("13_InH");
            entity.Property(e => e._13InM).HasColumnName("13_InM");
            entity.Property(e => e._13OutH).HasColumnName("13_OutH");
            entity.Property(e => e._13OutM).HasColumnName("13_OutM");
            entity.Property(e => e._13Sth).HasColumnName("13_STH");
            entity.Property(e => e._13Stm).HasColumnName("13_STM");
            entity.Property(e => e._14InH).HasColumnName("14_InH");
            entity.Property(e => e._14InM).HasColumnName("14_InM");
            entity.Property(e => e._14OutH).HasColumnName("14_OutH");
            entity.Property(e => e._14OutM).HasColumnName("14_OutM");
            entity.Property(e => e._14Sth).HasColumnName("14_STH");
            entity.Property(e => e._14Stm).HasColumnName("14_STM");
            entity.Property(e => e._15InH).HasColumnName("15_InH");
            entity.Property(e => e._15InM).HasColumnName("15_InM");
            entity.Property(e => e._15OutH).HasColumnName("15_OutH");
            entity.Property(e => e._15OutM).HasColumnName("15_OutM");
            entity.Property(e => e._15Sth).HasColumnName("15_STH");
            entity.Property(e => e._15Stm).HasColumnName("15_STM");
            entity.Property(e => e._16InH).HasColumnName("16_InH");
            entity.Property(e => e._16InM).HasColumnName("16_InM");
            entity.Property(e => e._16OutH).HasColumnName("16_OutH");
            entity.Property(e => e._16OutM).HasColumnName("16_OutM");
            entity.Property(e => e._16Sth).HasColumnName("16_STH");
            entity.Property(e => e._16Stm).HasColumnName("16_STM");
            entity.Property(e => e._17InH).HasColumnName("17_InH");
            entity.Property(e => e._17InM).HasColumnName("17_InM");
            entity.Property(e => e._17OutH).HasColumnName("17_OutH");
            entity.Property(e => e._17OutM).HasColumnName("17_OutM");
            entity.Property(e => e._17Sth).HasColumnName("17_STH");
            entity.Property(e => e._17Stm).HasColumnName("17_STM");
            entity.Property(e => e._18InH).HasColumnName("18_InH");
            entity.Property(e => e._18InM).HasColumnName("18_InM");
            entity.Property(e => e._18OutH).HasColumnName("18_OutH");
            entity.Property(e => e._18OutM).HasColumnName("18_OutM");
            entity.Property(e => e._18Sth).HasColumnName("18_STH");
            entity.Property(e => e._18Stm).HasColumnName("18_STM");
            entity.Property(e => e._19InH).HasColumnName("19_InH");
            entity.Property(e => e._19InM).HasColumnName("19_InM");
            entity.Property(e => e._19OutH).HasColumnName("19_OutH");
            entity.Property(e => e._19OutM).HasColumnName("19_OutM");
            entity.Property(e => e._19Sth).HasColumnName("19_STH");
            entity.Property(e => e._19Stm).HasColumnName("19_STM");
            entity.Property(e => e._1InH).HasColumnName("1_InH");
            entity.Property(e => e._1InM).HasColumnName("1_InM");
            entity.Property(e => e._1OutH).HasColumnName("1_OutH");
            entity.Property(e => e._1OutM).HasColumnName("1_OutM");
            entity.Property(e => e._1Sth).HasColumnName("1_STH");
            entity.Property(e => e._1Stm).HasColumnName("1_STM");
            entity.Property(e => e._20InH).HasColumnName("20_InH");
            entity.Property(e => e._20InM).HasColumnName("20_InM");
            entity.Property(e => e._20OutH).HasColumnName("20_OutH");
            entity.Property(e => e._20OutM).HasColumnName("20_OutM");
            entity.Property(e => e._20Sth).HasColumnName("20_STH");
            entity.Property(e => e._20Stm).HasColumnName("20_STM");
            entity.Property(e => e._21InH).HasColumnName("21_InH");
            entity.Property(e => e._21InM).HasColumnName("21_InM");
            entity.Property(e => e._21OutH).HasColumnName("21_OutH");
            entity.Property(e => e._21OutM).HasColumnName("21_OutM");
            entity.Property(e => e._21Sth).HasColumnName("21_STH");
            entity.Property(e => e._21Stm).HasColumnName("21_STM");
            entity.Property(e => e._22InH).HasColumnName("22_InH");
            entity.Property(e => e._22InM).HasColumnName("22_InM");
            entity.Property(e => e._22OutH).HasColumnName("22_OutH");
            entity.Property(e => e._22OutM).HasColumnName("22_OutM");
            entity.Property(e => e._22Sth).HasColumnName("22_STH");
            entity.Property(e => e._22Stm).HasColumnName("22_STM");
            entity.Property(e => e._23InH).HasColumnName("23_InH");
            entity.Property(e => e._23InM).HasColumnName("23_InM");
            entity.Property(e => e._23OutH).HasColumnName("23_OutH");
            entity.Property(e => e._23OutM).HasColumnName("23_OutM");
            entity.Property(e => e._23Sth).HasColumnName("23_STH");
            entity.Property(e => e._23Stm).HasColumnName("23_STM");
            entity.Property(e => e._24InH).HasColumnName("24_InH");
            entity.Property(e => e._24InM).HasColumnName("24_InM");
            entity.Property(e => e._24OutH).HasColumnName("24_OutH");
            entity.Property(e => e._24OutM).HasColumnName("24_OutM");
            entity.Property(e => e._24Sth).HasColumnName("24_STH");
            entity.Property(e => e._24Stm).HasColumnName("24_STM");
            entity.Property(e => e._25InH).HasColumnName("25_InH");
            entity.Property(e => e._25InM).HasColumnName("25_InM");
            entity.Property(e => e._25OutH).HasColumnName("25_OutH");
            entity.Property(e => e._25OutM).HasColumnName("25_OutM");
            entity.Property(e => e._25Sth).HasColumnName("25_STH");
            entity.Property(e => e._25Stm).HasColumnName("25_STM");
            entity.Property(e => e._26InH).HasColumnName("26_InH");
            entity.Property(e => e._26InM).HasColumnName("26_InM");
            entity.Property(e => e._26OutH).HasColumnName("26_OutH");
            entity.Property(e => e._26OutM).HasColumnName("26_OutM");
            entity.Property(e => e._26Sth).HasColumnName("26_STH");
            entity.Property(e => e._26Stm).HasColumnName("26_STM");
            entity.Property(e => e._27InH).HasColumnName("27_InH");
            entity.Property(e => e._27InM).HasColumnName("27_InM");
            entity.Property(e => e._27OutH).HasColumnName("27_OutH");
            entity.Property(e => e._27OutM).HasColumnName("27_OutM");
            entity.Property(e => e._27Sth).HasColumnName("27_STH");
            entity.Property(e => e._27Stm).HasColumnName("27_STM");
            entity.Property(e => e._28InH).HasColumnName("28_InH");
            entity.Property(e => e._28InM).HasColumnName("28_InM");
            entity.Property(e => e._28OutH).HasColumnName("28_OutH");
            entity.Property(e => e._28OutM).HasColumnName("28_OutM");
            entity.Property(e => e._28Sth).HasColumnName("28_STH");
            entity.Property(e => e._28Stm).HasColumnName("28_STM");
            entity.Property(e => e._29InH).HasColumnName("29_InH");
            entity.Property(e => e._29InM).HasColumnName("29_InM");
            entity.Property(e => e._29OutH).HasColumnName("29_OutH");
            entity.Property(e => e._29OutM).HasColumnName("29_OutM");
            entity.Property(e => e._29Sth).HasColumnName("29_STH");
            entity.Property(e => e._29Stm).HasColumnName("29_STM");
            entity.Property(e => e._2InH).HasColumnName("2_InH");
            entity.Property(e => e._2InM).HasColumnName("2_InM");
            entity.Property(e => e._2OutH).HasColumnName("2_OutH");
            entity.Property(e => e._2OutM).HasColumnName("2_OutM");
            entity.Property(e => e._2Sth).HasColumnName("2_STH");
            entity.Property(e => e._2Stm).HasColumnName("2_STM");
            entity.Property(e => e._30InH).HasColumnName("30_InH");
            entity.Property(e => e._30InM).HasColumnName("30_InM");
            entity.Property(e => e._30OutH).HasColumnName("30_OutH");
            entity.Property(e => e._30OutM).HasColumnName("30_OutM");
            entity.Property(e => e._30Sth).HasColumnName("30_STH");
            entity.Property(e => e._30Stm).HasColumnName("30_STM");
            entity.Property(e => e._31InH).HasColumnName("31_InH");
            entity.Property(e => e._31InM).HasColumnName("31_InM");
            entity.Property(e => e._31OutH).HasColumnName("31_OutH");
            entity.Property(e => e._31OutM).HasColumnName("31_OutM");
            entity.Property(e => e._31Sth).HasColumnName("31_STH");
            entity.Property(e => e._31Stm).HasColumnName("31_STM");
            entity.Property(e => e._3InH).HasColumnName("3_InH");
            entity.Property(e => e._3InM).HasColumnName("3_InM");
            entity.Property(e => e._3OutH).HasColumnName("3_OutH");
            entity.Property(e => e._3OutM).HasColumnName("3_OutM");
            entity.Property(e => e._3Sth).HasColumnName("3_STH");
            entity.Property(e => e._3Stm).HasColumnName("3_STM");
            entity.Property(e => e._4InH).HasColumnName("4_InH");
            entity.Property(e => e._4InM).HasColumnName("4_InM");
            entity.Property(e => e._4OutH).HasColumnName("4_OutH");
            entity.Property(e => e._4OutM).HasColumnName("4_OutM");
            entity.Property(e => e._4Sth).HasColumnName("4_STH");
            entity.Property(e => e._4Stm).HasColumnName("4_STM");
            entity.Property(e => e._5InH).HasColumnName("5_InH");
            entity.Property(e => e._5InM).HasColumnName("5_InM");
            entity.Property(e => e._5OutH).HasColumnName("5_OutH");
            entity.Property(e => e._5OutM).HasColumnName("5_OutM");
            entity.Property(e => e._5Sth).HasColumnName("5_STH");
            entity.Property(e => e._5Stm).HasColumnName("5_STM");
            entity.Property(e => e._6InH).HasColumnName("6_InH");
            entity.Property(e => e._6InM).HasColumnName("6_InM");
            entity.Property(e => e._6OutH).HasColumnName("6_OutH");
            entity.Property(e => e._6OutM).HasColumnName("6_OutM");
            entity.Property(e => e._6Sth).HasColumnName("6_STH");
            entity.Property(e => e._6Stm).HasColumnName("6_STM");
            entity.Property(e => e._7InH).HasColumnName("7_InH");
            entity.Property(e => e._7InM).HasColumnName("7_InM");
            entity.Property(e => e._7OutH).HasColumnName("7_OutH");
            entity.Property(e => e._7OutM).HasColumnName("7_OutM");
            entity.Property(e => e._7Sth).HasColumnName("7_STH");
            entity.Property(e => e._7Stm).HasColumnName("7_STM");
            entity.Property(e => e._8InH).HasColumnName("8_InH");
            entity.Property(e => e._8InM).HasColumnName("8_InM");
            entity.Property(e => e._8OutH).HasColumnName("8_OutH");
            entity.Property(e => e._8OutM).HasColumnName("8_OutM");
            entity.Property(e => e._8Sth).HasColumnName("8_STH");
            entity.Property(e => e._8Stm).HasColumnName("8_STM");
            entity.Property(e => e._9InH).HasColumnName("9_InH");
            entity.Property(e => e._9InM).HasColumnName("9_InM");
            entity.Property(e => e._9OutH).HasColumnName("9_OutH");
            entity.Property(e => e._9OutM).HasColumnName("9_OutM");
            entity.Property(e => e._9Sth).HasColumnName("9_STH");
            entity.Property(e => e._9Stm).HasColumnName("9_STM");
        });

        modelBuilder.Entity<VVatTaxIncomeTax>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_VatTax_IncomeTax");

            entity.Property(e => e.Address)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContrPfwhichPfact1925Applies).HasColumnName("ContrPFWhichPFAct1925Applies");
            entity.Property(e => e.DptId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DsgId)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DsgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ElAmount).HasColumnName("EL_Amount");
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GenerateDate).HasColumnType("datetime");
            entity.Property(e => e.InvstInApprDebentureOrDebentureStockStockOrShares).HasColumnName("InvstInApprDebentureOrDebentureStock_StockOrShares");
            entity.Property(e => e.InvstYear)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.PfAmount).HasColumnName("PF_Amount");
            entity.Property(e => e.TaxYears)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Tin)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TotalTaxableIncome).HasColumnName("Total_Taxable_Income");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VVatTaxRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_VatTax_Rate");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Rsn).HasColumnName("RSN");
            entity.Property(e => e.SlabName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VVatTaxRebatableRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_VatTax_Rebatable_Rate");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Rsn).HasColumnName("RSN");
            entity.Property(e => e.SlabName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VVatTaxYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_VatTax_Years");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.TaxYears)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VatTaxEmpInvestment>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.InvstYear });

            entity.ToTable("VatTax_EmpInvestment");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InvstYear)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ContrBenevolentFundAndGroupInsurPremium).HasDefaultValue(0.0);
            entity.Property(e => e.ContrDepositPensionScheme).HasDefaultValue(0.0);
            entity.Property(e => e.ContrPfwhichPfact1925Applies).HasColumnName("ContrPFWhichPFAct1925Applies");
            entity.Property(e => e.ContrSuperAnnuationFund).HasDefaultValue(0.0);
            entity.Property(e => e.InvstInApprDebentureOrDebentureStockStockOrShares)
                .HasDefaultValue(0.0)
                .HasColumnName("InvstInApprDebentureOrDebentureStock_StockOrShares");
            entity.Property(e => e.InvstInApprSavingsCertificate).HasDefaultValue(0.0);
            entity.Property(e => e.LifeInsurPremium).HasDefaultValue(0.0);
            entity.Property(e => e.Others).HasDefaultValue(0.0);
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");

            entity.HasOne(d => d.Emp).WithMany(p => p.VatTaxEmpInvestments)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_VatTax_EmpInvestment_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<VatTaxGenerateType>(entity =>
        {
            entity.ToTable("VatTax_GenerateType");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VatTaxIncomeTax>(entity =>
        {
            entity.HasKey(e => new { e.TaxId, e.EmpId });

            entity.ToTable("VatTax_IncomeTax");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ElAmount).HasColumnName("EL_Amount");
            entity.Property(e => e.GenerateDate).HasColumnType("datetime");
            entity.Property(e => e.PfAmount).HasColumnName("PF_Amount");
            entity.Property(e => e.TotalTaxableIncome).HasColumnName("Total_Taxable_Income");

            entity.HasOne(d => d.Tax).WithMany(p => p.VatTaxIncomeTaxes)
                .HasForeignKey(d => d.TaxId)
                .HasConstraintName("FK_VatTax_IncomeTax_VatTax_Years");
        });

        modelBuilder.Entity<VatTaxIncomeTaxDetailsLog>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.Month });

            entity.ToTable("VatTax_IncomeTaxDetailsLog");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsPaid).HasColumnName("isPaid");
            entity.Property(e => e.Sl)
                .ValueGeneratedOnAdd()
                .HasColumnName("SL");
            entity.Property(e => e.TaxYears)
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.HasOne(d => d.Emp).WithMany(p => p.VatTaxIncomeTaxDetailsLogs)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK_VatTax_IncomeTaxDetailsLog_Personnel_EmployeeInfo");
        });

        modelBuilder.Entity<VatTaxMinimumTax>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VatTax_MinimumTax");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<VatTaxRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VatTax_Rate");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Rsn)
                .ValueGeneratedOnAdd()
                .HasColumnName("RSN");
            entity.Property(e => e.SlabName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VatTaxRebatableRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VatTax_Rebatable_Rate");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Rsn)
                .ValueGeneratedOnAdd()
                .HasColumnName("RSN");
            entity.Property(e => e.SlabName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VatTaxRebateCalculation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VatTax_RebateCalculation");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SlabName)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.VatTaxIncomeTax).WithMany()
                .HasForeignKey(d => new { d.TaxId, d.EmpId })
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_VatTax_RebateCalculation_VatTax_IncomeTax");
        });

        modelBuilder.Entity<VatTaxTaxCalculation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VatTax_TaxCalculation");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SlabName)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.VatTaxIncomeTax).WithMany()
                .HasForeignKey(d => new { d.TaxId, d.EmpId })
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_VatTax_TaxCalculation_VatTax_IncomeTax");
        });

        modelBuilder.Entity<VatTaxTaxFreeAllowance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VatTax_TaxFreeAllowance");

            entity.Property(e => e.Tfsn)
                .ValueGeneratedOnAdd()
                .HasColumnName("TFSN");
        });

        modelBuilder.Entity<VatTaxYear>(entity =>
        {
            entity.HasKey(e => e.TaxId);

            entity.ToTable("VatTax_Years");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.TaxYears)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<View1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_1");

            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
