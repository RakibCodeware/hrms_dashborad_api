using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VatTaxMinimumTax
{
    public short? Id { get; set; }

    public int? MinimumTax { get; set; }

    public string? Area { get; set; }

    public bool? IsActive { get; set; }
}
