using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PersonnelSeparationActivationLog
{
    public int Sl { get; set; }

    public string? EmpId { get; set; }

    public long? EmpSeparationId { get; set; }

    public DateOnly? ActiveDate { get; set; }

    public string? Remark { get; set; }

    public int? UserId { get; set; }
}
