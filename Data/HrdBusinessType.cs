using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdBusinessType
{
    public short Bid { get; set; }

    public string? BtypeName { get; set; }

    public bool? IsActive { get; set; }
}
