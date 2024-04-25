using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdOthersSetting
{
    public int Sl { get; set; }

    public string? WorkerTiffinHour { get; set; }

    public string? WorkerTiffinMin { get; set; }

    public string? StaffTiffinHour { get; set; }

    public string? StaffTiffinMin { get; set; }

    public string? AcceptableMinuteasOt { get; set; }

    public string? WorkerNightBillHour { get; set; }

    public string? WorkerNightBillMin { get; set; }

    public string? StaffNightBillHour { get; set; }

    public string? StaffNightBillMni { get; set; }

    public string? StaffHolidayTotalHour { get; set; }

    public string? StaffHolidayTotalMin { get; set; }

    public double? WorkerTiffinTaka { get; set; }

    public double? StaffTiffinTaka { get; set; }

    public bool? StaffHolidayCount { get; set; }

    public string? CompanyId { get; set; }

    public string? MinWorkingHour { get; set; }

    public string? MinWorkingMin { get; set; }

    public string? MinOverTimeHour { get; set; }

    public string? MinOverTimeMin { get; set; }

    public string? BreakBeforeStartOtasMin { get; set; }

    public double? NightBillTk { get; set; }

    public int? LeaveEntryValidateDays { get; set; }

    public int? MinimumCompletedDaysForLv { get; set; }
}
