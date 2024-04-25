using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VForShiftChangeReport
{
    public string? CompanyId { get; set; }

    public string SftName { get; set; } = null!;

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public TimeOnly? SftStartTime { get; set; }

    public TimeOnly? SftEndTime { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public int? SftId { get; set; }
}
