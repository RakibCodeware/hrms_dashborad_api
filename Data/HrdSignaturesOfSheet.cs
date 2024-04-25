using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdSignaturesOfSheet
{
    public int Sl { get; set; }

    public string? Signature { get; set; }

    public string? Sheet { get; set; }

    public int? Ordering { get; set; }

    public bool? IsActive { get; set; }
}
