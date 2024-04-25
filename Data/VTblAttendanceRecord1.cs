using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VTblAttendanceRecord1
{
    public bool? LateForAttBonus { get; set; }

    public DateTime Attdate { get; set; }

    public string? InHour { get; set; }

    public string? InMin { get; set; }

    public string? OutHour { get; set; }

    public string? OutMin { get; set; }

    public string? AttStatus { get; set; }

    public string? StateStatus { get; set; }

    public int? EmpTypeId { get; set; }

    public string? AttManual { get; set; }

    public string EmpId { get; set; } = null!;

    public int? Sn { get; set; }

    public string? EmpName { get; set; }

    public string? EmpNameBn { get; set; }

    public string? SalaryType { get; set; }

    public double? EmpPresentSalary { get; set; }

    public double? IncrementAmount { get; set; }

    public double? MedicalAllownce { get; set; }

    public double? HouseRent { get; set; }

    public double? ConvenceAllownce { get; set; }

    public double? HolidayAllownce { get; set; }

    public double? TiffinAllownce { get; set; }

    public double? NightAllownce { get; set; }

    public double? AttendanceBonus { get; set; }

    public DateOnly? DateofUpdate { get; set; }

    public string? TypeOfChange { get; set; }

    public string? OrderRefNo { get; set; }

    public string? EmpStatus { get; set; }

    public string? EffectiveMonth { get; set; }

    public bool? ActiveSalary { get; set; }

    public double? FoodAllownce { get; set; }

    public string? EmpType { get; set; }

    public string? GrdName { get; set; }

    public string? MonthName { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public string? InSec { get; set; }

    public string? OutSec { get; set; }

    public short? IsActive { get; set; }

    public string? MonthId { get; set; }

    public string? InTime { get; set; }

    public string? OutTime { get; set; }

    public string? EmpCardNo { get; set; }

    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public string? Sex { get; set; }

    public TimeOnly? OverTime { get; set; }

    public string? DailyStartTimeAltCloseTime { get; set; }

    public string? Rname { get; set; }

    public string? MobileNo { get; set; }

    public int? Code { get; set; }

    public short? SftId { get; set; }

    public string SftName { get; set; } = null!;

    public short? Gid { get; set; }

    public string Gname { get; set; } = null!;

    public short? CustomOrdering { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DptCode { get; set; }

    public string? DptNameBn { get; set; }

    public string? CompanyNameBangla { get; set; }

    public string? AddressBangla { get; set; }

    public string? SftNameBangla { get; set; }

    public string DsgName { get; set; } = null!;

    public string? DsgNameBn { get; set; }

    public string DsgId { get; set; } = null!;

    public TimeOnly? BreakStartTime { get; set; }

    public TimeOnly? BreakEndTime { get; set; }

    public bool? IsOverTime { get; set; }

    public TimeOnly? StayTime { get; set; }

    public short? PaybleDays { get; set; }

    public short? TiffinCount { get; set; }

    public short? HolidayCount { get; set; }

    public string? RealProximityNo { get; set; }

    public TimeOnly? LateTime { get; set; }

    public bool? OverTimeCheck { get; set; }

    public TimeOnly? OtherOverTime { get; set; }

    public TimeOnly? TotalOverTime { get; set; }

    public int? TotalDays { get; set; }

    public int? Year { get; set; }

    public bool? OutDuty { get; set; }

    public string? ReferenceId { get; set; }

    public int? UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Remark { get; set; }

    public TimeOnly? SftStartTime { get; set; }

    public TimeOnly? SftEndTime { get; set; }

    public int IsLate { get; set; }

    public string? EmpProximityNo { get; set; }
}
