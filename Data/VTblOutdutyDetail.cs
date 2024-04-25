using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VTblOutdutyDetail
{
    public string? EmpId { get; set; }

    public DateOnly? Date { get; set; }

    public short? Type { get; set; }

    public string? Remark { get; set; }

    public short? Status { get; set; }

    public short? Processing { get; set; }

    public int? AppliedBy { get; set; }

    public int? AuthorizedBy { get; set; }

    public DateTime? AppiedDate { get; set; }

    public string? EmpName { get; set; }

    public string? EmpCardNo { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyId { get; set; }

    public string? DptId { get; set; }

    public string? Place { get; set; }

    public DateTime? AuthorizedDate { get; set; }

    public string? DsgId { get; set; }

    public string? DsgName { get; set; }

    public string? DptName { get; set; }

    public string? AssignedBy { get; set; }

    public string? Address { get; set; }

    public int? EmpTypeId { get; set; }

    public string? EmpType { get; set; }

    public string? AuthorizedByName { get; set; }

    public string? AuthorizedByEmpCardNo { get; set; }

    public string? EmpProximityNo { get; set; }

    public bool? StraightFromHome { get; set; }

    public bool? StraightToHome { get; set; }

    public string? ClientName { get; set; }

    public string? InTime { get; set; }

    public string? OutTime { get; set; }

    public string? Purpose { get; set; }

    public int Sl { get; set; }
}
