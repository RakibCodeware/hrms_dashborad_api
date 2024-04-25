using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollAdvanceSetting
{
    public string AdvanceId { get; set; } = null!;

    public string? EmpId { get; set; }

    public string? EmpCardNo { get; set; }

    public decimal? InstallmentAmount { get; set; }

    public short? PaidInstallmentNo { get; set; }

    public string? PaidMonth { get; set; }

    public string? EmpName { get; set; }

    public string DsgName { get; set; } = null!;

    public string? DptName { get; set; }

    public long Sl { get; set; }

    public short? InstallmentNo { get; set; }

    public DateOnly? StartMonth { get; set; }

    public decimal? AdvanceAmount { get; set; }

    public short? EmpTypeId { get; set; }
}
