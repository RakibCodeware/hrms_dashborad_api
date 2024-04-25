using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class LeaveYearlyEarnLeaveGeneration
{
    public long Sl { get; set; }

    public string? EmpId { get; set; }

    public int? EmpTypeId { get; set; }

    public double? BasicSalary { get; set; }

    public double? NetTotal { get; set; }

    public string? CompanyId { get; set; }

    public short? SftId { get; set; }

    public string? DptId { get; set; }

    public string? DsgId { get; set; }

    public DateOnly? GenerateDate { get; set; }

    public DateOnly? EarnLeavePerviousStartYear { get; set; }

    public DateOnly? EarnLeaveEndYear { get; set; }

    public int? PayableDays { get; set; }

    public int? WorkingDays { get; set; }

    public bool? IsSeperate { get; set; }

    public short? SpendDays { get; set; }

    public DateOnly? EldateForReport { get; set; }
}
