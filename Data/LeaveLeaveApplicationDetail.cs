using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class LeaveLeaveApplicationDetail
{
    public long Sl { get; set; }

    public long? Lacode { get; set; }

    public string? EmpId { get; set; }

    public DateOnly? LeaveDate { get; set; }

    public bool? Used { get; set; }

    public virtual LeaveLeaveApplication? LacodeNavigation { get; set; }
}
