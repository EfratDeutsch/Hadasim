using Entities.DBModels;

namespace Repository
{
    public interface IVaccinationsRepository
    {
        Task<IEnumerable<Vaccination>> GetAllVaccin();
        Task<IEnumerable<Vaccination>> getVaccinById(string id);
        Task<Vaccination> addVaccin(Vaccination vaccin);
    }
}