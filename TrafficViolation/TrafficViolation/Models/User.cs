﻿using System;
using System.Collections.Generic;

namespace TrafficViolation.Models;

public partial class User
{
    public int UserId { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public string Phone { get; set; } = null!;

    public string? Address { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<Complaint> ComplaintProcessedByNavigations { get; set; } = new List<Complaint>();

    public virtual ICollection<Complaint> ComplaintUsers { get; set; } = new List<Complaint>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<Report> ReportProcessedByNavigations { get; set; } = new List<Report>();

    public virtual ICollection<Report> ReportReporters { get; set; } = new List<Report>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

    public virtual ICollection<Violation> Violations { get; set; } = new List<Violation>();
}
