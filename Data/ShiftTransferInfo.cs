using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class ShiftTransferInfo
{
    public long Stid { get; set; }

    public short? SftId { get; set; }

    public DateOnly? TfromDate { get; set; }

    public DateOnly? TtoDate { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? DptId { get; set; }

    public string? CompanyId { get; set; }

    public int? Gid { get; set; }

    public virtual ICollection<ShiftTransferDetailsMissingLog> ShiftTransferDetailsMissingLogs { get; set; } = new List<ShiftTransferDetailsMissingLog>();
}
