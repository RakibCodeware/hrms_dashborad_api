using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VTblHolydayWork1
{
    public int Hcode { get; set; }

    public string? MonthYear { get; set; }

    public string? Hdate { get; set; }

    public string? Description { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? CompanyName { get; set; }
}
