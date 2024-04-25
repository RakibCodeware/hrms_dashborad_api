using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VUserAccount
{
    public int UserId { get; set; }

    public string? EmpName { get; set; }

    public string? EmpCardNo { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DsgName { get; set; }

    public string? Address { get; set; }

    public string? DptCode { get; set; }

    public string? UserName { get; set; }

    public string? UserPassword { get; set; }

    public string Email { get; set; } = null!;

    public string? UserType { get; set; }

    public bool? Status { get; set; }

    public string? CoockieInfo { get; set; }

    public string? EmpId { get; set; }

    public bool? IsLogin { get; set; }

    public bool? IsLvAuthority { get; set; }

    public short? LvAuthorityOrder { get; set; }

    public short? LvAuthorityAction { get; set; }

    public short? LvEmpType { get; set; }

    public bool? LvOnlyDpt { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyId { get; set; }

    public bool? CompanyType { get; set; }

    public string? ShortName { get; set; }

    public bool? IsCompliance { get; set; }
}
