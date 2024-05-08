using Hrms_api.Data;
using Hrms_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hrms_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   



    public class DailyAttendanceController : ControllerBase
    {
        private readonly IMemoryCache _cache;

        private readonly IConfiguration _configuration;

        public DailyAttendanceController(IConfiguration configuration, IMemoryCache memoryCache)
        {
            _configuration = configuration;
            _cache = memoryCache;
        }
        public double basicSalary = 0.0;
        [HttpGet]
        [Route("dailyAttendanceSummary")]

        public IActionResult getDailyAttendanceSummary(string companyId, string date)
        {
            try
            {
                string cacheKey = $"DailyAttendanceSummary_{companyId}_{date}";

                // Try to get the cached result
                if (!_cache.TryGetValue(cacheKey, out List<DailyAttendanceSummary> cachedResult))
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
                        _cache.Set(cacheKey, resultList, TimeSpan.FromMinutes(1));

                        return Ok(resultList);
                    }
                }
                else
                {
                    // Data found in cache, return it
                    return Ok(cachedResult);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error in Code");
            }
        }


        [HttpGet]
        [Route("dailyAttendanceStatus")]
        public IActionResult GetDailyAttendanceHistory(string companyId, string date)
        {
            try
            {
                string cacheKey = $"AttendanceSummery_{companyId}_{date}";

                // Try to get the cached result
                if (!_cache.TryGetValue(cacheKey, out AttendanceSummery cachedResult))
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

                            _cache.Set(cacheKey, result, TimeSpan.FromMinutes(1));
                        }
                        if (result != null)
                        {
                            return Ok(result);
                        }
                        else
                        {
                            List<AttendanceSummery> resultList = dataNotFound();
                            return Ok(resultList);
                        }
                       
                    }
                }
                else
                {
                    // Data found in cache, return it
                    return Ok(cachedResult);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error in Code");
            }
        }




        [HttpGet]
        [Route("currentEmployeeStaus")]
        public IActionResult GetCurrentEmployeesStatus(string companyId)
        {
            try
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
                                      where cs.CompanyId == companyId && cs.IsActive == 1 && (cs.EmpStatus == "1" || cs.EmpStatus == "8")
                                      group new { cs, subpep } by 1 into grp
                                      select new CurrentEmployeeStatusDto
                                      {
                                          TotalEmployee = grp.Count(),
                                          Worker = grp.Sum(x => x.cs.EmpTypeId == 1 ? 1 : 0),
                                          Staff = grp.Sum(x => x.cs.EmpTypeId == 2 ? 1 : 0),
                                          Male = grp.Sum(x => x.subpep.Sex == "Male" ? 1 : 0),
                                          Female = grp.Sum(x => x.subpep.Sex == "Female" ? 1 : 0),
                                          OverTime = grp.Sum(x => x.cs.OverTime == true ? 1 : 0)
                                      }).FirstOrDefault();

                        if (result != null)
                        {
                            decimal total = (decimal)result.TotalEmployee; // Total count
                            result.StaffPers = Math.Round(total == 0 ? 0 : (decimal)result.Staff / total * 100, 2); // Calculate leave percentage
                            result.Workerpers = Math.Round(total == 0 ? 0 : (decimal)result.Worker / total * 100, 2);
                            result.MalePers = Math.Round(total == 0 ? 0 : (decimal)result.Male / total * 100, 2);
                            result.FemalePers = Math.Round(total == 0 ? 0 : (decimal)result.Female / total * 100, 2);

                            // Cache the result for 1 minute
                            _cache.Set(cacheKey, result, TimeSpan.FromMinutes(1));

                            return Ok(result);
                        }
                        else
                        {
                            return Ok(new { Status = "404", Message = "Data Not Found" });
                        }

                    }
                }
                else
                {
                    // Data found in cache, return it
                    return Ok(cachedResult);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error in Code");
            }
        }




        [HttpGet]
        [Route("newJoinReleaseHistory")]
        public IActionResult getNewJoinandRelease(string date, string companyId)
        {
            try
            {
                // Generate a unique cache key based on parameters
                string cacheKey = $"JoinRelase_{date}_{companyId}";

                if (!_cache.TryGetValue(cacheKey, out List<JoinRelase> cachedResult))
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
                where CompanyId=@companyId and EmpJoiningDate>=@StartDate and EmpJoiningDate<=@EndDate 
                group by Format(EmpJoiningDate,'yyyy-MM')+'-01')
            , sp as (
                select Format(EffectiveDate,'yyyy-MM')+'-01' as Month,count(e.EmpId) as Release 
                from Personnel_EmployeeInfo e 
                left join Personnel_EmpSeparation s on e.EmpId=s.EmpId 
                where CompanyId=@companyId and EffectiveDate>=@StartDate and EffectiveDate<=@EndDate 
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
                        cmd.Parameters.AddWithValue("@companyId", companyId);

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
                    if (joinReleaseInfo != null)
                    {
                        _cache.Set(cacheKey, joinReleaseInfo, TimeSpan.FromMinutes(1));
                        return Ok(joinReleaseInfo);
                    }
                    else
                    {
                        return Ok(new { Status = "404", Message = "Data Not Found" });
                    }


                }
                else
                {
                    // Data found in cache, return it
                    return Ok(cachedResult);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error in Code");
            }
        }


        [HttpGet]
        [Route("dailyAttendancehistory")]
        public IActionResult dailyAttendancehistory(string date, string companyId)
        {
            try
            {
                // Generate a unique cache key based on parameters
                string cacheKey = $"DailyAttendanceHistory_{date}_{companyId}";

                if (!_cache.TryGetValue(cacheKey, out List<DailyAttendanceHistory> cachedResult))
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
                    if (dailyAttendanceHistory != null)
                    {
                        _cache.Set(cacheKey, dailyAttendanceHistory, TimeSpan.FromMinutes(1));
                        return Ok(dailyAttendanceHistory);

                    }
                
                     else
                    {
                        return Ok(new { Status = "404", Message = "Data Not Found" });
                    }

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
        public IActionResult getTodaysCosting(string date, string companyId)
        {
            try
            {
                // Generate a unique cache key based on parameters
                string cacheKey = $"Daily_and_MonthlyCostingCount_{date}_{companyId}";

                if (!_cache.TryGetValue(cacheKey, out List<Daily_and_MonthlyCostingCount> cachedResult))
                {
                    SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
                    DataTable dt = new DataTable();

                    string query = "select Round(Sum(EmpPresentSalary)/30,0) as TodaysSalary from  Personnel_EmpCurrentStatus where IsActive=1 and EmpId in(select EmpId From tblAttendanceRecord Where ATTDate=@Date and PaybleDays=1 and  CompanyId=@companyId)";
                    List<Daily_and_MonthlyCostingCount> dailyCostingCount = new List<Daily_and_MonthlyCostingCount>();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@companyId", companyId);

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
                    if (dailyCostingCount != null)
                    {
                        _cache.Set(cacheKey, dailyCostingCount, TimeSpan.FromMinutes(1));
                        return Ok(dailyCostingCount);
                    }

                    else
                    {
                        return Ok(new { Status = "404", Message = "Data Not Found" });
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


        [HttpGet]
        [Route("getlastMonthCosting")]
        public async Task<IActionResult> GetMonthlyCostingAmnt(string date, string companyId)
        {
            try
            {
                DateTime datetime = DateTime.Parse(date);
                //convert the date first day off previous month
                DateTime firstDayOfPreviousMonth = new DateTime(datetime.Year, datetime.Month, 1).AddMonths(-1);
                string Pdate = firstDayOfPreviousMonth.ToString("yyyy-MM-dd");

                // Generate a unique cache key based on parameters
                string cacheKey = $"MonthlyCosting_{date}_{companyId}";

                if (!_cache.TryGetValue(cacheKey, out List<MonthlyCosting> cachedResult))
                {
                    using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString()))
                    {
                        DataTable dt = new DataTable();

                        string query = "SELECT ISNULL(SUM(ROUND(NetPayable, 0)), 0) AS TotalSalary, ISNULL(SUM(ROUND(OverTimeAmount, 0)), 0) AS OverTimeAmount, ISNULL(SUM(ROUND(TotalOTAmount, 0) - ROUND(OverTimeAmount, 0)), 0) AS ExtraOTAmount FROM Payroll_MonthlySalarySheet WHERE YearMonth = @Date AND CompanyId = @companyId";
                        List<MonthlyCosting> monthlyCostingAmnt = new List<MonthlyCosting>();

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            // Add parameters
                            cmd.Parameters.AddWithValue("@Date", Pdate);
                            cmd.Parameters.AddWithValue("@companyId", companyId);

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
                        if (monthlyCostingAmnt != null)
                        {
                            _cache.Set(cacheKey, monthlyCostingAmnt, TimeSpan.FromMinutes(1));
                            return Ok(monthlyCostingAmnt);
                        }
                        else
                        {
                            return Ok(new { Status = "404", Message = "Data Not Found" });
                        }

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



        [HttpGet]
        [Route("salaryComparison")]
        public async Task<IActionResult> salaryComparison(string companyId, string date)
        {
            try
            {
                // Generate cache key based on parameters
                string cacheKey = $"MonthlySalaryComparison_{companyId}_{date}";

                if (!_cache.TryGetValue(cacheKey, out List<MonthlySalaryComparison> cachedResult))
                {
                    DateTime endDate = Convert.ToDateTime(date);
                    endDate = new DateTime(endDate.Year, endDate.Month, 1);
                    DateTime startDate = endDate.AddMonths(-12);
                    startDate = new DateTime(startDate.Year, startDate.Month, 1);
                    string startDateStr = startDate.ToString("yyyy-MM-dd");
                    string endDateStr = endDate.ToString("yyyy-MM-dd");

                    using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString()))
                    {
                        DataTable dt = new DataTable();
                        string query = "select  CONCAT(FORMAT(YearMonth, 'MMM'), '-', RIGHT(FORMAT(YearMonth, 'yy'), 2)) AS MonthName, YearMonth, sum(TotalSalary) as Salary from Payroll_MonthlySalarySheet where CompanyId=@companyId and YearMonth>=@startDate and YearMonth<=@endDate group by YearMonth";
                        List<MonthlySalaryComparison> salaryComparison = new List<MonthlySalaryComparison>();

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            // Add parameters
                            cmd.Parameters.AddWithValue("@companyId", companyId);
                            cmd.Parameters.AddWithValue("@startDate", startDateStr);
                            cmd.Parameters.AddWithValue("@endDate", endDateStr);

                            await connection.OpenAsync();

                            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                            {
                                while (await reader.ReadAsync())
                                {
                                    salaryComparison.Add(new MonthlySalaryComparison
                                    {
                                        Monthname = reader.GetString(0),
                                        Date = reader.GetDateTime(1).ToString("yyyy-MM-dd"),
                                        Salary = reader.GetDouble(2)
                                    });
                                }
                            }
                        }
                        if (salaryComparison != null)
                        {
                        // Set cache with dynamic cache key
                            _cache.Set(cacheKey, salaryComparison, TimeSpan.FromMinutes(1));
                            return Ok(salaryComparison);
                        }
                        else
                        {
                            return Ok(new { Status = "404", Message = "Data Not Found" });
                        }

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

        [HttpGet]
        [Route("monthlyNewjoinAndRelease")]
        public IActionResult monthlyNewjoinAndRelease(string date, string companyId)
        {
            
         try
            {
                 // Generate a unique cache key based on parameters
                string cacheKey = $"MonthlyNewJoinAndRelease{date}_{companyId}";

                if (!_cache.TryGetValue(cacheKey, out List<MonthlyNewJoinAndRelease> cachedResult))
                {
                    string orginalDate = date;
                    DateTime endDate = DateTime.Parse(orginalDate);


                    DateTime firstDayOfMonth = new DateTime(endDate.Year, endDate.Month, 1);


                    DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                    string startDate = firstDayOfMonth.ToString("yyyy-MM-dd");
                    string endDateStr = lastDayOfMonth.ToString("yyyy-MM-dd");


                    SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
                    DataTable dt = new DataTable();
                    string sSql = @"with nj as (
                select Format(EmpJoiningDate,'yyyy-MM')+'-01' as Month,count(EmpId) as NewJoin 
                from Personnel_EmployeeInfo  
                where CompanyId=@companyId and EmpJoiningDate>=@StartDate and EmpJoiningDate<=@EndDate 
                group by Format(EmpJoiningDate,'yyyy-MM')+'-01')
            , sp as (
                select Format(EffectiveDate,'yyyy-MM')+'-01' as Month,count(e.EmpId) as Release 
                from Personnel_EmployeeInfo e 
                left join Personnel_EmpSeparation s on e.EmpId=s.EmpId 
                where CompanyId=@companyId and EffectiveDate>=@StartDate and EffectiveDate<=@EndDate 
                group by Format(EffectiveDate,'yyyy-MM')+'-01')
            select format(convert(date, ISNULL(nj.Month,sp.Month)),'MMM-yy') as Month, NewJoin, Release 
            from nj  
            join sp on nj.Month=sp.Month 
            order by year(ISNULL(nj.Month,sp.Month)), month(ISNULL(nj.Month,sp.Month))";

                    List<MonthlyNewJoinAndRelease> monthly_joinReleaseInfo = new List<MonthlyNewJoinAndRelease>();

                    using (SqlCommand cmd = new SqlCommand(sSql, connection))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDateStr);
                        cmd.Parameters.AddWithValue("@companyId", companyId);

                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            monthly_joinReleaseInfo.Add(new MonthlyNewJoinAndRelease
                            {
                                Month = reader.GetString(0),
                                NewJoin = reader.GetInt32(1),
                                Release = reader.GetInt32(2)
                            });
                        }

                        reader.Close();
                        connection.Close();
                    }
                    if (monthly_joinReleaseInfo != null && monthly_joinReleaseInfo.Count>0)
                    {
                        _cache.Set(cacheKey, monthly_joinReleaseInfo, TimeSpan.FromMinutes(1));
                        return Ok(monthly_joinReleaseInfo);
                    }


                     else
                    {
                        return Ok(new { Status = "404", Message = "Data Not Found" });
                    }

                }
                else
                {
                    // Data found in cache, return it
                    return Ok(cachedResult);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error in Code");
            }
        }

        [HttpGet]
        [Route("dailyOtCalculation")]

        public IActionResult dailyOtCalculation(string date)
        {
            string todate = date;
            DateTime datetime = DateTime.Parse(date);
            //convert the date first day off previous month
            DateTime firstDayOfPreviousMonth = new DateTime(datetime.Year, datetime.Month, 1).AddMonths(-1);
            string Formadate = firstDayOfPreviousMonth.ToString("yyyy-MM-dd");
           

            var results = overTimeCalculation(todate, todate);
  
            return Ok(results);
        }


        [HttpGet]
        [Route("monthlyOtCalculation")]

        public IActionResult monthlyOtCalculation(string date)
        {
            string todate = date;
            DateTime datetime = DateTime.Parse(date);
            //convert the date first day off previous month
            DateTime firstDayOfPreviousMonth = new DateTime(datetime.Year, datetime.Month, 1).AddMonths(-1);
            string Formadate = firstDayOfPreviousMonth.ToString("yyyy-MM-dd");


            var results = overTimeCalculation(Formadate, todate);
           return Ok(results);
        }





        private object overTimeCalculation(string formdate, string todate)
        {

            try
            {
                SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
                DataTable dt = new DataTable();
                string sSql = @"DECLARE @maxOT VARCHAR(8) = '02:00:00' 
                                           Select att.Empid,cs.BasicSalary,  isnull(CAST(SUM(DATEDIFF(second, 0, case when ATTStatus='W' or ATTStatus='H' then '00:00:00' else case when TotalOverTime>@maxOT then  '02:0'+SUBSTRING(OutMin,2,1)+':'+OutSec else TotalOverTime end end)) / 3600 AS varchar(12)) + ':' + RIGHT('0' + CAST(SUM(DATEDIFF(second, 0, case when ATTStatus='W' or ATTStatus='H' then '00:00:00' else case when TotalOverTime>@maxOT then  '02:0'+SUBSTRING(OutMin,2,1)+':'+OutSec else TotalOverTime end end)) / 60 % 60 AS varchar(2)), 2) + ':' +RIGHT('0' + CAST(SUM(DATEDIFF(second, 0, case when ATTStatus='W' or ATTStatus='H' then '00:00:00' else case when TotalOverTime>@maxOT then  '02:0'+SUBSTRING(OutMin,2,1)+':'+OutSec else TotalOverTime end end)) % 60 AS varchar(2)), 2),'00:00:00') AS OverTime,isnull(CAST(SUM(DATEDIFF(second, 0, TotalOverTime)) / 3600 AS varchar(12)) + ':' + RIGHT('0' + CAST(SUM(DATEDIFF(second, 0, TotalOverTime)) / 60 % 60 AS varchar(2)), 2) + ':' +RIGHT('0' + CAST(SUM(DATEDIFF(second, 0, TotalOverTime)) % 60 AS varchar(2)), 2),'00:00:00') AS TotalOverTime from v_tblAttendanceRecord att left join Personnel_EmpCurrentStatus cs on att.EmpId=cs.EmpId and cs.IsActive=1 where  AttDate >='"+ formdate + "' AND AttDate <= '"+ todate + "'  and IsOverTime='1' and att.IsActive='1' group by  att.Empid,cs.BasicSalary";

                List<DailyOverTimeCalculetion> dailyOvertimeCalculation = new List<DailyOverTimeCalculetion>();

                using (SqlCommand cmd = new SqlCommand(sSql, connection))
                {
                    connection.Open();
                    cmd.CommandTimeout = 500;
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dailyOvertimeCalculation.Add(new DailyOverTimeCalculetion
                        {
                            EmpID = reader.GetString(0),
                            BasicSalary = reader.GetDouble(1),
                            RegularOvertime = reader.GetString(2),
                            TotalOverTime = reader.GetString(3),
                           
                        });
                    }

                    reader.Close();
                }


                connection.Close();
                double regularOTAmount = 0;
                double totalOtAmount = 0;
                double totalOtAsSec = 0;
                double regularOTAsSec = 0;
                double avgOtHour = 0;
                double avgOtAmnt = 0;
                foreach (var data in dailyOvertimeCalculation)
                {
                    Console.WriteLine(data.EmpID);
                    double otRate = getOTRate(data.BasicSalary);
                    regularOTAmount += getOTAmout(data.RegularOvertime, otRate);
                    regularOTAsSec += convertTimeToSecond(data.RegularOvertime);
                    totalOtAmount += getOTAmout(data.TotalOverTime, otRate);
                    totalOtAsSec += convertTimeToSecond(data.TotalOverTime);
                }
                double extraOtSec = totalOtAsSec - regularOTAsSec;
                double extraOtAmnt = totalOtAmount - regularOTAmount;
                double totalOtHour = totalOtAsSec / 3600;
                double regularOtHour = regularOTAsSec / 3600;
                double extraOtHour = extraOtSec / 36000;

                if (formdate != todate)
                {
                   
                    DateTime fromDate = DateTime.Parse(formdate);
                    DateTime toDate = DateTime.Parse(todate);
                    TimeSpan duration = toDate - fromDate;
                    int daysDifference = (int)duration.TotalDays;
                    double avgOtSec = totalOtAsSec / daysDifference;
                     avgOtHour =Math.Round(avgOtSec / 3600);
                     avgOtAmnt = Math.Round(totalOtAmount / daysDifference);
                }

                var result = new { regularOtHour = Math.Round(regularOtHour,2), extraOtHour =Math.Round(extraOtHour,2), totalOtHour =Math.Round(                totalOtHour,2), regularOTAmount = regularOTAmount, totalOtAmount = totalOtAmount, extraOtAmnt = extraOtAmnt,avgOtHour= avgOtHour,avgOtAmnt=avgOtAmnt };

                return result;
            }
            catch (Exception)
            {
                var result = new { stausCode = "404", Message = "Data Not founds" };
                return result;
            }
               

        }


        private List<AttendanceSummery> dataNotFound()
        {
            AttendanceSummery attendanceSummery = new AttendanceSummery()
            {
                Total = 0,
                Present = 0,
                Absent = 0,
                Late = 0,
                Leave = 0,
                PressentRatio = 0,
                absentRatio = 0,
                LeavePers = 0,
                lateRatio = 0,
            };

            List<AttendanceSummery> list = new List<AttendanceSummery>();
            list.Add(attendanceSummery);

            return list;
        }


        private double getOTRate(double Salary)
        {
            return Math.Round((Salary / 208) * 2, 2); // here 208 is static.                
        }

        private void  getBasicSalary(string empId)
        {

            

            using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString()))
            {
                string sSql = @"SELECT BasicSalary FROM Personnel_EmpCurrentStatus WHERE EmpId = @EmpId";

                using (SqlCommand cmd = new SqlCommand(sSql, connection))
                {
                    cmd.Parameters.AddWithValue("@EmpId", empId);
                    connection.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        basicSalary+=getOTRate(Convert.ToDouble(result));
                    }
                }
            }

         
        }


        private double getOTAmout(string OverTime, double OTRate)
        {
            string[] spltTime = OverTime.Split(':');

            double hours = double.Parse(spltTime[0]);
            double min = double.Parse(spltTime[1]);
            double secods = double.Parse(spltTime[2]);



            double secOttk = (OTRate / 3600) * secods;
            double minOttk = (OTRate / 60) * min;
            double hourlyot = OTRate * hours;
            return Math.Round(secOttk + minOttk + hourlyot);
        }
        private double convertTimeToSecond(string regularOt)
        {
            string[] parts = regularOt.Split(':');
            if (parts.Length != 3)
            {
                throw new ArgumentException("Invalid time format");
            }

            int hours, minutes, seconds;
            if (!int.TryParse(parts[0], out hours) ||
                !int.TryParse(parts[1], out minutes) ||
                !int.TryParse(parts[2], out seconds))
            {
                throw new ArgumentException("Invalid time format");
            }

            return (hours * 3600) + (minutes * 60) + seconds;
        }

    }
}
