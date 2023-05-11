using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaccinationDto
    {
        public int VaccinId { get; set; }

        public string Manufacturer { get; set; } = null!;

        public int UserId { get; set; }

        public int VaccinNum { get; set; }

        public DateTime VaccinDate { get; set; }

        public string IdentityNumber { get; set; } = null!;
    }
}
