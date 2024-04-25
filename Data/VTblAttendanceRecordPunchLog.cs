using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VTblAttendanceRecordPunchLog
{
    public string? PinHour { get; set; }

    public string? PinMin { get; set; }

    public string? PinSec { get; set; }

    public string? PoutHour { get; set; }

    public string? PoutMin { get; set; }

    public string? PoutSec { get; set; }

    public string? InHour { get; set; }

    public string? InMin { get; set; }

    public string? OutHour { get; set; }

    public string? OutMin { get; set; }

    public string? Attstatus { get; set; }

    public bool? OutDuty { get; set; }

    public string? EmpName { get; set; }

    public short? Gid { get; set; }

    public string Gname { get; set; } = null!;

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DptCode { get; set; }

    public string DsgName { get; set; } = null!;

    public string DsgId { get; set; } = null!;

    public short? SftId { get; set; }

    public string SftName { get; set; } = null!;

    public short? CustomOrdering { get; set; }

    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? EmpCardNo { get; set; }

    public string? InSec { get; set; }

    public string? OutSec { get; set; }

    public DateTime Attdate { get; set; }

    public string EmpId { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? AttManual { get; set; }
}
