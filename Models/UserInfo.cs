namespace Hrms_api.Models
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public string EmpName { get; set; }
        public string UserPassword { get; set; }
        public string UserType { get; set; }
        public string CompanyId { get; set; }
        public string shortName { get; set;}
        public bool isLvAuthority { get; set; }
        public bool LvOnlyDpt { get;set; }
        public int LvEmpType { get; set;}
        public string DptId { get; set; }
        public bool IsCompliance { get; set;}
        public string EmpId { get;set; }
    }
}
