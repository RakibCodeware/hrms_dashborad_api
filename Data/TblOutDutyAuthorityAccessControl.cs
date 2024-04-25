using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblOutDutyAuthorityAccessControl
{
    public string? CompanyId { get; set; }

    public int Sl { get; set; }

    public string? EmpId { get; set; }

    public int? AuthorityId { get; set; }

    public short? AuthorityPosition { get; set; }

    public short? AuthorityAction { get; set; }

    public bool? IsDirectApprove { get; set; }

    public virtual PersonnelEmployeeInfo? Emp { get; set; }
}
