using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class LeaveMaternityLeavePayment
{
    public int MateId { get; set; }

    public DateOnly? VoucherDate { get; set; }

    public string? EmpId { get; set; }

    public string? UsedLeave { get; set; }

    public string? PaymentAmount { get; set; }

    public string? Rate { get; set; }
}
