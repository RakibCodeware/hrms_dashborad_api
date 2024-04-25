using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VEarnLeaveGenerateAccount
{
    public int Sn { get; set; }

    public string? EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? EmpCardNo { get; set; }

    public int? EmpTypeId { get; set; }

    public string? EmpType { get; set; }

    public int? TotalDays { get; set; }

    public bool? ActiveSalary { get; set; }
}
