using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollOthersPay
{
    public int Opsn { get; set; }

    public string? CompanyId { get; set; }

    public string? EmpId { get; set; }

    public string? Oppurpose { get; set; }

    public double? OtherPay { get; set; }

    public bool? IsActive { get; set; }
}
