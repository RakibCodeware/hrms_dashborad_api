using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VEmployeeDetails1
{
    public string EmpId { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpNameBn { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DsgId { get; set; }

    public string DsgName { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public string? EmpProximityNo { get; set; }

    public string? EmpStatus { get; set; }

    public TimeOnly? EmpStartLunch { get; set; }

    public TimeOnly? EmpEndLunch { get; set; }

    public DateOnly? EmpShiftStartDate { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public short? EarnedLeave { get; set; }

    public DateOnly? EarnedLeaveEffectedFrom { get; set; }

    public string? BonusType { get; set; }

    public string? EmpPicture { get; set; }

    public string? SalaryType { get; set; }

    public double? EmpPresentSalary { get; set; }

    public double? BasicSalary { get; set; }

    public double? HouseRent { get; set; }

    public double? ConvenceAllownce { get; set; }

    public double? HolidayAllownce { get; set; }

    public double? TiffinAllownce { get; set; }

    public double? NightAllownce { get; set; }

    public double? AttendanceBonus { get; set; }

    public int Sn { get; set; }

    public double? FoodAllownce { get; set; }

    public double? OthersAllownce { get; set; }

    public string? SignatureImage { get; set; }

    public double? LunchAllownce { get; set; }

    public bool? LunchCount { get; set; }

    public int? EmpTypeId { get; set; }

    public string? EmpType { get; set; }

    public string? GrdName { get; set; }

    public string? EmpStatusName { get; set; }

    public string? BloodGroup { get; set; }

    public string? JoiningMonthYear { get; set; }

    public string? Age { get; set; }

    public string? Remarks { get; set; }

    public string? LastEdQualification { get; set; }

    public string? NoOfExperience { get; set; }

    public bool? ActiveSalary { get; set; }

    public short? IsActive { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyId { get; set; }

    public string SftName { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    public string? Sex { get; set; }

    public string? Type { get; set; }

    public double? PreTechnicalAllownce { get; set; }

    public double? TechnicalAllownce { get; set; }

    public string? NickName { get; set; }

    public string? TypeOfChange { get; set; }

    public short? Rid { get; set; }

    public string? Rname { get; set; }

    public string? EffectiveMonth { get; set; }

    public string? Address { get; set; }

    public string? DstName { get; set; }

    public int? PerCity { get; set; }

    public string? SftId { get; set; }

    public DateTime? ShiftTransferDate { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public short? Gid { get; set; }

    public string? Gname { get; set; }

    public bool? SalaryCount { get; set; }

    public short? BankId { get; set; }

    public bool? PfMember { get; set; }

    public DateOnly? PfDate { get; set; }

    public double? Pfamount { get; set; }

    public string? EmpAccountNo { get; set; }

    public double? EmpJoinigSalary { get; set; }

    public double? PreBasicSalary { get; set; }

    public double? PreFoodAllownce { get; set; }

    public double? PreConvenceAllownce { get; set; }

    public double? PreHouseRent { get; set; }

    public string? PreGrdName { get; set; }

    public double? PreOthersAllownce { get; set; }

    public double? PreHolidayAllownce { get; set; }

    public double? PreTiffinAllownce { get; set; }

    public double? PreNightAllownce { get; set; }

    public double? PreAttendanceBonus { get; set; }

    public double? PreLunchAllownce { get; set; }

    public double? PreMedicalAllownce { get; set; }

    public double? MedicalAllownce { get; set; }

    public double? Medical { get; set; }

    public double? PfPersent { get; set; }

    public double? HouseRentPersent { get; set; }

    public string? DptCode { get; set; }

    public short? CustomOrdering { get; set; }

    public string? CompanyNameBangla { get; set; }

    public string? AddressBangla { get; set; }

    public string? DsgNameBn { get; set; }

    public string? DptNameBn { get; set; }

    public string? SftNameBangla { get; set; }

    public string? FatherNameBn { get; set; }

    public string? PerVillageBangla { get; set; }

    public string? PerPobangla { get; set; }

    public string? ThaNameBangla { get; set; }

    public string? DstBangla { get; set; }

    public string? MobileNo { get; set; }

    public string? RealProximityNo { get; set; }

    public bool? PunchType { get; set; }

    public string? EmpDutyType { get; set; }

    public string? CompanyLogo { get; set; }

    public string? RnameBn { get; set; }

    public string? PreEmpDutyType { get; set; }

    public bool? OverTime { get; set; }

    public bool? AuthorizedPerson { get; set; }

    public double? DormitoryRent { get; set; }

    public string? Tin { get; set; }

    public double? IncrementAmount { get; set; }

    public DateOnly? DateofUpdate { get; set; }

    public bool? IsSingleRateOt { get; set; }
}
