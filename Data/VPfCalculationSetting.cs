using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPfCalculationSetting
{
    public string? CompanyId { get; set; }

    public double? EmpContribution { get; set; }

    public double? EmprContribution { get; set; }

    public double? RateofInterest { get; set; }

    public int? PfstartYear { get; set; }

    public int? PempPartStartyear { get; set; }

    public int? PempPartEndyear { get; set; }

    public int? PempEmprStartyear { get; set; }

    public int? PempEmprEndyear { get; set; }

    public int? PempEmprIrstStartyear { get; set; }

    public int? PempEmprIrstEndyear { get; set; }

    public string? CompanyName { get; set; }
}
