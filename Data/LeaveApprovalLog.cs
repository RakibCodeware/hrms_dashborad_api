using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class LeaveApprovalLog
{
    public int Sl { get; set; }

    public long? Lacode { get; set; }

    public int? UserId { get; set; }

    public DateTime? DateTime { get; set; }

    public short? Approval { get; set; }
}
