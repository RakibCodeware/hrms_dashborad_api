using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VHrdGroup
{
    public short Gid { get; set; }

    public string? CompanyId { get; set; }

    public string? DptId { get; set; }

    public string Gname { get; set; } = null!;

    public string? GnameBn { get; set; }

    public bool? IsActive { get; set; }

    public string? DptName { get; set; }

    public string? CompanyName { get; set; }

    public string? DptNameBn { get; set; }
}
