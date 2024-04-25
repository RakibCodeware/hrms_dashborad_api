using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VVTblAttendanceRecord
{
    public string EmpId { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public string? EmpName { get; set; }

    public string? Date { get; set; }

    public int? EmpTypeId { get; set; }

    public short? SftId { get; set; }

    public string? InTime { get; set; }

    public string? OutTime { get; set; }

    public string? Attstatus { get; set; }

    public string? StateStatus { get; set; }

    public string? AttDate { get; set; }

    public string? InTime12Format { get; set; }

    public string? OutTime12Format { get; set; }

    public string? AttManual { get; set; }

    public string? CompanyId { get; set; }
}
