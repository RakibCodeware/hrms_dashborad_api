using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollLoanMonthlySetup
{
    public long Sl { get; set; }

    public long? LoanId { get; set; }

    public string EmpId { get; set; } = null!;

    public string CompanyId { get; set; } = null!;

    public DateOnly Month { get; set; }

    public double? Amount { get; set; }

    public bool? IsPaid { get; set; }
}
