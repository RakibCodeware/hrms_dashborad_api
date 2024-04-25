using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdDesignation
{
    public short Sl { get; set; }

    public string DsgId { get; set; } = null!;

    public string? DptId { get; set; }

    public string DsgName { get; set; } = null!;

    public string? DsgNameBn { get; set; }

    public string? DsgShortName { get; set; }

    public bool? DsgStatus { get; set; }

    public double? HouseRentPersent { get; set; }

    public double? Medical { get; set; }

    public double? PfPersent { get; set; }

    public int? Ordering { get; set; }

    public virtual HrdDepartment? Dpt { get; set; }
}
