using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VTblHolydayWeekentEmployeeWise
{
    public long Hwcode { get; set; }

    public string? EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? Remarks { get; set; }

    public string? Hwtype { get; set; }

    public string? CompanyId { get; set; }

    public long? UserId { get; set; }

    public bool? IsUsed { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DsgId { get; set; }

    public string DsgName { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? HwdayName { get; set; }
}
