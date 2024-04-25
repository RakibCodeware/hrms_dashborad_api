using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VVatTaxRate
{
    public string? CompanyName { get; set; }

    public string? SlabName { get; set; }

    public int? FromTaka { get; set; }

    public int? ToTaka { get; set; }

    public double? IncomeTaxRate { get; set; }

    public int? RateOrder { get; set; }

    public int Rsn { get; set; }

    public string? CompanyId { get; set; }

    public short? Taxpayer { get; set; }
}
