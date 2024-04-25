using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VEmpContactInfo
{
    public string? EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? EmpCardNo { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string DsgName { get; set; } = null!;

    public string DsgId { get; set; } = null!;

    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? SftId { get; set; }

    public string SftName { get; set; } = null!;

    public string? Address { get; set; }

    public string? ContactName { get; set; }

    public string? EmergencyAddress { get; set; }

    public string? EmpRelation { get; set; }

    public string? EmergencyPhoneNo { get; set; }

    public string? Gender { get; set; }

    public string? MobileNo { get; set; }

    public string? EmpStatus { get; set; }

    public int Sn { get; set; }

    public int? EmpTypeId { get; set; }

    public short? CustomOrdering { get; set; }

    public string? CompanyNameBangla { get; set; }

    public string? AddressBangla { get; set; }

    public string? DsgNameBn { get; set; }

    public string? DptNameBn { get; set; }

    public string? EmpNameBn { get; set; }
}
