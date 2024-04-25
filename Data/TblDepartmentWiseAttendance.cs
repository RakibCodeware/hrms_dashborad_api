using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblDepartmentWiseAttendance
{
    public int Dwatten { get; set; }

    public int? MonthId { get; set; }

    public string? DivisionId { get; set; }

    public string? DptId { get; set; }

    public string? AttenStatus { get; set; }

    public DateOnly? DateIn { get; set; }

    public DateOnly? DateOut { get; set; }

    public int? TimeInHr { get; set; }

    public int? TimeInMin { get; set; }

    public int? TimeOutForLunchHr { get; set; }

    public int? TimeOutForLunchMin { get; set; }

    public int? TimeInAfterLunchHr { get; set; }

    public int? TimeInAfterLunchMin { get; set; }

    public int? TimeOutHr { get; set; }

    public int? TimeOutMin { get; set; }
}
