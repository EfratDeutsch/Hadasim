using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        [DataType(DataType.Date)]
        public DateTime VaccinDate { get; set; }
        [Required]
        [RegularExpression("^[0-9]{9}$", ErrorMessage = "The field must contain exactly 9 digits.")]
        public string IdentityNumber { get; set; } = null!;
    }
}
