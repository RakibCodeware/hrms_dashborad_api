using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VatTaxIncomeTaxDetailsLog
{
    public int Sl { get; set; }

    public string EmpId { get; set; } = null!;

    public DateOnly Month { get; set; }

    public double TaxAmount { get; set; }

    public string? TaxYears { get; set; }

    public bool? IsPaid { get; set; }

    public virtual PersonnelEmployeeInfo Emp { get; set; } = null!;
}
