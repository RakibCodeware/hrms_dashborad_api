using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VPersonnelEmpPunismentInfo
{
    public long EmpPunismentId { get; set; }

    public string EmpId { get; set; } = null!;

    public long? EmpCardNo { get; set; }

    public string? EmpPunismentOrderRef { get; set; }

    public DateOnly? EmpPunismentOrderRefDate { get; set; }

    public string? PtId { get; set; }

    public decimal? EmpPunismentAmount { get; set; }

    public string? EmpRemarks { get; set; }

    public bool? EmpPunismentStaus { get; set; }

    public string? PtName { get; set; }
}
