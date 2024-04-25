using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPersonnelEmpSeparation
{
    public long EmpSeparationId { get; set; }

    public string EmpId { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public DateOnly EffectiveDate { get; set; }

    public string? EmpStatus { get; set; }

    public string? EmpStatusName { get; set; }

    public string? Remarks { get; set; }

    public int? EmpTypeId { get; set; }

    public string? EmpType { get; set; }

    public DateOnly? EntryDate { get; set; }

    public string? EmpName { get; set; }

    public bool? IsActive { get; set; }

    public string? YearMonth { get; set; }

    public int Sn { get; set; }

    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public short SftId { get; set; }

    public string SftName { get; set; } = null!;

    public int? UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? DptName { get; set; }

    public string? DsgName { get; set; }
}
