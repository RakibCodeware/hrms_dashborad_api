using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class MonthlyManpower
{
    public string? MonthName { get; set; }

    public int? TotalManpower { get; set; }

    public int? Nmale { get; set; }

    public int? Nfemale { get; set; }

    public int? Smale { get; set; }

    public int? Sfemale { get; set; }

    public int? Rmale { get; set; }

    public int? Rfemale { get; set; }

    public int? PtotalManpower { get; set; }

    public int? Pmale { get; set; }

    public int? Pfemale { get; set; }
}
