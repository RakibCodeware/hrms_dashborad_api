using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdEmpStatus
{
    public string EmpStatus { get; set; } = null!;

    public string? EmpStatusName { get; set; }
}
