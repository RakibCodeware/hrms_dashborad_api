using System;
using System.Collections.Generic;

namespace Hrms_api.Data;

public partial class VHrdCompanyInfo
{
    public short? BusinessType { get; set; }

    public string? BtypeName { get; set; }

    public string CompanyId { get; set; } = null!;

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? CompanyNameBangla { get; set; }

    public string? AddressBangla { get; set; }

    public string? Country { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public string? DefaultCurrency { get; set; }

    public bool? MultipleBranch { get; set; }

    public string? Comments { get; set; }

    public string? CompanyLogo { get; set; }

    public short Id { get; set; }

    public string? StartCardNo { get; set; }

    public string? Weekend { get; set; }

    public string? ShortName { get; set; }

    public string? ComType { get; set; }

    public string? AttMachineName { get; set; }
}
