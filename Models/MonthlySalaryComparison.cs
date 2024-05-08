using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hrms_api.Models
{
    public class MonthlySalaryComparison
    {
        public string   Monthname {  get; set; }
        public string Date { get; set; }
        public double Salary {  get; set; }

    }
}
