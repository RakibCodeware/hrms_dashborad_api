using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VVVLeaveYearlyStatus
{
    public string EmpId { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? EmpCardNo { get; set; }

    public int? ClSpend { get; set; }

    public int? ClTotal { get; set; }

    public int? ClRemaining { get; set; }

    public int? SlSpend { get; set; }

    public int? SlTotal { get; set; }

    public int? SlRemaining { get; set; }

    public int? AlSpend { get; set; }

    public int? AlTotal { get; set; }

    public int? AlRemaining { get; set; }

    public int? MlSpend { get; set; }

    public int? MlTotal { get; set; }

    public int? MlRemaining { get; set; }

    public int? OplSpend { get; set; }

    public int? OplTotal { get; set; }

    public int? OplRemaining { get; set; }

    public int? OlSpend { get; set; }

    public int? OlTotal { get; set; }

    public int? OlRemaining { get; set; }

    public string? Sex { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DsgId { get; set; }

    public string? DsgName { get; set; }

    public string? CompanyId { get; set; }

    public string? SftId { get; set; }

    public string? SftName { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? Year { get; set; }
}
