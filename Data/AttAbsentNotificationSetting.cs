using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class AttAbsentNotificationSetting
{
    public int? Days { get; set; }

    public string? StatusCount { get; set; }

    public bool? NotificationStatus { get; set; }
}
