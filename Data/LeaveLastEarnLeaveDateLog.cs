using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class LeaveLastEarnLeaveDateLog
{
    public string? EmpId { get; set; }

    public DateOnly? EarnLeaveDate { get; set; }
}
