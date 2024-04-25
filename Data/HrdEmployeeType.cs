using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdEmployeeType
{
    public int EmpTypeId { get; set; }

    public string? EmpType { get; set; }

    public string? EmpTypeBn { get; set; }

    public virtual ICollection<LeaveLeaveApplication> LeaveLeaveApplications { get; set; } = new List<LeaveLeaveApplication>();

    public virtual ICollection<TblAttendanceRecord> TblAttendanceRecords { get; set; } = new List<TblAttendanceRecord>();
}
