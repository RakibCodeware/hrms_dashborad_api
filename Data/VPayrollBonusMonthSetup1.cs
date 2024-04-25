using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollBonusMonthSetup1
{
    public string? BonusType { get; set; }

    public int? Year { get; set; }

    public int? Bid { get; set; }

    public string? CompanyId { get; set; }

    public string Rname { get; set; } = null!;

    public DateTime? SetupedDate { get; set; }

    public short? Rid { get; set; }
}
