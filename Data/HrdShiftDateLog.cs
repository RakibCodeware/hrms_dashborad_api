using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdShiftDateLog
{
    public string? CompanyId { get; set; }

    public int? SftId { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public TimeOnly? SftStartTime { get; set; }

    public TimeOnly? SftEndTime { get; set; }
}
