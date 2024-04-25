using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VMonthlySalaryFlowReport
{
    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? Month { get; set; }

    public string? Year { get; set; }

    public string? MonthName { get; set; }

    public double? TotalSalary { get; set; }
}
