using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdAllownceSetting
{
    public short AllownceId { get; set; }

    public int? AlCalId { get; set; }

    public double? BasicAllowance { get; set; }

    public double? MedicalAllownce { get; set; }

    public double? FoodAllownce { get; set; }

    public double? ConvenceAllownce { get; set; }

    public double? HouseRent { get; set; }

    public double? TechnicalAllowance { get; set; }

    public double? Pfallowance { get; set; }

    public double? OthersAllowance { get; set; }

    public double? StampDeduct { get; set; }

    public string? Year { get; set; }

    public DateTime? EntryDate { get; set; }

    public int? UserId { get; set; }
}
