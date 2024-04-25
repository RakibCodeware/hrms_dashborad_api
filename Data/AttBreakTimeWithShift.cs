using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class AttBreakTimeWithShift
{
    public int Sl { get; set; }

    public int? SftId { get; set; }

    public int? BrkId { get; set; }

    public int? SpecialTimetableId { get; set; }

    public virtual AttBreakTime? Brk { get; set; }
}
