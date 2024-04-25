using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdSheet
{
    public string? Sheet { get; set; }

    public string? SheetTitle { get; set; }

    public bool? IsActive { get; set; }
}
