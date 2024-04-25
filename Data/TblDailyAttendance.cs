using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblDailyAttendance
{
    public string? EmpId { get; set; }

    public short? Present { get; set; }

    public short? Absent { get; set; }

    public short? Leave { get; set; }
}
