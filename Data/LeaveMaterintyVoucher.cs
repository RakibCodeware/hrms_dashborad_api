using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class LeaveMaterintyVoucher
{
    public long Sl { get; set; }

    public string MlvoucherNo { get; set; } = null!;

    public string? EmpId { get; set; }

    public short? EmpTypeId { get; set; }

    public short? DptId { get; set; }

    public short? DsgId { get; set; }

    public double? ThreeMonthsTotalPaymentWithBonus { get; set; }

    public double? AverageWages { get; set; }

    public double? InstallmentAmount { get; set; }

    public bool? FirstInstallmentSignature { get; set; }

    public DateOnly? FirstAcceptDate { get; set; }

    public bool? SecondInstallmentSignature { get; set; }

    public DateOnly? SecondAcceptDate { get; set; }

    public int? TotalPresentDays { get; set; }
}
