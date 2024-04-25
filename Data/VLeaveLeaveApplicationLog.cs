using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VLeaveLeaveApplicationLog
{
    public long Lacode { get; set; }

    public int LeaveId { get; set; }

    public DateOnly FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public int? WeekHolydayNo { get; set; }

    public int? TotalDays { get; set; }

    public string? Remarks { get; set; }

    public string? StateStatus { get; set; }

    public string EmpId { get; set; } = null!;

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public bool? IsProcessessed { get; set; }

    public int EmpTypeId { get; set; }

    public DateOnly? PregnantDate { get; set; }

    public DateOnly? PrasaberaDate { get; set; }

    public DateOnly? EntryDate { get; set; }

    public string? CompanyId { get; set; }

    public short? SftId { get; set; }

    public string? ApprovedRejected { get; set; }

    public string? EmpName { get; set; }

    public string? NickName { get; set; }

    public string? ShortName { get; set; }

    public string? EmpCardNo { get; set; }

    public string? EmpType { get; set; }

    public string SftName { get; set; } = null!;

    public string? CompanyName { get; set; }

    public string? CompanyNameBangla { get; set; }

    public string? DptId { get; set; }

    public string? DsgId { get; set; }

    public string? DptName { get; set; }

    public string DsgName { get; set; } = null!;

    public string? EmpStatus { get; set; }

    public string? EmpStatusName { get; set; }

    public string? LeaveName { get; set; }

    public string CurrentProcessStatus { get; set; } = null!;

    public string? LeaveFormSlno { get; set; }

    public DateOnly? ApplyDate { get; set; }

    public string? FromYear { get; set; }

    public string? ToYear { get; set; }

    public short? Gid { get; set; }

    public string? Gname { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public short? LeaveProcessingOrder { get; set; }

    public string? LvAddress { get; set; }

    public string? LvContact { get; set; }

    public string? Address { get; set; }

    public string? AuthorizedBy { get; set; }

    public string? AuthorizedByCardNo { get; set; }

    public string? UserName { get; set; }
}
