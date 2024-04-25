using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollMonthlyNoteAmount
{
    public long Sl { get; set; }

    public string? CompanyId { get; set; }

    public int? SftId { get; set; }

    public int? DptId { get; set; }

    public int? NoteName { get; set; }

    public int? Amount { get; set; }

    public string? MonthName { get; set; }
}
