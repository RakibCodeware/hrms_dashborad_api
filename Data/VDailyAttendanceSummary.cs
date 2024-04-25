using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VDailyAttendanceSummary
{
    public int Sn { get; set; }

    public string? EmpId { get; set; }

    public string DsgName { get; set; } = null!;

    public string? DptName { get; set; }

    public short? Male { get; set; }

    public short? Female { get; set; }

    public short? Present { get; set; }

    public short? Absent { get; set; }

    public short? Leave { get; set; }

    public string DptId { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public bool? ActiveSalary { get; set; }

    public short? IsActive { get; set; }
}
