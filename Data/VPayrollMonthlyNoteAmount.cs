using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollMonthlyNoteAmount
{
    public long Sl { get; set; }

    public int? NoteName { get; set; }

    public int? Amount { get; set; }

    public int? DptId { get; set; }

    public string? DptName { get; set; }

    public string? MonthName { get; set; }

    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public int? SftId { get; set; }

    public string SftName { get; set; } = null!;
}
