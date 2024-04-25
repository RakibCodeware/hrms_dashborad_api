using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class AttendanceTransferMedium
{
    public int Sl { get; set; }

    public string? EmpId { get; set; }

    public DateOnly? AttDate { get; set; }

    public short? Hur { get; set; }

    public short? Min { get; set; }

    public short? Sec { get; set; }
}
