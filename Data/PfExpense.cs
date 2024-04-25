using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PfExpense
{
    public int Sl { get; set; }

    public string EmpId { get; set; } = null!;

    public DateOnly Month { get; set; }

    public double Expense { get; set; }

    public virtual PersonnelEmployeeInfo Emp { get; set; } = null!;
}
