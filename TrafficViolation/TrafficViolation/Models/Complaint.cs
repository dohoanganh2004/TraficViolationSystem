using System;
using System.Collections.Generic;

namespace TrafficViolation.Models;

public partial class Complaint
{
    public int ComplaintId { get; set; }

    public int UserId { get; set; }

    public int? ReportId { get; set; }

    public int? ViolationId { get; set; }

    public string ComplaintText { get; set; } = null!;

    public DateTime? ComplaintDate { get; set; }

    public string? Status { get; set; }

    public int? ProcessedBy { get; set; }

    public virtual User? ProcessedByNavigation { get; set; }

    public virtual Report? Report { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual Violation? Violation { get; set; }
}
