using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblAttendanceRecordPunchLog
{
    public string? EmpId { get; set; }

    public DateTime? AttDate { get; set; }

    public string? PinHour { get; set; }

    public string? PinMin { get; set; }

    public string? PinSec { get; set; }

    public string? PoutHour { get; set; }

    public string? PoutMin { get; set; }

    public string? PoutSec { get; set; }
}
