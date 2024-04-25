using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PfCompanyRelation
{
    public int Sl { get; set; }

    public string PfcompanyId { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public string ProductDb { get; set; } = null!;

    public string ShortCode { get; set; } = null!;

    public virtual PfCompanyInfo Pfcompany { get; set; } = null!;
}
