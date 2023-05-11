using System;
using System.Collections.Generic;
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

        public string IdentityNumber { get; set; } = null!;

        public string City { get; set; } = null!;

        public string Street { get; set; } = null!;

        public int StreetNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Phone { get; set; } = null!;

        public string MobilePone { get; set; } = null!;

        public DateTime? PositiveResultDate { get; set; }

        public DateTime? DiseaseRecoveryDate { get; set; }

        public string? ImgUrl { get; set; }
    }
}
