using Hrms_api.Data;

namespace Hrms_api.Models
{
    public class DailyAttendanceSummary
    {
        public string? Department {  get; set; }
        public long TotalEmployee {  get; set; }
        public int Male { get; set; }
        public decimal MaleRatio { get; set; }
        public int Female {  get; set; }
        public decimal FemaleRatio { get; set; }
        public int Present { get; set; }
        public decimal PresentRatio { get; set; }
        public int Absent {  get; set; }
        public decimal AbsentRatio { get; set;}
        public int Leave { get; set; }  
        public decimal LeaveRatio { get; set;}
        public  int Late { get; set; }
        public decimal LateRatio { get; set;}
        public int OffDay { get; set; }
        public decimal OffdayRatio { get; set;}

    }
}
