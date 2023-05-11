using Entities.DBModels;

namespace Services
{
    public interface IMemberService
    {
        Task<IEnumerable<HmoMember>> GetAllMembers(); 
        Task<HmoMember> getMemberBYId(string id);
        Task<int> getNumOfNotImmuneMembers();
        Task<Dictionary<DateTime, int>> getNumOfActivePatients();
        Task<HmoMember> addMember(HmoMember member);
       
    }
}