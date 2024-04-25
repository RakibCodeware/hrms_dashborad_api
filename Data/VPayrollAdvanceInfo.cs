using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollAdvanceInfo
{
    public string AdvanceId { get; set; } = null!;

    public string? EmpId { get; set; }

    public string? EmpCardNo { get; set; }

    public short? EmpTypeId { get; set; }

    public DateOnly? EntryDate { get; set; }

    public decimal? AdvanceAmount { get; set; }

    public short? InstallmentNo { get; set; }

    public DateOnly? StartMonth { get; set; }

    public short? PaidInstallmentNo { get; set; }

    public bool? PaidStatus { get; set; }

    public string? Notes { get; set; }

    public string? EmpType { get; set; }

    public decimal? InstallmentAmount { get; set; }

    public string? EmpName { get; set; }

    public long Sl { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string DsgName { get; set; } = null!;

    public string? DsgNameBn { get; set; }

    public string? DptNameBn { get; set; }

    public int? SftId { get; set; }

    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }
}
