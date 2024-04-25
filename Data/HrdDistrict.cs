using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdDistrict
{
    public int DstId { get; set; }

    public string? Division { get; set; }

    public string? DstName { get; set; }

    public string? DstBangla { get; set; }

    public virtual ICollection<HrdthanaInfo> HrdthanaInfos { get; set; } = new List<HrdthanaInfo>();
}
