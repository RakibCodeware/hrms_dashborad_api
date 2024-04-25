using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollLoanInfo
{
    public long Sl { get; set; }

    public string LoanId { get; set; } = null!;

    public string? EmpId { get; set; }

    public string? EmpCardNo { get; set; }

    public short? EmpTypeId { get; set; }

    public DateOnly? EntryDate { get; set; }

    public decimal? LoanAmount { get; set; }

    public short? InstallmentNo { get; set; }

    public decimal? InstallmentAmount { get; set; }

    public string? StartMonth { get; set; }

    public short? PaidInstallmentNo { get; set; }

    public bool? PaidStatus { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string DsgName { get; set; } = null!;

    public string? DsgNameBn { get; set; }

    public string? DptNameBn { get; set; }

    public string? EmpName { get; set; }

    public string? EmpType { get; set; }

    public string? Notes { get; set; }
}
