using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdSpecialTimetable
{
    public int Sl { get; set; }

    public int? EmpTypeId { get; set; }

    public TimeOnly? SftStartTime { get; set; }

    public TimeOnly? StartPunchCountTime { get; set; }

    public TimeOnly? SftEndTime { get; set; }

    public TimeOnly? EndPunchCountTime { get; set; }

    public short? SftAcceptableLate { get; set; }

    public string? CompanyId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Purpose { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
