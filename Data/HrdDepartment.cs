using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdDepartment
{
    public short Sl { get; set; }

    public string DptId { get; set; } = null!;

    public string? CompanyId { get; set; }

    public string? DptName { get; set; }

    public string? DptNameBn { get; set; }

    public string? DptCode { get; set; }

    public bool? DptStatus { get; set; }

    public bool? IsHalfOt { get; set; }

    public bool? IsDelivery { get; set; }

    public virtual ICollection<HrdDesignation> HrdDesignations { get; set; } = new List<HrdDesignation>();
}
