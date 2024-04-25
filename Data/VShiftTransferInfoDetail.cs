using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VShiftTransferInfoDetail
{
    public long Stid { get; set; }

    public short? SftId { get; set; }

    public string SftName { get; set; } = null!;

    public string? EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? EmpCardNo { get; set; }

    public short? Fid { get; set; }

    public string? Fname { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public long Sl { get; set; }

    public DateOnly? Sdate { get; set; }

    public string? Day { get; set; }

    public string? EmpType { get; set; }

    public string? DsgId { get; set; }

    public string DsgName { get; set; } = null!;

    public short? EmpTypeId { get; set; }

    public string? CompanyId { get; set; }

    public bool? IsWeekend { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public DateOnly? TfromDate { get; set; }

    public DateOnly? TtoDate { get; set; }

    public string? EmpProximityNo { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Notes { get; set; }

    public short? Gid { get; set; }

    public string? Gname { get; set; }

    public string? EmpStatus { get; set; }

    public string? SftStartTimeIndicator { get; set; }

    public string? SftEndTimeIndicator { get; set; }

    public TimeOnly? SftStartTime { get; set; }

    public TimeOnly? SftEndTime { get; set; }

    public bool? SftOverTime { get; set; }

    public short? AcceptableTimeAsOt { get; set; }

    public short? SftAcceptableLate { get; set; }

    public TimeOnly? StartPunchCountTime { get; set; }

    public TimeOnly? BreakStartTime { get; set; }

    public TimeOnly? BreakEndTime { get; set; }

    public TimeOnly? EndPunchCountTime { get; set; }

    public bool? IsNight { get; set; }
}
