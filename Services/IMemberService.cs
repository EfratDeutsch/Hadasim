using Entities.DBModels;

namespace Services
{
    public interface IMemberService
    {
        Task<IEnumerable<HmoMember>> GetAllMembers();
        Task<HmoMember> addMember(HmoMember member);
    }
}