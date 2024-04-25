using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TotalPresentForJobCard
{
    public int Si { get; set; }

    public string? EmpId { get; set; }

    public string? Absent { get; set; }

    public string? Cl { get; set; }

    public string? Sl { get; set; }

    public string? Ml { get; set; }

    public string? El { get; set; }

    public string? Holiday { get; set; }

    public string? Present { get; set; }

    public string? Weekend { get; set; }

    public string? Apday { get; set; }
}
