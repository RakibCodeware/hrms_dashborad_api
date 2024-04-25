using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollLoanDetail
{
    public long LoanDetailsId { get; set; }

    public string? CompanyId { get; set; }

    public long? LoanId { get; set; }

    public DateOnly? LoanTakeDate { get; set; }

    public double? ParticularAmount { get; set; }

    public string? ParticularRemarks { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public int? DeletedBy { get; set; }

    public string? DeletedReason { get; set; }

    public virtual PayrollLoanInfo? Loan { get; set; }
}
