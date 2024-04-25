using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollHolidayWeekendBill
{
    public long Sl { get; set; }

    public string? EmpCardNo { get; set; }

    public string? EmpId { get; set; }

    public DateOnly? AttDate { get; set; }

    public string? InHour { get; set; }

    public string? InMin { get; set; }

    public string? OutHour { get; set; }

    public string? OutMin { get; set; }

    public string? Did { get; set; }

    public string? DptId { get; set; }

    public int? EmpTypeId { get; set; }

    public string? DsgId { get; set; }

    public string? LnId { get; set; }

    public string? TotalWorkHour { get; set; }

    public string TotalWorkMin { get; set; } = null!;

    public string? StayTime { get; set; }
}
