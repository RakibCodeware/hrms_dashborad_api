using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class TblReportHeading
{
    public string RptCode { get; set; } = null!;

    public string? RptHeader { get; set; }

    public string? RptAddress { get; set; }

    public string? RptTel { get; set; }

    public string? RptFax { get; set; }

    public string? RptEmail { get; set; }

    public string? RptMessage { get; set; }
}
