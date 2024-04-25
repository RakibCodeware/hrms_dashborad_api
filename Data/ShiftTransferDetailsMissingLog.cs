using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class ShiftTransferDetailsMissingLog
{
    public int Sl { get; set; }

    public string? EmpId { get; set; }

    public int? ShiftId { get; set; }

    public DateOnly? Date { get; set; }

    public DateTime? InsertTime { get; set; }

    public string? Error { get; set; }

    public long? Stid { get; set; }

    public virtual ShiftTransferInfo? St { get; set; }
}
