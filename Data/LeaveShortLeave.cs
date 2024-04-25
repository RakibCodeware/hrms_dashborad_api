using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class LeaveShortLeave
{
    public int SrLvId { get; set; }

    public string? LeaveId { get; set; }

    public string EmpId { get; set; } = null!;

    public string? CompanyId { get; set; }

    public DateOnly LvDate { get; set; }

    public TimeOnly? FromTime { get; set; }

    public TimeOnly? ToTime { get; set; }

    public TimeOnly LvTime { get; set; }

    public string? Remarks { get; set; }

    public short? LeaveProcessingOrder { get; set; }

    public short? LvStatus { get; set; }
}
