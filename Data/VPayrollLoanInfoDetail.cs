using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollLoanInfoDetail
{
    public string? EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DsgId { get; set; }

    public string DsgName { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public string? EmpProximityNo { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public double? EmpPresentSalary { get; set; }

    public double? BasicSalary { get; set; }

    public int? EmpTypeId { get; set; }

    public string? EmpType { get; set; }

    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public long LoanId { get; set; }

    public double? LoanAmount { get; set; }

    public double? PaidAmount { get; set; }

    public double? InstallmentAmount { get; set; }

    public DateOnly? DeductFrom { get; set; }

    public int? PaidInstallmentNo { get; set; }

    public bool? IsPaid { get; set; }

    public bool? IsExemption { get; set; }

    public string? ExemptionReason { get; set; }

    public long LoanDetailsId { get; set; }

    public DateOnly? LoanTakeDate { get; set; }

    public double? ParticularAmount { get; set; }

    public string? ParticularRemarks { get; set; }

    public short? CustomOrdering { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsDeletedDetails { get; set; }

    public short? StatusId { get; set; }

    public string? Status { get; set; }

    public string LastInstallmentAt { get; set; } = null!;

    public string InstallmentMonth { get; set; } = null!;

    public int InstallmentAmountPaid { get; set; }
}
