using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VFirstInLastOut
{
    public string Badgenumber { get; set; } = null!;

    public string? AttDate { get; set; }

    public string? Intime { get; set; }

    public string? Outtime { get; set; }
}
