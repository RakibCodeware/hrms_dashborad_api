using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdReligion
{
    public string Rname { get; set; } = null!;

    public short Rid { get; set; }

    public string? RnameBn { get; set; }
}
