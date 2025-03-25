using System;
using System.Collections.Generic;

namespace TrafficViolation.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int ViolationId { get; set; }

    public decimal PaymentAmount { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string? TransactionId { get; set; }

    public string? PaymentStatus { get; set; }

    public virtual Violation Violation { get; set; } = null!;
}
