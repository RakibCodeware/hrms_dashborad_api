using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VMonthlyOt
{
    public int Sn { get; set; }

    public string? EmpId { get; set; }

    public string? EmpCardNo { get; set; }

    public string? EmpName { get; set; }

    public string DsgName { get; set; } = null!;

    public double? Ot1 { get; set; }

    public double? Ot2 { get; set; }

    public string? DptName { get; set; }

    public int? EmpTypeId { get; set; }

    public short? IsActive { get; set; }

    public bool? ActiveSalary { get; set; }
}
