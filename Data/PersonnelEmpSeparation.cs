using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PersonnelEmpSeparation
{
    public long EmpSeparationId { get; set; }

    public string EmpId { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public DateOnly EffectiveDate { get; set; }

    public string? SeparationType { get; set; }

    public string? Remarks { get; set; }

    public int? EmpTypeId { get; set; }

    public DateOnly? EntryDate { get; set; }

    public bool? IsActive { get; set; }

    public int? UserId { get; set; }
}
