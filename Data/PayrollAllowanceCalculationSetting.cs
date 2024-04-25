using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class PayrollAllowanceCalculationSetting
{
    public int AlCalId { get; set; }

    public byte? BasicAllowance { get; set; }

    public byte? MedicalAllownce { get; set; }

    public byte? FoodAllownce { get; set; }

    public byte? ConvenceAllownce { get; set; }

    public byte? HouseRent { get; set; }

    public byte? TechnicalAllowance { get; set; }

    public byte? OthersAllowance { get; set; }

    public byte? ProvidentFund { get; set; }

    public DateTime? EntryDate { get; set; }

    public int? EmpTypeId { get; set; }

    public string? SalaryType { get; set; }

    public string? CompanyId { get; set; }

    public string? CalculationType { get; set; }
}
