using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entities.DBModels;

public partial class Vaccination
{
    public int VaccinId { get; set; }

    public string Manufacturer { get; set; } = null!;

    public int UserId { get; set; }

    public int VaccinNum { get; set; }

    public DateTime VaccinDate { get; set; }

    public string IdentityNumber { get; set; } = null!;
  
    
    public virtual HmoMember User { get; set; } = null!;
}
