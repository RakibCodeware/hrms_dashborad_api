using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VVLeaveLeaveApplicationDetail
{
    public int EmpTypeId { get; set; }

    public string? CompanyId { get; set; }

    public string? EmpName { get; set; }

    public string EmpId { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public string? ShortName { get; set; }

    public int Cl { get; set; }

    public int Sl { get; set; }

    public int Ml { get; set; }

    public int Al { get; set; }

    public int Opl { get; set; }

    public int Ol { get; set; }

    public DateOnly? LeaveDate { get; set; }

    public string? DptId { get; set; }

    public string? DsgId { get; set; }

    public string? SftId { get; set; }

    public string? SftName { get; set; }

    public int? LeaveDays { get; set; }

    public string? DptName { get; set; }

    public string? DsgName { get; set; }

    public string? Sex { get; set; }

    public bool? Used { get; set; }

    public string? Month { get; set; }

    public string? Year { get; set; }

    public string? MonthYear { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }
}
