using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PfPfrecord
{
    public int Sl { get; set; }

    public string EmpId { get; set; } = null!;

    public DateOnly Month { get; set; }

    public double? EmpContribution { get; set; }

    public double? EmprContribution { get; set; }

    public bool? IsManualEntry { get; set; }
}
