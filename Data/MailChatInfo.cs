using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class MailChatInfo
{
    public long Cid { get; set; }

    public string? Text { get; set; }

    public long? TxUserId { get; set; }

    public long? RxUserId { get; set; }

    public DateOnly? Cdate { get; set; }

    public TimeOnly? Ctime { get; set; }

    public bool? Status { get; set; }
}
