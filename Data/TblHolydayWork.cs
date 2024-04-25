using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblHolydayWork
{
    public int Hcode { get; set; }

    public DateOnly Hdate { get; set; }

    public string? Description { get; set; }

    public string CompanyId { get; set; } = null!;

    public virtual HrdCompanyInfo Company { get; set; } = null!;
}
