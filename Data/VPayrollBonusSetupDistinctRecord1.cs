using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollBonusSetupDistinctRecord1
{
    public string? BonusType { get; set; }

    public int? Year { get; set; }

    public DateOnly? CalculationDate { get; set; }

    public int Bid { get; set; }

    public string? CompanyId { get; set; }
}
