using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entities.DBModels;

public partial class HadasimContext : DbContext
{
    public HadasimContext()
    {
    }

    public HadasimContext(DbContextOptions<HadasimContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HmoMember> HmoMembers { get; set; }

    public virtual DbSet<Vaccination> Vaccinations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-IO6UM71; Initial Catalog = Hadasim; Integrated Security = True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HmoMember>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("HMO_MEMBERS");

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("dateOfBirth");
            entity.Property(e => e.DiseaseRecoveryDate)
                .HasColumnType("datetime")
                .HasColumnName("diseaseRecoveryDate");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("firstName");
            entity.Property(e => e.IdentityNumber)
                .HasMaxLength(50)
                .HasColumnName("identityNumber");
            entity.Property(e => e.ImgUrl)
                .HasMaxLength(50)
                .HasColumnName("imgUrl");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("lastName");
            entity.Property(e => e.MobilePone)
                .HasMaxLength(50)
                .HasColumnName("mobilePone");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.PositiveResultDate)
                .HasColumnType("datetime")
                .HasColumnName("positiveResultDate");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasColumnName("street");
            entity.Property(e => e.StreetNumber).HasColumnName("streetNumber");
        });

        modelBuilder.Entity<Vaccination>(entity =>
        {
            entity.HasKey(e => e.VaccinId);

            entity.ToTable("VACCINATIONS");

            entity.Property(e => e.VaccinId).HasColumnName("vaccinId");
            entity.Property(e => e.IdentityNumber)
                .HasMaxLength(50)
                .HasColumnName("identityNumber");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(50)
                .HasColumnName("manufacturer");
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.VaccinDate).HasColumnName("vaccinDate");
            entity.Property(e => e.VaccinNum).HasColumnName("vaccinNum");

            entity.HasOne(d => d.User).WithMany(p => p.Vaccinations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VACCINATI__userI__3E52440B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
