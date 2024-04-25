using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblOutDutyApprovalLog
{
    public int Sl { get; set; }

    public int? Odid { get; set; }

    public int? UserId { get; set; }

    public DateTime? DateTime { get; set; }

    public short? Approval { get; set; }

    public virtual TblOutDuty? Od { get; set; }
}
