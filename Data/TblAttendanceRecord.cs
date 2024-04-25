using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblAttendanceRecord
{
    public string EmpId { get; set; } = null!;

    public DateTime Attdate { get; set; }

    public int? EmpTypeId { get; set; }

    public string? InHour { get; set; }

    public string? InMin { get; set; }

    public string? InSec { get; set; }

    public string? OutHour { get; set; }

    public string? OutMin { get; set; }

    public string? OutSec { get; set; }

    public TimeOnly? BreakStartTime { get; set; }

    public TimeOnly? BreakEndTime { get; set; }

    public string? Attstatus { get; set; }

    public string? StateStatus { get; set; }

    public string? AttManual { get; set; }

    public string? DailyStartTimeAltCloseTime { get; set; }

    public TimeOnly? OverTime { get; set; }

    public short? SftId { get; set; }

    public string? DptId { get; set; }

    public string? DsgId { get; set; }

    public string? CompanyId { get; set; }

    public short? Gid { get; set; }

    public TimeOnly? LateTime { get; set; }

    public TimeOnly? StayTime { get; set; }

    public string? OutStatus { get; set; }

    public short? TiffinCount { get; set; }

    public short? HolidayCount { get; set; }

    public short? PaybleDays { get; set; }

    public TimeOnly? OtherOverTime { get; set; }

    public TimeOnly? TotalOverTime { get; set; }

    public bool? OutDuty { get; set; }

    public string? ReferenceId { get; set; }

    public int? UserId { get; set; }

    public string? Remark { get; set; }

    public short? NightAllowCount { get; set; }

    public bool? LateForAttBonus { get; set; }

    public int? Odid { get; set; }

    public virtual HrdEmployeeType? EmpType { get; set; }
}
