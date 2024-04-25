using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollAdvanceInfo
{
    public long Sl { get; set; }

    public string AdvanceId { get; set; } = null!;

    public string? EmpId { get; set; }

    public string? EmpCardNo { get; set; }

    public short? EmpTypeId { get; set; }

    public DateOnly? EntryDate { get; set; }

    public decimal? AdvanceAmount { get; set; }

    public short? InstallmentNo { get; set; }

    public decimal? InstallmentAmount { get; set; }

    public DateOnly? StartMonth { get; set; }

    public short? PaidInstallmentNo { get; set; }

    public bool? PaidStatus { get; set; }

    public string? Notes { get; set; }

    public string? CompanyId { get; set; }

    public int? SftId { get; set; }

    public virtual HrdCompanyInfo? Company { get; set; }
}
