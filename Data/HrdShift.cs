using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdShift
{
    public short SftId { get; set; }

    public string SftName { get; set; } = null!;

    public DateOnly? SftEffectiveDate { get; set; }

    public TimeOnly? SftStartTime { get; set; }

    public string? SftStartTimeIndicator { get; set; }

    public TimeOnly? StartPunchCountTime { get; set; }

    public TimeOnly? SftEndTime { get; set; }

    public string? SftEndTimeIndicator { get; set; }

    public short? SftAcceptableLate { get; set; }

    public bool? SftOverTime { get; set; }

    public bool? IsActive { get; set; }

    public string? Notes { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public short? AcceptableTimeAsOt { get; set; }

    public string? CompanyId { get; set; }

    public bool? IsInitial { get; set; }

    public string? DptId { get; set; }

    public string? SftNameBangla { get; set; }

    public TimeOnly? BreakStartTime { get; set; }

    public TimeOnly? BreakEndTime { get; set; }

    public TimeOnly? EndPunchCountTime { get; set; }

    public bool? IsNight { get; set; }

    public bool? IsNightShiftForReport { get; set; }
}
