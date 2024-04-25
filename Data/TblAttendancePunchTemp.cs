using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblAttendancePunchTemp
{
    public int Sl { get; set; }

    public string CompanyId { get; set; } = null!;

    public string CardNo { get; set; } = null!;

    public DateTime PunchTime { get; set; }

    public string ProcessingId { get; set; } = null!;
}
