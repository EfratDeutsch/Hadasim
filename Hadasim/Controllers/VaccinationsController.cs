using AutoMapper;
using DTO;
using Entities.DBModels;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hadasim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinationsController : ControllerBase
    {
        private readonly IVaccinationsService _IvaccinationsServide;
        private readonly IMapper _IMapper;

        public VaccinationsController(IVaccinationsService IvaccinationsServide,IMapper IMapper)
        {
            _IvaccinationsServide = IvaccinationsServide;
            _IMapper = IMapper;
        }
        // GET: api/<VaccinationsController>
        [HttpGet]
        public async Task< IEnumerable<Vaccination>> Get()
        {
            IEnumerable <Vaccination> vaccinList = await _IvaccinationsServide.GetAllVaccin();
            if (vaccinList != null)
                return vaccinList;
            else return null;
        }

        // GET api/<VaccinationsController>/5
        [HttpGet("{id}")]
        public async Task <IEnumerable<Vaccination>> Get(string id)
        {
            IEnumerable<Vaccination> vaccinList = await _IvaccinationsServide.getVaccinById(id);
            if (vaccinList != null)
                return vaccinList;
            else return null;
        }

        // POST api/<VaccinationsController>
        [HttpPost]
        public async Task<ActionResult<VaccinationDto>> Post([FromBody] VaccinationDto vaccin)
        {
            Vaccination regularVAccin= _IMapper.Map<VaccinationDto, Vaccination>(vaccin);
            Vaccination theVacin = await _IvaccinationsServide.addVaccin(regularVAccin);
            VaccinationDto goodvaccin= _IMapper.Map<Vaccination, VaccinationDto>(theVacin);

            if (goodvaccin!= null)
                return goodvaccin;
            else return null;

        }

     

    }
}
