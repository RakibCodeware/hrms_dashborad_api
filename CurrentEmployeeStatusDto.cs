namespace Hrms_api
{
    public class CurrentEmployeeStatusDto
    {
        public int TotalEmployee { get; set; }
        public int Worker { get; set; }
        public int Staff { get; set; }
        public int Male { get; set; }
        public int Female { get; set; }
        public int OverTime { get; set; }
        public decimal Workerpers { get; set; }
        public decimal StaffPers { get; set; }
        public decimal MalePers { get; set; }
        public decimal FemalePers { get; set; }

        public string Month { get; set; }
        public int NewJoin { get; set; }
        public int Release { get; set; }
    }
}
