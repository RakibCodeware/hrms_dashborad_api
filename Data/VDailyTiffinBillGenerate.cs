using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VDailyTiffinBillGenerate
{
    public string? EmpCardNo { get; set; }

    public string EmpId { get; set; } = null!;

    public int? OutHour { get; set; }

    public int? OutMin { get; set; }

    public DateTime Attdate { get; set; }

    public int? EmpTypeId { get; set; }

    public string? OutTime { get; set; }

    public DateTime? LogoutTime { get; set; }

    public short? IsActive { get; set; }

    public string? EmpName { get; set; }

    public string? EmpNameBn { get; set; }

    public double? TiffinAllownce { get; set; }

    public double? NightAllownce { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DsgName { get; set; }

    public string? DsgId { get; set; }

    public string? EmpType { get; set; }
}
