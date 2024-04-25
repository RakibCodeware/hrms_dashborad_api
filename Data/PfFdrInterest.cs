using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PfFdrInterest
{
    public int Id { get; set; }

    public int? FdrId { get; set; }

    public int? InterestAmount { get; set; }

    public int? Charge { get; set; }

    public int? NetInterest { get; set; }

    public DateOnly? WithdrawDate { get; set; }

    public int? TaxChargePer { get; set; }

    public int? TaxCharge { get; set; }

    public virtual PfFdr? Fdr { get; set; }
}
