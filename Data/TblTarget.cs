using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblTarget
{
    public short Tid { get; set; }

    public string? Did { get; set; }

    public string? DptId { get; set; }

    public short? LnId { get; set; }

    public DateOnly? TargetDate { get; set; }
}
