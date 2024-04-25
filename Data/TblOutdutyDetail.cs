using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblOutdutyDetail
{
    public int Sl { get; set; }

    public int? Odid { get; set; }

    public string? ClientName { get; set; }

    public string? InTime { get; set; }

    public string? OutTime { get; set; }

    public string? Purpose { get; set; }

    public virtual TblOutDuty? Od { get; set; }
}
