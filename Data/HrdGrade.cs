using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdGrade
{
    public short Sl { get; set; }

    public string GrdId { get; set; } = null!;

    public string GrdName { get; set; } = null!;

    public string? GrdNameBangla { get; set; }

    public bool? GrdStatus { get; set; }
}
