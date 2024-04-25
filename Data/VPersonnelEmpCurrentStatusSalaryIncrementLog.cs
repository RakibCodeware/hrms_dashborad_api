using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPersonnelEmpCurrentStatusSalaryIncrementLog
{
    public int Sn { get; set; }

    public string EmpId { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DptNameBn { get; set; }

    public string? DsgId { get; set; }

    public string DsgName { get; set; } = null!;

    public string? DsgNameBn { get; set; }

    public string? GrdName { get; set; }

    public string? GrdNameBangla { get; set; }

    public string? EmpCardNo { get; set; }

    public int? EmpTypeId { get; set; }

    public string? EmpType { get; set; }

    public string? SalaryType { get; set; }

    public double? EmpPresentSalary { get; set; }

    public double? IncrementAmount { get; set; }

    public double? BasicSalary { get; set; }

    public double? MedicalAllownce { get; set; }

    public double? FoodAllownce { get; set; }

    public double? ConvenceAllownce { get; set; }

    public double? HouseRent { get; set; }

    public double? OthersAllownce { get; set; }

    public double? HolidayAllownce { get; set; }

    public double? TiffinAllownce { get; set; }

    public double? NightAllownce { get; set; }

    public double? AttendanceBonus { get; set; }

    public double? LunchAllownce { get; set; }

    public bool LunchCount { get; set; }

    public DateOnly? DateofUpdate { get; set; }

    public string? TypeOfChange { get; set; }

    public string? EffectiveMonth { get; set; }

    public string? OrderRefNo { get; set; }

    public DateOnly? OrderRefDate { get; set; }

    public string? Remarks { get; set; }

    public bool ActiveSalary { get; set; }

    public DateOnly? EarnLeaveDate { get; set; }
}
