using System.ComponentModel.DataAnnotations;

namespace Hrms_api.Models
{
    public class CreateUser
    {
        [Required(ErrorMessage = "Please enter CompanyId")]
        public string? CompanyId {  get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        public string? UserName {  get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string? ConfirmePassword {  get; set; }

        [Required(ErrorMessage ="Please enter UserType")]
        public string? UserType {  get; set; }
        public string Email { get; set; }
        public bool isLvAuthority { get; set; }
        public short LvAuthorityOrder { get; set; }
        public short LvAuthorityAction { get; set; }
        public short LvEmpType { get; set; } 
        public bool LvOnlyDpt { get; set; }
        public string? EmpId { get; set; }
        public bool IsCompliance { get; set; }




    }
}
