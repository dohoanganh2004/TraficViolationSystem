using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TrafficViolation.DAL.Models;

public partial class TrafficViolationContext : DbContext
{
    public TrafficViolationContext()
    {
    }

    public TrafficViolationContext(DbContextOptions<TrafficViolationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<Complaint> Complaints { get; set; }

    public virtual DbSet<DriverLicense> DriverLicenses { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<Violation> Violations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-7KQPR9J;uid=sa;password=123456;database=TrafficViolation;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__AuditLog__5E5499A886A2A808");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.Action).HasMaxLength(255);
            entity.Property(e => e.ActionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.AuditLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__AuditLogs__UserI__7D439ABD");
        });

        modelBuilder.Entity<Complaint>(entity =>
        {
            entity.HasKey(e => e.ComplaintId).HasName("PK__Complain__740D89AFE62D68D1");

            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.ComplaintDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ReportId).HasColumnName("ReportID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Chờ xử lý");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.ViolationId).HasColumnName("ViolationID");

            entity.HasOne(d => d.ProcessedByNavigation).WithMany(p => p.ComplaintProcessedByNavigations)
                .HasForeignKey(d => d.ProcessedBy)
                .HasConstraintName("FK__Complaint__Proce__75A278F5");

            entity.HasOne(d => d.Report).WithMany(p => p.Complaints)
                .HasForeignKey(d => d.ReportId)
                .HasConstraintName("FK__Complaint__Repor__73BA3083");

            entity.HasOne(d => d.User).WithMany(p => p.ComplaintUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Complaint__UserI__72C60C4A");

            entity.HasOne(d => d.Violation).WithMany(p => p.Complaints)
                .HasForeignKey(d => d.ViolationId)
                .HasConstraintName("FK__Complaint__Viola__74AE54BC");
        });

        modelBuilder.Entity<DriverLicense>(entity =>
        {
            entity.HasKey(e => e.LicenseId).HasName("PK__DriverLi__72D600A29E4E0629");

            entity.HasIndex(e => e.LicenseNumber, "UQ__DriverLi__E88901661DC3C422").IsUnique();

            entity.Property(e => e.LicenseId).HasColumnName("LicenseID");
            entity.Property(e => e.IssuingAuthority).HasMaxLength(100);
            entity.Property(e => e.LicenseClass).HasMaxLength(10);
            entity.Property(e => e.LicenseNumber).HasMaxLength(20);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.DriverLicenses)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DriverLic__UserI__797309D9");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Notifica__20CF2E324A51DFA1");

            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.IsRead).HasDefaultValue(false);
            entity.Property(e => e.PlateNumber).HasMaxLength(15);
            entity.Property(e => e.SentDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.PlateNumberNavigation).WithMany(p => p.Notifications)
                .HasPrincipalKey(p => p.PlateNumber)
                .HasForeignKey(d => d.PlateNumber)
                .HasConstraintName("FK__Notificat__Plate__656C112C");

            entity.HasOne(d => d.User).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Notificat__UserI__6477ECF3");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payments__9B556A58BC2B5A77");

            entity.HasIndex(e => e.TransactionId, "UQ__Payments__55433A4A13FD6C47").IsUnique();

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PaymentDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PaymentMethod).HasMaxLength(50);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(20)
                .HasDefaultValue("Chờ xử lý");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TransactionID");
            entity.Property(e => e.ViolationId).HasColumnName("ViolationID");

            entity.HasOne(d => d.Violation).WithMany(p => p.Payments)
                .HasForeignKey(d => d.ViolationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Payments__Violat__6D0D32F4");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PK__Reports__D5BD48E543512778");

            entity.Property(e => e.ReportId).HasColumnName("ReportID");
            entity.Property(e => e.ImageUrl).HasColumnName("ImageURL");
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.PlateNumber).HasMaxLength(15);
            entity.Property(e => e.ReportDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ReporterId).HasColumnName("ReporterID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Chờ xử lý");
            entity.Property(e => e.VideoUrl).HasColumnName("VideoURL");
            entity.Property(e => e.ViolationType).HasMaxLength(50);

            entity.HasOne(d => d.PlateNumberNavigation).WithMany(p => p.Reports)
                .HasPrincipalKey(p => p.PlateNumber)
                .HasForeignKey(d => d.PlateNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reports__PlateNu__59063A47");

            entity.HasOne(d => d.ProcessedByNavigation).WithMany(p => p.ReportProcessedByNavigations)
                .HasForeignKey(d => d.ProcessedBy)
                .HasConstraintName("FK__Reports__Process__5812160E");

            entity.HasOne(d => d.Reporter).WithMany(p => p.ReportReporters)
                .HasForeignKey(d => d.ReporterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reports__Reporte__571DF1D5");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE3ACA9CB7C8");

            entity.HasIndex(e => e.RoleName, "UQ__Roles__8A2B6160D8ED450C").IsUnique();

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(20);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC968E9684");

            entity.HasIndex(e => e.Email, "UQ__Users__A9D10534D19EADD2").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(15);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Users__RoleID__4D94879B");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.VehicleId).HasName("PK__Vehicles__476B54B2686BC5D7");

            entity.HasIndex(e => e.PlateNumber, "UQ__Vehicles__03692624E032E007").IsUnique();

            entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");
            entity.Property(e => e.PlateNumber).HasMaxLength(15);

            entity.HasOne(d => d.Owner).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Vehicles__OwnerI__5165187F");
        });

        modelBuilder.Entity<Violation>(entity =>
        {
            entity.HasKey(e => e.ViolationId).HasName("PK__Violatio__18B6DC28B53F8961");

            entity.Property(e => e.ViolationId).HasColumnName("ViolationID");
            entity.Property(e => e.FineAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.FineDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PaidStatus).HasDefaultValue(false);
            entity.Property(e => e.PlateNumber).HasMaxLength(15);
            entity.Property(e => e.ReportId).HasColumnName("ReportID");
            entity.Property(e => e.ViolatorId).HasColumnName("ViolatorID");

            entity.HasOne(d => d.PlateNumberNavigation).WithMany(p => p.Violations)
                .HasPrincipalKey(p => p.PlateNumber)
                .HasForeignKey(d => d.PlateNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Violation__Plate__5EBF139D");

            entity.HasOne(d => d.Report).WithMany(p => p.Violations)
                .HasForeignKey(d => d.ReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Violation__Repor__5DCAEF64");

            entity.HasOne(d => d.Violator).WithMany(p => p.Violations)
                .HasForeignKey(d => d.ViolatorId)
                .HasConstraintName("FK__Violation__Viola__5FB337D6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
