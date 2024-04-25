using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPfMonthlyProfit
{
    public string EmpId { get; set; } = null!;

    public string? Month { get; set; }

    public double? Profit { get; set; }
}
