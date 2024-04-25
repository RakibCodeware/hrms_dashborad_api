using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollAdvanceSetting
{
    public string AdvanceId { get; set; } = null!;

    public decimal? InstallmentAmount { get; set; }

    public short? PaidInstallmentNo { get; set; }

    public string? PaidMonth { get; set; }

    public virtual PayrollAdvanceInfo Advance { get; set; } = null!;
}
