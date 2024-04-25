using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblHolydayWeekentEmployeeWise
{
    public long Hwcode { get; set; }

    public string? EmpId { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? Remarks { get; set; }

    public string? Hwtype { get; set; }

    public string? CompanyId { get; set; }

    public long? UserId { get; set; }

    public bool? IsUsed { get; set; }

    public string? DptId { get; set; }

    public string? DsgId { get; set; }

    public string? HwdayName { get; set; }
}
