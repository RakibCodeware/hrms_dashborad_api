using ComplexScriptingSystem;
using Hrms_api.Data;
using Hrms_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Hrms_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateUserController : ControllerBase
    {
      
        private readonly IConfiguration configuration;

        public CreateUserController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        [HttpGet("getCompanyList")]
        public IActionResult Get()
        {
            using (var context = new ApplicationDbContext())
            {
                var ComapnayList= context.HrdCompanyInfos.Select(c => new {c.CompanyId,c.CompanyName}).FirstOrDefault();
                return Ok(ComapnayList);
            }
        }

        [HttpGet("employeList")]
        public IActionResult Get(int companyId)
        {
           using (var context = new ApplicationDbContext())
            {
                var empList = (from emp in context.VPersonnelEmpCurrentStatuses
                            where emp.EmpStatus == "1" || emp.EmpStatus == "8"
                                  && emp.IsActive == 1
                                  && emp.CompanyId == "0001"
                                  && (emp.EmpTypeId == 1 || emp.EmpTypeId == 2)
                            group emp by new { emp.EmpId, emp.EmpCardNo, emp.EmpName, emp.DptCode, emp.CustomOrdering } into g
                            orderby g.Key.DptCode, g.Key.CustomOrdering
                            select new
                            {
                                EmpCardNo = g.Key.EmpCardNo,
                                EmpId = g.Key.EmpId,
                                EmpCardNoAndName = g.Key.EmpCardNo + " [ " + g.Key.EmpName + " ]"
                            }).ToList();
                return Ok(empList);
            }
        }



        [HttpPost("createUser")]
        public IActionResult createUser([FromBody] CreateUser createUser)
        {
            if(createUser == null)
            {
                return BadRequest("Pleease select the information");
            }
            else
            {
                if (createUser.Password != createUser.ConfirmePassword)
                {
                    return BadRequest("Password does not match");
                }
                var userInfos = new UserAccount()
                {
                    UserName = ComplexLetters.getTangledLetters(createUser.UserName),
                    UserPassword = ComplexLetters.getTangledLetters(createUser.Password), 
                    Email = createUser.Email,
                    UserType = ComplexLetters.getTangledLetters(createUser.UserType),
                    CreatedOn = DateOnly.ParseExact(DateTime.UtcNow.Date.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    CreatedBy =1,
                    Status = true,
                    CoockieInfo = "", 
                    CompanyId = createUser.CompanyId,
                    IsLvAuthority = createUser.isLvAuthority,
                    LvAuthorityOrder = createUser.LvAuthorityOrder,
                    LvAuthorityAction = createUser.LvAuthorityAction,
                    LvEmpType = createUser.LvEmpType,
                    LvOnlyDpt = createUser.LvOnlyDpt,
                    EmpId = createUser.EmpId,
                    IsCompliance = createUser.IsCompliance
                };
                using (var dbcontext=new ApplicationDbContext())
                {
                    dbcontext.UserAccounts.Add(userInfos);
                    dbcontext.SaveChanges();
                    return Ok(new {StatusCode="200",Message="Data Saved Succesfully"});
                }
            }
        }


        [HttpGet("getUserInfos")]
        public IActionResult getEmpInfos(string empId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var userInfos = (from user in context.VUserAccounts
                                     where user.EmpId == empId && user.CompanyId == "0001"
                                     select new
                                     {
                                         UserId = user.UserId,
                                         FullName = user.EmpName,
                                         UserName = ComplexLetters.getEntangledLetters(user.UserName),
                                         OldPassword =ComplexLetters.getEntangledLetters(user.UserPassword),
                                         Email = user.Email,
                                         UserSType = ComplexLetters.getEntangledLetters(user.UserType),
                                         IsLeavAuthority = user.IsLvAuthority,
                                         IsActive = user.Status

                                     }).ToList();
                    if (userInfos.Count <= 0 || userInfos == null)
                    {
                        return NotFound(new { StatusCode = "404", Message = "Data not found" });
                    }
                    return Ok(userInfos);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
            }


        [HttpPut("changePassword")]
        public IActionResult changePassword([FromBody] CreateUser createPass, int userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return BadRequest("User ID is null or empty");
            }

            if (createPass == null)
            {
                return BadRequest("Information is null");
            }

            if (createPass.Password != createPass.ConfirmePassword)
            {
                return BadRequest(new { Message = "Passwords do not match" });
            }

            using (var context = new ApplicationDbContext())
            {
                var user = context.UserAccounts.FirstOrDefault(u => u.UserId == userId);

                if (user != null)
                {
                    user.UserPassword = createPass.Password;
                    context.SaveChanges();
                    return Ok("Password updated successfully");
                }
                else
                {
                    return BadRequest("User not found");
                }
            }
        }


    }


}
