using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblLeaveApproval
{
    public string Lacode { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public string? EmpProximityNo { get; set; }

    public string? LeaveName { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public int? TotalDays { get; set; }

    public string? LeaveApplied { get; set; }

    public string? Remarks { get; set; }

    public string? StateStatus { get; set; }

    public string? StateRemarks { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public bool? IsProcessessed { get; set; }

    public string? DptCode { get; set; }
}
