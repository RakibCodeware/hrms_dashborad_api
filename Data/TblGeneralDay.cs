using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblGeneralDay
{
    public int Sl { get; set; }

    public DateOnly GeneralDay { get; set; }

    public string? Description { get; set; }

    public string CompanyId { get; set; } = null!;

    public short EmpTypeId { get; set; }
}
