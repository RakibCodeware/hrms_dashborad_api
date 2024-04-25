using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VUserAccountForLeave
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? UserName { get; set; }

    public string? UserPassword { get; set; }

    public string Email { get; set; } = null!;

    public string? UserType { get; set; }

    public DateOnly? CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public bool? Status { get; set; }

    public string? CoockieInfo { get; set; }

    public string? CompanyId { get; set; }

    public string? EmpId { get; set; }

    public bool? IsLogin { get; set; }

    public DateTime? LoginDateTime { get; set; }

    public bool? IsLvAuthority { get; set; }

    public short? LvAuthorityOrder { get; set; }

    public short? LvAuthorityAction { get; set; }

    public short? LvEmpType { get; set; }

    public bool? LvOnlyDpt { get; set; }

    public string? DptId { get; set; }
}
