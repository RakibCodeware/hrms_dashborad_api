using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPersonnelEmpNewPosition
{
    public string? EmpId { get; set; }

    public string? EmpName { get; set; }

    public double? EmpPresentSalary { get; set; }

    public double? LastIncrement { get; set; }

    public string? EmpCardNo { get; set; }

    public string? DptName { get; set; }

    public string? LastIncrementDate { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public string? SalaryCount { get; set; }

    public double? Approved { get; set; }

    public string? PromotionEffectiveFrom { get; set; }

    public double? NempPresentSalary { get; set; }

    public int Sn { get; set; }

    public string? TypeOfChange { get; set; }

    public string? DptId { get; set; }

    public int? EmpTypeId { get; set; }

    public string? Remarks { get; set; }

    public string? PreGrdName { get; set; }

    public string PreDsgName { get; set; } = null!;

    public string? PreDptName { get; set; }

    public double? PreEmpSalary { get; set; }

    public double? PreIncrementAmount { get; set; }

    public double? TechnicalAllownce { get; set; }

    public double? PreTechnicalAllownce { get; set; }

    public string? CompanyName { get; set; }

    public string SftName { get; set; } = null!;

    public string? GrdName { get; set; }

    public string DsgName { get; set; } = null!;
}
