using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblEmpWiseWeekendinfo
{
    public int Sl { get; set; }

    public string? CompanyId { get; set; }

    public string? DptId { get; set; }

    public short? Gid { get; set; }

    public string? DsgId { get; set; }

    public string EmpId { get; set; } = null!;

    public DateOnly Date { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual PersonnelEmployeeInfo Emp { get; set; } = null!;
}
