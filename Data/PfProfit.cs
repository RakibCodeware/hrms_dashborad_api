using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PfProfit
{
    public int Sl { get; set; }

    public int FdrId { get; set; }

    public string EmpId { get; set; } = null!;

    public DateOnly Month { get; set; }

    public double Profit { get; set; }
}
