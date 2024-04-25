using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblAttendance
{
    public string? ProximityNo { get; set; }

    public int? Hour { get; set; }

    public int? Minute { get; set; }

    public int? Second { get; set; }

    public string? PunchDate { get; set; }
}
