using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PfFdr
{
    public int FdrId { get; set; }

    public string? CompanyId { get; set; }

    public string FdrNo { get; set; } = null!;

    public double? FdrAmount { get; set; }

    public double? InterestRate { get; set; }

    public double? InterestAmount { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public int? Period { get; set; }

    public string? Bank { get; set; }

    public string? Branch { get; set; }

    public int? Type { get; set; }
}
