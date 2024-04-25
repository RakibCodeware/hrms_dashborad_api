using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollBonusSetup1
{
    public int Bid { get; set; }

    public string? BonusName { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public DateOnly? ConfigDate { get; set; }

    public bool? Status { get; set; }

    public DateOnly? CalculationDate { get; set; }

    public string? Year { get; set; }

    public string? CompanyId { get; set; }

    public short? Rid { get; set; }
}
