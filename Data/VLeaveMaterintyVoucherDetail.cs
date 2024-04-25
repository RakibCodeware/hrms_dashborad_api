using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VLeaveMaterintyVoucherDetail
{
    public string? MlvoucherNo { get; set; }

    public string? MonthId { get; set; }

    public int? PresentDays { get; set; }

    public double? TakenWages { get; set; }

    public double? TakenBonus { get; set; }

    public double? ThreeMonthsTotalPaymentWithBonus { get; set; }

    public double? AverageWages { get; set; }

    public double? InstallmentAmount { get; set; }

    public string? EmpId { get; set; }

    public string? CompanyNameBangla { get; set; }

    public string? AddressBangla { get; set; }

    public string? EmpNameBn { get; set; }

    public string? DsgNameBn { get; set; }

    public string? DptNameBn { get; set; }

    public string? EmpCardNo { get; set; }

    public int? EmpTypeId { get; set; }
}
