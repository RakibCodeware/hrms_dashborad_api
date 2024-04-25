using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdBankInfo
{
    public short BankId { get; set; }

    public string? BankName { get; set; }

    public bool? IsActive { get; set; }
}
