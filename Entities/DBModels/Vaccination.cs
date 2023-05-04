using System;
using System.Collections.Generic;

namespace Entities.DBModels;

public partial class Vaccination
{
    public int VaccinId { get; set; }

    public string Manufacturer { get; set; } = null!;
}
