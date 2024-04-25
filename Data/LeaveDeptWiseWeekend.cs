using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class LeaveDeptWiseWeekend
{
    public int Wdid { get; set; }

    public int? Did { get; set; }

    public int? DptId { get; set; }

    public DateOnly? EffectiveDateFrom { get; set; }

    public DateOnly? EffectiveDateTo { get; set; }

    public int? Days { get; set; }
}
