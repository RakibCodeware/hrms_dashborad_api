using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class MailComposeMailInfo
{
    public long ComposeMailId { get; set; }

    public string? EmpId { get; set; }

    public string? Subject { get; set; }

    public string? Details { get; set; }

    public DateOnly? Cdate { get; set; }

    public TimeOnly? Ctime { get; set; }

    public string? TxCompanyId { get; set; }

    public bool? IsRead { get; set; }

    public string? RxCompanyId { get; set; }

    public int? RxUserId { get; set; }
}
