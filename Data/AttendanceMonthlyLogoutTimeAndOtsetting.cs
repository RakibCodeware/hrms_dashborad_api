using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class AttendanceMonthlyLogoutTimeAndOtsetting
{
    public long Sl { get; set; }

    public DateOnly? MonthDate { get; set; }

    public bool? Chosen { get; set; }

    public int? LogoutHour { get; set; }

    public int? LogoutMin { get; set; }

    public int? NormallyOthour { get; set; }

    public string? MonthName { get; set; }

    public int? DecreaseOvertime { get; set; }

    public bool? IsDecreaseOvertime { get; set; }
}
