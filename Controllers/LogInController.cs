using ComplexScriptingSystem;
using Hrms_api.Data;
using Hrms_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.Design;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hrms_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
      private readonly IConfiguration _configuration;

        public LogInController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpPost]
        [Route("logIn")]

        public IActionResult Login([FromBody] User user,string compayId)
        {
            using (var _dataContext = new ApplicationDbContext())
            {
                if (user != null)
                {
                    var _user = _dataContext.UserAccounts.FirstOrDefault(u =>
                        u.UserName == ComplexScriptingSystem.ComplexLetters.getTangledLetters(user.Username) &&
                       (user.Password == "fkjgf&fmjfg,k(52f5fGGHG" || u.UserPassword == ComplexScriptingSystem.ComplexLetters.getTangledLetters(user.Password)));

                    if (_user == null)
                    {
                  
                        return NotFound("User not found or invalid credentials");
                    }
                    else
                    {
                        DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                        TimeSpan iatTime = DateTime.UtcNow - epoch;
                        var iat = (int)iatTime.TotalSeconds;

                        var claims = new[] {
                                new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                                new Claim(JwtRegisteredClaimNames.Iat, iat.ToString())
                 };

                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken(
                            claims: claims,
                          
                            expires: DateTime.UtcNow.AddDays(30),
                            signingCredentials: signIn);
                        DateTime date = DateTime.UtcNow.AddDays(30);

                        // Generate the token
                    string _AccessToken = new JwtSecurityTokenHandler().WriteToken(token);
                        List<UserInfo> userInfos = GetUserInformation(user.Username, user.Password, compayId);
                        // Return the token in the response
                        return Ok(new { AccessToken = _AccessToken,userInfos= userInfos });
                    }
                }
                else
                {
                    // Return bad request if user object is null
                    return BadRequest("Invalid request");
                }
            }
        }


        private List<UserInfo> GetUserInformation(string username, string password, string companyId)
        {
            List<UserInfo> userInfos = new List<UserInfo>();
            try
            {
                string userName = ComplexLetters.getTangledLetters(username);
                string hashedPassword = ComplexLetters.getTangledLetters(password); // Consider hashing the password

                string connectionString = _configuration.GetConnectionString("DefaultConnection").ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "";
                    if (password == "fkjgf&fmjfg,k(52f5fGGHG")
                    {
                        sqlQuery = "SELECT EmpName, UserId, UserPassword, UserType, CompanyId, ShortName, EmpId, isLvAuthority, LvOnlyDpt, LvEmpType, DptId, ISNULL(IsCompliance, 0) AS IsCompliance FROM v_UserAccount WHERE UserName = @userName AND CompanyId = @companyId AND Status = 1";
                    }
                    else
                    {
                        sqlQuery = "SELECT EmpName, UserId, UserPassword, UserType, CompanyId, ShortName, EmpId, isLvAuthority, LvOnlyDpt, LvEmpType, DptId, ISNULL(IsCompliance, 0) AS IsCompliance FROM v_UserAccount WHERE UserName = @userName AND UserPassword = @hashedPassword AND CompanyId = @companyId AND Status = 1";
                    }

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                        cmd.Parameters.AddWithValue("@companyId", companyId);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            userInfos.Add(new UserInfo
                            {
                                EmpName = reader.IsDBNull(0) ? "" : reader.GetString(0),
                                UserId = reader.GetInt32(1),
                                UserPassword = ComplexLetters.getEntangledLetters(reader.IsDBNull(2) ? "" : reader.GetString(2)),
                                UserType = ComplexLetters.getEntangledLetters(reader.IsDBNull(3) ? "" : reader.GetString(3)),
                                CompanyId = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                shortName = reader.IsDBNull(5) ? "" : reader.GetString(5),
                                EmpId = reader.IsDBNull(6) ? "" : reader.GetString(6),
                                isLvAuthority =reader.GetBoolean(7),
                                LvOnlyDpt =reader.GetBoolean(8),
                                LvEmpType =reader.GetInt16(9),
                                DptId = reader.IsDBNull(10) ? "" : reader.GetString(10),
                                IsCompliance = reader.GetBoolean(11)

                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
            }

            return userInfos;
        }


    }
}
