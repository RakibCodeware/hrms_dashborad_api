using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class NumRunDeil
{
    public short NumRunid { get; set; }

    public DateTime Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public short Sdays { get; set; }

    public short? Edays { get; set; }

    public int? Schclassid { get; set; }

    public int? OverTime { get; set; }
}
