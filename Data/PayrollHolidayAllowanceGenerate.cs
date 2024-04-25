using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollHolidayAllowanceGenerate
{
    public int Sl { get; set; }

    public string? EmpId { get; set; }

    public DateOnly? Hdate { get; set; }

    public double? HolidayAllownce { get; set; }
}
