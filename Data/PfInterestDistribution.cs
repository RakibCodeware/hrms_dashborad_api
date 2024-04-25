using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PfInterestDistribution
{
    public string? CompanyId { get; set; }

    public int? FdrId { get; set; }

    public string? EmpId { get; set; }

    public double? InterestAmount { get; set; }
}
