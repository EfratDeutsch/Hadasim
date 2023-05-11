using Entities.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class VaccinationsRepository : IVaccinationsRepository
    {
        private readonly HadasimContext _HadasimContext;
        public VaccinationsRepository(HadasimContext hadasimContext)
        {
            _HadasimContext = hadasimContext;
        }
        public async Task<IEnumerable<Vaccination>> GetAllVaccin()
        {
            IEnumerable<Vaccination> vaccinList = await _HadasimContext.Vaccinations.ToListAsync();

                return vaccinList;
            

        }
        public async Task <IEnumerable<Vaccination>> getVaccinById(string id)
        {
            var query = _HadasimContext.Vaccinations.Where(vaccin =>
                  (vaccin.IdentityNumber == id)
              );

            IEnumerable<Vaccination> vaccins = await query.ToListAsync();
            return vaccins;
        }
        public async Task <Vaccination> addVaccin(Vaccination vaccin)
        {
            
            var member = _HadasimContext.HmoMembers.Where(m => m.IdentityNumber == vaccin.IdentityNumber).FirstOrDefault();
            vaccin.UserId = member.UserId;
            await _HadasimContext.AddAsync(vaccin);
            await _HadasimContext.SaveChangesAsync();
            return vaccin;
        }
    }
}
