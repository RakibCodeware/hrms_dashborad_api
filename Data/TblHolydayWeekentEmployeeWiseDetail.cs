using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblHolydayWeekentEmployeeWiseDetail
{
    public long Sl { get; set; }

    public long? Hwcode { get; set; }

    public string? EmpId { get; set; }

    public DateOnly? Hwdate { get; set; }

    public bool? IsUsed { get; set; }

    public virtual TblHolydayWeekentEmployeeWise? HwcodeNavigation { get; set; }
}
