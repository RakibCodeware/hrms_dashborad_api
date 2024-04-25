using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PfActivityLog
{
    public int Sl { get; set; }

    public string? EmpId { get; set; }

    public DateOnly? Pfdate { get; set; }

    public double? Pfamount { get; set; }

    public bool? ActivityStatus { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }
}
