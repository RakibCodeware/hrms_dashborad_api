using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VHrdShift
{
    public short SftId { get; set; }

    public string SftName { get; set; } = null!;

    public TimeOnly? SftStartTime { get; set; }

    public string? StartTime12Fromat { get; set; }

    public TimeOnly? SftEndTime { get; set; }

    public string? EndTime12Fomat { get; set; }

    public string? PunchCountTime12Fomat { get; set; }

    public string? EndPunchCountTime12Fomat { get; set; }

    public short? SftAcceptableLate { get; set; }

    public bool? SftOverTime { get; set; }

    public string Otstatus { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string ActiveStatus { get; set; } = null!;

    public string? Notes { get; set; }

    public string? FromDate { get; set; }

    public string? ToDate { get; set; }

    public short? AcceptableTimeAsOt { get; set; }

    public string? CompanyId { get; set; }

    public bool? IsInitial { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? SftNameBangla { get; set; }

    public TimeOnly? BreakStartTime { get; set; }

    public TimeOnly? BreakEndTime { get; set; }

    public bool? IsNight { get; set; }

    public bool? IsNightShiftForReport { get; set; }
}
