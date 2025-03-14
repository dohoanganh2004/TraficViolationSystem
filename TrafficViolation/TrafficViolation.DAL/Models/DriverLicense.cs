using System;
using System.Collections.Generic;

namespace TrafficViolation.DAL.Models;

public partial class DriverLicense
{
    public int LicenseId { get; set; }

    public int UserId { get; set; }

    public string LicenseNumber { get; set; } = null!;

    public DateOnly IssueDate { get; set; }

    public DateOnly ExpiryDate { get; set; }

    public string? LicenseClass { get; set; }

    public string? IssuingAuthority { get; set; }

    public virtual User User { get; set; } = null!;
}
