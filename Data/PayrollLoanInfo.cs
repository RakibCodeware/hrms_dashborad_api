using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollLoanInfo
{
    public long LoanId { get; set; }

    public string? EmpId { get; set; }

    public string? CompanyId { get; set; }

    public double? LoanAmount { get; set; }

    public double? PaidAmount { get; set; }

    public double? InstallmentAmount { get; set; }

    public DateOnly? DeductFrom { get; set; }

    public int? PaidInstallmentNo { get; set; }

    public bool? IsPaid { get; set; }

    public bool? IsExemption { get; set; }

    public string? ExemptionReason { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public int? DeletedBy { get; set; }

    public string? DeletedReason { get; set; }

    public short? Status { get; set; }

    public string? StatusNote { get; set; }

    public DateOnly? StatusDate { get; set; }

    public DateTime? StatusUpdatedAt { get; set; }

    public int? StatusUpdatedBy { get; set; }

    public double? RefundAmount { get; set; }

    public virtual ICollection<PayrollLoanDetail> PayrollLoanDetails { get; set; } = new List<PayrollLoanDetail>();
}
