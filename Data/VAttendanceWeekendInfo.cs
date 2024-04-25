using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VAttendanceWeekendInfo
{
    public long Sl { get; set; }

    public long? MonthId { get; set; }

    public string? MonthName { get; set; }

    public string? Weekend { get; set; }

    public DateOnly? WeekendDate { get; set; }

    public string? Reason { get; set; }

    public string? CompanyId { get; set; }
}
