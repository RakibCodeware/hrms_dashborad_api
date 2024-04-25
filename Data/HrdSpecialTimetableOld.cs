using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdSpecialTimetableOld
{
    public TimeOnly? SftStartTime { get; set; }

    public string? SftStartTimeIndicator { get; set; }

    public TimeOnly? StartPunchCountTime { get; set; }

    public TimeOnly? SftEndTime { get; set; }

    public string? SftEndTimeIndicator { get; set; }

    public TimeOnly? EndPunchCountTime { get; set; }

    public short? SftAcceptableLate { get; set; }

    public bool? SftOverTime { get; set; }

    public short? AcceptableTimeAsOt { get; set; }

    public string? CompanyId { get; set; }

    public TimeOnly? BreakStartTime { get; set; }

    public TimeOnly? BreakEndTime { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool? IsNight { get; set; }
}
