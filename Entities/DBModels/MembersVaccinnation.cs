using System;
using System.Collections.Generic;

namespace Entities.DBModels;

public partial class MembersVaccinnation
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public bool? IsFirstVaccinId { get; set; }

    public bool? IsSecondVaccinId { get; set; }

    public bool? IsThirdVaccinId { get; set; }

    public bool? IsFourthVaccinId { get; set; }

    public int? NumbersOfVaccin { get; set; }
}
//ghjghjghj