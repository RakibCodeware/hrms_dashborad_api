using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class AttendanceWeekendInfo
{
    public long Sl { get; set; }

    public long? MonthId { get; set; }

    public string? Weekend { get; set; }

    public DateOnly? WeekendDate { get; set; }

    public string? Reason { get; set; }

    public string? CompanyId { get; set; }

    public virtual HrdCompanyInfo? Company { get; set; }

    public virtual TblMonthSetup? Month { get; set; }
}
