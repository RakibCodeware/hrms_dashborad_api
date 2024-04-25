using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VatTaxTaxCalculation
{
    public int? TaxId { get; set; }

    public string? EmpId { get; set; }

    public string? SlabName { get; set; }

    public double? Amount { get; set; }

    public int? Rate { get; set; }

    public double? TaxableAmount { get; set; }

    public int? OrderNo { get; set; }

    public virtual VatTaxIncomeTax? VatTaxIncomeTax { get; set; }
}
