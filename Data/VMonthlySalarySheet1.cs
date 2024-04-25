using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VMonthlySalarySheet1
{
    public short? DaysInMonth { get; set; }

    public short? WeekendHoliday { get; set; }

    public short? CasualLeave { get; set; }

    public short? SickLeave { get; set; }

    public short? AnnualLeave { get; set; }

    public short? FestivalHoliday { get; set; }

    public short? AbsentDay { get; set; }

    public short? PresentDay { get; set; }

    public short? PayableDays { get; set; }

    public double? BasicSalary { get; set; }

    public double? HouseRent { get; set; }

    public double? MedicalAllownce { get; set; }

    public double? ConvenceAllownce { get; set; }

    public double? FoodAllownce { get; set; }

    public double? EmpPresentSalary { get; set; }

    public double? AbsentDeduction { get; set; }

    public double? Payable { get; set; }

    public string? TotalOthour { get; set; }

    public double? Otrate { get; set; }

    public double? TotalOtamount { get; set; }

    public double? LunchAllowance { get; set; }

    public double? AttendanceBonus { get; set; }

    public double? AdvanceDeduction { get; set; }

    public double? LoanDeduction { get; set; }

    public double? NetPayable { get; set; }

    public short? Stampdeduct { get; set; }

    public double? TotalSalary { get; set; }

    public string DsgName { get; set; } = null!;

    public short? EmpTypeId { get; set; }

    public string? EmpId { get; set; }

    public string? EmpStatus { get; set; }

    public string? EmpStatusName { get; set; }

    public string? DptName { get; set; }

    public string? DptNameBn { get; set; }

    public string? GrdName { get; set; }

    public double? OthersAllownce { get; set; }

    public string? DptId { get; set; }

    public string? DsgNameBn { get; set; }

    public string? GrdNameBangla { get; set; }

    public short? IsSeperationGeneration { get; set; }

    public long Sl { get; set; }

    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? SftId { get; set; }

    public string SftName { get; set; } = null!;

    public int Staff { get; set; }

    public int Worker { get; set; }

    public double? TechnicalAllowance { get; set; }

    public DateOnly? YearMonth { get; set; }

    public short? OfficialLeave { get; set; }

    public short? OthersLeave { get; set; }

    public double? ProvidentFund { get; set; }

    public double? ProfitTax { get; set; }

    public string? Address { get; set; }

    public string? EmpName { get; set; }

    public string? EmpCardNo { get; set; }

    public DateOnly? EmpJoiningDate { get; set; }

    public string SalaryCount { get; set; } = null!;

    public string? BankName { get; set; }

    public string? EmpNameBn { get; set; }

    public string? CompanyNameBangla { get; set; }

    public short? CustomOrdering { get; set; }

    public string? EmpAccountNo { get; set; }

    public string? AddressBangla { get; set; }

    public double? OthourForBuyer { get; set; }

    public double? OtamountForBuyer { get; set; }

    public double? ExtraOthour { get; set; }

    public double? ExtraOtamount { get; set; }

    public double? NetPayableWithAllOtamt { get; set; }

    public short? IsActive { get; set; }

    public short? Gid { get; set; }

    public string? Gname { get; set; }

    public int? LateDays { get; set; }

    public double? LateFine { get; set; }

    public int? TiffinDays { get; set; }

    public double? TiffinTaka { get; set; }

    public int? HolidayWorkingDays { get; set; }

    public double? HolidayTaka { get; set; }

    public double? TiffinBillAmount { get; set; }

    public double? HoliDayBillAmount { get; set; }

    public double? DormitoryRent { get; set; }

    public string? TotalOverTime { get; set; }

    public string? TotalOtherOverTime { get; set; }

    public double? OthersPay { get; set; }

    public double? OthersDeduction { get; set; }

    public short? ShortLeave { get; set; }

    public DateOnly? PfDate { get; set; }

    public bool? PfMember { get; set; }

    public short? NightBillDays { get; set; }

    public double? NightbilAmount { get; set; }

    public short? Activeday { get; set; }

    public double? EmpNetGross { get; set; }

    public string? EmpProximityNo { get; set; }

    public string? DptCode { get; set; }
}
