using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdAdvanceStatus
{
    public int StatusId { get; set; }

    public string? Status { get; set; }

    public bool? IsActive { get; set; }
}
