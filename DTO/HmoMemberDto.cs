using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HmoMemberDto
    {
        public int UserId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;
        [Required]
        [RegularExpression("^[0-9]{9}$", ErrorMessage = "The field must contain exactly 9 digits.")]
        public string IdentityNumber { get; set; } = null!;

        public string City { get; set; } = null!;

        public string Street { get; set; } = null!;

        public int StreetNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "The field must contain only digits.")]
        public string Phone { get; set; } = null!;
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "The field must contain exactly 10 digits.")]
        public string MobilePone { get; set; } = null!;
        [Required]
        [DataType(DataType.Date)]
        public DateTime? PositiveResultDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DiseaseRecoveryDate { get; set; }

        public string? ImgUrl { get; set; }
    }
}
