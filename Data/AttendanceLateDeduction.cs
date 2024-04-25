using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class AttendanceLateDeduction
{
    public int Ldid { get; set; }

    public string? CompanyId { get; set; }

    public string? LeaveName { get; set; }

    public short? LateDays { get; set; }

    public bool? IsDeduction { get; set; }

    public short? NoDeductionDays { get; set; }

    public DateOnly? Entrydate { get; set; }

    public string? Notes { get; set; }
}
