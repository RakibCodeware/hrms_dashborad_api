using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class AttendanceOverTimeCounter
{
    public int Sl { get; set; }

    public string? EmpId { get; set; }

    public DateOnly? AttDate { get; set; }

    public int? OverTime { get; set; }
}
