using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPayrollYearlyBonusSheet1
{
    public string? EmpCardNo { get; set; }

    public int? EmpTypeId { get; set; }

    public double? PresentSalary { get; set; }

    public double? BasicSalary { get; set; }

    public double? BonusAmount { get; set; }

    public double? Percentage { get; set; }

    public long Sl { get; set; }

    public string? EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? EmpNameBn { get; set; }

    public string? DptId { get; set; }

    public string? DptName { get; set; }

    public string? DptNameBn { get; set; }

    public string? DsgId { get; set; }

    public string DsgName { get; set; } = null!;

    public string? DsgNameBn { get; set; }

    public string? DsgShortName { get; set; }

    public string? GrdName { get; set; }

    public DateOnly? GenerateDate { get; set; }

    public short? Year { get; set; }

    public string? EmpType { get; set; }

    public string? GenerateOn { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public string? SalaryCount { get; set; }

    public int? Bid { get; set; }

    public int? TotalDays { get; set; }

    public string? CompanyId { get; set; }

    public int? SftId { get; set; }

    public string? CompanyName { get; set; }

    public int Staff { get; set; }

    public int Worker { get; set; }

    public string SftName { get; set; } = null!;

    public string? Address { get; set; }

    public string? BonusMonth { get; set; }

    public string? BonusType { get; set; }

    public short? CustomOrdering { get; set; }

    public string? DptCode { get; set; }

    public DateOnly? CalculationDate { get; set; }

    public short? Gid { get; set; }

    public string? Gname { get; set; }

    public string? EmpProximityNo { get; set; }
}
