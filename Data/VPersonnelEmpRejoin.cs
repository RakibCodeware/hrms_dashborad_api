using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPersonnelEmpRejoin
{
    public int EmpRejoinId { get; set; }

    public string? EmpId { get; set; }

    public string? EmpCardNo { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public string? Remarks { get; set; }

    public int? EmpTypeId { get; set; }

    public string? EmpType { get; set; }
}
