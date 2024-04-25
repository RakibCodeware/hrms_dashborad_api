using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VVDailyAttendanceSummary
{
    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string DsgName { get; set; } = null!;

    public string DsgId { get; set; } = null!;

    public string? EmpId { get; set; }

    public int A { get; set; }

    public int P { get; set; }

    public int Lv { get; set; }

    public int L { get; set; }

    public int Wh { get; set; }

    public int Sn { get; set; }

    public DateTime Attdate { get; set; }

    public short? SftId { get; set; }

    public string SftName { get; set; } = null!;

    public short? Gid { get; set; }

    public string Gname { get; set; } = null!;

    public string? EmpStatus { get; set; }

    public string? DptCode { get; set; }

    public bool? IsNightShiftForReport { get; set; }

    public int Total { get; set; }

    public int? EmpTypeId { get; set; }
}
