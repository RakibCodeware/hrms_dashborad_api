using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VHrdDepartment
{
    public string DptId { get; set; } = null!;

    public string? DptName { get; set; }

    public string? DptNameBn { get; set; }

    public bool? DptStatus { get; set; }

    public short Sl { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyId { get; set; }

    public string? DptCode { get; set; }
}
