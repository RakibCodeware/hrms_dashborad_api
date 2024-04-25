using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class MailComplainInfo
{
    public long ComId { get; set; }

    public string? EmpId { get; set; }

    public string? ModuleType { get; set; }

    public string? Subject { get; set; }

    public string? Details { get; set; }

    public DateOnly? Cdate { get; set; }

    public TimeOnly? Ctime { get; set; }

    public string? CompanyId { get; set; }

    public bool? IsRead { get; set; }

    public int? RxUserId { get; set; }
}
