using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VatTaxTaxFreeAllowance
{
    public int Tfsn { get; set; }

    public double? ConvenceAllownce { get; set; }

    public double? HouseRent { get; set; }

    public double? MedicalAllownce { get; set; }
}
