using System;
using System.Collections.Generic;

namespace Entities.DBModels;

public partial class HmoMember
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string IdentityNumber { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int StreetNumber { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public string Phone { get; set; } = null!;

    public string MobilePone { get; set; } = null!;

    public DateOnly? FirstVaccineDate { get; set; }

    public DateOnly? SecondVaccineDate { get; set; }

    public DateOnly? ThirdVaccineDate { get; set; }

    public DateOnly? FourthVaccineDate { get; set; }

    public string? FirstVaccineManufacturer { get; set; }

    public string? SecondVaccineManufacturer { get; set; }

    public string? ThirdVaccineManufacturer { get; set; }

    public string? FourthVaccineManufacturer { get; set; }

    public DateOnly? PositiveResultDate { get; set; }

    public DateOnly? DiseaseRecoveryDate { get; set; }

    public string? ImgUrl { get; set; }
}
