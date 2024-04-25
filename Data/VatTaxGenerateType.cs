using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VatTaxGenerateType
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? CompanyId { get; set; }
}
