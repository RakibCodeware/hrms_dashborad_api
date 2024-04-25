using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class LeaveLeaveType
{
    public string LeaveName { get; set; } = null!;

    public string LeaveNameId { get; set; } = null!;

    public string LeaveShortName { get; set; } = null!;

    public int Order { get; set; }

    public bool? IsActive { get; set; }
}
