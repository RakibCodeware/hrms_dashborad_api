using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class AttBreakTimeSchedule
{
    public short? Id { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? Note { get; set; }
}
