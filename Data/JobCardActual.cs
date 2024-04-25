using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class JobCardActual
{
    public int Sl { get; set; }

    public string EmpId { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public string? EmpName { get; set; }

    public string? SftName { get; set; }

    public DateTime? Attdate { get; set; }

    public string? DptName { get; set; }

    public string? DsgName { get; set; }

    public string? LnCode { get; set; }

    public string? Dname { get; set; }

    public string? MonthName { get; set; }

    public string? InHour { get; set; }

    public string? InMin { get; set; }

    public string? OutHour { get; set; }

    public string? OutMin { get; set; }

    public string? Attstatus { get; set; }

    public string? StayTime { get; set; }

    public double? OverTime { get; set; }

    public string? EmpType { get; set; }

    public string? DptId { get; set; }

    public string? StateStatus { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public string? GrdName { get; set; }

    public string? InSec { get; set; }

    public string? OutSec { get; set; }

    public string? LateBy { get; set; }
}
