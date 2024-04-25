using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdFloor
{
    public short Fid { get; set; }

    public string? Fname { get; set; }

    public string? FnameBn { get; set; }

    public bool? IsActive { get; set; }

    public string? Remarks { get; set; }
}
