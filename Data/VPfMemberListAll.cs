using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPfMemberListAll
{
    public string ShortCode { get; set; } = null!;

    public string PfcompanyId { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public string? EmpId { get; set; }

    public string ProductDb { get; set; } = null!;

    public string? MemberId { get; set; }

    public string? EmpCardNo { get; set; }

    public string? EmpName { get; set; }

    public DateOnly? PfDate { get; set; }

    public string DsgName { get; set; } = null!;

    public DateOnly? EmpJoiningDate { get; set; }

    public string? EmpProximityNo { get; set; }

    public int? EmpTypeId { get; set; }

    public string? EmpType { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public short? CustomOrdering { get; set; }
}
