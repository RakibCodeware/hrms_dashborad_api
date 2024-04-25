using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PfCompanyInfo
{
    public string PfcompanyId { get; set; } = null!;

    public string? PfcompanyName { get; set; }

    public string? Pfaddress { get; set; }

    public virtual ICollection<PfCompanyRelation> PfCompanyRelations { get; set; } = new List<PfCompanyRelation>();
}
