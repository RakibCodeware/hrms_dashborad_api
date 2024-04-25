using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VEarnleaveMonthlyInfo1
{
    public string EmpId { get; set; } = null!;

    public int? Year { get; set; }

    public int? PreJan { get; set; }

    public int? PJan { get; set; }

    public int? PFeb { get; set; }

    public int? PMar { get; set; }

    public int? PApr { get; set; }

    public int? PMay { get; set; }

    public int? PJun { get; set; }

    public int? PJul { get; set; }

    public int? PAug { get; set; }

    public int? PSep { get; set; }

    public int? POct { get; set; }

    public int? PNov { get; set; }

    public int? PDec { get; set; }

    public int? NDec { get; set; }
}
