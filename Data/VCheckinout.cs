using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VCheckinout
{
    public int Userid { get; set; }

    public DateTime Checktime { get; set; }

    public string? Checktype { get; set; }

    public int? Verifycode { get; set; }

    public string? Sensorid { get; set; }

    public string? Memoinfo { get; set; }

    public string? WorkCode { get; set; }

    public string? Sn { get; set; }

    public short? UserExtFmt { get; set; }

    public string Badgenumber { get; set; } = null!;
}
