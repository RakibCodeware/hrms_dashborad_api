using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class EarnleaveSetting1
{
    public DateOnly? ElstartDate { get; set; }

    public string? Status { get; set; }

    public int? DurationDays { get; set; }

    public string? PaymentOn { get; set; }

    public int? WithdrawablePer { get; set; }
}
