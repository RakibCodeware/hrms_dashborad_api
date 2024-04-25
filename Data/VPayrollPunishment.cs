using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollPunishment
{
    public int Psn { get; set; }

    public string? CompanyId { get; set; }

    public string? EmpId { get; set; }

    public string? Pname { get; set; }

    public double? Pamount { get; set; }

    public string? MonthName { get; set; }

    public string? EmpName { get; set; }

    public string? CompanyName { get; set; }

    public string? EmpCardNo { get; set; }
}
