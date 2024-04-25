using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class ShiftTransferInfoDetail
{
    public long Sl { get; set; }

    public long? Stid { get; set; }

    public DateOnly? Sdate { get; set; }

    public string? EmpId { get; set; }

    public string? DptId { get; set; }

    public string? DsgId { get; set; }

    public short? EmpTypeId { get; set; }

    public string? CompanyId { get; set; }

    public short? Fid { get; set; }

    public bool? IsWeekend { get; set; }

    public string? Notes { get; set; }

    public short? Gid { get; set; }

    public virtual ShiftTransferInfo? St { get; set; }
}
