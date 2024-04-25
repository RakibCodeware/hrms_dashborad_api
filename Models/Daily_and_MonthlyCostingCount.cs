namespace Hrms_api.Models
{
    public class Daily_and_MonthlyCostingCount
    {
        public double? DailySalaryAmnt {  get; set; }
        public string DailyOTPay { get; set; }
   
    }

    public class MonthlyCosting()
    {
        public double MonthlyPaySalaryamnt { get; set; }
        public double MonthlyOTPay { get; set; }
        public double ExtraOtAmnt { get; set; }
    }
}
