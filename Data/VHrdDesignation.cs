using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VHrdDesignation
{
    public string DsgId { get; set; } = null!;

    public string DsgName { get; set; } = null!;

    public string? DsgNameBn { get; set; }

    public string? DsgShortName { get; set; }

    public bool? DsgStatus { get; set; }

    public string? DptName { get; set; }

    public short Sl { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyId { get; set; }

    public string? DptId { get; set; }

    public int? Ordering { get; set; }
}
