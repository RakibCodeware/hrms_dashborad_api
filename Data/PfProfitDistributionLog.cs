using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PfProfitDistributionLog
{
    public int Sl { get; set; }

    public int FdrId { get; set; }

    public DateOnly DistributionDate { get; set; }

    public DateTime? DistributionTime { get; set; }

    public bool? IsManual { get; set; }

    public int? UserId { get; set; }
}
