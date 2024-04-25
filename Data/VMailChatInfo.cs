using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VMailChatInfo
{
    public long Cid { get; set; }

    public long? TxUserId { get; set; }

    public string? Text { get; set; }

    public string FirstName { get; set; } = null!;

    public string? CdateTime { get; set; }

    public long? RxUserId { get; set; }

    public DateOnly? Cdate { get; set; }

    public TimeOnly? Ctime { get; set; }

    public bool? Status { get; set; }
}
