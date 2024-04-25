using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VLeaveShortLeave
{
    public string? EmpName { get; set; }

    public string? EmpCardNo { get; set; }

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

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string DsgName { get; set; } = null!;

    public short? LvStatus { get; set; }

    public string? DptId { get; set; }

    public short? IsActive { get; set; }

    public string? Expr1 { get; set; }

    public int? EmpTypeId { get; set; }

    public string? DptName { get; set; }
}
