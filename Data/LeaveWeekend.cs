using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class LeaveWeekend
{
    public int Wid { get; set; }

    public int? Did { get; set; }

    public int? DptId { get; set; }

    public int? DsgId { get; set; }

    public string? EmpCardNo { get; set; }

    public DateOnly? EffectiveDateFrom { get; set; }

    public DateOnly? EffectiveDateTo { get; set; }

    public int? Days { get; set; }
}
