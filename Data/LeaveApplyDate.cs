using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class LeaveApplyDate
{
    public int LvAppId { get; set; }

    public string? EmpId { get; set; }

    public long? Lacode { get; set; }

    public DateOnly? LvDate { get; set; }
}
