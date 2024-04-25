using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class ModulePageInfo
{
    public short? ModuleId { get; set; }

    public string? ModuleName { get; set; }

    public string? ModulePageName { get; set; }

    public string? PageTitle { get; set; }

    public byte? Ordering { get; set; }
}
