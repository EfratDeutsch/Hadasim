using Entities.DBModels;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class VaccinationsService : IVaccinationsService
    {
        private readonly IVaccinationsRepository _IVaccinationsRepository;
        public VaccinationsService(IVaccinationsRepository IVaccinationsRepository)
        {
            _IVaccinationsRepository = IVaccinationsRepository;
        }
        public async Task<IEnumerable<Vaccination>> GetAllVaccin()
        {
          return  await _IVaccinationsRepository.GetAllVaccin();
           
        }
        public async Task <IEnumerable<Vaccination>> getVaccinById(string id)
        {
            IEnumerable<Vaccination> vaccinList = await _IVaccinationsRepository.getVaccinById(id);
            if (vaccinList != null)
                return vaccinList;
            else return null;

        }
        public async Task<Vaccination> addVaccin(Vaccination vaccin)
        {
            Vaccination goodVAcin = await _IVaccinationsRepository.addVaccin(vaccin);
            if (goodVAcin != null)
                return goodVAcin;
            else return null;
        }
        
    }
}
