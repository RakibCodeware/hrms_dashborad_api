using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VUserPrivilegeList
{
    public short? ModuleId { get; set; }

    public string? PageTitle { get; set; }

    public string? ModulePageName { get; set; }

    public bool? ReadAction { get; set; }

    public bool? WriteAction { get; set; }

    public bool? UpdateAction { get; set; }

    public bool? DeleteAction { get; set; }

    public bool? AllAction { get; set; }

    public int? UserId { get; set; }

    public byte? Ordering { get; set; }
}
