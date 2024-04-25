using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VVForDailyMovementReport
{
    public string Badgenumber { get; set; } = null!;

    public DateTime Checktime { get; set; }

    public string? EmpName { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? EmpCardNo { get; set; }

    public string? DsgId { get; set; }

    public string DsgName { get; set; } = null!;

    public string? CompanyId { get; set; }

    public short? SftId { get; set; }

    public string SftName { get; set; } = null!;

    public string? CompanyName { get; set; }

    public string? Address { get; set; }
}
