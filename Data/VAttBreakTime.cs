using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VAttBreakTime
{
    public int Sl { get; set; }

    public string? Title { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public int? Ordering { get; set; }

    public TimeOnly? BreakTime { get; set; }

    public bool? NextDay { get; set; }

    public string? BreakId { get; set; }

    public bool? IsHoliday { get; set; }

    public bool? IsActive { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? Note { get; set; }
}
