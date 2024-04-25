using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PersonnelEmpProximityChangeLog
{
    public int Sl { get; set; }

    public string? EmpId { get; set; }

    public string? EmpProximityNo { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }
}
