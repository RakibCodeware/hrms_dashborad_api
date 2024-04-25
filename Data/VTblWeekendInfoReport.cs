using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VTblWeekendInfoReport
{
    public string EmpId { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public string? EmpName { get; set; }

    public int? EmpTypeId { get; set; }

    public string? EmpType { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DsgId { get; set; }

    public string? DsgName { get; set; }

    public short? Gid { get; set; }

    public string? Gname { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? Weekends { get; set; }
}
