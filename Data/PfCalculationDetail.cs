using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PfCalculationDetail
{
    public int PfcSn { get; set; }

    public string? MonthName { get; set; }

    public string? EmpId { get; set; }

    public double? OpeningBalance { get; set; }

    public double? EmpContributionPer { get; set; }

    public double? EmpContributionAmount { get; set; }

    public string? EmprContributionPer { get; set; }

    public double? EmprContributionAmount { get; set; }

    public double? InterestRate { get; set; }

    public double? InterestAmount { get; set; }
}
