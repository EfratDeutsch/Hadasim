using Entities.DBModels;

namespace Repository
{
    public interface IMemberRepository
    {
        Task<IEnumerable<HmoMember>> GetAllMembers();
    }
}