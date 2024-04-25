using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class EarnleaveBalanceDetailsLog
{
    public int Sl { get; set; }

    public string? CompanyId { get; set; }

    public string? EmpId { get; set; }

    public DateOnly? EarnLeaveLastDate { get; set; }

    public DateOnly? GenerateDate { get; set; }

    public int? EarnLeaveDays { get; set; }

    public DateTime? EntryDatetime { get; set; }
}
