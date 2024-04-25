using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class HrdCompanyInfo
{
    public string CompanyId { get; set; } = null!;

    public bool? CompanyType { get; set; }

    public string? HeadOfficeId { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyNameBangla { get; set; }

    public string? Address { get; set; }

    public string? AddressBangla { get; set; }

    public string? Country { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public string? DefaultCurrency { get; set; }

    public short? BusinessType { get; set; }

    public bool? MultipleBranch { get; set; }

    public string? Comments { get; set; }

    public string? CompanyLogo { get; set; }

    public short Id { get; set; }

    public string? StartCardNo { get; set; }

    public string? Weekend { get; set; }

    public string? ShortName { get; set; }

    public bool? CardNoType { get; set; }

    public short? FlatCode { get; set; }

    public short? CardNoDigits { get; set; }

    public string? AttMachineName { get; set; }

    public DateOnly? PfcountDate { get; set; }

    public bool? IsLeaveAuthority { get; set; }

    public bool? IsOdauthority { get; set; }

    public virtual ICollection<PayrollAdvanceInfo> PayrollAdvanceInfos { get; set; } = new List<PayrollAdvanceInfo>();

    public virtual ICollection<PayrollBonusSetup1> PayrollBonusSetup1s { get; set; } = new List<PayrollBonusSetup1>();

    public virtual ICollection<PayrollBonusSetup> PayrollBonusSetups { get; set; } = new List<PayrollBonusSetup>();

    public virtual ICollection<TblHolydayWork1> TblHolydayWork1s { get; set; } = new List<TblHolydayWork1>();

    public virtual ICollection<TblHolydayWork> TblHolydayWorks { get; set; } = new List<TblHolydayWork>();

    public virtual ICollection<TblLeaveConfig> TblLeaveConfigs { get; set; } = new List<TblLeaveConfig>();
}
