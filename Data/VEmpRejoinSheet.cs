using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VEmpRejoinSheet
{
    public string? EmpName { get; set; }

    public string? GrdName { get; set; }

    public string DsgName { get; set; } = null!;

    public string? DptName { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public double? EmpPresentSalary { get; set; }

    public int Sn { get; set; }

    public string? EmpCardNo { get; set; }

    public string? EmpId { get; set; }

    public int? EmpTypeId { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public bool? ActiveSalary { get; set; }

    public short? IsActive { get; set; }

    public string? EffectiveMonth { get; set; }

    public string? DptId { get; set; }
}
