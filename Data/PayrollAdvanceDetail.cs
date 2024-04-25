using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollAdvanceDetail
{
    public string? AdvanceId { get; set; }

    public string? InstallmentMonth { get; set; }

    public decimal? InstallmentAmount { get; set; }

    public bool? PaidStatus { get; set; }

    public string? Notes { get; set; }

    public virtual PayrollAdvanceInfo? Advance { get; set; }
}
