using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PersonnelEmpEducation
{
    public int Sn { get; set; }

    public string? EmpId { get; set; }

    public string? Degree { get; set; }

    public string? Year { get; set; }

    public string? Institute { get; set; }

    public string? Result { get; set; }

    public virtual PersonnelEmployeeInfo? Emp { get; set; }
}
