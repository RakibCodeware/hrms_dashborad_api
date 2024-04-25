using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PfYearlyExpense
{
    public int Sl { get; set; }

    public string CompanyId { get; set; } = null!;

    public DateOnly Date { get; set; }

    public double? Expense { get; set; }
}
