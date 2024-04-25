using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class AttAbsentNotificationLog
{
    public string EmpId { get; set; } = null!;

    public int AdminId { get; set; }

    public DateOnly Date { get; set; }

    public bool? Seen { get; set; }

    public DateOnly? LastWorkingDay { get; set; }
}
