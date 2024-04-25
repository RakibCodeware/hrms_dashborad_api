using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VVatTaxYear
{
    public string? Type { get; set; }

    public int TaxId { get; set; }

    public string? CompanyId { get; set; }

    public DateOnly? FromMonth { get; set; }

    public DateOnly? ToMonth { get; set; }

    public string? TaxYears { get; set; }

    public int? OrderNo { get; set; }

    public int? UserId { get; set; }

    public bool? IsPaid { get; set; }
}
