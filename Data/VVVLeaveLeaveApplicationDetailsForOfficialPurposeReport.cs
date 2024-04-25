using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VVVLeaveLeaveApplicationDetailsForOfficialPurposeReport
{
    public string EmpId { get; set; } = null!;

    public string? EmpCardNo { get; set; }

    public string? EmpName { get; set; }

    public int Opl { get; set; }

    public int Jan { get; set; }

    public int Feb { get; set; }

    public int Mar { get; set; }

    public int Apr { get; set; }

    public int May { get; set; }

    public int Jun { get; set; }

    public int Jul { get; set; }

    public int Aug { get; set; }

    public int Sep { get; set; }

    public int Oct { get; set; }

    public int Nov { get; set; }

    public int Dec { get; set; }

    public string? SftId { get; set; }

    public string? SftName { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? MonthYear { get; set; }

    public string? Year { get; set; }

    public DateOnly? LeaveDate { get; set; }

    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public int? Total { get; set; }
}
