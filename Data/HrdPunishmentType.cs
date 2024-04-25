using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdPunishmentType
{
    public string PtId { get; set; } = null!;

    public string? PtName { get; set; }

    public virtual ICollection<PersonnelEmpPunismentInfo> PersonnelEmpPunismentInfos { get; set; } = new List<PersonnelEmpPunismentInfo>();
}
