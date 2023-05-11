using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.DBModels;

public partial class HmoMember
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
    [Required]
    public string IdentityNumber { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int StreetNumber { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string Phone { get; set; } = null!;

    public string MobilePone { get; set; } = null!;
    [Required]
    [DataType(DataType.Date)]
    public DateTime? PositiveResultDate { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime? DiseaseRecoveryDate { get; set; }

    public string? ImgUrl { get; set; }

    public virtual ICollection<Vaccination> Vaccinations { get; set; } = new List<Vaccination>();
}
