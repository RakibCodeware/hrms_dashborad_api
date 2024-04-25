using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class AttSpecialBreakTime
{
    public int Sl { get; set; }

    public string? Title { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public TimeOnly? BreakTime { get; set; }

    public bool? NextDay { get; set; }

    public bool? IsActive { get; set; }

    public DateOnly? Date { get; set; }

    public string? DutyType { get; set; }

    public string? CompanyId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
