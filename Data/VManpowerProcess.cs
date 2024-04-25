using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VManpowerProcess
{
    public short? Male { get; set; }

    public short? Female { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public DateOnly? EffectiveDateSeparation { get; set; }

    public string EmpId { get; set; } = null!;

    public int? Sn { get; set; }

    public string? EffectiveMonth { get; set; }

    public string? TypeOfChange { get; set; }

    public short? IsActive { get; set; }
}
