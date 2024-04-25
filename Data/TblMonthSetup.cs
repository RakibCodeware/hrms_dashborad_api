using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblMonthSetup
{
    public long MonthId { get; set; }

    public string? MonthName { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public int? TotalDays { get; set; }

    public int? TotalWeekend { get; set; }

    public int? TotalHoliday { get; set; }

    public int? TotalWorkingDays { get; set; }

    public DateOnly? ExpectedPaymentDate { get; set; }

    public bool? MonthStatus { get; set; }

    public string? Did { get; set; }

    public int? UserId { get; set; }

    public string? CompanyId { get; set; }
}
