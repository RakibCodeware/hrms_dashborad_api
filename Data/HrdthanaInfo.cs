using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdthanaInfo
{
    public int ThaId { get; set; }

    public int DstId { get; set; }

    public string? ThaName { get; set; }

    public string? ThaNameBangla { get; set; }

    public virtual HrdDistrict Dst { get; set; } = null!;
}
