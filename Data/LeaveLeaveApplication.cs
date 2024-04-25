using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class LeaveLeaveApplication
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

    public string? DptId { get; set; }

    public string? DsgId { get; set; }

    public string? EmpStatus { get; set; }

    public string? LeaveFormSlno { get; set; }

    public DateOnly? ApplyDate { get; set; }

    public short? LeaveProcessingOrder { get; set; }

    public string? LvAddress { get; set; }

    public string? LvContact { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public virtual HrdEmployeeType EmpType { get; set; } = null!;

    public virtual TblLeaveConfig Leave { get; set; } = null!;
}
