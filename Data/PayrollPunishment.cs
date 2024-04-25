using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollPunishment
{
    public int Psn { get; set; }

    public string? CompanyId { get; set; }

    public string? EmpId { get; set; }

    public string? Pname { get; set; }

    public double? Pamount { get; set; }

    public string? MonthName { get; set; }
}
