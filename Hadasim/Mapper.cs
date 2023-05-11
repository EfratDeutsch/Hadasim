using AutoMapper;
using DTO;

using Entities.DBModels;

namespace Hadasim
{
    public class Mapper : Profile
    {
        public Mapper()
        {

            CreateMap<HmoMember, HmoMemberDto>().ReverseMap();
            CreateMap<Vaccination, VaccinationDto>().ReverseMap();

        }

    }
}