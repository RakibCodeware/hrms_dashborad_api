using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class EarnleaveMonthlyInfo
{
    public string? CompanyId { get; set; }

    public string EmpId { get; set; } = null!;

    public DateOnly Month { get; set; }

    public int? PresentDays { get; set; }

    public DateTime? EntryTime { get; set; }

    public int? PreMonthDays { get; set; }

    public int? NextMonthDays { get; set; }
}
