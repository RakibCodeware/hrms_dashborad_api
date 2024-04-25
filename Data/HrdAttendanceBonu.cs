using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdAttendanceBonu
{
    public string? CompanyId { get; set; }

    public int? EmpTypeId { get; set; }

    public double? AttBonus { get; set; }
}
