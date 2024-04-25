using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollEarnLeavePaymentSheet
{
    public long Sl { get; set; }

    public string? CompanyId { get; set; }

    public string? EmpId { get; set; }

    public short? EmpTypeId { get; set; }

    public short? EmpStatus { get; set; }

    public DateOnly? YearMonth { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public short? TotalEarnLeaveDays { get; set; }

    public short? SepntEarnLeaveDays { get; set; }

    public short? PayableEarnLeaveDays { get; set; }

    public double? WithdrawableEarnLeaveDays { get; set; }

    public double? PayableAmount { get; set; }

    public double? EmpPresentSalary { get; set; }

    public double? BasicSalary { get; set; }

    public double? OneDaySalary { get; set; }

    public string? DptId { get; set; }

    public string? DsgId { get; set; }

    public string? GrdName { get; set; }

    public DateTime? GenerateTime { get; set; }

    public bool? IsSeparated { get; set; }

    public string? DptName { get; set; }

    public string DsgName { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpCardNo { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public int? Gid { get; set; }

    public string Gname { get; set; } = null!;

    public int TotalPresent { get; set; }

    public double? StampDeductions { get; set; }

    public double? TotalAmount { get; set; }

    public int? WithdrawableEarnLeavePer { get; set; }

    public int? PJan { get; set; }

    public int? PFeb { get; set; }

    public int? PMar { get; set; }

    public int? PApr { get; set; }

    public int? PMay { get; set; }

    public int? PJun { get; set; }

    public int? PJul { get; set; }

    public int? PAug { get; set; }

    public int? PSep { get; set; }

    public int? POct { get; set; }

    public int? PNov { get; set; }

    public int? PDec { get; set; }

    public int? Year { get; set; }

    public string? EmpType { get; set; }

    public DateOnly? ReserveFor { get; set; }

    public double? ReserveEeanLeaveDays { get; set; }

    public string? EmpProximityNo { get; set; }

    public int? CurrentYearEarnLeaveDays { get; set; }

    public int? PreviousYearEarnLeaveDays { get; set; }

    public int? PreJan { get; set; }

    public int? NDec { get; set; }

    public short? CustomOrdering { get; set; }
}
