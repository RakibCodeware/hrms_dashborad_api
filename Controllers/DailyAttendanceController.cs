using Hrms_api.Data;
using Hrms_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Hrms_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DailyAttendanceController : ControllerBase
    {
        private readonly IMemoryCache _cache;

        private readonly IConfiguration _configuration;

        public DailyAttendanceController(IConfiguration configuration, IMemoryCache memoryCache)
        {
            _configuration = configuration;
            _cache = memoryCache;
        }

 
        [HttpGet]
        [Route("dailyAttendanceSummary")]

        public IActionResult getDailyAttendanceSummary(string companyId, string date)
        {
            if (!_cache.TryGetValue("DailyAttendanceSummary", out List<DailyAttendanceSummary> cachedResult))
            {
                // Data not found in cache, retrieve it from the database
                using (var _context = new ApplicationDbContext())
                {
                    var resultList = (from att in _context.TblAttendanceRecords
                                      join dpt in _context.HrdDepartments on att.DptId equals dpt.DptId
                                      join pep in _context.PersonnelEmpPersonnals on att.EmpId equals pep.EmpId
                                      where att.CompanyId == companyId && att.Attdate == DateTime.Parse(date)
                                      group new { att, pep } by new { att.DptId, dpt.DptName } into g
                                      orderby g.Key.DptName
                                      select new DailyAttendanceSummary
                                      {
                                          Department = g.Key.DptName,
                                          TotalEmployee = g.Count(),
                                          Male = g.Sum(x => x.pep.Sex == "Male" ? 1 : 0),
                                          Female = g.Sum(x => x.pep.Sex == "Female" ? 1 : 0),
                                          Leave = g.Sum(x => x.att.Attstatus == "lv" ? 1 : 0),
                                          Late = g.Sum(x => x.att.Attstatus == "l" ? 1 : 0),
                                          Present = g.Sum(x => x.att.Attstatus == "l" || x.att.Attstatus == "p" ? 1 : 0),
                                          Absent = g.Sum(x => x.att.Attstatus == "a" ? 1 : 0),
                                          OffDay = g.Sum(x => x.att.Attstatus == "w" || x.att.Attstatus == "h" ? 1 : 0)
                                      }).ToList();

                    foreach (var result in resultList)
                    {
                        decimal total = (decimal)result.TotalEmployee; // Total count
                        result.LeaveRatio = Math.Round(total == 0 ? 0 : (decimal)result.Leave / total * 100, 2);
                        result.AbsentRatio = Math.Round(total == 0 ? 0 : (decimal)result.Absent / total * 100, 2);
                        result.LateRatio = Math.Round(total == 0 ? 0 : (decimal)result.Late / total * 100, 2);
                        result.PresentRatio = Math.Round(total == 0 ? 0 : (decimal)result.Present / total * 100, 2);
                        result.OffdayRatio = Math.Round(total == 0 ? 0 : (decimal)result.OffDay / total * 100, 2);
                    }

                    // Cache the result for 1 minute
                    _cache.Set("DailyAttendanceSummary", resultList, TimeSpan.FromMinutes(1));

                    return Ok(resultList);
                }
            }
            else
            {
                // Data found in cache, return it
                return Ok(cachedResult);
            }


        }

         [HttpGet]
         [Route("dailyAttendanceStatus")]
        public IActionResult GetDailyAttendanceHistory(string companyId, string date)
  {
            if (!_cache.TryGetValue("AttendanceSummery", out AttendanceSummery cachedResult))
            {
                // Data not found in cache, retrieve it from the database
                using (var dbContext = new ApplicationDbContext())
                {
                    var result = dbContext.TblAttendanceRecords
                        .Where(record => record.CompanyId == companyId && record.Attdate == DateTime.Parse(date))
                        .GroupBy(record => 1)
                        .Select(g => new AttendanceSummery
                        {
                            Total = g.Count(),
                            Leave = g.Sum(x => x.Attstatus == "lv" ? 1 : 0),
                            Late = g.Sum(x => x.Attstatus == "l" ? 1 : 0),
                            Present = g.Sum(x => x.Attstatus == "l" || x.Attstatus == "p" ? 1 : 0),
                            Absent = g.Sum(x => x.Attstatus == "a" ? 1 : 0),
                            LeavePers = 0,
                            absentRatio = 0,
                            lateRatio = 0,
                            PressentRatio = 0
                        })
                        .FirstOrDefault();

                    if (result != null)
                    {
                        decimal total = (decimal)result.Total; // Total count
                        result.LeavePers = Math.Round(total == 0 ? 0 : (decimal)result.Leave / total * 100, 2); // Calculate leave percentage
                        result.absentRatio = Math.Round(total == 0 ? 0 : (decimal)result.Absent / total * 100, 2);
                        result.lateRatio = Math.Round(total == 0 ? 0 : (decimal)result.Late / total * 100, 2);
                        result.PressentRatio = Math.Round(total == 0 ? 0 : (decimal)result.Present / total * 100, 2);

                        _cache.Set("AttendanceSummery", result, TimeSpan.FromMinutes(1));
                    }
                    return Ok(result);
                }
            }
            else
            {
                return Ok(cachedResult);
            }

        }



        [HttpGet]
        [Route("currentEmployeeStaus")]
        public IActionResult GetCurrentEmployeesStatus(string companyId)
        {
            string cacheKey = $"CurrentEmployeesStatus_{companyId}";

            // Try to get the cached result
            if (!_cache.TryGetValue(cacheKey, out var cachedResult))
            {
                // Data not found in cache, retrieve it from the database
                using (var dbContext = new ApplicationDbContext())
                {
                    var result = (from cs in dbContext.PersonnelEmpCurrentStatuses
                                  join pep in dbContext.PersonnelEmpPersonnals on cs.EmpId equals pep.EmpId into joined
                                  from subpep in joined.DefaultIfEmpty()
                                  where cs.CompanyId == companyId && cs.IsActive == 1
                                  group new { cs, subpep } by 1 into grp
                                  select new
                                  {
                                      TotalEmployee = grp.Count(),
                                      Worker = grp.Sum(x => x.cs.EmpTypeId == 1 ? 1 : 0),
                                      Staff = grp.Sum(x => x.cs.EmpTypeId == 2 ? 1 : 0),
                                      Male = grp.Sum(x => x.subpep.Sex == "Male" ? 1 : 0),
                                      Female = grp.Sum(x => x.subpep.Sex == "Female" ? 1 : 0),
                                      OverTime = grp.Sum(x => x.cs.OverTime == true ? 1 : 0)
                                  }).FirstOrDefault();

                    // Cache the result for 1 minute
                    _cache.Set(cacheKey, result, TimeSpan.FromMinutes(1));

                    return Ok(result);
                }
            }
            else
            {
                // Data found in cache, return it
                return Ok(cachedResult);
            }
        }


        [HttpGet]
        [Route("newJoinReleaseHistory")]
        public IActionResult getNewJoinandRelease(string date)
        {
            if (!_cache.TryGetValue("JoinRelase", out List<JoinRelase> cachedResult))
            {
                // Data not found in cache, retrieve it from the database
                string endDateStr = date;
                DateTime enddate = DateTime.Parse(endDateStr);
                DateTime startDate = enddate.AddMonths(-6);
                startDate = new DateTime(startDate.Year, startDate.Month, 1);
                string startDateStr = startDate.ToString("yyyy-MM-dd");

                SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
                DataTable dt = new DataTable();
                string sSql = @"with nj as (
         select Format(EmpJoiningDate,'yyyy-MM')+'-01' as Month,count(EmpId) as NewJoin 
         from Personnel_EmployeeInfo  
         where EmpJoiningDate>=@StartDate and EmpJoiningDate<=@EndDate 
         group by Format(EmpJoiningDate,'yyyy-MM')+'-01')
     , sp as (
         select Format(EffectiveDate,'yyyy-MM')+'-01' as Month,count(e.EmpId) as Release 
         from Personnel_EmployeeInfo e 
         left join Personnel_EmpSeparation s on e.EmpId=s.EmpId 
         where EffectiveDate>=@StartDate and EffectiveDate<=@EndDate 
         group by Format(EffectiveDate,'yyyy-MM')+'-01')
     select format(convert(date, ISNULL(nj.Month,sp.Month)),'MMM-yy') as Month, NewJoin, Release 
     from nj  
     join sp on nj.Month=sp.Month 
     order by year(ISNULL(nj.Month,sp.Month)), month(ISNULL(nj.Month,sp.Month))";

                List<JoinRelase> joinReleaseInfo = new List<JoinRelase>();

                using (SqlCommand cmd = new SqlCommand(sSql, connection))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@StartDate", startDateStr);
                    cmd.Parameters.AddWithValue("@EndDate", endDateStr);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        joinReleaseInfo.Add(new JoinRelase
                        {
                            Month = reader.GetString(0),
                            NewJoin = reader.GetInt32(1),
                            Release = reader.GetInt32(2)
                        });
                    }

                    reader.Close();
                    connection.Close();
                }
                _cache.Set("JoinRelase", joinReleaseInfo, TimeSpan.FromMinutes(1));
                return Ok(joinReleaseInfo);
            }
            else
            {
                // Data found in cache, return it
                return Ok(cachedResult);
            }



        }

        [HttpGet]
        [Route("dailyAttendancehistory")]
        public IActionResult dailyAttendancehistory(string date, string companyId)
        {
            try
            {
                if (!_cache.TryGetValue("DailyAttendanceHistory", out List<DailyAttendanceHistory> cachedResult))
                {
                    string endDateStr = date;
                    DateTime enddate = DateTime.Parse(endDateStr);
                    DateTime startDate = enddate.AddDays(-6);
                    string startDateStr = startDate.ToString("yyyy-MM-dd");

                    SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
                    DataTable dt = new DataTable();

                    // Modified SQL query to use parameters
                    string sSql = "SELECT CAST(ATTDate AS DATE) AS Date, DATENAME(WEEKDAY, ATTDate) AS WEEKDAY, " +
                                  "SUM(CASE WHEN ATTStatus IN ('l','p') THEN 1 ELSE 0 END) AS Present, " +
                                  "SUM(CASE WHEN ATTStatus = 'a' THEN 1 ELSE 0 END) AS Absent " +
                                  "FROM tblAttendanceRecord " +
                                  "WHERE CompanyId = @CompanyId AND ATTDate >= @StartDate AND ATTDate <= @EndDate " +
                                  "GROUP BY ATTDate";

                    List<DailyAttendanceHistory> dailyAttendanceHistory = new List<DailyAttendanceHistory>();

                    using (SqlCommand cmd = new SqlCommand(sSql, connection))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@CompanyId", companyId);
                        cmd.Parameters.AddWithValue("@StartDate", startDateStr);
                        cmd.Parameters.AddWithValue("@EndDate", endDateStr);

                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dailyAttendanceHistory.Add(new DailyAttendanceHistory
                            {
                                Date = reader.GetDateTime(0).ToString("dd-MM-yy"),
                                WeekDay = reader.GetString(1),
                                Present = reader.GetInt32(2),
                                Absent = reader.GetInt32(3)
                            });
                        }

                        reader.Close();
                        connection.Close();
                    }
                    _cache.Set("DailyAttendanceHistory", dailyAttendanceHistory, TimeSpan.FromMinutes(1));
                    return Ok(dailyAttendanceHistory);
                }
                else
                {
                    return Ok(cachedResult);
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Error in Code");
            }


        }


        [HttpGet]
        [Route("getTodaysCosting")]
        public IActionResult getTodaysCosting(string date)
        {
            try
            {
                if (!_cache.TryGetValue("Daily_and_MonthlyCostingCount", out List<Daily_and_MonthlyCostingCount> cachedResult))
                {
                    SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
                    DataTable dt = new DataTable();


                    string query = "select Round(Sum(EmpPresentSalary)/30,0) as TodaysSalary from  Personnel_EmpCurrentStatus where IsActive=1 and EmpId in(select EmpId From tblAttendanceRecord Where ATTDate='" + date + "' and PaybleDays=1)";
                    List<Daily_and_MonthlyCostingCount> dailyCostingCount = new List<Daily_and_MonthlyCostingCount>();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Date", date);

                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dailyCostingCount.Add(new Daily_and_MonthlyCostingCount
                            {
                                DailySalaryAmnt = reader.GetDouble(0),
                                DailyOTPay = "0"
                            });
                        }

                        reader.Close();
                        connection.Close();
                    }
                    _cache.Set("Daily_and_MonthlyCostingCount", dailyCostingCount, TimeSpan.FromMinutes(1));
                    return Ok(dailyCostingCount);
                }
                else
                {
                    return Ok(cachedResult);
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Error my code");
            }

        }

        [HttpGet]
        [Route("getlastMonthCosting")]
        public async Task<IActionResult> GetMonthlyCostingAmnt(string date)
        {
            try
            {
                if (!_cache.TryGetValue("Daily_and_MonthlyCostingCount", out List<Daily_and_MonthlyCostingCount> cachedResult))
                {
                    using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString()))
                    {
                        DataTable dt = new DataTable();

                        string query = "SELECT   ISNULL(SUM(ROUND(NetPayable, 0)), 0) AS TotalSalary,ISNULL(SUM(ROUND(OverTimeAmount, 0)), 0) AS OverTimeAmount,ISNULL(SUM(ROUND(TotalOTAmount, 0) - ROUND(OverTimeAmount, 0)), 0) AS ExtraOTAmount FROM   Payroll_MonthlySalarySheet WHERE YearMonth =@Date";
                        List<MonthlyCosting> monthlyCostingAmnt = new List<MonthlyCosting>();

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            // Add parameters
                            cmd.Parameters.AddWithValue("@Date", date);

                            await connection.OpenAsync();
                            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                            {
                                while (await reader.ReadAsync())
                                {
                                    monthlyCostingAmnt.Add(new MonthlyCosting
                                    {
                                        MonthlyPaySalaryamnt = reader.GetDouble(0),
                                        ExtraOtAmnt = reader.GetDouble(1),
                                        MonthlyOTPay = reader.GetDouble(2)
                                    });
                                }
                            }
                        }

                        _cache.Set("MonthlyCosting", monthlyCostingAmnt, TimeSpan.FromMinutes(1));
                        return Ok(monthlyCostingAmnt);
                    }
                }
                else
                {
                    return Ok(cachedResult);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error in code");
            }
        }

    }
}
