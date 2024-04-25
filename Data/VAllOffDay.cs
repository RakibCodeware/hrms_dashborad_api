using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VAllOffDay
{
    public long Sl { get; set; }

    public string? CompanyId { get; set; }

    public DateOnly? Offdate { get; set; }

    public string? Reason { get; set; }
}
