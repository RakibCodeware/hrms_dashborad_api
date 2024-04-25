using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollHolidayAllowanceGenerate
{
    public int Sl { get; set; }

    public string? EmpId { get; set; }

    public string? MonthYear { get; set; }

    public string? Hdate { get; set; }

    public double? HolidayAllownce { get; set; }
}
