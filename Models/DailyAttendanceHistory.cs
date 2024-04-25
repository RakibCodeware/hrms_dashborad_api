namespace Hrms_api.Models
{
    public class DailyAttendanceHistory
    {
        public string Date {  get; set; }
        public string WeekDay { get; set; }
        public int Present { get; set; }
        public int Absent { get; set; }
    }
}
