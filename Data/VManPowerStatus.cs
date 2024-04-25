using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VManPowerStatus
{
    public string EmpId { get; set; } = null!;

    public int? EmpTypeId { get; set; }

    public string? EmpStatus { get; set; }

    public string DptId { get; set; } = null!;

    public string? DptName { get; set; }

    public string DsgId { get; set; } = null!;

    public string DsgName { get; set; } = null!;

    public short? Male { get; set; }

    public short? Female { get; set; }

    public int Sn { get; set; }

    public bool? ActiveSalary { get; set; }

    public short? IsActive { get; set; }

    public string? EmpCardNo { get; set; }

    public string? SftId { get; set; }
}
