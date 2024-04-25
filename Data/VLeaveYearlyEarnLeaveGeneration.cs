using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VLeaveYearlyEarnLeaveGeneration
{
    public long Sl { get; set; }

    public string? EmpId { get; set; }

    public int? EmpTypeId { get; set; }

    public double? NetTotal { get; set; }

    public string? DptId { get; set; }

    public string? DsgId { get; set; }

    public string? GenerateMonth { get; set; }

    public double? BasicSalary { get; set; }

    public DateOnly? GenerateDate { get; set; }

    public DateOnly? EarnLeavePerviousStartYear { get; set; }

    public DateOnly? EarnLeaveEndYear { get; set; }

    public string? DptName { get; set; }

    public string DsgName { get; set; } = null!;

    public string? GrdName { get; set; }

    public string? EmpName { get; set; }

    public string? EmpType { get; set; }

    public string? EmpCardNo { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string SftName { get; set; } = null!;

    public int? PayableDays { get; set; }

    public int? WorkingDays { get; set; }

    public short? SpendDays { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? SftId { get; set; }

    public DateOnly? EldateForReport { get; set; }
}
