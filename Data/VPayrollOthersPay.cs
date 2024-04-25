using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollOthersPay
{
    public int Opsn { get; set; }

    public string? CompanyId { get; set; }

    public string? EmpId { get; set; }

    public string? Oppurpose { get; set; }

    public double? OtherPay { get; set; }

    public string IsActive { get; set; } = null!;

    public string? EmpName { get; set; }

    public string? CompanyName { get; set; }

    public string? EmpCardNo { get; set; }
}
