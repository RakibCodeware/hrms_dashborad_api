using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VEmployeeExperience
{
    public string? EmpName { get; set; }

    public string? EmpCardNo { get; set; }

    public int? EmpTypeId { get; set; }

    public string? DptName { get; set; }

    public string DsgName { get; set; } = null!;

    public string? CompanyName { get; set; }

    public string? Designation { get; set; }

    public string? YearOfExp { get; set; }

    public DateOnly? JoiningDate { get; set; }

    public DateOnly? ResignDate { get; set; }

    public int Sn { get; set; }

    public bool? ActiveSalary { get; set; }
}
