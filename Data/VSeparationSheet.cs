using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VSeparationSheet
{
    public string EmpId { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public string? EmpName { get; set; }

    public int? EmpTypeId { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DsgId { get; set; }

    public string DsgName { get; set; } = null!;

    public string? GrdName { get; set; }

    public DateOnly EffectiveDate { get; set; }

    public string? SeparationType { get; set; }

    public string? Remarks { get; set; }

    public string? EmpStatusName { get; set; }

    public int Sn { get; set; }

    public string? EffectiveDateMonth { get; set; }

    public bool? ActiveSalary { get; set; }

    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string SftName { get; set; } = null!;

    public string? Efmonth { get; set; }

    public string? Address { get; set; }

    public short? IsActive { get; set; }
}
