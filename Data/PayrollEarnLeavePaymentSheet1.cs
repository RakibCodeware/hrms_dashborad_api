using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollEarnLeavePaymentSheet1
{
    public long Sl { get; set; }

    public string? CompanyId { get; set; }

    public string? EmpId { get; set; }

    public short? EmpTypeId { get; set; }

    public short? EmpStatus { get; set; }

    public DateOnly? YearMonth { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? CurrentYearEarnLeaveDays { get; set; }

    public int? PreviousYearEarnLeaveDays { get; set; }

    public short? TotalEarnLeaveDays { get; set; }

    public short? SepntEarnLeaveDays { get; set; }

    public short? PayableEarnLeaveDays { get; set; }

    public double? WithdrawableEarnLeaveDays { get; set; }

    public double? PayableAmount { get; set; }

    public double? StampDeductions { get; set; }

    public double? TotalAmount { get; set; }

    public double? EmpPresentSalary { get; set; }

    public double? BasicSalary { get; set; }

    public double? OneDaySalary { get; set; }

    public string? DptId { get; set; }

    public int? Gid { get; set; }

    public string? DsgId { get; set; }

    public string? GrdName { get; set; }

    public DateTime? GenerateTime { get; set; }

    public bool? IsSeparated { get; set; }

    public int? WithdrawableEarnLeavePer { get; set; }
}
