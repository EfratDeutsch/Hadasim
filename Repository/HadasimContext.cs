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

    public virtual DbSet<MembersVaccinnation> MembersVaccinnations { get; set; }

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
            entity.Property(e => e.DateOfBirth).HasColumnName("dateOfBirth");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("firstName");
            entity.Property(e => e.FirstVaccineDate).HasColumnName("firstVaccineDate");
            entity.Property(e => e.FirstVaccineManufacturer)
                .HasMaxLength(50)
                .HasColumnName("firstVaccineManufacturer");
            entity.Property(e => e.FourthVaccineDate).HasColumnName("fourthVaccineDate");
            entity.Property(e => e.FourthVaccineManufacturer)
                .HasMaxLength(50)
                .HasColumnName("fourthVaccineManufacturer");
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
            entity.Property(e => e.PositiveResultDate).HasColumnName("positiveResultDate");
            entity.Property(e => e.SecondVaccineDate).HasColumnName("secondVaccineDate");
            entity.Property(e => e.SecondVaccineManufacturer)
                .HasMaxLength(50)
                .HasColumnName("secondVaccineManufacturer");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .HasColumnName("street");
            entity.Property(e => e.StreetNumber).HasColumnName("streetNumber");
            entity.Property(e => e.ThirdVaccineDate).HasColumnName("thirdVaccineDate");
            entity.Property(e => e.ThirdVaccineManufacturer)
                .HasMaxLength(50)
                .HasColumnName("thirdVaccineManufacturer");
        });

        modelBuilder.Entity<MembersVaccinnation>(entity =>
        {
            entity.ToTable("MEMBERS_VACCINNATIONS");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsFirstVaccinId).HasColumnName("isFirstVaccinId");
            entity.Property(e => e.IsFourthVaccinId).HasColumnName("isFourthVaccinId");
            entity.Property(e => e.IsSecondVaccinId).HasColumnName("isSecondVaccinId");
            entity.Property(e => e.IsThirdVaccinId).HasColumnName("isThirdVaccinId");
            entity.Property(e => e.NumbersOfVaccin).HasColumnName("numbersOfVaccin");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<Vaccination>(entity =>
        {
            entity.HasKey(e => e.VaccinId);

            entity.ToTable("VACCINATIONS");

            entity.Property(e => e.VaccinId).HasColumnName("vaccinId");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(50)
                .HasColumnName("manufacturer");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
