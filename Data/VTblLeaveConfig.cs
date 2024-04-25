using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VTblLeaveConfig
{
    public string? LeaveName { get; set; }

    public string? ShortName { get; set; }

    public int? LeaveDays { get; set; }

    public string? LeaveNature { get; set; }

    public bool? IsDeductionAllowed { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string CompanyId { get; set; } = null!;
}
