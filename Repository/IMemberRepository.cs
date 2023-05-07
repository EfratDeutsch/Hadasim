using Entities.DBModels;

namespace Repository
{
    public interface IMemberRepository
    {
        Task<IEnumerable<HmoMember>> GetAllMembers();
        Task<HmoMember> addMember(HmoMember member);
    }
}