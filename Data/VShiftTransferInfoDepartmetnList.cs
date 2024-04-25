using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VShiftTransferInfoDepartmetnList
{
    public DateOnly? TfromDate { get; set; }

    public bool? IsActive { get; set; }

    public long Stid { get; set; }

    public string SftName { get; set; } = null!;

    public string? DptName { get; set; }

    public string? CompanyId { get; set; }

    public string? DptId { get; set; }

    public DateOnly? TtoDate { get; set; }

    public short? SftId { get; set; }

    public string? Gname { get; set; }

    public int? Gid { get; set; }
}
