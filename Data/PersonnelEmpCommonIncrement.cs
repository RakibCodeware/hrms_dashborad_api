using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PersonnelEmpCommonIncrement
{
    public int CommonIncId { get; set; }

    public short? EmpTypeId { get; set; }

    public decimal? AmountPercentage { get; set; }

    public string? EffectiveMonth { get; set; }

    public string? Remarks { get; set; }

    public DateOnly? EntryDate { get; set; }

    public int? UserId { get; set; }

    public bool? IsActivated { get; set; }
}
