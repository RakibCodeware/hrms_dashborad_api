using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPersonnelEmpCurrentStatus
{
    public int Sn { get; set; }

    public string? EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? EmpNameBn { get; set; }

    public int? EmpTypeId { get; set; }

    public string? SalaryType { get; set; }

    public double? EmpPresentSalary { get; set; }

    public double? IncrementAmount { get; set; }

    public double? MedicalAllownce { get; set; }

    public double? BasicSalary { get; set; }

    public double? HouseRent { get; set; }

    public double? ConvenceAllownce { get; set; }

    public double? HolidayAllownce { get; set; }

    public double? TiffinAllownce { get; set; }

    public double? NightAllownce { get; set; }

    public double? AttendanceBonus { get; set; }

    public DateOnly? DateofUpdate { get; set; }

    public string? DptId { get; set; }

    public string? EmpCardNo { get; set; }

    public string? TypeOfChange { get; set; }

    public string? OrderRefNo { get; set; }

    public DateOnly? OrderRefDate { get; set; }

    public string? EmpStatus { get; set; }

    public string? Remarks { get; set; }

    public string? DptName { get; set; }

    public string DsgName { get; set; } = null!;

    public string DsgId { get; set; } = null!;

    public string? EffectiveMonth { get; set; }

    public bool? ActiveSalary { get; set; }

    public double? FoodAllownce { get; set; }

    public string? EmpType { get; set; }

    public string? GrdName { get; set; }

    public DateOnly? EarnLeaveDate { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public bool? LunchCount { get; set; }

    public double? LunchAllownce { get; set; }

    public double? OthersAllownce { get; set; }

    public short? IsActive { get; set; }

    public string? DsgNameBn { get; set; }

    public string? DptNameBn { get; set; }

    public string? EmpStatusName { get; set; }

    public string? GrdNameBangla { get; set; }

    public string? CompanyId { get; set; }

    public string? PreCompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string SftName { get; set; } = null!;

    public string? Sex { get; set; }

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public string? NickName { get; set; }

    public double? PreTechnicalAllownce { get; set; }

    public double? TechnicalAllownce { get; set; }

    public short? Rid { get; set; }

    public string? Rname { get; set; }

    public string? MobileNo { get; set; }

    public string? AddressBangla { get; set; }

    public string? CompanyNameBangla { get; set; }

    public string? SftId { get; set; }

    public short? Gid { get; set; }

    public string? Gname { get; set; }

    public short? BankId { get; set; }

    public string? BankName { get; set; }

    public bool? SalaryCount { get; set; }

    public string? EmpAccountNo { get; set; }

    public short? CustomOrdering { get; set; }

    public string? RealProximityNo { get; set; }

    public bool? PunchType { get; set; }

    public string? PreEmpDutyType { get; set; }

    public string? EmpDutyType { get; set; }

    public string? SftNameBangla { get; set; }

    public string? DptCode { get; set; }

    public bool? OverTime { get; set; }

    public double? DormitoryRent { get; set; }

    public double? PreIncomeTax { get; set; }

    public double? IncomeTax { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public double? PfOpeningBalance { get; set; }

    public double? PfEmpContribution { get; set; }

    public bool? PfMember { get; set; }

    public DateOnly? PfDate { get; set; }

    public double? Pfamount { get; set; }

    public string? EmpProximityNo { get; set; }

    public string? EmpAttCard { get; set; }

    public bool? IsHalfOt { get; set; }

    public bool? IsDelivery { get; set; }

    public bool? TiffinStatus { get; set; }

    public bool? NightBillStatus { get; set; }

    public bool? LunchBillStatus { get; set; }

    public bool? BreakfastStatus { get; set; }

    public bool? IsSingleRateOt { get; set; }

    public string? WeekendType { get; set; }
}
