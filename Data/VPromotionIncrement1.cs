using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPromotionIncrement1
{
    public string EmpId { get; set; } = null!;

    public int Sn { get; set; }

    public string? PreCompanyId { get; set; }

    public string? CompanyId { get; set; }

    public string? EmpCardNo { get; set; }

    public int? PreEmpTypeId { get; set; }

    public int? EmpTypeId { get; set; }

    public string? PreSalaryType { get; set; }

    public string? SalaryType { get; set; }

    public double? PreEmpSalary { get; set; }

    public double? EmpPresentSalary { get; set; }

    public double? PreIncrementAmount { get; set; }

    public double? IncrementAmount { get; set; }

    public double? PreBasicSalary { get; set; }

    public double? BasicSalary { get; set; }

    public string? PreDptId { get; set; }

    public string? DptId { get; set; }

    public string? PreDsgId { get; set; }

    public string? DsgId { get; set; }

    public string? PreEmpStatus { get; set; }

    public string? EmpStatus { get; set; }

    public string? PreGrdName { get; set; }

    public string? GrdName { get; set; }

    public double? PreOthersAllownce { get; set; }

    public double? OthersAllownce { get; set; }

    public DateOnly? DateofUpdate { get; set; }

    public string? TypeOfChange { get; set; }

    public string? EffectiveMonth { get; set; }

    public string? OrderRefNo { get; set; }

    public DateOnly? OrderRefDate { get; set; }

    public string? Remarks { get; set; }

    public short? IsActive { get; set; }

    public string? PreCompanyName { get; set; }

    public string? CompanyName { get; set; }

    public string? PreEmpType { get; set; }

    public string? EmpType { get; set; }

    public string? PreDptName { get; set; }

    public string? DptName { get; set; }

    public string PreDsgName { get; set; } = null!;

    public string DsgName { get; set; } = null!;

    public string? EmpName { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public string? Address { get; set; }

    public double? PreTechnicalAllownce { get; set; }

    public double? TechnicalAllownce { get; set; }

    public double? PreConvenceAllownce { get; set; }

    public double? ConvenceAllownce { get; set; }

    public double? PreMedicalAllownce { get; set; }

    public double? MedicalAllownce { get; set; }

    public string SftName { get; set; } = null!;

    public double? PreFoodAllownce { get; set; }

    public double? FoodAllownce { get; set; }

    public double? PreHouseRent { get; set; }

    public double? HouseRent { get; set; }
}
