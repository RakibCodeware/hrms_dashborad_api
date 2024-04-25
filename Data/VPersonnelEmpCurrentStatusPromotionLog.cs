using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPersonnelEmpCurrentStatusPromotionLog
{
    public int Sn { get; set; }

    public string EmpId { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public string? EmpName { get; set; }

    public string? EmpNameBn { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DptNameBn { get; set; }

    public string? DsgId { get; set; }

    public string DsgName { get; set; } = null!;

    public string? DsgNameBn { get; set; }

    public int? EmpTypeId { get; set; }

    public string? EmpType { get; set; }

    public string? GrdName { get; set; }

    public string? GrdNameBangla { get; set; }

    public string? EffectiveMonth { get; set; }
}
