using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollBonusMonthSetup
{
    public int? Bid { get; set; }

    public long Sl { get; set; }

    public string? SlabType { get; set; }

    public string? EquivalentMonth { get; set; }

    public bool? Chosen { get; set; }

    public double? Percentage { get; set; }

    public string? BonusType { get; set; }

    public string? GenerateOn { get; set; }

    public DateTime? SetupedDate { get; set; }

    public virtual PayrollBonusSetup? BidNavigation { get; set; }
}
