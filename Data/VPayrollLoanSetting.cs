using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollLoanSetting
{
    public long Sl { get; set; }

    public string LoanId { get; set; } = null!;

    public string? EmpId { get; set; }

    public string? EmpCardNo { get; set; }

    public short? EmpTypeId { get; set; }

    public short? InstallmentNo { get; set; }

    public string? StartMonth { get; set; }

    public decimal? InstallmentAmount { get; set; }

    public short? PaidInstallmentNo { get; set; }

    public string? PaidMonth { get; set; }

    public string? EmpName { get; set; }

    public string? DptName { get; set; }

    public string DsgName { get; set; } = null!;
}
