using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PersonnelEmpExperience
{
    public string? EmpId { get; set; }

    public string? CompanyName { get; set; }

    public string? Designation { get; set; }

    public string? Responsibility { get; set; }

    public string? YearOfExp { get; set; }

    public DateOnly? JoiningDate { get; set; }

    public DateOnly? ResignDate { get; set; }

    public string? SpecialQualification { get; set; }

    public int Sn { get; set; }

    public virtual PersonnelEmployeeInfo? Emp { get; set; }
}
