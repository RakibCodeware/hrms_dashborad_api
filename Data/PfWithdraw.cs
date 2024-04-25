using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PfWithdraw
{
    public string EmpId { get; set; } = null!;

    public DateOnly? WithdrawDate { get; set; }

    public double? EmpContribution { get; set; }

    public double? EmprContribution { get; set; }

    public double? Profit { get; set; }

    public int? PayableType { get; set; }

    public virtual PersonnelEmployeeInfo Emp { get; set; } = null!;
}
