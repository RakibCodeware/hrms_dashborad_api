﻿using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdWeekendSetting
{
    public string CompanyId { get; set; } = null!;

    public string? EmpId { get; set; }

    public bool? Friday { get; set; }

    public bool? Saturday { get; set; }

    public bool? Sunday { get; set; }

    public bool? Monday { get; set; }

    public bool? Tuesday { get; set; }

    public bool? Wednesday { get; set; }

    public bool? Thursday { get; set; }
}