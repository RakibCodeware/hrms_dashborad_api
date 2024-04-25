using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class EarnleaveReserved
{
    public int Sl { get; set; }

    public long? PaymentId { get; set; }

    public string? CompanyId { get; set; }

    public string? EmpId { get; set; }

    public DateOnly? ReserveFor { get; set; }

    public DateOnly? GenerateDate { get; set; }

    public double? ReserveEeanLeaveDays { get; set; }

    public DateTime? EntryDatetime { get; set; }

    public virtual PayrollEarnLeavePaymentSheet? Payment { get; set; }
}
