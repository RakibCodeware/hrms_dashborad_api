using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VVVLeaveLeaveApplicationDetailsForLeaveBalanceReport
{
    public string EmpId { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpCardNo { get; set; }

    public string? Sex { get; set; }

    public int? Cl { get; set; }

    public int? Sl { get; set; }

    public int? Ml { get; set; }

    public int? Al { get; set; }

    public int? Opl { get; set; }

    public int? Ol { get; set; }

    public int? Total { get; set; }

    public int? LeaveDays { get; set; }

    public int? Remaining { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DsgId { get; set; }

    public string? DsgName { get; set; }

    public string? CompanyId { get; set; }

    public string? SftId { get; set; }

    public string? SftName { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public int Lwp { get; set; }

    public int PEl { get; set; }

    public int BEl { get; set; }
}
