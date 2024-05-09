namespace Hrms_api.Models
{
    public class AttendanceSummery
    {
        public long ?Present { get; set; }
        public long? Absent { get; set; }
        public long? Late { get; set; }
        public long? Leave { get; set; }
        public decimal ? PressentRatio { get; set; }
        public decimal? absentRatio { get; set; }
        public decimal? lateRatio { get; set; }
        public decimal? LeavePers { get; set; }
        public decimal? Total { get; set;}
        public decimal? TotalPerc { get; set; }

        public string OffDayDuty {  get; set; }
        public string OffDayDutyPerc { get; set; }



    }
}
