using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblOutDuty
{
    public int Sl { get; set; }

    public string? EmpId { get; set; }

    public DateOnly? Date { get; set; }

    public short? Type { get; set; }

    public string? Remark { get; set; }

    public string? Place { get; set; }

    public short? Status { get; set; }

    public short? Processing { get; set; }

    public int? AppliedBy { get; set; }

    public int? AuthorizedBy { get; set; }

    public DateTime? AppiedDate { get; set; }

    public DateTime? AuthorizedDate { get; set; }

    public string? DptId { get; set; }

    public string? DsgId { get; set; }

    public string? AssignedBy { get; set; }

    public TimeOnly? InTime { get; set; }

    public TimeOnly? OutTime { get; set; }

    public bool? StraightFromHome { get; set; }

    public bool? StraightToHome { get; set; }

    public virtual ICollection<TblOutdutyDetail> TblOutdutyDetails { get; set; } = new List<TblOutdutyDetail>();
}
