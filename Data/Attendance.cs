using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class Attendance
{
    public DateOnly? Date { get; set; }

    public int? PresentCount { get; set; }

    public int? AbsentCount { get; set; }
    public int? AbsentHisb {  get; set; }   
}
