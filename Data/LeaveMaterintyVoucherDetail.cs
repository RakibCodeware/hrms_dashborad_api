using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class LeaveMaterintyVoucherDetail
{
    public string? MlvoucherNo { get; set; }

    public string? MonthId { get; set; }

    public int? PresentDays { get; set; }

    public double? TakenWages { get; set; }

    public double? TakenBonus { get; set; }

    public virtual LeaveMaterintyVoucher? MlvoucherNoNavigation { get; set; }
}
