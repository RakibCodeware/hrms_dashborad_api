using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VLeaveLeaveApplicationDetail
{
    public long Lacode { get; set; }

    public int LeaveId { get; set; }

    public string EmpId { get; set; } = null!;

    public DateOnly? LeaveDate { get; set; }

    public bool? Used { get; set; }

    public string? LeaveName { get; set; }

    public string? ShortName { get; set; }

    public string? DptId { get; set; }

    public string? DsgId { get; set; }

    public string? SftId { get; set; }

    public string? EmpName { get; set; }

    public string? CompanyId { get; set; }

    public int? LeaveDays { get; set; }

    public string? EmpCardNo { get; set; }

    public string? DptName { get; set; }

    public string? DsgName { get; set; }

    public string? Sex { get; set; }

    public string? SftName { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? FromYear { get; set; }

    public DateOnly FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public bool? IsApproved { get; set; }

    public int? TotalDays { get; set; }

    public int EmpTypeId { get; set; }
}
