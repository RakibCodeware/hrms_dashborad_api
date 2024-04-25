using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPfBalanceSheet
{
    public string EmpId { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string DsgName { get; set; } = null!;

    public short? IsActive { get; set; }

    public double? OpeningBalance { get; set; }

    public double? EmpContribution { get; set; }

    public double? EmprContribution { get; set; }

    public double Profit { get; set; }

    public int? EmpTypeId { get; set; }

    public DateOnly? PfDate { get; set; }

    public double? PfEmpContribution { get; set; }

    public bool? PfMember { get; set; }

    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? EmpCardNo { get; set; }
}
