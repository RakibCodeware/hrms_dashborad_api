using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollYearlyBonusSheet
{
    public long Sl { get; set; }

    public string? CompanyId { get; set; }

    public int? SftId { get; set; }

    public int? Bid { get; set; }

    public string? EmpId { get; set; }

    public string? EmpCardNo { get; set; }

    public int? EmpTypeId { get; set; }

    public double? PresentSalary { get; set; }

    public double? BasicSalary { get; set; }

    public double? Percentage { get; set; }

    public double? BonusAmount { get; set; }

    public string? DptId { get; set; }

    public string? DsgId { get; set; }

    public DateOnly? GenerateDate { get; set; }

    public string? BonusType { get; set; }

    public int? UserId { get; set; }

    public string? GenerateOn { get; set; }

    public int? TotalDays { get; set; }

    public string? EditStatus { get; set; }

    public virtual PayrollBonusSetup? BidNavigation { get; set; }
}
