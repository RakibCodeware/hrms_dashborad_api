using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PersonnelEmergencyContact
{
    public int Id { get; set; }

    public string EmpId { get; set; } = null!;

    public string? ContactName { get; set; }

    public string? EmergencyAddress { get; set; }

    public string? EmpRelation { get; set; }

    public string? EmergencyPhoneNo { get; set; }

    public string? JobDescription { get; set; }

    public string? Gender { get; set; }

    public string? Age { get; set; }

    public virtual PersonnelEmployeeInfo Emp { get; set; } = null!;
}
