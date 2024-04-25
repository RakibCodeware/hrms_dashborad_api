using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VatTaxIncomeTax
{
    public int TaxId { get; set; }

    public string EmpId { get; set; } = null!;

    public string? CompanyId { get; set; }

    public double? PresentSalary { get; set; }

    public double? BasicSalary { get; set; }

    public double? Bonus { get; set; }

    public double? PfAmount { get; set; }

    public double? ElAmount { get; set; }

    public double? OthersIncome { get; set; }

    public double? TotalTaxableIncome { get; set; }

    public double? OthersAllowance { get; set; }

    public double? Conveyance { get; set; }

    public double? ConveyanceTaxFree { get; set; }

    public double? HouseRent { get; set; }

    public double? HouseRentTaxFree { get; set; }

    public double? Madical { get; set; }

    public double? MadicalTaxFree { get; set; }

    public double? TotalTax { get; set; }

    public double? Rebatable { get; set; }

    public double? NetPayableTax { get; set; }

    public double? PerMonthTax { get; set; }

    public double? EmpEmprContribution { get; set; }

    public DateTime? GenerateDate { get; set; }

    public int? UserId { get; set; }

    public double? MaxInvestmentAmount { get; set; }

    public double? TotalInvestmentAmount { get; set; }

    public double? RebatableInvestment { get; set; }

    public virtual VatTaxYear Tax { get; set; } = null!;
}
