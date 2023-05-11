using Entities.DBModels;

namespace Services
{
    public interface IVaccinationsService
    {
        Task<IEnumerable<Vaccination>> GetAllVaccin();
        Task<IEnumerable<Vaccination>> getVaccinById(string id);
        Task<Vaccination> addVaccin(Vaccination vaccin);
    }
}